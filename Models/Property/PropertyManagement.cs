using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LA.Models.Property
{
    public class PropertyManagement
    {
        public int PropertyManagementPK { get; set; }
        public int UserFK { get; set; }
        public int PropertyFK { get; set; }     
        public bool Active { get; set; }
    }
}
