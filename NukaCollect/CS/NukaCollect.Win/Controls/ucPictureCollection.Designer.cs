namespace NukaCollect.Win.Controls {
    partial class ucPictureCollection {
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
            this.peImage = new DevExpress.XtraEditors.PictureEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.mainBar = new DevExpress.XtraBars.Bar();
            this.bbiPrev = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecords = new DevExpress.XtraBars.BarStaticItem();
            this.bbiNext = new DevExpress.XtraBars.BarButtonItem();
            this.bbiAdd = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.peImage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // peImage
            // 
            this.peImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.peImage.Location = new System.Drawing.Point(0, 0);
            this.peImage.Name = "peImage";
            this.peImage.Properties.AllowFocused = false;
            this.peImage.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.peImage.Properties.Appearance.Options.UseBackColor = true;
            this.peImage.Properties.ReadOnly = true;
            this.peImage.Properties.ShowMenu = false;
            this.peImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.peImage.Size = new System.Drawing.Size(324, 284);
            this.peImage.TabIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 284);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(324, 4);
            this.panelControl2.TabIndex = 2;
            // 
            // barManager1
            // 
            this.barManager1.AllowCustomization = false;
            this.barManager1.AllowQuickCustomization = false;
            this.barManager1.AllowShowToolbarsPopup = false;
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.mainBar});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiPrev,
            this.bbiNext,
            this.bbiAdd,
            this.bbiDelete,
            this.bsiRecords});
            this.barManager1.MaxItemId = 5;
            // 
            // mainBar
            // 
            this.mainBar.BarName = "Custom 2";
            this.mainBar.DockCol = 0;
            this.mainBar.DockRow = 0;
            this.mainBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.mainBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiPrev),
            new DevExpress.XtraBars.LinkPersistInfo(this.bsiRecords),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiNext),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiDelete)});
            this.mainBar.OptionsBar.AllowQuickCustomization = false;
            this.mainBar.OptionsBar.DrawDragBorder = false;
            this.mainBar.OptionsBar.UseWholeRow = true;
            this.mainBar.Text = "Main menu";
            // 
            // bbiPrev
            // 
            this.bbiPrev.Caption = "Prev";
            this.bbiPrev.Hint = "Previous photo";
            this.bbiPrev.Id = 0;
            this.bbiPrev.ItemShortcut = new DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                            | System.Windows.Forms.Keys.Left));
            this.bbiPrev.Name = "bbiPrev";
            this.bbiPrev.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPrev_ItemClick);
            // 
            // bsiRecords
            // 
            this.bsiRecords.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.bsiRecords.Id = 4;
            this.bsiRecords.Name = "bsiRecords";
            this.bsiRecords.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // bbiNext
            // 
            this.bbiNext.Caption = "Next";
            this.bbiNext.Hint = "Next photo";
            this.bbiNext.Id = 1;
            this.bbiNext.ItemShortcut = new DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                            | System.Windows.Forms.Keys.Right));
            this.bbiNext.Name = "bbiNext";
            this.bbiNext.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNext_ItemClick);
            // 
            // bbiAdd
            // 
            this.bbiAdd.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bbiAdd.Caption = "Add Image";
            this.bbiAdd.Hint = "Add new photo";
            this.bbiAdd.Id = 2;
            this.bbiAdd.Name = "bbiAdd";
            this.bbiAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAdd_ItemClick);
            // 
            // bbiDelete
            // 
            this.bbiDelete.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bbiDelete.Caption = "Delete Image";
            this.bbiDelete.Hint = "Delete current photo";
            this.bbiDelete.Id = 3;
            this.bbiDelete.Name = "bbiDelete";
            this.bbiDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDelete_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(324, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 288);
            this.barDockControlBottom.Size = new System.Drawing.Size(324, 24);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 288);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(324, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 288);
            // 
            // ucPictureCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.peImage);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ucPictureCollection";
            this.Size = new System.Drawing.Size(324, 312);
            ((System.ComponentModel.ISupportInitialize)(this.peImage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit peImage;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar mainBar;
        private DevExpress.XtraBars.BarButtonItem bbiPrev;
        private DevExpress.XtraBars.BarButtonItem bbiNext;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bbiAdd;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarStaticItem bsiRecords;
    }
}
