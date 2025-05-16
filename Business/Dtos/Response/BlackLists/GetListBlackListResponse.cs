using Business.Dtos.Response.Applicants;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response.BlackLists
{
    public class GetListBlackListResponse
    {
        public string Reason { get; set; }
        public DateTime Date { get; set; }
        public Guid ApplicantId { get; set; }
        public ApplicantDto Applicant { get; set; }
    }
}
