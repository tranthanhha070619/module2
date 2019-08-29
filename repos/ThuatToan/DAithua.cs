using System;
using System.Collections.Generic;
using System.Text;

namespace ThuatToan
{
    class DAithua
    {
        public static void Main()
        {
            Console.WriteLine("Input a= ");
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0},{1}", n, Giaithua(n));
            var m = int.Parse(Console.ReadLine());
            Console.WriteLine("{0},{1}", m, Giaithua1(m));
            Console.ReadLine();
        }
        public static long Giaithua(int n)
        {
            if (n == 1 || n == 0)
            {
                return 1;
            }


            return n * Giaithua(n - 1);

        }
        public static long Giaithua1(int m)
        {
            long sum = 1;
            for(int i = 1; i < m; i++)
            {
                sum *= i;
            }
            return sum;
        }
        
        
    }
}
