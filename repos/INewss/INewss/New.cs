using System;
using System.Collections.Generic;
using System.Text;

namespace INewss
{
    class New
    {
        private int id;
        private string title;
        private string pulishDate;
        private string author;
        private string content;
        protected float averageRate;

        int[] RateList = new int[3];
        

        protected int Id { get => id; set => id = value; }
        protected string Title { get => title; set => title = value; }
        protected string PulishDate { get => pulishDate; set => pulishDate = value; }
        protected string Author { get => author; set => author = value; }
        protected string Content { get => content; set => content = value; }
        
        protected float AverageRate { get => averageRate; }
        public void Display()
        {
            Console.WriteLine("print Id: {0} print Title: {1} print PulishDate: {2} print Author: {3} print Content: {4} print AverageRate: {5} print: {6}"
                ,Id,Title,PulishDate,Author,Content,AverageRate);
        }
        public float Calculate()
        {
            var post  = 0;
            for(int i = 0; i < RateList.Length; i++)
            {
                post += RateList[i];
            }
            return  averageRate = post / RateList.Length;
        }
        public void Menu()
        {
            var option = 0;
            do
            {

                Console.WriteLine("********************");
                Console.WriteLine("1. Insert news");
                Console.WriteLine("2. View list news");
                Console.WriteLine("3. Average rate");
                Console.WriteLine("4. Exit");
                Console.WriteLine("********************");


                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    option = number;
                }
            } while (option <= 0 || option >= 5);
           
        }
        public static void Process( int number)
        {
            switch (number)
            {
                case 1:
                    {
                        Console.WriteLine("Insert news ");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("View list news");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Average rate");
                        break;
                    }
                case 4:
                default:
                    {
                        Environment.Exit(Environment.ExitCode);
                        break;
                    }
            }
          
        }
    }
}
