using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KeyStrokes
{
    public class NoFocusBtn : Button
    {
        public NoFocusBtn()
        {
            this.SetStyle(ControlStyles.Selectable, false);
        }
    }
}
