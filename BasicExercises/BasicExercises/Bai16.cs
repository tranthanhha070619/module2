using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    class Bai16
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(first_last("w3resource"));
            Console.WriteLine(first_last("Python"));
            Console.WriteLine(first_last("x"));
            Console.ReadLine();

        }
        public static string first_last(string ustr)
        {
            return ustr.Length > 1

                ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1,ustr.Length-2) + ustr.Substring(0,2) : ustr;
        }
    }
}
