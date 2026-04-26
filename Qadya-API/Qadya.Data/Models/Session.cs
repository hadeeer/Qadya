using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qadya.Data.Models
{
    public class Session
    {
        public int Id { get; set; }
        public DateTime SessionDate { get; set; }
        public string? Notes { get; set; }
        public string? Result { get; set; }
        public string Type { get; set; }

        public int? CaseId { get; set; }
        public Case Case { get; set; }
    }
}
