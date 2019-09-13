using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LA.Models.User
{
    public class UserType
    {
        public int UserTypePK { get; set; }        
        public string UserTypeValue { get; set; }
        public bool Active { get; set; }
    }
}
