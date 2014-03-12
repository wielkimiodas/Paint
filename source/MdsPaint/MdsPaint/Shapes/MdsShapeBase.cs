using System;
using System.Drawing;

namespace MdsPaint.Shapes
{
    public abstract class MdsShapeBase
    {
        public abstract void Draw(Bitmap bmp, Pen pen, Point start, Point end, bool isCanonical);
        public abstract void Fill(Bitmap bmp, Brush brush, Point start, Point end, bool isCanonical);

        protected static Rectangle GetRectangle(Point start, Point end, bool isCanonical)
        {
            if (isCanonical)
            {
                var tmp = Math.Max(Math.Abs(start.X - end.X), Math.Abs(start.Y - end.Y));
                int x = start.X;
                int y = start.Y;
                if (start.X > end.X)
                {
                    x -= tmp;
                }
                if (start.Y > end.Y)
                {
                    y -= tmp;
                }

                return new Rectangle(x, y, tmp, tmp);
            }
            else
            {
                int x = Math.Min(start.X, end.X);
                int y = Math.Min(start.Y, end.Y);
                int width = Math.Abs(start.X - end.X);
                int height = Math.Abs(start.Y - end.Y);
                return new Rectangle(x, y, width, height);
            }
        }
    }
}