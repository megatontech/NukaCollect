using DevExpress.Xpo.DB;
using System.Data;

namespace NukaCollect.Helpers
{
    public class DataStoreHelper
    {
        public static IDataStore CreateInMemoryDataStore()
        {
            return new DataSetDataStore(new DataSet(), AutoCreateOption.SchemaOnly);
        }
    }
}