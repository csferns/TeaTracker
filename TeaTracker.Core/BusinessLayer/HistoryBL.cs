using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using TeaTracker.Core.DTOs;
using TeaTracker.Data.Entities;
using TeaTracker.Data.Interfaces;

namespace TeaTracker.Core.BusinessLayer
{
    public interface IHistoryBL
    {
        HistoryDTO GetById(int id);
        List<HistoryDTO> GetAll();
        List<HistoryDTO> GetTodays();
        void Create(HistoryDTO historyDTO);
        void Delete(int id);
    }

    public class HistoryBL : BaseBL<History>, IHistoryBL
    {
        private readonly IUnitOfWork unitOfWork;
        public HistoryBL(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void Create(HistoryDTO historyDTO)
        {
            var history = Mapper.Map<History>(historyDTO);
            var repository = unitOfWork.CreateRepository<History>();
            repository.Add(history);
        }

        public void Delete(int id)
        {
            var repository = unitOfWork.CreateRepository<History>();
            var history = repository.GetById(id);
            repository.Delete(history);
        }

        public List<HistoryDTO> GetAll()
        {
            var repository = unitOfWork.CreateRepository<History>();
            return repository.GetQuery().ProjectTo<HistoryDTO>().ToList();
        }

        public List<HistoryDTO> GetTodays() 
        {
            var repository = unitOfWork.CreateRepository<History>();
            return repository.GetQuery().Where(x => x.DrinkTime.Day == DateTime.Now.Day).ProjectTo<HistoryDTO>().ToList();
        }

        public HistoryDTO GetById(int id)
        {
            var repository = unitOfWork.CreateRepository<History>();
            return repository.GetQuery().ProjectTo<HistoryDTO>().Where(x => x.HistoryId == id).FirstOrDefault();
        }
    }
}
