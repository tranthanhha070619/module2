using System;
using System.Collections.Generic;
using System.Text;

namespace ThuatToan
{
    public class selection
    {
       public static int[] A = { 1, 5, 4, 7, 8, 9, 6, 2, 4 };
        public static void Main() {
            SelectionSort();



        }

        public static void SelectionSort()
        {
            for(int i = 0;i< A.Length - 1; i++)
            {
                var min = A[i];
                var num = i;
                for(int j = i + 1; j< A.Length; j++)
                {
                    if(A[j] < min)
                    {
                        min = A[j];
                        num = j;
                    }

                }
                var tem = A[i];
                A[i] = A[num];
                   A[ num] = tem;
                    
                    
            }
            Console.WriteLine(string.Join(",", A));
        }
    }
}
