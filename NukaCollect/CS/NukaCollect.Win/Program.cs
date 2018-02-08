using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using NukaCollect.Win.Forms;
using System.IO;
using System.Globalization;
using DevExpress.LookAndFeel;
using DevExpress.Skins;

namespace NukaCollect.Win {
    static class Program {
        const string iniFilePath = "NukaCollect.ini";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] arguments) {
            //语言
            DevExpress.Utils.LocalizationHelper.SetCurrentCulture(arguments);
            CultureInfo videoRentCI = (CultureInfo)Application.CurrentCulture.Clone();
            //钱币符号
            videoRentCI.NumberFormat.CurrencySymbol = "￥";
            //小数点位数
            videoRentCI.NumberFormat.CurrencyDecimalDigits = 2;
            Application.CurrentCulture = videoRentCI;
            BonusSkins.Register();
            //主题
            DevExpress.Skins.SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IniFile iniFile = new IniFile();
            if(File.Exists(iniFilePath)) iniFile.Load(iniFilePath);
            InitialDbCreator initialDbCreator = new InitialDbCreator(new CreateInitialDbDialog(), new ExceptionsProcesser(null));
            if(initialDbCreator.OpenDb(iniFile)) {
                iniFile.Save(iniFilePath);
                VideoRentCurrentUser.Login(XpoDefault.Session, ReferenceData.AdministratorString); //TODO Create Login-Dialog
                Application.Run(new frmMain());
            }
        }
    }
}
