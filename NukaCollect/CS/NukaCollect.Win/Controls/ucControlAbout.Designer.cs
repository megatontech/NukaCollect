namespace NukaCollect.Win.Controls {
    partial class ucControlAbout {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.pnlLinks = new DevExpress.XtraEditors.PanelControl();
            this.peAbout = new DevExpress.XtraEditors.PictureEdit();
            this.lcName = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLinks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peAbout.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLinks
            // 
            this.pnlLinks.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlLinks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLinks.Location = new System.Drawing.Point(0, 193);
            this.pnlLinks.Name = "pnlLinks";
            this.pnlLinks.Size = new System.Drawing.Size(309, 65);
            this.pnlLinks.TabIndex = 5;
            // 
            // peAbout
            // 
            this.peAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.peAbout.Location = new System.Drawing.Point(0, 18);
            this.peAbout.Name = "peAbout";
            this.peAbout.Properties.AllowFocused = false;
            this.peAbout.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.peAbout.Properties.Appearance.Options.UseBackColor = true;
            this.peAbout.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peAbout.Properties.ShowMenu = false;
            this.peAbout.Size = new System.Drawing.Size(309, 175);
            this.peAbout.TabIndex = 4;
            // 
            // lcName
            // 
            this.lcName.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lcName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lcName.Location = new System.Drawing.Point(0, 0);
            this.lcName.Name = "lcName";
            this.lcName.Size = new System.Drawing.Size(309, 18);
            this.lcName.TabIndex = 3;
            this.lcName.Text = "Control Name";
            // 
            // ucControlAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlLinks);
            this.Controls.Add(this.peAbout);
            this.Controls.Add(this.lcName);
            this.Name = "ucControlAbout";
            this.Size = new System.Drawing.Size(309, 258);
            ((System.ComponentModel.ISupportInitialize)(this.pnlLinks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peAbout.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlLinks;
        private DevExpress.XtraEditors.PictureEdit peAbout;
        private DevExpress.XtraEditors.LabelControl lcName;
    }
}
