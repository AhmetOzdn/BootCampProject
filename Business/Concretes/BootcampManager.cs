using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Request.Bootcamps;
using Business.Dtos.Response.Bootcamps;
using Business.Dtos.Response.Employees;
using Business.Dtos.Response.Instructors;
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
    public class BootcampManager : IBootcampService
    {
        private readonly IBootcampRepository _ibootcampRepository;
        private readonly IMapper _mapper;
        public BootcampManager(IBootcampRepository ibootcampRepository,IMapper mapper)
        {
            _ibootcampRepository = ibootcampRepository;
            _mapper = mapper;
        }
        public CreatedBootcampResponse Add(CreateBootcampRequest request)
        {
            //Using AutoMapper
            Bootcamp bootcamp = _mapper.Map<Bootcamp>(request);
            Bootcamp createdBootcamp = _ibootcampRepository.Add(bootcamp);
            CreatedBootcampResponse response = _mapper.Map<CreatedBootcampResponse>(createdBootcamp);
            return response;
        }

        public DeletedBootcampResponse Delete(DeleteBootcampRequest request)
        {
            //Using AutoMapper
            Bootcamp selectedBootcamp = _ibootcampRepository.Get(sb => sb.Id == request.Id);

            if (selectedBootcamp == null)
                throw new Exception("Bootcamp Bulunamadı");

            _mapper.Map(request, selectedBootcamp);
            _ibootcampRepository.Delete(selectedBootcamp);
            Bootcamp deletedBootcamp = _ibootcampRepository.Delete(selectedBootcamp);
            DeletedBootcampResponse response = _mapper.Map<DeletedBootcampResponse>(deletedBootcamp);
            return response;
        }

        public List<GetListBootcampResponse> GetList()
        {
            //Using AutoMapper
            List<Bootcamp> instructors = _ibootcampRepository.GetAll();
            List<GetListBootcampResponse> responses = _mapper.Map<List<GetListBootcampResponse>>(instructors);
            return responses;
        }

        public UpdatedBootcampResponse Update(UpdateBootcampRequest request)
        {
            //Using AutoMapper
            Bootcamp selectedBootcamp = _ibootcampRepository.Get(sb => sb.Id == request.Id);

            if (selectedBootcamp == null)
                throw new Exception("Bootcamp Bulunamadı");

            _mapper.Map(request, selectedBootcamp);
            _ibootcampRepository.Update(selectedBootcamp);
            Bootcamp UpdatedBootcamp = _ibootcampRepository.Update(selectedBootcamp);
            UpdatedBootcampResponse response = _mapper.Map<UpdatedBootcampResponse>(UpdatedBootcamp);
            return response;
        }
    }
}
