using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    class Bai27
    {
        public static void Main(string[] args)
        {
            int n, sum;
            Console.Write("Nhap day chu so: ");
            n = Convert.ToInt32(Console.ReadLine());
            sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            Console.WriteLine("tong chu so cua cac so nguyen la: " + sum);
            Console.ReadLine();
        }

    }
}
