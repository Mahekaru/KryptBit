using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace KryptBit
{
    public class PnlDoubleBuffer : Panel
    {
        public PnlDoubleBuffer()
        {
            this.SetStyle
            (System.Windows.Forms.ControlStyles.UserPaint |
            System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
            System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer,
            true);
        }
    }
}
