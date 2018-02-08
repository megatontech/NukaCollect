namespace NukaCollect.Win.Modules {
    partial class Categories {
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel1 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            this.colIsDefault = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCategories = new DevExpress.XtraGrid.GridControl();
            this.gvCategories = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lciMovieCategoryDetail = new DevExpress.XtraLayout.LayoutControlItem();
            this.ucMovieCategoryDetail = new NukaCollect.Win.Controls.ucMovieCategoryDetail();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.lcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciCategories = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gcCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMovieCategoryDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // colIsDefault
            // 
            this.colIsDefault.Caption = "Default";
            this.colIsDefault.FieldName = "IsDefault";
            this.colIsDefault.Name = "colIsDefault";
            this.colIsDefault.OptionsColumn.AllowFocus = false;
            this.colIsDefault.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colIsDefault.Visible = true;
            this.colIsDefault.VisibleIndex = 1;
            this.colIsDefault.Width = 94;
            // 
            // gcCategories
            // 
            this.gcCategories.Location = new System.Drawing.Point(6, 6);
            this.gcCategories.MainView = this.gvCategories;
            this.gcCategories.Name = "gcCategories";
            this.gcCategories.Size = new System.Drawing.Size(258, 500);
            this.gcCategories.TabIndex = 4;
            this.gcCategories.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCategories});
            // 
            // gvCategories
            // 
            this.gvCategories.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colIsDefault});
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colIsDefault;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = true;
            this.gvCategories.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gvCategories.GridControl = this.gcCategories;
            this.gvCategories.Name = "gvCategories";
            this.gvCategories.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvCategories.OptionsBehavior.Editable = false;
            this.gvCategories.OptionsBehavior.ReadOnly = true;
            this.gvCategories.OptionsCustomization.AllowFilter = false;
            this.gvCategories.OptionsCustomization.AllowGroup = false;
            this.gvCategories.OptionsView.EnableAppearanceEvenRow = true;
            this.gvCategories.OptionsView.ShowDetailButtons = false;
            this.gvCategories.OptionsView.ShowGroupPanel = false;
            this.gvCategories.OptionsView.ShowIndicator = false;
            this.gvCategories.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gvCategories.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvCategories_FocusedRowChanged);
            this.gvCategories.ColumnFilterChanged += new System.EventHandler(this.gvCategories_ColumnFilterChanged);
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowFocus = false;
            this.colName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 217;
            // 
            // lciMovieCategoryDetail
            // 
            this.lciMovieCategoryDetail.Control = this.ucMovieCategoryDetail;
            this.lciMovieCategoryDetail.CustomizationFormText = "lciMovieCategoryDetail";
            this.lciMovieCategoryDetail.Location = new System.Drawing.Point(267, 0);
            this.lciMovieCategoryDetail.MaxSize = new System.Drawing.Size(0, 315);
            this.lciMovieCategoryDetail.MinSize = new System.Drawing.Size(100, 315);
            this.lciMovieCategoryDetail.Name = "lciMovieCategoryDetail";
            this.lciMovieCategoryDetail.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lciMovieCategoryDetail.Size = new System.Drawing.Size(503, 315);
            this.lciMovieCategoryDetail.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciMovieCategoryDetail.Text = "lciMovieCategoryDetail";
            this.lciMovieCategoryDetail.TextSize = new System.Drawing.Size(0, 0);
            this.lciMovieCategoryDetail.TextToControlDistance = 0;
            this.lciMovieCategoryDetail.TextVisible = false;
            // 
            // ucMovieCategoryDetail
            // 
            this.ucMovieCategoryDetail.Location = new System.Drawing.Point(271, 4);
            this.ucMovieCategoryDetail.Name = "ucMovieCategoryDetail";
            this.ucMovieCategoryDetail.Size = new System.Drawing.Size(503, 315);
            this.ucMovieCategoryDetail.TabIndex = 5;
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.chartControl1);
            this.lcMain.Controls.Add(this.gcCategories);
            this.lcMain.Controls.Add(this.ucMovieCategoryDetail);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 0);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.lcgMain;
            this.lcMain.Size = new System.Drawing.Size(778, 512);
            this.lcMain.TabIndex = 10;
            this.lcMain.Text = "layoutControl1";
            // 
            // chartControl1
            // 
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = true;
            xyDiagram1.AxisX.VisualRange.AutoSideMargins = true;
            xyDiagram1.AxisX.Title.Text = "Days";
            xyDiagram1.AxisX.Title.Visible = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.WholeRange.AutoSideMargins = true;
            xyDiagram1.AxisY.VisualRange.AutoSideMargins = true;
            xyDiagram1.AxisY.Title.Text = "Payment $";
            xyDiagram1.AxisY.Title.Visible = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Location = new System.Drawing.Point(273, 325);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesDataMember = "Type";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.SeriesTemplate.ArgumentDataMember = "Day";
            pointSeriesLabel1.LineVisible = true;
            this.chartControl1.SeriesTemplate.Label = pointSeriesLabel1;
            this.chartControl1.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            this.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "Price";
            this.chartControl1.SeriesTemplate.View = lineSeriesView1;
            this.chartControl1.Size = new System.Drawing.Size(499, 181);
            this.chartControl1.TabIndex = 6;
            // 
            // lcgMain
            // 
            this.lcgMain.CustomizationFormText = "lcgMain";
            this.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgMain.GroupBordersVisible = false;
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciCategories,
            this.splitterItem,
            this.lciMovieCategoryDetail,
            this.layoutControlItem1});
            this.lcgMain.Location = new System.Drawing.Point(0, 0);
            this.lcgMain.Name = "Root";
            this.lcgMain.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.lcgMain.Size = new System.Drawing.Size(778, 512);
            this.lcgMain.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgMain.Text = "Root";
            this.lcgMain.TextVisible = false;
            // 
            // lciCategories
            // 
            this.lciCategories.Control = this.gcCategories;
            this.lciCategories.CustomizationFormText = "lciCategories";
            this.lciCategories.Location = new System.Drawing.Point(0, 0);
            this.lciCategories.Name = "lciCategories";
            this.lciCategories.Size = new System.Drawing.Size(262, 504);
            this.lciCategories.Text = "lciCategories";
            this.lciCategories.TextSize = new System.Drawing.Size(0, 0);
            this.lciCategories.TextToControlDistance = 0;
            this.lciCategories.TextVisible = false;
            // 
            // splitterItem
            // 
            this.splitterItem.AllowHotTrack = true;
            this.splitterItem.CustomizationFormText = "splitterItem";
            this.splitterItem.Location = new System.Drawing.Point(262, 0);
            this.splitterItem.Name = "splitterItem";
            this.splitterItem.Size = new System.Drawing.Size(5, 504);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.chartControl1;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(267, 315);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 6, 2);
            this.layoutControlItem1.Size = new System.Drawing.Size(503, 189);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lcMain);
            this.Name = "Categories";
            this.Size = new System.Drawing.Size(778, 512);
            ((System.ComponentModel.ISupportInitialize)(this.gcCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMovieCategoryDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcCategories;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCategories;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colIsDefault;
        private DevExpress.XtraLayout.LayoutControlItem lciMovieCategoryDetail;
        private NukaCollect.Win.Controls.ucMovieCategoryDetail ucMovieCategoryDetail;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup lcgMain;
        private DevExpress.XtraLayout.LayoutControlItem lciCategories;
        private DevExpress.XtraLayout.SplitterItem splitterItem;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}
