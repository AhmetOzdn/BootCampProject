using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response.User
{
    public class DeletedUserResponse
    {
        public string Message { get; set; } = "Kullanıcı başarıyla silindi";
        public Guid Id { get; set; }
    }
}
