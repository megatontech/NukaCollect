namespace NukaCollect.Win.Forms {
    partial class frmMovieAddItems {
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
            this.components = new System.ComponentModel.Container();
            this.lciFormat = new DevExpress.XtraLayout.LayoutControlItem();
            this.lueFormat = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.seCount = new DevExpress.XtraEditors.SpinEdit();
            this.lciCount = new DevExpress.XtraLayout.LayoutControlItem();
            this.seSellPrice = new DevExpress.XtraEditors.SpinEdit();
            this.lciSellPrice = new DevExpress.XtraLayout.LayoutControlItem();
            this.ceAvailableForSell = new DevExpress.XtraEditors.CheckEdit();
            this.lciAvailableForSell = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFormat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueFormat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seSellPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSellPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAvailableForSell.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAvailableForSell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.seSellPrice);
            this.lcMain.Controls.Add(this.seCount);
            this.lcMain.Controls.Add(this.lueFormat);
            this.lcMain.Controls.Add(this.ceAvailableForSell);
            this.lcMain.Size = new System.Drawing.Size(333, 152);
            // 
            // lcgMain
            // 
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciFormat,
            this.lciCount,
            this.lciSellPrice,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.lciAvailableForSell,
            this.simpleSeparator1});
            this.lcgMain.Name = "Root";
            this.lcgMain.Size = new System.Drawing.Size(333, 152);
            this.lcgMain.Text = "Root";
            // 
            // lciFormat
            // 
            this.lciFormat.Control = this.lueFormat;
            this.lciFormat.CustomizationFormText = "Format:";
            this.lciFormat.Location = new System.Drawing.Point(0, 0);
            this.lciFormat.Name = "lciFormat";
            this.lciFormat.Size = new System.Drawing.Size(333, 24);
            this.lciFormat.Text = "Format:";
            this.lciFormat.TextSize = new System.Drawing.Size(38, 13);
            // 
            // lueFormat
            // 
            this.lueFormat.Location = new System.Drawing.Point(44, 2);
            this.lueFormat.Name = "lueFormat";
            this.lueFormat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueFormat.Size = new System.Drawing.Size(287, 20);
            this.lueFormat.StyleController = this.lcMain;
            this.lueFormat.TabIndex = 4;
            // 
            // seCount
            // 
            this.seCount.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seCount.Location = new System.Drawing.Point(44, 26);
            this.seCount.Name = "seCount";
            this.seCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seCount.Properties.IsFloatValue = false;
            this.seCount.Properties.Mask.EditMask = "N00";
            this.seCount.Properties.MaxValue = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.seCount.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seCount.Size = new System.Drawing.Size(287, 20);
            this.seCount.StyleController = this.lcMain;
            this.seCount.TabIndex = 5;
            // 
            // lciCount
            // 
            this.lciCount.Control = this.seCount;
            this.lciCount.CustomizationFormText = "Count:";
            this.lciCount.Location = new System.Drawing.Point(0, 24);
            this.lciCount.Name = "lciCount";
            this.lciCount.Size = new System.Drawing.Size(333, 24);
            this.lciCount.Text = "Count:";
            this.lciCount.TextSize = new System.Drawing.Size(38, 13);
            // 
            // seSellPrice
            // 
            this.seSellPrice.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seSellPrice.Location = new System.Drawing.Point(44, 94);
            this.seSellPrice.Name = "seSellPrice";
            this.seSellPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seSellPrice.Properties.Mask.EditMask = "c";
            this.seSellPrice.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.seSellPrice.Properties.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.seSellPrice.Size = new System.Drawing.Size(287, 20);
            this.seSellPrice.StyleController = this.lcMain;
            this.seSellPrice.TabIndex = 6;
            // 
            // lciSellPrice
            // 
            this.lciSellPrice.Control = this.seSellPrice;
            this.lciSellPrice.CustomizationFormText = "Price";
            this.lciSellPrice.Location = new System.Drawing.Point(0, 92);
            this.lciSellPrice.Name = "lciSellPrice";
            this.lciSellPrice.Size = new System.Drawing.Size(333, 24);
            this.lciSellPrice.Text = "Price:";
            this.lciSellPrice.TextSize = new System.Drawing.Size(38, 13);
            // 
            // ceAvailableForSell
            // 
            this.ceAvailableForSell.Location = new System.Drawing.Point(2, 72);
            this.ceAvailableForSell.Name = "ceAvailableForSell";
            this.ceAvailableForSell.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.ceAvailableForSell.Properties.Caption = "Available for <b>Sale</b>";
            this.ceAvailableForSell.Size = new System.Drawing.Size(329, 18);
            this.ceAvailableForSell.StyleController = this.lcMain;
            this.ceAvailableForSell.TabIndex = 7;
            // 
            // lciAvailableForSell
            // 
            this.lciAvailableForSell.Control = this.ceAvailableForSell;
            this.lciAvailableForSell.CustomizationFormText = "lciAvailableForSell";
            this.lciAvailableForSell.Location = new System.Drawing.Point(0, 70);
            this.lciAvailableForSell.Name = "lciAvailableForSell";
            this.lciAvailableForSell.Size = new System.Drawing.Size(333, 22);
            this.lciAvailableForSell.Text = " ";
            this.lciAvailableForSell.TextSize = new System.Drawing.Size(0, 0);
            this.lciAvailableForSell.TextToControlDistance = 0;
            this.lciAvailableForSell.TextVisible = false;
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.CustomizationFormText = "simpleSeparator1";
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 142);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(333, 2);
            this.simpleSeparator1.Text = "simpleSeparator1";
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 48);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(333, 22);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3";
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 116);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(333, 26);
            this.emptySpaceItem3.Text = "emptySpaceItem3";
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // frmMovieAddItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 198);
            this.Name = "frmMovieAddItems";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add to Movie Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFormat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueFormat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seSellPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSellPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAvailableForSell.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAvailableForSell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControlItem lciFormat;
        private DevExpress.XtraEditors.SpinEdit seCount;
        private DevExpress.XtraLayout.LayoutControlItem lciCount;
        private DevExpress.XtraEditors.SpinEdit seSellPrice;
        private DevExpress.XtraLayout.LayoutControlItem lciSellPrice;
        private DevExpress.XtraEditors.CheckEdit ceAvailableForSell;
        private DevExpress.XtraLayout.LayoutControlItem lciAvailableForSell;
        private DevExpress.XtraEditors.ImageComboBoxEdit lueFormat;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
    }
}
