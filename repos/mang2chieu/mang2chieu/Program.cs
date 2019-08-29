using System;

namespace mang2chieu
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine(test("kgjfghfd "));
            Console.ReadLine();
        }
        public static string test( string he) {
            for (int i = 0; i < he.Length; i++)
            {
                if (he.Length < 3)
                {
                    return he + he + he;
                }
               
            }

        }
    }
}
