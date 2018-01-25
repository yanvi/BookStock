using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStock.BL;
using BookStock.Models.View;
using BookStock.Common;
using System.Web.Helpers;

namespace BookStock.Controllers
{
    public class BookStockController : Controller
    {

        [HttpGet]
        public ActionResult IssueBook()
        {
            Models.IssueBookModel model = new Models.IssueBookModel();

            BookStock.BL.BookBL bl = new BL.BookBL();
            model.Books = bl.GetBooks();
            if (TempData["Result"] != null)
            {

            }
            return View(model);
        }
        [HttpPost]
        public ActionResult IssueBook([Bind(Exclude = "Books")]BookStock.Models.IssueBookModel obj)
        {
            if (ModelState.IsValid)
            {
                BookBL book = new BookBL();
                List<Book> books = new List<Book>();
                foreach (var item in obj.BooksId)
                {
                    books.Add(new Book() { BookId = item });
                }
                Result result = book.IssueBook(books, obj.StudentName);
                TempData["Result"] = result;
            }
            return RedirectToAction("IssueBook");
        }

        [HttpGet]
        public ActionResult ViewIssueBook(object IssueBookSearch)
        {
            return View();
        }

        [HttpGet]
        public ActionResult ReceiveBook()
        {
            return View();
        }
        public ActionResult ReceiveBook(object obj)
        {
            return View();
        }

        [HttpPost]
        public ActionResult ViewReceivedBook(object ReceivedBookSearch)
        {
            return View();
        }

        [HttpPost]
        public bool IsAlreadyAssignBook(string studentId, string bookId)
        {
            try
            {
                return new BL.BookBL().IsAlreadyAssignBook(Convert.ToInt16(bookId), Convert.ToInt32(studentId.Split('-')[1]));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        
        public JsonResult GetStudent(string term)
        {
            try
            {
                var srr = new string[0] ;
                if (!string.IsNullOrEmpty(term))
                {
                    StudentBL student = new StudentBL();
                    var criteria = new BookStock.Models.SearchCretetria.StudentSearchCritetia();
                    criteria.StudentName = term;
                    return Json(student.GetStudentName(criteria),JsonRequestBehavior.AllowGet);
                    
                }
                return Json("");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}