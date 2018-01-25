using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStock.Models.Utility
{
    public class Paging<T> where  T : class
    {
        public const int pageSize = 10;
        public List<T> Data { get; set; }
        public int FromPage { get; set; }
        public int ToPage { get; set; }

        public int TotalPages { get; set; }
    }
    

}