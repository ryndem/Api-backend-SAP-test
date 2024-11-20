using System;
using System.Collections;

namespace Core.Promsy.Models.Export
{
    public class FaultException
    {
        public FaultException(string message, Exception exception)
        {
            Message = message;
            ErrorType = exception.GetType().FullName;

            Data = exception.Data;

            if (exception.InnerException != null)
                InnerException = new FaultException(exception.InnerException.Message, exception.InnerException);
        }

        public string Message { get; set; }
        public string ErrorType { get; set; }
        public FaultException InnerException { get; set; }
        public IDictionary Data { get; set; }
    }
}