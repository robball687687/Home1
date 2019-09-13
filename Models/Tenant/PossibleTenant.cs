using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LA.Models.Tenant
{
    public class PossibleTenant
    {
        public int PossibleTenantPK { get; set; }
        public int TenantApplicationFK { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string SS { get; set; }
        public string DriverLicense { get; set; }
        public string Phone { get; set; }
        public string EmailAddress { get; set; }
        public string OtherPossibleName { get; set; }
        public bool Active { get; set; }
    }
}
