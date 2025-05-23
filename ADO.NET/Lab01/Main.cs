﻿using System;
using System.Data.SqlClient;
using System.Configuration;


namespace DBConnection
{
    public partial class Main : Form
    {
        
        OleDbConnection connection = new OleDbConnection();
        
        //string testConnect = @"Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Northwind;Data Source=(local)";
        
        public Main()
        {
            InitializeComponent();
            this.connection.StateChange += new System.Data.StateChangeEventHandler(this.connection_StateChange);  
        }

       static string GetConnectionStringByName(string name)
        {
            string returnValue = null;
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[name];
            if (settings != null)
                returnValue = settings.ConnectionString;
            return returnValue;
        }

        string testConnect = GetConnectionStringByName("DBConnect.NorthwindConnectionString");

        private void connection_StateChange(object sender, System.Data.StateChangeEventArgs e)
        {
            подключитьсяToolStripMenuItem.Enabled = e.CurrentState == ConnectionState.Closed;
            отключитьсяToolStripMenuItem.Enabled = e.CurrentState == ConnectionState.Open;
        }

        
        private void подключитьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = testConnect;
                    connection.Open();
                    MessageBox.Show("Соединение с базой данных выполнено успешно");
                }
                else
                    MessageBox.Show("Соединение с базой данных уже установлено");
            }
            catch (OleDbException XcpSQL)
            {
                foreach (OleDbError se in XcpSQL.Errors)
                {
                    MessageBox.Show(se.Message,
                        "SQL Error code " + se.NativeError,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception Xcp)
            {
                MessageBox.Show(Xcp.Message, "Unexpected Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void отключитьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Соединение с базой данных закрыто");
            }
            else
                MessageBox.Show("Соединение с базой данных уже закрыто");

        }

        private void списокПодключенийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;
            if (settings != null)
            {
                foreach (ConnectionStringSettings cs in settings)
                {
                    MessageBox.Show("name = " + cs.Name);
                    MessageBox.Show("providerName = " + cs.ProviderName);
                    MessageBox.Show("connectionString = " + cs.ConnectionString);
                }
            }
        }
    }
}
