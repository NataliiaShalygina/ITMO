using System;
using System.Windows.Forms;

namespace EditPerson
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public int indexList;

        public override string ToString()
        {
            return LastName + " " + FirstName + "\nВозраст: " + Age + "\n" + indexList;
        }
    }

}
