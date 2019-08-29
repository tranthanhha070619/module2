using System;
using System.Collections.Generic;
using System.Text;

namespace ThuatToan
{
   public class Bubble
    {
        public static int[] array = { 1, 2, 5, 7, 8, 4, 6, 10 };
        public static void BubbleSort(int[] array)
        {
            int temp;
            for (int i = 0; i< array.Length -1; i++)
            {
                for(int j = array.Length - 1;j > i; j--)
                {
                    if(array[j]< array[j - 1])
                    {
                        temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(",", array));
        }
        public static void Main()
        {
            BubbleSort(array);
        }
    }
}
