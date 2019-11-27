using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATSSolution.Models
{
    public class Order
    {
        public Vehicle Vehicle { get; set; }
        public Client Client { get; set; }
        public Mechanic MechanicManager { get; set; }

        public List<Order_Product> Order_Products { get; set; }
        public List<Order_Service> Order_Services { get; set; }

        public PaymentStatus PaymentStatus { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime DoneDate { get; set; }

        public string Diagnostic { get; set; }
        public string Problem { get; set; }
        public string Notes { get; set; }
    }
    public enum OrderStatus
    {
        Lobby,
        InProgress,
        WaitingClientResponse,
        WaitingWithdrawal,
        Done
    }

    public enum PaymentStatus
    {
        Pay,
        Pending
    }
}
