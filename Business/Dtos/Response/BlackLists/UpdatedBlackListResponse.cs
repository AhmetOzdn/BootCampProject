using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response.BlackLists
{
    public class UpdatedBlackListResponse
    {
        public Guid Id { get; set; }
        public string Reason { get; set; }
        public DateTime Date { get; set; }
        public Guid ApplicantId { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Message { get; set; } = "Kara Liste güncellemesi başarıyla gerçekleştirildi.";
    }
}
