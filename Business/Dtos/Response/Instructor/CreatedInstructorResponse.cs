using Business.Dtos.Response.Bootcamp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response.Instructor
{
    public class CreatedInstructorResponse
    {
        public Guid Id { get; set; }
        public string CompanyName { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
