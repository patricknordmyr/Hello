using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pls enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name);

            Console.WriteLine("How many hours did U sleep?");
            int hoursOfSleep = int.Parse(Console.ReadLine());


            Console.WriteLine("Hi, " + name);
            if (hoursOfSleep > 8)
            {
                Console.WriteLine("well rested");
            }
            else
            {
                Console.WriteLine("to bad");

            }
        }
    }
}
