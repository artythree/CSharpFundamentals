using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_inheritance_classes
{
    public class Address
    {
        

        public int StreetNumber { get; set; }
        public string AptNumber { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }

        /// <summary>
        /// 
        /// 
        /// 
        /// 
        /// </summary>
        /// <returns></returns>

        public override string ToString()
        {
            return $"{StreetNumber} {StreetName}, {City}, {State}, {ZipCode}";
        }
    }
}
