using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace MdsPaint
{
    public interface IMdsPaintPlugin
    {
        RibbonPanel RibbonPanel { get; set; }

        PictureBox Debug { get; set; }

        Bitmap Picture { get; set; }

        Panel PanelPointer { get; set; }

        String Name { get; set; }

        object ExecuteAction(object arg);

        
    }
}
