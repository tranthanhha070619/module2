using System;
using System.Collections.Generic;
using System.Text;

namespace ArrInputs
{
   public class ArrInput
    {
        public static void Main()
        {
            int i, j, sum = 0, sum1 = 0, n,m =0  ;
           

            Console.Write("Nhap kich co ma tran: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[,] arr1 = new int[n, n];
            Console.Write("Nhap cac phan tu: ");
            for(i = 0; i < n; i++)
            {
                for(j = 0; j < n; j++)
                {
                    Console.Write("Phan tu - {0},{1}: ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                    //if (i == j) sum = sum + arr1[i, j];
                }
            }
            Console.Write("in ma tran:\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (i ==j )
                    {
                        sum = sum + arr1[i, j];
                    }
                    if((i+j) == n-1)
                    {
                        sum1 += arr1[i,j];
                    }
                    Console.Write ($" { arr1[i,j] }");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Tong cac phan tu duong cheo chinh la: " + sum);
            Console.WriteLine("tong cac phan tu duong cheo phu la: " + sum1);
            Console.ReadKey();
        }
    }
}
