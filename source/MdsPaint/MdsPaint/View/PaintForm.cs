using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MdsPaint.PluginManagment;
using MdsPaint.Utils;

namespace MdsPaint.View
{
    public sealed partial class PaintForm : Form
    {
        private Color _currentColor = Color.Black;
        private IEnumerable<MdsPaintPluginBase> plugins;
        public Bitmap MainBitmap;
        private Stack<Bitmap> _history = new Stack<Bitmap>();

        private readonly Size _initialMainBitmapSize = new Size(100, 100);

        public PaintForm()
        {
            InitializeComponent();
            statusStrip.BringToFront();
            this.DoubleBuffered = true;
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

        private void paintingArea_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void pbPaintingArea_MouseMove(object sender, MouseEventArgs e)
        {
            StatusLogger.LogLocation(this, e.Location);
            currentPosition = e.Location;
            if (painting)
            {
                //using (var graphics = Graphics.FromImage(MainBitmap))
                //{
                //    graphics.DrawRectangle(new Pen(_currentColor), startPosition.X, startPosition.Y, e.X - startPosition.X, e.Y - startPosition.Y);
                //}
                paintingArea.Invalidate();
            }
        }

        private void paintingArea_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImageUnscaled(MainBitmap, Point.Empty);
            var pen = new Pen(_currentColor);
            if (rectangles.Count > 0) e.Graphics.DrawRectangles(pen, rectangles.ToArray());
            if (painting) e.Graphics.DrawRectangle(pen, getRectangle());

            //   _history.Push(MainBitmap);
        }

        private Rectangle getRectangle()
        {
            return new Rectangle(
                Math.Min(startPosition.X, currentPosition.X),
                Math.Min(startPosition.Y, currentPosition.Y),
                Math.Abs(startPosition.X - currentPosition.X),
                Math.Abs(startPosition.Y - currentPosition.Y));
        }
        List<Rectangle> rectangles = new List<Rectangle>(); 
        private Point startPosition;
        private Point currentPosition;
        private bool painting;
        private void paintingArea_MouseDown(object sender, MouseEventArgs e)
        {
            currentPosition=startPosition = new Point(e.X,e.Y);
            painting = true;
        }

        private void paintingArea_MouseUp(object sender, MouseEventArgs e)
        {
            if (painting)
            {
                painting = false;
                var rc = getRectangle();
                if (rc.Width > 0 && rc.Height > 0) rectangles.Add(rc);
                paintingArea.Invalidate();
            }
            
        }

        private void ribbonColorChooser_Click(object sender, EventArgs e)
        {
            var res = colorDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                _currentColor = colorDialog1.Color;
            }
        }
        

    }
}