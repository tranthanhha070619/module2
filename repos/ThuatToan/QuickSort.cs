using System;
using System.Collections.Generic;
using System.Text;

namespace ThuatToan
{
   public  class QuickSort
    {
        public static int[] arr = { 1, 7, 8, 9, 4, 5, 6, 3 };
        public int n = 8;
        public static void Main()
        {
            Quick(0,7);
        }
        public static void swap(int a,int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public static void Quick(int left, int right)
        {
            int x = arr[(left + right)/ 2];
            int i = left;
            int j = right;
            do
            {
                while (arr[i] < x)
                    i++;
                while (arr[j] > x)
                    j--;
                if (i <= j)
                {
                    swap(arr[i], arr[j]);
                    i++;
                    j--;
                }
            } while (i < j);
            if (left < j)
                Quick(left, j);
            if (i < right)
                Quick(i, right);
            Console.WriteLine(string.Join(",", arr));
        }
       
    }
}
