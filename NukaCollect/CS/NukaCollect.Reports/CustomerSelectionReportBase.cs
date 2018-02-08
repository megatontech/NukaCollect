using DevExpress.XtraEditors;
using DevExpress.XtraReports.Parameters;
using System;

namespace NukaCollect.Reports
{
    public partial class CustomerSelectionReportBase : ReportBase
    {
        private const string customerListParameterName = "customerListParameter";
        private const char separatorChar = ';';
        private string separatorString = new string(new char[] { separatorChar, ' ' });
        private bool isParameterInitialized = false;

        public CustomerSelectionReportBase()
        {
            InitializeComponent();
            Parameter customerListParameter = new Parameter();
            customerListParameter.Name = customerListParameterName;
            customerListParameter.Type = typeof(string);
            customerListParameter.Description = Properties.Resources.CustomersCaption;
            Parameters.Add(customerListParameter);
        }

        protected override void OnParametersRequestBeforeShow(ParametersRequestEventArgs e)
        {
            base.OnParametersRequestBeforeShow(e);

            foreach (ParameterInfo info in e.ParametersInformation)
            {
                if (info.Parameter.Name == customerListParameterName)
                {
                    info.Editor = CreateCheckedComboBoxEdit();
                }
            }
            if (!isParameterInitialized && xpCollectionCustomers.Session != null)
            {
                const int customerLimit = 5;
                bool isFirstIteration = true;
                int customerCount = 0;
                string customers = string.Empty;
                foreach (Customer customer in xpCollectionCustomers)
                {
                    if (!isFirstIteration)
                        customers += separatorString;
                    else
                        isFirstIteration = false;
                    customers += customer.FullNameLastSorting;
                    if (this is CustomerFilmRentsListReport)
                        if (++customerCount == customerLimit)
                            break;
                }
                Parameters[customerListParameterName].Value = customers;
                isParameterInitialized = true;
                FilterString = GetFilterString();
            }
        }

        private CheckedComboBoxEdit CreateCheckedComboBoxEdit()
        {
            CheckedComboBoxEdit checkedComboBoxEdit = new CheckedComboBoxEdit();
            checkedComboBoxEdit.Properties.DataSource = xpCollectionCustomers;
            checkedComboBoxEdit.Properties.DisplayMember = "FullNameLastSorting";
            checkedComboBoxEdit.Properties.SeparatorChar = separatorChar;
            if (checkedComboBoxEdit.Properties.PopupControl == null)
            {
                System.Reflection.MethodInfo metodInfo = typeof(CheckedComboBoxEdit).GetMethod("CreatePopupCheckListControl", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                checkedComboBoxEdit.Properties.PopupControl = metodInfo.Invoke(checkedComboBoxEdit, null) as PopupContainerControl;
            }
            checkedComboBoxEdit.Properties.PopupFormMinSize = new System.Drawing.Size(180, 390);
            checkedComboBoxEdit.Properties.PopupFormSize = checkedComboBoxEdit.Properties.PopupFormMinSize;
            return checkedComboBoxEdit;
        }

        protected override void OnParametersRequestSubmit(ParametersRequestEventArgs e)
        {
            base.OnParametersRequestSubmit(e);

            CheckedComboBoxEdit editor = FindEditor(customerListParameterName);
            if (AreAllItemsChecked(editor))
            {
                FilterString = String.Empty;
                return;
            }
            FilterString = GetFilterString();
        }

        private CheckedComboBoxEdit FindEditor(string parameterName)
        {
            ParameterInfo info = ReportPrintTool.ParametersInfo.Find(delegate (ParameterInfo parameterInfo) { return parameterInfo.Parameter.Name == parameterName; });
            CheckedComboBoxEdit editor = (CheckedComboBoxEdit)info.Editor;
            return editor;
        }

        private string GetFilterString()
        {
            string value = Parameters[customerListParameterName].Value as String;
            if (string.IsNullOrEmpty(value))
            {
                return String.Empty;
            }
            string[] values = value.Split(new string[] { separatorString }, StringSplitOptions.None);
            if (values == null || values.Length == 0)
            {
                return String.Empty;
            }
            bool isFirstIteration = true;
            string filterBuffer = string.Empty;
            foreach (string name in values)
            {
                if (!isFirstIteration)
                {
                    filterBuffer += " Or ";
                }
                string result = name.Replace("'", "''");
                filterBuffer += String.Format("[FullNameLastSorting] = '{0}'", result);
                isFirstIteration = false;
            }
            return filterBuffer;
        }

        private bool AreAllItemsChecked(CheckedComboBoxEdit editor)
        {
            if (editor.Properties.Items.Count == 0)
                return false;
            foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem item in editor.Properties.Items)
            {
                if (item.CheckState == System.Windows.Forms.CheckState.Unchecked)
                {
                    return false;
                }
            }
            return true;
        }

        private void xpCollectionCustomers_ResolveSession(object sender, DevExpress.Xpo.ResolveSessionEventArgs e)
        {
            e.Session = Session;
        }
    }
}