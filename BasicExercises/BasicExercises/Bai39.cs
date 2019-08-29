using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    class Bai39
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("nhap so a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("nhap so b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("nhap so c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("so co gia tri lon nhat la: " + Math.Max(a, Math.Max( b, c)));
            Console.WriteLine("so co gia tri nho nhat la: " + Math.Min(a, Math.Min(b, c)));

            Console.ReadLine();

        }
    }
}
