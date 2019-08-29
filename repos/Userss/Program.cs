using System;
using System.Collections.Generic;

namespace Userss
{
    public class Program
    {
        public static Dictionary<int, User> PhoneList = new Dictionary<int, User>();

        public static int Id = 0;
        public static void Main(string[] args)
        {
            Menu();
        }
        public static void Menu()
        {

            int option = 0;
            do
            {
                Console.WriteLine("1. Add User ");

                Console.WriteLine("2. Cherk User");

                Console.WriteLine("3. Display all User");

                Console.WriteLine("4. Exit");
                option = int.Parse(Console.ReadLine());
            }
            while (option > 4|| option < 0);
            Process(option);
        }

        public static void Process(int select)
        {
            switch (select)
            {
                case 1:

                    Console.WriteLine("Add...");
                    Create();
                    break;



                case 2:
                    Ask();
                    break;

                case 3:
                    Display();
                    break;

                case 4:
                    Environment.Exit(Environment.ExitCode);

                    break;

            }
            Menu();
        }
        public static void Create()
        {
            var user = new User();
            user.ID = Id + 1;

            Console.WriteLine("Input the name: ");
            user.Name = Console.ReadLine();

            Console.WriteLine("Input the Pass: ");
            user.PassWord = Console.ReadLine();


            Console.WriteLine("Input of Phonenumber: ");
            var addPhone = Console.ReadLine();
            if(string.Compare(addPhone.ToUpper(),"H") == 0)
            {
                Console.Write("please input phone number: ");
                user.phoneList.Add(int.Parse(Console.ReadLine()));
            }
            PhoneList.Add(user.ID, user);


        }
       public static void Ask()
        {
            
            Console.WriteLine("Ask user to enter ID: ");
            var id = Console.ReadLine();

            Console.WriteLine("Ask user to enter Name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Ask user to Password ");
            var pass = Console.ReadLine();

            var IsExit = false;
            foreach (KeyValuePair<int, User> item in PhoneList) {
                if (item.Value.Name == name && item.Value.PassWord == pass)
                {
                    IsExit = true;
                }
          }
            if (IsExit)
            {
                Console.WriteLine("User checked");
            }
            else
            {
                Console.WriteLine("User not found");
            }
        }
        public static void Display()
        {
            foreach(KeyValuePair<int,User> item in PhoneList)
            {
                Console.WriteLine(item.Value.Display());
            }
        }
    }
}
