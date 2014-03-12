using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace MdsPaint.Shapes
{
    public class MdsLine : MdsShape
    {
        public override void Draw(Bitmap bmp, Pen pen, Point start, Point end, bool isCanonical)
        {
            using (var gfx = Graphics.FromImage(bmp))
            {
                if (isCanonical)
                    end = GetCanonicalPoint(start, end);

                gfx.DrawLine(pen, start, end);
            }
        }

        public override void Fill(Bitmap bmp, Brush brush, Point start, Point end, bool isCanonical)
        {
            using (var gfx = Graphics.FromImage(bmp))
            {
                if (isCanonical)
                    end = GetCanonicalPoint(start, end);

                gfx.DrawLine(new Pen(brush){Width = 3}, start, end);
            }
        }

        private Point GetCanonicalPoint(Point start, Point end)
        {
            int distX = start.X - end.X;
            int distY = start.Y - end.Y;
            int absDistX = Math.Abs(distX);
            int absDistY = Math.Abs(distY);

            var dest = new Point();
            if (absDistX > absDistY)
            {
                dest.X = end.X;
                dest.Y = start.Y;
            }
            else
            {
                dest.X = start.X;
                dest.Y = end.Y;
            }

            return dest;
        }
    }
}