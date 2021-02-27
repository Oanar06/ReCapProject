using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
     

        public Result(bool successs, string message):this(successs)
        {
            Message = message;
            
        }
        public Result(bool successs) 
        {
            Success = Success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
