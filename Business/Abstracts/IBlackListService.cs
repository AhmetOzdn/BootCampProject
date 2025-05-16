using Business.Dtos.Request.BlackLists;
using Business.Dtos.Request.Bootcamps;
using Business.Dtos.Response.BlackLists;
using Business.Dtos.Response.Bootcamps;
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
        CreatedBlackListResponse Add(CreateBlackListRequest request);
        List<GetListBlackListResponse> GetList();
        UpdatedBlackListResponse Update(UpdateBlackListRequest request);
        DeletedBlackListResponse Delete(DeleteBlackListRequest request);
    }
}
