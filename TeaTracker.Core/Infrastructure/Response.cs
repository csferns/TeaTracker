using System;
using System.Collections.Generic;
using System.Text;

namespace TeaTracker.Core.Infrastructure
{
    public class Response<T> : ResponseBase
    {
        public T Entity { get; set; }
    }
}
