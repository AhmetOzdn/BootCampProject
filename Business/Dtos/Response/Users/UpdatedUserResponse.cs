using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response.Users
{
    public class UpdatedUserResponse
    {
        public string Message { get; set; } = "Kullanıcı başarıyla güncellendi";
        public Guid Id { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
