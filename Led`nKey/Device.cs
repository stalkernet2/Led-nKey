using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace Led_nKey
{
    internal class Device : IDisposable
    {
        public static Device USB;
        public bool IsConnected = false;

        private readonly SerialPort _port;
        private const int _sizeOfDateInfo = 6; // size of the sent time

        public Device()
        {
            _port = new SerialPort();
        }

        public void MakeConnection(string portName, int bandRate = 9600)
        {
            if (IsConnected)
            {
                MessageBox.Show("Already connected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //if (!_port.IsOpen)
            //{
            //    MessageBox.Show("Port is closed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            _port.PortName = portName;
            _port.BaudRate = bandRate;

            IsConnected = true;
            _port.Open();
        }

        public void SendData(byte[] data, int offset, int arraySize)
        {
            //if (arraySize - (data.Length + _sizeOfDateInfo) < 0)
            //    throw new OverflowException("Length of data is bigger than arraySize");

            data = InsertDateInfo(FillEmptyBytes(data, 
                                                 arraySize));

            _port.Write(data, offset, arraySize);
        }

        private byte[] InsertDateInfo(byte[] data)
        {
            var timeNow = new int[] { DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second };
            var timeIndex = 0;
            for (int i = data.Length - 1; i > data.Length - _sizeOfDateInfo; i -= 2)
            {
                var byteOf = TM1638.ConvertNums(timeNow[timeIndex].ToString());

                for (int j = byteOf.Length - 1; j >= 0; j--)
                    data[i - j] = byteOf[j];

                timeIndex++;
            }

            return data;
        }

        public void CloseConnection()
        {
            IsConnected = false;
            _port.Close();
        }

        public static string[] GetPortNames() => SerialPort.GetPortNames();

        private byte[] FillEmptyBytes(byte[] oldBytes, int target)
        {
            var newBytes = new byte[target];

            for (int i = 0; i < target; i++)
                newBytes[i] = i < oldBytes.Length ? oldBytes[i] : (byte)0x00;

            return newBytes;
        }

        public void Dispose()
        {
            CloseConnection();
            GC.SuppressFinalize(this);
        }
    }
}
