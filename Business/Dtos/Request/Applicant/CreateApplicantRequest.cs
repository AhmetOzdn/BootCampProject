using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Request.Applicant
{
    public class CreateApplicantRequest
    {
        public Guid UserId { get; set; }
        public string About { get; set; }
    }
}
