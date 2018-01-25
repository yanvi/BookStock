using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStock.Common
{
    public class Result
    {

        public string Message { get; set; }
        public Status Status { get; set; }
        public object Data { get; set; }
    }
    public enum Status
    {
        Success=1,
        Warning=2,
        Error=3
    }
}