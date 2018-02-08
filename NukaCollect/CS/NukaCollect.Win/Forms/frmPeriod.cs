using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using System.ComponentModel;
using System.Windows.Forms;

namespace NukaCollect.Win.Forms
{
    public partial class frmPeriod : XtraForm
    {
        public frmPeriod() : this(PeriodType.All)
        {
        }

        public frmPeriod(PeriodType type)
        {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForFrmPeriod(this);
            InitData(type);
        }

        private Period CurrentReceiptPeriod
        { get { return PeriodManager.ReceiptPeriod; } }
        private Period CurrentKPIPeriod
        { get { return PeriodManager.KPIPeriod; } }

        private void InitData(PeriodType type)
        {
            ucPeriodKPI.InitData(CurrentKPIPeriod.StartDate, CurrentKPIPeriod.EndDate);
            ucPeriodReport.InitData(CurrentReceiptPeriod.StartDate, CurrentReceiptPeriod.EndDate);

            if (type != PeriodType.All)
                tgcMain.Ungroup();

            lcgReceipt.Visibility = type != PeriodType.KPI ? LayoutVisibility.Always : LayoutVisibility.Never;
            lcgKPI.Visibility = type != PeriodType.Receipt ? LayoutVisibility.Always : LayoutVisibility.Never;

            lcgReceipt.Height = lcgKPI.Height = lcMain.Height;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            if (this.DialogResult == DialogResult.OK)
                e.Cancel = !SaveData();
        }

        private bool SaveData()
        {
            bool ret = ucPeriodKPI.ValidateDates();
            if (ret)
            {
                CurrentKPIPeriod.StartDate = ucPeriodKPI.StartDate;
                CurrentKPIPeriod.EndDate = ucPeriodKPI.EndDate;
                ret = ucPeriodReport.ValidateDates();
            }
            else
            {
                lcMain.FocusHelper.PlaceItemIntoView(lcgKPI);
                return ret;
            }
            if (ret)
            {
                CurrentReceiptPeriod.StartDate = ucPeriodReport.StartDate;
                CurrentReceiptPeriod.EndDate = ucPeriodReport.EndDate;
            }
            else
                lcMain.FocusHelper.PlaceItemIntoView(lcgReceipt);
            return ret;
        }
    }
}