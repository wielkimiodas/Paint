using System;
using System.Windows.Forms;
using MdsPaint.Utils;

namespace MdsPaint.View
{
    public sealed partial class PaintForm
    {
        private void ribbonOrbMenuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rbtLoadFile_Click(object sender, EventArgs e)
        {
            OverwritePanel(FileUtils.LoadImageFile());
        }

        

        private void rbtSaveFile_Click(object sender, EventArgs e)
        {
            FileUtils.SaveBmpFile(MainBitmap);
        }

        private void ribbonButtonPlugins_Click(object sender, EventArgs e)
        {
            ImportPlugins();
        }

        private void ribbonButtonUndo_Click(object sender, EventArgs e)
        {
            //MainBitmap = _history.Pop();
            //MainBitmap = _history.Pop();
            //paintingArea.Refresh();
        }

        private void ribbonButtonRedo_Click(object sender, EventArgs e)
        {

        }

        private void ribbonButton1_Click(object sender, EventArgs e)
        {

        }

        private void panelPaintContainer_MouseEnter(object sender, EventArgs e)
        {
            panelPaintContainer.Focus();
        }
    }
}