namespace NukaCollect.Win.ModulesStatistics {
    partial class CustomerRevenueStatistics {
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel1 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.PointOptions pointOptions1 = new DevExpress.XtraCharts.PointOptions();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.pivotGrid = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldRevenue = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMonth = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCustomer = new DevExpress.XtraPivotGrid.PivotGridField();
            this.ucCustomerInfo1 = new NukaCollect.Win.Controls.ucCustomerInfo();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem2 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.chart);
            this.layoutControl1.Controls.Add(this.pivotGrid);
            this.layoutControl1.Controls.Add(this.ucCustomerInfo1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1016, 537);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // chart
            // 
            this.chart.DataSource = this.pivotGrid;
            xyDiagram1.AxisX.Label.Staggered = true;
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = true;
            xyDiagram1.AxisX.VisualRange.AutoSideMargins = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Label.NumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Currency;
            xyDiagram1.AxisY.Label.NumericOptions.Precision = 0;
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = false;
            xyDiagram1.AxisY.WholeRange.AutoSideMargins = true;
            xyDiagram1.AxisY.VisualRange.AutoSideMargins = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chart.Diagram = xyDiagram1;
            this.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            this.chart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside;
            this.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.chart.Legend.MaxVerticalPercentage = 30;
            this.chart.Location = new System.Drawing.Point(250, 8);
            this.chart.Name = "chart";
            this.chart.PaletteName = "Concourse";
            this.chart.SeriesDataMember = "Series";
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chart.SeriesTemplate.ArgumentDataMember = "Arguments";
            pointSeriesLabel1.LineVisible = true;
            pointOptions1.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Currency;
            pointSeriesLabel1.PointOptions = pointOptions1;
            pointSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default;
            this.chart.SeriesTemplate.Label = pointSeriesLabel1;
            this.chart.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            this.chart.SeriesTemplate.ValueDataMembersSerializable = "Values";
            this.chart.SeriesTemplate.View = lineSeriesView1;
            this.chart.Size = new System.Drawing.Size(758, 335);
            this.chart.TabIndex = 4;
            chartTitle1.Text = "Customer Revenue - Last 12 Months";
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            this.chart.BoundDataChanged += new DevExpress.XtraCharts.BoundDataChangedEventHandler(this.chart_BoundDataChanged);
            // 
            // pivotGrid
            // 
            this.pivotGrid.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldRevenue,
            this.fieldMonth,
            this.fieldCustomer});
            this.pivotGrid.Location = new System.Drawing.Point(250, 352);
            this.pivotGrid.Name = "pivotGrid";
            this.pivotGrid.OptionsChartDataSource.FieldValuesProvideMode = DevExpress.XtraPivotGrid.PivotChartFieldValuesProvideMode.DisplayText;
            this.pivotGrid.OptionsChartDataSource.ProvideColumnCustomTotals = false;
            this.pivotGrid.OptionsChartDataSource.ProvideColumnGrandTotals = false;
            this.pivotGrid.OptionsChartDataSource.ProvideColumnTotals = false;
            this.pivotGrid.OptionsChartDataSource.ProvideDataByColumns = false;
            this.pivotGrid.OptionsChartDataSource.ProvideRowCustomTotals = false;
            this.pivotGrid.OptionsChartDataSource.ProvideRowGrandTotals = false;
            this.pivotGrid.OptionsChartDataSource.ProvideRowTotals = false;
            this.pivotGrid.OptionsChartDataSource.SelectionOnly = false;
            this.pivotGrid.OptionsCustomization.AllowDrag = false;
            this.pivotGrid.OptionsView.ShowColumnGrandTotals = false;
            this.pivotGrid.OptionsView.ShowFilterHeaders = false;
            this.pivotGrid.Size = new System.Drawing.Size(758, 177);
            this.pivotGrid.TabIndex = 5;
            this.pivotGrid.CustomDrawCell += new DevExpress.XtraPivotGrid.PivotCustomDrawCellEventHandler(this.pivotGrid_CustomDrawCell);
            this.pivotGrid.CustomFieldSort += new DevExpress.XtraPivotGrid.PivotGridCustomFieldSortEventHandler(this.pivotGrid_CustomFieldSort);
            this.pivotGrid.FieldValueDisplayText += new DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventHandler(this.pivotGrid_FieldValueDisplayText);
            this.pivotGrid.CustomGroupInterval += new DevExpress.XtraPivotGrid.PivotCustomGroupIntervalEventHandler(this.pivotGrid_CustomGroupInterval);
            this.pivotGrid.CustomSummary += new DevExpress.XtraPivotGrid.PivotGridCustomSummaryEventHandler(this.pivotGrid_CustomSummary);
            // 
            // fieldRevenue
            // 
            this.fieldRevenue.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldRevenue.AreaIndex = 0;
            this.fieldRevenue.Caption = "Revenue";
            this.fieldRevenue.FieldName = "Payment";
            this.fieldRevenue.Name = "fieldRevenue";
            this.fieldRevenue.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom;
            // 
            // fieldMonth
            // 
            this.fieldMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldMonth.AreaIndex = 0;
            this.fieldMonth.Caption = "Month";
            this.fieldMonth.FieldName = "Date";
            this.fieldMonth.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.Custom;
            this.fieldMonth.Name = "fieldMonth";
            this.fieldMonth.UnboundFieldName = "fieldMonth";
            // 
            // fieldCustomer
            // 
            this.fieldCustomer.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCustomer.AreaIndex = 0;
            this.fieldCustomer.Caption = "Customer";
            this.fieldCustomer.FieldName = "Customer!";
            this.fieldCustomer.Name = "fieldCustomer";
            this.fieldCustomer.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.False;
            this.fieldCustomer.SortMode = DevExpress.XtraPivotGrid.PivotSortMode.Custom;
            // 
            // ucCustomerInfo1
            // 
            this.ucCustomerInfo1.Location = new System.Drawing.Point(8, 8);
            this.ucCustomerInfo1.Name = "ucCustomerInfo1";
            this.ucCustomerInfo1.Size = new System.Drawing.Size(233, 521);
            this.ucCustomerInfo1.TabIndex = 6;
            this.ucCustomerInfo1.DoEdit += new System.EventHandler(this.ucCustomerInfo1_DoEdit);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.splitterItem2,
            this.layoutControlItem2,
            this.splitterItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(6, 6, 6, 6);
            this.layoutControlGroup1.Size = new System.Drawing.Size(1016, 537);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.chart;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(242, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(762, 339);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.ucCustomerInfo1;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(237, 525);
            this.layoutControlItem3.Text = "Current Customer:";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // splitterItem2
            // 
            this.splitterItem2.AllowHotTrack = true;
            this.splitterItem2.CustomizationFormText = "splitterItem2";
            this.splitterItem2.Location = new System.Drawing.Point(237, 0);
            this.splitterItem2.Name = "splitterItem2";
            this.splitterItem2.Size = new System.Drawing.Size(5, 525);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.pivotGrid;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(242, 344);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(762, 181);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.CustomizationFormText = "splitterItem1";
            this.splitterItem1.Location = new System.Drawing.Point(242, 339);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(762, 5);
            // 
            // CustomerRevenueStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "CustomerRevenueStatistics";
            this.Size = new System.Drawing.Size(1016, 537);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGrid;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldRevenue;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMonth;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCustomer;
        private NukaCollect.Win.Controls.ucCustomerInfo ucCustomerInfo1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.SplitterItem splitterItem2;
        private DevExpress.XtraCharts.ChartControl chart;
    }
}
