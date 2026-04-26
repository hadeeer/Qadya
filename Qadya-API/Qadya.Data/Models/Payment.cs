using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qadya.Data.Models
{
    public class Payment:Auditable
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public string PaymentMethod { get; set; }
        public string InvoiceNumber { get; set; }

        public int? ClientId { get; set; }
        public Client Client { get; set; }

        public int? CaseId { get; set; }
        public Case Case { get; set; }
    }
}
