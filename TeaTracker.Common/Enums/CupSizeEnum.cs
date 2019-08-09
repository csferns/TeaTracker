using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TeaTracker.Common.Enums
{
    public enum CupSizeEnum
    {
        [Description("Half Pint")] HalfPint = 0,
        [Description("Pint")] Pint = 1,
        [Description("Mug")] Mug = 2,
        [Description("Teapot")] Teapot = 3 
    }
}
