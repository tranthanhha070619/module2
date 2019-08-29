using System;

namespace BasicExercises
{
    class Bai31
    {
        public static void Main(string[] args) { 

        int[] number = { 1, 4, 5, 8, 9 };
            int[] count = { 1, 4, 5, 8, 7 };


            Console.WriteLine("\narray: [{0}]", string.Join(",", number));
            Console.WriteLine("count: [{0}]", string.Join(",", count));

            Console.WriteLine("\n tich cac phan tu tuong ung cua mang la: ");

            for(int i = 0;i <number.Length; i++)
            {
                Console.WriteLine(number[i] * count[i] + " ");
            }

            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
