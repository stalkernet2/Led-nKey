using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Led_nKey.Displays
{
    public interface IDisplays
    {
        int Power { get; set; }
        int MessageSize { get; set; }

        byte[] ConvertNums(string text);
        byte[] ConvertText(string text);
        byte[] ConvertImage(string text);
    }
}
