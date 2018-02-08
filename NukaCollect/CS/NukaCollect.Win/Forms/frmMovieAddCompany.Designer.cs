namespace NukaCollect.Win.Forms {
    partial class frmMovieAddCompany {
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
            this.lueCompany = new DevExpress.XtraEditors.LookUpEdit();
            this.lciCompany = new DevExpress.XtraLayout.LayoutControlItem();
            this.meDescription = new DevExpress.XtraEditors.MemoEdit();
            this.lciDescription = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDescription)).BeginInit();
            this.SuspendLayout();
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.meDescription);
            this.lcMain.Controls.Add(this.lueCompany);
            this.lcMain.Size = new System.Drawing.Size(375, 226);
            // 
            // lcgMain
            // 
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciCompany,
            this.lciDescription});
            this.lcgMain.Size = new System.Drawing.Size(375, 226);
            // 
            // lueCompany
            // 
            this.lueCompany.Location = new System.Drawing.Point(63, 2);
            this.lueCompany.Name = "lueCompany";
            this.lueCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueCompany.Properties.NullText = " ";
            this.lueCompany.Size = new System.Drawing.Size(310, 20);
            this.lueCompany.StyleController = this.lcMain;
            this.lueCompany.TabIndex = 4;
            // 
            // lciCompany
            // 
            this.lciCompany.Control = this.lueCompany;
            this.lciCompany.CustomizationFormText = "Company";
            this.lciCompany.Location = new System.Drawing.Point(0, 0);
            this.lciCompany.Name = "lciCompany";
            this.lciCompany.Size = new System.Drawing.Size(375, 24);
            this.lciCompany.Text = "Company:";
            this.lciCompany.TextSize = new System.Drawing.Size(57, 13);
            // 
            // meDescription
            // 
            this.meDescription.Location = new System.Drawing.Point(63, 26);
            this.meDescription.Name = "meDescription";
            this.meDescription.Size = new System.Drawing.Size(310, 190);
            this.meDescription.StyleController = this.lcMain;
            this.meDescription.TabIndex = 6;
            // 
            // lciDescription
            // 
            this.lciDescription.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lciDescription.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.lciDescription.Control = this.meDescription;
            this.lciDescription.CustomizationFormText = "Description";
            this.lciDescription.Location = new System.Drawing.Point(0, 24);
            this.lciDescription.Name = "lciDescription";
            this.lciDescription.Size = new System.Drawing.Size(375, 194);
            this.lciDescription.Text = "Description:";
            this.lciDescription.TextSize = new System.Drawing.Size(57, 13);
            // 
            // frmMovieAddCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 272);
            this.Name = "frmMovieAddCompany";
            this.ShowIcon = false;
            this.Text = "MovieAddCompany";
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDescription)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lueCompany;
        private DevExpress.XtraLayout.LayoutControlItem lciCompany;
        private DevExpress.XtraEditors.MemoEdit meDescription;
        private DevExpress.XtraLayout.LayoutControlItem lciDescription;
    }
}
