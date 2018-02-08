using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.IO;
using Microsoft.Win32;
using DevExpress.Internal;
using System.ComponentModel;
using System.Security;
using System.Text.RegularExpressions;
using System.Linq;
#if !SL
using System.Data.Common;
using System.Data.EntityClient;
#endif

namespace DevExpress.DemoData.Helpers {
    public static class StartApplicationHelper {
        static EscapeHelper urlHelper;

        static StartApplicationHelper() {
            urlHelper = new EscapeHelper();
            UrlHelper.AddPair(":", "/p");
            UrlHelper.AddPair(" ", "_");
            UrlHelper.AddPair("_", "/_");
            UrlHelper.AddPair("\\", "/-");
            UrlHelper.AddPair("+", "/*");
            UrlHelper.AddPair("/", "//");
        }

        public static EscapeHelper UrlHelper { get { return urlHelper; } }
#if !SL
        static string commonDocuments;

        public static string GetDemoFullPath(string demoName) {
            return Path.Combine(DemosPath, demoName.TrimStart('/', '\\'));
        }
        public static string CommonDocuments {
            get {
                if(commonDocuments == null) {
                    try {
                        commonDocuments = WinApiHelper.GetFolderPath(WinApiHelper.SpecialFolderType.CommonDocuments);
                    } catch { }
                    if(commonDocuments == null)
                        commonDocuments = "C:\\Users\\Public\\Documents";
                }
                return commonDocuments;
            }
        }
        public static string DemosPath {
            get { return Path.Combine(CommonDocuments, string.Format("DevExpress Demos {0}\\Components", AssemblyInfo.VersionShort)); }
        }
        public static string Start(string fileName, string[] arguments, bool isUrl) {
            string workingDirectory = null;
            if(!isUrl) {
                fileName = string.IsNullOrEmpty(fileName) ? string.Empty : StartApplicationHelper.GetDemoFullPath(fileName);
                if(string.IsNullOrEmpty(fileName) || !File.Exists(fileName) && !Directory.Exists(fileName))
                    return string.Format("File {0} is not found.", fileName);
                workingDirectory = Path.GetDirectoryName(fileName);
            }
            string argumentsString = JoinArguments(arguments);
            string error = string.Empty;
            try {
                StartCore(fileName, workingDirectory, argumentsString);
            } catch(Exception e) {
                error = e.Message;
            }
            return error;
        }
        static void StartCore(string fileName, string workingDirectory, string argumentsString) {
            if(!fileName.EndsWith(".sln", StringComparison.OrdinalIgnoreCase)) {
                DoStart(fileName, workingDirectory, argumentsString);
                return;
            }
            if(StartWithRegistryInfo(fileName, workingDirectory, argumentsString)) return;
            if(StartWithVSPath(fileName, workingDirectory, argumentsString)) return;
            DoStart(fileName, workingDirectory, argumentsString);
        }

