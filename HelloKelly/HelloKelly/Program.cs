using System;

namespace HelloKelly
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            Console.WriteLine("What is your name?");
            userName = Console.ReadLine();
            Greeting(userName);
            Console.Write("Press <Enter> to exit... ");
            Console.ReadLine();
        }

        static void Greeting(string name )
        {
            Console.WriteLine($"Nice to meet you, {name} !");
        }
    }
}
