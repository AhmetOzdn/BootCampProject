using Business.Abstracts;
using Business.Dtos.Response.Bootcamp;
using Entities;
using Repositories.Abstacts;
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
        public BootcampManager(IBootcampRepository ibootcampRepository)
        {
            _ibootcampRepository = ibootcampRepository;
        }

        public CreatedBootcampResponse Add(CreatedBootcampResponse response)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid bootcampId)
        {
            throw new NotImplementedException();
        }

        public List<Bootcamp> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Bootcamp bootcamp)
        {
            throw new NotImplementedException();
        }
    }
}
