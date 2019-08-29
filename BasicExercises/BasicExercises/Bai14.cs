using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    class Bai14
    {
        public static void Main(string[] args)
        {
            int celsius;
            Console.Write("Nhap do vao: ");
            celsius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}", celsius + 273);

            Console.WriteLine("{0}", celsius * 18 / 10 + 32);

            Console.ReadLine();
        }
    }
}
