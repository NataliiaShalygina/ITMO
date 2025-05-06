using System;

namespace EditPersonXML
{
    public partial class Form1 : Form
    {
        public static ArrayList pers = new ArrayList();

        public Form1()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditPersonForm editForm = new EditPersonForm();
            if (editForm.ShowDialog() != DialogResult.OK)
                return;
            ListViewItem newItem = personsListView.Items.Add(editForm.FirstName);
            newItem.SubItems.Add(editForm.LastName);
            newItem.SubItems.Add(editForm.Age.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (personsListView.SelectedItems.Count == 0)
                return;

            ListViewItem item = personsListView.SelectedItems[0];

            EditPersonForm editForm = new EditPersonForm();

            editForm.FirstName = item.Text;
            editForm.LastName = item.SubItems[1].Text;
            editForm.Age = Convert.ToInt32(item.SubItems[2].Text);
            
            if (editForm.ShowDialog() != DialogResult.OK)
                return;

            item.Text = editForm.FirstName;
            item.SubItems[1].Text = editForm.LastName;
            item.SubItems[2].Text = editForm.Age.ToString();
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            List<Person> list = new List<Person>();
            foreach(Person person in pers)
            {
                list.Add(person);
            }
            using (FileStream fStream = new FileStream("PersonCollection.xml",
                   FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer xmlFormat = new
                XmlSerializer(typeof(List<Person>));
                xmlFormat.Serialize(fStream, list);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            try
            {
                XmlSerializer nn = new XmlSerializer(typeof(List<Person>));
                using (FileStream fStream = new FileStream("PersonCollection.xml",
                   FileMode.OpenOrCreate, FileAccess.Read, FileShare.None))
                {
                    List<Person> load = ((List<Person>) nn.Deserialize(fStream));
                    foreach (Person person in load)
                    {
                        pers.Add(person);
                        ListViewItem newItem = personsListView.Items.Add(person.FirstName);
                        newItem.SubItems.Add(person.LastName);
                        newItem.SubItems.Add(person.Age.ToString());
                    }
                    
                    
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
    }
