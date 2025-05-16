using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Request.Applications
{
    public class GetListApplicationRequest
    {
        public Guid? BootcampId { get; set; }
        public Guid? ApplicantId { get; set; }
        public ApplicationState? ApplicationState { get; set; }
    }
}
