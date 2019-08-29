using System;
using System.Collections.Generic;
using System.Text;

namespace ZOO
{
   public abstract class Animal
    {
        private string name;
        private int age;
        private string description;

      
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Description { get => description; set => description = value; }

        public void viewInfo() { }
        

        public Animal() { }
        public Animal(string Name)
        {
            name = Name;
        }
        public Animal( string Name,int Age)
        {
            name = Name;
            age = Age;
        }
        public Animal(string Name,int Age, string Description)
        {
            name = Name;
            age = Age;
            description = Description;
        }

        public abstract void Speak()
        {
            Console.WriteLine("animal speak");
        }

    }
   
}
