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
    public partial class User_Notification : Form
    {
        OracleConnection con;
        public User_Notification()
        {
            InitializeComponent();
        }

        private void User_Notification_Load(object sender, EventArgs e)
        {

            string conStr = @"DATA SOURCE =localhost:1521/xe;USER ID=DatabaseProject;PASSWORD=9200";
            con = new OracleConnection(conStr);
            updateGrid();
        }
        
        private void updateGrid()
        {
            con.Open();
            OracleCommand getEmps = con.CreateCommand();
            getEmps.CommandText = "SELECT * FROM Notification";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            Notifications_dataGridView1.DataSource = empDT;
            con.Close();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            User obj=new User();
            this.Hide();
            obj.Show();
        }

        private void Delete_Notification_button_Click(object sender, EventArgs e)
        {
            // Assuming 'con' is your OracleConnection object

            con.Open();

            // Assuming 'richTextBox1' is the control containing the ID of the speaker you want to delete
            OracleCommand deleteCommand = con.CreateCommand();
            deleteCommand.CommandText = "DELETE FROM Notification WHERE NotificationID = :NotificationID";
            deleteCommand.Parameters.Add(":NotificationID", OracleDbType.Int32).Value = Convert.ToInt32(Delet_NOTIFICationrichTextBox.Text);

            deleteCommand.CommandType = CommandType.Text;

            try
            {
                int rows = deleteCommand.ExecuteNonQuery();
                if (rows > 0)
                    MessageBox.Show("Ntification Deleted Successfully!");
                else
                    MessageBox.Show("No matching records found for deletion.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
                updateGrid();  // Assuming 'updateGrid' is a method to refresh your grid after deleting data
            }

        }
    }
}
