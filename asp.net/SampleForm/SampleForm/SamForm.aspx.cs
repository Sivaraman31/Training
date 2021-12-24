using System;
using System.Data.SqlClient;
namespace DBconn
{
    class Con
    {
        static void Main()
        {
            new Con().Connection();
        }
        public void Connection()
        {
            using(SqlConnection con = new SqlConnection("datasource=.;database=Student;integrated security=SSPI"))
            {
                con.Open();
                Console.WriteLine("Connected....");
            }
        }
    }
}