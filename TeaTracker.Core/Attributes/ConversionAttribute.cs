using System;

namespace TeaTracker.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
    public class ConversionAttribute : Attribute
    {
        public ConversionAttribute()
        {

        }
    }
}
