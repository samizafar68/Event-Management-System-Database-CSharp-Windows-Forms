using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
namespace Event_Management_System
{
    public partial class Participant_Registration : Form
    {
        OracleConnection con;
        public Participant_Registration()
        {
            InitializeComponent();
        }
        private void Participant_Registration_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE =localhost:1521/xe;USER ID=DatabaseProject;PASSWORD=9200";
            con = new OracleConnection(conStr);
            updateGrid();

        }
        private void updateGrid()
        {
            con.Open();
            OracleCommand getEmps = con.CreateCommand();
            getEmps.CommandText = "Select * From ParticipantRegistration";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            Register_dataGridView1.DataSource = empDT;
            con.Close();
        }
        
        private void Insert_button_Click(object sender, EventArgs e)
        {
            // Assuming 'con' is your OracleConnection object
            if (Notification_checkBox.Checked)
            {
                //  MessageBox.Show("Both checkboxes are checked.")
            }
            else
            {
                MessageBox.Show("Please send Notification for confirmation.");
                return;
            }

            con.Open();
            // Assuming 'richTextBox1', 'richTextBox6', 'dateTimePicker1', 'richTextBox3', 'richTextBox5', 'richTextBox4' are your input controls
            OracleCommand insertEmp = con.CreateCommand();

            insertEmp.CommandText = "INSERT INTO ParticipantRegistration (ParticipantRegistrationID,  EventID, Name, RegistrationDate,RegistrationStatus, Email, Payment) " +
                                    "VALUES (:ParticipantRegistrationID,  :EventID, :Name, :RegistrationDate,:RegistrationStatus, :Email, :Payment)";

            insertEmp.Parameters.Add(":ParticipantRegistrationID", OracleDbType.Int32).Value = Convert.ToInt32(Register_Id__richTextBox2.Text);
            insertEmp.Parameters.Add(":EVENTID", OracleDbType.Int32).Value = Convert.ToInt32(Event_Rg__richTextBox1.Text);
            insertEmp.Parameters.Add(":Name", OracleDbType.Varchar2).Value = Rg_Name__richTextBox6.Text; // Corrected conversion to DateTime
            insertEmp.Parameters.Add(":RegistrationDate", OracleDbType.TimeStamp).Value = Register_dateTimePicker1.Value; // Assuming dateTimePicker1 includes both date and time
            insertEmp.Parameters.Add(":RegistrationStatus", OracleDbType.Varchar2).Value = Rg_Status_richTextBox3.Text;
            insertEmp.Parameters.Add(":Email", OracleDbType.Varchar2).Value = Rg_Email_richTextBox5.Text;
            insertEmp.Parameters.Add(":Payment", OracleDbType.Decimal).Value = Rg_Payment__richTextBox4.Text;
            
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
                updateGrid();  // Assuming 'updateGrid' is a method to refresh your grid after inserting data
            }

            Notification_checkBox.Checked = false;
            return;

        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            User obj = new User();
            this.Hide();
            obj.Show();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            con.Open();
            // Assuming 'richTextBox1', 'richTextBox6', 'dateTimePicker1', 'richTextBox3', 'richTextBox5', 'richTextBox4' are your input controls
            OracleCommand insertEmp = con.CreateCommand();
            insertEmp.CommandText = "INSERT INTO Notification (NotificationID,  NotificationDate,NotificationDetails) " +
                                  "VALUES (NotificationSeq.NEXTVAL,  :NotificationDate,:NotificationDetails)";
          //  insertEmp.Parameters.Add("NotificationID", OracleDbType.Int32).Value = Convert.ToInt32();
            insertEmp.Parameters.Add(":NotificationDate", OracleDbType.Date).Value = Register_dateTimePicker1.Value;
            insertEmp.Parameters.Add(":NotificationDetails", OracleDbType.Varchar2).Value = Rg_Email_richTextBox5.Text;


            
            insertEmp.CommandType = CommandType.Text;

            try
            {
                int rows = insertEmp.ExecuteNonQuery();
                if (rows > 0)
                    MessageBox.Show("Send Notification Successfully!");
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


        }
    }
}
