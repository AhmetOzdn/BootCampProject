using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response.Applications
{
    public class UpdatedApplicationResponse
    {
        public Guid Id { get; set; }
        public Guid ApplicantId { get; set; }
        public Guid BootcampId { get; set; }
        public ApplicationState AplicationState { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Message { get; set; } = "Uygulama başarıyla güncellendi.";
    }
}
