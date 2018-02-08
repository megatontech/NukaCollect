using DevExpress.Xpo;
using System.Windows.Forms;

namespace NukaCollect.Reports {
    public class ReportBase : DevExpress.XtraReports.UI.XtraReport {
        UnitOfWork session;

        public UnitOfWork Session {
            get { return session; }
            set { session = value; }
        }

        protected override void OnParametersRequestSubmit(DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e) {
            base.OnParametersRequestSubmit(e);
            Cursor.Current = Cursors.WaitCursor;
        }
    }
}
