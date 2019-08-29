using System;

namespace StopWatchs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = new StopWatch();
           Console.WriteLine( n.Start());
            
           Console.WriteLine( n.Stop());
            n.getElapsedTime();
            Console.WriteLine(n.getElapsedTime() + " milisecond");
        }
    }
}
