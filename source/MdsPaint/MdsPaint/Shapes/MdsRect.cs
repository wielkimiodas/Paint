using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;

namespace MdsPaint.Shapes
{
    class MdsRect : Shape
    {
        public override void Draw(Bitmap bmp, Pen pen, Point start, Point end)
        {
            using (var gfx = Graphics.FromImage(bmp))
            {
                var rect = GetRectangle(start, end);
                //pen.DashStyle = DashStyle.Dot;
                pen.Width = 5;
                if (rect.Width > 0 && rect.Height > 0)
                    gfx.DrawRectangle(pen, rect);
            }
        }
    }
}
