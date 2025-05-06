using System;
using System.Windows.Forms;

namespace Ex04
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBoxF21.Text + " " + textBoxF22.Text + " " + textBoxF23.Text;
            Form1 frm1 = this.Owner as Form1;
            if (frm1 != null)
            {
                frm1.SolData = s;
            }
            this.Close();
        }
    }
}
