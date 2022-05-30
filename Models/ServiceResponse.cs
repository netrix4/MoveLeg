using System;
using System.Collections.Generic;
using System.Text;

namespace MoveLegRef.Bussines
{
    public class ServiceResponse<T>
    {
        //private T _Data;
        public T Data { get; set; }
        public string Message { get; set; }
        public bool IsOk { get; set; }
    }
}
