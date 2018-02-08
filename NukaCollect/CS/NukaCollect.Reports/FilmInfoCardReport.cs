using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using System;

namespace NukaCollect.Reports
{
    public partial class FilmInfoCardReport : ReportBase
    {
        private const string filmListParameterName = "filmListParameter";
        private const char separatorChar = ';';
        private string separatorString = new string(new char[] { separatorChar, ' ' });
        private bool isParameterInitialized = false;

        public FilmInfoCardReport()
        {
            InitializeComponent();
            DisplayName = Properties.Resources.FilmCardsReport;
            Parameter filmListParameter = new Parameter();
            filmListParameter.Name = filmListParameterName;
            filmListParameter.Type = typeof(string);
            filmListParameter.Description = Properties.Resources.MoviesCaption;
            this.Parameters.Add(filmListParameter);
        }

        protected override void OnParametersRequestBeforeShow(ParametersRequestEventArgs e)
        {
            base.OnParametersRequestBeforeShow(e);

            foreach (ParameterInfo info in e.ParametersInformation)
            {
                if (info.Parameter.Name == filmListParameterName)
                {
                    info.Editor = CreateCheckedComboBoxEdit();
                }
            }
            if (!isParameterInitialized && xpCollectionMovies.Session != null)
            {
                const int filmLimit = 5;
                bool isFirstIteration = true;
                string films = string.Empty;
                for (int filmIndex = 0; filmIndex < filmLimit; filmIndex++)
                {
                    if (!isFirstIteration)
                        films += separatorString;
                    else
                        isFirstIteration = false;
                    films += ((Movie)xpCollectionMovies[filmIndex]).Title;
                }
                Parameters[filmListParameterName].Value = films;
                isParameterInitialized = true;
                FilterString = GetFilterString();
            }
        }

        private CheckedComboBoxEdit CreateCheckedComboBoxEdit()
        {
            CheckedComboBoxEdit checkedComboBoxEdit = new CheckedComboBoxEdit();
            checkedComboBoxEdit.Properties.DataSource = xpCollectionMovies;
            checkedComboBoxEdit.Properties.DisplayMember = "Title";
            checkedComboBoxEdit.Properties.SeparatorChar = separatorChar;
            if (checkedComboBoxEdit.Properties.PopupControl == null)
            {
                System.Reflection.MethodInfo metodInfo = typeof(CheckedComboBoxEdit).GetMethod("CreatePopupCheckListControl", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                checkedComboBoxEdit.Properties.PopupControl = metodInfo.Invoke(checkedComboBoxEdit, null) as PopupContainerControl;
            }
            checkedComboBoxEdit.Properties.PopupFormMinSize = new System.Drawing.Size(220, 390);
            checkedComboBoxEdit.Properties.PopupFormSize = checkedComboBoxEdit.Properties.PopupFormMinSize;
            return checkedComboBoxEdit;
        }

        protected override void OnParametersRequestSubmit(ParametersRequestEventArgs e)
        {
            base.OnParametersRequestSubmit(e);

            CheckedComboBoxEdit editor = FindEditor(filmListParameterName);
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
            string value = Parameters[filmListParameterName].Value as String;
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
                filterBuffer += String.Format("[Movie.Title] = '{0}'", result);
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

        private void xrBarCode2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRBarCode barCode = sender as XRBarCode;
            MovieItem movieItem = GetCurrentRow() as MovieItem;
            barCode.Text = string.Format("{0:d6}", movieItem.MovieItemId);
        }

        private void xpCollectionMovieItems_ResolveSession(object sender, ResolveSessionEventArgs e)
        {
            e.Session = Session;
        }

        private void xpCollectionMovies_ResolveSession(object sender, ResolveSessionEventArgs e)
        {
            e.Session = Session;
        }
    }
}