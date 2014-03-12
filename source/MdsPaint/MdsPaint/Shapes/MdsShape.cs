using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace MdsPaint.Shapes
{
    public abstract class MdsShape
    {
        public abstract void Draw(Bitmap bmp, Pen pen, Point start, Point end, bool isCanonical);
        public abstract void Fill(Bitmap bmp, Brush brush, Point start, Point end, bool isCanonical);

        protected static Rectangle GetRectangle(Point start, Point end, bool isCanonical)
        {
            

            if (isCanonical)
            {
                int x = Math.Min(start.X, end.X);
                int y = Math.Min(start.Y, end.Y);
                
                int width = Math.Abs(start.X - end.X);
                int height = Math.Abs(start.Y - end.Y);
                var tmp = Math.Max(width, height);
                
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
