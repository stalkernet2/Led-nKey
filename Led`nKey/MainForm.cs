using OpenHardwareMonitor.Hardware;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Led_nKey
{
    public partial class MainForm : Form
    {
        private readonly TheRealComputer _thisPC;
        private bool _firstStart = true;
        private int _threadClock = 100;

        public MainForm()
        {
            InitializeComponent();

            ClockBox.Text = _threadClock.ToString();
            Device.USB = new Device();
            _thisPC = new TheRealComputer();

            _thisPC.GetInfoBySensors(SensorType.Temperature);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Minimized;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Minimized)
                return;

            this.Hide();

            if (!_firstStart)
                return;

            Notify.Text = this.Text;
            Notify.BalloonTipIcon = ToolTipIcon.None;
            Notify.BalloonTipTitle = "Я тут!";
            Notify.BalloonTipText = "Приложение было свернуто";
            Notify.ShowBalloonTip(0);

            _firstStart = false;
        }

        private void ClockBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void ClockBox_TextChanged(object sender, EventArgs e)
        {
            _threadClock = int.Parse(ClockBox.Text == "" ? "1000" : ClockBox.Text);
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (Device.USB.IsConnected)
            {
                MirrorWorker.CancelAsync();
                Device.USB.CloseConnection();
                ConnectButton.Text = "Connect!";
                return;
            }

            if (PortPicker.SelectedIndex == -1)
            {
                MessageBox.Show("Port not selected!","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Device.USB.MakeConnection((string)PortPicker.Items[PortPicker.SelectedIndex]);

            if (!Device.USB.IsConnected)
                return;

            MirrorWorker.RunWorkerAsync();

            if(Device.USB.IsConnected)
                ConnectButton.Text = "Connected!";
        }

        private void PortPickerPressed(object sender, EventArgs e)
        {
            PortPicker.Items.Clear();
            var availablePorts = Device.GetPortNames();

            for (int i = 0; i < availablePorts.Length; i++)
                PortPicker.Items.Add(availablePorts[i]);
        }

        private void TempCheckBoxChanged(object sender, EventArgs e)
        {
            if (!((CheckBox)sender).Checked)
                return;

            _threadClock = 100;

            TextBox.Checked = false;
            TemperatureGroup.Enabled = true;
            TextGroup.Enabled = false;
        }

        private void TextCheckBoxChanged(object sender, EventArgs e)
        {
            if (!((CheckBox)sender).Checked)
                return;

            _threadClock = 500;

            TemperatureBox.Checked = false;
            TemperatureGroup.Enabled = false;
            TextGroup.Enabled = true;
        }

        private void Notify_Click(object sender, EventArgs e)
        {
            this.Show();
            WindowState = FormWindowState.Normal;
            this.Focus();
        }

        private void MirrorWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = new Worker();
            while (!MirrorWorker.CancellationPending)
            {
                if (TemperatureBox.Checked)
                {
                    worker.SendTemperatureAndLoadOfCpuAndGpu(_thisPC, out float tempCPU, out float tempGPU, out float loadCPU, out float loadGPU);

                    if (this.WindowState == FormWindowState.Minimized)
                    {
                        Thread.Sleep(_threadClock);
                        continue;
                    }

                    InvokingStuff.SetText(StringStuff.CeilingAndDesignating(tempCPU, "°C"), TempCPULabel);
                    InvokingStuff.SetText(StringStuff.CeilingAndDesignating(tempGPU, "°C"), TempGPULabel);

                    InvokingStuff.SetText(StringStuff.CeilingAndDesignating(loadCPU, "%"), LoadCPULabel);
                    InvokingStuff.SetText(StringStuff.CeilingAndDesignating(loadGPU, "%"), LoadGPULabel);
                }

                if (TextBox.Checked)
                {
                    worker.SendText(TextBoxSender.Text);
                }
                Thread.Sleep(_threadClock);
            }
        }
    }
}
