using System;

namespace NukaCollect.Helpers {
    public class EnumHelper {
        public static T[] GetValues<T>() {
            return (T[])Enum.GetValues(typeof(T));
        }
    }
}
