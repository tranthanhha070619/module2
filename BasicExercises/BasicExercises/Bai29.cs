using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BasicExercises
{
    class Bai29
    {
        public static void Main(string[] args)
        {
            FileInfo f = new FileInfo("/home/students/abc.txt");
            Console.WriteLine("\nSize of a file: " + f.Length.ToString());
            Console.ReadLine();
        }
    }
}
