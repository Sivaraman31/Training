using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stud
{
    class Student
    {

		public void EditContactFromDB(long phone)
		{
			SqlCommand fetchDataQuery = new SqlCommand($"SELECT * FROM Contacts WHERE PhoneNumber={phone}", con);

			try
			{
				con.Open();
				SqlDataReader sdr = fetchDataQuery.ExecuteReader();

				if (sdr.HasRows)
				{
					int nUserOption;

					while (sdr.Read())
					{
						Console.WriteLine($"Name\t: {sdr["Name"]}");
						Console.WriteLine($"First Name\t: {sdr["FirstName"]}");
						Console.WriteLine($"Last Name\t: {sdr["LastName"]}");
						Console.WriteLine($"Phone Number\t: {sdr["PhoneNumber"]}");
						Console.WriteLine($"EMail\t: {sdr["Email"]}");
					}

					con.Close();

					Console.WriteLine("\nWhich field you want to Edit: ");
					Console.WriteLine("1. Name");
					Console.WriteLine("2. First Name");
					Console.WriteLine("3. Last Name");
					Console.WriteLine("4. Phone Number");
					Console.WriteLine("5. Email");

					Console.Write("\nChoose your Option: ");
					int.TryParse(Console.ReadLine(), out nUserOption);

					if (nUserOption > 0)
					{
						con.Open();

						ContactBook contactBook = new ContactBook();
						switch (nUserOption)
						{
							case 1:
								Console.Write("Name\t\t: ");
								string strName = Console.ReadLine();

								SqlCommand nameUpdateQuery = new SqlCommand($"UPDATE Contacts SET Name='{strName}' WHERE PhoneNumber={phone}", con);
								nameUpdateQuery.ExecuteNonQuery();

								Console.WriteLine("\nData Modified...");
								break;
							case 2:
								Console.Write("First Name\t: ");
								string strFirstName = Console.ReadLine();

								SqlCommand firstNameUpdateQuery = new SqlCommand($"UPDATE Contacts SET FirstName='{strFirstName}' WHERE PhoneNumber={phone}", con);
								firstNameUpdateQuery.ExecuteNonQuery();

								Console.WriteLine("\nData Modified...");
								break;
							case 3:
								Console.Write("Last Name\t: ");
								string strLastName = Console.ReadLine();

								SqlCommand lastNameUpdateQuery = new SqlCommand($"UPDATE Contacts SET LastName='{strLastName}' WHERE PhoneNumber={phone}", con);
								lastNameUpdateQuery.ExecuteNonQuery();

								Console.WriteLine("\nData Modified...");
								break;
							case 4:
								Console.Write("Phone Number\t: ");
								long newPhoneNumber = Convert.ToInt64(Console.ReadLine());

								SqlCommand phoneUpdateQuery = new SqlCommand($"UPDATE Contacts SET PhoneNumber={newPhoneNumber} WHERE PhoneNumber={phone}", con);
								phoneUpdateQuery.ExecuteNonQuery();

								Console.WriteLine("\nData Modified...");
								break;
							case 5:
								Console.Write("Email\t\t: ");
								string strEmail = Console.ReadLine();

								SqlCommand emailUpdateQuery = new SqlCommand($"UPDATE Contacts SET Email='{strEmail}' WHERE PhoneNumber={phone}", con);
								emailUpdateQuery.ExecuteNonQuery();

								Console.WriteLine("\nData Modified...");
								break;
							default:
								Console.WriteLine("\nInvalid Option.Try again...");
								contactBook.EditContact();
								break;
						}
					}
					else
					{
						Console.WriteLine("\nInvalid Option.Try again...");
						new ContactBook().EditContact();
					}
				}
				else
				{
					Console.WriteLine("\nNo Records Found...");
				}
			}
			catch
			{
				Console.WriteLine("\nCannot edit the Contact...\n\n");
			}
			finally
			{
				con.Close();
			}
		}

	}
}
