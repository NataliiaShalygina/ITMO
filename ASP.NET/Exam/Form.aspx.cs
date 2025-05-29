using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exam
{
    public partial class Form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                StudentRecord record = new StudentRecord(FirstName.Text, LastName.Text, Group.Text, Algebra.Text, Geometry.Text, MathAnalysis.Text, ProbTheory.Text, Phisics.Text);
                StudentsRep.GetRepository().AddResponse(record);
                try
                {

                    SampleContext context = new SampleContext();
                    context.StudentRecords.Add(record);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Response.Redirect("Ошибка " + ex.Message);
                }
                Response.Redirect("Otvet.html");

            }
        }
    }
}
