using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace MdsPaint.Shapes
{
    public abstract class Shape
    {
        public abstract void Draw(Bitmap bmp, Pen pen, Point start, Point end, bool isCanonical);
        public abstract void Fill(Bitmap bmp, Brush brush, Point start, Point end, bool isCanonical);

        protected static Rectangle GetRectangle(Point start, Point end, bool isCanonical)
        {
            int a1 = Math.Min(start.X, end.X);
            int a2 = Math.Min(start.Y, end.Y);
            int a3 = Math.Abs(start.X - end.X);
            int a4 = Math.Abs(start.Y - end.Y);

            if (isCanonical)
                return new Rectangle(a1, a1, a3, a3);
            return new Rectangle(a1, a2, a3, a4);
        }
    }
}
