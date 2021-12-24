using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactDB
{
    public class ContactBook
    {
        public string ContactName { get; set; }
        public string Location { get; set; }
        public string EMail { get; set; }
        public long PhoneNumber { get; set; }
    }
    static ArrayList ContactList = new ArrayList();
    public static void Main(string[] args)
    {
        DisplayMenu();
    }
    static void DisplayMenu()
    {
        Console.WriteLine("\n _____CONTACT LIST_____ \n");
        Console.WriteLine("1: Add New Contact");
        Console.WriteLine("2: Display Contact");
        Console.WriteLine("3: Search Contact");
        Console.WriteLine("4: Edit Contact");
        Console.WriteLine("5: Delete Contact");
        Console.WriteLine("6: Exit");

        Console.Write("\n Enter Your Choice: ");

        int nChoice;
        int.TryParse(Console.ReadLine(), out nChoice);
        if (nChoice > 0)
        {
            switch (nChoice)
            {
                case 1:
                    AddContact();
                    break;
                case 2:
                    DisplayContact();
                    break;
                case 3:
                    SearchContact();
                    break;
                case 4:
                    EditContact();
                    break;
                case 5:
                    DeleteContact();
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Invalid Choice...");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid Choice...");
        }
        DisplayMenu();
    }
    static void AddContact()
    {

        ContactBook contact = new ContactBook();

        Console.WriteLine("\n");
        Console.Write("Enter Contact Name : ");
        contact.ContactName = Console.ReadLine();

        Console.Write("Enter Phone Number : ");
        contact.PhoneNumber = Convert.ToInt64(Console.ReadLine());

        Console.Write("Enter Location : ");
        contact.Location = Console.ReadLine();

        Console.Write("Enter Mail Id : ");
        contact.EMail = Console.ReadLine();

        ContactList.Add(contact);

        Console.WriteLine("\n");
        Console.WriteLine("Contact Added Successfully...");
        Console.WriteLine("\n");

        ContactBook.AddContactDB(contact);
        DisplayContact();
    }


    class ContactBookDB
    {
        SqlConnection con = new SqlConnection("data source=.; database=ContactBookDB; integrated security=SSPI");

        public void AddContactToDB(Contact contact)
        {
            SqlCommand insertQuery = new SqlCommand($"INSERT INTO Contacts(ContactName, PhoneNumber, Location, Email) VALUES ( '{contact.ContactName}', '{contact.PhoneNumber}', {contact.EMail}, '{contact.Location}')", con);

            try
            {
                con.Open();
                insertQuery.ExecuteNonQuery();
                Console.WriteLine("\nContact Added Successfully...\n\n");
            }
            catch
            {
                Console.WriteLine("\nCannot add the Contact...\n\n");
            }
            finally
            {
                con.Close();
            }
        }
    }
}
