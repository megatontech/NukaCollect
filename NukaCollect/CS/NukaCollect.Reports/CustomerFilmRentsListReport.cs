using System;
using DevExpress.Xpo;
using DevExpress.XtraReports.Parameters;
using System.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraReports.UI;

namespace NukaCollect.Reports {
    public enum ShowMode { FullHistory, NotReturnedRents, ExpiredRents }
    public partial class CustomerFilmRentsListReport : CustomerSelectionReportBase {
        const string parameterName = "showModeParameter";

        public CustomerFilmRentsListReport() {
            InitializeComponent();
            DisplayName = Properties.Resources.FilmRentsReport;
            Parameters[parameterName].Type = typeof(ShowMode);
            ParametersRequestBeforeShow += CustomerFilmRentsListReport_ParametersRequestBeforeShow;
            showModeParameter.Description = Properties.Resources.DetailsCaption;
        }

        void CustomerFilmRentsListReport_ParametersRequestBeforeShow(object sender, ParametersRequestEventArgs e) {
            foreach(ParameterInfo info in e.ParametersInformation) {
                if(info.Parameter.Name == parameterName) {
                    info.Editor = CreateShowModeEditor(new ShowMode[] { ShowMode.FullHistory, ShowMode.NotReturnedRents, ShowMode.ExpiredRents }, new string[] { "Complete History", "Non-Returned Rentals Only", "Expired Rentals Only" });
                }
            }
        }
        ImageComboBoxEdit CreateShowModeEditor(Array values, string[] names) {
            ImageComboBoxEdit result = new ImageComboBoxEdit();
            for(int i = 0; i < values.Length && i < names.Length; i++) {
                result.Properties.Items.Add(new ImageComboBoxItem(names[i], values.GetValue(i)));
            }
            return result;
        }
        protected override void OnParametersRequestSubmit(ParametersRequestEventArgs e) {
            base.OnParametersRequestSubmit(e);

            int currentShowingVariant = (int)Parameters[parameterName].Value;
            switch(currentShowingVariant) {
                case (0): {
                        DetailReportRents.FilterString = string.Empty;
                        break;
                    }
                case (1): {
                        DetailReportRents.FilterString = String.Format("[Active] = {0}", bool.TrueString);
                        break;
                    }
                case (2): {
                        DetailReportRents.FilterString = String.Format("[IsOverdue] = {0}", bool.TrueString);
                        break;
                    }
                default: {
                        throw new Exception("Invalid 'switch' branch.");
                    }
            }
        }
        void xpCollectionCustomers_ResolveSession(object sender, ResolveSessionEventArgs e) {
            e.Session = Session;
        }
        void xrPictureBoxCustomerPhoto_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            XRPictureBox photo = sender as XRPictureBox;
            if(photo.Image == null) {
                photo.Image = ReferenceImages.UnknownPerson;
            }
        }
        void xrPictureBoxPhoto_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            XRPictureBox photo = sender as XRPictureBox;
            if(photo.Image == null) {
                photo.Image = ReferenceImages.UnknownMovie;
            }
        }
        void xrTableCellReturnedOn_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            XRTableCell xrTblClReturnedOn = sender as XRTableCell;
            if(string.IsNullOrEmpty(xrTblClReturnedOn.Text)) {
                xrTblClReturnedOn.Text = "Not yet returned.";
            }
        }
    }
}
