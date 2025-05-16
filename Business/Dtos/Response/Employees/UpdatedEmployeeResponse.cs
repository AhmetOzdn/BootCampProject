using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response.Employees
{
    public class UpdatedEmployeeResponse
    {
        public Guid Id { get; set; }
        public string Position { get; set; }
        public string Message { get; set; } = "Müşteri başarıyla güncellendi";
        public DateTime UpdatedDate { get; set; }
    }
}
