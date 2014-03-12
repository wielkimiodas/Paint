using System.Drawing;

namespace MdsPaint.Shapes
{
    internal class MdsRect : MdsShapeBase
    {
        public override void Draw(Bitmap bmp, Pen pen, Point start, Point end, bool isCanonical)
        {
            using (var gfx = Graphics.FromImage(bmp))
            {
                var rect = GetRectangle(start, end, isCanonical);
                if (rect.Width > 0 && rect.Height > 0)
                    gfx.DrawRectangle(pen, rect);
            }
        }

        public override void Fill(Bitmap bmp, Brush brush, Point start, Point end, bool isCanonical)
        {
            using (var gfx = Graphics.FromImage(bmp))
            {
                var rect = GetRectangle(start, end, isCanonical);
                if (rect.Width > 0 && rect.Height > 0)
                    gfx.FillRectangle(brush, rect);
            }
        }
    }
}