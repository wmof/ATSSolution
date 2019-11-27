using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATSSolution.Models
{
    public class Vehicle
    {
        int Id { get; set; }
        public Client Owner { get; set; }

        public List<Order> AssociatedOrders { get; set; }

        public string License { get; set; }

        public string Maker { get; set; }

        public string Model { get; set; }

        public int Year { get; set;}
    }
}
