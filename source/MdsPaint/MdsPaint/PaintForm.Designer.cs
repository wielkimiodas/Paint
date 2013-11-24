using System.Windows.Forms;

namespace MdsPaint
{
    partial class PaintForm
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
            this.ribbonTabPlugins = new System.Windows.Forms.RibbonTab();
            this.ribbonPanelPlugins = new System.Windows.Forms.RibbonPanel();
            this.ribbonButtonPlugins = new System.Windows.Forms.RibbonButton();
            this.ribbonTabActions = new System.Windows.Forms.RibbonTab();
            this.ribbonPanelFileActions = new System.Windows.Forms.RibbonPanel();
            this.rbtLoadFile = new System.Windows.Forms.RibbonButton();
            this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
            this.rbtSaveFile = new System.Windows.Forms.RibbonButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLocationLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbPaintingArea = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.ribbon.OrbDropDown.Name = "";
            this.ribbon.OrbDropDown.Size = new System.Drawing.Size(527, 447);
            this.ribbon.OrbDropDown.TabIndex = 0;
            this.ribbon.OrbImage = null;
            this.ribbon.Size = new System.Drawing.Size(810, 155);
            this.ribbon.TabIndex = 1;
            this.ribbon.Tabs.Add(this.ribbonTabPlugins);
            this.ribbon.Tabs.Add(this.ribbonTabActions);
            this.ribbon.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.ribbon.Text = "ribbon1";
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
            this.ribbonTabActions.Text = "Actions";
            // 
            // ribbonPanelFileActions
            // 
            this.ribbonPanelFileActions.Items.Add(this.rbtLoadFile);
            this.ribbonPanelFileActions.Items.Add(this.rbtSaveFile);
            this.ribbonPanelFileActions.Text = "File";
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
            // rbtSaveFile
            // 
            this.rbtSaveFile.Image = ((System.Drawing.Image)(resources.GetObject("rbtSaveFile.Image")));
            this.rbtSaveFile.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtSaveFile.SmallImage")));
            this.rbtSaveFile.Text = "Save to a file";
            this.rbtSaveFile.Click += new System.EventHandler(this.rbtSaveFile_Click);
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
            this.toolStripStatusLocationLabel.Name = "toolStripStatusLocationLabel";
            this.toolStripStatusLocationLabel.Size = new System.Drawing.Size(112, 17);
            this.toolStripStatusLocationLabel.Text = "toolStripStatusLabel";
            this.toolStripStatusLocationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel.Text = "toolStripStatusLabel2";
            // 
            // pbPaintingArea
            // 
            this.pbPaintingArea.BackColor = System.Drawing.Color.White;
            this.pbPaintingArea.Location = new System.Drawing.Point(12, 161);
            this.pbPaintingArea.Name = "pbPaintingArea";
            this.pbPaintingArea.Size = new System.Drawing.Size(309, 234);
            this.pbPaintingArea.TabIndex = 3;
            this.pbPaintingArea.SizeChanged += new System.EventHandler(this.pbPaintingArea_SizeChanged);
            this.pbPaintingArea.Paint += new System.Windows.Forms.PaintEventHandler(this.pbPaintingArea_Paint);
            this.pbPaintingArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbPaintingArea_MouseDown);
            this.pbPaintingArea.MouseLeave += new System.EventHandler(this.pbPaintingArea_MouseLeave);
            this.pbPaintingArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbPaintingArea_MouseMove);
            this.pbPaintingArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbPaintingArea_MouseUp);
            this.pbPaintingArea.Resize += new System.EventHandler(this.pbPaintingArea_Resize);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(418, 161);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 201);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // PaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 519);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbPaintingArea);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.ribbon);
            this.Name = "PaintForm";
            this.Text = "Mds paint";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaintForm_MouseDown);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        public System.Windows.Forms.Panel pbPaintingArea;
        private PictureBox pictureBox1;
    }
}

