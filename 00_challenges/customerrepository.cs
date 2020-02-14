using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_challenges
{
    public class customerrepository 
    {
        private List<KomodoInsurance> _CustomerList = new List<KomodoInsurance>();

        public void AddCustomerToList(KomodoInsurance newDragon)
        {
            _CustomerList.Add(newDragon);
        }
        public string GoldCustomer(KomodoInsurance customer)
        {

            if (customer.YearsAsCustomer > 5)
            {
                return "Thank you for being a Gold Member!";
            }
            else 
            {
                return "Thanks for being a customer, even if you're a noob";
            }


        }
    }
}
