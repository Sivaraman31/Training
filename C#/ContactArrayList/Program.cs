using System;
using System.Collections;
using System.Data.SqlClient;
using System.Data;

public class ContactBook
{
    public string ContactName { get; set; }
    public string Location { get; set; }
    public string EMail { get; set; }
    public long PhoneNumber { get; set; }
}
public class Program
{
    static ArrayList ContactList = new ArrayList();
    static void Main(string[] args)
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
        int.TryParse(Console.ReadLine(),out nChoice);
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
        int nPhone;
        string strC_Name, strLocation, strMail;

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

        /*using(SqlConnection conn=new SqlConnection("Data Source=.;Database=ContactBookDB;Integrated Security=SSPI"))
        {
            conn.Open();
            SqlCommand cmd;
            SqlDataAdapter adap = new SqlDataAdapter();

            string sql = "";
            sql = "Insert Into ContactDB(ContactName,PhoneNumber,Location,Email) Values(@ContactName,@PhoneNumber,@Location,@EMail)";
            
            cmd=new SqlCommand(sql, conn)
            {
                cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ContactName", strC_Name);
            cmd.Parameters.AddWithValue("@PhoneNumber", nPhone);
            cmd.Parameters.AddWithValue("@Location", strLocation);
            cmd.Parameters.AddWithValue("@Email", strMail);
        }
            adap.InsertCommand = new SqlCommand(sql, conn);

            
        }*/
       
    }

    static void DisplayContact()
    {
        if (ContactList.Count == 0)
        {
            Console.WriteLine("ContactBook is Empty");
            Console.WriteLine("\n ");
        }
        else
        {
            foreach (ContactBook display in ContactList)
            {
               // Console.WriteLine("\n Contact List Will Be Showen Below. \n");
                Console.WriteLine("Contact Name : " + display.ContactName);
                Console.WriteLine("Phone Number : " + display.PhoneNumber);
                Console.WriteLine("Location : " + display.Location);
                Console.WriteLine("Mail Id : " + display.EMail);
                Console.ReadKey();
                Console.WriteLine("\n");
            }
        }
       
    }
    static void SearchContact()
    {
        Console.Write("\n Enter The Number To Search :");
        long lPhoneNumber = Convert.ToInt64(Console.ReadLine());
        ContactBook contactBook = new ContactBook();

        foreach (ContactBook search in ContactList)
        {
            if (search.PhoneNumber == lPhoneNumber)
            {
                contactBook = search;
                break;
            }
        }

        if (contactBook != null)
        {
            //Console.WriteLine("\n Searched Contact Will Showen Below.");

            Console.WriteLine("Contact Name :" + contactBook.ContactName);
            Console.WriteLine("Phone Number :" + contactBook.PhoneNumber);
            Console.WriteLine("Location :" + contactBook.Location);
            Console.WriteLine("Mail Id :" + contactBook.EMail);
        }
        else
        {
            Console.WriteLine("No Record Found :(");
            Console.WriteLine("\n");
        }
       
    }
    static void EditContact()
    {
        Console.Write("\n Enter the Contact number to Edit Details :");
        long lPhoneNumber = Convert.ToInt64(Console.ReadLine());
        ContactBook contactBook = new ContactBook();
        bool bContactExist = false;

        foreach (ContactBook edit in ContactList)
        {
            if (edit.PhoneNumber == lPhoneNumber)
            {
                contactBook = edit;
                bContactExist = true;
                break;
            }
        }

        if (bContactExist)
        {
            Console.WriteLine("\n Choose The Field To Edit... \n");

            while (true)
            {
                Console.WriteLine("1: Edit Name");
                Console.WriteLine("2: Edit Number");
                Console.WriteLine("3: Edit Location");
                Console.WriteLine("4: Edit Mail Id");
                Console.WriteLine("5: Exit Editing");
                Console.WriteLine("\n Enter your Choice");

                var Editchoice = Convert.ToString(Console.ReadLine());

                switch (Editchoice)
                {
                    case "1":
                        Console.Write("\n Enter New Name :");
                        contactBook.ContactName = Console.ReadLine();
                        Console.WriteLine("successfull changed...");
                        DisplayContact();
                        break;

                    case "2":
                        Console.Write("\n Enter New Number :");
                        contactBook.PhoneNumber = Convert.ToInt64(Console.ReadLine());
                        DisplayContact();
                        break;

                    case "3":
                        Console.Write("\n Enter New Location :");
                        contactBook.Location = Console.ReadLine();
                        DisplayContact();
                        break;

                    case "4":
                        Console.Write("\n Enter New Mail Id :");
                        contactBook.EMail = Console.ReadLine();
                        DisplayContact();
                        break;

                    case "5":
                        return;

                    default:
                        Console.WriteLine("Invalid Choice. Try again...");
                        break;
                }
            }
        }
        else
        {
            Console.WriteLine("No Records found :(");
            Console.WriteLine("\n");
        }
    }
    static void DeleteContact()
    {
        Console.Write("\n Enter the Name to Delete :");
        string strContactName = Convert.ToString(Console.ReadLine());
        ContactBook contactBook = new ContactBook();
        bool bContactExist = false;

        foreach (ContactBook find in ContactList)
        {
            if (find.ContactName == strContactName)
            {
                contactBook = find;
                bContactExist = true;
                break;
            }
        }

        if (bContactExist)
        {
            Console.WriteLine("\n Contact Deleted...");
            Console.WriteLine("\n");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("\n No Records found :(");
        }
    }   
    
    
}