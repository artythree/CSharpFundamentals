using System;
using System.Collections.Generic;
using _08_inheritance_classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08_inheritance
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void SetAddress()
        {
            Person urMom = new Person();
            urMom.Address.StreetName = "SoFat Lane";
            urMom.Address.StreetNumber = 42069;

            Customer lilNicky = new Customer();
            lilNicky.Address.StreetName = "fake street";
            lilNicky.Address.StreetNumber = 42069;

            Console.WriteLine(urMom.Address);
            Console.WriteLine(lilNicky.Address);
        }
            [TestMethod]
        public void CustomerIsPremium()
        {
            Customer JimBob = new Customer();
            JimBob.IsPremium = true;

            Console.WriteLine(JimBob.IsPremium);
            Console.WriteLine(JimBob.GetType());

            Assert.IsTrue(JimBob.IsPremium);
        }
        [TestMethod]
        public void EmployeeTests()
        {
            Employee Jarvis = new Employee();
            HourlyEmployee tony = new HourlyEmployee();
            SalariedEmployee Friday = new SalariedEmployee();

            List<Employee> allEmployees = new List<Employee>();
            allEmployees.Add(Jarvis);
            allEmployees.Add(tony);
            allEmployees.Add(Friday);

            foreach (Employee wageslave in allEmployees)
            {
                if (wageslave.GetType() == typeof(SalariedEmployee))
                {
                    SalariedEmployee sEmployee = (SalariedEmployee)wageslave;
                    Console.WriteLine("Irrelevant");
                }
                else if (wageslave is HourlyEmployee HourlyWorker)//pattern matching
                {
                    Console.WriteLine("this is an hourly employee");
                    Console.WriteLine(HourlyWorker.HourlyWage);
                    

                }
                else
                {
                    Console.WriteLine("WHO KNOWS");
                }
            }
        }
    }


}
