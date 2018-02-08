namespace NukaCollect.Win.ModulesKPI {
    partial class MoviesKPI {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup1 = new DevExpress.XtraPivotGrid.PivotGridGroup();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel1 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.SplineSeriesView splineSeriesView1 = new DevExpress.XtraCharts.SplineSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.Year = new DevExpress.XtraPivotGrid.PivotGridField();
            this.Quarter = new DevExpress.XtraPivotGrid.PivotGridField();
            this.Month = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPayment = new DevExpress.XtraPivotGrid.PivotGridField();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.profitGrid = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.rentsCollection = new DevExpress.Xpo.XPCollection();
            this.fieldMovie = new DevExpress.XtraPivotGrid.PivotGridField();
            this.profitChart = new DevExpress.XtraCharts.ChartControl();
            this.lcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciChartProfit = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.colIcon = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTitle = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colReleaseDate = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCheck = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colInfo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profitGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentsCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profitChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciChartProfit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // Year
            // 
            this.Year.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.Year.AreaIndex = 0;
            this.Year.Caption = "Year";
            this.Year.FieldName = "RentedOn";
            this.Year.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.Year.Name = "Year";
            this.Year.Options.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.Year.RunningTotal = true;
            this.Year.UnboundFieldName = "Year";
            // 
            // Quarter
            // 
            this.Quarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.Quarter.AreaIndex = 1;
            this.Quarter.Caption = "Quarter";
            this.Quarter.ExpandedInFieldsGroup = false;
            this.Quarter.FieldName = "RentedOn";
            this.Quarter.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter;
            this.Quarter.Name = "Quarter";
            this.Quarter.Options.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.Quarter.RunningTotal = true;
            this.Quarter.UnboundFieldName = "Quarter";
            // 
            // Month
            // 
            this.Month.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.Month.AreaIndex = 2;
            this.Month.Caption = "Month";
            this.Month.FieldName = "RentedOn";
            this.Month.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
            this.Month.Name = "Month";
            this.Month.Options.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.Month.RunningTotal = true;
            this.Month.UnboundFieldName = "Month";
            this.Month.Visible = false;
            // 
            // fieldPayment
            // 
            this.fieldPayment.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldPayment.AreaIndex = 0;
            this.fieldPayment.FieldName = "Payment";
            this.fieldPayment.Name = "fieldPayment";
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomizationMenu = false;
            this.layoutControl1.Controls.Add(this.profitGrid);
            this.layoutControl1.Controls.Add(this.profitChart);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.lcgMain;
            this.layoutControl1.Size = new System.Drawing.Size(979, 604);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // profitGrid
            // 
            this.profitGrid.DataSource = this.rentsCollection;
            this.profitGrid.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldMovie,
            this.fieldPayment,
            this.Year,
            this.Quarter,
            this.Month});
            pivotGridGroup1.Caption = "Year";
            pivotGridGroup1.Fields.Add(this.Year);
            pivotGridGroup1.Fields.Add(this.Quarter);
            pivotGridGroup1.Fields.Add(this.Month);
            pivotGridGroup1.Hierarchy = null;
            this.profitGrid.Groups.AddRange(new DevExpress.XtraPivotGrid.PivotGridGroup[] {
            pivotGridGroup1});
            this.profitGrid.Location = new System.Drawing.Point(8, 8);
            this.profitGrid.Name = "profitGrid";
            this.profitGrid.OptionsChartDataSource.FieldValuesProvideMode = DevExpress.XtraPivotGrid.PivotChartFieldValuesProvideMode.Value;
            this.profitGrid.OptionsChartDataSource.ProvideColumnCustomTotals = false;
            this.profitGrid.OptionsChartDataSource.ProvideColumnGrandTotals = false;
            this.profitGrid.OptionsChartDataSource.ProvideColumnTotals = false;
            this.profitGrid.OptionsChartDataSource.ProvideDataByColumns = false;
            this.profitGrid.OptionsChartDataSource.ProvideRowCustomTotals = false;
            this.profitGrid.OptionsChartDataSource.ProvideRowGrandTotals = false;
            this.profitGrid.OptionsChartDataSource.ProvideRowTotals = false;
            this.profitGrid.OptionsCustomization.AllowDrag = false;
            this.profitGrid.OptionsCustomization.AllowDragInCustomizationForm = false;
            this.profitGrid.OptionsCustomization.AllowEdit = false;
            this.profitGrid.OptionsCustomization.AllowExpand = false;
            this.profitGrid.OptionsView.ColumnTotalsLocation = DevExpress.XtraPivotGrid.PivotTotalsLocation.Near;
            this.profitGrid.OptionsView.ShowColumnTotals = false;
            this.profitGrid.OptionsView.ShowFilterHeaders = false;
            this.profitGrid.OptionsView.ShowFilterSeparatorBar = false;
            this.profitGrid.OptionsView.ShowRowGrandTotalHeader = false;
            this.profitGrid.OptionsView.ShowRowGrandTotals = false;
            this.profitGrid.OptionsView.ShowRowTotals = false;
            this.profitGrid.Size = new System.Drawing.Size(336, 588);
            this.profitGrid.TabIndex = 9;
            this.profitGrid.MouseMove += new System.Windows.Forms.MouseEventHandler(this.profitGrid_MouseMove);
            this.profitGrid.FocusedCellChanged += new System.EventHandler(this.profitGrid_FocusedCellChanged);
            this.profitGrid.FieldExpandedInFieldGroupChanged += new DevExpress.XtraPivotGrid.PivotFieldEventHandler(this.profitGrid_FieldExpandedInFieldGroupChanged);
            this.profitGrid.CellSelectionChanged += new System.EventHandler(this.profitGrid_CellSelectionChanged);
            this.profitGrid.FieldTooltipShowing += new DevExpress.XtraPivotGrid.PivotFieldTooltipShowingEventHandler(this.profitGrid_FieldTooltipShowing);
            // 
            // rentsCollection
            // 
            this.rentsCollection.ObjectType = typeof(NukaCollect.Rent);
            this.rentsCollection.ResolveSession += new DevExpress.Xpo.ResolveSessionEventHandler(this.rentsCollection_ResolveSession);
            // 
            // fieldMovie
            // 
            this.fieldMovie.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldMovie.AreaIndex = 0;
            this.fieldMovie.Caption = "Movie";
            this.fieldMovie.FieldName = "Movie!";
            this.fieldMovie.Name = "fieldMovie";
            this.fieldMovie.SortBySummaryInfo.Field = this.fieldPayment;
            this.fieldMovie.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
            this.fieldMovie.Width = 115;
            // 
            // profitChart
            // 
            xyDiagram1.AxisX.GridLines.MinorVisible = true;
            xyDiagram1.AxisX.GridLines.Visible = true;
            xyDiagram1.AxisX.Label.Staggered = true;
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = true;
            xyDiagram1.AxisX.VisualRange.AutoSideMargins = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.GridLines.MinorVisible = true;
            xyDiagram1.AxisY.WholeRange.AutoSideMargins = true;
            xyDiagram1.AxisY.VisualRange.AutoSideMargins = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.profitChart.Diagram = xyDiagram1;
            this.profitChart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left;
            this.profitChart.Location = new System.Drawing.Point(353, 8);
            this.profitChart.Name = "profitChart";
            this.profitChart.RefreshDataOnRepaint = false;
            this.profitChart.RuntimeHitTesting = false;
            this.profitChart.SeriesDataMember = "Series";
            this.profitChart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.profitChart.SeriesTemplate.ArgumentDataMember = "Arguments";
            this.profitChart.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            pointSeriesLabel1.LineVisible = true;
            this.profitChart.SeriesTemplate.Label = pointSeriesLabel1;
            this.profitChart.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            this.profitChart.SeriesTemplate.ValueDataMembersSerializable = "Values";
            this.profitChart.SeriesTemplate.View = splineSeriesView1;
            this.profitChart.Size = new System.Drawing.Size(618, 588);
            this.profitChart.TabIndex = 5;
            chartTitle1.Text = "Revenue from Movies";
            this.profitChart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // lcgMain
            // 
            this.lcgMain.CustomizationFormText = "Root";
            this.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgMain.GroupBordersVisible = false;
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.lciChartProfit,
            this.splitterItem1});
            this.lcgMain.Location = new System.Drawing.Point(0, 0);
            this.lcgMain.Name = "lcgMain";
            this.lcgMain.Padding = new DevExpress.XtraLayout.Utils.Padding(6, 6, 6, 6);
            this.lcgMain.Size = new System.Drawing.Size(979, 604);
            this.lcgMain.Text = "lcgMain";
            this.lcgMain.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.profitGrid;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(340, 592);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // lciChartProfit
            // 
            this.lciChartProfit.Control = this.profitChart;
            this.lciChartProfit.CustomizationFormText = "lciChartProfit";
            this.lciChartProfit.Location = new System.Drawing.Point(345, 0);
            this.lciChartProfit.Name = "lciChartProfit";
            this.lciChartProfit.Size = new System.Drawing.Size(622, 592);
            this.lciChartProfit.Text = "lciChartProfit";
            this.lciChartProfit.TextSize = new System.Drawing.Size(0, 0);
            this.lciChartProfit.TextToControlDistance = 0;
            this.lciChartProfit.TextVisible = false;
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.CustomizationFormText = "splitterItem1";
            this.splitterItem1.Location = new System.Drawing.Point(340, 0);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(5, 592);
            // 
            // colIcon
            // 
            this.colIcon.AutoFillDown = true;
            this.colIcon.Caption = "Icon";
            this.colIcon.FieldName = "PhotoExist";
            this.colIcon.Name = "colIcon";
            this.colIcon.OptionsColumn.AllowEdit = false;
            this.colIcon.OptionsColumn.AllowFocus = false;
            this.colIcon.OptionsColumn.AllowSize = false;
            this.colIcon.OptionsColumn.FixedWidth = true;
            this.colIcon.OptionsColumn.ReadOnly = true;
            this.colIcon.RowCount = 2;
            this.colIcon.Visible = true;
            this.colIcon.Width = 40;
            // 
            // colTitle
            // 
            this.colTitle.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTitle.AppearanceCell.Options.UseFont = true;
            this.colTitle.FieldName = "Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.OptionsColumn.AllowFocus = false;
            this.colTitle.OptionsColumn.ReadOnly = true;
            this.colTitle.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colTitle.Visible = true;
            this.colTitle.Width = 157;
            // 
            // colReleaseDate
            // 
            this.colReleaseDate.FieldName = "ReleaseDate";
            this.colReleaseDate.Name = "colReleaseDate";
            this.colReleaseDate.OptionsColumn.AllowFocus = false;
            this.colReleaseDate.OptionsColumn.ReadOnly = true;
            this.colReleaseDate.RowIndex = 1;
            this.colReleaseDate.Visible = true;
            this.colReleaseDate.Width = 157;
            // 
            // colCheck
            // 
            this.colCheck.Caption = "Check";
            this.colCheck.FieldName = "Check";
            this.colCheck.Name = "colCheck";
            this.colCheck.RowCount = 2;
            this.colCheck.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.colCheck.Visible = true;
            this.colCheck.Width = 32;
            // 
            // colInfo
            // 
            this.colInfo.FieldName = "Info";
            this.colInfo.Name = "colInfo";
            this.colInfo.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colInfo.Visible = true;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Data1";
            this.gridBand3.Columns.Add(this.colTitle);
            this.gridBand3.Columns.Add(this.colReleaseDate);
            this.gridBand3.MinWidth = 20;
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.Width = 157;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Image";
            this.gridBand2.Columns.Add(this.colIcon);
            this.gridBand2.MinWidth = 20;
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.OptionsBand.FixedWidth = true;
            this.gridBand2.Width = 40;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Check";
            this.gridBand1.Columns.Add(this.colCheck);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.OptionsBand.FixedWidth = true;
            this.gridBand1.Width = 32;
            // 
            // MoviesKPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "MoviesKPI";
            this.Size = new System.Drawing.Size(979, 604);
            this.Load += new System.EventHandler(this.MovieKPI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profitGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentsCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profitChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciChartProfit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup lcgMain;
        private DevExpress.XtraCharts.ChartControl profitChart;
        private DevExpress.XtraLayout.LayoutControlItem lciChartProfit;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private DevExpress.XtraPivotGrid.PivotGridControl profitGrid;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colIcon;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTitle;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colReleaseDate;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCheck;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colInfo;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.Xpo.XPCollection rentsCollection;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMovie;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPayment;
        private DevExpress.XtraPivotGrid.PivotGridField Year;
        private DevExpress.XtraPivotGrid.PivotGridField Quarter;
        private DevExpress.XtraPivotGrid.PivotGridField Month;
    }
}
