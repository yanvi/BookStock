using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookStock.Models.View
{
    public class IssueBook
    {
        [Required(ErrorMessage="Required!")]
        public string StudentName { get; set; }

        [Required(ErrorMessage = "Required!")]
        public List<Book> IssueBooks { get; set; }
    }
}