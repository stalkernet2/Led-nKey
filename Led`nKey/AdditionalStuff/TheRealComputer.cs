using Led_nKey.Displays;
using OpenHardwareMonitor.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Led_nKey
{
    internal class TheRealComputer
    {
        private readonly Computer _computer;

        public TheRealComputer()
        {
            _computer = new Computer {  CPUEnabled = true, 
                                        GPUEnabled = true };
            _computer.Open();
        }

        public IReadOnlyDictionary<string, float> GetInfoBySensors(SensorType sensorType)
        {
            var coreAndTemperature = new Dictionary<string, float>();

            foreach (var hardware in _computer.Hardware)
            {
                hardware.Update();
                foreach (var sensor in hardware.Sensors)
                {
                    if (sensor.SensorType == sensorType && sensor.Value.HasValue)
                        coreAndTemperature.Add(sensor.Name, sensor.Value.Value);
                }
            }

            return coreAndTemperature;
        }

        public void Dispose()
        {
            try
            {
                _computer.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}
