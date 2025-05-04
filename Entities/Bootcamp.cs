using Core.Entities;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Bootcamp : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public Guid InstructorId { get; set; } 
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public BootcampState BootcampState { get; set; }
        public virtual ICollection<Instructor> Instructors { get; set; } // Many To Many
    }
}
