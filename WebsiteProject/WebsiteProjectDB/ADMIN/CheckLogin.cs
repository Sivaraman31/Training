using System;
using System.Data.SqlClient;

namespace WebsiteProjectDB.ADMIN
{
	public class CheckLogin
	{
		SqlConnection con;

		public CheckLogin()
		{
			con = new SqlConnection("data source=.; database=WebsiteProject; integrated security=SSPI");
		}

		public bool AdminLoginValidation(string userName, string password)
		{
			SqlCommand selectQuery = new SqlCommand($"SELECT * FROM AdminUsers WHERE Name='{userName}' AND Password='{password}'", con);

			try
			{
				con.Open();
				SqlDataReader sdr = selectQuery.ExecuteReader();

				if(sdr.HasRows) return true;
				else return false;
			}
			catch(Exception e)
			{
				return false;
			}
			finally
			{
				con.Close();
			}
		}
	}
}
