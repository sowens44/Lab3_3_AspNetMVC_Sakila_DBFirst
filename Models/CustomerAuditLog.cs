using System;
using System.Collections.Generic;

namespace Lab3_3_AspNetMVC_Sakila_DBFirst.Models
{
    public partial class CustomerAuditLog
    {
        public int CustomerAuditId { get; set; }
        public int? CustomerId { get; set; }
        public int? StoredId { get; set; }
        public int? StoredIdOld { get; set; }
        public string FirstName { get; set; }
        public string FirstNameOld { get; set; }
        public string LastName { get; set; }
        public string LastNameOld { get; set; }
        public string Email { get; set; }
        public string EmailOld { get; set; }
        public string Active { get; set; }
        public string ActiveOld { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
    }
}
