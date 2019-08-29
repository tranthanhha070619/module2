using System;
using System.Collections.Generic;
using System.Text;
using Telephones.Modul;

namespace Telephones
{

    public class PhoneTest
    {
        public static PhoneBook phoneBook = new PhoneBook();
        public static void Main()
        {
            {
                InitMenu();

            }
        }

        public static void InitMenu()
        {
            int option = 0;
            do
            {
                Console.WriteLine("Management phone");
                Console.WriteLine("1. Insert phone");
                Console.WriteLine("2. Remove phone");
                Console.WriteLine("3. Update phone");
                Console.WriteLine("4. Seach phone");
                Console.WriteLine("5. Sort phone");
                Console.WriteLine("6. Display");
                Console.WriteLine("7. Exit");
                Console.WriteLine("Please select an option");
                Console.Write("Option: ");
                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    option = number;
                }

            }
            while (option > 7 || option <= 0);
            Process(option);
        }
        public static void Process(int seleted)
        {
            Console.Clear();
            switch (seleted)
            {
                case 1:
                    {
                        Console.WriteLine("Insert phone: ");
                        Console.Write("input name: ");
                        var name = Console.ReadLine();

                        Console.Write("Input phone number: ");
                        var phone = Console.ReadLine();
                        phoneBook.insertPhone(name, phone);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine(" Remove phone: ");
                        var name = Console.ReadLine();
                        phoneBook.removePhone(name);
                        break;
                    }

                case 3:
                    {
                        Console.WriteLine(" Update phone: ");
                        Console.WriteLine("Nhap ten: ");
                        var name = Console.ReadLine();
                        Console.WriteLine("Nhap so phone: ");
                        var phone = Console.ReadLine();
                        phoneBook.updatePhone(name, phone);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine(" Seach name: ");
                        var name = Console.ReadLine();
                        Console.WriteLine("Seach ");
                        phoneBook.seachPhone(name);
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine(" Sort phone: ");
                        break;
                    }
                case 6:
                    {
                        Display();
                        break;
                    }
                case 7:
                default:
                    {
                        Environment.Exit(Environment.ExitCode);
                        break;
                    }
            }
            InitMenu();


        }
        public static void Display()
        {
            Console.WriteLine("Name \t\t\t Phonenumber");
            if (phoneBook.PhoneList != null && phoneBook.PhoneList.Count > 0)
            {
                foreach (NewItem newItem in phoneBook.PhoneList)
                {
                    Console.WriteLine("{0}\t\t\t{1}", newItem.Name, newItem.PhoneNumber);
                }
            }
        }

    }
    //var phonebook = new phonebook();
    //for(int i = 0; i < 3; i++)
    //{
    //    console.write("nhap vao ten: ");
    //    var name = console.readline();

    //    console.write("nhap so phone: ");
    //    var phone = console.readline();

    //    phonebook.insertphone(name, phone);
    //}
   

}

