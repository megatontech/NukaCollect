namespace NukaCollect.Win.ModulesKPI {
    partial class CustomersByDatesKPI {
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.StackedBarSeriesView stackedBarSeriesView1 = new DevExpress.XtraCharts.StackedBarSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.StackedBarSeriesView stackedBarSeriesView2 = new DevExpress.XtraCharts.StackedBarSeriesView();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.StackedBarSeriesView stackedBarSeriesView3 = new DevExpress.XtraCharts.StackedBarSeriesView();
            DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.StackedBarSeriesView stackedBarSeriesView4 = new DevExpress.XtraCharts.StackedBarSeriesView();
            DevExpress.XtraCharts.Series series5 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.StackedBarSeriesView stackedBarSeriesView5 = new DevExpress.XtraCharts.StackedBarSeriesView();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.PointOptions pointOptions1 = new DevExpress.XtraCharts.PointOptions();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup1 = new DevExpress.XtraPivotGrid.PivotGridGroup();
            this.Year = new DevExpress.XtraPivotGrid.PivotGridField();
            this.Quarter = new DevExpress.XtraPivotGrid.PivotGridField();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cbeSortMode = new DevExpress.XtraEditors.ComboBoxEdit();
            this.customersChart = new DevExpress.XtraCharts.ChartControl();
            this.customersGrid = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.receiptsCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.fieldPayment = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCustomer = new DevExpress.XtraPivotGrid.PivotGridField();
            this.lcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciChart = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciPivot = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbeSortMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptsCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPivot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // Year
            // 
            this.Year.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.Year.AreaIndex = 0;
            this.Year.Caption = "Year";
            this.Year.FieldName = "Date";
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
            this.Quarter.FieldName = "Date";
            this.Quarter.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter;
            this.Quarter.Name = "Quarter";
            this.Quarter.Options.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.Quarter.RunningTotal = true;
            this.Quarter.UnboundFieldName = "Quarter";
            this.Quarter.Width = 105;
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomizationMenu = false;
            this.layoutControl1.Controls.Add(this.cbeSortMode);
            this.layoutControl1.Controls.Add(this.customersChart);
            this.layoutControl1.Controls.Add(this.customersGrid);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.lcgMain;
            this.layoutControl1.Size = new System.Drawing.Size(887, 538);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cbeSortMode
            // 
            this.cbeSortMode.EditValue = "Payment";
            this.cbeSortMode.Location = new System.Drawing.Point(349, 8);
            this.cbeSortMode.Name = "cbeSortMode";
            this.cbeSortMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeSortMode.Properties.DropDownRows = 2;
            this.cbeSortMode.Properties.Items.AddRange(new object[] {
            "Payment",
            "Customer"});
            this.cbeSortMode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbeSortMode.Size = new System.Drawing.Size(530, 20);
            this.cbeSortMode.StyleController = this.layoutControl1;
            this.cbeSortMode.TabIndex = 6;
            this.cbeSortMode.SelectedIndexChanged += new System.EventHandler(this.cbeSortMode_SelectedIndexChanged);
            // 
            // customersChart
            // 
            this.customersChart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.AxisX.MinorCount = 1;
            xyDiagram1.AxisX.Tickmarks.MinorLength = 5;
            xyDiagram1.AxisX.Tickmarks.Visible = false;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = true;
            xyDiagram1.AxisY.Tickmarks.MinorVisible = false;
            xyDiagram1.AxisY.Title.Text = "Payment $";
            xyDiagram1.AxisY.Title.Visible = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.WholeRange.AutoSideMargins = true;
            this.customersChart.Diagram = xyDiagram1;
            this.customersChart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right;
            this.customersChart.Location = new System.Drawing.Point(311, 32);
            this.customersChart.Name = "customersChart";
            this.customersChart.RefreshDataOnRepaint = false;
            this.customersChart.RuntimeSeriesSelectionMode = DevExpress.XtraCharts.SeriesSelectionMode.Point;
            this.customersChart.SeriesDataMember = "Series";
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series1.Name = "Prodigious";
            series1.View = stackedBarSeriesView1;
            series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series2.Name = "Active";
            series2.View = stackedBarSeriesView2;
            series3.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series3.Name = "Occasional";
            series3.View = stackedBarSeriesView3;
            series4.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series4.Name = "Basic";
            series4.View = stackedBarSeriesView4;
            series5.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series5.Name = "FirstTime";
            series5.View = stackedBarSeriesView5;
            this.customersChart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2,
        series3,
        series4,
        series5};
            this.customersChart.SeriesTemplate.ArgumentDataMember = "Arguments";
            pointOptions1.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Currency;
            sideBySideBarSeriesLabel1.PointOptions = pointOptions1;
            sideBySideBarSeriesLabel1.Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Center;
            sideBySideBarSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default;
            this.customersChart.SeriesTemplate.Label = sideBySideBarSeriesLabel1;
            this.customersChart.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            this.customersChart.SeriesTemplate.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Descending;
            this.customersChart.SeriesTemplate.SeriesPointsSortingKey = DevExpress.XtraCharts.SeriesPointKey.Value_1;
            this.customersChart.SeriesTemplate.ShowInLegend = false;
            this.customersChart.SeriesTemplate.ValueDataMembersSerializable = "Values";
            this.customersChart.Size = new System.Drawing.Size(568, 498);
            this.customersChart.TabIndex = 4;
            chartTitle1.Text = "Customers by Dates";
            this.customersChart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            this.customersChart.CustomDrawSeries += new DevExpress.XtraCharts.CustomDrawSeriesEventHandler(this.customersChart_CustomDrawSeries);
            this.customersChart.CustomDrawSeriesPoint += new DevExpress.XtraCharts.CustomDrawSeriesPointEventHandler(this.customersChart_CustomDrawSeriesPoint);
            this.customersChart.BoundDataChanged += new DevExpress.XtraCharts.BoundDataChangedEventHandler(this.customersChart_BoundDataChanged);
            this.customersChart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.customersChart_MouseMove);
            // 
            // customersGrid
            // 
            this.customersGrid.DataSource = this.receiptsCollection;
            this.customersGrid.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldPayment,
            this.fieldCustomer,
            this.Year,
            this.Quarter});
            pivotGridGroup1.Fields.Add(this.Year);
            pivotGridGroup1.Fields.Add(this.Quarter);
            pivotGridGroup1.Hierarchy = null;
            pivotGridGroup1.ShowNewValues = true;
            this.customersGrid.Groups.AddRange(new DevExpress.XtraPivotGrid.PivotGridGroup[] {
            pivotGridGroup1});
            this.customersGrid.Location = new System.Drawing.Point(8, 8);
            this.customersGrid.Name = "customersGrid";
            this.customersGrid.OptionsChartDataSource.FieldValuesProvideMode = DevExpress.XtraPivotGrid.PivotChartFieldValuesProvideMode.DisplayText;
            this.customersGrid.OptionsCustomization.AllowDrag = false;
            this.customersGrid.OptionsCustomization.AllowEdit = false;
            this.customersGrid.OptionsSelection.MaxWidth = 1;
            this.customersGrid.OptionsView.ColumnTotalsLocation = DevExpress.XtraPivotGrid.PivotTotalsLocation.Near;
            this.customersGrid.OptionsView.ShowColumnTotals = false;
            this.customersGrid.OptionsView.ShowFilterHeaders = false;
            this.customersGrid.OptionsView.ShowRowGrandTotalHeader = false;
            this.customersGrid.OptionsView.ShowRowGrandTotals = false;
            this.customersGrid.OptionsView.ShowRowTotals = false;
            this.customersGrid.Size = new System.Drawing.Size(294, 522);
            this.customersGrid.TabIndex = 5;
            this.customersGrid.FieldTooltipShowing += new DevExpress.XtraPivotGrid.PivotFieldTooltipShowingEventHandler(this.customersGrid_FieldTooltipShowing);
            this.customersGrid.MouseMove += new System.Windows.Forms.MouseEventHandler(this.customersGrid_MouseMove);
            // 
            // receiptsCollection
            // 
            this.receiptsCollection.ObjectType = typeof(NukaCollect.Receipt);
            this.receiptsCollection.ResolveSession += new DevExpress.Xpo.ResolveSessionEventHandler(this.receiptsCollection_ResolveSession);
            // 
            // fieldPayment
            // 
            this.fieldPayment.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldPayment.AreaIndex = 0;
            this.fieldPayment.FieldName = "Payment";
            this.fieldPayment.Name = "fieldPayment";
            this.fieldPayment.Options.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            // 
            // fieldCustomer
            // 
            this.fieldCustomer.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCustomer.AreaIndex = 0;
            this.fieldCustomer.Caption = "Customer";
            this.fieldCustomer.FieldName = "Customer!";
            this.fieldCustomer.Name = "fieldCustomer";
            this.fieldCustomer.SortBySummaryInfo.FieldName = "Payment";
            this.fieldCustomer.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
            this.fieldCustomer.Width = 127;
            // 
            // lcgMain
            // 
            this.lcgMain.CustomizationFormText = "Root";
            this.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgMain.GroupBordersVisible = false;
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciChart,
            this.lciPivot,
            this.splitterItem1,
            this.layoutControlItem1});
            this.lcgMain.Location = new System.Drawing.Point(0, 0);
            this.lcgMain.Name = "lcgMain";
            this.lcgMain.Padding = new DevExpress.XtraLayout.Utils.Padding(6, 6, 6, 6);
            this.lcgMain.Size = new System.Drawing.Size(887, 538);
            this.lcgMain.Text = "lcgMain";
            this.lcgMain.TextVisible = false;
            // 
            // lciChart
            // 
            this.lciChart.Control = this.customersChart;
            this.lciChart.CustomizationFormText = "layoutControlItem1";
            this.lciChart.Location = new System.Drawing.Point(303, 24);
            this.lciChart.Name = "lciChart";
            this.lciChart.Size = new System.Drawing.Size(572, 502);
            this.lciChart.Text = "lciChart";
            this.lciChart.TextSize = new System.Drawing.Size(0, 0);
            this.lciChart.TextToControlDistance = 0;
            this.lciChart.TextVisible = false;
            // 
            // lciPivot
            // 
            this.lciPivot.Control = this.customersGrid;
            this.lciPivot.CustomizationFormText = "lciPivot";
            this.lciPivot.Location = new System.Drawing.Point(0, 0);
            this.lciPivot.MinSize = new System.Drawing.Size(104, 24);
            this.lciPivot.Name = "lciPivot";
            this.lciPivot.Size = new System.Drawing.Size(298, 526);
            this.lciPivot.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciPivot.Text = "lciPivot";
            this.lciPivot.TextSize = new System.Drawing.Size(0, 0);
            this.lciPivot.TextToControlDistance = 0;
            this.lciPivot.TextVisible = false;
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.CustomizationFormText = "splitterItem1";
            this.splitterItem1.Location = new System.Drawing.Point(298, 0);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(5, 526);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cbeSortMode;
            this.layoutControlItem1.CustomizationFormText = "comboSortMode";
            this.layoutControlItem1.Location = new System.Drawing.Point(303, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(572, 24);
            this.layoutControlItem1.Text = "Sort by";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(35, 13);
            // 
            // CustomersByDatesKPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "CustomersByDatesKPI";
            this.Size = new System.Drawing.Size(887, 538);
            this.Load += new System.EventHandler(this.CustomerKPI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbeSortMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptsCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPivot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup lcgMain;
        private DevExpress.XtraCharts.ChartControl customersChart;
        private DevExpress.XtraLayout.LayoutControlItem lciChart;
        private DevExpress.XtraPivotGrid.PivotGridControl customersGrid;
        private DevExpress.XtraLayout.LayoutControlItem lciPivot;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private DevExpress.Xpo.XPCollection receiptsCollection;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPayment;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCustomer;
        private DevExpress.XtraPivotGrid.PivotGridField Year;
        private DevExpress.XtraPivotGrid.PivotGridField Quarter;
        private DevExpress.XtraEditors.ComboBoxEdit cbeSortMode;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;

    }
}
