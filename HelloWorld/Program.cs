using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "a;slkdjf";
            int myAge;
            bool isOld = false;

            //Get user name
            Console.WriteLine("Hello, what is your name?");
            myName = Console.ReadLine();
            Console.WriteLine("Hello, " + myName + "nice to meet you.");

            //Get user age
            Console.WriteLine(myName + "please enter your age.");
            string ageStr = Console.ReadLine();
            myAge = int.Parse(ageStr);

            if (myAge >= 60)
            {
                Console.WriteLine("Wow " + myName + " you're pretty old!");

                Console.WriteLine("I'm gonna need your birth month since you're going to die soon");
                string monthStr = Console.ReadLine();
                int birthMonth = int.Parse(monthStr);
                if (birthMonth >= 9 && birthMonth <= 11)
                {
                    Console.WriteLine("You were a fall baby");
                }
                else if (birthMonth >= 5)
                {
                    Console.WriteLine("You were a summer baby");
                }
                else if (birthMonth >= 3)
                {
                    Console.WriteLine("You were a spring baby");
                }
                else if (birthMonth == 12 || birthMonth < 3)
                {
                    Console.WriteLine("You were a winter baby");
                }
            }
            else if (myAge >= 25 && myAge< 60)
            {
                Console.WriteLine("You're middle aged " + myName);
            }
            else
            {
                Console.WriteLine("You're still pretty young " + myName);
            }
        }
    }
}
            