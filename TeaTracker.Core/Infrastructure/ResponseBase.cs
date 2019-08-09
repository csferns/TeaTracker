using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Text;

namespace TeaTracker.Core.Infrastructure
{
    public class ResponseBase
    {
        public void SetException(string userMessage, ExceptionDispatchInfo exceptionDispatchInfo)
        {
            this.UserMessage = userMessage;
            this.ExceptionDispatchInfo = exceptionDispatchInfo;
        }

        public string UserMessage { get; private set; }
        public ExceptionDispatchInfo ExceptionDispatchInfo { get; private set; }
        public bool Success
        {
            get { return ExceptionDispatchInfo == null; }
        }
    }
}
