using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookStock.Models.SearchCretetria;
using BookStock.Models.View;
using BookStock.DL;
using BookStock.Models.Utility;
using BookStock.Common;
namespace BookStock.BL
{
    public class BookBL
    {
        public Dictionary<int, string> GetBooks()
        {
            Dictionary<int, string> books = new Dictionary<int, string>();
            try
            {
              BookDL  dl=new BookDL ();
             books= dl.GetBooks();
             return books;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            
        }

        public int IssueBook(Book Book, string StudentName)
        {
            int x = 0;
            try
            {

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return x;
        }
        public Result IssueBook( List<Book> Books ,string StudentName)
        {
            Result x;
            try
            {
                DL.BookDL book = new BookDL();
               return book.IssueBook(Books, StudentName);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            
        }

        public object ViewIssueBook(object searchCriteria)
        {
            Paging<object> obj = new Paging<object>();
            try
            {

            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            return obj;
        }

        public int ReceivedBook(object obj)
        {
            int x = 0;
            try
            {

            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            return x;
        }

        public object ViewReceivedBook( object searchCriteria)
        {
            Paging<object> obj = new Paging<object>();
            try
            {

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return obj;
        }
        public bool IsAlreadyAssignBook(int bookId, int studentId)
        {
            try
            {
                return new BookDL().IsAlreadyAssignBook(bookId, studentId);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

    }
}