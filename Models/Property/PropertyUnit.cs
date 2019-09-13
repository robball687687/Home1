using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LA.Models.Property
{
    public class PropertyUnit
    {
        public int PropertyUnitPK { get; set; }
        public int PropertyFK { get; set; }
        public int PropertyStatusFK { get; set; }
        public DateTime DateAvailable { get; set; }
        public DateTime DateRollover { get; set; }
        public string Description { get; set; }
        public string Comments { get; set; }
        public bool Active { get; set; }
    }
}
