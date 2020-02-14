using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_conditionals
{
    [TestClass]
    public class conditional_examples
    {
        [TestMethod]
        public void ifstatement()
        {
            bool userishungry = true;
            if (userishungry)
            {
                Console.WriteLine("Eat something ya dummy");
            }
            int hours = 1;
            if (hours < 16)
            {
                Console.WriteLine("Are you even trying");
            }
        }
        [TestMethod]
        public void ifelsestatements()
        {
            bool choresaredone = false;
            if (choresaredone)
            {
                Console.WriteLine("Have fun at the movies");

            }
            else
            {
                Console.WriteLine("do ya chores ya dirty bird");
            }
        }
        [TestMethod]
        public void switchybois()
        {
            int input = 1;
            switch (input)
            {
                case 1:
                    Console.WriteLine("Hello");
                    break;
                case 2:
                    Console.WriteLine("what u doin");
                    break;
                default:
                    Console.WriteLine("Yarr here there be defaults");
                    break;
            }

        }
        [TestMethod]
        public void ternaries()
        {
            int age = 42;
            bool isadult = (age > 17) ? true : false;
            Console.WriteLine($"age is over 17: {isadult}");
            int numone = 10;
            int numtwo = (numone == 10) ? 30 : 20;
            Console.WriteLine(numtwo);

            bool istuesday = DateTime.Now.DayOfWeek.ToString() == "Tuesday";
            Console.WriteLine($"Today is " + (istuesday ? "Tuesday" : "not Tuesday"));
        }

    }
}
