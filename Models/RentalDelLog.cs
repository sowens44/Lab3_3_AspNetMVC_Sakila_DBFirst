using System;
using System.Collections.Generic;

namespace Lab3_3_AspNetMVC_Sakila_DBFirst.Models
{
    public partial class RentalDelLog
    {
        public int LogId { get; set; }
        public int? RentalId { get; set; }
        public DateTime? RentalDate { get; set; }
        public int? InventoryId { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? ReturnDate { get; set; }
        public byte? StaffId { get; set; }
        public DateTime? DeletedOn { get; set; }
        public string DeletedBy { get; set; }
    }
}
