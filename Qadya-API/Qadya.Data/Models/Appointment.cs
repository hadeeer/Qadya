using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qadya.Data.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public decimal Price { get; set; }

        public int? LawyerId { get; set; }
        public Lawyer Lawyer { get; set; }

        public int? ClientId { get; set; }
        public Client Client { get; set; }

    }
}
