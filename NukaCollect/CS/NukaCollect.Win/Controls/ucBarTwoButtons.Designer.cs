namespace NukaCollect.Win.Controls {
    partial class ucBarTwoButtons {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.mainBar = new DevExpress.XtraBars.Bar();
            this.bbiButton0 = new DevExpress.XtraBars.BarButtonItem();
            this.bbiButton1 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager
            // 
            this.barManager.AllowCustomization = false;
            this.barManager.AllowQuickCustomization = false;
            this.barManager.AllowShowToolbarsPopup = false;
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.mainBar});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiButton0,
            this.bbiButton1});
            this.barManager.MaxItemId = 2;
            // 
            // mainBar
            // 
            this.mainBar.BarName = "Main menu";
            this.mainBar.DockCol = 0;
            this.mainBar.DockRow = 0;
            this.mainBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.mainBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiButton0),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiButton1)});
            this.mainBar.OptionsBar.AllowQuickCustomization = false;
            this.mainBar.OptionsBar.DrawDragBorder = false;
            this.mainBar.OptionsBar.UseWholeRow = true;
            this.mainBar.Text = "Main menu";
            // 
            // bbiButton0
            // 
            this.bbiButton0.Caption = "Button0";
            this.bbiButton0.Id = 0;
            this.bbiButton0.Name = "bbiButton0";
            this.bbiButton0.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiButton0.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiButton0_ItemClick);
            // 
            // bbiButton1
            // 
            this.bbiButton1.Caption = "Button1";
            this.bbiButton1.Id = 1;
            this.bbiButton1.Name = "bbiButton1";
            this.bbiButton1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiButton1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiButton1_ItemClick);
            // 
            // ucBarTwoButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ucBarTwoButtons";
            this.Size = new System.Drawing.Size(416, 30);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Bar mainBar;
        private DevExpress.XtraBars.BarButtonItem bbiButton0;
        private DevExpress.XtraBars.BarButtonItem bbiButton1;
    }
}
