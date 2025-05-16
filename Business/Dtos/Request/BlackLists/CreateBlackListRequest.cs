using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Request.BlackLists
{
    public class CreateBlackListRequest
    {
        public string Reason { get; set; }
        public DateTime Date { get; set; } 
        public Guid ApplicantId { get; set; }
    }
}
