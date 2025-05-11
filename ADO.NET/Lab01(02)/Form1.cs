using System;

namespace DBConnection
{
    public partial class Form1 : Form
    {
        OleDbConnection connection = new OleDbConnection();

        //string testConnect = @"Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Northwind;Data Source=DESKTOP-LE67O4M\SQLEXPRESS";
        public Form1()
        {

            InitializeComponent();
            this.connection.StateChange += new System.Data.StateChangeEventHandler(this.connection_StateChange);
            disconnect_Menu.Enabled =
                (false);
        }
        static string GetConnectionStringByName(string name)
        {
            string returnValue = null;
            ConnectionStringSettings settings =
                ConfigurationManager.ConnectionStrings[name];
            if (settings != null)
                returnValue = settings.ConnectionString;
            return returnValue;
        }
        string testConnect = GetConnectionStringByName("DBConnect.NorthwindConnectionString");

        private void connectMenu_Click(object sender, EventArgs e)
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
            catch (Exception Xcp)
            {
                MessageBox.Show(Xcp.Message, "Unexpected Exception",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void disconnect_Menu_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                    MessageBox.Show("Соединение с базой данных закрыто");
                }
                else
                    MessageBox.Show("Соединение уже закрыто");
            }
            catch (Exception Xcp)
            {
                MessageBox.Show(Xcp.Message, "Unexpected Exception",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void connection_StateChange(object sender, System.Data.StateChangeEventArgs e)
        {
            connectMenu.Enabled =
                (e.CurrentState == ConnectionState.Closed);
            disconnect_Menu.Enabled =
                (e.CurrentState == ConnectionState.Open);
        }

        private void connection_List_Click(object sender, EventArgs e)
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)

            {

                MessageBox.Show("Сначала подключитесь к базе");

                return;

            }

            OleDbCommand command = new OleDbCommand();

            command.Connection = connection;

            command.CommandText = "SELECT COUNT(*) FROM Products";

            int number = (int)command.ExecuteScalar();

            label1.Text = number.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)

            {

                MessageBox.Show("Сначала подключитесь к базе");

                return;

            }
            OleDbCommand command = connection.CreateCommand();
            
            command.CommandText = "SELECT ProductName FROM Products";

            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())

            {

                listView1.Items.Add(reader["ProductName"].ToString());

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(testConnect);
            connection.Open();
            OleDbTransaction OleTran = connection.BeginTransaction();
            OleDbCommand command = connection.CreateCommand();
            command.Transaction = OleTran;
            try
            {
                command.CommandText =
              "INSERT INTO Products (ProductName) VALUES('Wrong size')";
                command.ExecuteNonQuery();
                command.CommandText =
               "INSERT INTO Products (ProductName) VALUES('Wrong color')";
                command.ExecuteNonQuery();

                OleTran.Commit();
                MessageBox.Show("Both records were written to database");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                try
                {
                    OleTran.Rollback();
                }
                catch (Exception exRollback)
                {
                    MessageBox.Show(exRollback.Message);
                }

            }
            finally
            {
                connection.Close();
            }

        }
    }
}
