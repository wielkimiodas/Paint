using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.RibbonHelpers;
using MdsPaint.PluginManagment;
using MdsPaint.Shapes;
using MdsPaint.Utils;

namespace MdsPaint.View
{
    public sealed partial class PaintForm : Form
    {
        private Shape _currentShape = new MdsRect();
        private readonly Pen _pen = new Pen(Color.Black);
        private IEnumerable<MdsPaintPluginBase> plugins;
        public Bitmap MainBitmap;
        private Stack<Bitmap> _history = new Stack<Bitmap>();
        private bool _drawing;
        private Bitmap _oldBmp;

        private readonly Size _initialMainBitmapSize = new Size(600, 300);

        public PaintForm()
        {
            InitializeComponent();
            statusStrip.BringToFront();
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw,false);
            MainBitmap = new Bitmap(_initialMainBitmapSize.Width, _initialMainBitmapSize.Height);
            using (var graphics = Graphics.FromImage(MainBitmap))
            {
                graphics.FillRectangle(Brushes.White,0,0,MainBitmap.Width,MainBitmap.Height);
                graphics.FillEllipse(Brushes.Aqua, 0, 0, 50, 50);
                graphics.FillRectangle(Brushes.Crimson, 60, 60, 70, 90);
                graphics.FillRectangle(Brushes.Yellow, 0, 60, 10, 70);
            }

            var pb = new PickBox();
            pb.WireControl(paintingArea);
            pb.PropertyChange += pb_PropertyChange;
            paintingArea.Size = MainBitmap.Size;
            paintingArea.Refresh();
            _oldBmp = MainBitmap;
        }

        void pb_PropertyChange(object sender, ResizeEventArgs data)
        {
            var newbmp = new Bitmap(data.NewSize.Width, data.NewSize.Height);

            for (int i = 0; i < data.NewSize.Width; i++)
            {
                for (int j = 0; j < data.NewSize.Height; j++)
                {
                    if (i < MainBitmap.Size.Width && j < MainBitmap.Size.Height)
                        newbmp.SetPixel(i, j, MainBitmap.GetPixel(i, j));
                    else
                    {
                        newbmp.SetPixel(i,j,Color.White);
                    }
                }
            }
            MainBitmap = newbmp;
            _oldBmp = newbmp;
            paintingArea.Refresh();
        }

        protected override void OnClosed(EventArgs e)
        {
            //var res = MessageBox.Show("Are you sure you want to exit without saving?", "Question",
            //    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (res == DialogResult.Yes)
            //    Close();
        }

        private void ImportPlugins()
        {
            if (plugins != null)
            {
                var first = ribbonTabPlugins.Panels.First();
                ribbonTabPlugins.Panels.Clear();
                ribbonTabPlugins.Panels.Add(first);
            }

            var importer = new PluginImporter();
            plugins = null;
            plugins = importer.GetPluginsList();

            foreach (var plugin in plugins)
            {
                plugin.PaintFormPointer = this;
                ribbonTabPlugins.Panels.Add(plugin.RibbonPanel);
            }
            ribbon.ResumeUpdating(true);
        }

        public void OverwritePanel(Bitmap bmp)
        {
            MainBitmap = bmp;
            paintingArea.Size = MainBitmap.Size;
            paintingArea.Refresh();
        }

        public void EnableRibbon(bool enabled)
        {
            foreach (var tab in ribbon.Tabs)
            {
                foreach (var panel in tab.Panels)
                {
                    panel.Enabled = enabled;
                }
            }
        }

        private void pbPaintingArea_MouseMove(object sender, MouseEventArgs e)
        {
            StatusLogger.LogLocation(this, e.Location);
            currentPosition = e.Location;
            if (_drawing)
            {
                paintingArea.Invalidate();
            }
        }
        
        private void paintingArea_Paint(object sender, PaintEventArgs e)
        {
            _oldBmp = (Bitmap)MainBitmap.Clone();
            if (_drawing) 
                _currentShape.Draw(MainBitmap,_pen,startPosition,currentPosition);
            
            e.Graphics.DrawImageUnscaled(MainBitmap, Point.Empty);
            MainBitmap = (Bitmap)_oldBmp.Clone();
            //   _history.Push(MainBitmap);
        }

        private Rectangle currRect;
        private Point startPosition;
        private Point currentPosition;
        
        private void paintingArea_MouseDown(object sender, MouseEventArgs e)
        {
            currentPosition=startPosition = new Point(e.X,e.Y);
            _oldBmp = (Bitmap)MainBitmap;//.Clone();
            _drawing = true;
        }
        

        private void paintingArea_MouseUp(object sender, MouseEventArgs e)
        {
            if (_drawing)
            {
                _drawing = false;
            }

            _currentShape.Draw(MainBitmap,_pen,startPosition,currentPosition);
            _oldBmp = MainBitmap;

            paintingArea.Invalidate();
            startPosition = Point.Empty;
        }

        private void ribbonColorChooser_Click(object sender, EventArgs e)
        {
            var res = colorDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                _pen.Color = colorDialog.Color;
                //_currentColor = 
                ribbonColorChooserBorder.Color = colorDialog.Color;
                //pen.Color = _currentColor;
            }
        }

        private void pbPaintingArea_MouseLeave(object sender, EventArgs e)
        {
            StatusLogger.LogLocation(this, null);
        }

        private void ribbonComboBoxThickness_DropDownItemClicked(object sender, RibbonItemEventArgs e)
        {
            _pen.Width = Convert.ToSingle(e.Item.Value);
        }

        private void rbShapeEllipse_Click(object sender, EventArgs e)
        {
            _currentShape = new MdsEllipse();
        }

        private void rbShapeRectangle_Click(object sender, EventArgs e)
        {
            _currentShape = new MdsRect();
        }

        private void ribbonColorChooserFilling_Click(object sender, EventArgs e)
        {
            //ColorDialog cd;
        }


        
    }
}