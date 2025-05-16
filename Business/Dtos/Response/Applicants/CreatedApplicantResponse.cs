using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response.Applicants
{
    public class CreatedApplicantResponse
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
