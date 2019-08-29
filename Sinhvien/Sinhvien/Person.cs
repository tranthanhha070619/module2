using System;
using System.Collections.Generic;
using System.Text;

namespace Sinhvien
{
    class Person
    {
        private int age;

        public void setAge(int n)
        {
            this.age = n;
        }
        public int getAge()
        {
            return age;
        }
        public virtual void greet()
        {
            Console.WriteLine("Xin chao!");
           
        }
       
    }
} 
