using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Databasteknik_Inlämning1.All_classes
{
    public class SQLSearch
    {
        public SQLSearch(string address)
        {
            var GetAddress= new AddressOutput();
            SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AddressBook.mdf;Integrated Security=True;Connect Timeout=30");

            SqlCommand commands = new SqlCommand();

            using (connect)
            {
                using (commands)
                {
                    connect.Open();
                    var Statement = $"select * from dbo.Addresses where Gatunamn =  \"address\"";  
                    var command = new SqlCommand(Statement, connect);
                    SqlDataReader read = command.ExecuteReader();

                    if (read.Read())
                    {
                        GetAddress.Address= read["Gatunamn"].ToString();
                        GetAddress.MailingAddress = Convert.ToInt32(read["Postnummer"].ToString());
                        GetAddress.City = read["Postort"].ToString();
                    }

                    else
                    {
                        MessageBox.Show("Ingen address med detta namn existerar i adressboken.");
                    }
                    read.Close();
                    connect.Close();
                }
            }
        }
    }
}