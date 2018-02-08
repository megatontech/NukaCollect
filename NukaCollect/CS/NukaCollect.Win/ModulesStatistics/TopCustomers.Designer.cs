namespace NukaCollect.Win.ModulesStatistics {
    partial class TopCustomersStatistics {
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
            DevExpress.XtraCharts.SimpleDiagram3D simpleDiagram3D1 = new DevExpress.XtraCharts.SimpleDiagram3D();
            DevExpress.XtraCharts.Pie3DSeriesLabel pie3DSeriesLabel1 = new DevExpress.XtraCharts.Pie3DSeriesLabel();
            DevExpress.XtraCharts.PiePointOptions piePointOptions1 = new DevExpress.XtraCharts.PiePointOptions();
            DevExpress.XtraCharts.PiePointOptions piePointOptions2 = new DevExpress.XtraCharts.PiePointOptions();
            DevExpress.XtraCharts.Pie3DSeriesView pie3DSeriesView1 = new DevExpress.XtraCharts.Pie3DSeriesView();
            DevExpress.XtraCharts.SeriesTitle seriesTitle1 = new DevExpress.XtraCharts.SeriesTitle();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.spinCustomerCount = new DevExpress.XtraEditors.SpinEdit();
            this.comboPeriod = new DevExpress.XtraEditors.ComboBoxEdit();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.pivotGrid = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldRevenue = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCustomer = new DevExpress.XtraPivotGrid.PivotGridField();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinCustomerCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboPeriod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.spinCustomerCount);
            this.layoutControl1.Controls.Add(this.comboPeriod);
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
            // spinCustomerCount
            // 
            this.spinCustomerCount.EditValue = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.spinCustomerCount.Location = new System.Drawing.Point(94, 32);
            this.spinCustomerCount.Name = "spinCustomerCount";
            this.spinCustomerCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinCustomerCount.Properties.IsFloatValue = false;
            this.spinCustomerCount.Properties.Mask.EditMask = "N00";
            this.spinCustomerCount.Properties.MaxValue = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.spinCustomerCount.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinCustomerCount.Size = new System.Drawing.Size(173, 20);
            this.spinCustomerCount.StyleController = this.layoutControl1;
            this.spinCustomerCount.TabIndex = 7;
            this.spinCustomerCount.EditValueChanged += new System.EventHandler(this.spinEdit1_EditValueChanged);
            // 
            // comboPeriod
            // 
            this.comboPeriod.EditValue = "Last Month";
            this.comboPeriod.Location = new System.Drawing.Point(94, 8);
            this.comboPeriod.Name = "comboPeriod";
            this.comboPeriod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboPeriod.Properties.Items.AddRange(new object[] {
            "This Month",
            "Last Month",
            "Last 12 Months"});
            this.comboPeriod.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboPeriod.Size = new System.Drawing.Size(173, 20);
            this.comboPeriod.StyleController = this.layoutControl1;
            this.comboPeriod.TabIndex = 6;
            this.comboPeriod.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit1_SelectedIndexChanged);
            // 
            // chart
            // 
            this.chart.DataSource = this.pivotGrid;
            simpleDiagram3D1.Dimension = 2;
            simpleDiagram3D1.LabelsResolveOverlappingMinIndent = 6;
            simpleDiagram3D1.RotationMatrixSerializable = "1;0;0;0;0;0.80449948567803;-0.5939533462687;0;0;0.5939533462687;0.80449948567803;" +
                "0;0;0;0;1";
            simpleDiagram3D1.RuntimeRotation = true;
            simpleDiagram3D1.RuntimeScrolling = true;
            simpleDiagram3D1.RuntimeZooming = true;
            this.chart.Diagram = simpleDiagram3D1;
            this.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            this.chart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside;
            this.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.chart.Legend.MaxVerticalPercentage = 30;
            this.chart.Location = new System.Drawing.Point(276, 8);
            this.chart.Name = "chart";
            this.chart.PaletteName = "Concourse";
            this.chart.SeriesDataMember = "Series";
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chart.SeriesTemplate.ArgumentDataMember = "Arguments";
            pie3DSeriesLabel1.LineVisible = true;
            piePointOptions1.PercentOptions.ValueAsPercent = false;
            piePointOptions1.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Currency;
            pie3DSeriesLabel1.PointOptions = piePointOptions1;
            pie3DSeriesLabel1.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.TwoColumns;
            pie3DSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default;
            this.chart.SeriesTemplate.Label = pie3DSeriesLabel1;
            piePointOptions2.PointView = DevExpress.XtraCharts.PointView.Argument;
            this.chart.SeriesTemplate.LegendPointOptions = piePointOptions2;
            this.chart.SeriesTemplate.SynchronizePointOptions = false;
            this.chart.SeriesTemplate.ValueDataMembersSerializable = "Values";
            pie3DSeriesView1.Titles.AddRange(new DevExpress.XtraCharts.SeriesTitle[] {
            seriesTitle1});
            this.chart.SeriesTemplate.View = pie3DSeriesView1;
            this.chart.Size = new System.Drawing.Size(732, 521);
            this.chart.TabIndex = 4;
            chartTitle1.Text = "Top Customers";
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // pivotGrid
            // 
            this.pivotGrid.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldRevenue,
            this.fieldCustomer});
            this.pivotGrid.Location = new System.Drawing.Point(8, 56);
            this.pivotGrid.Name = "pivotGrid";
            this.pivotGrid.OptionsChartDataSource.FieldValuesProvideMode = DevExpress.XtraPivotGrid.PivotChartFieldValuesProvideMode.DisplayText;
            this.pivotGrid.OptionsChartDataSource.ProvideColumnCustomTotals = false;
            this.pivotGrid.OptionsChartDataSource.ProvideColumnTotals = false;
            this.pivotGrid.OptionsChartDataSource.ProvideRowCustomTotals = false;
            this.pivotGrid.OptionsChartDataSource.ProvideRowGrandTotals = false;
            this.pivotGrid.OptionsChartDataSource.ProvideRowTotals = false;
            this.pivotGrid.OptionsChartDataSource.SelectionOnly = false;
            this.pivotGrid.OptionsCustomization.AllowDrag = false;
            this.pivotGrid.OptionsView.ShowColumnGrandTotals = false;
            this.pivotGrid.OptionsView.ShowColumnHeaders = false;
            this.pivotGrid.OptionsView.ShowFilterHeaders = false;
            this.pivotGrid.Size = new System.Drawing.Size(259, 473);
            this.pivotGrid.TabIndex = 5;
            this.pivotGrid.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pivotGrid_MouseMove);
            this.pivotGrid.FieldValueDisplayText += new DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventHandler(this.pivotGrid_FieldValueDisplayText);
            this.pivotGrid.FieldTooltipShowing += new DevExpress.XtraPivotGrid.PivotFieldTooltipShowingEventHandler(this.pivotGrid_FieldTooltipShowing);
            // 
            // fieldRevenue
            // 
            this.fieldRevenue.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldRevenue.AreaIndex = 0;
            this.fieldRevenue.Caption = "Income";
            this.fieldRevenue.FieldName = "Payment";
            this.fieldRevenue.Name = "fieldRevenue";
            // 
            // fieldCustomer
            // 
            this.fieldCustomer.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCustomer.AreaIndex = 0;
            this.fieldCustomer.Caption = "Customer";
            this.fieldCustomer.FieldName = "Customer!";
            this.fieldCustomer.Name = "fieldCustomer";
            this.fieldCustomer.SortBySummaryInfo.Field = this.fieldRevenue;
            this.fieldCustomer.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
            this.fieldCustomer.TopValueCount = 10;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
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
            this.layoutControlItem1.Location = new System.Drawing.Point(268, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(736, 525);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.pivotGrid;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(263, 477);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.comboPeriod;
            this.layoutControlItem3.CustomizationFormText = "Period";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(263, 24);
            this.layoutControlItem3.Text = "Period:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(82, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.spinCustomerCount;
            this.layoutControlItem4.CustomizationFormText = "Customer Count";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(263, 24);
            this.layoutControlItem4.Text = "Customer Count:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(82, 13);
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.CustomizationFormText = "splitterItem1";
            this.splitterItem1.Location = new System.Drawing.Point(263, 0);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(5, 525);
            // 
            // TopCustomersStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "TopCustomersStatistics";
            this.Size = new System.Drawing.Size(1016, 537);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spinCustomerCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboPeriod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
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
        private DevExpress.XtraPivotGrid.PivotGridField fieldCustomer;
        private DevExpress.XtraEditors.ComboBoxEdit comboPeriod;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SpinEdit spinCustomerCount;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraCharts.ChartControl chart;
    }
}
