using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KryptBit
{
    class Stack
    {
        public frmKryptBit MainForm;
        public Stack(frmKryptBit frmMainForm)
        {
            MainForm = frmMainForm;
        }

        public void AddToStack(string FilterName)
        {
            MainForm.lstFilterStack.Items.Add(FilterName);
        }

    }
}
