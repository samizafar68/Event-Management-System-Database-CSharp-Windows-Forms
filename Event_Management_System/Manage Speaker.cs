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
    public partial class Manage_Speaker : Form
    {
        OracleConnection con;
        public Manage_Speaker()
        {
            InitializeComponent();
        }

        private void Insert_button_Click(object sender, EventArgs e)
        {
            // Assuming 'con' is your OracleConnection object

            con.Open();

            // Assuming 'richTextBox1', 'richTextBox6', 'dateTimePicker1', 'richTextBox3', 'richTextBox5', 'richTextBox4' are your input controls
            OracleCommand insertEmp = con.CreateCommand();
            insertEmp.CommandText = "INSERT INTO SPEAKER (SpeakerID, EventID, SpeakerName, Availibility, Bio, Email,Phone) " +
                                    "VALUES (:SpeakerID, :EventID, :SpeakerName, :Availibility, :Bio, :Email,:Phone)";

            insertEmp.Parameters.Add(":SpeakerID", OracleDbType.Int32).Value = Convert.ToInt32(richTextBox1.Text);
            insertEmp.Parameters.Add(":EventID", OracleDbType.Varchar2).Value = richTextBox7.Text;
            insertEmp.Parameters.Add(":SpeakerName", OracleDbType.Varchar2).Value = richTextBox2.Text; // Corrected conversion to DateTime
            insertEmp.Parameters.Add(":Availibility", OracleDbType.Varchar2).Value = richTextBox3.Text; // Assuming dateTimePicker1 includes both date and time
            insertEmp.Parameters.Add(":Bio", OracleDbType.Varchar2).Value = richTextBox4.Text;
            insertEmp.Parameters.Add(":Email", OracleDbType.Varchar2).Value = richTextBox5.Text;
            insertEmp.Parameters.Add(":Phone", OracleDbType.Varchar2).Value = richTextBox6.Text;

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

        private void Manage_Speaker_label_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE =localhost:1521/xe;USER ID=DatabaseProject;PASSWORD=9200";
            con = new OracleConnection(conStr);
            updateGrid();
        }
        private void updateGrid()
        {
            con.Open();
            OracleCommand getEmps = con.CreateCommand();
            getEmps.CommandText = "Select * From Speaker";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            dataGridView1.DataSource = empDT;
            con.Close();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            Admin obj = new Admin();
            this.Hide();
            obj.Show();
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            // Assuming 'con' is your OracleConnection object

            con.Open();

            // Assuming 'richTextBox1' is the control containing the ID of the speaker you want to delete
            OracleCommand deleteCommand = con.CreateCommand();
            deleteCommand.CommandText = "DELETE FROM SPEAKER WHERE SpeakerID = :SpeakerID";
            deleteCommand.Parameters.Add(":SpeakerID", OracleDbType.Int32).Value = Convert.ToInt32(richTextBox1.Text);

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

            // Assuming 'richTextBox1', 'richTextBox6', 'dateTimePicker1', 'richTextBox3', 'richTextBox5', 'richTextBox4' are your input controls
            OracleCommand insertEmp = con.CreateCommand();
            insertEmp.CommandText = "INSERT INTO SPEAKER (SpeakerID, EventID, SpeakerName, Availibility, Bio, Email,Phone) " +
                                    "VALUES (:SpeakerID, :EventID, :SpeakerName, :Availibility, :Bio, :Email,:Phone)";

            // Use int.TryParse to safely convert the string to an integer
            int speakerId;
            if (int.TryParse(richTextBox1.Text, out speakerId))
            {
                insertEmp.Parameters.Add(":SpeakerID", OracleDbType.Int32).Value = speakerId;
            }
            else
            {
                MessageBox.Show("Invalid Speaker ID. Please enter a valid integer.");
                con.Close();
                return; // Stop execution if the conversion fails
            }

            // Continue adding other parameters...
            insertEmp.Parameters.Add(":EventID", OracleDbType.Int32).Value = Convert.ToInt32(richTextBox7.Text);
            insertEmp.Parameters.Add(":SpeakerName", OracleDbType.Varchar2).Value = richTextBox2.Text;
            insertEmp.Parameters.Add(":Availibility", OracleDbType.Varchar2).Value = richTextBox3.Text;
            insertEmp.Parameters.Add(":Bio", OracleDbType.Varchar2).Value = richTextBox4.Text;
            insertEmp.Parameters.Add(":Email", OracleDbType.Varchar2).Value = richTextBox5.Text;
            insertEmp.Parameters.Add(":Phone", OracleDbType.Varchar2).Value = richTextBox6.Text;

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
    }
}