        static bool StartWithRegistryInfo(string fileName, string workingDirectory, string argumentsString) {
            try {
                string slnApp = Registry.GetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FileExts\\.sln\\UserChoice", "ProgId", "") as string;
                if(string.IsNullOrEmpty(slnApp)) {
                    RegistryKey openWithProgids = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FileExts\\.sln\\OpenWithProgids");
                    if(openWithProgids == null) return false;
                    if(openWithProgids.ValueCount != 1) return false;
                    slnApp = openWithProgids.GetValueNames()[0] as string;
                }
                string vsPath = Registry.GetValue("HKEY_CLASSES_ROOT\\" + slnApp + "\\shell\\Open\\command", null, "") as string;
                const string vsVersionSelector = "VSLauncher.exe";
                if(vsPath.IndexOf(vsVersionSelector, 0) != (-1)) return false;
                if(string.IsNullOrEmpty(vsPath)) return false;
                argumentsString = string.Format("\"{0}\"", fileName);
                fileName = vsPath.Replace("\"%1\"", "").Replace("\"", "");
                DoStart(fileName, workingDirectory, argumentsString);
                return true;
            } catch {
                return false;
            }
        }
        static bool StartWithVSPath(string fileName, string workingDirectory, string argumentsString) {
            try {
                VSSolutionFile slnFile = new VSSolutionFile(fileName);
                string vsPath = VSInstallHelper.GetVSPath(slnFile.Version);
                if(string.IsNullOrEmpty(vsPath)) return false;
                fileName = vsPath;
                argumentsString = string.Format("\"{0}\"", slnFile.Path);
                DoStart(fileName, workingDirectory, argumentsString);
                return true;
            } catch {
                return false;
            }
        }
        static void DoStart(string fileName, string workingDirectory, string argumentsString) {
            ProcessStartInfo psi = new ProcessStartInfo(fileName);
            psi.WorkingDirectory = workingDirectory ?? AppDomain.CurrentDomain.BaseDirectory;
            psi.Arguments = argumentsString;
            WinApiHelper.WaitForWindowAppears(Process.Start(psi));
        }
        static string JoinArguments(string[] arguments) {
            if(arguments == null) return string.Empty;
            StringBuilder s = new StringBuilder();
            foreach(string argument in arguments) {
                if(string.IsNullOrEmpty(argument)) continue;
                if(s.Length != 0)
                    s.Append(' ');
                s.Append(argument);
            }
            return s.ToString();
        }
        class WinApiHelper {
            [SecuritySafeCritical]
            public static void WaitForWindowAppears(Process process) {
                if(process == null) return;
                IntPtr[] handles = new IntPtr[] { process.Handle };
                try {
                    while(true) {
                        process.Refresh();
                        Import.MsgWaitForMultipleObjects((uint)handles.Length, handles, true, 250, 0xff);
                        if(!process.MainWindowHandle.Equals(IntPtr.Zero)) {
                            Import.SwitchToThisWindow(process.MainWindowHandle, true);
                            return;
                        }
                    }
                } catch(Exception) { }
            }
            public enum SpecialFolderType {
                CommonDocuments = Import.SpecialFolderType.CommonDocuments
            }
            [SecuritySafeCritical]
            public static string GetFolderPath(SpecialFolderType folderType) {
                StringBuilder path = new StringBuilder(Import.MAX_PATH);
                int result = Import.SHGetFolderPath(IntPtr.Zero, (int)folderType, IntPtr.Zero, 0, path);
                if(result != 0)
                    throw new Win32Exception(result);
                return path.ToString();
            }
            class Import {
                [DllImport("user32.dll")]
                public static extern uint MsgWaitForMultipleObjects(uint nCount, IntPtr[] pHandles, bool bWaitAll, uint dwMilliseconds, uint dwWakeMask);
                [DllImport("user32.dll", SetLastError = true)]
                public static extern void SwitchToThisWindow(IntPtr hwind, bool fAltTab);
                public const int MAX_PATH = 260;
                [DllImport("shell32.dll")]
                public static extern int SHGetFolderPath(IntPtr hwndOwner, int nFolder, IntPtr hToken, uint dwFlags, [Out] StringBuilder pszPath);
                public enum SpecialFolderType {
                    AdministrativeTools = 0x0030,
                    CommonAdministrativeTools = 0x002f,
                    ApplicationData = 0x001a,
                    CommonAppData = 0x0023,
                    CommonDocuments = 0x002e,
                    Cookies = 0x0021,
                    CreateFlag = 0x8000,
                    History = 0x0022,
                    InternetCache = 0x0020,
                    LocalApplicationData = 0x001c,
                    MyPictures = 0x0027,
                    Personal = 0x0005,
                    ProgramFiles = 0x0026,
                    CommonProgramFiles = 0x002b,
                    System = 0x0025,
                    Windows = 0x0024,
                    Fonts = 0x0014
                }
            }
        }
        enum VSVersion { VS2010, VS2012, Other }
        class VSInstallHelper {
            static string vs2010Path;
            static string vs2012Path;

