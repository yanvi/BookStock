using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookStock.Models.SearchCretetria;
using Dapper;
using System.Text;

namespace BookStock.DL
{
    public class StudentDL
    {
        DbConnection connection = new DbConnection();
        public List<string> GetStudentName(StudentSearchCritetia criteria)
        {
            try
            {
              var query =  GetStudentNameQuery();
              var parameter = new { name = criteria.StudentName };
                var x = connection.db.Query<String>(query,parameter);
                return x.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private string GetStudentNameQuery()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" select StudentName+'-'+Cast(StudentId as varchar(80)) AS StudentName ");
            sb.Append(" from StudentTbl ");
            sb.Append("Where StudentName like('%'+@name+'%')");
            return sb.ToString();
        }
    }
}