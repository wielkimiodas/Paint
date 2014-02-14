using System.Reflection;
using MdsPaint.PluginManagment;
using System.ComponentModel.Composition;
using System.Drawing;
using MdsPaint.Utils;

namespace MirrorImagePlugin
{
    [Export(typeof(MdsPaintPluginBase))]
    public class MirrorImageMaker : MdsPaintPluginBase
    {
        public override Image ButtonImage
        {
            get
            {
                return Assembly.GetExecutingAssembly().RetrieveImageFromEmbeddedResource("MirrorImagePlugin.mirror.png");
            }
        }

        public override string PanelLabel
        {
            get { return "Mirror plugin"; }
        }

        public override string Name
        {
            get { return "Mirror image"; }
        }

        public override Bitmap ProcessBitmap(Bitmap source)
        {
            var baseBmp = (Bitmap)source.Clone();
            var tempBitmap = new Bitmap(baseBmp.Width, baseBmp.Height);

            for (int i = 0; i < baseBmp.Height; i++)
            {
                for (int j = 0; j < baseBmp.Width; j++)
                {
                    var c = baseBmp.GetPixel(j, i);
                    tempBitmap.SetPixel(baseBmp.Width - j - 1,i, c);

                }
            }


            return tempBitmap;
        }
    }
}
