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
        public CustomerViewForm()
        {
            InitializeComponent();
        }

        private void CustomerViewForm_Load(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.IsLoggedIn = false;
            frm.ShowDialog();

            if (!frm.IsLoggedIn)
            {
                this.Close();
                Application.Exit();
                return;
            }

            loadTableButton.Enabled = false;
            TableCountUpdateButton.Enabled = false;

        }

        private void loadDatabaseButton_Click(object sender, EventArgs e)
        {
            try
            {
                string TableToLoad = TableSelectionBox.SelectedItem.ToString();
                CustomerGridView.DataSource = dbManager.LoadTable(TableToLoad);
                dbManager.CloseDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show("You don't have access to this table, try another.");
            }
        }

        private void UpdateCustomerCount()
        {
            try
            {
                string TableToLoad = TableSelectionBox.SelectedItem.ToString();
                TableCountValue.Text = dbManager.TableCount(TableToLoad).Rows.Count.ToString();
                dbManager.CloseDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show("You don't have access to this table, try another.");
            }

        }

        private void CustomerCountUpdateButton_Click(object sender, EventArgs e)
        {
            UpdateCustomerCount();
        }

        private void TableSelectionBox_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TableSelectionBox.Text))
            {
                loadTableButton.Enabled = false;
                TableCountUpdateButton.Enabled = false;
            } else
            {
                loadTableButton.Enabled = true;
                TableCountUpdateButton.Enabled = true;
            }
        }
    }
}
