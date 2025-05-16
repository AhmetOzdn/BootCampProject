using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Request.Applications;
using Business.Dtos.Response.Applications;
using Business.Dtos.Response.BlackLists;
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
    public class ApplicationManager : IApplicationService
    {
        private readonly IApplicationRepository _applicationRepository;
        private readonly IMapper _mapper;
        public ApplicationManager(IApplicationRepository applicationRepository, IMapper mapper)
        {
            _applicationRepository = applicationRepository;
            _mapper = mapper;
        }


        public CreatedApplicationResponse Add(CreateApplicationRequest request)
        {
            //Using AutoMapper
            Application application = _mapper.Map<Application>(request);
            Application createdApplication = _applicationRepository.Add(application);
            CreatedApplicationResponse response = _mapper.Map<CreatedApplicationResponse>(createdApplication);
            return response;
        }

        public DeletedApplicationResponse Delete(DeleteApplicationRequest request)
        {
            //Using AutoMapper
            Application selectedApplication = _applicationRepository.Get(sa => sa.Id == request.Id);

            if (selectedApplication == null)
                throw new Exception("Uygulamada silinecek eleman bulunamadı.");

            _mapper.Map(request, selectedApplication);
            _applicationRepository.Delete(selectedApplication);
            Application deletedBlackList = _applicationRepository.Delete(selectedApplication);
            DeletedApplicationResponse response = _mapper.Map<DeletedApplicationResponse>(deletedBlackList);
            return response;
        }

        public List<GetListApplicationResponse> GetList()
        {
            //Using AutoMapper
            List<Application> instructors = _applicationRepository.GetAll();
            List<GetListApplicationResponse> responses = _mapper.Map<List<GetListApplicationResponse>>(instructors);
            return responses;
        }

        public UpdatedApplicationResponse Update(UpdateApplicationRequest request)
        {
            //Using AutoMapper
            Application selectedApplication = _applicationRepository.Get(sa => sa.Id == request.Id);

            if (selectedApplication == null)
                throw new Exception("Uygulamada güncellenecek eleman bulunamadı.");

            _mapper.Map(request, selectedApplication);
            _applicationRepository.Update(selectedApplication);
            Application deletedBlackList = _applicationRepository.Update(selectedApplication);
            UpdatedApplicationResponse response = _mapper.Map<UpdatedApplicationResponse>(deletedBlackList);
            return response;
        }
    }
}
