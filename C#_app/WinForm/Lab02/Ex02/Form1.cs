using System.Xml;

namespace TestList
{
    public partial class TestList : Form
    {
        public TestList()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (peopleList.Text.Length != 0)
            {
                memberList.Items.Add(peopleList.Text);
            }
            else MessageBox.Show("Выберите элемент из списка или введите новый");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            while (memberList.CheckedIndices.Count > 0)
                memberList.Items.RemoveAt(memberList.CheckedIndices[0]);
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            memberList.Sorted = true;
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            peopleList.Items.Clear();
            FileStream fStream = 
                new FileStream ("..\\..\\XMLData.xml", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            XmlDocument xmlDoc = new XmlDocument ();
            xmlDoc.Load (fStream);
            for (int i = 0; i < xmlDoc.DocumentElement.ChildNodes.Count; i++)
            {
                peopleList.Items.Add(xmlDoc.DocumentElement.ChildNodes[i].InnerText);
                fStream.Close();
            }
        }
    }
}
