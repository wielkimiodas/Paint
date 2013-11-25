using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using MdsPaint;
using MdsPaint.PluginManagment;
using MdsPaint.Utils;

namespace TestPlugin
{
    [Export(typeof(MdsPaintPluginBase))]
    public class GrayScaleMaker : MdsPaintPluginBase
    {
        public override Image ButtonImage
        {
            get { return Assembly.GetExecutingAssembly().RetrieveImageFromEmbeddedResource("TestPlugin.grayscale.png"); }
        }

        public override string PanelLabel
        {
            get { return "Gray plugin"; }
        }

        public override void ProcessBitmap(Bitmap source, Bitmap dest)
        {
            for (int y = 0; y < source.Height; y++)
            {
                for (int x = 0; x < source.Width; x++)
                {
                    var c = source.GetPixel(x, y);
                    var luma = (int)(c.R * 0.3 + c.G * 0.59 + c.B * 0.11);
                    dest.SetPixel(x, y, Color.FromArgb(luma, luma, luma));
                }
            }
        }

        public override string Name
        {
            get { return "Gray scale"; }
        }




    }
}
