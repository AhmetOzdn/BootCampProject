using Business.Dtos.Response.Bootcamp;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IBootcampService
    {
        CreatedBootcampResponse Add(CreatedBootcampResponse response);
        List<Bootcamp> GetAll();
        void Update(Bootcamp bootcamp);
        void Delete(Guid bootcampId);
    }
}
