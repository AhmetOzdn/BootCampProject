using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response.Applicants
{
    public class UpdatedApplicantResponse
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid ApplicantId { get; set; }
        public Guid BootcampId { get; set; }
        public ApplicationState AplicationState { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Message { get; set; } = "Başvuru sahibi başarıyla güncellendi.";
    }
}
