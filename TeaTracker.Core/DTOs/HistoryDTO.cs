using System;
using TeaTracker.Common.Enums;
using UnitsNet.Units;

namespace TeaTracker.Core.DTOs
{
    public class HistoryDTO
    {
        public int HistoryId { get; set; }
        public DrinkTypeEnum DrinkType { get; set; }
        public DateTime DrinkTime { get; set; }
        public VolumeUnit VolumeUnit { get; set; }
        public double CupSize { get; set; }
    }
}
