using DevExpress.Utils.Menu;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NukaCollect.Win.Forms
{
    public partial class frmAddBase : XtraForm, IFormWithLayoutManager
    {
        protected VideoRentBaseObject editObject;
        private UnitOfWork session;
        private Form parent;

        public frmAddBase()
        {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForFrmAddBase(this);
        }

        public frmAddBase(Form parent, UnitOfWork session, VideoRentBaseObject editObject, IDXMenuManager manager)
            : this()
        {
            this.session = session;
            this.editObject = editObject;
            this.parent = parent;
            lcMain.MenuManager = manager;
        }

        public UnitOfWork Session { get { return session; } }

        protected UnitOfWork GetSession()
        {
            return Session;
        }

        public FormLayoutManager LayoutManager
        {
            get
            {
                if (parent is IFormWithLayoutManager)
                    return ((IFormWithLayoutManager)parent).LayoutManager;
                return null;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (parent == null) return;
            InitData();
            InitValidation();
            this.Location = new Point(parent.Left + (parent.Width - this.Width) / 2,
                parent.Top + (parent.Height - this.Height) / 2);
            LoadFormLayout();
            foreach (Control item in lcMain.Controls)
            {
                BaseEdit edit = item as BaseEdit;
                if (edit != null)
                {
                    edit.MenuManager = lcMain.MenuManager;
                }
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            if (DialogResult == DialogResult.OK)
            {
                if (editObject == null) CreateNewObject();
                SaveData();
            }
            else
            {
                CloseCancelForm();
            }
            SaveFormLayout();
        }

        private void sbSave_Click(object sender, EventArgs e)
        {
            if (ValidationProvider.Validate())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        protected virtual void CloseCancelForm()
        {
        }

        public DXValidationProvider ValidationProvider { get { return dxValidationProvider; } }

        protected virtual void CreateNewObject()
        {
        }

        protected virtual void InitData()
        {
        }

        protected virtual void InitValidation()
        {
        }

        protected virtual void SaveData()
        {
        }

        protected virtual void LoadFormLayout()
        {
            if (LayoutManager == null) return;
            LayoutManager.RestoreFormLayout(new FormLayoutInfo(this, lcMain));
        }

        protected virtual void SaveFormLayout()
        {
            if (LayoutManager == null) return;
            LayoutManager.SaveFormLayout(new FormLayoutInfo(this, lcMain));
        }
    }
}