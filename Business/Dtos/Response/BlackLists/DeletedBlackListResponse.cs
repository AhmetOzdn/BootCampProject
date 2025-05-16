using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response.BlackLists
{
    public class DeletedBlackListResponse
    {
        public Guid Id { get; set; }
        public DateTime DeletedDate { get; set; }
        public string Message { get; set; } = "Kullanıcı kara listeden başarıyla silindi.";
    }
}
