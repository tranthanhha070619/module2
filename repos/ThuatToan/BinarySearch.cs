using System;
using System.Collections.Generic;
using System.Text;

namespace ThuatToan
{

   public class BinarySearch
    {
        public static int[] arr = { 1, 5, 4, 7, 8, 9, 6, 3, 2 };
        public static int Binary(int value, int[] arr)
        {
            int left = 0, right = arr.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (value == arr[mid])
                {
                    return arr[mid];
                }
                else if (value > arr[mid])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
               
            }
            return -1;
        }
        public static void Main()
        {
            if (Binary(15,arr) != -1)
            {
                Console.WriteLine("co tim thay");
            }
            else
            {
                Console.WriteLine("ko  tim thay");
            }
            //Console.WriteLine("Nhap so: ");
            //int value = int.Parse(Console.ReadLine());

            //Binary(value,arr);
        }
    }
}
