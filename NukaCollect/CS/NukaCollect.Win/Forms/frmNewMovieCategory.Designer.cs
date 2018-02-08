namespace NukaCollect.Win.Forms {
    partial class frmNewMovieCategory {
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
            this.pcFormButtons = new DevExpress.XtraEditors.PanelControl();
            this.sbOk = new DevExpress.XtraEditors.SimpleButton();
            this.pcSeparator = new DevExpress.XtraEditors.PanelControl();
            this.sbCancel = new DevExpress.XtraEditors.SimpleButton();
            this.ucMovieCategoryDetail = new NukaCollect.Win.Controls.ucMovieCategoryDetail();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pcFormButtons)).BeginInit();
            this.pcFormButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcSeparator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // pcFormButtons
            // 
            this.pcFormButtons.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pcFormButtons.Controls.Add(this.sbOk);
            this.pcFormButtons.Controls.Add(this.pcSeparator);
            this.pcFormButtons.Controls.Add(this.sbCancel);
            this.pcFormButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pcFormButtons.Location = new System.Drawing.Point(12, 317);
            this.pcFormButtons.Name = "pcFormButtons";
            this.pcFormButtons.Size = new System.Drawing.Size(584, 22);
            this.pcFormButtons.TabIndex = 1;
            // 
            // sbOk
            // 
            this.sbOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.sbOk.Dock = System.Windows.Forms.DockStyle.Right;
            this.sbOk.Location = new System.Drawing.Point(369, 0);
            this.sbOk.Name = "sbOk";
            this.sbOk.Size = new System.Drawing.Size(124, 22);
            this.sbOk.TabIndex = 3;
            this.sbOk.Text = "S&ave and Close";
            // 
            // pcSeparator
            // 
            this.pcSeparator.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pcSeparator.Dock = System.Windows.Forms.DockStyle.Right;
            this.pcSeparator.Location = new System.Drawing.Point(493, 0);
            this.pcSeparator.Name = "pcSeparator";
            this.pcSeparator.Size = new System.Drawing.Size(8, 22);
            this.pcSeparator.TabIndex = 2;
            // 
            // sbCancel
            // 
            this.sbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.sbCancel.Location = new System.Drawing.Point(501, 0);
            this.sbCancel.Name = "sbCancel";
            this.sbCancel.Size = new System.Drawing.Size(83, 22);
            this.sbCancel.TabIndex = 1;
            this.sbCancel.Text = "&Close";
            // 
            // ucMovieCategoryDetail
            // 
            this.ucMovieCategoryDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMovieCategoryDetail.Location = new System.Drawing.Point(12, 12);
            this.ucMovieCategoryDetail.Name = "ucMovieCategoryDetail";
            this.ucMovieCategoryDetail.Size = new System.Drawing.Size(584, 297);
            this.ucMovieCategoryDetail.TabIndex = 2;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(12, 309);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(584, 8);
            this.panelControl1.TabIndex = 3;
            // 
            // frmNewMovieCategory
            // 
            this.AcceptButton = this.sbOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.sbCancel;
            this.ClientSize = new System.Drawing.Size(608, 351);
            this.Controls.Add(this.ucMovieCategoryDetail);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.pcFormButtons);
            this.Name = "frmNewMovieCategory";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "New Category";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNewCategory_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pcFormButtons)).EndInit();
            this.pcFormButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcSeparator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pcFormButtons;
        private DevExpress.XtraEditors.SimpleButton sbOk;
        private DevExpress.XtraEditors.PanelControl pcSeparator;
        private DevExpress.XtraEditors.SimpleButton sbCancel;
        private NukaCollect.Win.Controls.ucMovieCategoryDetail ucMovieCategoryDetail;
        private DevExpress.XtraEditors.PanelControl panelControl1;

    }
}
