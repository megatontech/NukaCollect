using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
using NukaCollect.Resources;
using System;
using System.Windows.Forms;

namespace NukaCollect.Win.Modules
{
    public partial class CustomerDetail : DetailBase
    {
        public CustomerDetail(Form parent, GetSessionCallback session, Customer customer, IDXMenuManager manager, CloseDetailForm closeForm)
            : base(parent, session, customer, manager, closeForm)
        {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForCustomerDetail(this);
            beEmail.Properties.Buttons[0].Caption = ConstStrings.Get("SendEmail");
            beEmail.Properties.Buttons[0].ToolTip = ConstStrings.Get("SendEmail");
            Text = customer != null ? customer.FullName : ConstStrings.Get("NewCustomer");
        }

        protected override string HomeButtonCaption { get { return ConstStrings.Get("CustomerList"); } }
        public Customer Customer { get { return editObject as Customer; } }

        protected override void InitData()
        {
            base.InitData();
            InitEditors();
            if (Customer == null) return;
            teFirstName.Text = Customer.FirstName;
            teLastName.Text = Customer.LastName;
            teMiddleName.Text = Customer.MiddleName;
            icbGender.EditValue = Customer.Gender;
            if (Customer.BirthDate != null) deBirthDate.DateTime = Customer.BirthDate.Value;
            tePhone.Text = Customer.Phone;
            beEmail.Text = Customer.Email;
            meAddress.Text = Customer.Address;
            meComments.Text = Customer.Comments;
            pePhoto.Image = Customer.Photo;
            icbDiscountLevel.EditValue = Customer.DiscountLevel;
            teDiscount.EditValue = Customer.Discount;
            ucPictureEditBar1.Init(pePhoto, LayoutManager);
        }

        protected override void InitValidation()
        {
            ValidationProvider.SetValidationRule(teFirstName, ValidationRulesHelper.RuleIsNotBlank);
            ValidationProvider.SetValidationRule(teLastName, ValidationRulesHelper.RuleIsNotBlank);
        }

        private void InitEditors()
        {
            EditorHelper.CreateGenderImageComboBox(icbGender.Properties, null);
            EditorHelper.CreateDiscountLevelImageComboBox(icbDiscountLevel.Properties, null);
            EditorHelper.CreateDiscountTextEdit(teDiscount.Properties);
            pePhoto.Properties.NullText = ConstStrings.Get("NoImageData");
            npDiscount.Text = ConstStrings.Get("DiscountNote");
        }

        protected override void UpdateReadOnlyData()
        {
            base.UpdateReadOnlyData();
            lciBar.Visibility = ReadOnly ? DevExpress.XtraLayout.Utils.LayoutVisibility.Never : DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
        }

        protected override void SaveData()
        {
            base.SaveData();
            Customer.FirstName = teFirstName.Text;
            Customer.LastName = teLastName.Text;
            Customer.MiddleName = teMiddleName.Text;
            Customer.Gender = (PersonGender)icbGender.EditValue;
            Customer.BirthDate = deBirthDate.DateTime;
            if (Customer.BirthDate == DateTime.MinValue) Customer.BirthDate = null;
            Customer.Phone = tePhone.Text;
            Customer.Email = beEmail.Text;
            Customer.Address = meAddress.Text;
            Customer.Comments = meComments.Text;
            Customer.Photo = pePhoto.Image;
            CommitSession();
        }

        protected override VideoRentBaseObject CreateNewObject()
        {
            base.CreateNewObject();
            return new Customer(Session);
        }

        private void beEmail_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(string.Format("MailTo:{0}", beEmail.Text));
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, ConstStrings.Get("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void beEmail_TextChanged(object sender, EventArgs e)
        {
            beEmail.Properties.Buttons[0].Enabled = !string.IsNullOrEmpty(beEmail.Text.Trim());
        }

        protected internal override void LoadPicture()
        {
            base.LoadPicture();
            ucPictureEditBar1.LoadPicture();
        }

        protected internal override void ClearPicture()
        {
            base.ClearPicture();
            ucPictureEditBar1.ClearPicture();
        }
    }
}