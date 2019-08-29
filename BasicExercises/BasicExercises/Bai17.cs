using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    class Bai17
    {
        public static void Main(string[] args)
        {
            string str;
            Console.Write("Nhap chuoi vao: ");
            str = Console.ReadLine();
            if(str.Length >= 1)
            {
                var s = str.Substring(0, 1);
                Console.WriteLine(s + str + s);
                Console.ReadLine();
            
            }
        }
    }
}
