using System;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using MdsPaint.Shapes;
using MdsPaint.Utils;

namespace MdsPaint.View
{
    public sealed partial class PaintForm
    {
        private void ribbonOrbMenuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ribbonButtonPlugins_Click(object sender, EventArgs e)
        {
            ImportPlugins();
        }

        private void ribbonButtonUndo_Click(object sender, EventArgs e)
        {
            OverwritePanel(PopFromHistory());
        }

        private void ribbonButtonRedo_Click(object sender, EventArgs e)
        {
        }

        private void panelPaintContainer_MouseEnter(object sender, EventArgs e)
        {
            panelPaintContainer.Focus();
        }

        private void rbDash_Click(object sender, EventArgs e)
        {
            _pen.DashStyle = DashStyle.Dash;
        }

        private void rbSolid_Click(object sender, EventArgs e)
        {
            _pen.DashStyle = DashStyle.Solid;
        }

        private void rbDotted_Click(object sender, EventArgs e)
        {
            _pen.DashStyle = DashStyle.Dot;
        }

        private void ribbonComboBoxThickness_DropDownItemClicked(object sender, RibbonItemEventArgs e)
        {
            _pen.Width = Convert.ToSingle(e.Item.Value);
        }

        private void rbShapeEllipse_Click(object sender, EventArgs e)
        {
            _currentMdsShape = new MdsEllipse();
        }

        private void rbShapeRectangle_Click(object sender, EventArgs e)
        {
            _currentMdsShape = new MdsRect();
        }

        private void ribbonComboBoxFillingStyle_DropDownItemClicked(object sender, RibbonItemEventArgs e)
        {
            UpdateBrush();
        }

        private void ribbonOrbMenuItemNew_Click(object sender, EventArgs e)
        {
            InitNewBitmap();
        }

        private void ribbonOrbMenuItemSave_Click(object sender, EventArgs e)
        {
            FileUtils.SaveBmpFile(MainBitmap);
        }

        private void ribbonOrbMenuItemLoad_Click(object sender, EventArgs e)
        {
            var newbmp = FileUtils.LoadImageFile();
            OverwritePanel(newbmp);
            AddToHistory(newbmp);
        }

        private void rbShapeLine_Click(object sender, EventArgs e)
        {
            _currentMdsShape = new MdsLine();
        }

        private void PaintForm_KeyUp(object sender, KeyEventArgs e)
        {
            _isCanonical = false;
            paintingArea.Invalidate();
        }

        private void ribbonColorChooserFilling_Click(object sender, EventArgs e)
        {
            var res = colorDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                _currentFillingColor = colorDialog.Color;
                ribbonColorChooserFilling.Color = colorDialog.Color;
            }
        }

        private void PaintForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift)
            {
                _isCanonical = true;
                paintingArea.Invalidate();
            }
            if (e.KeyData == (Keys.Control | Keys.Z))
            {
                OverwritePanel(PopFromHistory());
            }
            if (e.KeyData == (Keys.Control | Keys.Y))
            {
                //MessageBox.Show("Powtórz");
            }
        }
    }
}