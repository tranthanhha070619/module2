using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    class Bai32
    {
        public static void Main(string[] args)
        {
            string str;
            
            Console.WriteLine("Nhap chuoi vao: ");
            str = Console.ReadLine();
            if(str.Length > 4)
            {
                Console.WriteLine(str.Length < 4 ? str + str + str : str.Substring(str.Length - 4) + str.Substring(str.Length - 4) + str.Substring(str.Length - 4) + str.Substring(str.Length - 4));
                Console.ReadLine();
            }
        }
    }
}
