using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Led_nKey.Displays
{
    public class KS0108 : IDisplays
    {
        public int Power { get; set; }
        public int MessageSize { get; set; }

        public KS0108() 
        { 
            MessageSize = 0;
            Power = (int)Displays.Power.All;
        }

        public byte[] ConvertImage(string text)
        {
            throw new NotImplementedException();
        }

        public byte[] ConvertNums(string text)
        {
            throw new NotImplementedException();
        }

        public byte[] ConvertText(string text)
        {
            throw new NotImplementedException();
        }
    }
}
