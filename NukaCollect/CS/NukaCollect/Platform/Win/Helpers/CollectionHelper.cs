using System.Collections;

namespace NukaCollect.Helpers
{
    public class CollectionHelper
    {
        public static IList CreateList(ICollection collection)
        {
            return new ArrayList(collection);
        }
    }
}