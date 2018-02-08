namespace NukaCollect.Win.Forms {
    partial class frmDetailBase {
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
            this.sbOK = new DevExpress.XtraEditors.SimpleButton();
            this.pcSeparator = new DevExpress.XtraEditors.PanelControl();
            this.sbCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pcFormButtons)).BeginInit();
            this.pcFormButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcSeparator)).BeginInit();
            this.SuspendLayout();
            // 
            // pcFormButtons
            // 
            this.pcFormButtons.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pcFormButtons.Controls.Add(this.sbOK);
            this.pcFormButtons.Controls.Add(this.pcSeparator);
            this.pcFormButtons.Controls.Add(this.sbCancel);
            this.pcFormButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pcFormButtons.Location = new System.Drawing.Point(8, 456);
            this.pcFormButtons.Name = "pcFormButtons";
            this.pcFormButtons.Size = new System.Drawing.Size(796, 22);
            this.pcFormButtons.TabIndex = 1;
            // 
            // sbOK
            // 
            this.sbOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.sbOK.Location = new System.Drawing.Point(622, 0);
            this.sbOK.Name = "sbOK";
            this.sbOK.Size = new System.Drawing.Size(83, 22);
            this.sbOK.TabIndex = 0;
            this.sbOK.Text = "&OK";
            this.sbOK.Click += new System.EventHandler(this.sbOK_Click);
            // 
            // pcSeparator
            // 
            this.pcSeparator.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pcSeparator.Dock = System.Windows.Forms.DockStyle.Right;
            this.pcSeparator.Location = new System.Drawing.Point(705, 0);
            this.pcSeparator.Name = "pcSeparator";
            this.pcSeparator.Size = new System.Drawing.Size(8, 22);
            this.pcSeparator.TabIndex = 2;
            // 
            // sbCancel
            // 
            this.sbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.sbCancel.Location = new System.Drawing.Point(713, 0);
            this.sbCancel.Name = "sbCancel";
            this.sbCancel.Size = new System.Drawing.Size(83, 22);
            this.sbCancel.TabIndex = 1;
            this.sbCancel.Text = "&Cancel";
            // 
            // frmDetailBase
            // 
            this.AcceptButton = this.sbOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.sbCancel;
            this.ClientSize = new System.Drawing.Size(812, 486);
            this.Controls.Add(this.pcFormButtons);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "frmDetailBase";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmDetailBase";
            ((System.ComponentModel.ISupportInitialize)(this.pcFormButtons)).EndInit();
            this.pcFormButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcSeparator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pcFormButtons;
        private DevExpress.XtraEditors.PanelControl pcSeparator;
        private DevExpress.XtraEditors.SimpleButton sbCancel;
        private DevExpress.XtraEditors.SimpleButton sbOK;
    }
}
