using System;
using DevExpress.XtraEditors;
using System.Data;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;
using System.Collections.Generic;
using DevExpress.XtraReports.Extensions;
using DevExpress.Utils.Design;
using System.ComponentModel;

namespace NukaCollect.Reports {
    public enum TimePeriod { Custom, Month, ThreeMonths, SixMonths, Year, TwoYears, FiveYears, TenYears }
    public partial class TimePeriodReportBase : ReportBase {
        #region inner classes
        class DateTimeCorrector {
            int months;
            int years;

            public DateTimeCorrector(int months, int years) {
                this.months = months;
                this.years = years;
            }

            public bool IsEmpty { get { return months == 0 && years == 0; } }

            public DateTime Correct(DateTime time) {
                return time.AddMonths(months).AddYears(years);
            }
        }
        class TimePeriodDesignExtention : ReportDesignExtension {
            public override void AddParameterTypes(IDictionary<Type, string> dictionary) {
                dictionary.Add(typeof(TimePeriod), "TimePeriod");
            }
        }
        class TimePeriodParametersExtention : ParametersRequestExtension {
            bool canUpdateEditors = true;

            static EditParameterInfo FindParameterInfo(IList<EditParameterInfo> parametersInfo, string name) {
                return new List<EditParameterInfo>(parametersInfo).Find(delegate(EditParameterInfo item) { return item.Parameter.Name == name; });
            }
            static BaseEdit FindEditor(IList<EditParameterInfo> parametersInfo, string name) {
                EditParameterInfo info = FindParameterInfo(parametersInfo, name);
                return info != null ? info.Editor : null;
            }
            protected override void OnBeforeShow(IList<EditParameterInfo> parametersInfo, XtraReport report) {
                EditParameterInfo info = FindParameterInfo(parametersInfo, periodParamName);
                if(info == null)
                    return;
                info.Editor = CreatePeriodEditor(new TimePeriod[] { TimePeriod.Custom, TimePeriod.Month, TimePeriod.ThreeMonths, TimePeriod.SixMonths, TimePeriod.Year, TimePeriod.TwoYears, TimePeriod.FiveYears, TimePeriod.TenYears },
                    new string[] { Properties.Resources.PeriodCustom, Properties.Resources.PeriodMonth, Properties.Resources.PeriodThreeMonths, Properties.Resources.PeriodSixMonths, Properties.Resources.PeriodYear, Properties.Resources.PeriodTwoYears, Properties.Resources.PeriodFiveYears, Properties.Resources.PeriodTenYears });
                TimePeriod timePeriod = (TimePeriod)info.Parameter.Value;
                if(timePeriod != TimePeriod.Custom) {
                    DateTimeCorrector corrector = CreateCorrector(timePeriod);
                    DateTime endTime = DateTime.Now;
                    FindParameterInfo(parametersInfo, startDateParamName).Parameter.Value = (object)corrector.Correct(endTime);
                    FindParameterInfo(parametersInfo, endDateParamName).Parameter.Value = (object)endTime;
                }
                DateEdit startDateEdit = (DateEdit)FindEditor(parametersInfo, startDateParamName);
                startDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
                DateEdit endDateEdit = (DateEdit)FindEditor(parametersInfo, endDateParamName);
                endDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            }
            static BaseEdit CreatePeriodEditor(Array values, string[] names) {
                ImageComboBoxEdit result = new ImageComboBoxEdit();
                for(int i = 0; i < values.Length && i < names.Length; i++) {
                    result.Properties.Items.Add(new ImageComboBoxItem(names[i], values.GetValue(i)));
                }
                result.Properties.PopupFormMinSize = new System.Drawing.Size(result.Properties.PopupFormMinSize.Width, result.Properties.PopupFormMinSize.Height + 135);
                return result;
            }
            protected override void OnEditorValueChanged(IList<EditParameterInfo> parametersInfo, EditParameterInfo changedInstance, XtraReport report) {
                switch(changedInstance.Parameter.Name) {
                    case periodParamName:
                        OnPeriodEditValueChanged(parametersInfo);
                        break;
                    case startDateParamName:
                        OnStartDateDateEditValueChanged(parametersInfo);
                        break;
                    case endDateParamName:
                        OnEndDateEditValueChanged(parametersInfo);
                        break;
                    default:
                        throw new Exception("Invalid switch's branch.");
                }
            }
            void OnStartDateDateEditValueChanged(IList<EditParameterInfo> parametersInfo) {
                if(!canUpdateEditors)
                    return;
                DateEdit edit = (DateEdit)FindEditor(parametersInfo, startDateParamName);
                if(edit == null) {
                    return;
                }
                edit.DoValidate();
                SetValue(FindEditor(parametersInfo, periodParamName), TimePeriod.Custom);
            }
            void OnEndDateEditValueChanged(IList<EditParameterInfo> parametersInfo) {
                if(!canUpdateEditors)
                    return;
                DateEdit edit = (DateEdit)FindEditor(parametersInfo, endDateParamName);
                if(edit == null) {
                    return;
                }
                edit.DoValidate();
                SetValue(FindEditor(parametersInfo, periodParamName), TimePeriod.Custom);
            }
            void OnPeriodEditValueChanged(IList<EditParameterInfo> parametersInfo) {
                if(!canUpdateEditors)
                    return;
                BaseEdit edit = FindEditor(parametersInfo, periodParamName);
                if(edit == null) {
                    return;
                }
                edit.DoValidate();
                DateTimeCorrector corrector = CreateCorrector((TimePeriod)edit.EditValue);
                if(corrector == null || corrector.IsEmpty)
                    return;
                DateTime endTime = DateTime.Now;
                SetValue(FindEditor(parametersInfo, startDateParamName), corrector.Correct(endTime));
                SetValue(FindEditor(parametersInfo, endDateParamName), endTime);
            }
            void SetValue(BaseEdit editor, object value) {
                canUpdateEditors = false;
                try {
                    if(editor != null) {
                        editor.EditValue = value;
                        editor.IsModified = true;
                        editor.DoValidate();
                    }
                } finally {
                    canUpdateEditors = true;
                }
            }
        }
        #endregion
        
