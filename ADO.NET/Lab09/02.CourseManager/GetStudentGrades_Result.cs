namespace CourseManager
{
    using System;
    
    public partial class GetStudentGrades_Result
    {
        public int EnrollmentID { get; set; }
        public Nullable<decimal> Grade { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
    }
}
