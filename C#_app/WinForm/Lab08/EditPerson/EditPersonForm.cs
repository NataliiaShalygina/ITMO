using System;
using System.Windows.Forms;

namespace EditPerson
{
    public partial class EditPersonForm : Form
    {
       
        Person p = new Person();
        public EditPersonForm()
        {
            InitializeComponent();


        }

        public string FirstName
        {
            get { return firstNameTextBox.Text; }
            set { firstNameTextBox.Text = value; }
        }

        public string LastName
        {
            get { return lastNameTextBox.Text; }
            set { lastNameTextBox.Text = value; }
        }

        public int Age
        {
            get { return (int)ageNumericUpDown.Value; }
            set { ageNumericUpDown.Value = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.FirstName = firstNameTextBox.Text;
            p.LastName = lastNameTextBox.Text;
            p.Age = Convert.ToInt32(ageNumericUpDown.Value);
            MessageBox.Show("Сотрудник: " + p.ToString());
            Form1.pers.Add(p);
            
           
        }
    }
}
