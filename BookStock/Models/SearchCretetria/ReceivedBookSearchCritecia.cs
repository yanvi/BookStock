using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStock.Models.SearchCretetria
{
    public class ReceivedBookSearchCritecia
    {
        public string StudentName { get; set; }
        public string AuthorName { get; set; }
        public DateTime ReceivedFromDate { get; set; }
        public DateTime ReceivedToDate { get; set; }

        
    }
}