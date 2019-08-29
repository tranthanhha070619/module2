using System;
using System.Collections.Generic;
using System.Text;
using Inew.Models;

namespace Inew
{
 public   class NewTest
      
    {
        public static News news = new News();
        public static int Id = 0;
        public static void Main()
        {
            InitMenu();
          
        }
        public static void InitMenu()
        {
            int option = 0;
            do
            {
                Console.WriteLine("Management News");
                Console.WriteLine("1. Insert news");
                Console.WriteLine("2. View list news");
                Console.WriteLine("3. Average rate");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Please select an option");
                Console.Write("Option: ");
                if (int.TryParse(Console.ReadLine(), out var number)) { 
                    option = number;
                }
               
            }
            while (option > 4 || option <= 0);
            Process(option);
        }
        public static void Process(int seleted)
        {
            switch (seleted)
            {
                case 1:
                    {
                        Console.WriteLine("Intest news: ");
                        Id = Id + 1;
                        InsertNews();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("View list news: ");
                        news.Display();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Averaga Rate: ");
                        break;
                    }
                case 4:
                default:
                    {
                        Environment.Exit(Environment.ExitCode);
                        break;
                    }
            }
            InitMenu();
            
        }
        public static void InsertNews()
        {
            news.Id = Id;
            Console.Write("Input chuc vu: ");
            news.Title = Console.ReadLine();

            Console.Write("Input ngay xuat ban: ");
            news.PublishDate = Console.ReadLine();

            Console.Write("Input tac gia: ");
            news.Author = Console.ReadLine();

            Console.Write("Input noi dung: ");
            news.Content = Console.ReadLine();

            Console.Write("Input tyle: ");
            for(int i = 0; i < news.RateList.Length; i++)
            {
                Console.Write("Input rate {0}", i + 1);
                news.RateList[i] = int.Parse(Console.ReadLine());
            }
            news.InsertNews(Id);
        }
    }
}
