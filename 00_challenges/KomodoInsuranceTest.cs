using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _00_challenges
{
    [TestClass]
    public class KomodoInsuranceTest
    {
        [TestMethod]
        public void KomodoInsurance()
        {
            
            
            KomodoInsurance Dragon = new KomodoInsurance("Urmom", 50000, DateTime.Now);
            ;
            
            Console.WriteLine(Dragon.CustomerID);

           

        }
    }
}
