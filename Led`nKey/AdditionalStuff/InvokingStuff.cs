using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Led_nKey
{
    internal class InvokingStuff
    {
        public static void SetText(string text, Control sender)
        {
            sender.Invoke(new Action(() => { sender.Text = text; }));
        }
    }
}
