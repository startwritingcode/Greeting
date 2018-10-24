using System;

namespace Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name: ");
            string userName = Console.ReadLine();
            string greeting = "I'm glad you are learning C# today, ";
            string fullGreeting = greeting + userName;
            Console.WriteLine(fullGreeting);
        }
    }
}
