using Entities.Enums;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Dtos.Response.Instructors;

namespace Business.Dtos.Response.Bootcamps
{
    public class GetListBootcampResponse
    {
        public List<InstructorDto> Instructors { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public BootcampState BootcampState { get; set; }

    }
}
