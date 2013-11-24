using System;
using System.Drawing;
using System.Windows.Forms;

namespace MdsPaint.PluginManagment
{
    public interface IMdsPaintPlugin
    {
        RibbonPanel RibbonPanel { get;}

        Bitmap Picture { get; set; }

        Panel PanelPointer { get; set; }

        String Name { get; }
    }
}
