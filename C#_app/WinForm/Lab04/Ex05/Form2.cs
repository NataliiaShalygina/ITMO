using System;
using System.Windows.Forms;

namespace Ex05
{
    public partial class Form2 : Form
    {
        public bool radians = true;

        public decimal min
        {
            get { return numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }

        public decimal max 
        {
            get { return numericUpDown2.Value; }
            set { numericUpDown2.Value = value; }
        }

        
        public Form2()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radians = true;
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown2.DecimalPlaces = 2;
            numericUpDown1.Increment = (decimal)0.01;
            numericUpDown2.Increment = (decimal)0.01;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radians = false;
            numericUpDown1.DecimalPlaces = 0;
            numericUpDown2.DecimalPlaces = 0;
            numericUpDown1.Increment = 1;
            numericUpDown2.Increment = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
               
        }
    }
}
