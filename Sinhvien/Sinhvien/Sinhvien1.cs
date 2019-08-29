using System;
using System.Collections.Generic;
using System.Text;

namespace Sinhvien
{
    class Sinhvien1
    {
        public static void Main() {
            var Ha = new Person();
            Console.WriteLine("**************");
            Ha.greet();
            var Nam = new Person();
            Console.WriteLine("**************");
            Nam.setAge(21);
            Console.WriteLine(Nam.getAge());
            Nam.greet();
            var Mai = new Student();
            Console.WriteLine("**************");
            Mai.setAge(30);
            Console.WriteLine(Mai.getAge());
            Mai.greet();
            

            

            
        }
    }
}
