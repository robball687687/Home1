using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LA.Models.User
{
    public class User
    {
        public int UserPK { get; set; }
        public int UserTypeFK { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string EmailAddress { get; set; }
        public string Phone1 { get; set; }        
        public bool Active { get; set; }
    }
}
