using BookStock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStock.DL
{
    public class IssueBookDL
    {
        public bool IssueBook(IssueBookModel issueBook)
        {
            try
            {
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}