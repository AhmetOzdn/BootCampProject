using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Blacklist : BaseEntity<Guid>
    {
        public string Reason { get; set; }
        public DateTime Date { get; set; }
        public Guid ApplicantId { get; set; }
        public virtual Applicant Applicant { get; set; } // Many to One
    }
}
