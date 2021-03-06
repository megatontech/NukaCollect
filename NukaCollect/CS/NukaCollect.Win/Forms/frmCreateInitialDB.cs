using DevExpress.DemoData.Helpers;
using DevExpress.XtraEditors;
using NukaCollect.Helpers;
using NukaCollect.Resources;
using System;
using System.Windows.Forms;

namespace NukaCollect.Win.Forms
{
    public partial class frmCreateInitialDB : XtraForm
    {
        private DBConnectData dbConnectData;
        private FormAnimationSizer sizer;

        public frmCreateInitialDB(DBConnectData dbConnectData)
        {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForFrmCreateInitialDB(this);
            sizer = new FormAnimationSizer(this);
            this.dbConnectData = dbConnectData;
            this.Icon = ElementHelper.AppIcon;
            teServer.EditValue = DbEngineDetector.GetSqlServerInstanceName();
            notePanel.Text = ConstStrings.Get("DatabaseCreating");
            EditorHelper.CreateDBFormatRadioGroup(rgType.Properties);
            rgType.DataBindings.Add("EditValue", dbConnectData, "DBFormat");
            EditorHelper.CreateSqlAuthenticationTypeRadioGroup(rgSqlAuthenticationType.Properties);
            rgSqlAuthenticationType.DataBindings.Add("EditValue", dbConnectData, "SqlAuthenticationType");
            teServer.DataBindings.Add("Text", dbConnectData, "Server");
            teLogin.DataBindings.Add("Text", dbConnectData, "Login");
            tePassword.DataBindings.Add("Text", dbConnectData, "Password");
            ceGenerateRentsHistory.DataBindings.Add("Checked", dbConnectData, "GenerateRentsHistory");
            teDatabase.DataBindings.Add("Text", dbConnectData, "MdbPath");
            teDatabaseSQL.DataBindings.Add("Text", dbConnectData, "SqlDbName");
        }

        public event EventHandler Start;

        private void rgType_EditValueChanged(object sender, EventArgs e)
        {
            lcMain.BeginUpdate();
            try
            {
                if ((DBFormat)rgType.EditValue == DBFormat.Mdb)
                    DisbleSqlConnect();
                else
                    EnableSqlConnect();
            }
            finally
            {
                lcMain.EndUpdate();
                sizer.SetMinHeight(lcMain.Root.MinSize.Height);
            }
        }

        private void EnableSqlConnect()
        {
            lcgSQL.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            lcgAccess.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            teServer.Enabled = true;
            rgSqlAuthenticationType.Enabled = true;
            teDatabaseSQL.Enabled = true;
            teDatabase.Enabled = false;
            UpdateLoginPassword();
        }

        private void DisbleSqlConnect()
        {
            lcgAccess.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            lcgSQL.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            teServer.Enabled = false;
            rgSqlAuthenticationType.Enabled = false;
            teLogin.Enabled = false;
            tePassword.Enabled = false;
            teDatabaseSQL.Enabled = false;
            teDatabase.Enabled = true;
        }

        private void rgSqlAuthenticationType_EditValueChanged(object sender, EventArgs e)
        {
            UpdateLoginPassword();
        }

        private void UpdateLoginPassword()
        {
            teLogin.Enabled = tePassword.Enabled = (SqlAuthenticationType)rgSqlAuthenticationType.EditValue == SqlAuthenticationType.Sql;
        }

        private void ceGenerateRentsHistory_CheckedChanged(object sender, EventArgs e)
        {
            if (ceGenerateRentsHistory.Visible)
                vbwRentsHistory.Enabled = ceGenerateRentsHistory.Checked;
        }

        private void sbCreate_Click(object sender, EventArgs e)
        {
            EventHandler start = Start;
            if (start != null) start(this, EventArgs.Empty);
        }

        public void BeginWork()
        {
            this.Cursor = Cursors.WaitCursor;
            sbCreate.Enabled = false;
            lcMain.OptionsView.IsReadOnly = DevExpress.Utils.DefaultBoolean.True;
            lcMain.Refresh();
        }

        public void EndWork(bool complete)
        {
            lcMain.OptionsView.IsReadOnly = DevExpress.Utils.DefaultBoolean.False;
            sbCreate.Enabled = true;
            if (!complete)
            {
                vbwCreatingDb.Position = vbwCreatingDb.Properties.Minimum;
                vbwRentsHistory.Position = vbwRentsHistory.Properties.Minimum;
            }
            this.Cursor = Cursors.Arrow;
        }

        public IBackgroundWorker CreateDbWorker { get { return vbwCreatingDb; } }
        public IBackgroundWorker GenerateRentsHistoryWorker { get { return vbwRentsHistory; } }
    }

    public class CreateInitialDbDialog : ICreateInitialDbDialog
    {
        private frmCreateInitialDB form;

        public void Show(DBConnectData dbConnectData)
        {
            form = new frmCreateInitialDB(dbConnectData);
        }

        public void ShowDialog()
        {
            form.ShowDialog();
        }

        public void Close()
        {
            form.Close();
            form.Dispose();
        }

        public IBackgroundWorker CreateDbWorker { get { return form.CreateDbWorker; } }
        public IBackgroundWorker GenerateRentsHistoryWorker { get { return form.GenerateRentsHistoryWorker; } }

        public event EventHandler Start
        {
            add { form.Start += value; }
            remove { form.Start -= value; }
        }

        public void BeginWork()
        {
            form.BeginWork();
        }

        public void EndWork(bool complete)
        {
            form.EndWork(complete);
        }

        public void ShowUnableToOpenMessage(bool createNew)
        {
            XtraMessageBox.Show(createNew ? ConstStrings.Get("UnableCreateDBMessage") : ConstStrings.Get("UnableOpenDBMessage"), ConstStrings.Get("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}