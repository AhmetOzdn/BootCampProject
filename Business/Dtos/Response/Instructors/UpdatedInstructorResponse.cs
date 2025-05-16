using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response.Instructors
{
    public class UpdatedInstructorResponse
    {
        public string Message { get; set; } = "Eğitmen başarıyla güncellendi";
        public Guid Id { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
