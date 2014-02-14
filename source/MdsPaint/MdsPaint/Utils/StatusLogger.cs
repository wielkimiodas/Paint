using System.Drawing;
using MdsPaint.View;

namespace MdsPaint.Utils
{
    public class StatusLogger
    {
        public static void LogLocation(PaintForm destinationForm, Point? location)
        {
            if (location == null)
                destinationForm.toolStripStatusLocationLabel.Text = "";
            else
                destinationForm.toolStripStatusLocationLabel.Text = "X: " + location.Value.X + "; Y: " +
                                                                    location.Value.Y + ";";
        }
    }
}