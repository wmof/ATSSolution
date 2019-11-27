using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATSSolution.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Addrres { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public userType Role { get; set; }

        public enum userType
        {
            Client,
            Mechanic
        };
    }
}
