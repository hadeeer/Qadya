using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Qadya.Data.Models
{
    public class Case
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }

        public int LawyerId { get; set; }
        public Lawyer Lawyer { get; set; }

        public ICollection<Session> Sessions { get; set; }
        public ICollection<Document> Documents { get; set; }
        public ICollection<Payment> Payments { get; set; }
    }
}
