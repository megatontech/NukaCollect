namespace NukaCollect.Win.ModulesStatistics {
    partial class NetIncomeStatistics {
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
            DevExpress.XtraGauges.Core.Model.ScaleLabel scaleLabel1 = new DevExpress.XtraGauges.Core.Model.ScaleLabel();
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange1 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange2 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel1 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gaugeControl2 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.circularGauge1 = new DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge();
            this.arcScaleBackgroundLayerComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent();
            this.arcScaleComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.labelComponent1 = new DevExpress.XtraGauges.Win.Base.LabelComponent();
            this.arcScaleNeedleComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.pivotGrid = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldRevenue = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPeriod = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMonth = new DevExpress.XtraPivotGrid.PivotGridField();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gaugeControl2);
            this.layoutControl1.Controls.Add(this.radioGroup1);
            this.layoutControl1.Controls.Add(this.chart);
            this.layoutControl1.Controls.Add(this.pivotGrid);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1016, 537);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gaugeControl2
            // 
            this.gaugeControl2.BackColor = System.Drawing.Color.Transparent;
            this.gaugeControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gaugeControl2.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.circularGauge1});
            this.gaugeControl2.Location = new System.Drawing.Point(789, 310);
            this.gaugeControl2.Name = "gaugeControl2";
            this.gaugeControl2.Size = new System.Drawing.Size(219, 219);
            this.gaugeControl2.TabIndex = 8;
            // 
            // circularGauge1
            // 
            this.circularGauge1.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent[] {
            this.arcScaleBackgroundLayerComponent1});
            this.circularGauge1.Bounds = new System.Drawing.Rectangle(6, 6, 207, 207);
            this.circularGauge1.Labels.AddRange(new DevExpress.XtraGauges.Win.Base.LabelComponent[] {
            this.labelComponent1});
            this.circularGauge1.Name = "circularGauge1";
            this.circularGauge1.Needles.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent[] {
            this.arcScaleNeedleComponent1});
            this.circularGauge1.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent[] {
            this.arcScaleComponent1});
            // 
            // arcScaleBackgroundLayerComponent1
            // 
            this.arcScaleBackgroundLayerComponent1.ArcScale = this.arcScaleComponent1;
            this.arcScaleBackgroundLayerComponent1.Name = "bg";
            this.arcScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style1;
            this.arcScaleBackgroundLayerComponent1.ZOrder = 1000;
            // 
            // arcScaleComponent1
            // 
            this.arcScaleComponent1.AppearanceTickmarkText.Font = new System.Drawing.Font("Tahoma", 11F);
            this.arcScaleComponent1.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black");
            this.arcScaleComponent1.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F);
            this.arcScaleComponent1.EndAngle = 60F;
            scaleLabel1.AppearanceText.Font = new System.Drawing.Font("Tahoma", 11F);
            scaleLabel1.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Maroon");
            scaleLabel1.FormatString = "${1:F2}";
            scaleLabel1.Name = "Label0";
            scaleLabel1.Position = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 180F);
            scaleLabel1.Size = new System.Drawing.SizeF(150F, 30F);
            this.arcScaleComponent1.Labels.AddRange(new DevExpress.XtraGauges.Core.Model.ILabel[] {
            scaleLabel1});
            this.arcScaleComponent1.MajorTickmark.FormatString = "${0:F2}K";
            this.arcScaleComponent1.MajorTickmark.Multiplier = 0.001F;
            this.arcScaleComponent1.MajorTickmark.ShapeOffset = -3.5F;
            this.arcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_4;
            this.arcScaleComponent1.MajorTickmark.ShowText = false;
            this.arcScaleComponent1.MajorTickmark.TextOffset = -15F;
            this.arcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScaleComponent1.MaxValue = 4000F;
            this.arcScaleComponent1.MinorTickCount = 4;
            this.arcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_3;
            this.arcScaleComponent1.MinValue = 2500F;
            this.arcScaleComponent1.Name = "scale1";
            arcScaleRange1.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#90FF8080");
            arcScaleRange1.EndThickness = 20F;
            arcScaleRange1.EndValue = 3000F;
            arcScaleRange1.Name = "Range0";
            arcScaleRange1.ShapeOffset = -10F;
            arcScaleRange1.StartThickness = 25F;
            arcScaleRange2.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#9080FF80");
            arcScaleRange2.EndThickness = 25F;
            arcScaleRange2.EndValue = 3500F;
            arcScaleRange2.Name = "Range2";
            arcScaleRange2.ShapeOffset = -10F;
            arcScaleRange2.StartThickness = 20F;
            arcScaleRange2.StartValue = 3000F;
            this.arcScaleComponent1.Ranges.AddRange(new DevExpress.XtraGauges.Core.Model.IRange[] {
            arcScaleRange1,
            arcScaleRange2});
            this.arcScaleComponent1.StartAngle = -240F;
            this.arcScaleComponent1.Value = 3000F;
            // 
            // labelComponent1
            // 
            this.labelComponent1.AppearanceText.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelComponent1.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black");
            this.labelComponent1.Name = "circularGauge2_Label1";
            this.labelComponent1.Position = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 160F);
            this.labelComponent1.Text = "Month";
            this.labelComponent1.ZOrder = -1001;
            // 
            // arcScaleNeedleComponent1
            // 
            this.arcScaleNeedleComponent1.ArcScale = this.arcScaleComponent1;
            this.arcScaleNeedleComponent1.Name = "needle";
            this.arcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style6;
            this.arcScaleNeedleComponent1.StartOffset = -20F;
            this.arcScaleNeedleComponent1.ZOrder = -50;
            // 
            // radioGroup1
            // 
            this.radioGroup1.AutoSizeInLayoutControl = true;
            this.radioGroup1.EditValue = 1;
            this.radioGroup1.Location = new System.Drawing.Point(8, 8);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroup1.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroup1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Show Monthly Revenue"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Show Monthly Receipts")});
            this.radioGroup1.Size = new System.Drawing.Size(1000, 24);
            this.radioGroup1.StyleController = this.layoutControl1;
            this.radioGroup1.TabIndex = 6;
            this.radioGroup1.SelectedIndexChanged += new System.EventHandler(this.radioGroup1_SelectedIndexChanged);
            // 
            // chart
            // 
            this.chart.DataSource = this.pivotGrid;
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
            this.chart.Location = new System.Drawing.Point(8, 38);
            this.chart.Name = "chart";
            this.chart.PaletteName = "Concourse";
            this.chart.SeriesDataMember = "Series";
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chart.SeriesTemplate.ArgumentDataMember = "Arguments";
            this.chart.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
            pointSeriesLabel1.LineVisible = true;
            pointSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default;
            this.chart.SeriesTemplate.Label = pointSeriesLabel1;
            this.chart.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            this.chart.SeriesTemplate.ValueDataMembersSerializable = "Values";
            this.chart.SeriesTemplate.View = lineSeriesView1;
            this.chart.Size = new System.Drawing.Size(1000, 263);
            this.chart.TabIndex = 4;
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            this.chart.BoundDataChanged += new DevExpress.XtraCharts.BoundDataChangedEventHandler(this.chart_BoundDataChanged);
            this.chart.CustomizeAutoBindingSettings += new DevExpress.XtraCharts.CustomizeAutoBindingSettingsEventHandler(this.chart_CustomizeAutoBindingSettings);
            // 
            // pivotGrid
            // 
            this.pivotGrid.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldRevenue,
            this.fieldPeriod,
            this.fieldMonth});
            this.pivotGrid.Location = new System.Drawing.Point(8, 310);
            this.pivotGrid.Name = "pivotGrid";
            this.pivotGrid.OptionsChartDataSource.FieldValuesProvideMode = DevExpress.XtraPivotGrid.PivotChartFieldValuesProvideMode.Value;
            this.pivotGrid.OptionsChartDataSource.SelectionOnly = false;
            this.pivotGrid.OptionsChartDataSource.ProvideColumnCustomTotals = false;
            this.pivotGrid.OptionsChartDataSource.ProvideColumnGrandTotals = false;
            this.pivotGrid.OptionsChartDataSource.ProvideColumnTotals = false;
            this.pivotGrid.OptionsChartDataSource.ProvideRowCustomTotals = false;
            this.pivotGrid.OptionsChartDataSource.ProvideRowGrandTotals = false;
            this.pivotGrid.OptionsChartDataSource.ProvideRowTotals = false;
            this.pivotGrid.OptionsCustomization.AllowDrag = false;
            this.pivotGrid.OptionsView.ShowColumnGrandTotals = false;
            this.pivotGrid.OptionsView.ShowFilterHeaders = false;
            this.pivotGrid.Size = new System.Drawing.Size(777, 219);
            this.pivotGrid.TabIndex = 5;
            this.pivotGrid.CustomDrawCell += new DevExpress.XtraPivotGrid.PivotCustomDrawCellEventHandler(this.pivotGrid_CustomDrawCell);
            this.pivotGrid.CustomFieldSort += new DevExpress.XtraPivotGrid.PivotGridCustomFieldSortEventHandler(this.pivotGrid_CustomFieldSort);
            this.pivotGrid.FieldValueDisplayText += new DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventHandler(this.pivotGrid_FieldValueDisplayText);
            this.pivotGrid.CustomGroupInterval += new DevExpress.XtraPivotGrid.PivotCustomGroupIntervalEventHandler(this.pivotGrid_CustomGroupInterval);
            // 
            // fieldRevenue
            // 
            this.fieldRevenue.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldRevenue.AreaIndex = 0;
            this.fieldRevenue.Caption = "Revenue";
            this.fieldRevenue.FieldName = "Payment";
            this.fieldRevenue.Name = "fieldRevenue";
            // 
            // fieldPeriod
            // 
            this.fieldPeriod.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldPeriod.AreaIndex = 0;
            this.fieldPeriod.Caption = "Period";
            this.fieldPeriod.FieldName = "Date";
            this.fieldPeriod.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.Custom;
            this.fieldPeriod.Name = "fieldPeriod";
            this.fieldPeriod.UnboundFieldName = "fieldPeriod";
            this.fieldPeriod.Width = 200;
            // 
            // fieldMonth
            // 
            this.fieldMonth.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldMonth.AreaIndex = 0;
            this.fieldMonth.Caption = "Month";
            this.fieldMonth.FieldName = "Date";
            this.fieldMonth.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
            this.fieldMonth.Name = "fieldMonth";
            this.fieldMonth.SortMode = DevExpress.XtraPivotGrid.PivotSortMode.Custom;
            this.fieldMonth.UnboundFieldName = "fieldMonth";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.splitterItem1,
            this.layoutControlItem3,
            this.simpleSeparator1,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(6, 6, 6, 6);
            this.layoutControlGroup1.Size = new System.Drawing.Size(1016, 537);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.chart;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 30);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1004, 267);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.pivotGrid;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 302);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(781, 223);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.CustomizationFormText = "splitterItem1";
            this.splitterItem1.Location = new System.Drawing.Point(0, 297);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(1004, 5);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.radioGroup1;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1004, 28);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.CustomizationFormText = "simpleSeparator1";
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 28);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(1004, 2);
            this.simpleSeparator1.Text = "simpleSeparator1";
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.gaugeControl2;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(781, 302);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(223, 223);
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // NetIncomeStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "NetIncomeStatistics";
            this.Size = new System.Drawing.Size(1016, 537);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
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
        private DevExpress.XtraPivotGrid.PivotGridField fieldPeriod;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMonth;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraCharts.ChartControl chart;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl2;
        private DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge circularGauge1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent arcScaleBackgroundLayerComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent1;
        private DevExpress.XtraGauges.Win.Base.LabelComponent labelComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedleComponent1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}
