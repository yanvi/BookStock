using BookStock.Models.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStock.Models
{
    public class IssueBookModel
    {
        public Dictionary<int, string> Books { get; set; }
       public List<int>BooksId { get; set; }
       public string StudentName { get; set; }
    }

   
}