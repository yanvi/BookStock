using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookStock.Models;
using BookStock.Models.Utility;
using BookStock.Models.SearchCretetria;
using BookStock.Models.View;
using Dapper;
using System.Data;
using BookStock.Common;

namespace BookStock.DL
{
    public class BookDL
    {
        DbConnection connection = new DbConnection();
        public Dictionary<int, string> GetBooks()
        {
            Dictionary<int, string> books = new Dictionary<int, string>();
            try
            {
                string query = @"SELECT BookId
      ,case when  AuthorName IS null then BookName
       else  BookName +'-'+AuthorName end  as[BookName]
  FROM [BookMastr]";
                var x = connection.db.Query<ViewBookDL>(query);
                books = x.ToDictionary(p => p.BookId, p => p.BookName);

                return books;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public Result IssueBook(List<Book> Books, string StudentName)
        {
            
            connection.db.Open();
            IDbTransaction tran = connection.db.BeginTransaction(IsolationLevel.ReadCommitted);
            Result s;
            using (tran)
            {
                try
                {
                    foreach (var book in Books)
                    {
                        var parameterlist = new { StudentId = StudentName, BookId = book.BookId, UserId = 1 };
                        var result = connection.db.Query("USP_BookIssue", parameterlist, tran, false, null, CommandType.StoredProcedure);
                        
                    }
                    tran.Commit();
                    s = new Result() { Data = null, Message = "Success", Status = Status.Success };
                    return s;

                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    s = new Result() { Data = null, Message = ex.Message, Status = Status.Error };

                }
            }
            return s;
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

        public object ViewReceivedBook(object searchCriteria)
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
                string query = @"if exists( select '1' from StudentBookTRN  
where StudentId =@StudentId AND BookId =@BookId 
AND  ReceivedDate  is null )";
                var parameterList = new { BookId = bookId, StudentId = studentId };
                var x = connection.db.Query(query, parameterList, null, false, null, CommandType.Text);


                if (Convert.ToBoolean(x) == true)
                {
                    return true;
                }

                return false;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}