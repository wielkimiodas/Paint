using System.Windows.Forms;

namespace MdsPaint.View
{
    sealed partial class PaintForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaintForm));
            this.ribbon = new System.Windows.Forms.Ribbon();
            this.ribbonOrbMenuItemNew = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbMenuItemSave = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbMenuItemExit = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonButtonUndo = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonRedo = new System.Windows.Forms.RibbonButton();
            this.ribbonTabDrawing = new System.Windows.Forms.RibbonTab();
            this.ribbonPanelColorPicking = new System.Windows.Forms.RibbonPanel();
            this.ribbonColorChooser = new System.Windows.Forms.RibbonColorChooser();
            this.ribbonPanelShapes = new System.Windows.Forms.RibbonPanel();
            this.ribbonButtonEllipse = new System.Windows.Forms.RibbonButton();
            this.ribbonButton4 = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonRectangle = new System.Windows.Forms.RibbonButton();
            this.ribbonTabPlugins = new System.Windows.Forms.RibbonTab();
            this.ribbonPanelPlugins = new System.Windows.Forms.RibbonPanel();
            this.ribbonButtonPlugins = new System.Windows.Forms.RibbonButton();
            this.ribbonTabActions = new System.Windows.Forms.RibbonTab();
            this.ribbonPanelFileActions = new System.Windows.Forms.RibbonPanel();
            this.rbtSaveFile = new System.Windows.Forms.RibbonButton();
            this.rbtLoadFile = new System.Windows.Forms.RibbonButton();
            this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLocationLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.paintingArea = new MdsPaint.MdsPanel();
            this.panelPaintContainer = new System.Windows.Forms.Panel();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.statusStrip.SuspendLayout();
            this.panelPaintContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Minimized = false;
            this.ribbon.Name = "ribbon";
            // 
            // 
            // 
            this.ribbon.OrbDropDown.BorderRoundness = 8;
            this.ribbon.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItemNew);
            this.ribbon.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItemSave);
            this.ribbon.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItemExit);
            this.ribbon.OrbDropDown.Name = "";
            this.ribbon.OrbDropDown.Size = new System.Drawing.Size(527, 204);
            this.ribbon.OrbDropDown.TabIndex = 0;
            this.ribbon.OrbImage = global::MdsPaint.Properties.Resources.Paint1;
            // 
            // 
            // 
            this.ribbon.QuickAcessToolbar.Items.Add(this.ribbonButtonUndo);
            this.ribbon.QuickAcessToolbar.Items.Add(this.ribbonButtonRedo);
            this.ribbon.Size = new System.Drawing.Size(810, 155);
            this.ribbon.TabIndex = 1;
            this.ribbon.Tabs.Add(this.ribbonTabDrawing);
            this.ribbon.Tabs.Add(this.ribbonTabPlugins);
            this.ribbon.Tabs.Add(this.ribbonTabActions);
            this.ribbon.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.ribbon.Text = "ribbon1";
            // 
            // ribbonOrbMenuItemNew
            // 
            this.ribbonOrbMenuItemNew.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItemNew.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItemNew.Image")));
            this.ribbonOrbMenuItemNew.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItemNew.SmallImage")));
            this.ribbonOrbMenuItemNew.Text = "New";
            // 
            // ribbonOrbMenuItemSave
            // 
            this.ribbonOrbMenuItemSave.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItemSave.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItemSave.Image")));
            this.ribbonOrbMenuItemSave.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItemSave.SmallImage")));
            this.ribbonOrbMenuItemSave.Text = "Save";
            // 
            // ribbonOrbMenuItemExit
            // 
            this.ribbonOrbMenuItemExit.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItemExit.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItemExit.Image")));
            this.ribbonOrbMenuItemExit.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItemExit.SmallImage")));
            this.ribbonOrbMenuItemExit.Text = "Exit";
            this.ribbonOrbMenuItemExit.Click += new System.EventHandler(this.ribbonOrbMenuItemExit_Click);
            // 
            // ribbonButtonUndo
            // 
            this.ribbonButtonUndo.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonUndo.Image")));
            this.ribbonButtonUndo.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonUndo.SmallImage = global::MdsPaint.Properties.Resources.arrow_undo16;
            this.ribbonButtonUndo.Text = "ribbonButton1";
            this.ribbonButtonUndo.Click += new System.EventHandler(this.ribbonButtonUndo_Click);
            // 
            // ribbonButtonRedo
            // 
            this.ribbonButtonRedo.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonRedo.Image")));
            this.ribbonButtonRedo.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonRedo.SmallImage = global::MdsPaint.Properties.Resources.arrow_redo16;
            this.ribbonButtonRedo.Text = "ribbonButton1";
            this.ribbonButtonRedo.Click += new System.EventHandler(this.ribbonButtonRedo_Click);
            // 
            // ribbonTabDrawing
            // 
            this.ribbonTabDrawing.Panels.Add(this.ribbonPanelColorPicking);
            this.ribbonTabDrawing.Panels.Add(this.ribbonPanelShapes);
            this.ribbonTabDrawing.Text = "Drawing";
            // 
            // ribbonPanelColorPicking
            // 
            this.ribbonPanelColorPicking.Items.Add(this.ribbonColorChooser);
            this.ribbonPanelColorPicking.Text = "Colors";
            // 
            // ribbonColorChooser
            // 
            this.ribbonColorChooser.Color = System.Drawing.Color.Black;
            this.ribbonColorChooser.Image = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooser.Image")));
            this.ribbonColorChooser.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooser.SmallImage")));
            this.ribbonColorChooser.Text = "Color Chooser";
            this.ribbonColorChooser.Click += new System.EventHandler(this.ribbonColorChooser_Click);
            // 
            // ribbonPanelShapes
            // 
            this.ribbonPanelShapes.Items.Add(this.ribbonButtonEllipse);
            this.ribbonPanelShapes.Items.Add(this.ribbonButtonRectangle);
            this.ribbonPanelShapes.Text = "Shapes";
            // 
            // ribbonButtonEllipse
            // 
            this.ribbonButtonEllipse.DropDownItems.Add(this.ribbonButton4);
            this.ribbonButtonEllipse.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonEllipse.Image")));
            this.ribbonButtonEllipse.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonEllipse.SmallImage")));
            this.ribbonButtonEllipse.Text = "Ellipse";
            this.ribbonButtonEllipse.Click += new System.EventHandler(this.ribbonButtonEllipse_Click);
            // 
            // ribbonButton4
            // 
            this.ribbonButton4.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.Image")));
            this.ribbonButton4.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.SmallImage")));
            this.ribbonButton4.Text = "ribbonButton4";
            // 
            // ribbonButtonRectangle
            // 
            this.ribbonButtonRectangle.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonRectangle.Image")));
            this.ribbonButtonRectangle.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonRectangle.SmallImage")));
            this.ribbonButtonRectangle.Text = "Rectangle";
            this.ribbonButtonRectangle.Click += new System.EventHandler(this.ribbonButtonRectangle_Click);
            // 
            // ribbonTabPlugins
            // 
            this.ribbonTabPlugins.Panels.Add(this.ribbonPanelPlugins);
            this.ribbonTabPlugins.Text = "Plugins";
            // 
            // ribbonPanelPlugins
            // 
            this.ribbonPanelPlugins.Items.Add(this.ribbonButtonPlugins);
            this.ribbonPanelPlugins.Text = "Plugins";
            // 
            // ribbonButtonPlugins
            // 
            this.ribbonButtonPlugins.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPlugins.Image")));
            this.ribbonButtonPlugins.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPlugins.SmallImage")));
            this.ribbonButtonPlugins.Text = "Import plugins";
            this.ribbonButtonPlugins.Click += new System.EventHandler(this.ribbonButtonPlugins_Click);
            // 
            // ribbonTabActions
            // 
            this.ribbonTabActions.Panels.Add(this.ribbonPanelFileActions);
            this.ribbonTabActions.Panels.Add(this.ribbonPanel1);
            this.ribbonTabActions.Text = "Actions";
            // 
            // ribbonPanelFileActions
            // 
            this.ribbonPanelFileActions.Items.Add(this.rbtSaveFile);
            this.ribbonPanelFileActions.Items.Add(this.rbtLoadFile);
            this.ribbonPanelFileActions.Text = "File";
            // 
            // rbtSaveFile
            // 
            this.rbtSaveFile.Image = ((System.Drawing.Image)(resources.GetObject("rbtSaveFile.Image")));
            this.rbtSaveFile.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtSaveFile.SmallImage")));
            this.rbtSaveFile.Text = "Save file";
            this.rbtSaveFile.Click += new System.EventHandler(this.rbtSaveFile_Click);
            // 
            // rbtLoadFile
            // 
            this.rbtLoadFile.DropDownItems.Add(this.ribbonButton2);
            this.rbtLoadFile.Image = ((System.Drawing.Image)(resources.GetObject("rbtLoadFile.Image")));
            this.rbtLoadFile.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtLoadFile.SmallImage")));
            this.rbtLoadFile.Text = "Load file";
            this.rbtLoadFile.Click += new System.EventHandler(this.rbtLoadFile_Click);
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.Image")));
            this.ribbonButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.SmallImage")));
            this.ribbonButton2.Text = "ribbonButton2";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.ribbonButton1);
            this.ribbonPanel1.Text = "ribbonPanel1";
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Text = "ribbonButton1";
            this.ribbonButton1.Click += new System.EventHandler(this.ribbonButton1_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLocationLabel,
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 497);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(810, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLocationLabel
            // 
            this.toolStripStatusLocationLabel.AutoSize = false;
            this.toolStripStatusLocationLabel.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLocationLabel.Name = "toolStripStatusLocationLabel";
            this.toolStripStatusLocationLabel.Size = new System.Drawing.Size(112, 17);
            this.toolStripStatusLocationLabel.Text = "toolStripStatusLabel";
            this.toolStripStatusLocationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel.Text = "toolStripStatusLabel2";
            // 
            // paintingArea
            // 
            this.paintingArea.BackColor = System.Drawing.Color.White;
            this.paintingArea.Location = new System.Drawing.Point(3, 3);
            this.paintingArea.Name = "paintingArea";
            this.paintingArea.Size = new System.Drawing.Size(281, 223);
            this.paintingArea.TabIndex = 3;
            this.paintingArea.Paint += new System.Windows.Forms.PaintEventHandler(this.paintingArea_Paint);
            this.paintingArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paintingArea_MouseDown);
            this.paintingArea.MouseLeave += new System.EventHandler(this.pbPaintingArea_MouseLeave);
            this.paintingArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbPaintingArea_MouseMove);
            this.paintingArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.paintingArea_MouseUp);
            // 
            // panelPaintContainer
            // 
            this.panelPaintContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPaintContainer.AutoScroll = true;
            this.panelPaintContainer.Controls.Add(this.paintingArea);
            this.panelPaintContainer.Location = new System.Drawing.Point(12, 161);
            this.panelPaintContainer.Name = "panelPaintContainer";
            this.panelPaintContainer.Size = new System.Drawing.Size(786, 333);
            this.panelPaintContainer.TabIndex = 4;
            this.panelPaintContainer.MouseEnter += new System.EventHandler(this.panelPaintContainer_MouseEnter);
            // 
            // PaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(810, 519);
            this.Controls.Add(this.panelPaintContainer);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaintForm";
            this.Text = "Mds paint";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panelPaintContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon;
        private System.Windows.Forms.RibbonTab ribbonTabPlugins;
        private System.Windows.Forms.RibbonPanel ribbonPanelPlugins;
        private System.Windows.Forms.RibbonButton ribbonButtonPlugins;
        private System.Windows.Forms.RibbonTab ribbonTabActions;
        private System.Windows.Forms.RibbonPanel ribbonPanelFileActions;
        private System.Windows.Forms.RibbonButton rbtLoadFile;
        public System.Windows.Forms.StatusStrip statusStrip;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLocationLabel;
        private System.Windows.Forms.RibbonButton ribbonButton2;
        private System.Windows.Forms.RibbonButton rbtSaveFile;
        private RibbonOrbMenuItem ribbonOrbMenuItemNew;
        private RibbonOrbMenuItem ribbonOrbMenuItemSave;
        private RibbonOrbMenuItem ribbonOrbMenuItemExit;
        private RibbonButton ribbonButtonUndo;
        private RibbonButton ribbonButtonRedo;
        private Panel panelPaintContainer;
        private RibbonPanel ribbonPanel1;
        private RibbonButton ribbonButton1;
        private RibbonTab ribbonTabDrawing;
        private RibbonPanel ribbonPanelColorPicking;
        private RibbonColorChooser ribbonColorChooser;
        private ColorDialog colorDialog;
        public MdsPanel paintingArea;
        private RibbonPanel ribbonPanelShapes;
        private RibbonButton ribbonButtonEllipse;
        private RibbonButton ribbonButton4;
        private RibbonButton ribbonButtonRectangle;
    }
}

