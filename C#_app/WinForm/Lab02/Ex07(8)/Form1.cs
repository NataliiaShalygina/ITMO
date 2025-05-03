using System;
using System.Windows.Forms;

namespace RegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Label lbl = new Label();
            TextBox txt = new TextBox();
            txt.KeyPress += new
            KeyPressEventHandler(this.textBox2_KeyPress);
            if (checkBox1.Checked == true)
            {
                
                lbl.Location = new System.Drawing.Point(16, 96);
                lbl.Size = new System.Drawing.Size(32, 23);
                lbl.Name = "labelll";
                lbl.TabIndex = 2;
                lbl.Text = "PIN2";
                groupBox1.Controls.Add(lbl);
                
                txt.Location = new System.Drawing.Point(96, 96);
                txt.Size = new System.Drawing.Size(184, 20);
                txt.Name = "textboxx";
                txt.TabIndex = 1;
                txt.Text = "";
                groupBox1.Controls.Add(txt);
                
            }
            else
            {
                int lcv;
                lcv = groupBox1.Controls.Count;// определяется количество элементов

                while (lcv > 4)
                {
                    groupBox1.Controls.RemoveAt(lcv - 1);
                    lcv -= 1;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                errorProvider1.SetError(textBox1, "Must be letter");
                e.Handled = true;
                MessageBox.Show("Поле Name не может содержать цифры");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле PIN не может содержать буквы");
            }

        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            //if (textBox2.Text == "")
            //{
            //    e.Cancel = false;
            //}
            //else
            //{
            //    try
            //    {
            //        double.Parse(textBox2.Text);
            //        e.Cancel = false;
            //    }
            //    catch
            //    {
            //        e.Cancel = true;
            //        MessageBox.Show("Поле PIN не может содержать буквы");
            //    }
            //}
        }
    }
}
