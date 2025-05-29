using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exam
{
    public class StudentsRep
    {
        private static StudentsRep rep = new StudentsRep();
        private List<StudentRecord> respons = new List<StudentRecord>();
        public static StudentsRep GetRepository()
        {
            return rep;
        }
        public IEnumerable<StudentRecord> GetAllResponses()
        {
            return respons;
        }
        public void AddResponse(StudentRecord response)
        {
            respons.Add(response);
        }
    }
}