            public static string GetVSPath(VSVersion version) {
                if(version == VSVersion.Other) return null;
                string vsPath;
                if(version == VSVersion.VS2010) {
                    vsPath = GetVS2010Path();
                    if(!string.IsNullOrEmpty(vsPath)) return vsPath;
                }
                return GetVS2012Path();
            }
            static string GetVS2010Path() {
                if(vs2010Path == null)
                    vs2010Path = GetVSPathCore("10.0");
                return vs2010Path;
            }
            static string GetVS2012Path() {
                if(vs2012Path == null)
                    vs2012Path = GetVSPathCore("11.0");
                return vs2012Path;
            }
            static string GetVSPathCore(string version) {
                try {
                    // replaced "path ?? string.Empty" to workaround InstantVB's bug
                    string path = RegistryViewer.Current.GetSzValue(RegistryHive.LocalMachine, string.Format("SOFTWARE/Microsoft/VisualStudio/{0}/Setup/VS", version), "EnvironmentPath");
                    if (path == null)
                        return string.Empty;
                    return path;
                } catch {
                    return string.Empty;
                }
            }
        }
        class VSSolutionFile {
            VSVersion? version;

            public VSSolutionFile(string path) {
                Path = path;
            }
            public string Path { get; private set; }
            public VSVersion Version {
                get {
                    if(version == null)
                        version = GetVersion();
                    return version.Value;
                }
            }
            VSVersion GetVersion() {
                string[] text = File.ReadAllLines(Path);
                string versionString = text.Select(t => GetVersionInLine(t)).Where(v => v != null).FirstOrDefault();
                return versionString == "12.00" ? VSVersion.VS2012 : versionString == "11.00" ? VSVersion.VS2010 : VSVersion.Other;
            }
            string GetVersionInLine(string line) {
                Match match = Regex.Match(line, "Microsoft Visual Studio Solution File, Format Version (?<version>.*)");
                return !match.Success ? null : match.Groups["version"].Value;
            }
        }
#endif
    }
    public class EscapeHelper {
        List<Dictionary<string, string>> replaces = new List<Dictionary<string, string>>();
        List<Dictionary<string, string>> inverts = new List<Dictionary<string, string>>();

        public void AddPair(string original, string escaped) {
            AddReplace(original, escaped, replaces);
            AddReplace(escaped, original, inverts);
        }
        public string Screen(string s) {
            return Replace(s, replaces);
        }
        public string Unscreen(string s) {
            return Replace(s, inverts);
        }
        static void AddReplace(string from, string to, List<Dictionary<string, string>> replaces) {
            Dictionary<string, string> replace = GetDictionary(replaces, from.Length - 1);
            replace.Add(from, to);
        }
        static string Replace(string s, List<Dictionary<string, string>> replaces) {
            StringBuilder result = new StringBuilder();
            for(int i = 0; i < s.Length; ++i) {
                int originalLength_1 = -1;
                string escaped = null;
                for(int length_1 = replaces.Count - 1; length_1 >= 0; --length_1) {
                    if(i + length_1 + 1 > s.Length) continue;
                    Dictionary<string, string> dictionary = GetDictionary(replaces, length_1);
                    string t = s.Substring(i, length_1 + 1);
                    string r = null;
                    if(dictionary.TryGetValue(t, out r)) {
                        originalLength_1 = length_1;
                        escaped = r;
                        break;
                    }
                }
                if(originalLength_1 >= 0) {
                    result.Append(escaped);
                    i += originalLength_1;
                } else {
                    result.Append(s[i]);
                }
            }
            return result.ToString();
        }
        static Dictionary<string, string> GetDictionary(List<Dictionary<string, string>> list, int i) {
            lock(list) {
                int listCount = list.Count;
                if(i < listCount) return list[i];
                for(int k = 0; k < i - listCount + 1; ++k) {
                    list.Add(new Dictionary<string, string>());
                }
                return list[i];
            }
        }
    }
    public abstract class DisposableBase : IDisposable {
        bool disposed = false;

