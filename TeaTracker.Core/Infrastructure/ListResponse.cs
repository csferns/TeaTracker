using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeaTracker.Core.Infrastructure
{
    public class ListResponse<T> : ResponseBase
    {
        public List<T> Entities { get; set; }
        public bool HasData
        {
            get { return Success && Entities != null && Entities.Any(); }
        }
    }
}
