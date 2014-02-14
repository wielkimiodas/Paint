using System.ComponentModel.Composition;
using System.Drawing;
using System.Reflection;
using MdsPaint.PluginManagment;
using MdsPaint.Utils;

namespace TestPlugin
{
    [Export(typeof (MdsPaintPluginBase))]
    public class GrayScaleMaker : MdsPaintPluginBase
    {
        public override Image ButtonImage
        {
            get
            {
                return Assembly.GetExecutingAssembly().RetrieveImageFromEmbeddedResource("GrayScalePlugin.grayscale.png");
            }
        }

        public override string PanelLabel
        {
            get { return "Gray plugin"; }
        }

        public override string Name
        {
            get { return "Gray scale"; }
        }

        public override Bitmap ProcessBitmap(Bitmap source)
        {
            var tempBitmap = (Bitmap) source.Clone();
            for (int y = 0; y < tempBitmap.Height; y++)
            {
                for (int x = 0; x < tempBitmap.Width; x++)
                {
                    var c = tempBitmap.GetPixel(x, y);
                    var luma = (int) (c.R*0.3 + c.G*0.59 + c.B*0.11);
                    tempBitmap.SetPixel(x, y, Color.FromArgb(luma, luma, luma));
                }
            }
            //Thread.Sleep(5000);
            return tempBitmap;
        }
    }
}