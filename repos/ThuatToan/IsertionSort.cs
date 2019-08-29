using System;
using System.Collections.Generic;
using System.Text;

namespace ThuatToan
{
  public  class IsertionSort
    {
        public static int[] a = {7,8,9,4,5,7,8,4,5,7,1,2 };
       public static void swap(int []a,int i , int j)
        {
            int k = a[i];
            a[i] = a[j];
            a[j] = k;
        }
        public static void Main()


        {
            
            Insertion(a);
        }
        public static void Insertion(int []a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i; j > 0 && a[j -1] > a[j];--j)
                {
                    swap (a,j -1, j) ;
                }
            }
            Console.WriteLine(string.Join(",", a));
        }
    }
}
