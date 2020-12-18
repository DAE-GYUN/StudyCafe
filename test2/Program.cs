using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            const string ConnectionString = "Data Source=cn76.ipdisk.co.kr,3423;Initial Catalog=KoreanStudyCafe;Persist Security Info=True;User ID=8f;Password=1";
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "RecordTheBeverageRecord";

            connection.Open();

            try
            {
                command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
