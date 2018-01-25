using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStock.Models.View
{
    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public decimal Price { get; set; }
        public bool IsIssue { get; set; }
    }
    
}