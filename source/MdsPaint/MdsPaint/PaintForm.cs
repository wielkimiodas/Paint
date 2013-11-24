using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MdsPaint
{
    public partial class PaintForm : Form
    {
        private IEnumerable<IMdsPaintPlugin> plugins;

        public PaintForm()
        {
            InitializeComponent();
            
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        private void rbtLoadFile_Click(object sender, EventArgs e)
        {
            FileUtils.LoadImageFileToPictureBox(this);
        }

        private void pbPaintingArea_MouseMove(object sender, MouseEventArgs e)
        {
            StatusLogger.LogLocation(this, e.Location);
        }

        private void pbPaintingArea_MouseLeave(object sender, EventArgs e)
        {
            StatusLogger.LogLocation(this, null);
        }

        private void rbtSaveFile_Click(object sender, EventArgs e)
        {
            //FileUtils.SaveBmpFile(pbPaintingArea, FileUtils.GetNewFilePath());
        }

        private void pbPaintingArea_Resize(object sender, EventArgs e)
        {


        }

        private void ribbonButtonPlugins_Click(object sender, EventArgs e)
        {
            var importer = new PluginImporter();
            plugins = importer.GetPluginsList();

            foreach (var plugin in plugins)
            {
                plugin.PanelPointer = pbPaintingArea;
                plugin.Debug = pictureBox1;
                ribbonTabPlugins.Panels.Add(plugin.RibbonPanel);
            }
            ribbon.ResumeUpdating(true);
            //ribbon.Invalidate();
            //ribbon.Refresh();            
            //this.Refresh();
        }

        private Bitmap buffer = new Bitmap(100,100);
        private void Test2()
        {
            pbPaintingArea.DrawToBitmap(plugins.First().Picture,new Rectangle(0,0,100,100));

        }

        private void Test()
        {
            var g = pbPaintingArea.CreateGraphics();
            Bitmap bmp = new Bitmap(pbPaintingArea.Width, pbPaintingArea.Height);
            pbPaintingArea.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            bmp.Save(@"C:\Users\Wojciech\Desktop\bmp.bmp");
        }

        private void pbPaintingArea_SizeChanged(object sender, EventArgs e)
        {
            //            if(!mouseDown)
            //MessageBox.Show(" resized");
            //pbPaintingArea.FixPictureBoxSize();
        }

        private bool mouseDown = false;
        private void pbPaintingArea_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void pbPaintingArea_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void PaintForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void pbPaintingArea_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Chartreuse, 0, 0, 50, 50);

        }

    }
}
