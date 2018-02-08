using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using NukaCollect.Helpers;
using NukaCollect.Resources;

namespace NukaCollect.Win.Modules {
    public partial class Employee : TutorialControl {
        public Employee() {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForEmployee(this);
        }
        protected override void BeginRefreshData() {
            base.BeginRefreshData();
            xpCollection1.Reload(); //TODO
        }
        protected override void InitData() {
            base.InitData();
            gridControl1.DataSource = xpCollection1;

        }
        private void xpCollection1_ResolveSession(object sender, DevExpress.Xpo.ResolveSessionEventArgs e) {
            e.Session = Session;
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            SessionHelper.CommitSession(Session, new ExceptionsProcesser(this.FindForm()));
        }
    }
}
