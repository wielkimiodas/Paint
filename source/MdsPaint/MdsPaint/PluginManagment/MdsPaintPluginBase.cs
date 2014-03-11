using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MdsPaint.View;

namespace MdsPaint.PluginManagment
{
    public abstract class MdsPaintPluginBase
    {
        public PaintForm PaintFormPointer { get; set; }
        public abstract Image ButtonImage { get; }
        public abstract string PanelLabel { get; }
        public abstract string Name { get; }

        public abstract Bitmap ProcessBitmap(Bitmap source);

        public RibbonPanel RibbonPanel
        {
            get { return InitRibbonPanel(); }
        }

        private RibbonPanel InitRibbonPanel()
        {
            var btn = new RibbonButton(Name) {Tag = this};
            btn.Click += button_Click;
            btn.Image = ButtonImage;
            var panel = new RibbonPanel(PanelLabel);
            panel.Items.Add(btn);
            return panel;
        }

        private static void button_Click(object sender, EventArgs e)
        {
            var btn = (RibbonButton) sender;
            var plugin = (MdsPaintPluginBase) (btn.Tag);
            plugin.PaintFormPointer.EnableRibbon(false);
            Task.Factory.StartNew(() => BtnAction(plugin));
        }

        public static void BtnAction(MdsPaintPluginBase plugin)
        {
            var res = plugin.ProcessBitmap(plugin.PaintFormPointer.MainBitmap);
            var changeImgAction = new Action(() => plugin.PaintFormPointer.OverwritePanel(res));

            var asyncImgChange = plugin.PaintFormPointer.BeginInvoke(changeImgAction);
            plugin.PaintFormPointer.EndInvoke(asyncImgChange);
            plugin.PaintFormPointer.EnableRibbon(true);
        }
    }
}