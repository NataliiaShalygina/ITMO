﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DataBindingComplex
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void BindGridButton_Click(object sender, EventArgs e)
        {
            productsTableAdapter1.Fill(northwindDataSet1.Products);
            BindingSource productsBindingSource = new BindingSource(northwindDataSet1, "Products");
            ProductsGrid.DataSource = productsBindingSource;
            bindingNavigator1.BindingSource = productsBindingSource;
        }
    }
}
