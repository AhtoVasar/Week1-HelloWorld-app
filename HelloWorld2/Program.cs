using System;

namespace HelloWorld2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            String UserName;
            UserName = Console.ReadLine();

            Console.WriteLine("Hello, " + UserName);

            Console.Read();

        }
    }
}
