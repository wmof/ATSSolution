using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATSSolution.Models
{
    public class Order_Product
    {
        Product Product { get; set; }

        int Quantity { get; set; }

        DateTime Date { get; set; }

    }
}
