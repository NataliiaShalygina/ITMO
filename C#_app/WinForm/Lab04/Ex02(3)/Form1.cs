using System;
using System.Windows.Forms;

namespace EditPerson
{
    public partial class Form1 : Form
    {
        private int Counter = 0;

        List<Person> pers = new List<Person>();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            EditPersonForm editForm = new EditPersonForm(p);
            if (editForm.ShowDialog() != DialogResult.OK)
                return;
            ListViewItem newItem = personsListView.Items.Add(p.FirstName);
            newItem.SubItems.Add(p.LastName);
            newItem.SubItems.Add(p.Age.ToString());
            p.indexList = ++Counter-1;
            pers.Add(p);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (personsListView.SelectedItems.Count == 0)
                return;
            Person p = new Person();
            ListViewItem item = personsListView.SelectedItems[0];
            p.FirstName= item.Text;
            p.LastName= item.SubItems[1].Text;
            p.Age= Convert.ToInt32(item.SubItems[2].Text);
            EditPersonForm editForm = new EditPersonForm(p);
           
            if (editForm.ShowDialog() != DialogResult.OK)
                return;
            item.Text = p.FirstName;
            item.SubItems[1].Text = p.LastName;
            item.SubItems[2].Text = p.Age.ToString();
            pers[p.indexList] = p;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Person item in pers)
            {
                sb.Append("Сотрудник: \n" + item.ToString());
            }
            richTextBox1.Text = sb.ToString();
        }

        private void personsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
