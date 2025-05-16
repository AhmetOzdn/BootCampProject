using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response.Bootcamps
{
    public class DeletedBootcampResponse
    {
        public Guid Id { get; set; }
        public string Message { get; set; } = "Bootcamp başarıyla silindi";
    }
}
