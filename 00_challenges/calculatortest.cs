using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _00_challenges
{
    [TestClass]
    public class calculatortest
    {
        [TestMethod]
        public void additiontest()
        {
            Calculator variable = new Calculator();
            
            Console.WriteLine(variable.Addition(12.5,15.709));
        }
    }
}