        protected const string startDateParamName = "paramStartDate";
        protected const string endDateParamName = "paramEndDate";
        protected const string periodParamName = "paramPeriod";
        static TimePeriod defaultTimePeriod = TimePeriod.ThreeMonths;

        static TimePeriodReportBase() {
            ParametersRequestExtension.RegisterExtension(new TimePeriodParametersExtention(), "TimePeriodReport");
            ReportDesignExtension.RegisterExtension(new TimePeriodDesignExtention(), "TimePeriodReport");
        }
        static DateTimeCorrector CreateCorrector(TimePeriod timePeriod) {
            switch(timePeriod) {
                case TimePeriod.Month:
                    return new DateTimeCorrector(-1, 0);
                case TimePeriod.ThreeMonths:
                    return new DateTimeCorrector(-3, 0);
                case TimePeriod.SixMonths:
                    return new DateTimeCorrector(-6, 0);
                case TimePeriod.Year:
                    return new DateTimeCorrector(0, -1);
                case TimePeriod.TwoYears:
                    return new DateTimeCorrector(0, -2);
                case TimePeriod.FiveYears:
                    return new DateTimeCorrector(0, -5);
                case TimePeriod.TenYears:
                    return new DateTimeCorrector(0, -10);
                default:
                    return new DateTimeCorrector(0, 0);
            }
        }

        public TimePeriodReportBase() {
            InitializeComponent();
            ParametersRequestExtension.AssociateReportWithExtension(this, "TimePeriodReport");
            ReportDesignExtension.AssociateReportWithExtension(this, "TimePeriodReport");

            Parameter startDateParameter = CreateParameter(startDateParamName, typeof(DateTime), Properties.Resources.StartDateCaption, CreateCorrector(defaultTimePeriod).Correct(DateTime.Now));
            Parameter endDateParameter = CreateParameter(endDateParamName, typeof(DateTime), Properties.Resources.EndDateCaption, DateTime.Now);
            Parameter periodParameter = CreateParameter(periodParamName, typeof(TimePeriod), Properties.Resources.LastTimeCaption, defaultTimePeriod);
            this.Parameters.AddRange(new Parameter[] { startDateParameter, endDateParameter, periodParameter });
        }
        Parameter CreateParameter(string name, Type type, string description, object value) {
            Parameter parameter = new Parameter();
            parameter.Name = name;
            parameter.Type = type;
            parameter.Description = description;
            parameter.Value = value;
            return parameter;
        }
    }
}
