using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Methods
{
    [TestClass]
    public class methodexamples
    {
        
        //1     2       3
        public void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
        
        
        public int Add(int numone, int numtwo)
        {
            int numthree = numone + numtwo;
            Console.WriteLine(numthree);
            return numthree;
        }

        public int Sub(int numone, int numtwo)
        {
            int diff = numone - numtwo;
            Console.WriteLine(diff);
            return diff;
        }

        public int Mult(int numone, int numtwo)
        {
            int mult = numone * numtwo;
            Console.WriteLine(mult);
            return mult;
        }

        public int Div(int numone, int numtwo)
        {
            int div = numone * numtwo;
            Console.WriteLine(div);
            return div;
        }

        public long Fact(long num)
        {
            long fact = 1;
            while(num > 1)
            {
                fact *= num;
                num -= 1;
            }
            Console.WriteLine(fact);
            return fact;
        }

        private int CalculateAge(DateTime BDay)
        {
            TimeSpan agespan = DateTime.Now - BDay;
            double totalageinyears = agespan.TotalDays / 365.25;
            int years = Convert.ToInt32(Math.Floor(totalageinyears));
            Console.WriteLine(years);
            return years;
        }


        [TestMethod]
        public void methodexecution()
        {
            string x = "alpha";
            SayHello(x);

            int y = 36;
            int z = 24;
            int w =Add(y, z);
            DateTime birthday = new DateTime(1944, 12, 24);
            CalculateAge(birthday);
            Fact((long)8);



        }
    }
}
