namespace NukaCollect.Win.Modules {
    partial class Artists {
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Artists));
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.colPicture = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.xcArtist = new DevExpress.Xpo.XPCollection(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colArtistId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirthCountry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirthLocation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirthName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirthDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBiography = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.colNickName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLink = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ilColumnImages = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xcArtist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // cardView1
            // 
            this.cardView1.CardCaptionFormat = "Photo {0}";
            this.cardView1.CardWidth = 250;
            this.cardView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPicture});
            this.cardView1.FocusedCardTopFieldIndex = 0;
            this.cardView1.GridControl = this.gridControl1;
            this.cardView1.Name = "cardView1";
            this.cardView1.OptionsBehavior.Editable = false;
            this.cardView1.OptionsBehavior.FieldAutoHeight = true;
            this.cardView1.OptionsView.ShowFieldCaptions = false;
            this.cardView1.OptionsView.ShowQuickCustomizeButton = false;
            this.cardView1.CalcFieldHeight += new DevExpress.XtraGrid.Views.Card.FieldHeightEventHandler(this.cardView1_CalcFieldHeight);
            // 
            // colPicture
            // 
            this.colPicture.ColumnEdit = this.repositoryItemPictureEdit1;
            this.colPicture.FieldName = "Image";
            this.colPicture.Name = "colPicture";
            this.colPicture.Visible = true;
            this.colPicture.VisibleIndex = 0;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.xcArtist;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.cardView1;
            gridLevelNode1.RelationName = "Pictures";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(6, 6);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1,
            this.repositoryItemMemoExEdit1});
            this.gridControl1.ShowOnlyPredefinedDetails = true;
            this.gridControl1.Size = new System.Drawing.Size(904, 534);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.cardView1});
            // 
            // xcArtist
            // 
            this.xcArtist.LoadingEnabled = false;
            this.xcArtist.ObjectType = typeof(NukaCollect.Artist);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Preview.Font = new System.Drawing.Font("Tahoma", 6.75F);
            this.gridView1.Appearance.Preview.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colArtistId,
            this.colGender,
            this.colBirthCountry,
            this.colBirthLocation,
            this.colFirstName,
            this.colLastName,
            this.colBirthName,
            this.colBirthDate,
            this.colBiography,
            this.colNickName,
            this.colLink});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Images = this.ilColumnImages;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsDetail.AllowExpandEmptyDetails = true;
            this.gridView1.OptionsDetail.EnableDetailToolTip = true;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsDetail.ShowDetailTabs = false;
            this.gridView1.OptionsPrint.PrintPreview = true;
            this.gridView1.OptionsView.AutoCalcPreviewLineCount = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowPreview = true;
            this.gridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.PreviewFieldName = "Biography";
            this.gridView1.PreviewLineCount = 5;
            this.gridView1.MasterRowGetRelationDisplayCaption += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.gridView1_MasterRowGetRelationDisplayCaption);
            // 
            // colArtistId
            // 
            this.colArtistId.FieldName = "ArtistId";
            this.colArtistId.Name = "colArtistId";
            this.colArtistId.OptionsColumn.AllowEdit = false;
            this.colArtistId.OptionsColumn.AllowFocus = false;
            // 
            // colGender
            // 
            this.colGender.FieldName = "Gender";
            this.colGender.ImageIndex = 0;
            this.colGender.Name = "colGender";
            this.colGender.OptionsColumn.AllowEdit = false;
            this.colGender.OptionsColumn.AllowFocus = false;
            this.colGender.OptionsColumn.AllowMove = false;
            this.colGender.OptionsColumn.AllowSize = false;
            this.colGender.OptionsColumn.FixedWidth = true;
            this.colGender.OptionsColumn.ShowCaption = false;
            this.colGender.Visible = true;
            this.colGender.VisibleIndex = 0;
            this.colGender.Width = 45;
            // 
            // colBirthCountry
            // 
            this.colBirthCountry.Caption = "Birth Country";
            this.colBirthCountry.FieldName = "BirthCountry!Key";
            this.colBirthCountry.Name = "colBirthCountry";
            this.colBirthCountry.OptionsColumn.AllowEdit = false;
            this.colBirthCountry.OptionsColumn.AllowFocus = false;
            this.colBirthCountry.Visible = true;
            this.colBirthCountry.VisibleIndex = 5;
            this.colBirthCountry.Width = 115;
            // 
            // colBirthLocation
            // 
            this.colBirthLocation.FieldName = "BirthLocation";
            this.colBirthLocation.Name = "colBirthLocation";
            this.colBirthLocation.OptionsColumn.AllowEdit = false;
            this.colBirthLocation.OptionsColumn.AllowFocus = false;
            this.colBirthLocation.Visible = true;
            this.colBirthLocation.VisibleIndex = 6;
            this.colBirthLocation.Width = 139;
            // 
            // colFirstName
            // 
            this.colFirstName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colFirstName.AppearanceCell.Options.UseFont = true;
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.OptionsColumn.AllowEdit = false;
            this.colFirstName.OptionsColumn.AllowFocus = false;
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 1;
            this.colFirstName.Width = 130;
            // 
            // colLastName
            // 
            this.colLastName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colLastName.AppearanceCell.Options.UseFont = true;
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.OptionsColumn.AllowEdit = false;
            this.colLastName.OptionsColumn.AllowFocus = false;
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 2;
            this.colLastName.Width = 132;
            // 
            // colBirthName
            // 
            this.colBirthName.FieldName = "BirthName";
            this.colBirthName.Name = "colBirthName";
            this.colBirthName.OptionsColumn.AllowEdit = false;
            this.colBirthName.OptionsColumn.AllowFocus = false;
            this.colBirthName.Visible = true;
            this.colBirthName.VisibleIndex = 4;
            this.colBirthName.Width = 106;
            // 
            // colBirthDate
            // 
            this.colBirthDate.FieldName = "BirthDate";
            this.colBirthDate.Name = "colBirthDate";
            this.colBirthDate.OptionsColumn.AllowEdit = false;
            this.colBirthDate.OptionsColumn.AllowFocus = false;
            this.colBirthDate.Visible = true;
            this.colBirthDate.VisibleIndex = 3;
            this.colBirthDate.Width = 138;
            // 
            // colBiography
            // 
            this.colBiography.ColumnEdit = this.repositoryItemMemoExEdit1;
            this.colBiography.FieldName = "Biography";
            this.colBiography.Name = "colBiography";
            this.colBiography.OptionsColumn.AllowEdit = false;
            this.colBiography.OptionsColumn.AllowFocus = false;
            this.colBiography.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBiography.OptionsFilter.AllowAutoFilter = false;
            this.colBiography.OptionsFilter.AllowFilter = false;
            this.colBiography.Visible = true;
            this.colBiography.VisibleIndex = 8;
            // 
            // repositoryItemMemoExEdit1
            // 
            this.repositoryItemMemoExEdit1.AutoHeight = false;
            this.repositoryItemMemoExEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1";
            this.repositoryItemMemoExEdit1.PopupFormSize = new System.Drawing.Size(350, 200);
            // 
            // colNickName
            // 
            this.colNickName.FieldName = "NickName";
            this.colNickName.Name = "colNickName";
            this.colNickName.OptionsColumn.AllowEdit = false;
            this.colNickName.OptionsColumn.AllowFocus = false;
            this.colNickName.Visible = true;
            this.colNickName.VisibleIndex = 7;
            this.colNickName.Width = 105;
            // 
            // colLink
            // 
            this.colLink.FieldName = "Link";
            this.colLink.Name = "colLink";
            this.colLink.OptionsColumn.AllowEdit = false;
            this.colLink.OptionsColumn.AllowFocus = false;
            // 
            // ilColumnImages
            // 
            this.ilColumnImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilColumnImages.ImageStream")));
            this.ilColumnImages.TransparentColor = System.Drawing.Color.Magenta;
            this.ilColumnImages.Images.SetKeyName(0, "");
            // 
            // Artists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "Artists";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Size = new System.Drawing.Size(916, 546);
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xcArtist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Xpo.XPCollection xcArtist;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colGender;
        private DevExpress.XtraGrid.Columns.GridColumn colBirthCountry;
        private DevExpress.XtraGrid.Columns.GridColumn colBirthLocation;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colBirthName;
        private DevExpress.XtraGrid.Columns.GridColumn colBirthDate;
        private DevExpress.XtraGrid.Columns.GridColumn colBiography;
        private DevExpress.XtraGrid.Columns.GridColumn colNickName;
        private DevExpress.XtraGrid.Columns.GridColumn colLink;
        private DevExpress.XtraGrid.Columns.GridColumn colArtistId;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private DevExpress.XtraGrid.Columns.GridColumn colPicture;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private System.Windows.Forms.ImageList ilColumnImages;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
    }
}
