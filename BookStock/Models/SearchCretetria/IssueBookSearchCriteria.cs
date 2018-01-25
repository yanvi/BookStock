using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStock.Models.SearchCretetria
{
    public class IssueBookSearchCriteria
    {
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public DateTime IssueFrom { get; set; }
        public DateTime IssueTo { get; set; }

    }
}