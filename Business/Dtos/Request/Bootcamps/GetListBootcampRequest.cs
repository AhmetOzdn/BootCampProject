using Business.Dtos.Response.Instructors;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Request.Bootcamps
{
    public class GetListBootcampRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid InstructorId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public BootcampState BootcampState { get; set; }
        public List<InstructorDto> Instructors { get; set; }
    }
}
