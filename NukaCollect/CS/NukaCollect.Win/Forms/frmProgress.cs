using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Alerter;
using NukaCollect.Resources;

namespace NukaCollect.Win.Forms {
    public partial class frmProgress : StickLookAndFeelForm {
        Form parent;
        const int requiredCount = 200;
        const int requiredDataCount = 20;
        int requiredUpdateCount = 0;
        public frmProgress() : this(null) { }
        public frmProgress(Form parent) {
            this.parent = parent;
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForFrmProgress(this);
        }
        void Locate() {
            if(parent != null) {
                this.Location = new Point(parent.Bounds.X + (parent.Width - this.Width) / 2,
                    parent.Bounds.Y + (parent.Height - this.Height) / 2);
            }
        }
        public void ShowProgress(int count) {
            Locate();
            progressBarControl1.Position = 0;
            progressBarControl1.Properties.Maximum = count;
            requiredUpdateCount = count / 55;
            if(requiredUpdateCount == 0) requiredUpdateCount = 1;
            if(count > requiredCount) this.Show();
            FormInvalidate();
        }
        public void ShowProgress(int recordCount, string caption) {
            Locate();
            progressBarControl1.Position = 0;
            progressBarControl1.Properties.Maximum = 100;
            requiredUpdateCount = 1;
            labelControl1.Text = caption;
            if(recordCount > requiredDataCount) this.Show();
            FormInvalidate();
        }
        void FormInvalidate() {
            this.UpdateRegion();
            labelControl1.Refresh();
            this.Refresh();
        }
        public void Progress(int index) {
            if(this.Visible && index % requiredUpdateCount == 0) {
                progressBarControl1.Position = index;
                progressBarControl1.Refresh();
            }
        }
        public void HideProgress() {
            progressBarControl1.Position = progressBarControl1.Properties.Maximum;
            progressBarControl1.Refresh();
            this.Hide();
        }
    }
}
