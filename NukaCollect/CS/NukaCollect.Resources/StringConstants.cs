using System.Reflection;

namespace NukaCollect.Resources
{
    public class ConstStrings
    {
        public static string Get(string name)
        {
            return GetDefault(name);
        }

        private static string GetDefault(string name)
        {
            PropertyInfo pi = typeof(NukaCollect.Resources.Properties.Resources).GetProperty(name);
            return string.Format("{0}", pi.GetValue(null, new object[] { }));
        }
    }
}