using System;

namespace student
{
    class Program
    {
        static void Main(string[] args)
        {
            var Mytuple = new Tuple<string, int, string, string, string, string>("bo", 1, "2", "muoi", "hai","hay");
            Console.WriteLine(Mytuple);
        }
    }
}
