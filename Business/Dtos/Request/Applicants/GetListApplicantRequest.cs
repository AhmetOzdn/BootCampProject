using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Request.Applicants
{
    public class GetListApplicantRequest
    {
        public string? NameKeyword { get; set; }
        public string? Email { get; set; }
    }
}
