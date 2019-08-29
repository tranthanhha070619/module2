using System;
using System.Collections.Generic;
using System.Text;

namespace ThuatToan
{
  public  class mang
    {
        public static void Main()
        {
          
            
           
            int[] A = { 1, 7, 5, 1, 5, 4, 8, 7, 5 };
            Console.WriteLine("{0}", Array(A, A.Length));
        }
        public static long Array(int[] A,int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return A[n - 1];
            return Array(A, n - 1) + A[n - 1];
        }
    }
}
