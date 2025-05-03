using System;

namespace Ex01
{
    public partial class nForm : Form
    {
        public nForm()
        {
            InitializeComponent();
        }

        private bool nclose = false;
        public new void Close()
        {
           nclose = true; 
           base.Close();
        }
        private void nForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (checkBoxClose.Checked) return;
            if (nclose) return;
            e.Cancel = true;
            Hide();
        }

  

        private void nForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
