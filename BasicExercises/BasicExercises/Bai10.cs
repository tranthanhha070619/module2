using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    class Bai10
    {
        public static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("Nhap so a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap so b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap so c: ");
            c = Convert.ToInt32(Console.ReadLine());

            Console.Write("{0},{1} and {2},(x+y)*z is {3} and x*y + y*z is {4}\n\n", a, b, c, ((a + b) * c), (a*b + b*c));
            Console.ReadLine();
        }
    }
}
