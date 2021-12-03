using System;

namespace Contact
{
    class Program
    {
        ContactList mobile = new ContactList();
        static void Main(string[] args)
        {
            mobile(){
                while (true)
                {
                    Console.WriteLine("1:Add");
                    Console.WriteLine("2:search");
                    Console.WriteLine("Enter Your Choice :");
                    int choose = Convert.ToInt32(Console.ReadLine());

                    switch (choose)
                    {
                        case 1:
                            AddContact();
                            break;
                        case 2:
                            SearchContact();
                            break;
                    }
                }
            }

            
            
        }
        static void AddContact()
        {
            long number;
            string strF, strL;
            Console.WriteLine("Contact Book");

            Console.WriteLine("Enter First Name :");
            strF = Console.ReadLine();

            Console.WriteLine("Enter Last Name :");
            strL = "Firstname";
            strL = Console.ReadLine();

            Console.WriteLine("Enter mobile :");
            number = Convert.ToInt64(Console.ReadLine());

        }
        void EditContact()
        {

        }

        static void SearchContact()
        {
            long number;
            string strF, strL;

            Console.Write("Enter your Firstname : ");
            strF = Console.ReadLine();

            if (name[strF] == null)
            {
                Console.WriteLine("Given name is not found in phonebook");
            }
            else
            {
                number = Convert.ToInt64(mobile[number]);
                Console.WriteLine("Name: " + strF + ", phone number: " + number);
            }
        }
    }
}
