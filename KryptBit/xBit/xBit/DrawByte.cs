using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace xBit
{
    class DrawByte
    {
        public Bitmap xByte(int intColor)
        {
            var bitmap = new Bitmap(666, 467, PixelFormat.Format32bppArgb);
            var graphics = Graphics.FromImage(bitmap);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            switch (intColor)
            {
                case 1:
                    graphics.FillRectangle(new SolidBrush(Color.Red), 0, 0, 10, 10);
                    break;
                case 0:
                    graphics.FillRectangle(new SolidBrush(Color.White), 0, 0, 10, 10);
                    break;
                default:
                    break;
            }
            return bitmap;
        }
        public DrawByte()
        {
            
        }
    }
}
