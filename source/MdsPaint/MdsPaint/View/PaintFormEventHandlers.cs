using System;
using System.Windows.Forms;
using MdsPaint.Utils;

namespace MdsPaint.View
{
    public partial class PaintForm
    {
        private void ribbonOrbMenuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Resizing
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

        private void pbPaintingArea_SizeChanged(object sender, EventArgs e)
        {
            //            if(!mouseDown)
            //MessageBox.Show(" resized");
            //pbPaintingArea.FixPictureBoxSize();
        }

        private void pbPaintingArea_Resize(object sender, EventArgs e)
        {

        }

        #endregion

        private void rbtLoadFile_Click(object sender, EventArgs e)
        {
            FileUtils.LoadImageFileToMainPanel(this);
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
            FileUtils.SaveBmpFile(MainBitmap);
        }

        private void ribbonButtonPlugins_Click(object sender, EventArgs e)
        {
            ImportPlugins();
        }
    }
}
