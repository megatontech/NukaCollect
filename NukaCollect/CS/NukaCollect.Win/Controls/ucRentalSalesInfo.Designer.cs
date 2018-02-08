namespace NukaCollect.Win.Controls {
    partial class ucRentalSalesInfo {
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
            this.lbItemsCount = new DevExpress.XtraEditors.LabelControl();
            this.teDefaultDays = new DevExpress.XtraEditors.TextEdit();
            this.teDefaultPrice = new DevExpress.XtraEditors.TextEdit();
            this.lbItemsInfo = new DevExpress.XtraEditors.LabelControl();
            this.lcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciDefaultDays = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDefaultPrice = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciItemsInfo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciItemsCount = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teDefaultDays.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDefaultPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDefaultDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDefaultPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciItemsInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciItemsCount)).BeginInit();
            this.SuspendLayout();
            // 
            // lcMain
            // 
            this.lcMain.AllowCustomizationMenu = false;
            this.lcMain.Controls.Add(this.lbItemsCount);
            this.lcMain.Controls.Add(this.teDefaultDays);
            this.lcMain.Controls.Add(this.teDefaultPrice);
            this.lcMain.Controls.Add(this.lbItemsInfo);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 0);
            this.lcMain.Name = "lcMain";
            this.lcMain.Padding = new System.Windows.Forms.Padding(3);
            this.lcMain.Root = this.lcgMain;
            this.lcMain.Size = new System.Drawing.Size(510, 160);
            this.lcMain.TabIndex = 0;
            this.lcMain.Text = "layoutControl1";
            // 
            // lbItemsCount
            // 
            this.lbItemsCount.AllowHtmlString = true;
            this.lbItemsCount.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbItemsCount.Location = new System.Drawing.Point(12, 2);
            this.lbItemsCount.Name = "lbItemsCount";
            this.lbItemsCount.Size = new System.Drawing.Size(486, 13);
            this.lbItemsCount.StyleController = this.lcMain;
            this.lbItemsCount.TabIndex = 8;
            this.lbItemsCount.Text = "Items count: <b>00</b>.";
            // 
            // teDefaultDays
            // 
            this.teDefaultDays.Location = new System.Drawing.Point(116, 36);
            this.teDefaultDays.Name = "teDefaultDays";
            this.teDefaultDays.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.teDefaultDays.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.teDefaultDays.Properties.Mask.EditMask = "n0";
            this.teDefaultDays.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.teDefaultDays.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.teDefaultDays.Properties.ReadOnly = true;
            this.teDefaultDays.Size = new System.Drawing.Size(382, 20);
            this.teDefaultDays.StyleController = this.lcMain;
            this.teDefaultDays.TabIndex = 6;
            // 
            // teDefaultPrice
            // 
            this.teDefaultPrice.Location = new System.Drawing.Point(116, 60);
            this.teDefaultPrice.Name = "teDefaultPrice";
            this.teDefaultPrice.Properties.Appearance.Options.UseTextOptions = true;
            this.teDefaultPrice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.teDefaultPrice.Properties.Mask.EditMask = "c";
            this.teDefaultPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.teDefaultPrice.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.teDefaultPrice.Properties.ReadOnly = true;
            this.teDefaultPrice.Size = new System.Drawing.Size(382, 20);
            this.teDefaultPrice.StyleController = this.lcMain;
            this.teDefaultPrice.TabIndex = 4;
            // 
            // lbItemsInfo
            // 
            this.lbItemsInfo.AllowHtmlString = true;
            this.lbItemsInfo.Location = new System.Drawing.Point(12, 19);
            this.lbItemsInfo.Name = "lbItemsInfo";
            this.lbItemsInfo.Size = new System.Drawing.Size(368, 13);
            this.lbItemsInfo.StyleController = this.lcMain;
            this.lbItemsInfo.TabIndex = 7;
            this.lbItemsInfo.Text = "Of them <b>00</b> in rent, <b>00</b> active, <b>00</b> for sell, <b>00</b> lost, " +
                "<b>00</b> damage, <b>00</b> sold out.";
            // 
            // lcgMain
            // 
            this.lcgMain.CustomizationFormText = "layoutControlGroupMain";
            this.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgMain.GroupBordersVisible = false;
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciDefaultDays,
            this.lciDefaultPrice,
            this.lciItemsInfo,
            this.lciItemsCount});
            this.lcgMain.Location = new System.Drawing.Point(0, 0);
            this.lcgMain.Name = "lcgMain";
            this.lcgMain.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgMain.Size = new System.Drawing.Size(510, 160);
            this.lcgMain.Text = "lcgMain";
            this.lcgMain.TextVisible = false;
            // 
            // lciDefaultDays
            // 
            this.lciDefaultDays.Control = this.teDefaultDays;
            this.lciDefaultDays.CustomizationFormText = "Default Rental Days";
            this.lciDefaultDays.Location = new System.Drawing.Point(0, 34);
            this.lciDefaultDays.Name = "lciDefaultDays";
            this.lciDefaultDays.Padding = new DevExpress.XtraLayout.Utils.Padding(12, 12, 2, 2);
            this.lciDefaultDays.Size = new System.Drawing.Size(510, 24);
            this.lciDefaultDays.Text = "Default Rental Days:";
            this.lciDefaultDays.TextSize = new System.Drawing.Size(100, 13);
            // 
            // lciDefaultPrice
            // 
            this.lciDefaultPrice.Control = this.teDefaultPrice;
            this.lciDefaultPrice.CustomizationFormText = "Default Late Fee";
            this.lciDefaultPrice.Location = new System.Drawing.Point(0, 58);
            this.lciDefaultPrice.Name = "lciDefaultPrice";
            this.lciDefaultPrice.Padding = new DevExpress.XtraLayout.Utils.Padding(12, 12, 2, 2);
            this.lciDefaultPrice.Size = new System.Drawing.Size(510, 102);
            this.lciDefaultPrice.Text = "Default Late Fee:";
            this.lciDefaultPrice.TextSize = new System.Drawing.Size(100, 13);
            // 
            // lciItemsInfo
            // 
            this.lciItemsInfo.Control = this.lbItemsInfo;
            this.lciItemsInfo.CustomizationFormText = "lciItemsInfo";
            this.lciItemsInfo.Location = new System.Drawing.Point(0, 17);
            this.lciItemsInfo.Name = "lciItemsInfo";
            this.lciItemsInfo.Padding = new DevExpress.XtraLayout.Utils.Padding(12, 12, 2, 2);
            this.lciItemsInfo.Size = new System.Drawing.Size(510, 17);
            this.lciItemsInfo.Text = "lciItemsInfo";
            this.lciItemsInfo.TextSize = new System.Drawing.Size(0, 0);
            this.lciItemsInfo.TextToControlDistance = 0;
            this.lciItemsInfo.TextVisible = false;
            // 
            // lciItemsCount
            // 
            this.lciItemsCount.Control = this.lbItemsCount;
            this.lciItemsCount.CustomizationFormText = "lciItemsCount";
            this.lciItemsCount.Location = new System.Drawing.Point(0, 0);
            this.lciItemsCount.Name = "lciItemsCount";
            this.lciItemsCount.Padding = new DevExpress.XtraLayout.Utils.Padding(12, 12, 2, 2);
            this.lciItemsCount.Size = new System.Drawing.Size(510, 17);
            this.lciItemsCount.Text = "lciItemsCount";
            this.lciItemsCount.TextSize = new System.Drawing.Size(0, 0);
            this.lciItemsCount.TextToControlDistance = 0;
            this.lciItemsCount.TextVisible = false;
            // 
            // ucRentalSalesInfo
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lcMain);
            this.Name = "ucRentalSalesInfo";
            this.Size = new System.Drawing.Size(510, 160);
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teDefaultDays.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDefaultPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDefaultDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDefaultPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciItemsInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciItemsCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup lcgMain;
        private DevExpress.XtraEditors.TextEdit teDefaultDays;
        private DevExpress.XtraEditors.TextEdit teDefaultPrice;
        private DevExpress.XtraLayout.LayoutControlItem lciDefaultPrice;
        private DevExpress.XtraLayout.LayoutControlItem lciDefaultDays;
        private DevExpress.XtraEditors.LabelControl lbItemsInfo;
        private DevExpress.XtraLayout.LayoutControlItem lciItemsInfo;
        private DevExpress.XtraEditors.LabelControl lbItemsCount;
        private DevExpress.XtraLayout.LayoutControlItem lciItemsCount;
    }
}
