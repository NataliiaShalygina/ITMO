using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Exam
{
    public class SampleContext : DbContext
    {
        public SampleContext() : base("SchoolBD") { }
        public DbSet<StudentRecord> StudentRecords { get; set; }
    }
}
