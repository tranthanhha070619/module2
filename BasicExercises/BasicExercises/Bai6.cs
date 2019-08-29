using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    class Bai6
    {
        public static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("nhap a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("nhap b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("nhap c: ");
            c = Convert.ToInt32(Console.ReadLine());

            int multiply = a * b * c;
            Console.WriteLine("Tich 3 so la: " + multiply);
            Console.ReadKey();
        }
    }
}