        ~DisposableBase() { Dispose(false); }
        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public bool Disposed { get { return disposed; } }
        public event EventHandler AfterDispose;
        protected virtual void DisposeManaged() { }
        protected virtual void DisposeUnmanaged() { }
        void Dispose(bool disposing) {
            if(Disposed) return;
            disposed = true;
            if(disposing)
                DisposeManaged();
            DisposeUnmanaged();
            RaiseAfterDispose();
        }
        void RaiseAfterDispose() {
            if(AfterDispose != null)
                AfterDispose(this, EventArgs.Empty);
            AfterDispose = null;
        }
    }
    public abstract class RegistryViewerBase {
        public abstract bool IsKeyExists(RegistryHive hive, string key);
        public abstract string[] GetMultiSzValue(RegistryHive hive, string key, string name);
        public abstract string GetSzValue(RegistryHive hive, string key, string name);
    }
#if SL
    public enum RegistryHive {
        ClassesRoot = -2147483648,
        CurrentUser = -2147483647,
        LocalMachine = -2147483646,
        Users = -2147483645,
        PerformanceData = -2147483644,
        CurrentConfig = -2147483643,
        DynData = -2147483642
    }
#endif
#if !SL
    public static class WinApiRegistryHelper {
        [Flags]
        public enum ResigtryAccess {
            QueryValue = Import.KEY_QUERY_VALUE,
            SetValue = Import.KEY_SET_VALUE,
            CreateSubKey = Import.KEY_CREATE_SUB_KEY,
            EnumerateSubKeys = Import.KEY_ENUMERATE_SUB_KEYS,
            Notify = Import.KEY_NOTIFY,
            CreateLink = Import.KEY_CREATE_LINK,
            Read = Import.KEY_READ,
            WOW64_32Key = Import.KEY_WOW64_32KEY,
            WOW64_64Key = Import.KEY_WOW64_64KEY,
            WOW64_Res = Import.KEY_WOW64_RES
        }
        [SecuritySafeCritical]
        public static IntPtr OpenRegistryKey(RegistryHive hkey, string subkey, ResigtryAccess access) {
            IntPtr handle;
            if(Import.RegOpenKeyEx(HkeyToPtr(hkey), subkey, 0, (int)access, out handle) != 0)
                handle = IntPtr.Zero;
            return handle;
        }
        [SecuritySafeCritical]
        public static void CloseRegistryKey(IntPtr key) {
            Import.RegCloseKey(key);
        }
        static IntPtr HkeyToPtr(RegistryHive hkey) {
            return hkey == RegistryHive.CurrentUser ? Import.HKEY_CURRENT_USER : Import.HKEY_LOCAL_MACHINE;
        }
        [SecuritySafeCritical]
        public static string[] ReadRegistryKeyMultiSzValue(IntPtr key, string name) {
            Import.RType type = Import.RType.RegMultiSz;
            uint size = 0;
            if(Import.RegQueryValueEx(key, name, 0, ref type, null, ref size) != 0) return null;
            byte[] d = new byte[(int)size];
            if(Import.RegQueryValueEx(key, name, 0, ref type, d, ref size) != 0) return null;
            List<string> strings = new List<string>();
            string s = Encoding.Unicode.GetString(d, 0, (int)size);
            int start;
            int end = -1;
            while(true) {
                start = end + 1;
                end = s.IndexOf('\0', start);
                if(end <= start) break;
                strings.Add(s.Substring(start, end - start));
            }
            return strings.ToArray();
        }
        [SecuritySafeCritical]
        public static string ReadRegistryKeySzValue(IntPtr key, string name) {
            Import.RType type = Import.RType.RegSz;
            uint size = 0;
            if(Import.RegQueryValueEx(key, name, 0, ref type, null, ref size) != 0) return null;
            byte[] d = new byte[(int)size];
            if(Import.RegQueryValueEx(key, name, 0, ref type, d, ref size) != 0) return null;
            return Encoding.Unicode.GetString(d, 0, (int)size);
        }
        static class Import {
            [DllImport("advapi32.dll", CharSet = CharSet.Unicode, EntryPoint = "RegQueryValueExW", SetLastError = true)]
            public static extern uint RegQueryValueEx(IntPtr hKey, string lpValueName, int lpReserved, ref RType lpType, byte[] pvData, ref uint pcbData);
            public enum RFlags {
                Any = 65535,
                RegNone = 1,
                Noexpand = 268435456,
                RegBinary = 8,
                Dword = 24,
                RegDword = 16,
                Qword = 72,
                RegQword = 64,
                RegSz = 2,
                RegMultiSz = 32,
                RegExpandSz = 4,
                RrfZeroonfailure = 536870912
            }
            public enum RType {
                RegNone = 0,
                RegSz = 1,
                RegExpandSz = 2,
                RegMultiSz = 7,
                RegBinary = 3,
                RegDword = 4,
                RegQword = 11,
                RegQwordLittleEndian = 11,
                RegDwordLittleEndian = 4,
                RegDwordBigEndian = 5,
                RegLink = 6,
                RegResourceList = 8,
                RegFullResourceDescriptor = 9,
                RegResourceRequirementsList = 10
            }
            [DllImport("advapi32.dll", SetLastError = true)]
            public static extern int RegCloseKey(IntPtr hKey);
            [DllImport("advapi32.dll", CharSet = CharSet.Auto)]
            public static extern int RegOpenKeyEx(IntPtr hKey, string subKey, int ulOptions, int samDesired, out IntPtr hkResult);
            public static IntPtr HKEY_LOCAL_MACHINE = new IntPtr(-2147483646);
            public static IntPtr HKEY_CURRENT_USER = new IntPtr(-2147483647);
            public const int KEY_QUERY_VALUE = 0x1;
            public const int KEY_SET_VALUE = 0x2;
            public const int KEY_CREATE_SUB_KEY = 0x4;
            public const int KEY_ENUMERATE_SUB_KEYS = 0x8;
            public const int KEY_NOTIFY = 0x10;
            public const int KEY_CREATE_LINK = 0x20;
            public const int KEY_WOW64_32KEY = 0x200;
            public const int KEY_WOW64_64KEY = 0x100;
            public const int KEY_WOW64_RES = 0x300;
            public const int KEY_READ = 0x20019;
        }
    }
    public class WinApiRegistryKey : DisposableBase {
        IntPtr handle;

