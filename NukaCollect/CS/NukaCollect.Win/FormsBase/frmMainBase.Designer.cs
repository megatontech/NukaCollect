namespace NukaCollect.Win {
    partial class frmMainBase {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.rcMain = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiAbout = new DevExpress.XtraBars.BarButtonItem();
            this.bsUser = new DevExpress.XtraBars.BarStaticItem();
            this.bsData = new DevExpress.XtraBars.BarStaticItem();
            this.rsbMain = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.nbMain = new DevExpress.XtraNavBar.NavBarControl();
            this.pnlControl = new DevExpress.XtraEditors.PanelControl();
            this.pnlMainContainer = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.rcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainContainer)).BeginInit();
            this.pnlMainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // rcMain
            // 
            this.rcMain.ApplicationButtonText = null;
            // 
            // 
            // 
            this.rcMain.ExpandCollapseItem.Id = 0;
            this.rcMain.ExpandCollapseItem.Name = "";
            this.rcMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rcMain.ExpandCollapseItem,
            this.bbiAbout,
            this.bsUser,
            this.bsData});
            this.rcMain.Location = new System.Drawing.Point(0, 0);
            this.rcMain.MaxItemId = 4;
            this.rcMain.Name = "rcMain";
            this.rcMain.PageHeaderItemLinks.Add(this.bbiAbout);
            this.rcMain.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.rcMain.Size = new System.Drawing.Size(1076, 54);
            this.rcMain.StatusBar = this.rsbMain;
            // 
            // bbiAbout
            // 
            this.bbiAbout.Caption = "About";
            this.bbiAbout.Hint = "About this Demo";
            this.bbiAbout.Id = 0;
            this.bbiAbout.Name = "bbiAbout";
            this.bbiAbout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAbout_ItemClick);
            // 
            // bsUser
            // 
            this.bsUser.Id = 1;
            this.bsUser.Name = "bsUser";
            this.bsUser.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // bsData
            // 
            this.bsData.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring;
            this.bsData.Id = 2;
            this.bsData.LeftIndent = 4;
            this.bsData.Name = "bsData";
            this.bsData.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // rsbMain
            // 
            this.rsbMain.ItemLinks.Add(this.bsUser);
            this.rsbMain.ItemLinks.Add(this.bsData);
            this.rsbMain.Location = new System.Drawing.Point(0, 667);
            this.rsbMain.Name = "rsbMain";
            this.rsbMain.Ribbon = this.rcMain;
            this.rsbMain.Size = new System.Drawing.Size(1076, 23);
            // 
            // nbMain
            // 
            this.nbMain.ActiveGroup = null;
            this.nbMain.AllowSelectedLink = true;
            this.nbMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.nbMain.Location = new System.Drawing.Point(6, 6);
            this.nbMain.Name = "nbMain";
            this.nbMain.OptionsNavPane.ExpandedWidth = 186;
            this.nbMain.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.nbMain.Size = new System.Drawing.Size(158, 601);
            this.nbMain.TabIndex = 2;
            this.nbMain.Text = "navBarControl1";
            this.nbMain.Resize += new System.EventHandler(this.nbMain_Resize);
            // 
            // pnlControl
            // 
            this.pnlControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControl.Location = new System.Drawing.Point(180, 54);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(896, 613);
            this.pnlControl.TabIndex = 4;
            // 
            // pnlMainContainer
            // 
            this.pnlMainContainer.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlMainContainer.Controls.Add(this.nbMain);
            this.pnlMainContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMainContainer.Location = new System.Drawing.Point(0, 54);
            this.pnlMainContainer.Name = "pnlMainContainer";
            this.pnlMainContainer.Padding = new System.Windows.Forms.Padding(6, 6, 0, 6);
            this.pnlMainContainer.Size = new System.Drawing.Size(180, 613);
            this.pnlMainContainer.TabIndex = 7;
            // 
            // frmMainBase
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 690);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.pnlMainContainer);
            this.Controls.Add(this.rsbMain);
            this.Controls.Add(this.rcMain);
            this.KeyPreview = true;
            this.Name = "frmMainBase";
            this.Ribbon = this.rcMain;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.rsbMain;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.rcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainContainer)).EndInit();
            this.pnlMainContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonStatusBar rsbMain;
        private DevExpress.XtraNavBar.NavBarControl nbMain;
        private DevExpress.XtraBars.BarStaticItem bsUser;
        private DevExpress.XtraBars.BarStaticItem bsData;
        protected DevExpress.XtraBars.Ribbon.RibbonControl rcMain;
        private DevExpress.XtraEditors.PanelControl pnlMainContainer;
        protected DevExpress.XtraBars.BarButtonItem bbiAbout;
        protected DevExpress.XtraEditors.PanelControl pnlControl;
    }
}

