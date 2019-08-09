using System;
using System.Collections.Generic;
using TeaTracker.Common.Enums;
using UnitsNet.Units;

namespace TeaTracker.Models.History
{
    public class IndexViewModel
    {
        public IEnumerable<HistoryViewModel> Histories { get; set; }

        public DateTime? TargetDate { get; set; }

        public decimal ReccomendedFluidIntake { get; set; }
        public decimal ActualFluidIntake { get; set; }
        public decimal FluidIntakeDifference
        {
            get
            {
                return ActualFluidIntake - ReccomendedFluidIntake;
            }
        }

        public decimal FluidIntakePercentage
        {
            get
            {
                return (ActualFluidIntake / ReccomendedFluidIntake) * 100;
            }
        }

        public VolumeUnit MeasurementUnit { get; set; }

        public decimal ConvertToMeasurementUnit
        {
            get
            {
                return decimal.MinValue;
            }
        }
    }
}
