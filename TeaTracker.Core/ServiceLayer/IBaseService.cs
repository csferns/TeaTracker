using System.Collections.Generic;
using TeaTracker.Core.Infrastructure;

namespace TeaTracker.Core.ServiceLayer
{
    public interface IBaseService
    {
        Response<T> LoadResponse<T>(T item);
        ListResponse<T> LoadListResponse<T>(List<T> list); 
    }
}
