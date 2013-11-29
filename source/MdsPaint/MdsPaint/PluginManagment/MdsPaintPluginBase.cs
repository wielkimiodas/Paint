using System;
using System.Drawing;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using MdsPaint.Utils;

namespace MdsPaint.PluginManagment
{
    public abstract class MdsPaintPluginBase
    {
        public Panel PanelPointer { get; set; }

        public Bitmap Picture { get; set; }

        public abstract Image ButtonImage { get; }
        public abstract string PanelLabel { get; }

        public abstract void ProcessBitmap(Bitmap source, Bitmap dest, Semaphore s);

        public static object Locker = new object();

        public RibbonPanel RibbonPanel
        {
            get
            {
                return InitRibbonPanel();
            }
        }

        private RibbonPanel InitRibbonPanel()
        {
            var button = new RibbonButton(Name) { Tag = this };
            button.Click += button_Click;
            button.Image = ButtonImage;
            var panel = new RibbonPanel(PanelLabel);
            panel.Items.Add(button);
            return panel;
        }

        static void button_Click(object sender, EventArgs e)
        {
            var btn = (RibbonButton)sender;
            var plugin = (MdsPaintPluginBase)(btn.Tag);
            var panel = plugin.PanelPointer;
            var panelDim = panel.Size;
            var source = new Bitmap(panelDim.Width, panelDim.Height);
            panel.DrawToBitmap(source, new Rectangle(0, 0, panelDim.Width, panelDim.Height));

            Semaphore s = new Semaphore(1,1);
            s.WaitOne();
                var t = new Thread(() => plugin.ProcessBitmap(source, plugin.Picture,s));
                t.Start();

            s.WaitOne();
                plugin.PanelPointer.Refresh();
        }

        public abstract string Name { get; }
    }
}
