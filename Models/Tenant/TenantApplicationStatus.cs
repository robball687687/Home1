using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LA.Models.Tenant
{
    public class TenantApplicationStatus
    {
        public int TenantApplicationStatusPK { get; set; }
        public string TenantApplicationStatusValue { get; set; }
        public bool Active { get; set; }
    }
}
