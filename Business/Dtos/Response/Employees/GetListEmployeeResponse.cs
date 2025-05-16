using Business.Dtos.Response.Bootcamps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response.Employees
{
    public class GetListEmployeeResponse
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }       // User Inherited
        public string LastName { get; set; }        // User Inherited
        public string Email { get; set; }           // User Inherited
        public string Password { get; set; }        // User Inherited
        public string UserName { get; set; }        // User Inherited
        public string Position { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
