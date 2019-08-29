using System;
using System.Collections;

namespace ZOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo();
            Console.WriteLine("hello");
            //    Console.WriteLine("Hello World!");
            //}
            //Animal animal = new Animal();
        }

        public static void Demo()
        {
            ArrayList array = new ArrayList();
            array.Add(1);
            array.Add("two");
            array.Add(5.4);
            IList arraylist2 = new ArrayList() { 100, 200 };
            array.AddRange(arraylist2);
            for (int i = 0; i < array.Count; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
