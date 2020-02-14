using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_inheritance_classes
{
    public class Employee : Person
    {
        public int EmployeeID { get; set; }
        public DateTime HireDate { get; set; }
        public int YearsOfService
        {
            get
            {
                TimeSpan timeserved = DateTime.Now - HireDate;
                double totalyears = timeserved.Days / 365.25;
                int years = Convert.ToInt32(Math.Floor(totalyears));
                return years;
            }
           

        }

        
        

    }
    public class HourlyEmployee : Employee
    {
        public decimal HourlyWage { get; set; }
        public double HoursWorked { get; set; }
    }
    public class SalariedEmployee : Employee
    {
        public decimal Salary { get; set; }
    }
}
