using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "a;slkdjf" ;

            Console.WriteLine("Hello, what is your name?");
            myName = Console.ReadLine();
            Console.WriteLine("Hello, " + myName); 
               
        }
    }
}
