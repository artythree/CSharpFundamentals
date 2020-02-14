using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_inheritance_classes
{
    public class Person
    {
        public Person()
        {
            Address = new Address();
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}
