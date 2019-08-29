using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    class Bai8
    {
        public static void Main(string[] args)
        {
            int number;
            int Accumulated;

            Console.Write("Nhap numeber: ");
            number = Convert.ToInt32(Console.ReadLine());

            Accumulated = number * 1;
            Console.WriteLine("{0} x {1} = {2}", number, 1, Accumulated);

            Accumulated = number * 2;
            Console.WriteLine("{0} x {1} = {2}", number, 2, Accumulated);

            Accumulated = number * 3;
            Console.WriteLine("{0} x {1} = {2}", number, 3, Accumulated);

            Accumulated = number * 4;
            Console.WriteLine("{0} x {1} = {2}", number, 4, Accumulated);

            Accumulated = number * 5;
            Console.WriteLine("{0} x {1} = {2}", number, 5, Accumulated);

            Accumulated = number * 6;
            Console.WriteLine("{0} x {1} = {2}", number, 6, Accumulated);

            Accumulated = number * 7;
            Console.WriteLine("{0} x {1} = {2}", number, 7, Accumulated);

            Accumulated = number * 8;
            Console.WriteLine("{0} x {1} = {2}", number, 8, Accumulated);

            Accumulated = number * 9;
            Console.WriteLine("{0} x {1} = {2}", number, 9, Accumulated);

            Accumulated = number * 10;
            Console.WriteLine("{0} x {1} = {2}", number, 10, Accumulated);

            Console.ReadLine();


        }
    }
}
