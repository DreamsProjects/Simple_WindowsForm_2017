using System.Data.SqlClient;

namespace Databasteknik_Inlämning1.All_classes
{
    public class DataAccess
    {
        private SqlConnection connection = null;

        public DataAccess()
        {
            var constring = Properties.Settings.Default.AddressBookConnectionString;
            connection = new SqlConnection(constring);
        }
    }
}