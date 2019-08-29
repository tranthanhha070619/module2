using System;

namespace Fans
{
    class Program
    {
        static void Main(string[] args)
        {
            var Fan1 = new Fan();
            Fan1.Speed = 3;
            Fan1.Radius = 10;
            Fan1.Color = "yelow";
            Fan1.On = true;
            Console.WriteLine("quat chay: {0},{1},{2},{3}", Fan1.Speed, Fan1.Radius, Fan1.Color, Fan1.On);

            var Fan2 = new Fan();
            Fan2.Speed = 2;
            Fan2.Radius = 5;
            Fan2.Color = "blue";
            Fan2.On = false;
            Console.WriteLine("Quat tat: {0},{1},{2},{3}", Fan2.Speed, Fan2.Radius, Fan2.Color, Fan2.On);
            Console.ReadKey();
        }
    }
}
