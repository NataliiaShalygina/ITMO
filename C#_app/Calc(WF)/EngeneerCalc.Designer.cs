namespace SimpleCalculator
{
    partial class EngeneerCalc
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Degree = new System.Windows.Forms.Button();
            this.Sqrt = new System.Windows.Forms.Button();
            this.Reverse = new System.Windows.Forms.Button();
            this.Square = new System.Windows.Forms.Button();
            this.Factorial = new System.Windows.Forms.Button();
            this.Triangle = new System.Windows.Forms.Button();
            this.Quadratic = new System.Windows.Forms.Button();
            this.AsyncFactorial = new System.Windows.Forms.Button();
            this.OutDisplayFactorial = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // VersionInfo
            // 
            this.VersionInfo.Size = new System.Drawing.Size(344, 20);
            // 
            // KeyExit
            // 
            this.KeyExit.Location = new System.Drawing.Point(296, 216);
            // 
            // KeyDate
            // 
            this.KeyDate.Location = new System.Drawing.Point(296, 168);
            // 
            // OutputDisplay
            // 
            this.OutputDisplay.Size = new System.Drawing.Size(344, 26);
            // 
            // KeyClear
            // 
            this.KeyClear.Location = new System.Drawing.Point(296, 120);
            // 
            // KeyEqual
            // 
            this.KeyEqual.Location = new System.Drawing.Point(296, 264);
            // 
            // Degree
            // 
            this.Degree.ForeColor = System.Drawing.Color.Red;
            this.Degree.Location = new System.Drawing.Point(200, 120);
            this.Degree.Name = "Degree";
            this.Degree.Size = new System.Drawing.Size(40, 40);
            this.Degree.TabIndex = 23;
            this.Degree.Text = "xª";
            this.toolTip1.SetToolTip(this.Degree, "Возведение в степень");
            this.Degree.UseVisualStyleBackColor = true;
            this.Degree.Click += new System.EventHandler(this.Degree_Click);
            // 
            // Sqrt
            // 
            this.Sqrt.ForeColor = System.Drawing.Color.Red;
            this.Sqrt.Location = new System.Drawing.Point(200, 168);
            this.Sqrt.Name = "Sqrt";
            this.Sqrt.Size = new System.Drawing.Size(40, 40);
            this.Sqrt.TabIndex = 23;
            this.Sqrt.Text = "√";
            this.toolTip1.SetToolTip(this.Sqrt, "Корень");
            this.Sqrt.UseVisualStyleBackColor = true;
            this.Sqrt.Click += new System.EventHandler(this.Sqrt_Click);
            // 
            // Reverse
            // 
            this.Reverse.ForeColor = System.Drawing.Color.Red;
            this.Reverse.Location = new System.Drawing.Point(200, 216);
            this.Reverse.Name = "Reverse";
            this.Reverse.Size = new System.Drawing.Size(40, 40);
            this.Reverse.TabIndex = 23;
            this.Reverse.Text = "1/x";
            this.toolTip1.SetToolTip(this.Reverse, "Обратное число");
            this.Reverse.UseVisualStyleBackColor = true;
            this.Reverse.Click += new System.EventHandler(this.Reverse_Click);
            // 
            // Square
            // 
            this.Square.ForeColor = System.Drawing.Color.Red;
            this.Square.Location = new System.Drawing.Point(200, 264);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(40, 40);
            this.Square.TabIndex = 23;
            this.Square.Text = "x²";
            this.toolTip1.SetToolTip(this.Square, "Квадрат числа");
            this.Square.UseVisualStyleBackColor = true;
            this.Square.Click += new System.EventHandler(this.Square_Click);
            // 
            // Factorial
            // 
            this.Factorial.ForeColor = System.Drawing.Color.Red;
            this.Factorial.Location = new System.Drawing.Point(248, 120);
            this.Factorial.Name = "Factorial";
            this.Factorial.Size = new System.Drawing.Size(40, 40);
            this.Factorial.TabIndex = 23;
            this.Factorial.Text = "x!";
            this.toolTip1.SetToolTip(this.Factorial, "Факториал (только целые)");
            this.Factorial.UseVisualStyleBackColor = true;
            this.Factorial.Click += new System.EventHandler(this.Factorial_Click);
            // 
            // Triangle
            // 
            this.Triangle.ForeColor = System.Drawing.Color.Red;
            this.Triangle.Location = new System.Drawing.Point(248, 168);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(40, 40);
            this.Triangle.TabIndex = 23;
            this.Triangle.Text = "³√x";
            this.toolTip1.SetToolTip(this.Triangle, "Кубический корень");
            this.Triangle.UseVisualStyleBackColor = true;
            this.Triangle.Click += new System.EventHandler(this.Triangle_Click);
            // 
            // Quadratic
            // 
            this.Quadratic.ForeColor = System.Drawing.Color.Red;
            this.Quadratic.Location = new System.Drawing.Point(248, 216);
            this.Quadratic.Name = "Quadratic";
            this.Quadratic.Size = new System.Drawing.Size(40, 40);
            this.Quadratic.TabIndex = 23;
            this.Quadratic.Text = "D";
            this.toolTip1.SetToolTip(this.Quadratic, "Квадратное уравнение");
            this.Quadratic.UseVisualStyleBackColor = true;
            this.Quadratic.Click += new System.EventHandler(this.Quadratic_Click);
            // 
            // AsyncFactorial
            // 
            this.AsyncFactorial.Font = new System.Drawing.Font("Microsoft Uighur", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AsyncFactorial.ForeColor = System.Drawing.Color.Red;
            this.AsyncFactorial.Location = new System.Drawing.Point(248, 264);
            this.AsyncFactorial.Name = "AsyncFactorial";
            this.AsyncFactorial.Size = new System.Drawing.Size(40, 40);
            this.AsyncFactorial.TabIndex = 23;
            this.AsyncFactorial.Text = "as x!";
            this.toolTip1.SetToolTip(this.AsyncFactorial, "Асихронный факториал");
            this.AsyncFactorial.UseVisualStyleBackColor = true;
            this.AsyncFactorial.Click += new System.EventHandler(this.AsyncFactorial_Click);
            // 
            // OutDisplayFactorial
            // 
            this.OutDisplayFactorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutDisplayFactorial.Location = new System.Drawing.Point(8, 91);
            this.OutDisplayFactorial.Name = "OutDisplayFactorial";
            this.OutDisplayFactorial.ReadOnly = true;
            this.OutDisplayFactorial.Size = new System.Drawing.Size(344, 20);
            this.OutDisplayFactorial.TabIndex = 24;
            this.OutDisplayFactorial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.OutDisplayFactorial, "Вывод асихронного фаториала");
            // 
            // EngeneerCalc
            // 
            this.ClientSize = new System.Drawing.Size(358, 309);
            this.Controls.Add(this.OutDisplayFactorial);
            this.Controls.Add(this.Square);
            this.Controls.Add(this.Reverse);
            this.Controls.Add(this.Sqrt);
            this.Controls.Add(this.AsyncFactorial);
            this.Controls.Add(this.Quadratic);
            this.Controls.Add(this.Triangle);
            this.Controls.Add(this.Factorial);
            this.Controls.Add(this.Degree);
            this.Name = "EngeneerCalc";
            this.Load += new System.EventHandler(this.EngeneerCalc_Load);
            this.Controls.SetChildIndex(this.Degree, 0);
            this.Controls.SetChildIndex(this.Factorial, 0);
            this.Controls.SetChildIndex(this.Triangle, 0);
            this.Controls.SetChildIndex(this.Quadratic, 0);
            this.Controls.SetChildIndex(this.AsyncFactorial, 0);
            this.Controls.SetChildIndex(this.Sqrt, 0);
            this.Controls.SetChildIndex(this.Reverse, 0);
            this.Controls.SetChildIndex(this.Square, 0);
            this.Controls.SetChildIndex(this.VersionInfo, 0);
            this.Controls.SetChildIndex(this.OutputDisplay, 0);
            this.Controls.SetChildIndex(this.KeyExit, 0);
            this.Controls.SetChildIndex(this.KeyClear, 0);
            this.Controls.SetChildIndex(this.KeyDate, 0);
            this.Controls.SetChildIndex(this.KeyEqual, 0);
            this.Controls.SetChildIndex(this.OutDisplayFactorial, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Degree;
        private System.Windows.Forms.Button Sqrt;
        private System.Windows.Forms.Button Reverse;
        private System.Windows.Forms.Button Square;
        private System.Windows.Forms.Button Factorial;
        private System.Windows.Forms.Button Triangle;
        private System.Windows.Forms.Button Quadratic;
        private System.Windows.Forms.Button AsyncFactorial;
        private System.Windows.Forms.TextBox OutDisplayFactorial;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
