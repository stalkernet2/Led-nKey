using OpenHardwareMonitor.Hardware;
using System;

namespace Led_nKey
{
    internal class Worker
    {
        private const byte SEND_TEMPERATURE_AND_LOAD = 0x04;
        private const byte SEND_TEXT = 0x04;
        private const int SIZE_MESSAGE = 24;

        public void SendTemperatureAndLoadOfCpuAndGpu(TheRealComputer thisPC, out float tempCPU, out float tempGPU, out float loadCPU, out float loadGPU)
        {
            var tempCollection = thisPC.GetInfoBySensors(SensorType.Temperature);
            var loadCollection = thisPC.GetInfoBySensors(SensorType.Load);

            tempCollection.TryGetValue("CPU Package", out tempCPU);
            var CPUTemp = StringStuff.ParseToByte(tempCPU.ToString());

            tempCollection.TryGetValue("GPU Core", out tempGPU);
            var GPUTemp = StringStuff.ParseToByte(tempGPU.ToString());

            loadCollection.TryGetValue("CPU Total", out loadCPU);
            var CPULoad = StringStuff.ParseToByte((Math.Ceiling(loadCPU * 0.4 / 10) * 10).ToString());

            loadCollection.TryGetValue("GPU Core", out loadGPU);
            var GPULoad = StringStuff.ParseToByte((Math.Ceiling(loadGPU * 0.4 / 10) * 10).ToString());

            if (!Device.USB.IsConnected)
                return;

            Device.USB.SendData(new byte[] { SEND_TEMPERATURE_AND_LOAD, 0x39, 0x00, TM1638.Nums[CPUTemp[0]], TM1638.Nums[CPUTemp[1]], 0x3D, 0x00, TM1638.Nums[GPUTemp[0]], TM1638.Nums[GPUTemp[1]], CPULoad[0], GPULoad[0] }, 0, SIZE_MESSAGE);
        }

        public void SendText(string text)
        {
            for (int i = 0; i < text.Length; i++)
                if (!char.IsDigit(text[i]))
                    return;

            var bytes = new byte[9];
            var tempBytes = TM1638.ConvertNums(text);

            bytes[0] = SEND_TEXT;
            for (int i = 1; i < bytes.Length; i++)
                bytes[i] = tempBytes[i - 1];

            Device.USB.SendData(bytes, 0, SIZE_MESSAGE);
        }
    }
}
