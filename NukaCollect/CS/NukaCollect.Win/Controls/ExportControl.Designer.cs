namespace NukaCollect.Win.Controls {
    partial class ExportControl {
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
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem1 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem2 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem3 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem4 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem5 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem6 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem7 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem8 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem9 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.exportGallery = new DevExpress.XtraBars.Ribbon.GalleryControl();
            this.galleryControlClient1 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            this.backstageViewLabel1 = new NukaCollect.Win.BackstageViewLabel();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exportGallery)).BeginInit();
            this.exportGallery.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.exportGallery);
            this.splitContainer1.Panel1.Controls.Add(this.backstageViewLabel1);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(20);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.labelControl4);
            this.splitContainer1.Size = new System.Drawing.Size(764, 557);
            this.splitContainer1.SplitterDistance = 378;
            this.splitContainer1.TabIndex = 0;
            // 
            // exportGallery
            // 
            this.exportGallery.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.exportGallery.Controls.Add(this.galleryControlClient1);
            this.exportGallery.DesignGalleryGroupIndex = 0;
            this.exportGallery.DesignGalleryItemIndex = 0;
            this.exportGallery.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // galleryControlGallery1
            // 
            this.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = true;
            this.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = true;
            this.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = true;
            this.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseTextOptions = true;
            this.exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseTextOptions = true;
            this.exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseTextOptions = true;
            this.exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.exportGallery.Gallery.AutoFitColumns = false;
            this.exportGallery.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.None;
            this.exportGallery.Gallery.BackColor = System.Drawing.Color.Transparent;
            this.exportGallery.Gallery.CheckDrawMode = DevExpress.XtraBars.Ribbon.Gallery.CheckDrawMode.OnlyImage;
            this.exportGallery.Gallery.ColumnCount = 1;
            this.exportGallery.Gallery.FixedImageSize = false;
            galleryItemGroup1.Caption = "Group1";
            galleryItem1.Caption = "PDF File";
            galleryItem1.Description = "Adobe Portable Document Format";
            galleryItem2.Caption = "HTML File";
            galleryItem2.Description = "Web Page";
            galleryItem3.Caption = "MHT File";
            galleryItem3.Description = "Single File Web Page";
            galleryItem4.Caption = "RTF File";
            galleryItem4.Description = "Rich Text Format";
            galleryItem5.Caption = "XLS File";
            galleryItem5.Description = "Microsoft Excel 2000-2003 Workbook";
            galleryItem6.Caption = "XLSX File";
            galleryItem6.Description = "Microsoft Excel 2007 Workbook";
            galleryItem7.Caption = "CSV File";
            galleryItem7.Description = "Comma-Separated Values Text";
            galleryItem8.Caption = "Text File";
            galleryItem8.Description = "Plain Text";
            galleryItem9.Caption = "Image File";
            galleryItem9.Description = "BMP, GIF, JPEG, PNG, TIFF, EMF, WMF";
            galleryItemGroup1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            galleryItem1,
            galleryItem2,
            galleryItem3,
            galleryItem4,
            galleryItem5,
            galleryItem6,
            galleryItem7,
            galleryItem8,
            galleryItem9});
            this.exportGallery.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1});
            this.exportGallery.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.exportGallery.Gallery.ShowGroupCaption = false;
            this.exportGallery.Gallery.ShowItemText = true;
            this.exportGallery.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.exportGallery.Gallery.StretchItems = true;
            this.exportGallery.Gallery.ItemClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.galleryControlGallery1_ItemClick);
            this.exportGallery.Location = new System.Drawing.Point(20, 56);
            this.exportGallery.Name = "exportGallery";
            this.exportGallery.Size = new System.Drawing.Size(338, 481);
            this.exportGallery.TabIndex = 1;
            this.exportGallery.Text = "galleryControl1";
            // 
            // galleryControlClient1
            // 
            this.galleryControlClient1.GalleryControl = this.exportGallery;
            this.galleryControlClient1.Location = new System.Drawing.Point(1, 1);
            this.galleryControlClient1.Size = new System.Drawing.Size(336, 479);
            // 
            // backstageViewLabel1
            // 
            this.backstageViewLabel1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backstageViewLabel1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.backstageViewLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.backstageViewLabel1.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.backstageViewLabel1.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.backstageViewLabel1.LineVisible = true;
            this.backstageViewLabel1.Location = new System.Drawing.Point(20, 20);
            this.backstageViewLabel1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.backstageViewLabel1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.backstageViewLabel1.Name = "backstageViewLabel1";
            this.backstageViewLabel1.ShowLineShadow = false;
            this.backstageViewLabel1.Size = new System.Drawing.Size(338, 36);
            this.backstageViewLabel1.TabIndex = 0;
            this.backstageViewLabel1.Text = "Export";
            // 
            // labelControl4
            // 
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelControl4.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl4.LineVisible = true;
            this.labelControl4.Location = new System.Drawing.Point(0, 0);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(4, 557);
            this.labelControl4.TabIndex = 4;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Title = "Export...";
            // 
            // ExportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ExportControl";
            this.Size = new System.Drawing.Size(764, 557);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exportGallery)).EndInit();
            this.exportGallery.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private BackstageViewLabel backstageViewLabel1;
        private DevExpress.XtraBars.Ribbon.GalleryControl exportGallery;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}
