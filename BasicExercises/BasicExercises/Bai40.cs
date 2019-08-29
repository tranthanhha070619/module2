using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    class Bai40
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Nhap x:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap y:");
            int y = Convert.ToInt32(Console.ReadLine());
            int n = 20;
            var val1 = Math.Abs(x - n);
            var val2 = Math.Abs(y - n);
            Console.WriteLine("Gia tri gan voi 20 la: ");
            Console.WriteLine(val1 == val2 ? 0 : (val1 < val2 ? x : y));
            Console.ReadLine();
        }
    }
}
