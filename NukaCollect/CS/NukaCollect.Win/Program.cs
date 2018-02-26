using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.Xpo;
using NukaCollect.Win.Forms;
using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace NukaCollect.Win
{
    internal static class Program
    {
        private const string iniFilePath = "NukaCollect.ini";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(string[] arguments)
        {
            //����
            DevExpress.Utils.LocalizationHelper.SetCurrentCulture(arguments);
            CultureInfo videoRentCI = (CultureInfo)Application.CurrentCulture.Clone();
            //Ǯ�ҷ���
            videoRentCI.NumberFormat.CurrencySymbol = "��";
            //С����λ��
            videoRentCI.NumberFormat.CurrencyDecimalDigits = 2;
            Application.CurrentCulture = videoRentCI;
            BonusSkins.Register();
            //����
            DevExpress.Skins.SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IniFile iniFile = new IniFile();
            if (File.Exists(iniFilePath)) iniFile.Load(iniFilePath);
            InitialDbCreator initialDbCreator = new InitialDbCreator(new CreateInitialDbDialog(), new ExceptionsProcesser(null));
            if (initialDbCreator.OpenDb(iniFile))
            {
                iniFile.Save(iniFilePath);
                UserLookAndFeel.Default.SetSkinStyle(iniFile.Get<string>("[]SkinStyle"));
                VideoRentCurrentUser.Login(XpoDefault.Session, ReferenceData.AdministratorString); //TODO Create Login-Dialog
                Application.Run(new frmMain());
            }
        }
    }
}