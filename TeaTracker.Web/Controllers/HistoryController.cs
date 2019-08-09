using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using TeaTracker.Core.DTOs;
using TeaTracker.Core.ServiceLayer;
using TeaTracker.Models.History;
using UnitsNet;
using UnitsNet.Units;

namespace TeaTracker.Web.Controllers
{
    public class HistoryController : Controller
    {
        private readonly IHistoryService historyService;
        private readonly ILogger<HistoryController> logger;

        public HistoryController(ILogger<HistoryController> logger, IHistoryService historyService)
        {
            this.logger = logger;
            this.historyService = historyService;
        }

        public IActionResult Index()
        {
            List<HistoryViewModel> historiesViewModel = new List<HistoryViewModel>();
            try
            {
                List<HistoryDTO> histories = historyService.GetTodays().Entities;
                historiesViewModel = Mapper.Map<List<HistoryViewModel>>(histories);
            }
            catch (Exception e)
            {
                logger.LogError(e, string.Empty);
            }

            IndexViewModel indexViewModel = PopulateIndexModel(historiesViewModel);

            return View(indexViewModel);
        }

        public IActionResult AllHistory()
        {
            List<HistoryViewModel> historiesViewModel = new List<HistoryViewModel>();
            try
            {
                List<HistoryDTO> histories = historyService.GetAll().Entities;
                historiesViewModel = Mapper.Map<List<HistoryViewModel>>(histories);
            }
            catch (Exception e)
            {
                logger.LogError(e, string.Empty);
            }

            IndexViewModel indexViewModel = PopulateIndexModel(historiesViewModel, true);

            return View("History", indexViewModel);
        }

        private IndexViewModel PopulateIndexModel(List<HistoryViewModel> historiesViewModel, bool getAll = false)
        {
            IndexViewModel indexViewModel = new IndexViewModel()
            {
                Histories = historiesViewModel,
                MeasurementUnit = VolumeUnit.Milliliter,
                ReccomendedFluidIntake = 3700M,
                ActualFluidIntake = (decimal)historiesViewModel.Sum(x => Volume.FromMilliliters(x.CupSize).Value)
            };

            if (!getAll)
            {
                indexViewModel.TargetDate = DateTime.Now;
            }

            return indexViewModel;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new HistoryCreateViewModel());
        }

        [HttpPost]
        public IActionResult Create(HistoryCreateViewModel viewModel) 
        {
            HistoryDTO historyDTO = Mapper.Map<HistoryDTO>(viewModel);
            historyDTO.CupSize = Volume.From(viewModel.CupSize, viewModel.VolumeUnit).ToUnit(VolumeUnit.Milliliter).Value;
            historyService.Create(historyDTO);

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            HistoryDTO history = historyService.GetById(id).Entity;
            HistoryCreateViewModel historyViewModel = Mapper.Map<HistoryCreateViewModel>(history);

            return View(historyViewModel);
        }

        public IActionResult Delete(int id)
        {
            historyService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}