        public WinApiRegistryKey(RegistryHive hive, string key, WinApiRegistryHelper.ResigtryAccess access) {
            handle = WinApiRegistryHelper.OpenRegistryKey(hive, key, access);
        }
        protected override void DisposeUnmanaged() {
            if(handle != IntPtr.Zero)
                WinApiRegistryHelper.CloseRegistryKey(handle);
            handle = IntPtr.Zero;
            base.DisposeUnmanaged();
        }
        public bool Exists { get { return handle != IntPtr.Zero; } }
        public string[] GetMultiSzValue(string name) {
            if(!Exists) return null;
            return WinApiRegistryHelper.ReadRegistryKeyMultiSzValue(handle, name);
        }
        public string GetSzValue(string name) {
            if(!Exists) return null;
            return WinApiRegistryHelper.ReadRegistryKeySzValue(handle, name);
        }
    }
    public class WinApiRegistryMultiKey : DisposableBase {
        List<WinApiRegistryKey> keys = new List<WinApiRegistryKey>();

        public WinApiRegistryMultiKey(RegistryHive hive, string key, WinApiRegistryHelper.ResigtryAccess access) {
            WinApiRegistryKey wkey = new WinApiRegistryKey(hive, key, access | WinApiRegistryHelper.ResigtryAccess.WOW64_32Key);
            if(wkey.Exists)
                keys.Add(wkey);
            wkey = new WinApiRegistryKey(hive, key, access | WinApiRegistryHelper.ResigtryAccess.WOW64_64Key);
            if(wkey.Exists)
                keys.Add(wkey);
        }
        protected override void DisposeManaged() {
            foreach(WinApiRegistryKey wkey in keys)
                wkey.Dispose();
            keys.Clear();
            base.DisposeManaged();
        }
        public bool Exists { get { return keys.Count > 0; } }
        public string[] GetMultiSzValue(string name) {
            var values = new List<string>();
            foreach(WinApiRegistryKey wkey in keys) {
                string[] s = wkey.GetMultiSzValue(name);
                if(s != null) {
                    values.AddRange(s);
                }
            }
            return values.Count > 0 ? values.ToArray() : null;
        }
        public string GetSzValue(string name) {
            foreach(WinApiRegistryKey wkey in keys) {
                string s = wkey.GetSzValue(name);
                if(s != null) return s;
            }
            return null;
        }
    }
    public class RegistryViewer : RegistryViewerBase {
        public static RegistryViewer Current = new RegistryViewer();

