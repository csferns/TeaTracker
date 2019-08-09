using System.Collections.Generic;
using TeaTracker.Core.Infrastructure;

namespace TeaTracker.Core.ServiceLayer
{
    public class BaseService : IBaseService
    {
        public Response<T> LoadResponse<T>(T item)
        {
            Response<T> response = new Response<T>
            {
                Entity = item,
            };

            return response;
        }

        public ListResponse<T> LoadListResponse<T>(List<T> list)
        {
            ListResponse<T> response = new ListResponse<T>
            {
                Entities = list
            };

            return response;
        }
    }
}
