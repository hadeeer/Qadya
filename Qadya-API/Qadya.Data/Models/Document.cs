using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qadya.Data.Models
{
    public class Document
    {
        public int Id { get; set; }
        public string FilePath { get; set; }
        public DateTime UploadedAt { get; set; }

        public int? CaseId { get; set; }
        public Case Case { get; set; }
    }
}
