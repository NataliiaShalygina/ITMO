using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace DatasetDesigner
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void GetCustomersButton_Click(object sender, EventArgs e)
        {
            NorthwindDataSet NorthwindDataset1 = new NorthwindDataSet();
            NorthwindDataSetTableAdapters.CustomersTableAdapter CustomersTableAdapter1 = 
                new NorthwindDataSetTableAdapters.CustomersTableAdapter();
            CustomersTableAdapter1.Fill(NorthwindDataset1.Customers);
            foreach (NorthwindDataSet.CustomersRow NWCustomer in
                             NorthwindDataset1.Customers.Rows)
            {
                CustomersListBox.Items.Add(NWCustomer.CompanyName);
            }
        }
    }
}
