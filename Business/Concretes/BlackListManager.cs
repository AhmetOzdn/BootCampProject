using Business.Abstracts;
using Business.Dtos.Response.BlackList;
using Entities;
using Repositories.Abstacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class BlackListManager : IBlackListService
    {
        private readonly IBlackListRepository _iblackListRepository;

        public BlackListManager(IBlackListRepository iblackListRepository)
        {
            _iblackListRepository = iblackListRepository;
        }

        public CreatedBlackListResponse Add(CreatedBlackListResponse response)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid blackListId)
        {
            throw new NotImplementedException();
        }

        public List<Blacklist> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Blacklist blackList)
        {
            throw new NotImplementedException();
        }
    }
}
