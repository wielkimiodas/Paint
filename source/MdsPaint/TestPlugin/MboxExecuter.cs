using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MdsPaint;

namespace TestPlugin
{
    [Export(typeof(IMdsPaintPlugin))]
    public class MboxExecuter : IMdsPaintPlugin
    {
        public RibbonPanel RibbonPanel
        {
            get
            {
                return InitRibbonPanel();
            }
            set
            {

            }
        }

        public PictureBox Debug { get; set; }

        public Panel PanelPointer { get; set; }

        public string Name
        {
            get
            {
                return "Test plugin";
            }
            set
            {

            }
        }

        public Bitmap Picture { get; set; }

        public object ExecuteAction(object arg)
        {
            var source = (Bitmap) arg;
            var bm = new Bitmap(source.Width, source.Height);
            
            return bm;
        }

        private RibbonPanel InitRibbonPanel()
        {
            var rb = new RibbonButton("mega tescior");
            rb.Tag = this;
            rb.Click += rb_Click;
            var rp = new RibbonPanel("mega panel");
            rp.Items.Add(rb);
            return rp;
        }

        static void rb_Click(object sender, EventArgs e)
        {
            var btn = (RibbonButton) sender;
            var blabl = (IMdsPaintPlugin)(btn.Tag);

            var source = new Bitmap(100, 100);
            var dest = new Bitmap(100, 100);
            blabl.PanelPointer.DrawToBitmap(source, new Rectangle(0, 0, 100, 100));

            for (int y = 0; y < source.Height; y++)
            {
                for (int x = 0; x < source.Width; x++)
                {
                    var c = source.GetPixel(x, y);
                    var luma = (int)(c.R * 0.3 + c.G * 0.59 + c.B * 0.11);
                    dest.SetPixel(x, y, Color.FromArgb(luma, luma, luma));
                }
            }
            

            //blabl.PanelPointer.BackColor = Color.SeaGreen;
            blabl.Debug.Image = dest;
            blabl.PanelPointer.Invalidate();
        }
    }
}
