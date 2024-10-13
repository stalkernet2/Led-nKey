using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Led_nKey
{
    internal class StringStuff
    {
        public static string CeilingAndDesignating(float value, string design)
        {
            var tempValue = Math.Ceiling(value).ToString();

            switch (tempValue.Length)
            {
                case 1:
                    tempValue += "    " + design;
                    break;
                case 2:
                    tempValue += "  " + design;
                    break;
                case 3:
                    tempValue += " " + design;
                    break;
                default:
                    break;
            }

            return tempValue;
        }

        public static byte[] ParseToByte(string target)
        {
            if (target.Length <= 1)
            {
                string add = "";
                for (int i = 0; i < 2 - target.Length; i++)
                    add += "0";
                target = add + target;
            }

            var bytes = new byte[2];
            for (int i = 0; i < bytes.Length; i++)
                bytes[i] = byte.Parse(target[i].ToString());
            return bytes;
        }
    }
}
