using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraReports.UI;
using System;

namespace NukaCollect.Reports
{
    public partial class TopNFilmsReport : TimePeriodReportBase
    {
        public TopNFilmsReport()
        {
            InitializeComponent();
            DisplayName = Properties.Resources.TopFilmsReport;
        }

        private void xpCollectionMovies_ResolveSession(object sender, ResolveSessionEventArgs e)
        {
            e.Session = Session;
        }

        private void calculatedFieldRentsCount_GetValue(object sender, GetValueEventArgs e)
        {
            Movie movie = e.Row as Movie;
            CriteriaOperator filter = new GroupOperator(GroupOperatorType.And,
                new BinaryOperator("RentedOn", (DateTime)Parameters[startDateParamName].Value, BinaryOperatorType.GreaterOrEqual),
                new BinaryOperator("RentedOn", (DateTime)Parameters[endDateParamName].Value, BinaryOperatorType.LessOrEqual));
            e.Value = (int)Session.Evaluate(Session.GetClassInfo<Rent>(), CriteriaOperator.Parse("count()"), CriteriaOperator.Parse("Item.Movie.Oid = ?", movie.Oid) & filter);
        }

        protected override XtraReport CreateClone()
        {
            TopNFilmsReport clone = (TopNFilmsReport)base.CreateClone();
            clone.Session = this.Session;
            return clone;
        }

        private void xrPictureBoxCover_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRPictureBox photo = sender as XRPictureBox;
            if (photo.Image == null)
            {
                photo.Image = ReferenceImages.UnknownMovie;
            }
        }

        private void TopNFilmsReport_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            FilterString = "[calculatedFieldRentsCount] <> '0'";
            this.BeforePrint -= TopNFilmsReport_BeforePrint;
        }
    }
}