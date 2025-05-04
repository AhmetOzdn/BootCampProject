using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response.Employee
{
    public class CreatedEmployeeResponse
    {
        public Guid Id { get; set; }
        public string Position { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
