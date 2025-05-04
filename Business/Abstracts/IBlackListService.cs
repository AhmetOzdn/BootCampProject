using Business.Dtos.Response.BlackList;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IBlackListService
    {
        CreatedBlackListResponse Add(CreatedBlackListResponse response);
        List<Blacklist> GetAll();
        void Update(Blacklist blackList);
        void Delete(Guid blackListId);
    }
}
