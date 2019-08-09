using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TeaTracker.Common.Enums
{
    public enum MeasurementUnitEnum
    {
        [Description("Millilitres")] ML = 0,
        [Description("Litres")] L = 1,
        [Description("Kilolitres")] KL = 2,
        [Description("Pint")] P = 3,
        [Description("Gallon")] G = 4,
    }
}
