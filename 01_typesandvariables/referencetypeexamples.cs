using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_typesandvariables
{
    [TestClass]
    public class referencetypeexamples
    {
        [TestMethod]
        public void strings()
        {
            string firstname = "Arthur";
            string lastname = "robinson";
            string concat = firstname + " " + lastname;
            Console.WriteLine(concat);

            string compositename = string.Format("Waddup {0} {1}.",firstname,lastname);
            Console.WriteLine(compositename);

            string interpolation = $"{firstname} {lastname}";
            Console.WriteLine(interpolation);
        }
        [TestMethod]
        public void collections()
        {
            string stringexample = "helloworld :(";
            string[] stringarray = { "hello", "world", "why", "is it", "always", stringexample, "?" };
            string thirditem = stringarray[2];
            Console.WriteLine(thirditem);

            stringarray[0] = "what's up";
            Console.WriteLine(stringarray[0]);

            List<string> listofstrings = new List<string>();//why no list
            List<int> listofints = new List<int>();

            listofstrings.AddRange(stringarray);
            listofints.Add(32);
            listofstrings.Add("waddup tho");

            Queue<string> firstinfirstout = new Queue<string>();
            firstinfirstout.Enqueue("I'm first you loser.");
            firstinfirstout.Enqueue("I'm next you ass.");
            string firstitem = firstinfirstout.Dequeue();

            Dictionary<int, string> keyandvalue = new Dictionary<int, string>();
            keyandvalue.Add(22, "string");
            string value22 = keyandvalue[22];
            Console.WriteLine(value22);

            SortedList<int, string> sortedkeyandvalue = new SortedList<int, string>();
            HashSet<int> uniquelist = new HashSet<int>();
            Stack<string> lastinfirstout = new Stack<string>();
        }
        [TestMethod]
        public void classes()
        {
            Random rng = new Random();
            int randomnumber = rng.Next();
            Console.WriteLine(randomnumber);
        }
    }

}
