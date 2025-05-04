using Core.Entities;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Application : BaseEntity<Guid>
    {
        public Guid ApplicantId { get; set; } 
        public Guid BootcampId { get; set; } 
        public  ApplicationState AplicationState { get; set; }
        public virtual Applicant Applicant { get; set; } //One To Many
        public virtual Bootcamp Bootcamp { get; set; } // One To Many
    }
}
