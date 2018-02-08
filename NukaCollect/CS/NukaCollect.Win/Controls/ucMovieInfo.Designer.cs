namespace NukaCollect.Win.Controls {
    partial class ucMovieInfo {
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
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.pePhoto = new DevExpress.XtraEditors.PictureEdit();
            this.lcInfo = new DevExpress.XtraEditors.LabelControl();
            this.lcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciInfo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciPhoto = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pePhoto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.pePhoto);
            this.lcMain.Controls.Add(this.lcInfo);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 0);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.lcgMain;
            this.lcMain.Size = new System.Drawing.Size(639, 116);
            this.lcMain.TabIndex = 0;
            this.lcMain.Text = "layoutControl1";
            // 
            // pePhoto
            // 
            this.pePhoto.Location = new System.Drawing.Point(561, 2);
            this.pePhoto.Name = "pePhoto";
            this.pePhoto.Properties.AllowFocused = false;
            this.pePhoto.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pePhoto.Properties.Appearance.Options.UseBackColor = true;
            this.pePhoto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pePhoto.Properties.NullText = " ";
            this.pePhoto.Properties.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.pePhoto.Properties.ReadOnly = true;
            this.pePhoto.Properties.ShowMenu = false;
            this.pePhoto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pePhoto.Size = new System.Drawing.Size(76, 112);
            this.pePhoto.StyleController = this.lcMain;
            this.pePhoto.TabIndex = 4;
            this.pePhoto.Resize += new System.EventHandler(this.pePhoto_Resize);
            this.pePhoto.DoubleClick += new System.EventHandler(this.pePhoto_DoubleClick);
            // 
            // lcInfo
            // 
            this.lcInfo.AllowHtmlString = true;
            this.lcInfo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.lcInfo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lcInfo.Location = new System.Drawing.Point(2, 2);
            this.lcInfo.Name = "lcInfo";
            this.lcInfo.Size = new System.Drawing.Size(555, 112);
            this.lcInfo.StyleController = this.lcMain;
            this.lcInfo.TabIndex = 5;
            this.lcInfo.DoubleClick += new System.EventHandler(this.lcInfo_DoubleClick);
            // 
            // lcgMain
            // 
            this.lcgMain.CustomizationFormText = "lcgMain";
            this.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgMain.GroupBordersVisible = false;
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciInfo,
            this.lciPhoto});
            this.lcgMain.Location = new System.Drawing.Point(0, 0);
            this.lcgMain.Name = "lcgMain";
            this.lcgMain.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgMain.Size = new System.Drawing.Size(639, 116);
            this.lcgMain.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgMain.Text = "lcgMain";
            this.lcgMain.TextVisible = false;
            // 
            // lciInfo
            // 
            this.lciInfo.Control = this.lcInfo;
            this.lciInfo.CustomizationFormText = "lciInfo";
            this.lciInfo.Location = new System.Drawing.Point(0, 0);
            this.lciInfo.MinSize = new System.Drawing.Size(67, 17);
            this.lciInfo.Name = "lciInfo";
            this.lciInfo.Size = new System.Drawing.Size(559, 116);
            this.lciInfo.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciInfo.Text = "lciInfo";
            this.lciInfo.TextSize = new System.Drawing.Size(0, 0);
            this.lciInfo.TextToControlDistance = 0;
            this.lciInfo.TextVisible = false;
            // 
            // lciPhoto
            // 
            this.lciPhoto.Control = this.pePhoto;
            this.lciPhoto.CustomizationFormText = "lciPhoto";
            this.lciPhoto.Location = new System.Drawing.Point(559, 0);
            this.lciPhoto.Name = "lciPhoto";
            this.lciPhoto.Size = new System.Drawing.Size(80, 116);
            this.lciPhoto.Text = "lciPhoto";
            this.lciPhoto.TextSize = new System.Drawing.Size(0, 0);
            this.lciPhoto.TextToControlDistance = 0;
            this.lciPhoto.TextVisible = false;
            // 
            // ucMovieInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lcMain);
            this.Name = "ucMovieInfo";
            this.Size = new System.Drawing.Size(639, 116);
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pePhoto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraEditors.LabelControl lcInfo;
        private DevExpress.XtraEditors.PictureEdit pePhoto;
        private DevExpress.XtraLayout.LayoutControlGroup lcgMain;
        private DevExpress.XtraLayout.LayoutControlItem lciPhoto;
        private DevExpress.XtraLayout.LayoutControlItem lciInfo;
    }
}
