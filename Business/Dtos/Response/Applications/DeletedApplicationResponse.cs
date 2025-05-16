using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response.Applications
{
    public class DeletedApplicationResponse
    {
        public Guid Id { get; set; }
        public DateTime DeletedDate { get; set; }
        public string Message { get; set; } = "Uygulama başarıyla silindi";
    }
}
