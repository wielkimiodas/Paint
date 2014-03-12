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
      this.ribbonOrbMenuItemNew = new System.Windows.Forms.RibbonOrbMenuItem();
      this.ribbonOrbMenuItemSave = new System.Windows.Forms.RibbonOrbMenuItem();
      this.ribbonOrbMenuItemExit = new System.Windows.Forms.RibbonOrbMenuItem();
      this.ribbonButtonUndo = new System.Windows.Forms.RibbonButton();
      this.ribbonButtonRedo = new System.Windows.Forms.RibbonButton();
      this.ribbonTabDrawing = new System.Windows.Forms.RibbonTab();
      this.ribbonPanelColorPicking = new System.Windows.Forms.RibbonPanel();
      this.ribbonColorChooserBorder = new System.Windows.Forms.RibbonColorChooser();
      this.ribbonColorChooserFilling = new System.Windows.Forms.RibbonColorChooser();
      this.ribbonComboBoxFillingStyle = new System.Windows.Forms.RibbonComboBox();
      this.rlNone = new System.Windows.Forms.RibbonLabel();
      this.rlSolid = new System.Windows.Forms.RibbonLabel();
      this.rlCross = new System.Windows.Forms.RibbonLabel();
      this.rlChess = new System.Windows.Forms.RibbonLabel();
      this.rlDots = new System.Windows.Forms.RibbonLabel();
      this.rlShingles = new System.Windows.Forms.RibbonLabel();
      this.ribbonPanelShapes = new System.Windows.Forms.RibbonPanel();
      this.ribbonButtonList1 = new System.Windows.Forms.RibbonButtonList();
      this.rbShapeEllipse = new System.Windows.Forms.RibbonButton();
      this.rbShapeRectangle = new System.Windows.Forms.RibbonButton();
      this.rbShapeLine = new System.Windows.Forms.RibbonButton();
      this.ribbonPanelPenStyles = new System.Windows.Forms.RibbonPanel();
      this.ribbonComboBoxThickness = new System.Windows.Forms.RibbonComboBox();
      this.rbThicknessThin = new System.Windows.Forms.RibbonButton();
      this.rbThicknessNormal = new System.Windows.Forms.RibbonButton();
      this.rbThicknessWide = new System.Windows.Forms.RibbonButton();
      this.ribbonSeparator1 = new System.Windows.Forms.RibbonSeparator();
      this.ribbonButtonListPenStyles = new System.Windows.Forms.RibbonButtonList();
      this.rbDash = new System.Windows.Forms.RibbonButton();
      this.rbSolid = new System.Windows.Forms.RibbonButton();
      this.rbDotted = new System.Windows.Forms.RibbonButton();
      this.ribbonTabPlugins = new System.Windows.Forms.RibbonTab();
      this.ribbonPanelPlugins = new System.Windows.Forms.RibbonPanel();
      this.ribbonButtonPlugins = new System.Windows.Forms.RibbonButton();
      this.statusStrip = new System.Windows.Forms.StatusStrip();
      this.toolStripStatusLocationLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.panelPaintContainer = new System.Windows.Forms.Panel();
      this.paintingArea = new MdsPaint.MdsPanel();
      this.colorDialog = new System.Windows.Forms.ColorDialog();
      this.ribbon = new System.Windows.Forms.Ribbon();
      this.ribbonSeparator2 = new System.Windows.Forms.RibbonSeparator();
      this.ribbonOrbMenuItemLoad = new System.Windows.Forms.RibbonOrbMenuItem();
      this.ribbonSeparator3 = new System.Windows.Forms.RibbonSeparator();
      this.ribbonOrbMenuItemAbout = new System.Windows.Forms.RibbonOrbMenuItem();
      this.ribbonSeparator4 = new System.Windows.Forms.RibbonSeparator();
      this.statusStrip.SuspendLayout();
      this.panelPaintContainer.SuspendLayout();
      this.SuspendLayout();
      // 
      // ribbonOrbMenuItemNew
      // 
      this.ribbonOrbMenuItemNew.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
      this.ribbonOrbMenuItemNew.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItemNew.Image")));
      this.ribbonOrbMenuItemNew.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItemNew.SmallImage")));
      this.ribbonOrbMenuItemNew.Text = "New";
      this.ribbonOrbMenuItemNew.Click += new System.EventHandler(this.ribbonOrbMenuItemNew_Click);
      // 
      // ribbonOrbMenuItemSave
      // 
      this.ribbonOrbMenuItemSave.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
      this.ribbonOrbMenuItemSave.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItemSave.Image")));
      this.ribbonOrbMenuItemSave.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItemSave.SmallImage")));
      this.ribbonOrbMenuItemSave.Text = "Save";
      this.ribbonOrbMenuItemSave.Click += new System.EventHandler(this.ribbonOrbMenuItemSave_Click);
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
      this.ribbonButtonRedo.Enabled = false;
      this.ribbonButtonRedo.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonRedo.Image")));
      this.ribbonButtonRedo.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
      this.ribbonButtonRedo.SmallImage = global::MdsPaint.Properties.Resources.arrow_redo16;
      this.ribbonButtonRedo.Text = "";
      this.ribbonButtonRedo.Click += new System.EventHandler(this.ribbonButtonRedo_Click);
      // 
      // ribbonTabDrawing
      // 
      this.ribbonTabDrawing.Panels.Add(this.ribbonPanelColorPicking);
      this.ribbonTabDrawing.Panels.Add(this.ribbonPanelShapes);
      this.ribbonTabDrawing.Panels.Add(this.ribbonPanelPenStyles);
      this.ribbonTabDrawing.Text = "Drawing";
      // 
      // ribbonPanelColorPicking
      // 
      this.ribbonPanelColorPicking.Items.Add(this.ribbonColorChooserBorder);
      this.ribbonPanelColorPicking.Items.Add(this.ribbonColorChooserFilling);
      this.ribbonPanelColorPicking.Items.Add(this.ribbonComboBoxFillingStyle);
      this.ribbonPanelColorPicking.Text = "Colors";
      // 
      // ribbonColorChooserBorder
      // 
      this.ribbonColorChooserBorder.Color = System.Drawing.Color.Black;
      this.ribbonColorChooserBorder.Image = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserBorder.Image")));
      this.ribbonColorChooserBorder.ImageColorHeight = 20;
      this.ribbonColorChooserBorder.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserBorder.SmallImage")));
      this.ribbonColorChooserBorder.Text = "Border";
      this.ribbonColorChooserBorder.Click += new System.EventHandler(this.ribbonColorChooser_Click);
      // 
      // ribbonColorChooserFilling
      // 
      this.ribbonColorChooserFilling.CheckOnClick = true;
      this.ribbonColorChooserFilling.Color = System.Drawing.Color.LimeGreen;
      this.ribbonColorChooserFilling.Image = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserFilling.Image")));
      this.ribbonColorChooserFilling.ImageColorHeight = 20;
      this.ribbonColorChooserFilling.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserFilling.SmallImage")));
      this.ribbonColorChooserFilling.Text = "Filling";
      this.ribbonColorChooserFilling.Click += new System.EventHandler(this.ribbonColorChooserFilling_Click);
      // 
      // ribbonComboBoxFillingStyle
      // 
      this.ribbonComboBoxFillingStyle.AllowTextEdit = false;
      this.ribbonComboBoxFillingStyle.DropDownItems.Add(this.rlNone);
      this.ribbonComboBoxFillingStyle.DropDownItems.Add(this.rlSolid);
      this.ribbonComboBoxFillingStyle.DropDownItems.Add(this.rlCross);
      this.ribbonComboBoxFillingStyle.DropDownItems.Add(this.rlChess);
      this.ribbonComboBoxFillingStyle.DropDownItems.Add(this.rlDots);
      this.ribbonComboBoxFillingStyle.DropDownItems.Add(this.rlShingles);
      this.ribbonComboBoxFillingStyle.Text = "";
      this.ribbonComboBoxFillingStyle.TextBoxText = "None";
      this.ribbonComboBoxFillingStyle.DropDownItemClicked += new System.Windows.Forms.RibbonComboBox.RibbonItemEventHandler(this.ribbonComboBoxFillingStyle_DropDownItemClicked);
      // 
      // rlNone
      // 
      this.rlNone.Text = "None";
      this.rlNone.Value = "0";
      // 
      // rlSolid
      // 
      this.rlSolid.Text = "Solid";
      this.rlSolid.Value = "5";
      // 
      // rlCross
      // 
      this.rlCross.Text = "Crosses";
      this.rlCross.Value = "1";
      // 
      // rlChess
      // 
      this.rlChess.Text = "Chess";
      this.rlChess.Value = "2";
      // 
      // rlDots
      // 
      this.rlDots.Text = "Dots";
      this.rlDots.Value = "3";
      // 
      // rlShingles
      // 
      this.rlShingles.Text = "Shingles";
      this.rlShingles.Value = "4";
      // 
      // ribbonPanelShapes
      // 
      this.ribbonPanelShapes.Items.Add(this.ribbonButtonList1);
      this.ribbonPanelShapes.Text = "Shapes";
      // 
      // ribbonButtonList1
      // 
      this.ribbonButtonList1.Buttons.Add(this.rbShapeEllipse);
      this.ribbonButtonList1.Buttons.Add(this.rbShapeRectangle);
      this.ribbonButtonList1.Buttons.Add(this.rbShapeLine);
      this.ribbonButtonList1.ButtonsSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
      this.ribbonButtonList1.FlowToBottom = false;
      this.ribbonButtonList1.ItemsSizeInDropwDownMode = new System.Drawing.Size(7, 5);
      this.ribbonButtonList1.Text = "ribbonButtonList1";
      // 
      // rbShapeEllipse
      // 
      this.rbShapeEllipse.Image = ((System.Drawing.Image)(resources.GetObject("rbShapeEllipse.Image")));
      this.rbShapeEllipse.MaximumSize = new System.Drawing.Size(32, 32);
      this.rbShapeEllipse.SmallImage = global::MdsPaint.Properties.Resources._14_ellipse;
      this.rbShapeEllipse.Text = "ribbonButton3";
      this.rbShapeEllipse.Click += new System.EventHandler(this.rbShapeEllipse_Click);
      // 
      // rbShapeRectangle
      // 
      this.rbShapeRectangle.Image = ((System.Drawing.Image)(resources.GetObject("rbShapeRectangle.Image")));
      this.rbShapeRectangle.MaximumSize = new System.Drawing.Size(32, 32);
      this.rbShapeRectangle.SmallImage = global::MdsPaint.Properties.Resources._14_rectangle;
      this.rbShapeRectangle.Text = "ribbonButton5";
      this.rbShapeRectangle.Click += new System.EventHandler(this.rbShapeRectangle_Click);
      // 
      // rbShapeLine
      // 
      this.rbShapeLine.Image = global::MdsPaint.Properties.Resources.strokeLine;
      this.rbShapeLine.MaximumSize = new System.Drawing.Size(32, 32);
      this.rbShapeLine.SmallImage = global::MdsPaint.Properties.Resources.strokeLinesmall;
      this.rbShapeLine.Text = "";
      this.rbShapeLine.Click += new System.EventHandler(this.rbShapeLine_Click);
      // 
      // ribbonPanelPenStyles
      // 
      this.ribbonPanelPenStyles.Items.Add(this.ribbonComboBoxThickness);
      this.ribbonPanelPenStyles.Items.Add(this.ribbonSeparator1);
      this.ribbonPanelPenStyles.Items.Add(this.ribbonButtonListPenStyles);
      this.ribbonPanelPenStyles.Text = "Pen styles";
      // 
      // ribbonComboBoxThickness
      // 
      this.ribbonComboBoxThickness.AllowTextEdit = false;
      this.ribbonComboBoxThickness.DropDownItems.Add(this.rbThicknessThin);
      this.ribbonComboBoxThickness.DropDownItems.Add(this.rbThicknessNormal);
      this.ribbonComboBoxThickness.DropDownItems.Add(this.rbThicknessWide);
      this.ribbonComboBoxThickness.Text = "";
      this.ribbonComboBoxThickness.TextBoxText = "Thin";
      this.ribbonComboBoxThickness.DropDownItemClicked += new System.Windows.Forms.RibbonComboBox.RibbonItemEventHandler(this.ribbonComboBoxThickness_DropDownItemClicked);
      // 
      // rbThicknessThin
      // 
      this.rbThicknessThin.Image = global::MdsPaint.Properties.Resources.thin;
      this.rbThicknessThin.SmallImage = global::MdsPaint.Properties.Resources.thin;
      this.rbThicknessThin.Text = "Thin";
      this.rbThicknessThin.Value = "1";
      // 
      // rbThicknessNormal
      // 
      this.rbThicknessNormal.Image = global::MdsPaint.Properties.Resources.normal;
      this.rbThicknessNormal.SmallImage = global::MdsPaint.Properties.Resources.normal;
      this.rbThicknessNormal.Text = "Normal";
      this.rbThicknessNormal.Value = "3";
      // 
      // rbThicknessWide
      // 
      this.rbThicknessWide.Image = global::MdsPaint.Properties.Resources.wide;
      this.rbThicknessWide.SmallImage = global::MdsPaint.Properties.Resources.wide;
      this.rbThicknessWide.Text = "Wide";
      this.rbThicknessWide.Value = "5";
      // 
      // ribbonButtonListPenStyles
      // 
      this.ribbonButtonListPenStyles.Buttons.Add(this.rbDash);
      this.ribbonButtonListPenStyles.Buttons.Add(this.rbSolid);
      this.ribbonButtonListPenStyles.Buttons.Add(this.rbDotted);
      this.ribbonButtonListPenStyles.ButtonsSizeMode = System.Windows.Forms.RibbonElementSizeMode.DropDown;
      this.ribbonButtonListPenStyles.FlowToBottom = false;
      this.ribbonButtonListPenStyles.ItemsSizeInDropwDownMode = new System.Drawing.Size(7, 5);
      this.ribbonButtonListPenStyles.Text = "";
      // 
      // rbDash
      // 
      this.rbDash.Image = global::MdsPaint.Properties.Resources._1394593294_border_color;
      this.rbDash.SmallImage = global::MdsPaint.Properties.Resources._1394593294_border_color;
      this.rbDash.Text = "";
      this.rbDash.Click += new System.EventHandler(this.rbDash_Click);
      // 
      // rbSolid
      // 
      this.rbSolid.Image = global::MdsPaint.Properties.Resources._1394593294_border_color1;
      this.rbSolid.SmallImage = global::MdsPaint.Properties.Resources._1394593294_border_color1;
      this.rbSolid.Text = "";
      this.rbSolid.Click += new System.EventHandler(this.rbSolid_Click);
      // 
      // rbDotted
      // 
      this.rbDotted.Image = global::MdsPaint.Properties.Resources.border_color_dot;
      this.rbDotted.SmallImage = global::MdsPaint.Properties.Resources.border_color_dot;
      this.rbDotted.Text = "";
      this.rbDotted.Click += new System.EventHandler(this.rbDotted_Click);
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
      this.toolStripStatusLabel.Visible = false;
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
      // ribbon
      // 
      this.ribbon.BackColor = System.Drawing.SystemColors.InactiveCaption;
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
      this.ribbon.OrbDropDown.MenuItems.Add(this.ribbonSeparator2);
      this.ribbon.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItemSave);
      this.ribbon.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItemLoad);
      this.ribbon.OrbDropDown.MenuItems.Add(this.ribbonSeparator3);
      this.ribbon.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItemAbout);
      this.ribbon.OrbDropDown.MenuItems.Add(this.ribbonSeparator4);
      this.ribbon.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItemExit);
      this.ribbon.OrbDropDown.Name = "";
      this.ribbon.OrbDropDown.Size = new System.Drawing.Size(527, 301);
      this.ribbon.OrbDropDown.TabIndex = 0;
      this.ribbon.OrbImage = global::MdsPaint.Properties.Resources.Paint_glyph;
      this.ribbon.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2010;
      // 
      // 
      // 
      this.ribbon.QuickAcessToolbar.Items.Add(this.ribbonButtonUndo);
      this.ribbon.QuickAcessToolbar.Items.Add(this.ribbonButtonRedo);
      this.ribbon.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
      this.ribbon.Size = new System.Drawing.Size(810, 155);
      this.ribbon.TabIndex = 1;
      this.ribbon.Tabs.Add(this.ribbonTabDrawing);
      this.ribbon.Tabs.Add(this.ribbonTabPlugins);
      this.ribbon.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
      this.ribbon.Text = "ribbon1";
      this.ribbon.ThemeColor = System.Windows.Forms.RibbonTheme.Blue;
      // 
      // ribbonOrbMenuItemLoad
      // 
      this.ribbonOrbMenuItemLoad.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
      this.ribbonOrbMenuItemLoad.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItemLoad.Image")));
      this.ribbonOrbMenuItemLoad.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItemLoad.SmallImage")));
      this.ribbonOrbMenuItemLoad.Text = "Load";
      this.ribbonOrbMenuItemLoad.Click += new System.EventHandler(this.ribbonOrbMenuItemLoad_Click);
      // 
      // ribbonOrbMenuItemAbout
      // 
      this.ribbonOrbMenuItemAbout.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
      this.ribbonOrbMenuItemAbout.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItemAbout.Image")));
      this.ribbonOrbMenuItemAbout.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItemAbout.SmallImage")));
      this.ribbonOrbMenuItemAbout.Text = "About";
      this.ribbonOrbMenuItemAbout.Click += new System.EventHandler(this.ribbonOrbMenuItemAbout_Click);
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
      this.KeyPreview = true;
      this.Name = "PaintForm";
      this.Text = "Mds paint";
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PaintForm_KeyDown);
      this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PaintForm_KeyUp);
      this.statusStrip.ResumeLayout(false);
      this.statusStrip.PerformLayout();
      this.panelPaintContainer.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RibbonTab ribbonTabPlugins;
        private System.Windows.Forms.RibbonPanel ribbonPanelPlugins;
        private System.Windows.Forms.RibbonButton ribbonButtonPlugins;
        public System.Windows.Forms.StatusStrip statusStrip;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLocationLabel;
        private RibbonOrbMenuItem ribbonOrbMenuItemNew;
        private RibbonOrbMenuItem ribbonOrbMenuItemSave;
        private RibbonOrbMenuItem ribbonOrbMenuItemExit;
        private RibbonButton ribbonButtonUndo;
        private RibbonButton ribbonButtonRedo;
        private Panel panelPaintContainer;
        private RibbonTab ribbonTabDrawing;
        private RibbonPanel ribbonPanelColorPicking;
        private RibbonColorChooser ribbonColorChooserBorder;
        private ColorDialog colorDialog;
        private RibbonPanel ribbonPanelShapes;
        private MdsPanel paintingArea;
        private RibbonPanel ribbonPanelPenStyles;
        private RibbonComboBox ribbonComboBoxThickness;
        private RibbonButton rbThicknessThin;
        private RibbonButton rbThicknessNormal;
        private RibbonButton rbThicknessWide;
        private RibbonButtonList ribbonButtonList1;
        private RibbonButton rbShapeEllipse;
        private RibbonButton rbShapeRectangle;
        private RibbonButton rbShapeLine;
        private RibbonSeparator ribbonSeparator1;
        private RibbonButtonList ribbonButtonListPenStyles;
        private RibbonButton rbDash;
        private RibbonButton rbSolid;
        private RibbonColorChooser ribbonColorChooserFilling;
        private Ribbon ribbon;
        private RibbonButton rbDotted;
        private RibbonComboBox ribbonComboBoxFillingStyle;
        private RibbonLabel rlNone;
        private RibbonLabel rlCross;
        private RibbonLabel rlDots;
        private RibbonLabel rlChess;
        private RibbonLabel rlShingles;
        private RibbonLabel rlSolid;
        private RibbonOrbMenuItem ribbonOrbMenuItemLoad;
        private RibbonSeparator ribbonSeparator2;
        private RibbonSeparator ribbonSeparator3;
        private RibbonOrbMenuItem ribbonOrbMenuItemAbout;
        private RibbonSeparator ribbonSeparator4;
    }
}

