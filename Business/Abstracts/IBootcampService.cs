using Business.Dtos.Request.Bootcamps;
using Business.Dtos.Response.Bootcamps;

namespace Business.Abstracts
{
    public interface IBootcampService
    {
        CreatedBootcampResponse Add(CreateBootcampRequest request);
        List<GetListBootcampResponse> GetList();
        UpdatedBootcampResponse Update(UpdateBootcampRequest request);
        DeletedBootcampResponse Delete(DeleteBootcampRequest request);
    }
}
