using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Led_nKey
{
    public static class Check
    {
        public static bool IsDigit(this Keys key)
        {
            Keys[] numbers = { Keys.D0, Keys.D1, Keys.D2,
                              Keys.D3, Keys.D4, Keys.D5,
                              Keys.D6, Keys.D7, Keys.D8,
                              Keys.D9,
                              Keys.NumPad0, Keys.NumPad1, Keys.NumPad2,
                              Keys.NumPad3, Keys.NumPad4, Keys.NumPad5,
                              Keys.NumPad6, Keys.NumPad7, Keys.NumPad8,
                              Keys.NumPad9};

            foreach (var number in numbers)
            {
                if (number == key)
                {
                    return true;
                }
            }

            return false;
        }
        public static bool IsDigit(this char chr)
        {
            char[] numbers = { '0', '1', '2',
                               '3', '4', '5',
                               '6', '7', '8',
                               '9' };

            foreach (var number in numbers)
            {
                if (number == chr)
                {
                    return true;
                }
            }

            return false;
        }
        public static bool HaveEmpty(this string[] array)
        {
            foreach (var item in array)
            {
                if (item == "")
                {
                    return true;
                }
            }
            return false;
        }
    }
}
