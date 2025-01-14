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
    public partial class user_creation_Account : Form
    {
        OracleConnection con;
        public user_creation_Account()
        {
            InitializeComponent();
        }

        private void user_creation_Account_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE =localhost:1521/xe;USER ID=DatabaseProject;PASSWORD=9200";
            con = new OracleConnection(conStr);
        }

        private void new_user_showpassword_checkBox_CheckedChanged(object sender, EventArgs e)
        {

            new_password_textBox.PasswordChar = new_user_showpassword_checkBox.Checked ? '\0' : '*';
            confirmpass_textBox.PasswordChar = new_user_showpassword_checkBox.Checked ? '\0' : '*';
        }

        private void created_button_Click(object sender, EventArgs e)
        {
            string newPassword = new_password_textBox.Text;
            string confirmPassword = confirmpass_textBox.Text;

            if (newPassword == confirmPassword)
            {
                // MessageBox.Show("Account Created successfully.!");
            }
            else
            {
                MessageBox.Show("Passwords do not match. Please try again.");
                return;
            }
            if (confirm_pass_checkBox1.Checked)
            {
              //  MessageBox.Show("Both checkboxes are checked.");
            }
            else
            {
                MessageBox.Show("Please fill confirm boxe for confirmation.");
                return;
            }


            // Assuming 'con' is your OracleConnection object

            con.Open();

            // Assuming 'richTextBox1', 'richTextBox6', 'dateTimePicker1', 'richTextBox3', 'richTextBox5', 'richTextBox4' are your input controls
            OracleCommand insertEmp = con.CreateCommand();
            insertEmp.CommandText = "INSERT INTO USER_TABLE (username, password) " +
                                    "VALUES (:username, :password)";

            insertEmp.Parameters.Add(":username", OracleDbType.Varchar2).Value = n_user_textBox.Text; // Corrected conversion to DateTime
            insertEmp.Parameters.Add(":password", OracleDbType.Varchar2).Value = new_password_textBox.Text; // Assuming dateTimePicker1 includes both date and time
           
            insertEmp.CommandType = CommandType.Text;

            try
            {
                int rows = insertEmp.ExecuteNonQuery();
                if (rows > 0)
                    MessageBox.Show("Data Inserted Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
               // updateGrid();  // Assuming 'updateGrid' is a method to refresh your grid after inserting data
            }
            User_login obj=new User_login();
            this.Hide();
            obj.Show();
        }

        private void user_new_cros_label_Click(object sender, EventArgs e)
        {
            User_login obj = new User_login();
            this.Hide();
            obj.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
