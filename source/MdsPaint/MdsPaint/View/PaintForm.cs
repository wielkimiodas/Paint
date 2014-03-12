using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.RibbonHelpers;
using System.Windows.Forms.VisualStyles;
using MdsPaint.PluginManagment;
using MdsPaint.Shapes;
using MdsPaint.Utils;

namespace MdsPaint.View
{
    public sealed partial class PaintForm : Form
    {
        private MdsShape _currentMdsShape = new MdsRect();
        private readonly Pen _pen = new Pen(Color.Black);
        private Color _currentFillingColor = Color.LimeGreen;
        private Brush _currentFillingBrush;
        private IEnumerable<MdsPaintPluginBase> plugins;
        public Bitmap MainBitmap;
        private Stack<Bitmap> _history = new Stack<Bitmap>();
        private bool _drawing;
        private Bitmap _oldBmp;
        private bool _isCanonical;
        private Point _startPosition;
        private Point _currentPosition;

        private readonly Size _initialMainBitmapSize = new Size(600, 300);

        public PaintForm()
        {
            InitializeComponent();
            statusStrip.BringToFront();
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, false);

            var pb = new PickBox();
            pb.WireControl(paintingArea);
            pb.PropertyChange += pb_PropertyChange;

            InitNewBitmap();
        }

        private void InitNewBitmap()
        {
            MainBitmap = new Bitmap(_initialMainBitmapSize.Width, _initialMainBitmapSize.Height);
            using (var graphics = Graphics.FromImage(MainBitmap))
            {
                graphics.FillRectangle(Brushes.White, 0, 0, MainBitmap.Width, MainBitmap.Height);
                //graphics.FillEllipse(Brushes.Aqua, 0, 0, 50, 50);
                //graphics.FillRectangle(Brushes.Crimson, 60, 60, 70, 90);
                //graphics.FillRectangle(Brushes.Yellow, 0, 60, 10, 70);
            }
            OverwritePanel(MainBitmap);
            AddToHistory(MainBitmap);
        }

        public void AddToHistory(Bitmap bmp)
        {
            _history.Push(bmp);
        }

        public Bitmap PopFromHistory()
        {
            Bitmap tmp = null;
            try
            {
                if (_history.Count > 1)
                    _history.Pop();
                tmp = _history.Peek();
            }
            catch (Exception)
            {
            }
            return tmp ?? MainBitmap;
        }

        private void pb_PropertyChange(object sender, ResizeEventArgs data)
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
                        newbmp.SetPixel(i, j, Color.White);
                    }
                }
            }

            OverwritePanel(newbmp);
            AddToHistory(newbmp);            
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
          if (bmp != null)
          {
            MainBitmap = bmp;
            paintingArea.Size = MainBitmap.Size;
            paintingArea.Refresh();
          }
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
            _currentPosition = e.Location;
            if (_drawing)
            {
                paintingArea.Invalidate();
            }
        }

        private void paintingArea_Paint(object sender, PaintEventArgs e)
        {
            _oldBmp = (Bitmap) MainBitmap.Clone();
            if (_drawing)
            {
                UpdateBrush();
                if (_currentFillingBrush != null)
                    _currentMdsShape.Fill(MainBitmap, _currentFillingBrush, _startPosition, _currentPosition,
                        _isCanonical);
                else
                    _currentMdsShape.Draw(MainBitmap, _pen, _startPosition, _currentPosition, _isCanonical);
            }

            e.Graphics.DrawImageUnscaled(MainBitmap, Point.Empty);
            MainBitmap = (Bitmap) _oldBmp.Clone();
            
        }


        private void paintingArea_MouseDown(object sender, MouseEventArgs e)
        {
            _currentPosition = _startPosition = new Point(e.X, e.Y);
            _oldBmp = (Bitmap) MainBitmap; //.Clone();
            _drawing = true;
        }

        private void paintingArea_MouseUp(object sender, MouseEventArgs e)
        {
            if (_drawing)
            {
                _drawing = false;
            }

            if (_currentFillingBrush != null)
            {
                UpdateBrush();
                _currentMdsShape.Fill(MainBitmap, _currentFillingBrush, _startPosition, _currentPosition, _isCanonical);
            }
            else
            {
                _currentMdsShape.Draw(MainBitmap, _pen, _startPosition, _currentPosition, _isCanonical);
            }

            _oldBmp = MainBitmap;

            paintingArea.Invalidate();
            _startPosition = Point.Empty;
            AddToHistory(MainBitmap);
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
        
        private void UpdateBrush()
        {
            switch (ribbonComboBoxFillingStyle.SelectedValue)
            {
                case "0":
                    _currentFillingBrush = null;
                    break;
                case "1":
                    _currentFillingBrush = new HatchBrush(HatchStyle.Cross, _currentFillingColor);
                    break;
                case "2":
                    _currentFillingBrush = new HatchBrush(HatchStyle.LargeCheckerBoard, _currentFillingColor);
                    break;
                case "3":
                    _currentFillingBrush = new HatchBrush(HatchStyle.Percent90, _currentFillingColor);
                    break;
                case "4":
                    _currentFillingBrush = new HatchBrush(HatchStyle.Shingle, _currentFillingColor);
                    break;
                case "5":
                    _currentFillingBrush = new SolidBrush(_currentFillingColor);
                    break;
                default:
                    _currentFillingBrush = null;
                    break;
            }
        }

        private void ribbonOrbMenuItemAbout_Click(object sender, EventArgs e)
        {
            var aboutDialog = new About {StartPosition = FormStartPosition.CenterParent};
            aboutDialog.ShowDialog();
        }
    }
}