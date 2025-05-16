using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response.Applicants
{
    public class DeletedApplicantResponse
    {
        public Guid Id { get; set; }
        public DateTime DeletedDate { get; set; }
        public string Message { get; set; } = "Başvuru sahibi başarıyla silindi.";
    }
}
