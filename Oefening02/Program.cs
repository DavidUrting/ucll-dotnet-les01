using Oefening01;
using System;

namespace Oefening02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Greeter greeter = new Greeter();

            Console.WriteLine("Wat is uw naam?");
            string who = Console.ReadLine();

            string greeting = greeter.Greet(who);
            Console.WriteLine(greeting);
        }
    }
}
