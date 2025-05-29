using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exam
{
    public class StudentRecord
    {
      public int StudentRecordId { get; set; }
      public string FirstName { get; set; }
      public string LastName { get; set; }
      public string Group { get; set; }

      public string Algebra { get; set; }
      public string Geometry { get; set; }
      public string MathAnalysis { get; set; }
      public string ProbTheory { get; set; }
      public string Phisics { get; set; }

      public int SumBall { get; set; }
      public double SrBall { get; set; }
      
        public StudentRecord(string firstName, string lastName, string group, string algebra, string geometry, string mathAnalysis, string probTheory, string phisics)
            {
               FirstName = firstName;
               LastName = lastName;
               Group = group;
               Algebra = algebra;
               Geometry = geometry;
               MathAnalysis = mathAnalysis;
               ProbTheory = probTheory;
               Phisics = phisics;
               int[] MasBall = { Convert.ToInt32(algebra), Convert.ToInt32(geometry), Convert.ToInt32(mathAnalysis), Convert.ToInt32(probTheory), Convert.ToInt32(phisics) };
               SumBall = MasBall.Sum();
               SrBall = MasBall.Average();         
            }
        }
    }
