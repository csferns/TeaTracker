using System;
using TeaTracker.Common.Enums;
using UnitsNet.Units;

namespace TeaTracker.Models.History
{
    public class HistoryCreateViewModel
    {
        public HistoryCreateViewModel()
        {
            DrinkTime ??= DateTime.Now;   
        }

        public int HistoryId { get; set; }
        public DrinkTypeEnum DrinkType { get; set; }
        public DateTime? DrinkTime { get; set; }
        public VolumeUnit VolumeUnit { get; set; }
        public double CupSize { get; set; }
    }
}
