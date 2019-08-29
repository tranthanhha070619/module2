using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    class Bai36
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int a, b;
            Console.WriteLine("nhập số a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("nhâp số b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((a >= -10 && b >= -10 || b <= 10 && a <= 10));
            Console.ReadLine();
        }
    }
}