using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_challenges
{
    public class KomodoInsurance
    {
        public KomodoInsurance()
        {

            CustomerID = UserID();

        }
        public KomodoInsurance(string lastname, int age, DateTime enrollmentdate)
        {
            LastName = lastname;
            Age = age;
            EnrollmentDate = enrollmentdate;
        }
        public string CustomerID { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public int YearsAsCustomer
        {
            get
            {
                //TimeSpan timeSpan = DateTime.Now - EnrollmentDate;
                //double totalTime = timeSpan.TotalDays / 365.25;
                //int years = Convert.ToInt32(Math.Floor(totalTime));
                //Console.WriteLine(years);
                //return years;

                double totalTime = (DateTime.Now - EnrollmentDate).TotalDays/365.25;
                return Convert.ToInt32(Math.Floor(totalTime));
            }
        }



        
        public string UserID()
        {
            var chars = "abcdefghijklmnopqrstuvwxyz1234567890";
            int counter = 0;
            int length = chars.Length;
            string password = "";
            Random rand = new Random();
            int randomalpha = rand.Next(1, length);
            char alphanum = chars[randomalpha];


            while (counter < 10)
            {


                password += alphanum;
                counter += 1;


            }

            string Password = (string)password;
            return Password;
        }
    }
}
