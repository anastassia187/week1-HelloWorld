using System;

namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string userFirstname = Console.ReadLine();
            Console.WriteLine("what is your last name?");
            string userLastname = Console.ReadLine();

            Console.WriteLine($"Hello, {userFirstname} {userLastname}!");//string iterpolation

            //Console.WriteLine("Hello, " + userFirstname + " " + userLastname + "!");//string concantenation

        }
    }
}
