using Calculator;
using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class EngeneerCalc : SimpleCalculator.CalcUI
    {
        CalcUI mainForm;
        public EngeneerCalc(CalcUI form)
        {
            mainForm = form;
            InitializeComponent();
        }

        private void EngeneerCalc_Load(object sender, EventArgs e)
        {
            Menu.DropDownItems.Clear();
            ToolStripMenuItem calc = new ToolStripMenuItem("Обычный калькулятор");
            calc.Click += commonCalc_Click;
            Menu.DropDownItems.Add(calc);
        }
        private void commonCalc_Click(object sender, EventArgs e)
        {
            mainForm.Visible = true;
            this.Visible = false;
        }


        private void Degree_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eDegree);
        }

        private void Sqrt_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcSQRT();
        }

        private void Reverse_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcReverse();
        }

        private void Square_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcSquare();
        }

        private void Factorial_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(OutputDisplay.Text.Replace('.', ',')) < 27)
            {
                if (int.TryParse(OutputDisplay.Text,out int result) == true)
                {
                    OutputDisplay.Text = CalcEngine.CalcFactorial();
                }
                else
                {
                    OutputDisplay.Text = "Введите целое число!";
                }
            }
            else
            {
                OutputDisplay.Text = "Значение слишком большое.";
            }
        }

        private void Triangle_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcTriangle();
        }

        private void Quadratic_Click(object sender, EventArgs e)
        {
            Quadratic quadraticF = new Quadratic();
            if(quadraticF.ShowDialog() != DialogResult.OK){
                return;
            }
            double a = Convert.ToDouble(quadraticF.A.Replace('.', ','));
            double b = Convert.ToDouble(quadraticF.B.Replace('.', ','));
            double c = Convert.ToDouble(quadraticF.C.Replace('.', ','));
            double x1, x2;
            var discrim = Math.Pow(b, 2) - 4 * a * c;
            if (discrim < 0)
                OutputDisplay.Text = "Нет действительных корней";
            else
            {
                if(discrim == 0)
                {
                    x1 = -b / (2 * a);
                    x2 = x1;
                }
                else
                {
                    x1 = (-b + Math.Sqrt(discrim)) / (2 * a);
                    x2 = (-b - Math.Sqrt(discrim)) / (2 * a);
                }
                OutputDisplay.Text = $"Корни: x1 = {Math.Round(x1,2)}; x2 = {Math.Round(x2, 2)}";
            }

        }

     

        private async void AsyncFactorial_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(OutputDisplay.Text.Replace('.', ',')) < 27)
            {
                if (int.TryParse(OutputDisplay.Text, out int result) == true)
                {
                    OutDisplayFactorial.Text = await CalcEngine.FactorialAsync();

                }
                else
                {
                    OutputDisplay.Text = "Введите целое число!";
                }
            }
            else
            {
                OutputDisplay.Text = "Значение слишком большое.";
            }
        }
    }
}
