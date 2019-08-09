using TeaTracker.Core.BusinessLayer;
using TeaTracker.Core.DTOs;
using TeaTracker.Core.Infrastructure;

namespace TeaTracker.Core.ServiceLayer
{
    public interface IHistoryService
    {
        Response<HistoryDTO> GetById(int id);
        ListResponse<HistoryDTO> GetAll();
        ListResponse<HistoryDTO> GetTodays();
        ResponseBase Create(HistoryDTO historyDTO);
        ResponseBase Delete(int id);
    }

    public class HistoryService : BaseService, IHistoryService
    {
        private readonly IHistoryBL historyBL;
        public HistoryService(IHistoryBL historyBL)
        {
            this.historyBL = historyBL;
        }

        public Response<HistoryDTO> GetById(int id)
        {
            return LoadResponse(historyBL.GetById(id));
        }

        public ListResponse<HistoryDTO> GetAll()
        {
            return LoadListResponse(historyBL.GetAll());
        }

        public ListResponse<HistoryDTO> GetTodays()
        {
            return LoadListResponse(historyBL.GetTodays());
        }

        public ResponseBase Create(HistoryDTO historyDTO)
        {
            historyBL.Create(historyDTO);
            return new ResponseBase();
        }

        public ResponseBase Delete(int id)
        {
            historyBL.Delete(id);
            return new ResponseBase();
        }
    }
}
