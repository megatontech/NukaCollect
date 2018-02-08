namespace NukaCollect.Win.Controls {
    partial class ucMovieItemsInfo {
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
            DevExpress.XtraCharts.SimpleDiagram simpleDiagram1 = new DevExpress.XtraCharts.SimpleDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.DoughnutSeriesLabel doughnutSeriesLabel1 = new DevExpress.XtraCharts.DoughnutSeriesLabel();
            DevExpress.XtraCharts.PiePointOptions piePointOptions1 = new DevExpress.XtraCharts.PiePointOptions();
            DevExpress.XtraCharts.DoughnutSeriesView doughnutSeriesView1 = new DevExpress.XtraCharts.DoughnutSeriesView();
            DevExpress.XtraCharts.SeriesTitle seriesTitle1 = new DevExpress.XtraCharts.SeriesTitle();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.DoughnutSeriesLabel doughnutSeriesLabel2 = new DevExpress.XtraCharts.DoughnutSeriesLabel();
            DevExpress.XtraCharts.PiePointOptions piePointOptions2 = new DevExpress.XtraCharts.PiePointOptions();
            DevExpress.XtraCharts.DoughnutSeriesView doughnutSeriesView2 = new DevExpress.XtraCharts.DoughnutSeriesView();
            DevExpress.XtraCharts.SeriesTitle seriesTitle2 = new DevExpress.XtraCharts.SeriesTitle();
            DevExpress.XtraCharts.DoughnutSeriesLabel doughnutSeriesLabel3 = new DevExpress.XtraCharts.DoughnutSeriesLabel();
            DevExpress.XtraCharts.PiePointOptions piePointOptions3 = new DevExpress.XtraCharts.PiePointOptions();
            DevExpress.XtraCharts.DoughnutSeriesView doughnutSeriesView3 = new DevExpress.XtraCharts.DoughnutSeriesView();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.ccFormatsInfo = new DevExpress.XtraCharts.ChartControl();
            this.teLastRentedOn = new DevExpress.XtraEditors.TextEdit();
            this.lcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciLastRentedOn = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciChart = new DevExpress.XtraLayout.LayoutControlItem();
            this.tcMain = new DevExpress.XtraLayout.TabbedControlGroup();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ccFormatsInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLastRentedOn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLastRentedOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcMain)).BeginInit();
            this.SuspendLayout();
            // 
            // lcMain
            // 
            this.lcMain.AllowCustomizationMenu = false;
            this.lcMain.Controls.Add(this.ccFormatsInfo);
            this.lcMain.Controls.Add(this.teLastRentedOn);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 0);
            this.lcMain.Name = "lcMain";
            this.lcMain.Padding = new System.Windows.Forms.Padding(3);
            this.lcMain.Root = this.lcgMain;
            this.lcMain.Size = new System.Drawing.Size(486, 400);
            this.lcMain.TabIndex = 0;
            this.lcMain.Text = "layoutControl1";
            // 
            // ccFormatsInfo
            // 
            this.ccFormatsInfo.CrosshairOptions.ArgumentLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(57)))), ((int)(((byte)(205)))));
            this.ccFormatsInfo.CrosshairOptions.ValueLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(57)))), ((int)(((byte)(205)))));
            simpleDiagram1.CustomPanel = null;
            simpleDiagram1.EqualPieSize = false;
            this.ccFormatsInfo.Diagram = simpleDiagram1;
            this.ccFormatsInfo.Legend.Visible = false;
            this.ccFormatsInfo.Location = new System.Drawing.Point(5, 191);
            this.ccFormatsInfo.Name = "ccFormatsInfo";
            doughnutSeriesLabel1.LineVisible = true;
            piePointOptions1.ArgumentNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General;
            piePointOptions1.PercentOptions.ValueAsPercent = false;
            piePointOptions1.PointView = DevExpress.XtraCharts.PointView.ArgumentAndValues;
            piePointOptions1.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Percent;
            doughnutSeriesLabel1.PointOptions = piePointOptions1;
            series1.Label = doughnutSeriesLabel1;
            series1.Name = "Series 1";
            doughnutSeriesView1.RuntimeExploding = true;
            seriesTitle1.Text = "Media Formats";
            doughnutSeriesView1.Titles.AddRange(new DevExpress.XtraCharts.SeriesTitle[] {
            seriesTitle1});
            series1.View = doughnutSeriesView1;
            doughnutSeriesLabel2.LineVisible = true;
            piePointOptions2.ArgumentNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General;
            piePointOptions2.PercentOptions.ValueAsPercent = false;
            piePointOptions2.PointView = DevExpress.XtraCharts.PointView.ArgumentAndValues;
            piePointOptions2.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Percent;
            doughnutSeriesLabel2.PointOptions = piePointOptions2;
            series2.Label = doughnutSeriesLabel2;
            series2.Name = "Series 2";
            doughnutSeriesView2.RuntimeExploding = false;
            seriesTitle2.Text = "Unit Allocation";
            doughnutSeriesView2.Titles.AddRange(new DevExpress.XtraCharts.SeriesTitle[] {
            seriesTitle2});
            series2.View = doughnutSeriesView2;
            this.ccFormatsInfo.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            doughnutSeriesLabel3.LineVisible = true;
            piePointOptions3.ArgumentNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General;
            piePointOptions3.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General;
            doughnutSeriesLabel3.PointOptions = piePointOptions3;
            this.ccFormatsInfo.SeriesTemplate.Label = doughnutSeriesLabel3;
            doughnutSeriesView3.RuntimeExploding = false;
            this.ccFormatsInfo.SeriesTemplate.View = doughnutSeriesView3;
            this.ccFormatsInfo.Size = new System.Drawing.Size(476, 204);
            this.ccFormatsInfo.TabIndex = 46;
            this.ccFormatsInfo.CustomDrawSeriesPoint += new DevExpress.XtraCharts.CustomDrawSeriesPointEventHandler(this.ccFormatsInfo_CustomDrawSeriesPoint);
            this.ccFormatsInfo.PieSeriesPointExploded += new DevExpress.XtraCharts.PieSeriesPointExplodedEventHandler(this.ccFormatsInfo_PieSeriesPointExploded);
            // 
            // teLastRentedOn
            // 
            this.teLastRentedOn.Location = new System.Drawing.Point(94, 5);
            this.teLastRentedOn.Name = "teLastRentedOn";
            this.teLastRentedOn.Properties.ReadOnly = true;
            this.teLastRentedOn.Size = new System.Drawing.Size(387, 20);
            this.teLastRentedOn.StyleController = this.lcMain;
            this.teLastRentedOn.TabIndex = 6;
            // 
            // lcgMain
            // 
            this.lcgMain.CustomizationFormText = "lcgMain";
            this.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgMain.GroupBordersVisible = false;
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciLastRentedOn,
            this.lciChart,
            this.tcMain});
            this.lcgMain.Location = new System.Drawing.Point(0, 0);
            this.lcgMain.Name = "Root";
            this.lcgMain.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.lcgMain.Size = new System.Drawing.Size(486, 400);
            this.lcgMain.Text = "Root";
            this.lcgMain.TextVisible = false;
            // 
            // lciLastRentedOn
            // 
            this.lciLastRentedOn.Control = this.teLastRentedOn;
            this.lciLastRentedOn.CustomizationFormText = "Last Rented On:";
            this.lciLastRentedOn.Location = new System.Drawing.Point(0, 0);
            this.lciLastRentedOn.Name = "lciLastRentedOn";
            this.lciLastRentedOn.Size = new System.Drawing.Size(480, 24);
            this.lciLastRentedOn.Text = "Last Rented On:";
            this.lciLastRentedOn.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lciLastRentedOn.TextSize = new System.Drawing.Size(83, 13);
            this.lciLastRentedOn.TextToControlDistance = 6;
            // 
            // lciChart
            // 
            this.lciChart.Control = this.ccFormatsInfo;
            this.lciChart.CustomizationFormText = "layoutControlItemChart";
            this.lciChart.Location = new System.Drawing.Point(0, 182);
            this.lciChart.Name = "lciChart";
            this.lciChart.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 6, 2);
            this.lciChart.Size = new System.Drawing.Size(480, 212);
            this.lciChart.Text = "lciChart";
            this.lciChart.TextSize = new System.Drawing.Size(0, 0);
            this.lciChart.TextToControlDistance = 0;
            this.lciChart.TextVisible = false;
            // 
            // tcMain
            // 
            this.tcMain.CustomizationFormText = "tcMain";
            this.tcMain.Location = new System.Drawing.Point(0, 24);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedTabPage = null;
            this.tcMain.SelectedTabPageIndex = -1;
            this.tcMain.Size = new System.Drawing.Size(480, 158);
            this.tcMain.Text = "tcMain";
            this.tcMain.SelectedPageChanged += new DevExpress.XtraLayout.LayoutTabPageChangedEventHandler(this.tcMain_SelectedPageChanged);
            // 
            // ucMovieItemsInfo
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.Controls.Add(this.lcMain);
            this.Name = "ucMovieItemsInfo";
            this.Size = new System.Drawing.Size(486, 400);
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccFormatsInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLastRentedOn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLastRentedOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup lcgMain;
        private DevExpress.XtraEditors.TextEdit teLastRentedOn;
        private DevExpress.XtraLayout.LayoutControlItem lciLastRentedOn;
        private DevExpress.XtraCharts.ChartControl ccFormatsInfo;
        private DevExpress.XtraLayout.LayoutControlItem lciChart;
        private DevExpress.XtraLayout.TabbedControlGroup tcMain;

    }
}
