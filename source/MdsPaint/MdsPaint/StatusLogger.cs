using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;

namespace MdsPaint
{
    public class StatusLogger
    {

        public static void LogLocation(PaintForm destinationForm, Point? location)
        {
            if (location == null)
                destinationForm.toolStripStatusLocationLabel.Text = "";
            else
                destinationForm.toolStripStatusLocationLabel.Text = "X: " + location.Value.X + "; Y: " + location.Value.Y + ";";

        }
    }
}
