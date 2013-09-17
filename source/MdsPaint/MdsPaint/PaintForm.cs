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
            StatusLogger.LogLocation(this,e.Location);
        }

        private void pbPaintingArea_MouseLeave(object sender, EventArgs e)
        {
            StatusLogger.LogLocation(this, null);
        }

        private void rbtSaveFile_Click(object sender, EventArgs e)
        {
            FileUtils.SaveBmpFile(pbPaintingArea,FileUtils.GetNewFilePath());
        }

        private void pbPaintingArea_Resize(object sender, EventArgs e)
        {
            pbPaintingArea.FixPictureBoxSize();
        }

        private void ribbonButton1_Click(object sender, EventArgs e)
        {
            Test();
        }

        private void Test()
        {
            var g = pbPaintingArea.CreateGraphics();
            Bitmap bmp = new Bitmap(pbPaintingArea.Width,pbPaintingArea.Height);
            pbPaintingArea.DrawToBitmap(bmp,new Rectangle(0,0,bmp.Width,bmp.Height));
            bmp.Save(@"C:\Users\Wojciech\Desktop\bmp.bmp");
        }

    }
}
