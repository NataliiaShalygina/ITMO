using System;
using System.Windows.Forms;

namespace Ex05
{
    public partial class Form1 : Form
    {
        List<string> list = new List<string>();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
            Form2 fm2 = new Form2();
            if (fm2.ShowDialog() == DialogResult.OK)
            {
                if (fm2.min < fm2.max)
                {
                    double min = (double)fm2.min;
                    double max = (double)fm2.max;
                    if (fm2.radians)
                    {
                        label2.Text = "от " + min.ToString()+" до " + max.ToString() + "\nРадиан";
                        double sinX;
                        double x = min;
                        while (x <= max)
                        {
                            sinX = Math.Round(SinCos(x), 2);
                            List_Add(sinX, Math.Round(x,2));

                            if (x + 0.10 > (max) && x < max)
                            {
                                sinX = Math.Round(SinCos(max), 2);
                                List_Add(sinX, Math.Round(max, 2));
                                break;
                            }
                            x = x + 0.10;

                        }
                    }
                    else
                    {
                        label2.Text = "от " + min.ToString() + " до " + max.ToString() + "\nГрадусов";
                        min = Math.PI * min / 180;
                        max = Math.PI * max / 180;
                        double sinX;
                        double x = min;
                        while (x <= (max))
                        {
                            sinX = Math.Round(SinCos(x), 2);
                            List_Add(sinX, Math.Round(Gradusy(x)));

                            if (x + (Math.PI * 10 / 180) > (max) && x < max)
                            {
                                sinX = Math.Round(SinCos(max), 2);
                                List_Add(sinX, Math.Round(Gradusy(max)));
                                break;
                            }
                            x = x + (Math.PI * 10 / 180);
                        }
                    }
                }
                else MessageBox.Show("от Меньшего к Большему");
                
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void List_Add (double sin, double x)
        {

            string sinx = x.ToString() + ": " + sin.ToString() + "\n";
            richTextBox1.AppendText(sinx);
            

        }
        private  static  double Gradusy (double x)
        {
            double y = 180 * x/ Math.PI;
            return y;
        }

        private double SinCos (double x)
        {
            if (radioButton1.Checked)
            {
                label3.Text = "sin";
                return  Math.Sin(x);
            }
            if (radioButton2.Checked) 
            {
                label3.Text = "cos";
                return Math.Cos(x);
            }
            return 0;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
