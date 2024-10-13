using Led_nKey.Displays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Led_nKey.Displays
{
    public class TM1638 : IDisplays
    {
        private readonly byte[] Nums = new byte[] { 0x3F, 0x06, 0x5B, // 0, 1, 2,
                                                          0x4F, 0x66, 0x6D, // 3, 4, 5,
                                                          0x7D, 0x07, 0x7F, // 6, 7, 8,
                                                          0x6F };           // 9

        public int Power { get; set; }
        public int MessageSize { get; set; }
        
        public TM1638()
        {
            MessageSize = 24;
            Power = (int)Displays.Power.Nums;
        }

        public byte[] ConvertNums(string text)
        {
            var bytes = new byte[text.Length <= 8 ? text.Length : 8];

            for (int i = 0; i < bytes.Length; i++)
                bytes[i] = Nums[(i < text.Length) ? text[i] : 0x00];

            return bytes;
        }

        public byte[] ConvertText(string text)
        {
            throw new NotImplementedException();
        }

        public byte[] ConvertImage(string text)
        {
            throw new NotImplementedException();
        }
    }
}
