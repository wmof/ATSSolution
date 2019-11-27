using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATSSolution.Models
{
    public class Client : User
    {
        public List<Vehicle> Vehicles {get; set; }

        public List<Order> Orders { get; set; }
    }
}
