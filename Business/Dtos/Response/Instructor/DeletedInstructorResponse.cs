using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response.Instructor
{
    public class DeletedInstructorResponse
    {
        public string Message { get; set; } = "Eğitmen başarıyla silindi";
        public Guid Id { get; set; }
    }
}
