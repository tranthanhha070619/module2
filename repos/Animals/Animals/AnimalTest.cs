using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    class AnimalTest
    {
        public static  void Main()
        {
            Console.WriteLine("*********Chicken***********");
            var gaCon = new Chicken();
            Console.WriteLine("Ga con keu:{0}", gaCon.MakeSound());
            Console.WriteLine("ga con an: {0}", gaCon.HowToEat());


            Console.WriteLine("**********Tiger**********");
            var purma = new Tiger();
            Console.WriteLine("Con cap keu: {0}", purma.MakeSound());
            

            Console.WriteLine("*********Apple***********");
            var china = new Apple();
            Console.WriteLine("An tao: {0}", china.HowToEat());

            Console.WriteLine("*********Orange***********");
            var mong = new Orange();
            Console.WriteLine("An Cam: {0}", mong.HowToEat());

            Console.ReadKey();
        }
    }
}
