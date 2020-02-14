using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Operators
{
    [TestClass]
    public class Operatorexamples
    {
        [TestMethod]
        public void arithmeticoperators()
        {
            int x = 23;
            int y = 24;

            int sum = x + y;
            int sub = x - y;
            double div = (double)x / (double)y;//casting
            int rem = x % y;
            int mult = x * y;
            int exp = x ^ y;

            DateTime now = DateTime.Now;
            DateTime someday = new DateTime(1978, 1, 1);
            TimeSpan timespan = now - someday;
            Console.WriteLine(timespan.Days);
        }
        [TestMethod]
        public void comparisonoperators()
        {
            int age = 67;
            string name = "doggo";
            bool equals = age == 41;
            bool userisadam = name == "adam";
            Console.WriteLine("User is 41: " + equals);
            Console.WriteLine("User is Adam: " + userisadam);

            bool notequal = age != 122;
            bool notjustin = name != "justin";

            Console.WriteLine($"User is not 122: {notequal}");
            Console.WriteLine($"user is not justin: {notjustin}");

            List<string> firstlist = new List<string>();
            firstlist.Add(name);

            List<string> secondlist = new List<string>();
            secondlist.Add(name);

            bool listsareequal = firstlist == secondlist;
            Console.WriteLine($"The lists are the same: {listsareequal}");

            bool greaterthan = age > 12;
            bool greaterequal = age >= 40;
            bool lessthan = age < 12;
            bool lessequal = age <= 40;
            bool orvalue = lessthan || equals;

            bool tort = true || true;
            bool torf = true || false;
            bool fort = true || true;
            bool forf = false || false;
            Console.WriteLine($"true or true :{tort}");
            Console.WriteLine($"true or false :{torf}");
            Console.WriteLine($"false or true :{fort}");
            Console.WriteLine($"false or false :{forf}");

            bool tat = true && true;
            bool taf = true && false;
            bool fat = false && true;
            bool faf = false && false;
            Console.WriteLine($"true And true :{tat}");
            Console.WriteLine($"true And false :{taf}");
            Console.WriteLine($"false And true :{fat}");
            Console.WriteLine($"false and false :{faf}");

        }

    }
}
