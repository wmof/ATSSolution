using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATSSolution.Models
{
    public class Mechanic
    {
        public Areas Area { get; set; }
        public List<Order> OrdersManager { get; set; }
        
    }
    public enum Areas
    {
        Eletric,
        Engine,
        Chassis,
        Tires
    };
}
