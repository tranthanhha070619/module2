using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    class Bai21
    {
        public static void Main(string[] args)
        {
            int a, b;

            Console.Write("Nhap a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kiem tra: ");
            Console.WriteLine(a == 20 || b == 20 || a + b == 20);
            Console.ReadLine();
        }
      
    }
}
