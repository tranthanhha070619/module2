using System;
using System.Collections.Generic;
using System.Text;

namespace Thilaimodul2.Bai1
{
   
   public static class Bai1
    {
        public static int[][] CreateMatrix;
        public static void Main()
        {
            Matrix();
            FindMax();
            ShowMatrix(CreateMatrix);
        }
        
        public static void Matrix()
        {
            Console.WriteLine("Nhap n: ");
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap m: ");
            var m = int.Parse(Console.ReadLine());

            CreateMatrix = new int[n][];
            for (int i = 0; i < n; i++)
            {
                CreateMatrix[i] = new int[m];
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine("A: [{0} {1}]", i, j);
                    CreateMatrix[i][j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public static int FindMax()
        {
            int[] arr = new int[0];
            var max = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
               if( arr[i]>max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
        public static void ShowMatrix(int[][] arr)
        {
            
            Console.Write("\nMa tran tam giac duoi cua ma tran da cho la:\n");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (i >= j)
                        Console.Write("{0}  ", arr[i][j]);
                }
            }
            Console.Write("\n\n");
            Console.ReadKey();

        }
    }
}
