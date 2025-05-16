using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response.Employees
{
    public class DeletedEmployeeResponse
    {
        public Guid Id { get; set; }
        public string Message { get; set; } = "Çalışan başarıyla silindi";
    }
}
