using System;
using System.Collections.Generic;
using System.Text;

namespace User
{
   public class UserTest
    {
        public static Dictionary<int, User> PhoneList = new Dictionary<int, User>();
        public static int iD = 0;
        public static void Main()
        {

        }
        public static void Menu()
        {
            int opstion = 0;
            do
            {
                Console.WriteLine("1. Add User");
                Console.WriteLine("2. Check User");
                Console.WriteLine("3. Display all User");
                Console.WriteLine("4. Exit");
                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    opstion = number;
                }
            }
            while (opstion >= 4 && opstion < 0);
            
        }
        public static void





        public static void Create()
        {
            var user = new User();
            iD = iD + 1;
            user.Id = iD;

            Console.WriteLine("Input the Name: ");
            user.Name = Console.ReadLine();

            Console.WriteLine("Input the password");
            user.Password = Console.ReadLine();

            var number = 0;
            do
            {
                Console.Write("Input PhoneList");
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    if (number > 0)
                        user.Phonelist.Add(number);
                };

            } while (number >0);
            PhoneList.Add(iD, user);
        }
    }
}
