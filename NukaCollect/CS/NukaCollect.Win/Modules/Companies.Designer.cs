namespace NukaCollect.Win.Modules {
    partial class Companies {
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.colPhoto1 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.layoutViewField_colPhotoExist1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colTitle1 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colTitle2 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colReleaseDate1 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colReleaseDate2 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colPlot1 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.layoutViewField_colPlot2 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colDescription = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.xcCompanies = new DevExpress.Xpo.XPCollection();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWebSite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.colCountry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFlag = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPhotoExist1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colTitle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colReleaseDate2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPlot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xcCompanies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutView1
            // 
            this.layoutView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.layoutView1.CardCaptionFormat = "Movie {0} of {1}";
            this.layoutView1.CardHorzInterval = 12;
            this.layoutView1.CardMinSize = new System.Drawing.Size(255, 216);
            this.layoutView1.CardVertInterval = 12;
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colPhoto1,
            this.colTitle1,
            this.colReleaseDate1,
            this.colPlot1,
            this.colDescription});
            this.layoutView1.GridControl = this.gridControl1;
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.OptionsBehavior.Editable = false;
            this.layoutView1.OptionsBehavior.ScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            this.layoutView1.OptionsCustomization.AllowFilter = false;
            this.layoutView1.OptionsCustomization.AllowSort = false;
            this.layoutView1.OptionsView.CardsAlignment = DevExpress.XtraGrid.Views.Layout.CardsAlignment.Near;
            this.layoutView1.OptionsView.ContentAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutView1.OptionsView.ShowCardExpandButton = false;
            this.layoutView1.OptionsView.ShowCardLines = false;
            this.layoutView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.layoutView1.OptionsView.ShowHeaderPanel = false;
            this.layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiRow;
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            this.layoutView1.CustomCardLayout += new DevExpress.XtraGrid.Views.Layout.Events.LayoutViewCustomCardLayoutEventHandler(this.layoutView1_CustomCardLayout);
            // 
            // colPhoto1
            // 
            this.colPhoto1.ColumnEdit = this.repositoryItemPictureEdit1;
            this.colPhoto1.FieldName = "Movie.PhotoExist";
            this.colPhoto1.LayoutViewField = this.layoutViewField_colPhotoExist1;
            this.colPhoto1.Name = "colPhoto1";
            this.colPhoto1.OptionsColumn.AllowFocus = false;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            // 
            // layoutViewField_colPhotoExist1
            // 
            this.layoutViewField_colPhotoExist1.EditorPreferredWidth = 110;
            this.layoutViewField_colPhotoExist1.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colPhotoExist1.Name = "layoutViewField_colPhotoExist1";
            this.layoutViewField_colPhotoExist1.Size = new System.Drawing.Size(114, 156);
            this.layoutViewField_colPhotoExist1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutViewField_colPhotoExist1.TextToControlDistance = 0;
            this.layoutViewField_colPhotoExist1.TextVisible = false;
            // 
            // colTitle1
            // 
            this.colTitle1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTitle1.AppearanceCell.Options.UseFont = true;
            this.colTitle1.FieldName = "Movie.Title";
            this.colTitle1.LayoutViewField = this.layoutViewField_colTitle2;
            this.colTitle1.Name = "colTitle1";
            this.colTitle1.OptionsColumn.AllowFocus = false;
            // 
            // layoutViewField_colTitle2
            // 
            this.layoutViewField_colTitle2.EditorPreferredWidth = 117;
            this.layoutViewField_colTitle2.Location = new System.Drawing.Point(114, 0);
            this.layoutViewField_colTitle2.Name = "layoutViewField_colTitle2";
            this.layoutViewField_colTitle2.Size = new System.Drawing.Size(121, 20);
            this.layoutViewField_colTitle2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutViewField_colTitle2.TextToControlDistance = 0;
            this.layoutViewField_colTitle2.TextVisible = false;
            // 
            // colReleaseDate1
            // 
            this.colReleaseDate1.FieldName = "Movie.ReleaseDate";
            this.colReleaseDate1.LayoutViewField = this.layoutViewField_colReleaseDate2;
            this.colReleaseDate1.Name = "colReleaseDate1";
            this.colReleaseDate1.OptionsColumn.AllowFocus = false;
            // 
            // layoutViewField_colReleaseDate2
            // 
            this.layoutViewField_colReleaseDate2.EditorPreferredWidth = 117;
            this.layoutViewField_colReleaseDate2.Location = new System.Drawing.Point(114, 20);
            this.layoutViewField_colReleaseDate2.Name = "layoutViewField_colReleaseDate2";
            this.layoutViewField_colReleaseDate2.Size = new System.Drawing.Size(121, 20);
            this.layoutViewField_colReleaseDate2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutViewField_colReleaseDate2.TextToControlDistance = 0;
            this.layoutViewField_colReleaseDate2.TextVisible = false;
            // 
            // colPlot1
            // 
            this.colPlot1.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colPlot1.FieldName = "Movie.Plot";
            this.colPlot1.LayoutViewField = this.layoutViewField_colPlot2;
            this.colPlot1.Name = "colPlot1";
            this.colPlot1.OptionsColumn.AllowFocus = false;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // layoutViewField_colPlot2
            // 
            this.layoutViewField_colPlot2.EditorPreferredWidth = 117;
            this.layoutViewField_colPlot2.Location = new System.Drawing.Point(114, 40);
            this.layoutViewField_colPlot2.Name = "layoutViewField_colPlot2";
            this.layoutViewField_colPlot2.Size = new System.Drawing.Size(121, 116);
            this.layoutViewField_colPlot2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutViewField_colPlot2.TextToControlDistance = 0;
            this.layoutViewField_colPlot2.TextVisible = false;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.LayoutViewField = this.layoutViewField_layoutViewColumn1;
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsColumn.AllowFocus = false;
            // 
            // layoutViewField_layoutViewColumn1
            // 
            this.layoutViewField_layoutViewColumn1.EditorPreferredWidth = 169;
            this.layoutViewField_layoutViewColumn1.Location = new System.Drawing.Point(0, 156);
            this.layoutViewField_layoutViewColumn1.Name = "layoutViewField_layoutViewColumn1";
            this.layoutViewField_layoutViewColumn1.Size = new System.Drawing.Size(235, 20);
            this.layoutViewField_layoutViewColumn1.TextSize = new System.Drawing.Size(57, 13);
            this.layoutViewField_layoutViewColumn1.TextToControlDistance = 5;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.xcCompanies;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.layoutView1;
            gridLevelNode1.RelationName = "Movies";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(6, 6);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1,
            this.repositoryItemMemoEdit1,
            this.repositoryItemPictureEdit2,
            this.repositoryItemHyperLinkEdit1});
            this.gridControl1.ShowOnlyPredefinedDetails = true;
            this.gridControl1.Size = new System.Drawing.Size(1033, 624);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.layoutView1});
            this.gridControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseDown);
            // 
            // xcCompanies
            // 
            this.xcCompanies.CaseSensitive = true;
            this.xcCompanies.LoadingEnabled = false;
            this.xcCompanies.ObjectType = typeof(NukaCollect.Company);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colType,
            this.colWebSite,
            this.colCountry,
            this.colFlag});
            this.gridView1.DetailHeight = 100;
            this.gridView1.DetailVerticalIndent = 2;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Oid", null, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsDetail.ShowDetailTabs = false;
            this.gridView1.OptionsPrint.ExpandAllDetails = true;
            this.gridView1.OptionsPrint.PrintDetails = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colName
            // 
            this.colName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colName.AppearanceCell.Options.UseFont = true;
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowFocus = false;
            this.colName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 343;
            // 
            // colType
            // 
            this.colType.FieldName = "Type!Key";
            this.colType.Name = "colType";
            this.colType.OptionsColumn.AllowFocus = false;
            this.colType.Visible = true;
            this.colType.VisibleIndex = 2;
            this.colType.Width = 154;
            // 
            // colWebSite
            // 
            this.colWebSite.ColumnEdit = this.repositoryItemHyperLinkEdit1;
            this.colWebSite.FieldName = "WebSite";
            this.colWebSite.Name = "colWebSite";
            this.colWebSite.OptionsColumn.AllowFocus = false;
            this.colWebSite.OptionsFilter.AllowFilter = false;
            this.colWebSite.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colWebSite.Visible = true;
            this.colWebSite.VisibleIndex = 3;
            this.colWebSite.Width = 264;
            // 
            // repositoryItemHyperLinkEdit1
            // 
            this.repositoryItemHyperLinkEdit1.AutoHeight = false;
            this.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1";
            // 
            // colCountry
            // 
            this.colCountry.FieldName = "Country!Key";
            this.colCountry.Name = "colCountry";
            this.colCountry.OptionsColumn.AllowFocus = false;
            this.colCountry.Visible = true;
            this.colCountry.VisibleIndex = 1;
            this.colCountry.Width = 137;
            // 
            // colFlag
            // 
            this.colFlag.Caption = "Flag";
            this.colFlag.ColumnEdit = this.repositoryItemPictureEdit2;
            this.colFlag.FieldName = "Country.Flag";
            this.colFlag.Name = "colFlag";
            this.colFlag.OptionsColumn.AllowFocus = false;
            this.colFlag.OptionsColumn.FixedWidth = true;
            this.colFlag.OptionsFilter.AllowAutoFilter = false;
            this.colFlag.OptionsFilter.AllowFilter = false;
            this.colFlag.Visible = true;
            this.colFlag.VisibleIndex = 4;
            this.colFlag.Width = 114;
            // 
            // repositoryItemPictureEdit2
            // 
            this.repositoryItemPictureEdit2.Name = "repositoryItemPictureEdit2";
            this.repositoryItemPictureEdit2.NullText = " ";
            this.repositoryItemPictureEdit2.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.repositoryItemPictureEdit2.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.CustomizationFormText = "TemplateCard";
            this.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colPhotoExist1,
            this.layoutViewField_colPlot2,
            this.layoutViewField_colTitle2,
            this.layoutViewField_colReleaseDate2,
            this.layoutViewField_layoutViewColumn1});
            this.layoutViewCard1.Name = "layoutViewCard1";
            this.layoutViewCard1.OptionsItemText.TextToControlDistance = 5;
            this.layoutViewCard1.Text = "TemplateCard";
            // 
            // Companies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "Companies";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Size = new System.Drawing.Size(1045, 636);
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPhotoExist1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colTitle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colReleaseDate2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPlot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xcCompanies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Xpo.XPCollection xcCompanies;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private DevExpress.XtraGrid.Columns.GridColumn colWebSite;
        private DevExpress.XtraGrid.Columns.GridColumn colCountry;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colPhoto1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colTitle1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colReleaseDate1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colPlot1;
        private DevExpress.XtraGrid.Columns.GridColumn colFlag;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colPhotoExist1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colTitle2;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colReleaseDate2;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colPlot2;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colDescription;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
    }
}
