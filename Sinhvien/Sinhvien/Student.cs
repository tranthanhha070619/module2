using System;
using System.Collections.Generic;
using System.Text;

namespace Sinhvien
{
    class Student : Person
    {
        public void GoToClass()
        {
            Console.WriteLine("Toi se den den lop");
        }
        public void ShowAge()
        {
            Console.WriteLine("Tuoi cua toi: {} year old", getAge());
        }
        public override void greet()
        {
            Console.WriteLine("Con hon cha");
        }
    }
}
