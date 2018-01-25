using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookStock.Models.SearchCretetria;
using BookStock.DL;

namespace BookStock.BL
{
    public class StudentBL
    {
        public List<string> GetStudentName(StudentSearchCritetia criteria)
        {
            try
            {
                StudentDL student = new StudentDL();
                return  student.GetStudentName(criteria);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

    
}