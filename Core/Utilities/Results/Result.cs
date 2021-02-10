using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //İKi kere success = success yazdık buda kendini tekrar etme ilkesine ters bunun için ilk constructer'dan diğerini çağırdık.
        public Result(bool success, string message):this(success)
        {
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }
        public bool Success { get; }

        public string Message { get; }
        
    }
}
