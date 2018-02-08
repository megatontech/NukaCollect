namespace NukaCollect.Win.Forms {
    partial class frmCreateInitialDB {
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
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.notePanel = new DevExpress.Utils.Frames.NotePanel8_1();
            this.teDatabaseSQL = new DevExpress.XtraEditors.TextEdit();
            this.tePassword = new DevExpress.XtraEditors.TextEdit();
            this.teLogin = new DevExpress.XtraEditors.TextEdit();
            this.teDatabase = new DevExpress.XtraEditors.TextEdit();
            this.teServer = new DevExpress.XtraEditors.TextEdit();
            this.sbCreate = new DevExpress.XtraEditors.SimpleButton();
            this.vbwRentsHistory = new NukaCollect.Win.VisualBackgroundWorker();
            this.ceGenerateRentsHistory = new DevExpress.XtraEditors.CheckEdit();
            this.vbwCreatingDb = new NukaCollect.Win.VisualBackgroundWorker();
            this.rgSqlAuthenticationType = new DevExpress.XtraEditors.RadioGroup();
            this.rgType = new DevExpress.XtraEditors.RadioGroup();
            this.lciGenerateRentsHistory = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciRentsHistory = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciType = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciCreatingDB = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciCreate = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lcgAccess = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciDatabase = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lcgSQL = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciServer = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDatabaseSQL = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSqlConnect = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciLogin = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciPassword = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem7 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.emptySpaceItem8 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teDatabaseSQL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDatabase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teServer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vbwRentsHistory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceGenerateRentsHistory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vbwCreatingDb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgSqlAuthenticationType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGenerateRentsHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRentsHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCreatingDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCreate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgAccess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgSQL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDatabaseSQL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSqlConnect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // lcMain
            // 
            this.lcMain.AllowCustomizationMenu = false;
            this.lcMain.AutoScroll = false;
            this.lcMain.Controls.Add(this.notePanel);
            this.lcMain.Controls.Add(this.teDatabaseSQL);
            this.lcMain.Controls.Add(this.tePassword);
            this.lcMain.Controls.Add(this.teLogin);
            this.lcMain.Controls.Add(this.teDatabase);
            this.lcMain.Controls.Add(this.teServer);
            this.lcMain.Controls.Add(this.sbCreate);
            this.lcMain.Controls.Add(this.vbwRentsHistory);
            this.lcMain.Controls.Add(this.ceGenerateRentsHistory);
            this.lcMain.Controls.Add(this.vbwCreatingDb);
            this.lcMain.Controls.Add(this.rgSqlAuthenticationType);
            this.lcMain.Controls.Add(this.rgType);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciGenerateRentsHistory});
            this.lcMain.Location = new System.Drawing.Point(0, 0);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.lcgMain;
            this.lcMain.Size = new System.Drawing.Size(416, 448);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // notePanel
            // 
            this.notePanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.notePanel.Location = new System.Drawing.Point(12, 12);
            this.notePanel.MaxRows = 10;
            this.notePanel.Name = "notePanel";
            this.notePanel.Size = new System.Drawing.Size(392, 50);
            this.notePanel.TabIndex = 17;
            this.notePanel.TabStop = false;
            // 
            // teDatabaseSQL
            // 
            this.teDatabaseSQL.Location = new System.Drawing.Point(279, 184);
            this.teDatabaseSQL.Name = "teDatabaseSQL";
            this.teDatabaseSQL.Size = new System.Drawing.Size(125, 20);
            this.teDatabaseSQL.StyleController = this.lcMain;
            this.teDatabaseSQL.TabIndex = 16;
            // 
            // tePassword
            // 
            this.tePassword.Location = new System.Drawing.Point(279, 295);
            this.tePassword.Name = "tePassword";
            this.tePassword.Size = new System.Drawing.Size(125, 20);
            this.tePassword.StyleController = this.lcMain;
            this.tePassword.TabIndex = 15;
            // 
            // teLogin
            // 
            this.teLogin.Location = new System.Drawing.Point(279, 271);
            this.teLogin.Name = "teLogin";
            this.teLogin.Size = new System.Drawing.Size(125, 20);
            this.teLogin.StyleController = this.lcMain;
            this.teLogin.TabIndex = 14;
            // 
            // teDatabase
            // 
            this.teDatabase.Location = new System.Drawing.Point(115, 160);
            this.teDatabase.Name = "teDatabase";
            this.teDatabase.Size = new System.Drawing.Size(57, 20);
            this.teDatabase.StyleController = this.lcMain;
            this.teDatabase.TabIndex = 9;
            // 
            // teServer
            // 
            this.teServer.EditValue = ".\\SQLExpress";
            this.teServer.Enabled = false;
            this.teServer.Location = new System.Drawing.Point(279, 160);
            this.teServer.Name = "teServer";
            this.teServer.Size = new System.Drawing.Size(125, 20);
            this.teServer.StyleController = this.lcMain;
            this.teServer.TabIndex = 8;
            // 
            // sbCreate
            // 
            this.sbCreate.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sbCreate.Appearance.Options.UseFont = true;
            this.sbCreate.Location = new System.Drawing.Point(205, 414);
            this.sbCreate.Name = "sbCreate";
            this.sbCreate.Size = new System.Drawing.Size(199, 22);
            this.sbCreate.StyleController = this.lcMain;
            this.sbCreate.TabIndex = 12;
            this.sbCreate.Text = "Create";
            this.sbCreate.Click += new System.EventHandler(this.sbCreate_Click);
            // 
            // vbwRentsHistory
            // 
            this.vbwRentsHistory.Location = new System.Drawing.Point(138, 380);
            this.vbwRentsHistory.Name = "vbwRentsHistory";
            this.vbwRentsHistory.Properties.ShowTitle = true;
            this.vbwRentsHistory.Size = new System.Drawing.Size(266, 20);
            this.vbwRentsHistory.StyleController = this.lcMain;
            this.vbwRentsHistory.TabIndex = 0;
            // 
            // ceGenerateRentsHistory
            // 
            this.ceGenerateRentsHistory.EditValue = true;
            this.ceGenerateRentsHistory.Enabled = false;
            this.ceGenerateRentsHistory.Location = new System.Drawing.Point(12, 264);
            this.ceGenerateRentsHistory.Name = "ceGenerateRentsHistory";
            this.ceGenerateRentsHistory.Properties.Caption = "Generate rents history";
            this.ceGenerateRentsHistory.Size = new System.Drawing.Size(420, 19);
            this.ceGenerateRentsHistory.StyleController = this.lcMain;
            this.ceGenerateRentsHistory.TabIndex = 13;
            this.ceGenerateRentsHistory.CheckedChanged += new System.EventHandler(this.ceGenerateRentsHistory_CheckedChanged);
            // 
            // vbwCreatingDb
            // 
            this.vbwCreatingDb.Location = new System.Drawing.Point(138, 356);
            this.vbwCreatingDb.Name = "vbwCreatingDb";
            this.vbwCreatingDb.Properties.ShowTitle = true;
            this.vbwCreatingDb.Size = new System.Drawing.Size(266, 20);
            this.vbwCreatingDb.StyleController = this.lcMain;
            this.vbwCreatingDb.TabIndex = 7;
            // 
            // rgSqlAuthenticationType
            // 
            this.rgSqlAuthenticationType.Location = new System.Drawing.Point(200, 208);
            this.rgSqlAuthenticationType.Name = "rgSqlAuthenticationType";
            this.rgSqlAuthenticationType.Size = new System.Drawing.Size(204, 59);
            this.rgSqlAuthenticationType.StyleController = this.lcMain;
            this.rgSqlAuthenticationType.TabIndex = 6;
            this.rgSqlAuthenticationType.EditValueChanged += new System.EventHandler(this.rgSqlAuthenticationType_EditValueChanged);
            // 
            // rgType
            // 
            this.rgType.Location = new System.Drawing.Point(12, 93);
            this.rgType.Name = "rgType";
            this.rgType.Size = new System.Drawing.Size(392, 63);
            this.rgType.StyleController = this.lcMain;
            this.rgType.TabIndex = 5;
            this.rgType.EditValueChanged += new System.EventHandler(this.rgType_EditValueChanged);
            // 
            // lciGenerateRentsHistory
            // 
            this.lciGenerateRentsHistory.Control = this.ceGenerateRentsHistory;
            this.lciGenerateRentsHistory.CustomizationFormText = "lciGenerateRentsHistory";
            this.lciGenerateRentsHistory.Location = new System.Drawing.Point(0, 252);
            this.lciGenerateRentsHistory.Name = "lciGenerateRentsHistory";
            this.lciGenerateRentsHistory.Size = new System.Drawing.Size(424, 22);
            this.lciGenerateRentsHistory.Text = "lciGenerateRentsHistory";
            this.lciGenerateRentsHistory.TextSize = new System.Drawing.Size(0, 0);
            this.lciGenerateRentsHistory.TextToControlDistance = 0;
            this.lciGenerateRentsHistory.TextVisible = false;
            // 
            // lcgMain
            // 
            this.lcgMain.CustomizationFormText = "lcgMain";
            this.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgMain.GroupBordersVisible = false;
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciRentsHistory,
            this.lciType,
            this.lciCreatingDB,
            this.emptySpaceItem1,
            this.lciCreate,
            this.emptySpaceItem3,
            this.lcgAccess,
            this.lcgSQL,
            this.emptySpaceItem2,
            this.layoutControlItem1,
            this.emptySpaceItem7,
            this.simpleSeparator1,
            this.emptySpaceItem8});
            this.lcgMain.Location = new System.Drawing.Point(0, 0);
            this.lcgMain.Name = "Root";
            this.lcgMain.Size = new System.Drawing.Size(416, 448);
            this.lcgMain.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgMain.Text = "Root";
            this.lcgMain.TextVisible = false;
            // 
            // lciRentsHistory
            // 
            this.lciRentsHistory.Control = this.vbwRentsHistory;
            this.lciRentsHistory.CustomizationFormText = "lciRentsHistory";
            this.lciRentsHistory.Location = new System.Drawing.Point(0, 368);
            this.lciRentsHistory.MaxSize = new System.Drawing.Size(0, 24);
            this.lciRentsHistory.MinSize = new System.Drawing.Size(180, 24);
            this.lciRentsHistory.Name = "lciRentsHistory";
            this.lciRentsHistory.Size = new System.Drawing.Size(396, 24);
            this.lciRentsHistory.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciRentsHistory.Text = "Generating data:";
            this.lciRentsHistory.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lciRentsHistory.TextSize = new System.Drawing.Size(121, 13);
            this.lciRentsHistory.TextToControlDistance = 5;
            // 
            // lciType
            // 
            this.lciType.Control = this.rgType;
            this.lciType.CustomizationFormText = "lciType";
            this.lciType.Location = new System.Drawing.Point(0, 65);
            this.lciType.MaxSize = new System.Drawing.Size(0, 83);
            this.lciType.MinSize = new System.Drawing.Size(79, 83);
            this.lciType.Name = "lciType";
            this.lciType.Size = new System.Drawing.Size(396, 83);
            this.lciType.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciType.Text = "Database type:";
            this.lciType.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciType.TextSize = new System.Drawing.Size(75, 13);
            // 
            // lciCreatingDB
            // 
            this.lciCreatingDB.Control = this.vbwCreatingDb;
            this.lciCreatingDB.CustomizationFormText = "lciCreateDB";
            this.lciCreatingDB.Location = new System.Drawing.Point(0, 344);
            this.lciCreatingDB.MaxSize = new System.Drawing.Size(0, 24);
            this.lciCreatingDB.MinSize = new System.Drawing.Size(180, 24);
            this.lciCreatingDB.Name = "lciCreatingDB";
            this.lciCreatingDB.Size = new System.Drawing.Size(396, 24);
            this.lciCreatingDB.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciCreatingDB.Text = "Creating database:";
            this.lciCreatingDB.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lciCreatingDB.TextSize = new System.Drawing.Size(121, 13);
            this.lciCreatingDB.TextToControlDistance = 5;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 402);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(193, 26);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciCreate
            // 
            this.lciCreate.Control = this.sbCreate;
            this.lciCreate.CustomizationFormText = "lciCreate";
            this.lciCreate.Location = new System.Drawing.Point(193, 402);
            this.lciCreate.Name = "lciCreate";
            this.lciCreate.Size = new System.Drawing.Size(203, 26);
            this.lciCreate.Text = "lciCreate";
            this.lciCreate.TextSize = new System.Drawing.Size(0, 0);
            this.lciCreate.TextToControlDistance = 0;
            this.lciCreate.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3";
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 392);
            this.emptySpaceItem3.MaxSize = new System.Drawing.Size(0, 10);
            this.emptySpaceItem3.MinSize = new System.Drawing.Size(10, 10);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(396, 10);
            this.emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem3.Text = "emptySpaceItem3";
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lcgAccess
            // 
            this.lcgAccess.CustomizationFormText = "lcgAccess";
            this.lcgAccess.GroupBordersVisible = false;
            this.lcgAccess.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciDatabase,
            this.emptySpaceItem5});
            this.lcgAccess.Location = new System.Drawing.Point(0, 148);
            this.lcgAccess.Name = "lcgAccess";
            this.lcgAccess.Size = new System.Drawing.Size(164, 159);
            this.lcgAccess.Text = "lcgAccess";
            // 
            // lciDatabase
            // 
            this.lciDatabase.Control = this.teDatabase;
            this.lciDatabase.CustomizationFormText = "Database:";
            this.lciDatabase.Location = new System.Drawing.Point(24, 0);
            this.lciDatabase.Name = "lciDatabase";
            this.lciDatabase.Size = new System.Drawing.Size(140, 159);
            this.lciDatabase.Text = "Database:";
            this.lciDatabase.TextSize = new System.Drawing.Size(75, 13);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.CustomizationFormText = "emptySpaceItem5";
            this.emptySpaceItem5.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem5.MaxSize = new System.Drawing.Size(24, 0);
            this.emptySpaceItem5.MinSize = new System.Drawing.Size(24, 10);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(24, 159);
            this.emptySpaceItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem5.Text = "emptySpaceItem5";
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lcgSQL
            // 
            this.lcgSQL.CustomizationFormText = "lcgSQL";
            this.lcgSQL.GroupBordersVisible = false;
            this.lcgSQL.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciServer,
            this.lciDatabaseSQL,
            this.lciSqlConnect,
            this.lciLogin,
            this.lciPassword,
            this.emptySpaceItem6});
            this.lcgSQL.Location = new System.Drawing.Point(164, 148);
            this.lcgSQL.Name = "lcgSQL";
            this.lcgSQL.Size = new System.Drawing.Size(232, 159);
            this.lcgSQL.Text = "lcgSQL";
            // 
            // lciServer
            // 
            this.lciServer.Control = this.teServer;
            this.lciServer.CustomizationFormText = "SQL Server:";
            this.lciServer.Location = new System.Drawing.Point(24, 0);
            this.lciServer.Name = "lciServer";
            this.lciServer.Size = new System.Drawing.Size(208, 24);
            this.lciServer.Text = "SQL Server:";
            this.lciServer.TextSize = new System.Drawing.Size(75, 13);
            // 
            // lciDatabaseSQL
            // 
            this.lciDatabaseSQL.Control = this.teDatabaseSQL;
            this.lciDatabaseSQL.CustomizationFormText = "Database:";
            this.lciDatabaseSQL.Location = new System.Drawing.Point(24, 24);
            this.lciDatabaseSQL.Name = "lciDatabaseSQL";
            this.lciDatabaseSQL.Size = new System.Drawing.Size(208, 24);
            this.lciDatabaseSQL.Text = "Database:";
            this.lciDatabaseSQL.TextSize = new System.Drawing.Size(75, 13);
            // 
            // lciSqlConnect
            // 
            this.lciSqlConnect.Control = this.rgSqlAuthenticationType;
            this.lciSqlConnect.CustomizationFormText = "layoutControlItem1";
            this.lciSqlConnect.Location = new System.Drawing.Point(24, 48);
            this.lciSqlConnect.MaxSize = new System.Drawing.Size(0, 63);
            this.lciSqlConnect.MinSize = new System.Drawing.Size(54, 63);
            this.lciSqlConnect.Name = "lciSqlConnect";
            this.lciSqlConnect.Size = new System.Drawing.Size(208, 63);
            this.lciSqlConnect.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciSqlConnect.Text = "lciSqlConnect";
            this.lciSqlConnect.TextSize = new System.Drawing.Size(0, 0);
            this.lciSqlConnect.TextToControlDistance = 0;
            this.lciSqlConnect.TextVisible = false;
            // 
            // lciLogin
            // 
            this.lciLogin.Control = this.teLogin;
            this.lciLogin.CustomizationFormText = "layoutControlItem2";
            this.lciLogin.Location = new System.Drawing.Point(24, 111);
            this.lciLogin.Name = "lciLogin";
            this.lciLogin.Size = new System.Drawing.Size(208, 24);
            this.lciLogin.Text = "Login:";
            this.lciLogin.TextSize = new System.Drawing.Size(75, 13);
            // 
            // lciPassword
            // 
            this.lciPassword.Control = this.tePassword;
            this.lciPassword.CustomizationFormText = "layoutControlItem4";
            this.lciPassword.Location = new System.Drawing.Point(24, 135);
            this.lciPassword.Name = "lciPassword";
            this.lciPassword.Size = new System.Drawing.Size(208, 24);
            this.lciPassword.Text = "Password:";
            this.lciPassword.TextSize = new System.Drawing.Size(75, 13);
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.CustomizationFormText = "emptySpaceItem6";
            this.emptySpaceItem6.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem6.MaxSize = new System.Drawing.Size(24, 0);
            this.emptySpaceItem6.MinSize = new System.Drawing.Size(24, 10);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(24, 159);
            this.emptySpaceItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem6.Text = "emptySpaceItem6";
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 307);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(396, 19);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.notePanel;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(396, 54);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem7
            // 
            this.emptySpaceItem7.CustomizationFormText = "emptySpaceItem7";
            this.emptySpaceItem7.Location = new System.Drawing.Point(0, 54);
            this.emptySpaceItem7.MaxSize = new System.Drawing.Size(0, 11);
            this.emptySpaceItem7.MinSize = new System.Drawing.Size(10, 11);
            this.emptySpaceItem7.Name = "emptySpaceItem7";
            this.emptySpaceItem7.Size = new System.Drawing.Size(396, 11);
            this.emptySpaceItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem7.Text = "emptySpaceItem7";
            this.emptySpaceItem7.TextSize = new System.Drawing.Size(0, 0);
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.CustomizationFormText = "simpleSeparator1";
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 326);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(396, 2);
            this.simpleSeparator1.Text = "simpleSeparator1";
            // 
            // emptySpaceItem8
            // 
            this.emptySpaceItem8.CustomizationFormText = "emptySpaceItem8";
            this.emptySpaceItem8.Location = new System.Drawing.Point(0, 328);
            this.emptySpaceItem8.Name = "emptySpaceItem8";
            this.emptySpaceItem8.Size = new System.Drawing.Size(396, 16);
            this.emptySpaceItem8.Text = "emptySpaceItem8";
            this.emptySpaceItem8.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.teLogin;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 219);
            this.layoutControlItem3.Name = "layoutControlItem2";
            this.layoutControlItem3.Size = new System.Drawing.Size(424, 24);
            this.layoutControlItem3.Text = "layoutControlItem2";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(93, 13);
            this.layoutControlItem3.TextToControlDistance = 5;
            // 
            // frmCreateInitialDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 448);
            this.Controls.Add(this.lcMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmCreateInitialDB";
            this.Text = "Create Database";
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teDatabaseSQL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDatabase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teServer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vbwRentsHistory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceGenerateRentsHistory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vbwCreatingDb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgSqlAuthenticationType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGenerateRentsHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRentsHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCreatingDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCreate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgAccess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgSQL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDatabaseSQL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSqlConnect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private VisualBackgroundWorker vbwRentsHistory;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup lcgMain;
        private DevExpress.XtraLayout.LayoutControlItem lciRentsHistory;
        private DevExpress.XtraEditors.RadioGroup rgType;
        private DevExpress.XtraLayout.LayoutControlItem lciType;
        private VisualBackgroundWorker vbwCreatingDb;
        private DevExpress.XtraLayout.LayoutControlItem lciCreatingDB;
        private DevExpress.XtraEditors.TextEdit teDatabase;
        private DevExpress.XtraEditors.TextEdit teServer;
        private DevExpress.XtraEditors.SimpleButton sbCreate;
        private DevExpress.XtraLayout.LayoutControlItem lciCreate;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.CheckEdit ceGenerateRentsHistory;
        private DevExpress.XtraLayout.LayoutControlItem lciGenerateRentsHistory;
        private DevExpress.XtraEditors.RadioGroup rgSqlAuthenticationType;
        private DevExpress.XtraEditors.TextEdit tePassword;
        private DevExpress.XtraEditors.TextEdit teLogin;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.TextEdit teDatabaseSQL;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.LayoutControlGroup lcgAccess;
        private DevExpress.XtraLayout.LayoutControlItem lciDatabase;
        private DevExpress.XtraLayout.LayoutControlGroup lcgSQL;
        private DevExpress.XtraLayout.LayoutControlItem lciServer;
        private DevExpress.XtraLayout.LayoutControlItem lciDatabaseSQL;
        private DevExpress.XtraLayout.LayoutControlItem lciSqlConnect;
        private DevExpress.XtraLayout.LayoutControlItem lciLogin;
        private DevExpress.XtraLayout.LayoutControlItem lciPassword;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
        private DevExpress.Utils.Frames.NotePanel8_1 notePanel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem7;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem8;
    }
}
