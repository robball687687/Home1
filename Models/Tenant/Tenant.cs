using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LA.Models.Tenant
{
    public class Tenant
    {
        public int TenantPK { get; set; }
        public int UserFK { get; set; }
        public bool Active { get; set; }
    }
}
