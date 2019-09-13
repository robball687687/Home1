using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LA.Models.Property
{
    public class Property
    {
        public int PropertyPK { get; set; }   
        public int PropertyStatusFK { get; set; }
        public string StreetAddress { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Zipcode { get; set; }
        public int TotalUnitCount { get; set; }
        public int OpenUnitCount { get; set; }
        public int FullUnitCount { get; set; }
        public string Description { get; set; }
        public string Comments { get; set; }
        public bool Active { get; set; }
    }
}
