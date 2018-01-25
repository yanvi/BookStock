using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStock.Models.View
{
    public class ReceivedBook
    {
        public string StudentName { get; set; }
        public List<Book> ReceivedBooks { get; set; }

    }
}