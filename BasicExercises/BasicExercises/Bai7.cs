using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    class Bai7
    {
        public static void Main(string[] args)
        {
            int a, b;

            Console.Write("Nhap so a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap so b: ");
            b = Convert.ToInt32(Console.ReadLine());

            int total = a + b;
            int Brand = a - b;
            int Accumulated = a * b;
            int share = a / b;
            int percent = a % b;

            Console.WriteLine("Tong cua 2 so la: " + total + "\n");
            Console.WriteLine("Hieu cua 2 so la: " + Brand + "\n");
            Console.WriteLine("Tich cua 2 so la: " + Accumulated + "\n");
            Console.WriteLine("Chia cua 2 so la: " + share + "\n");
            Console.WriteLine("Phan tram cua 2 so la: " + percent + "\n");
            Console.ReadKey();
        }
    }
}
