using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Request.BlackLists;
using Business.Dtos.Response.BlackLists;
using Business.Dtos.Response.Bootcamps;
using Entities;
using Repositories.Abstacts;
using Repositories.Concretes;
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
        private readonly IMapper _mapper;

        public BlackListManager(IBlackListRepository iblackListRepository,IMapper mapper)
        {
            _iblackListRepository = iblackListRepository;
            _mapper = mapper;
        }

        public CreatedBlackListResponse Add(CreateBlackListRequest request)
        {
            //Using AutoMapper
            BlackList blackList = _mapper.Map<BlackList>(request);
            BlackList createdBlackList = _iblackListRepository.Add(blackList);
            CreatedBlackListResponse response = _mapper.Map<CreatedBlackListResponse>(createdBlackList);
            return response;
        }

        public DeletedBlackListResponse Delete(DeleteBlackListRequest request)
        {
            //Using AutoMapper
            BlackList selectedBlackList = _iblackListRepository.Get(sbl => sbl.Id == request.Id);

            if (selectedBlackList == null)
                throw new Exception("Black Listte silinecek eleman bulunamadı.");

            _mapper.Map(request, selectedBlackList);
            _iblackListRepository.Delete(selectedBlackList);
            BlackList deletedBlackList = _iblackListRepository.Delete(selectedBlackList);
            DeletedBlackListResponse response = _mapper.Map<DeletedBlackListResponse>(deletedBlackList);
            return response;
        }

        public List<GetListBlackListResponse> GetList()
        {
            //Using AutoMapper
            List<BlackList> instructors = _iblackListRepository.GetAll();
            List<GetListBlackListResponse> responses = _mapper.Map<List<GetListBlackListResponse>>(instructors);
            return responses;
        }

        public UpdatedBlackListResponse Update(UpdateBlackListRequest request)
        {
            //Using AutoMapper
            BlackList selectedBlackList = _iblackListRepository.Get(sbl => sbl.Id == request.Id);

            if (selectedBlackList == null)
                throw new Exception("Black Listte güncellenecek eleman bulunamadı.");

            _mapper.Map(request, selectedBlackList);
            _iblackListRepository.Delete(selectedBlackList);
            BlackList updatedBlackList = _iblackListRepository.Delete(selectedBlackList);
            UpdatedBlackListResponse response = _mapper.Map<UpdatedBlackListResponse>(updatedBlackList);
            return response;
        }
    }
}
