using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloKelly
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string userName;
            Console.WriteLine("What is your name?");
            userName=Console.ReadLine();
            Greeting(userName);
            Console.Write("Press <Enter> to exit... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }

        }
        static void Greeting(string userName )
        {
            Console.WriteLine("Nice to meet you, " + userName + "!");

        }
    }
}
