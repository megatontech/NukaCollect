namespace NukaCollect.Win.Modules {
    partial class CompanyDetail {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.teName = new DevExpress.XtraEditors.TextEdit();
            this.lueType = new DevExpress.XtraEditors.LookUpEdit();
            this.lueCountry = new DevExpress.XtraEditors.LookUpEdit();
            this.beWebSite = new DevExpress.XtraEditors.ButtonEdit();
            this.ucGridEditBar = new NukaCollect.Win.Controls.ucGridEditBar();
            this.gcMovies = new DevExpress.XtraGrid.GridControl();
            this.gvMovies = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMovie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lciName = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciType = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciWebSite = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciCountry = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciMoviesGridBar = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciMovies = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.peFlag = new DevExpress.XtraEditors.PictureEdit();
            this.lciFlag = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCountry.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beWebSite.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciWebSite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMoviesGridBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peFlag.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.peFlag);
            this.lcMain.Controls.Add(this.teName);
            this.lcMain.Controls.Add(this.lueType);
            this.lcMain.Controls.Add(this.beWebSite);
            this.lcMain.Controls.Add(this.lueCountry);
            this.lcMain.Controls.Add(this.gcMovies);
            this.lcMain.Controls.Add(this.ucGridEditBar);
            this.lcMain.Size = new System.Drawing.Size(466, 403);
            // 
            // lcgMain
            // 
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciName,
            this.lciWebSite,
            this.lciType,
            this.lciCountry,
            this.lciMoviesGridBar,
            this.lciMovies,
            this.simpleSeparator1,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.lciFlag});
            this.lcgMain.Name = "Root";
            this.lcgMain.Size = new System.Drawing.Size(466, 403);
            this.lcgMain.Text = "Root";
            // 
            // teName
            // 
            this.teName.Location = new System.Drawing.Point(82, 8);
            this.teName.Name = "teName";
            this.teName.Size = new System.Drawing.Size(223, 20);
            this.teName.StyleController = this.lcMain;
            this.teName.TabIndex = 4;
            // 
            // lueType
            // 
            this.lueType.Location = new System.Drawing.Point(82, 32);
            this.lueType.Name = "lueType";
            this.lueType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueType.Properties.NullText = "";
            this.lueType.Properties.PopupSizeable = false;
            this.lueType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueType.Size = new System.Drawing.Size(223, 20);
            this.lueType.StyleController = this.lcMain;
            this.lueType.TabIndex = 5;
            // 
            // lueCountry
            // 
            this.lueCountry.Location = new System.Drawing.Point(82, 80);
            this.lueCountry.Name = "lueCountry";
            this.lueCountry.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueCountry.Properties.NullText = "";
            this.lueCountry.Properties.PopupSizeable = false;
            this.lueCountry.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueCountry.Size = new System.Drawing.Size(223, 20);
            this.lueCountry.StyleController = this.lcMain;
            this.lueCountry.TabIndex = 7;
            this.lueCountry.EditValueChanged += new System.EventHandler(this.lueCountry_EditValueChanged);
            // 
            // beWebSite
            // 
            this.beWebSite.Location = new System.Drawing.Point(82, 56);
            this.beWebSite.Name = "beWebSite";
            this.beWebSite.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "Go to Website", null, null, true)});
            this.beWebSite.Size = new System.Drawing.Size(223, 20);
            this.beWebSite.StyleController = this.lcMain;
            this.beWebSite.TabIndex = 6;
            this.beWebSite.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beWebSite_ButtonClick);
            // 
            // ucGridEditBar
            // 
            this.ucGridEditBar.Location = new System.Drawing.Point(8, 142);
            this.ucGridEditBar.Name = "ucGridEditBar";
            this.ucGridEditBar.Size = new System.Drawing.Size(450, 26);
            this.ucGridEditBar.TabIndex = 5;
            this.ucGridEditBar.DeleteRecord += new System.EventHandler(this.ucGridEditBar_DeleteRecord);
            this.ucGridEditBar.AddRecord += new System.EventHandler(this.ucGridEditBar_AddRecord);
            // 
            // gcMovies
            // 
            this.gcMovies.Location = new System.Drawing.Point(8, 172);
            this.gcMovies.MainView = this.gvMovies;
            this.gcMovies.Name = "gcMovies";
            this.gcMovies.ShowOnlyPredefinedDetails = true;
            this.gcMovies.Size = new System.Drawing.Size(450, 223);
            this.gcMovies.TabIndex = 4;
            this.gcMovies.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMovies});
            // 
            // gvMovies
            // 
            this.gvMovies.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMovie,
            this.colDescription});
            this.gvMovies.GridControl = this.gcMovies;
            this.gvMovies.Name = "gvMovies";
            this.gvMovies.OptionsView.ShowDetailButtons = false;
            this.gvMovies.OptionsView.ShowGroupPanel = false;
            // 
            // colMovie
            // 
            this.colMovie.Caption = "Movie";
            this.colMovie.FieldName = "Movie!";
            this.colMovie.Name = "colMovie";
            this.colMovie.Visible = true;
            this.colMovie.VisibleIndex = 0;
            this.colMovie.Width = 280;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            this.colDescription.Width = 148;
            // 
            // lciName
            // 
            this.lciName.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lciName.AppearanceItemCaption.Options.UseFont = true;
            this.lciName.Control = this.teName;
            this.lciName.CustomizationFormText = "Name:";
            this.lciName.Location = new System.Drawing.Point(0, 0);
            this.lciName.Name = "lciName";
            this.lciName.Size = new System.Drawing.Size(301, 24);
            this.lciName.Text = "Name:";
            this.lciName.TextSize = new System.Drawing.Size(70, 13);
            // 
            // lciType
            // 
            this.lciType.Control = this.lueType;
            this.lciType.CustomizationFormText = "Type:";
            this.lciType.Location = new System.Drawing.Point(0, 24);
            this.lciType.Name = "lciType";
            this.lciType.Size = new System.Drawing.Size(301, 24);
            this.lciType.Text = "Type:";
            this.lciType.TextSize = new System.Drawing.Size(70, 13);
            // 
            // lciWebSite
            // 
            this.lciWebSite.Control = this.beWebSite;
            this.lciWebSite.CustomizationFormText = "Web Site:";
            this.lciWebSite.Location = new System.Drawing.Point(0, 48);
            this.lciWebSite.Name = "lciWebSite";
            this.lciWebSite.Size = new System.Drawing.Size(301, 24);
            this.lciWebSite.Text = "Web Site:";
            this.lciWebSite.TextSize = new System.Drawing.Size(70, 13);
            // 
            // lciCountry
            // 
            this.lciCountry.Control = this.lueCountry;
            this.lciCountry.CustomizationFormText = "Country:";
            this.lciCountry.Location = new System.Drawing.Point(0, 72);
            this.lciCountry.Name = "lciCountry";
            this.lciCountry.Size = new System.Drawing.Size(301, 24);
            this.lciCountry.Text = "Country:";
            this.lciCountry.TextSize = new System.Drawing.Size(70, 13);
            // 
            // lciMoviesGridBar
            // 
            this.lciMoviesGridBar.Control = this.ucGridEditBar;
            this.lciMoviesGridBar.CustomizationFormText = "lciMoviesGridBar";
            this.lciMoviesGridBar.Location = new System.Drawing.Point(0, 118);
            this.lciMoviesGridBar.Name = "lciMoviesGridBar";
            this.lciMoviesGridBar.Size = new System.Drawing.Size(454, 46);
            this.lciMoviesGridBar.Text = "Linked Movies:";
            this.lciMoviesGridBar.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciMoviesGridBar.TextSize = new System.Drawing.Size(70, 13);
            // 
            // lciMovies
            // 
            this.lciMovies.Control = this.gcMovies;
            this.lciMovies.CustomizationFormText = "lciMovies";
            this.lciMovies.Location = new System.Drawing.Point(0, 164);
            this.lciMovies.Name = "lciMovies";
            this.lciMovies.Size = new System.Drawing.Size(454, 227);
            this.lciMovies.Text = "lciMovies";
            this.lciMovies.TextSize = new System.Drawing.Size(0, 0);
            this.lciMovies.TextToControlDistance = 0;
            this.lciMovies.TextVisible = false;
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.CustomizationFormText = "simpleSeparator1";
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 106);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(454, 2);
            this.simpleSeparator1.Text = "simpleSeparator1";
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 108);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(0, 10);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(10, 10);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(454, 10);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 96);
            this.emptySpaceItem2.MaxSize = new System.Drawing.Size(0, 10);
            this.emptySpaceItem2.MinSize = new System.Drawing.Size(10, 10);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(454, 10);
            this.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // peFlag
            // 
            this.peFlag.Location = new System.Drawing.Point(309, 8);
            this.peFlag.Name = "peFlag";
            this.peFlag.Properties.AllowFocused = false;
            this.peFlag.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.peFlag.Properties.Appearance.Options.UseBackColor = true;
            this.peFlag.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peFlag.Properties.NullText = " ";
            this.peFlag.Properties.ShowMenu = false;
            this.peFlag.Size = new System.Drawing.Size(149, 92);
            this.peFlag.StyleController = this.lcMain;
            this.peFlag.TabIndex = 8;
            // 
            // lciFlag
            // 
            this.lciFlag.Control = this.peFlag;
            this.lciFlag.CustomizationFormText = "lciFlag";
            this.lciFlag.Location = new System.Drawing.Point(301, 0);
            this.lciFlag.MaxSize = new System.Drawing.Size(153, 0);
            this.lciFlag.MinSize = new System.Drawing.Size(153, 24);
            this.lciFlag.Name = "lciFlag";
            this.lciFlag.Size = new System.Drawing.Size(153, 96);
            this.lciFlag.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciFlag.Text = "lciFlag";
            this.lciFlag.TextSize = new System.Drawing.Size(0, 0);
            this.lciFlag.TextToControlDistance = 0;
            this.lciFlag.TextVisible = false;
            // 
            // CompanyDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "CompanyDetail";
            this.Size = new System.Drawing.Size(466, 403);
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCountry.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beWebSite.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciWebSite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMoviesGridBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peFlag.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFlag)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit teName;
        private NukaCollect.Win.Controls.ucGridEditBar ucGridEditBar;
        private DevExpress.XtraGrid.GridControl gcMovies;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMovies;
        private DevExpress.XtraGrid.Columns.GridColumn colMovie;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraEditors.LookUpEdit lueType;
        private DevExpress.XtraEditors.LookUpEdit lueCountry;
        private DevExpress.XtraEditors.ButtonEdit beWebSite;
        private DevExpress.XtraLayout.LayoutControlItem lciName;
        private DevExpress.XtraLayout.LayoutControlItem lciWebSite;
        private DevExpress.XtraLayout.LayoutControlItem lciType;
        private DevExpress.XtraLayout.LayoutControlItem lciCountry;
        private DevExpress.XtraLayout.LayoutControlItem lciMoviesGridBar;
        private DevExpress.XtraLayout.LayoutControlItem lciMovies;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.PictureEdit peFlag;
        private DevExpress.XtraLayout.LayoutControlItem lciFlag;
    }
}
