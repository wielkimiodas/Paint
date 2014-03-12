using System.ComponentModel.Composition;
using System.Drawing;
using System.Reflection;
using MdsPaint.PluginManagment;
using MdsPaint.Utils;

namespace NegativePlugin
{
    [Export(typeof (MdsPaintPluginBase))]
    public class NegativeMaker : MdsPaintPluginBase
    {
        public override Image ButtonImage
        {
            get
            {
                return Assembly.GetExecutingAssembly().RetrieveImageFromEmbeddedResource("NegativePlugin.negative.png");
            }
        }

        public override string PanelLabel
        {
            get { return "Negative plugin"; }
        }

        public override string Name
        {
            get { return "Negative maker"; }
        }

        public override Bitmap ProcessBitmap(Bitmap source)
        {
            var tempBmp = (Bitmap) source.Clone();
            for (int i = 0; i < tempBmp.Width; i++)
            {
                for (int j = 0; j < tempBmp.Height; j++)
                {
                    var c = tempBmp.GetPixel(i, j);
                    c = Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B);
                    tempBmp.SetPixel(i, j, c);
                }
            }
            return tempBmp;
        }
    }
}