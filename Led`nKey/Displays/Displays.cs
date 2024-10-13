using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Led_nKey.Displays
{
    public class Displays
    {
        public enum Send
        {
            TemperatureAndLoad = 0x01,
            Text = 0x02,
            Image = 0x03
        }

        public enum Power
        { 
            Nums,
            Text,
            Image,
            All
        }
    }
}
