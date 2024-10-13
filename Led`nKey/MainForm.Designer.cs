namespace Led_nKey
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.SettingsBox = new System.Windows.Forms.GroupBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.ShowBox = new System.Windows.Forms.GroupBox();
            this.TemperatureBox = new System.Windows.Forms.CheckBox();
            this.TextBox = new System.Windows.Forms.CheckBox();
            this.PortPicker = new System.Windows.Forms.ComboBox();
            this.PortLabel = new System.Windows.Forms.Label();
            this.MirrorWorker = new System.ComponentModel.BackgroundWorker();
            this.TemperatureGroup = new System.Windows.Forms.GroupBox();
            this.ClockBox = new System.Windows.Forms.TextBox();
            this.ClockLabel = new System.Windows.Forms.Label();
            this.LGPU = new System.Windows.Forms.Label();
            this.LCPU = new System.Windows.Forms.Label();
            this.TGPU = new System.Windows.Forms.Label();
            this.TCPU = new System.Windows.Forms.Label();
            this.LoadGPULabel = new System.Windows.Forms.Label();
            this.LoadCPULabel = new System.Windows.Forms.Label();
            this.TempGPULabel = new System.Windows.Forms.Label();
            this.TempCPULabel = new System.Windows.Forms.Label();
            this.TextGroup = new System.Windows.Forms.GroupBox();
            this.TextBoxSender = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tM1638ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onStartupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kS0108ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsBox.SuspendLayout();
            this.ShowBox.SuspendLayout();
            this.TemperatureGroup.SuspendLayout();
            this.TextGroup.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Notify
            // 
            this.Notify.Icon = ((System.Drawing.Icon)(resources.GetObject("Notify.Icon")));
            this.Notify.Text = "Notify";
            this.Notify.Visible = true;
            this.Notify.Click += new System.EventHandler(this.Notify_Click);
            // 
            // SettingsBox
            // 
            this.SettingsBox.Controls.Add(this.ConnectButton);
            this.SettingsBox.Controls.Add(this.ShowBox);
            this.SettingsBox.Controls.Add(this.PortPicker);
            this.SettingsBox.Controls.Add(this.PortLabel);
            this.SettingsBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsBox.Location = new System.Drawing.Point(12, 27);
            this.SettingsBox.Name = "SettingsBox";
            this.SettingsBox.Size = new System.Drawing.Size(170, 171);
            this.SettingsBox.TabIndex = 0;
            this.SettingsBox.TabStop = false;
            this.SettingsBox.Text = "Settings";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(6, 139);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(158, 26);
            this.ConnectButton.TabIndex = 5;
            this.ConnectButton.Text = "Connect!";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // ShowBox
            // 
            this.ShowBox.Controls.Add(this.TemperatureBox);
            this.ShowBox.Controls.Add(this.TextBox);
            this.ShowBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowBox.Location = new System.Drawing.Point(9, 46);
            this.ShowBox.Name = "ShowBox";
            this.ShowBox.Size = new System.Drawing.Size(153, 68);
            this.ShowBox.TabIndex = 4;
            this.ShowBox.TabStop = false;
            this.ShowBox.Text = "Show";
            // 
            // TemperatureBox
            // 
            this.TemperatureBox.AutoSize = true;
            this.TemperatureBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TemperatureBox.Location = new System.Drawing.Point(6, 22);
            this.TemperatureBox.Name = "TemperatureBox";
            this.TemperatureBox.Size = new System.Drawing.Size(92, 19);
            this.TemperatureBox.TabIndex = 2;
            this.TemperatureBox.Text = "Temperature";
            this.TemperatureBox.UseVisualStyleBackColor = true;
            this.TemperatureBox.CheckedChanged += new System.EventHandler(this.TempCheckBoxChanged);
            // 
            // TextBox
            // 
            this.TextBox.AutoSize = true;
            this.TextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox.Location = new System.Drawing.Point(6, 42);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(47, 19);
            this.TextBox.TabIndex = 3;
            this.TextBox.Text = "Text";
            this.TextBox.UseVisualStyleBackColor = true;
            this.TextBox.CheckedChanged += new System.EventHandler(this.TextCheckBoxChanged);
            // 
            // PortPicker
            // 
            this.PortPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortPicker.FormattingEnabled = true;
            this.PortPicker.Location = new System.Drawing.Point(41, 19);
            this.PortPicker.Name = "PortPicker";
            this.PortPicker.Size = new System.Drawing.Size(121, 23);
            this.PortPicker.TabIndex = 1;
            this.PortPicker.DropDown += new System.EventHandler(this.PortPickerPressed);
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PortLabel.Location = new System.Drawing.Point(6, 22);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(32, 15);
            this.PortLabel.TabIndex = 0;
            this.PortLabel.Text = "Port:";
            // 
            // MirrorWorker
            // 
            this.MirrorWorker.WorkerSupportsCancellation = true;
            this.MirrorWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.MirrorWorker_DoWork);
            // 
            // TemperatureGroup
            // 
            this.TemperatureGroup.Controls.Add(this.ClockBox);
            this.TemperatureGroup.Controls.Add(this.ClockLabel);
            this.TemperatureGroup.Controls.Add(this.LGPU);
            this.TemperatureGroup.Controls.Add(this.LCPU);
            this.TemperatureGroup.Controls.Add(this.TGPU);
            this.TemperatureGroup.Controls.Add(this.TCPU);
            this.TemperatureGroup.Controls.Add(this.LoadGPULabel);
            this.TemperatureGroup.Controls.Add(this.LoadCPULabel);
            this.TemperatureGroup.Controls.Add(this.TempGPULabel);
            this.TemperatureGroup.Controls.Add(this.TempCPULabel);
            this.TemperatureGroup.Enabled = false;
            this.TemperatureGroup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TemperatureGroup.Location = new System.Drawing.Point(189, 27);
            this.TemperatureGroup.Name = "TemperatureGroup";
            this.TemperatureGroup.Size = new System.Drawing.Size(188, 171);
            this.TemperatureGroup.TabIndex = 1;
            this.TemperatureGroup.TabStop = false;
            this.TemperatureGroup.Text = "Temperature and load";
            // 
            // ClockBox
            // 
            this.ClockBox.Location = new System.Drawing.Point(49, 22);
            this.ClockBox.Name = "ClockBox";
            this.ClockBox.Size = new System.Drawing.Size(45, 23);
            this.ClockBox.TabIndex = 9;
            this.ClockBox.TextChanged += new System.EventHandler(this.ClockBox_TextChanged);
            this.ClockBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClockBox_KeyPress);
            // 
            // ClockLabel
            // 
            this.ClockLabel.AutoSize = true;
            this.ClockLabel.Location = new System.Drawing.Point(6, 27);
            this.ClockLabel.Name = "ClockLabel";
            this.ClockLabel.Size = new System.Drawing.Size(40, 15);
            this.ClockLabel.TabIndex = 8;
            this.ClockLabel.Text = "Clock:";
            // 
            // LGPU
            // 
            this.LGPU.AutoSize = true;
            this.LGPU.Location = new System.Drawing.Point(6, 145);
            this.LGPU.Name = "LGPU";
            this.LGPU.Size = new System.Drawing.Size(39, 15);
            this.LGPU.TabIndex = 7;
            this.LGPU.Text = "LGPU:";
            // 
            // LCPU
            // 
            this.LCPU.AutoSize = true;
            this.LCPU.Location = new System.Drawing.Point(6, 130);
            this.LCPU.Name = "LCPU";
            this.LCPU.Size = new System.Drawing.Size(39, 15);
            this.LCPU.TabIndex = 6;
            this.LCPU.Text = "LCPU:";
            // 
            // TGPU
            // 
            this.TGPU.AutoSize = true;
            this.TGPU.Location = new System.Drawing.Point(6, 115);
            this.TGPU.Name = "TGPU";
            this.TGPU.Size = new System.Drawing.Size(38, 15);
            this.TGPU.TabIndex = 5;
            this.TGPU.Text = "TGPU:";
            // 
            // TCPU
            // 
            this.TCPU.AutoSize = true;
            this.TCPU.Location = new System.Drawing.Point(6, 100);
            this.TCPU.Name = "TCPU";
            this.TCPU.Size = new System.Drawing.Size(38, 15);
            this.TCPU.TabIndex = 4;
            this.TCPU.Text = "TCPU:";
            // 
            // LoadGPULabel
            // 
            this.LoadGPULabel.AutoSize = true;
            this.LoadGPULabel.Location = new System.Drawing.Point(50, 145);
            this.LoadGPULabel.Name = "LoadGPULabel";
            this.LoadGPULabel.Size = new System.Drawing.Size(13, 15);
            this.LoadGPULabel.TabIndex = 3;
            this.LoadGPULabel.Text = "0";
            // 
            // LoadCPULabel
            // 
            this.LoadCPULabel.AutoSize = true;
            this.LoadCPULabel.Location = new System.Drawing.Point(50, 130);
            this.LoadCPULabel.Name = "LoadCPULabel";
            this.LoadCPULabel.Size = new System.Drawing.Size(13, 15);
            this.LoadCPULabel.TabIndex = 2;
            this.LoadCPULabel.Text = "0";
            // 
            // TempGPULabel
            // 
            this.TempGPULabel.AutoSize = true;
            this.TempGPULabel.Location = new System.Drawing.Point(50, 115);
            this.TempGPULabel.Name = "TempGPULabel";
            this.TempGPULabel.Size = new System.Drawing.Size(13, 15);
            this.TempGPULabel.TabIndex = 1;
            this.TempGPULabel.Text = "0";
            // 
            // TempCPULabel
            // 
            this.TempCPULabel.AutoSize = true;
            this.TempCPULabel.Location = new System.Drawing.Point(50, 100);
            this.TempCPULabel.Name = "TempCPULabel";
            this.TempCPULabel.Size = new System.Drawing.Size(13, 15);
            this.TempCPULabel.TabIndex = 0;
            this.TempCPULabel.Text = "0";
            // 
            // TextGroup
            // 
            this.TextGroup.Controls.Add(this.TextBoxSender);
            this.TextGroup.Enabled = false;
            this.TextGroup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextGroup.Location = new System.Drawing.Point(12, 204);
            this.TextGroup.Name = "TextGroup";
            this.TextGroup.Size = new System.Drawing.Size(364, 164);
            this.TextGroup.TabIndex = 2;
            this.TextGroup.TabStop = false;
            this.TextGroup.Text = "Text";
            // 
            // TextBoxSender
            // 
            this.TextBoxSender.Location = new System.Drawing.Point(6, 22);
            this.TextBoxSender.Name = "TextBoxSender";
            this.TextBoxSender.Size = new System.Drawing.Size(100, 23);
            this.TextBoxSender.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(390, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tM1638ToolStripMenuItem,
            this.kS0108ToolStripMenuItem});
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.displayToolStripMenuItem.Text = "Display";
            // 
            // tM1638ToolStripMenuItem
            // 
            this.tM1638ToolStripMenuItem.Name = "tM1638ToolStripMenuItem";
            this.tM1638ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tM1638ToolStripMenuItem.Text = "TM1638";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onStartupToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // onStartupToolStripMenuItem
            // 
            this.onStartupToolStripMenuItem.Checked = true;
            this.onStartupToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.onStartupToolStripMenuItem.Name = "onStartupToolStripMenuItem";
            this.onStartupToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.onStartupToolStripMenuItem.Text = "On startup";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // kS0108ToolStripMenuItem
            // 
            this.kS0108ToolStripMenuItem.Name = "kS0108ToolStripMenuItem";
            this.kS0108ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kS0108ToolStripMenuItem.Text = "KS0108";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 379);
            this.Controls.Add(this.TextGroup);
            this.Controls.Add(this.TemperatureGroup);
            this.Controls.Add(this.SettingsBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Led`nKey";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.SettingsBox.ResumeLayout(false);
            this.SettingsBox.PerformLayout();
            this.ShowBox.ResumeLayout(false);
            this.ShowBox.PerformLayout();
            this.TemperatureGroup.ResumeLayout(false);
            this.TemperatureGroup.PerformLayout();
            this.TextGroup.ResumeLayout(false);
            this.TextGroup.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon Notify;
        private System.Windows.Forms.GroupBox SettingsBox;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.GroupBox ShowBox;
        private System.Windows.Forms.CheckBox TemperatureBox;
        private System.Windows.Forms.CheckBox TextBox;
        private System.Windows.Forms.ComboBox PortPicker;
        private System.Windows.Forms.Label PortLabel;
        private System.ComponentModel.BackgroundWorker MirrorWorker;
        private System.Windows.Forms.GroupBox TemperatureGroup;
        private System.Windows.Forms.GroupBox TextGroup;
        private System.Windows.Forms.Label TempGPULabel;
        private System.Windows.Forms.Label TempCPULabel;
        private System.Windows.Forms.Label LoadCPULabel;
        private System.Windows.Forms.Label LoadGPULabel;
        private System.Windows.Forms.Label LGPU;
        private System.Windows.Forms.Label LCPU;
        private System.Windows.Forms.Label TGPU;
        private System.Windows.Forms.Label TCPU;
        private System.Windows.Forms.TextBox ClockBox;
        private System.Windows.Forms.Label ClockLabel;
        private System.Windows.Forms.TextBox TextBoxSender;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tM1638ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onStartupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kS0108ToolStripMenuItem;
    }
}

