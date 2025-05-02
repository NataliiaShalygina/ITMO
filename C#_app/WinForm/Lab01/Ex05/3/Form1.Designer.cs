namespace Ex0503
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnModel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.TextBox();
            this.txtDta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnModel
            // 
            this.btnModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModel.Location = new System.Drawing.Point(219, 144);
            this.btnModel.Name = "btnModel";
            this.btnModel.Size = new System.Drawing.Size(94, 29);
            this.btnModel.TabIndex = 0;
            this.btnModel.Text = "Отправить";
            this.btnModel.UseVisualStyleBackColor = false;
            this.btnModel.Click += new System.EventHandler(this.btnModel_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите данные";
            // 
            // lblData
            // 
            this.lblData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblData.Location = new System.Drawing.Point(179, 42);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(151, 27);
            this.lblData.TabIndex = 2;
            // 
            // txtDta
            // 
            this.txtDta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDta.Location = new System.Drawing.Point(12, 95);
            this.txtDta.Multiline = true;
            this.txtDta.Name = "txtDta";
            this.txtDta.Size = new System.Drawing.Size(162, 155);
            this.txtDta.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 300);
            this.Controls.Add(this.txtDta);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnModel;
        private Label label1;
        private TextBox lblData;
        private TextBox txtDta;
    }
}
