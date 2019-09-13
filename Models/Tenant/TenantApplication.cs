using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LA.Models.Tenant
{
    public class TenantApplication
    {
        public int TenantApplicationPK { get; set; }
        public int TenantApplicationStatusFK { get; set; }
        public PossibleTenant MainTenant { get; set; }
        public List<PossibleTenant> OtherTenants { get; set; }        
        public bool Active { get; set; }
    }
}
