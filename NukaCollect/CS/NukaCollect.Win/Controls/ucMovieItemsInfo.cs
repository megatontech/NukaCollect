using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.Xpo.DB;
using DevExpress.XtraLayout;
using DevExpress.Utils.Menu;
using DevExpress.XtraCharts;
using DevExpress.Data.Helpers;
using NukaCollect.Resources;

namespace NukaCollect.Win.Controls {
    public partial class ucMovieItemsInfo : XtraUserControl {
        MovieItem.CountInfo countInfo;
        MovieItemFormat?[] formatsAndAll;
        bool lockInit = false;

        public ucMovieItemsInfo() {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForUCMovieItemsInfo(this);
            DoughnutSeriesView view = FormatSeries.View as DoughnutSeriesView;
            if(view != null)
                view.Titles[0].Text = ConstStrings.Get("MediaFormats");
        }

        Series FormatSeries { get { return ccFormatsInfo.Series[0]; } }
        Series RentalSalesInfoSeries { get { return ccFormatsInfo.Series[1]; } }

        public void Init(MovieCategory category, XPCollection<MovieItem> items, IDXMenuManager manager) {
            lockInit = true;
            try {
                lcMain.MenuManager = manager;
                countInfo = new MovieItem.CountInfo(items);
                teLastRentedOn.Text = countInfo.LastRentedOn == null ? string.Empty : countInfo.LastRentedOn.Value.ToString();
                MovieItemFormat[] formats = (MovieItemFormat[])Enum.GetValues(typeof(MovieItemFormat));
                formatsAndAll = new MovieItemFormat?[formats.Length + 1];
                for(int i = 0; i < formats.Length; ++i) formatsAndAll[i] = formats[i];
                formatsAndAll[formatsAndAll.Length - 1] = null;
                InitFormatSeries(formats);
                int index = tcMain.SelectedTabPageIndex;
                foreach(MovieItemFormat? format in formatsAndAll) {
                    string pageCaption = EnumTitlesKeeper<MovieItemFormat>.GetTitle(format);
                    MovieCategoryPrice categoryPrice = format == null ? null : category.GetPrice(format.Value);
                    ucRentalSalesInfo info = GetCurrentRentalSalesInfo(pageCaption);
                    if(info != null) {
                        info.Init(categoryPrice, countInfo, format, lcMain.MenuManager);
                    } else {
                        LayoutControlGroup page = tcMain.AddTabPage(pageCaption);
                        page.CaptionImage = format == null ? null : ImagesHelper.Current.DiskIcons.Images[(int)format - 1];
                        ucRentalSalesInfo ucInfo = new ucRentalSalesInfo(categoryPrice, countInfo, format, lcMain.MenuManager);
                        LayoutControlItem item = page.AddItem() as LayoutControlItem;
                        item.Control = ucInfo;
                        item.TextVisible = false;
                        item.MaxSize = new System.Drawing.Size(0, 120);
                        item.MinSize = new System.Drawing.Size(10, 120);
                        item.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
                        item.Padding = new DevExpress.XtraLayout.Utils.Padding(6);
                    }
                }
                tcMain.SelectedTabPageIndex = index >= 0 ? index : 0;
                foreach(Control item in lcMain.Controls)
                    AddControl(item);
            } finally {
                lockInit = false;
                UpdateFormatSeries();
            }
        }
        ucRentalSalesInfo GetCurrentRentalSalesInfo(string caption) {
            foreach(LayoutControlGroup page in tcMain.TabPages)
                if(page.Text == caption)
                    return ((LayoutControlItem)page.Items[0]).Control as ucRentalSalesInfo;
            return null;
        }
        void AddControl(Control item) {
            BaseEdit edit = item as BaseEdit;
            if(edit != null)
                edit.MenuManager = lcMain.MenuManager;
        }
        void InitFormatSeries(MovieItemFormat[] formats) {
            if(FormatSeries == null)
                return;
            FormatSeries.Points.Clear();
            for(int i = 0; i < formats.Length; i++)
                FormatSeries.Points.Add(new SeriesPoint(EnumTitlesKeeper<MovieItemFormat>.GetTitle(formats[i]), countInfo.WithFormat[i]));
        }
        void InitRentalSalesInfoSeries(MovieItemFormat? format) {
            if(RentalSalesInfoSeries == null)
                return;
            RentalSalesInfoSeries.Points.Clear();
            MovieItemStatus[] statuses = countInfo.Statuses;
            if(format == null) {
                for(int i = 0; i < statuses.Length; i++)
                    RentalSalesInfoSeries.Points.Add(new SeriesPoint(EnumTitlesKeeper<MovieItemStatus>.GetTitle(statuses[i]), countInfo.WithStatus[i]));
            } else {
                int formatIndex = countInfo.FormatIndex(format.Value);
                for(int i = 0; i < statuses.Length; i++)
                    RentalSalesInfoSeries.Points.Add(new SeriesPoint(EnumTitlesKeeper<MovieItemStatus>.GetTitle(statuses[i]), countInfo.WithFormatAndStatus[formatIndex, i]));
            }
            DoughnutSeriesView salesInfoSeriesView = ((DoughnutSeriesView)RentalSalesInfoSeries.View);
            if(salesInfoSeriesView != null)
                salesInfoSeriesView.Titles[0].Text = EnumTitlesKeeper<MovieItemFormat>.GetTitle(format); ;
        }
        void ExplodeFormatSeries(MovieItemFormat? format) {
            DoughnutSeriesView formatSeriesView = ((DoughnutSeriesView)FormatSeries.View);
            if(formatSeriesView != null) {
                formatSeriesView.ExplodedPoints.Clear();
                if(format == null)
                    formatSeriesView.ExplodeMode = PieExplodeMode.All;
                else {
                    int index = countInfo.FormatIndex(format.Value);
                    formatSeriesView.ExplodedPoints.Add(FormatSeries.Points[index]);
                }
            }
        }
        void ccFormatsInfo_PieSeriesPointExploded(object sender, PieSeriesPointExplodedEventArgs e) {
            if(e.Dragged && e.Exploded && e.Series == FormatSeries)
                tcMain.SelectedTabPageIndex = FormatSeries.Points.IndexOf(e.Point);
        }

        private void ccFormatsInfo_CustomDrawSeriesPoint(object sender, CustomDrawSeriesPointEventArgs e) {
            e.LabelText = string.Format("{1}: {0}", e.SeriesPoint.Values[0],
                e.SeriesPoint.Argument == MovieItemStatus.Active.ToString() ?
                /*ConstStrings.MovieItemStatusActive*/ e.SeriesPoint.Argument :
                MasterDetailHelper.SplitPascalCaseString(e.SeriesPoint.Argument));
        }

        private void tcMain_SelectedPageChanged(object sender, LayoutTabPageChangedEventArgs e) {
            UpdateFormatSeries();
        }
        void UpdateFormatSeries() {
            if(lockInit) return;
            if(tcMain.SelectedTabPageIndex >= 0) {
                MovieItemFormat? format = formatsAndAll[tcMain.SelectedTabPageIndex];
                InitRentalSalesInfoSeries(format);
                ExplodeFormatSeries(format);
            }
        }
    }
}
