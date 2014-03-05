using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MdsPaint.Utils
{
    public class ResizeEventArgs : EventArgs
    {
        public Size NewSize { get; set; }
    }

    public class PickBox
    {
        //////////////////////////////////////////////////////////////////
        // PRIVATE CONSTANTS AND VARIABLES
        //////////////////////////////////////////////////////////////////

        public delegate void PropertyChangeHandler(object sender, ResizeEventArgs data);
        
        public event PropertyChangeHandler PropertyChange;
        // The method which fires the Event
        protected void OnPropertyChange(object sender, ResizeEventArgs data)
        {
            // Check if there are any Subscribers
            if (PropertyChange != null)
            {
                // Call the Event
                PropertyChange(this, data);
            }
        }

        private const int BoxSize = 8;
        private readonly Color _boxColor = Color.White;
        private Control _mControl;
        private readonly Label _lbl = new Label();
        private int startw;
        private int starth;
        //private int startx;
        //private int starty;
        private bool dragging;
        private Cursor oldCursor;

        public Size Size { get; set; }

        private const int MIN_SIZE = 20;

        //
        // Constructor creates 8 sizing handles & wires mouse events
        // to each that implement sizing functions
        //
        public PickBox()
        {
            _lbl = new Label
            {
                TabIndex = 4,
                FlatStyle = 0,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = _boxColor,
                Cursor = Cursors.SizeNWSE,
                Text = ""
            };
            _lbl.BringToFront();
            _lbl.MouseDown += lbl_MouseDown;
            _lbl.MouseMove += lbl_MouseMove;
            _lbl.MouseUp += lbl_MouseUp;
        }

        //////////////////////////////////////////////////////////////////
        // PUBLIC METHODS
        //////////////////////////////////////////////////////////////////

        //
        // Wires a Click event handler to the passed Control
        // that attaches a pick box to the control when it is clicked
        //
        public void WireControl(Control ctl)
        {
            ctl.Click += SelectControl;
        }

        /////////////////////////////////////////////////////////////////
        // PRIVATE METHODS
        /////////////////////////////////////////////////////////////////

        //
        // Attaches a pick box to the sender Control
        //
        private void SelectControl(object sender, EventArgs e)
        {
            if (_mControl != null)
            {
                _mControl.Cursor = oldCursor;
                _mControl = null;
            }
            _mControl = (Control)sender;
            //Add sizing handles to Control's container (Form or PictureBox)
            _mControl.Parent.Controls.Add(_lbl);
            _lbl.BringToFront();
            //Position sizing handles around Control
            MoveHandles();
            //Display sizing handles
            ShowHandles();
            oldCursor = _mControl.Cursor;
        }

        public void Remove()
        {
            HideHandles();
            _mControl.Cursor = oldCursor;
        }

        private void ShowHandles()
        {
            if (_mControl != null)
            {
                _lbl.Visible = true;
            }
        }

        private void HideHandles()
        {
            _lbl.Visible = false;
        }

        private void MoveHandles()
        {
            int sX = _mControl.Left - BoxSize;
            int sY = _mControl.Top - BoxSize;
            int sW = _mControl.Width + BoxSize;
            int sH = _mControl.Height + BoxSize;
            int hB = BoxSize / 2;
            int posX = sX + sW - hB;
            int posY = sY + sH - hB;
            _lbl.SetBounds(posX, posY, BoxSize, BoxSize);
        }

        /////////////////////////////////////////////////////////////////
        // MOUSE EVENTS THAT IMPLEMENT SIZING OF THE PICKED CONTROL
        /////////////////////////////////////////////////////////////////

        //
        // Store control position and size when mouse button pushed over
        // any sizing handle
        //
        private void lbl_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startw = _mControl.Width;
            starth = _mControl.Height;
            HideHandles();
        }

        private void lbl_MouseMove(object sender, MouseEventArgs e)
        {
            int l = _mControl.Left;
            int w = _mControl.Width;
            int t = _mControl.Top;
            int h = _mControl.Height;
            if (dragging)
            {
                switch (((Label)sender).TabIndex)
                {
                    case 4: // Dragging right-bottom sizing box
                        w = startw + e.X > MIN_SIZE ? startw + e.X : MIN_SIZE;
                        h = starth + e.Y > MIN_SIZE ? starth + e.Y : MIN_SIZE;
                        break;
                }
                l = (l < 0) ? 0 : l;
                t = (t < 0) ? 0 : t;
                _mControl.SetBounds(3, 3, w, h);
            }
        }

        //
        // Display sizing handles around picked control once sizing has completed
        //
        private void lbl_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
            MoveHandles();
            ShowHandles();
            OnPropertyChange(this,new ResizeEventArgs(){NewSize = new Size(_mControl.Width,_mControl.Height)});
        }
    }
}
