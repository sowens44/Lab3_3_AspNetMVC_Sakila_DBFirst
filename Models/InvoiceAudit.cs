using System;
using System.Collections.Generic;

namespace Lab3_3_AspNetMVC_Sakila_DBFirst.Models
{
    public partial class InvoiceAudit
    {
        public int InvoiceAuditId { get; set; }
        public int? InvoiceId { get; set; }
        public string Username { get; set; }
        public DateTime? DateAdded { get; set; }
    }
}
