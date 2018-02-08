using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraCharts;
using DevExpress.XtraLayout;
using DevExpress.XtraPivotGrid;
using NukaCollect.Resources;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace NukaCollect.Win.ModulesKPI
{
    public partial class MoviesKPI : ChartExportTutorialControl
    {
        private const int selectedRowsCount = 5;

        private MovieToolTipController tooltip;
        private bool inSelectionUpdate;

        protected internal override ViewType ChartViewType { get { return ViewType.Spline; } }
        protected override ChartControl MainChart { get { return profitChart; } }
        protected override LayoutControl MainLayoutControl { get { return layoutControl1; } }
        protected override bool AllowRotateLayout { get { return true; } }
        protected override bool AllowFlipLayout { get { return true; } }

        public MoviesKPI()
        {
            InitializeComponent();
            profitGrid.BestFit();
            tooltip = new MovieToolTipController(profitGrid);
            profitChart.Titles[0].Text = ConstStrings.Get("RevenueMovies");
            ElementConstStringLoader.LoadConstStringsForMoviesKPI(this);
        }

        private void SetDateFilter()
        {
            rentsCollection.Criteria =
                        new GroupOperator(GroupOperatorType.And,
                            new BinaryOperator(
                                "RentedOn", PeriodManager.KPIPeriod.StartDate, BinaryOperatorType.GreaterOrEqual),
                            new BinaryOperator(
                                "RentedOn", PeriodManager.KPIPeriod.EndDate, BinaryOperatorType.LessOrEqual)
                        );
        }

        private void rentsCollection_ResolveSession(object sender, ResolveSessionEventArgs e)
        {
            SetDateFilter();
            e.Session = Session;
        }

        private void MovieKPI_Load(object sender, EventArgs e)
        {
            profitGrid.Cells.Selection = new Rectangle(0, 0, profitGrid.Cells.ColumnCount, selectedRowsCount);
            profitChart.DataSource = profitGrid;
        }

        private void UpdateSelection()
        {
            if (inSelectionUpdate)
                return;
            inSelectionUpdate = true;
            SetSelection(GetSelectedRows());
            inSelectionUpdate = false;
        }

        private List<int> GetSelectedRows()
        {
            List<int> selectedRows = new List<int>();
            for (int i = 0; i < profitGrid.Cells.MultiSelection.SelectedCells.Count; i++)
                if (!selectedRows.Contains(profitGrid.Cells.MultiSelection.SelectedCells[i].Y))
                    selectedRows.Add(profitGrid.Cells.MultiSelection.SelectedCells[i].Y);
            return selectedRows;
        }

        private void SetSelection(List<int> selectedRows)
        {
            List<Point> selectedCells = new List<Point>();
            for (int x = 0; x < profitGrid.Cells.ColumnCount; x++)
                for (int i = 0; i < selectedRows.Count; i++)
                    selectedCells.Add(new Point(x, selectedRows[i]));
            profitGrid.Cells.MultiSelection.SetSelection(selectedCells.ToArray());
        }

        private void profitGrid_FocusedCellChanged(object sender, EventArgs e)
        {
            if (inSelectionUpdate)
                return;
            inSelectionUpdate = true;
            if (profitGrid.Cells.MultiSelection.SelectedCells.Count == 0)
            {
                List<Point> selectedCells = new List<Point>();
                for (int x = 0; x < profitGrid.Cells.ColumnCount; x++)
                    selectedCells.Add(new Point(x, profitGrid.Cells.FocusedCell.Y));
                profitGrid.Cells.MultiSelection.SetSelection(selectedCells.ToArray());
            }
            inSelectionUpdate = false;
        }

        private void profitGrid_CellSelectionChanged(object sender, EventArgs e)
        {
            UpdateSelection();
        }

        private void profitGrid_FieldExpandedInFieldGroupChanged(object sender, PivotFieldEventArgs e)
        {
            UpdateSelection();
        }

        private void profitGrid_MouseMove(object sender, MouseEventArgs e)
        {
            PivotGridHitInfo hitInfo = profitGrid.CalcHitInfo(e.Location);
            if (MustShowMovieTooltip(hitInfo))
            {
                Movie movie = (Movie)hitInfo.ValueInfo.Value;
                Point location = e.Location;
                location.Offset(20, 20);
                tooltip.ShowHint(movie, location);
            }
            else
                tooltip.HideHint(true);
        }

        private void profitGrid_FieldTooltipShowing(object sender, PivotFieldTooltipShowingEventArgs e)
        {
            PivotGridHitInfo info = e.HitInfo;
            if (MustShowMovieTooltip(info))
            {
                e.ShowTooltip = false;
            }
        }

        private bool MustShowMovieTooltip(PivotGridHitInfo info)
        {
            return info.HitTest == PivotGridHitTest.Value && info.ValueInfo.Field == fieldMovie;
        }

        protected override void BeginRefreshData()
        {
            base.BeginRefreshData();
            profitChart.BeginInit();
            try
            {
                List<int> selectedRows = GetSelectedRows();
                profitGrid.BeginUpdate();
                try
                {
                    SetDateFilter();
                }
                finally
                {
                    profitGrid.EndUpdate();
                }
                SetSelection(selectedRows);
            }
            finally
            {
                profitChart.EndInit();
            }
            profitGrid.BestFit();
        }
    }
}