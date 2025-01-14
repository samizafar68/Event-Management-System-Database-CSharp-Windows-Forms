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
    public partial class Create_Session : Form
    {
        OracleConnection con;
        public Create_Session()
        {
            InitializeComponent();
        }

        private void Insert_button_Click(object sender, EventArgs e)
        {
            // Assuming 'con' is your OracleConnection object

            con.Open();

            // Assuming 'richTextBox1', 'richTextBox6', 'dateTimePicker1', 'richTextBox3', 'richTextBox5', 'richTextBox4' are your input controls
            OracleCommand insertEmp = con.CreateCommand();
            insertEmp.CommandText = "INSERT INTO Event_SESSION (SESSIONID, EVENTID, SESSIONNAME, STARTTIME,ENDTIME, LOCATION, DESCRIPTION,SPEAKERID) " +
                                    "VALUES (:SESSIONID, :EVENTID, :SESSIONNAME, :STARTTIME,:ENDTIME,:LOCATION, :DESCRIPTION,:SPEAKERID)";

            insertEmp.Parameters.Add(":SESSIONID", OracleDbType.Int32).Value = Convert.ToInt32(Session_richTextBox1.Text);
            insertEmp.Parameters.Add(":EVENTID", OracleDbType.Int32).Value = Convert.ToInt32(Session_richTextBox6.Text);
            insertEmp.Parameters.Add(":SESSIONNAME", OracleDbType.Varchar2).Value = Session_richTextBox2.Text; // Corrected conversion to DateTime
            insertEmp.Parameters.Add(":STARTTIME", OracleDbType.TimeStamp).Value = Session_dateTimePicker1.Value; // Assuming dateTimePicker1 includes both date and time
            insertEmp.Parameters.Add(":ENDTIME", OracleDbType.TimeStamp).Value = Session_dateTimePicker2.Value;
            insertEmp.Parameters.Add(":LOCATION", OracleDbType.Varchar2).Value = Session_richTextBox3.Text;
            insertEmp.Parameters.Add(":DESCRIPTION", OracleDbType.Varchar2).Value = Session_richTextBox5.Text;
            try
            {
                int speakerID = Convert.ToInt32(Session_richTextBox4.Text);
                insertEmp.Parameters.Add(":SPEAKERID", OracleDbType.Int32).Value = speakerID;
            }
            catch (FormatException)
            {
                // Handle the case where the user entered a non-numeric value
                MessageBox.Show("Error: Please enter a valid numeric value for Speaker ID.");
            }

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

        }

        private void Create_Session_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE =localhost:1521/xe;USER ID=DatabaseProject;PASSWORD=9200";
            con = new OracleConnection(conStr);
            updateGrid();
        }
        private void updateGrid()
        {
            con.Open();
            OracleCommand getEmps = con.CreateCommand();
            getEmps.CommandText = "Select * From Event_Session";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            Session_dataGridView1.DataSource = empDT;
            con.Close();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            Admin obj =new Admin();
            this.Hide();
            obj.Show();
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            // Assuming 'con' is your OracleConnection object

            con.Open();

            // Assuming 'Session_richTextBox1' is the control containing the SessionID of the record you want to delete
            OracleCommand deleteCommand = con.CreateCommand();
            deleteCommand.CommandText = "DELETE FROM Event_SESSION WHERE SESSIONID = :SESSIONID";
            deleteCommand.Parameters.Add(":SESSIONID", OracleDbType.Int32).Value = Convert.ToInt32(Session_richTextBox1.Text);

            deleteCommand.CommandType = CommandType.Text;

            try
            {
                int rows = deleteCommand.ExecuteNonQuery();
                if (rows > 0)
                    MessageBox.Show("Data Deleted Successfully!");
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

        private void Update_button_Click(object sender, EventArgs e)
        {
            // Assuming 'con' is your OracleConnection object
            con.Open();

            // Assuming 'Session_richTextBox1', 'Session_richTextBox6', 'Session_dateTimePicker1', 'Session_richTextBox3', 'Session_richTextBox5', 'Session_richTextBox4' are your input controls
            OracleCommand updateSession = con.CreateCommand();
            updateSession.CommandText = "UPDATE Event_SESSION " +
                                        "SET EVENTID = :EVENTID, SESSIONNAME = :SESSIONNAME, STARTTIME = :STARTTIME, ENDTIME = :ENDTIME, " +
                                        "LOCATION = :LOCATION, DESCRIPTION = :DESCRIPTION, SPEAKERID = :SPEAKERID " +
                                        "WHERE SESSIONID = :SESSIONID";

            updateSession.Parameters.Add(":SESSIONID", OracleDbType.Int32).Value = Convert.ToInt32(Session_richTextBox1.Text);
            updateSession.Parameters.Add(":EVENTID", OracleDbType.Int32).Value = Convert.ToInt32(Session_richTextBox6.Text);
            updateSession.Parameters.Add(":SESSIONNAME", OracleDbType.Varchar2).Value = Session_richTextBox2.Text;
            updateSession.Parameters.Add(":STARTTIME", OracleDbType.TimeStamp).Value = Session_dateTimePicker1.Value;
            updateSession.Parameters.Add(":ENDTIME", OracleDbType.TimeStamp).Value = Session_dateTimePicker2.Value;
            updateSession.Parameters.Add(":LOCATION", OracleDbType.Varchar2).Value = Session_richTextBox3.Text;
            updateSession.Parameters.Add(":DESCRIPTION", OracleDbType.Varchar2).Value = Session_richTextBox5.Text;
            updateSession.Parameters.Add(":SPEAKERID", OracleDbType.Int32).Value = Convert.ToInt32(Session_richTextBox4.Text);

            updateSession.CommandType = CommandType.Text;

            try
            {
                int rows = updateSession.ExecuteNonQuery();
                if (rows > 0)
                    MessageBox.Show("Data Updated Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
                updateGrid();  // Assuming 'updateGrid' is a method to refresh your grid after updating data
            }

        }
    }
}
