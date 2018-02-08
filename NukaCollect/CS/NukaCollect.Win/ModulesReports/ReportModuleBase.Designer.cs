namespace NukaCollect.Win.ModulesReports {
    partial class ReportModuleBase {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            this.printControl = new DevExpress.XtraPrinting.Control.PrintControl();
            this.SuspendLayout();
            // 
            // printControl
            // 
            this.printControl.BackColor = System.Drawing.Color.Empty;
            this.printControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printControl.ForeColor = System.Drawing.Color.Empty;
            this.printControl.IsMetric = true;
            this.printControl.Location = new System.Drawing.Point(6, 0);
            this.printControl.Name = "printControl";
            this.printControl.Size = new System.Drawing.Size(794, 500);
            this.printControl.TabIndex = 0;
            this.printControl.TooltipFont = new System.Drawing.Font("Tahoma", 8.25F);
            // 
            // ReportModuleBase
            // 
            this.Controls.Add(this.printControl);
            this.Name = "ReportModuleBase";
            this.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.Size = new System.Drawing.Size(800, 500);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPrinting.Control.PrintControl printControl;
    }
}
