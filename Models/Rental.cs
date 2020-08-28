using System;
using System.Collections.Generic;

namespace Lab3_3_AspNetMVC_Sakila_DBFirst.Models
{
    public partial class Rental
    {
        public Rental()
        {
            Payment = new HashSet<Payment>();
            So2payment = new HashSet<So2payment>();
            Sopayment = new HashSet<Sopayment>();
        }

        public int RentalId { get; set; }
        public DateTime RentalDate { get; set; }
        public int InventoryId { get; set; }
        public int CustomerId { get; set; }
        public DateTime? ReturnDate { get; set; }
        public byte StaffId { get; set; }
        public DateTime LastUpdate { get; set; }

        public Customer Customer { get; set; }
        public Inventory Inventory { get; set; }
        public Staff Staff { get; set; }
        public ICollection<Payment> Payment { get; set; }
        public ICollection<So2payment> So2payment { get; set; }
        public ICollection<Sopayment> Sopayment { get; set; }
    }
}
