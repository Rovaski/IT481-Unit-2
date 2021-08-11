using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace IT481_Unit_2
{
    public partial class CustomerViewForm : Form
    {
        string dbConnectString = @"Provider=SQLOLEDB;Data Source = KRAKEN\WAVES;Initial Catalog = Northwind; Trusted_Connection=yes;";

        public CustomerViewForm()
        {
            InitializeComponent();
        }

        private void CustomerViewForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDatabase();

                connectionStatusValue.Text = "Connected";

                CloseDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error," + ex);
            }
        }

        private void loadDatabaseButton_Click(object sender, EventArgs e)
        {
            OleDbCommand command = new OleDbCommand();

            command.Connection = LoadDatabase();
            command.CommandText = "SELECT * FROM Customers";

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);

            CustomerGridView.DataSource = dt;

            CloseDatabase();
        }

        private void UpdateCustomerCount()
        {
            OleDbCommand command = new OleDbCommand();

            command.Connection = LoadDatabase();
            command.CommandText = "SELECT * FROM Customers";

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);

            CustomerCountValue.Text = dt.Rows.Count.ToString();

            CloseDatabase();
        }

        private OleDbConnection LoadDatabase()
        {
            OleDbConnection dbConnection = new OleDbConnection();
            dbConnection.ConnectionString = dbConnectString;
            dbConnection.Open();

            return dbConnection;
        }

        private void CloseDatabase()
        {
            OleDbConnection dbConnection = new OleDbConnection();
            dbConnection.ConnectionString = dbConnectString;
            dbConnection.Close();
        }

        private void CustomerCountUpdateButton_Click(object sender, EventArgs e)
        {
            UpdateCustomerCount();
        }
    }
}
