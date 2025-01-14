using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
namespace Event_Management_System
{
    public partial class User_login : Form
    {
        OracleConnection con;
        public User_login()
        {
            InitializeComponent();
        }

        private void user_show_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            user_password_textBox.PasswordChar = user_show_checkBox.Checked ? '\0' : '*';

        }

        private void user_back_label_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            this.Hide();
            obj.Show();
        }

        private void Sign_user_button_Click(object sender, EventArgs e)
        {
            user_creation_Account obj=new user_creation_Account();
            this.Hide();
            obj.Show();
        }

        private void user_login_button_Click(object sender, EventArgs e)
        {
            string username = username_textBox.Text;
            string password = user_password_textBox.Text;
            User obj = new User();
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

                using (OracleCommand command = new OracleCommand("SELECT COUNT(*) FROM USER_TABLE WHERE Username = :Username AND Password = :Password", connection))
                {
                    command.Parameters.Add("Username", OracleDbType.Varchar2).Value = username;
                    command.Parameters.Add("Password", OracleDbType.Varchar2).Value = password;

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }
        }
        private void User_login_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE =localhost:1521/xe;USER ID=DatabaseProject;PASSWORD=9200";
            con = new OracleConnection(conStr);
        }
    }
}