        public override bool IsKeyExists(RegistryHive hive, string key) {
            using(WinApiRegistryMultiKey wkey = GetWKey(hive, key)) {
                return wkey.Exists;
            }
        }
        public override string[] GetMultiSzValue(RegistryHive hive, string key, string name) {
            using(WinApiRegistryMultiKey wkey = GetWKey(hive, key)) {
                return wkey.GetMultiSzValue(name);
            }
        }
        public override string GetSzValue(RegistryHive hive, string key, string name) {
            using(WinApiRegistryMultiKey wkey = GetWKey(hive, key)) {
                return wkey.GetSzValue(name);
            }
        }
        WinApiRegistryMultiKey GetWKey(RegistryHive hive, string key) {
            key = key.Replace('/', '\\');
            return new WinApiRegistryMultiKey(hive, key, WinApiRegistryHelper.ResigtryAccess.Read);
        }
    }
    public class DbEngineDetector {
        public static string LocalDbVersion {
            get {
                string keybase = "SOFTWARE\\Microsoft\\Microsoft SQL Server Local DB\\Installed Versions\\";
                if(RegistryViewer.Current.IsKeyExists(RegistryHive.LocalMachine, keybase + "11.0"))
                    return "v11.0";
                if(RegistryViewer.Current.IsKeyExists(RegistryHive.LocalMachine, keybase + "12.0"))
                    return "v12.0";
                return null;
            }
        }
        public static bool IsSqlExpressInstalled {
            get {
                string[] instances = RegistryViewer.Current.GetMultiSzValue(RegistryHive.LocalMachine, "SOFTWARE\\Microsoft\\Microsoft SQL Server", "InstalledInstances");
                return instances != null && instances.Contains("SQLEXPRESS");
            }
        }
        public static bool IsLocalDbInstalled {
            get { return !string.IsNullOrEmpty(LocalDbVersion); }
        }
        public static string[] GetSclCEInstalledVersions() {
            List<string> result = new List<string>();
            string keybase = "SOFTWARE\\Microsoft\\Microsoft SQL Server Compact Edition\\";
            if (RegistryViewer.Current.IsKeyExists(RegistryHive.LocalMachine, keybase + "v3.5"))
                result.Add("v3.5");
            if (RegistryViewer.Current.IsKeyExists(RegistryHive.LocalMachine, keybase + "v4.0"))
                result.Add("v4.0");
            return result.ToArray();
        }
        static string PatchInnerString(string connectionString, bool entitySyntax, Func<string, string> f) {
            if(entitySyntax) {
                var entityBuilder = new EntityConnectionStringBuilder { ConnectionString = connectionString };
                entityBuilder.ProviderConnectionString = f(entityBuilder.ProviderConnectionString);
                return entityBuilder.ConnectionString;
            }
            return f(connectionString);
        }
        public static string PatchConnectionString(string rawConnectionString, bool entitySyntax = false) {
            return PatchInnerString(rawConnectionString, entitySyntax, cs => {
                var builder = new DbConnectionStringBuilder { ConnectionString = cs };
                string instanceName = GetSqlServerInstanceName();
                builder["Data Source"] = instanceName;
                if(instanceName.Contains("localdb")) {
                    builder.Remove("User Instance");
                }
                return builder.ConnectionString;
            });
        }
        public static string SelectConnectionStringName(string sqlexpressName, string localdbName) {
            string dbversion = LocalDbVersion;
            if(IsSqlExpressInstalled) {
                return sqlexpressName;
            }
            if(dbversion != null) {
                return localdbName;
            }            
            return sqlexpressName;
        }
        public static string GetSqlServerInstanceName() {            
            string localdbVersion = LocalDbVersion;            
            if(IsSqlExpressInstalled) {
                return ".\\SQLEXPRESS";
            }
            if(localdbVersion != null) {
                return "(localdb)\\" + localdbVersion;
            }
            return "(local)";
        }
    }
#endif
}
