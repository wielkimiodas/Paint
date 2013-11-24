using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using MdsPaint;
using MdsPaint.PluginManagment;
using MdsPaint.Utils;

namespace TestPlugin
{
    [Export(typeof(IMdsPaintPlugin))]
    public class MboxExecuter : IMdsPaintPlugin
    {
        public Panel PanelPointer { get; set; }

        public Bitmap Picture { get; set; }

        public RibbonPanel RibbonPanel
        {
            get
            {
                return InitRibbonPanel();
            }
        }

        public string Name
        {
            get
            {
                return "Test plugin";
            }
        }

        private RibbonPanel InitRibbonPanel()
        {
            var button = new RibbonButton("Gray scale") { Tag = this };
            button.Click += button_Click;
            button.Image = Assembly.GetExecutingAssembly().RetrieveImageFromEmbeddedResource("TestPlugin.grayscale.png");
            button.Text = Name;
            var panel = new RibbonPanel("Gray plugin");
            panel.Items.Add(button);
            return panel;
        }

        static void button_Click(object sender, EventArgs e)
        {
            var btn = (RibbonButton)sender;
            var plugin = (IMdsPaintPlugin)(btn.Tag);
            var panel = plugin.PanelPointer;
            var panelDim = panel.Size;
            var source = new Bitmap(panelDim.Width, panelDim.Height);
            panel.DrawToBitmap(source, new Rectangle(0, 0, panelDim.Width, panelDim.Height));

            for (int y = 0; y < source.Height; y++)
            {
                for (int x = 0; x < source.Width; x++)
                {
                    var c = source.GetPixel(x, y);
                    var luma = (int)(c.R * 0.3 + c.G * 0.59 + c.B * 0.11);
                    plugin.Picture.SetPixel(x, y, Color.FromArgb(luma, luma, luma));
                }
            }

            plugin.PanelPointer.Invalidate();
        }
    }
}
