using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace ContactBookDB
{
	class Contacts
	{
		static void Main(string[] args)
		{
			DisplayMenu();
		}

		static void DisplayMenu()
		{
			int nChoice;
            Console.WriteLine("\n----------------------Contact Book------------------------\n\n");
			Console.WriteLine("1. Add Contact");
			Console.WriteLine("2. Display Contact");
			Console.WriteLine("3. Search Contact");
			Console.WriteLine("4. Delete Contact");
			Console.WriteLine("5. Edit Contact");
			Console.WriteLine("6. Exit");
			Console.Write("\nEnter your Choice: ");
			if (int.TryParse(Console.ReadLine(), out nChoice))
			{
				switch (nChoice)
				{
					case 1:
						new Contacts().AddContact();
						break;
					case 2:
						new Contacts().DisplayContact();
						break;
					case 3:
						int nNumber;
						Console.Write("\nEnter the PhoneNumber to Search: ");
						nNumber = int.Parse(Console.ReadLine());
						new Contacts().SearchContact(nNumber);
						break;
					case 4:
						new Contacts().DeleteContact();
						break;
					case 5:
						new Contacts().EditContact();
						break;
					case 6: return;
					default:
						Console.WriteLine("Invalid Choice...");
						break;
				}
			}
			else
			{
				Console.WriteLine("Invalid Input. Try Again...");
			}
			DisplayMenu();
		}

		public void AddContact()
		{
			string strName, strLocation, strMail;
			int nNumber;
			Console.Write("\nEnter Name: ");
			strName = Console.ReadLine();
			Console.Write("Enter PhoneNumber: ");
			nNumber = int.Parse(Console.ReadLine());
			Console.Write("Enter Location: ");
			strLocation = Console.ReadLine();
			Console.Write("Enter Your Mail: ");
			strMail = Console.ReadLine();
			using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=ContactBookDB;Integrated Security=SSPI"))
			{
				
				string sql = "Insert into ContactDB(ContactName, PhoneNumber, Location, EMail) Values(@Name, @Number, @Location, @Mail)";
                
					connection.Open();
					SqlCommand command;
					SqlDataAdapter dataAdapter = new SqlDataAdapter();
					command = new SqlCommand(sql, connection);
					command.CommandType = CommandType.Text;
					command.Parameters.AddWithValue("@Name", strName);
					command.Parameters.AddWithValue("@Number", nNumber);
					command.Parameters.AddWithValue("@Location", strLocation);
					command.Parameters.AddWithValue("@Mail", strMail);
					command.ExecuteNonQuery();
                    Console.WriteLine("Contact Added...");
					DisplayContact();
					command.Dispose();	
			}
		}
		public void DisplayContact()
		{
			using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=ContactBookDB;Integrated Security=SSPI"))
			{
                
				connection.Open();
				SqlCommand command;
				SqlDataReader dataReader;
				Console.WriteLine("\n");
				string sql = "Select * from ContactDB", output = " ";
				command = new SqlCommand(sql, connection);
				dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
					while (dataReader.Read())
					{
						output = output + dataReader.GetValue(0) + "  " + dataReader.GetValue(1) + "  " + dataReader.GetValue(2) + " " + dataReader.GetValue(3) + "\n";
					}
                }
                else
                {
                    Console.WriteLine("\nContacts Not Found...");
                }

				Console.WriteLine(output);
				dataReader.Close();
				command.Dispose();
				connection.Close();
			}
		}
		public void SearchContact(int Number)
		{
			using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=ContactBookDB;Integrated Security=SSPI"))
			{
				connection.Open();
				SqlCommand command;
				SqlDataReader dataReader;
				SqlDataAdapter dataAdapter = new SqlDataAdapter();
				string output = " ", sql = "Select * from ContactDB where PhoneNumber = @Number;";
				command = new SqlCommand(sql, connection);
				{
					command.CommandType = CommandType.Text;
					command.Parameters.AddWithValue("@Number", Number);
				}
				dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
					while (dataReader.Read())
					{
						output = output + dataReader.GetValue(0) + "  " + dataReader.GetValue(1) + "  " + dataReader.GetValue(2) + "  " + dataReader.GetValue(3) + "\n";
					}
                }
                else
                {
                    Console.WriteLine("\nNo Record Found...");
                }
				

				Console.WriteLine(output);
				command.Dispose();
				connection.Close();
			}
		}
		public void DeleteContact()
		{
			int Number;
			Console.Write("\nEnter the PhoneNumber to Delete: ");
			Number = int.Parse(Console.ReadLine());
			check(Number);
			using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=ContactBookDB;Integrated Security=SSPI"))
			{
				connection.Open();
				SqlCommand command;
				SqlDataAdapter dataAdapter = new SqlDataAdapter();
				string sql = "Delete from ContactDB where PhoneNumber = @Number";

				command = new SqlCommand(sql, connection);
				{
					command.CommandType = CommandType.Text;
					command.Parameters.AddWithValue("@Number", Number);
				}
				command.ExecuteNonQuery();
				Console.WriteLine("\nContact Deleted Successfully.");
				DisplayContact();
				command.Dispose();
				connection.Close();
			}
		}
		public void check(int PhoneNumber)
		{
			int nNumber = PhoneNumber;
			using (SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=ContactBookDB;Integrated Security=SSPI"))
			{
				Conn.Open();
				SqlCommand cmd;
				string sql = "Select * from ContactDB Where PhoneNumber = @Number";
				cmd = new SqlCommand(sql, Conn);
				cmd.Parameters.AddWithValue("@Number", nNumber);
				SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
				if (reader.HasRows) { }
				
				else
				{
					Console.WriteLine("\nNo Records found \n");
					DisplayMenu();
				}

				cmd.Dispose();
				Conn.Close();
			}
		}
		public void EditContact()
		{
			int nChoice;
			Console.WriteLine("\n1. Edit Name: ");
			Console.WriteLine("2. Edit Number: ");
			Console.WriteLine("3. Edit Location: ");
			Console.WriteLine("4. Edit Mail Id: ");
			Console.Write("\nEnter your choice: ");
			if (int.TryParse(Console.ReadLine(), out nChoice))
			{
				switch (nChoice)
				{
					case 1:
						EditName();
						break;
					case 2:
						EditNumber();
						break;
					case 3:
						EditLocation();
						break;
					case 4:
						EditMail();
						break;
					default:
                        Console.WriteLine("Invalid Choice... Try Again....");
						break;
				}
			}
		}

		public void EditName()
		{
			int Number;
			Console.Write("\nEnter Your Phonenumber to Edit Your Name: ");
			Number = int.Parse(Console.ReadLine());
			check(Number);
			string strName;
			Console.Write("\nEnter Your New Name: ");
			strName = Console.ReadLine();

			using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=ContactBookDB;Integrated Security=SSPI"))
			{
				connection.Open();
				SqlCommand command;
				SqlDataAdapter dataAdapter = new SqlDataAdapter();

				string sql = "Update ContactDB Set ContactName = @Name where PhoneNumber = @" + Number;
				command = new SqlCommand(sql, connection);

				command.Parameters.AddWithValue("@Name", strName);
				command.Parameters.AddWithValue("@" + Number, Number);
				command.ExecuteNonQuery();
                Console.WriteLine("\n Your Name Successfully Changed...");
				command.Dispose();
				DisplayContact();
				connection.Close();
			}
		}
		public void EditNumber()
		{
			int Number;
			Console.Write("\nEnter the number to Edit: ");
			Number = int.Parse(Console.ReadLine());
			check(Number);
			int nNumber;
			Console.Write("\nEnter the New Number: ");
			nNumber = int.Parse(Console.ReadLine());

			using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=ContactBookDB;Integrated Security=SSPI"))
			{
				connection.Open();
				SqlCommand command;
				SqlDataAdapter dataAdapter = new SqlDataAdapter();

				string sql = "Update ContactDB Set PhoneNumber = @Number where PhoneNumber = @" + Number;
				command = new SqlCommand(sql, connection);

				command.CommandType = CommandType.Text;
				command.Parameters.AddWithValue("@Number", nNumber);
				command.Parameters.AddWithValue("@" + Number, Number);
				command.ExecuteNonQuery();
				Console.WriteLine("\n Your Phone Number Successfully Changed...");
				command.Dispose();
				DisplayContact();
				connection.Close();
			}
		}
		public void EditLocation()
		{
			int Number;
			Console.Write("\nEnter the number to Edit: ");
			Number = int.Parse(Console.ReadLine());
			check(Number);
			string strLocation;
			Console.Write("\nEnter the New Location: ");
			strLocation = Console.ReadLine();

			using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=ContactBookDB;Integrated Security=SSPI"))
			{
				connection.Open();
				SqlCommand command;
				SqlDataAdapter dataAdapter = new SqlDataAdapter();

				string sql = "Update ContactDB Set Location = @Location where PhoneNumber = @" + Number;
				command = new SqlCommand(sql, connection);

				command.CommandType = CommandType.Text;
				command.Parameters.AddWithValue("@Location", strLocation);
				command.Parameters.AddWithValue("@" + Number, Number);
				command.ExecuteNonQuery();
				Console.WriteLine("\n Your Location Successfully Changed...");
				command.Dispose();
				DisplayContact();
				connection.Close();
			}
		}
		public void EditMail()
		{
			int Number;
			Console.Write("\nEnter the number to Edit: ");
			Number = int.Parse(Console.ReadLine());
			check(Number);
			string strMail;
			Console.Write("\nEnter the New Mail Id: ");
			strMail = Console.ReadLine();

			using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=ContactBookDB;Integrated Security=SSPI"))
			{
				connection.Open();
				SqlCommand command;
				SqlDataAdapter dataAdapter = new SqlDataAdapter();

				string sql = "Update ContactDB Set EMail = @Mail where PhoneNumber = @" + Number;
				command = new SqlCommand(sql, connection);

				command.CommandType = CommandType.Text;
				command.Parameters.AddWithValue("@Mail", strMail);
				command.Parameters.AddWithValue("@" + Number, Number);
				Console.WriteLine("\n Your Mail Id Successfully Changed...");
				command.ExecuteNonQuery();
				command.Dispose();
				DisplayContact();
				connection.Close();
			}
		}
	}
}