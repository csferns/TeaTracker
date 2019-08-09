using System;
using System.Globalization;
using TeaTracker.Common.Enums;
using UnitsNet;
using UnitsNet.Units;

namespace TeaTracker.Models.History
{
    public class HistoryViewModel
    {
        public int HistoryId { get; set; }
        public DrinkTypeEnum DrinkType { get; set; }
        public DateTime DrinkTime { get; set; }
        public VolumeUnit VolumeUnit { get; set; }
        public double CupSize { get; set; }

        public Volume GetMeasurement 
        {
            get
            {
                return Volume.FromMilliliters(CupSize).ToUnit(VolumeUnit);
            }
        }
    }
}
