using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATSSolution.Models
{
    public class Service
    {
        int Id { get; set; }
        public Areas ServiceArea { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
    }
}
