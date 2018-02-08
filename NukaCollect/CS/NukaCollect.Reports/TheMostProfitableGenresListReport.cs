using DevExpress.Xpo;
using DevExpress.XtraReports.UI;
using System;
using System.Globalization;

namespace NukaCollect.Reports
{
    public partial class TheMostProfitableGenresListReport : TimePeriodReportBase
    {
        private decimal genreTotalRevenue;
        private decimal groupGenreTotalRevenue;

        public TheMostProfitableGenresListReport()
        {
            InitializeComponent();
            DisplayName = Properties.Resources.GenresReport;
        }

        private void xpCollectionTheMostProfitableGenres_ResolveSession(object sender, ResolveSessionEventArgs e)
        {
            e.Session = Session;
        }

        private void xrLabelTotalRevenue_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            e.Handled = true;
            e.Result = genreTotalRevenue;
        }

        private void xrLabelTotalRevenue_SummaryRowChanged(object sender, EventArgs e)
        {
            Movie movie = (Movie)GetCurrentRow();
            decimal movieTotalRevenue = decimal.Zero;
            foreach (Rent rent in movie.Rents)
            {
                if (rent.RentedOn >= (DateTime)Parameters[startDateParamName].Value && rent.RentedOn <= (DateTime)Parameters[endDateParamName].Value)
                {
                    movieTotalRevenue += rent.Payment;
                }
            }
            genreTotalRevenue += movieTotalRevenue;
            xrTableCellRevenue.Text = String.Format(Properties.Resources.Revenue, CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol, movieTotalRevenue);
        }

        private void xrLabelTotalRevenue_SummaryReset(object sender, EventArgs e)
        {
            genreTotalRevenue = decimal.Zero;
        }

        private void xrPictureBoxCover_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRPictureBox photo = sender as XRPictureBox;
            if (photo.Image == null)
            {
                photo.Image = ReferenceImages.UnknownMovie;
            }
        }

        private void GroupHeaderGenreGroup_SortingSummaryGetResult(object sender, GroupSortingSummaryGetResultEventArgs e)
        {
            e.Handled = true;
            e.Result = groupGenreTotalRevenue;
        }

        private void GroupHeaderGenreGroup_SortingSummaryReset(object sender, EventArgs e)
        {
            groupGenreTotalRevenue = decimal.Zero;
        }

        private void GroupHeaderGenreGroup_SortingSummaryRowChanged(object sender, GroupSortingSummaryRowChangedEventArgs e)
        {
            Movie movie = e.Row as Movie;
            if (movie == null)
                return;
            decimal groupMovieTotalRevenue = decimal.Zero;
            foreach (Rent rent in movie.Rents)
            {
                if (rent.RentedOn >= (DateTime)Parameters[startDateParamName].Value && rent.RentedOn <= (DateTime)Parameters[endDateParamName].Value)
                {
                    groupMovieTotalRevenue += rent.Payment;
                }
            }
            groupGenreTotalRevenue += groupMovieTotalRevenue;
        }
    }
}