using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_typesandvariables
{
    [TestClass]
    public class valuetypeexamples
    {
        [TestMethod]
        public void Booleans()
        {
            bool isdeclared;
            isdeclared = true;
            bool isinitialized = false;
            // comments because reasons
            /* comments
             comments
             comments
             comments
             */ 
    
        }
        [TestMethod]
        public void Characters()
        {
            char character = 'a';
            char symbol = '&';
            char number = '1';
            char space = ' ';
            char specialcharacter = '\n';//newline
        }
        [TestMethod]
        public void Wholenums()
        {
            byte bytesized = 255;
            sbyte sbytes = -128;
            short willneveruse = 32767;
            Int16 anothershorty = 32767;//it's a short
            int intmin = -2147483648;
            Int32 intmax = -2147483647;//it an int
            long longboi = 9223372036854775807;
            Int64 negativelongboi = -9223372036854775808;

            int max = int.MaxValue; //super fuckin useful
            int a = 15;
            int b = 22;
            int c = 37;
            byte age = 254;

        }
        [TestMethod]
        public void Decimals()
        {
            float floor = 1.045231f;
            double toilandtrouble = 1.789053278907036d; //c# defaults to double for all decimals
            decimal dewey = 1.25789072890457897897897897897897m;

            Console.WriteLine(floor);
            Console.WriteLine(toilandtrouble);
            Console.WriteLine(dewey);

        }
        enum pastrytype { cake, danish, scone, doughnut, tart, croissant}
        [TestMethod]
        public void enums()
        {
            pastrytype myPastry = pastrytype.croissant;
            pastrytype myOTHERpastry = pastrytype.tart;
            Console.WriteLine(myPastry);
            Console.WriteLine(myOTHERpastry);

        }
        [TestMethod]
        public void Structs()
        {
            Int32 age = 42;
            DateTime today = DateTime.Now;
            Console.WriteLine(today);
            DateTime bday = new DateTime(1994, 08, 19);
            Console.WriteLine(bday.ToShortDateString());
        }
        enum digits { one, two, three, four, five }
        [TestMethod]
        public void challenges()
        {
            bool boolol = true;
            string urmom = "urmom";
            int bestnum = 69;
            double pi = 3.14159268;
            char bestchar = '&';

            

            Console.WriteLine(boolol);
            Console.WriteLine(urmom);
            Console.WriteLine(bestnum);
            Console.WriteLine(pi);
            Console.WriteLine(bestchar);
            Console.WriteLine(digits.one);
            
            
        }
    }

}
