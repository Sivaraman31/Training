using System;

namespace Const
{
    class ContactList
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long Number { get; set; }

    }
   
    class Program
    {

        static void Main(string[] args)
        {
            ContactList contactList = new ContactList();

            while (true)
            {
                Console.WriteLine("1:Add");
                Console.WriteLine("2:Delete");
                Console.WriteLine("Enter Your Choice :");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                            Console.Write("Enter First Name :");
                        contactList.FirstName = Convert.ToString(Console.ReadLine());


                            Console.Write("Enter Last Name :");
                        contactList.LastName = Convert.ToString(Console.ReadLine());

                            Console.Write("Enter Number :");
                        contactList.Number = Convert.ToInt64(Console.ReadLine());
                       
                            break;

                    case 2:
                        ViewContact();
                        break;

                    default:
                        Console.WriteLine("Choice is not Available...");
                        break;
                }
            }

            
            static void AddContact()
            {
                ContactList contactlist = new ContactList();

                Console.WriteLine("\n\n");
                Console.WriteLine("Inserted Contact");
                Console.WriteLine("\n");
                Console.Write(contactlist.FirstName);
                Console.Write("\t");
                Console.Write(contactlist.LastName);
                Console.Write("\t");
                Console.Write(contactlist.Number);
                Console.WriteLine("\n");
                
            }

            static void ViewContact()
            {
                Console.WriteLine(FirstName);

                Console.ReadKey();
            }

            static void DeleteContact()
            {
                string DeleteName;
                ContactList contactlist = new ContactList();

                Console.WriteLine("Enter The Contact name For Delete :");

                DeleteName = Convert.ToString(Console.ReadLine());
                Console.Write("\n");
                if (DeleteName != FirstName )
                {
                    Console.WriteLine("Contact Was Deleted...");
                }
                else
                {
                    Console.WriteLine("Unknown Contact...");
                }
            }
        }
    }
}
