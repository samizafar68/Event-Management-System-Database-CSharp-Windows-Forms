using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Event_Management_System
{
    public partial class login : Form
    {
        OracleConnection con;
        public login()
        {
            InitializeComponent();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            password_textBox.PasswordChar = show_checkBox.Checked ? '\0' : '*';
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string username = user_textBox.Text;
            string password = password_textBox.Text;
            Admin obj = new Admin();
            if (ValidateUser(username, password))
            {
                MessageBox.Show("Login Successful!");
                this.Hide();
                obj.Show();
                // Perform actions after successful login
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
                return;
            }
        }

        private bool ValidateUser(string username, string password)
        {
            // Replace "YourOracleConnectionString" with your actual Oracle connection string
            string conStr = @"DATA SOURCE =localhost:1521/xe;USER ID=DatabaseProject;PASSWORD=9200";
            using (OracleConnection connection = new OracleConnection(conStr))
            {
                connection.Open();

                using (OracleCommand command = new OracleCommand("SELECT COUNT(*) FROM LOGIN WHERE Username = :Username AND Password = :Password", connection))
                {
                    command.Parameters.Add("Username", OracleDbType.Varchar2).Value = username;
                    command.Parameters.Add("Password", OracleDbType.Varchar2).Value = password;

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        private void login_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE =localhost:1521/xe;USER ID=DatabaseProject;PASSWORD=9200";
            con = new OracleConnection(conStr);
           // updateGrid();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Home obj=new Home();
            this.Hide();
            obj.Show();
        }

        private void user_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_label_Click(object sender, EventArgs e)
        {

        }

        private void username_label_Click(object sender, EventArgs e)
        {

        }

        private void login_label_Click(object sender, EventArgs e)
        {

        }
    }
}
