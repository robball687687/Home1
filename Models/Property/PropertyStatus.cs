using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LA.Models.Property
{
    public class PropertyStatus
    {
        public int PropertyStatusPK { get; set; }
        public string StatusValue { get; set; }
        public bool Active { get; set; }
    }
}
