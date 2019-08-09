using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TeaTracker.Common.Enums
{
    public enum DrinkTypeEnum
    {
        [Description("Tea")] Tea,
        [Description("Coffee")] Coffee,
        [Description("Hot Chocolate")] HotChocolate,
        [Description("Water")] Water,
        [Description("Orange Squash")] OrangeSquash
    }
}
