using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    class Bai35
    {
        public static void Main(string[] args)
        {
            int number, number2;
            Console.WriteLine("Nhap so nguyen < 100: ");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhap so nguyen > 200: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((number < 100 && number2 > 200));
            Console.ReadKey();
             
        }
    }
}
