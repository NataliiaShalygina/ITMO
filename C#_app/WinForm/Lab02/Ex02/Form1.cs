using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TestList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (memberList.Items.Contains(peopleList.Text))
            {
                MessageBox.Show("Этот человек уже добавлен");
            }

            if (peopleList.Text.Length > 0 &&  !(memberList.Items.Contains(peopleList.Text)))
            {
                memberList.Items.Add(peopleList.Text);
            }


            if (peopleList.Text.Length == 0) 
            { 
                MessageBox.Show("Выберите человека из списка или впишите его"); 
            }
        }

        private void memberList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            while (memberList.CheckedIndices.Count> 0)
            {
                memberList.Items.RemoveAt(memberList.CheckedIndices[0]);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            memberList.Sorted= true;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            peopleList.Items.Clear();
            FileStream fStream =
                        new FileStream("..\\..\\XMLFile1.xml", FileMode.Open,
                                        FileAccess.Read, FileShare.ReadWrite);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(fStream);
            for (int i = 0; i < xmlDoc.DocumentElement.ChildNodes.Count; i++)
            {
                peopleList.Items.Add(xmlDoc.DocumentElement.ChildNodes[i].InnerText);

            }
            fStream.Close();
        }
    }
}
