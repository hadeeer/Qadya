using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qadya.Data.Models
{
    public class Lawyer
    {
        public int Id { get; set; }
        public string Specialization { get; set; }
        public string LicenseNumber { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }


    }
}
