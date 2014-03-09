using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace MdsPaint.Shapes
{
    public abstract class Shape
    {
        public abstract void Draw(Bitmap bmp, Pen pen, Point start, Point end);

        protected static Rectangle GetRectangle(Point start, Point end)
        {
            return new Rectangle(
                Math.Min(start.X, end.X),
                Math.Min(start.Y, end.Y),
                Math.Abs(start.X - end.X),
                Math.Abs(start.Y - end.Y));
        }
    }
}
