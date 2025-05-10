using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Quadratic : Form
    {

        public string A
        {
            get { if (textBox1.Text != "")return textBox1.Text;
                else return "1";
            }
            set { textBox1.Text = value; }
        }
        public string B
        {
            get {
                if (textBox2.Text != "") return textBox2.Text;
                else return "1";
            }
            set { textBox2.Text = value; }
        }
        public string C
        {
            get {
                if (textBox3.Text != "") return textBox3.Text;
                else return "1";
            }
            set { textBox3.Text = value; }
        }
        public Quadratic()
        {
            TopMost = true;
            InitializeComponent();
            
            this.Cursor = Cursors.Hand;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Quadratic_Load(object sender, EventArgs e)
        {
            
            A = "1";
            B = "1";
            C = "1";
        }
    }
}
