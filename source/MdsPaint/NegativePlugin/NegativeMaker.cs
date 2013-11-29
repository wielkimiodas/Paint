using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using MdsPaint.PluginManagment;
using MdsPaint.Utils;

namespace NegativePlugin
{
    [Export(typeof(MdsPaintPluginBase))]
    public class NegativeMaker : MdsPaintPluginBase
    {
        public override Image ButtonImage
        {
            get { return Assembly.GetExecutingAssembly().RetrieveImageFromEmbeddedResource("NegativePlugin.negative.png"); }
        }

        public override string PanelLabel
        {
            get { return "Negative plugin"; }
        }

        //public override Bitmap ProcessBitmap(Bitmap source)
        //{
        //    throw new NotImplementedException();
        //}

        public override string Name
        {
            get { return "Negative maker"; }
        }

        public override void ProcessBitmap(Bitmap source, Bitmap dest,Semaphore s)
        {
            for (int i = 0; i < source.Width; i++)
            {
                for (int j = 0; j < source.Height; j++)
                {
                    var c = source.GetPixel(i, j);
                    c = Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B);
                    dest.SetPixel(i, j, c);
                }
            }
            s.Release();
        }
    }
}
