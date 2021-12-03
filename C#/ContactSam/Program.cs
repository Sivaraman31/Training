using System;
using System.Collections.Generic;
namespace ContactSam
{
    class Program
    {
        static ArrayList tel_book_arr = new ArrayList();
        static void Main(string[] args)
        {

            int sel = 0;

            while (sel != 6)
            {
                Console.Clear();
                Console.WriteLine("1 : enter information");
                Console.WriteLine("2 : display information");
                Console.WriteLine("3 : search information");
                Console.WriteLine("4 : edit information");
                Console.WriteLine("5 : delete information");
                Console.WriteLine("6 : exit");

                Console.Write("\nenter your choose : ");
                sel = Convert.ToInt32(Console.ReadLine());

                switch (sel)
                {
                    case 1:
                        enter_info();
                        break;
                    case 2:
                        show_info();
                        break;
                    case 3:
                        search_ifo();
                        break;
                    case 4:
                        edit_info();
                        break;
                    case 5:
                        delet_ifo();
                        break;
                }
            }

        }

        static void enter_info()
        {
            Console.Clear();

            telephone t = new telephone();

            Console.Write("enter name : ");
            t.name = Console.ReadLine();

            Console.Write("enter family : ");
            t.family = Console.ReadLine();

            Console.Write("enter tel : ");
            t.tel = Console.ReadLine();

            tel_book_arr.Add(t);
        }

        static void show_info()
        {
            Console.Clear();

            foreach (telephone temp in tel_book_arr)
            {
                Console.WriteLine("name : " + temp.name);
                Console.WriteLine("family : " + temp.family);
                Console.WriteLine("tel : " + temp.tel);
                Console.ReadKey();
            }
        }

        static void search_ifo()
        {
            Console.Clear();
            object name = Console.Read("please enter the number: ");
            object family = Console.Read("please enter the family: ");
        }
        static void edit_info()
        {
            Console.Clear();
            search_ifo();
        }
        static void delet_ifo()
        {
            Console.Clear();
        }
    }

    class telephone
    {
        public string name, family, tel;
    }
}


