using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT481_Unit_2
{
    public partial class LoginForm : Form
    {
        public bool IsLoggedIn { get; set; }
        private string dbConnectString = "";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void SubmitLoginButton_Click(object sender, EventArgs e)
        {
            string serverName = ServerTextBox.Text;
            string databaseName = DatabaseTextBox.Text;
            string userName = UsernameTextBox.Text;
            string passcode = PasscodeTextBox.Text;

            try
            {
                
                dbManager.InitDatabase(serverName, databaseName, userName, passcode);
                IsLoggedIn = true;
                dbManager.CloseDatabase();
                this.Close();                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login failed, good bye.");
                IsLoggedIn = false;
                this.Close();
            }

        }
    }
}
