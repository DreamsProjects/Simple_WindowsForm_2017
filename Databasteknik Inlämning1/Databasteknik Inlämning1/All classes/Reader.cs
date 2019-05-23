using System.Data;
using System.Data.SqlClient;
using System.ComponentModel; //BindingList

namespace Databasteknik_Inlämning1.All_classes
{
    public class Reader
    {
        private SqlConnection connection = null;
        private const string Id = "KundID";
        private const string Name = "Förnamn";
        private const string Address = "Adress";

        public Reader()
        {
           var connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AddressBook.mdf;Integrated Security=True;Connect Timeout=30");
        }

        public BindingList<RegisterPerson> Person(string commandText, CommandType type, SqlParameter[] param)
        {
            var address = new BindingList<RegisterPerson>();

            using (connection)
            {
                connection.Open();
                SqlCommand command = new SqlCommand(commandText, connection);
                command.CommandType = type;

                if(param != null)
                {
                    command.Parameters.AddRange(param);
                }

                SqlDataReader read = command.ExecuteReader();

                while(read.Read())
                {
                    var areNumb = int.TryParse(read[Id].ToString(), out int idNumber);
                    address.Add(new RegisterPerson
                    {
                        ID = idNumber,
                        Firstname = read[Name].ToString(),
                        Address = read[Address].ToString()
                    });
                }
                connection.Close();
            }
            return address;
        }
    }
}