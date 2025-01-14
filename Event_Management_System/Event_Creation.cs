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
    public partial class Event_Creation : Form
    {
        OracleConnection con;
        public Event_Creation()
        {
            InitializeComponent();
        }

        private void Insert_button_Click(object sender, EventArgs e)
        {
            

            // Assuming 'con' is your OracleConnection object

            con.Open();

            // Assuming 'richTextBox1', 'richTextBox6', 'dateTimePicker1', 'richTextBox3', 'richTextBox5', 'richTextBox4' are your input controls
            OracleCommand insertEmp = con.CreateCommand();
            insertEmp.CommandText = "INSERT INTO EVENT_CREATION (EventID, EventName, EventDate, EventTime, Location, Description,EVENTFEE) " +
                                    "VALUES (:EventID, :EventName, :EventDate, :EventTime, :Location, :Description,:EVENTFEE)";

            insertEmp.Parameters.Add(":EventID", OracleDbType.Int32).Value = Convert.ToInt32(richTextBox1.Text);
            insertEmp.Parameters.Add(":EventName", OracleDbType.Varchar2).Value = richTextBox6.Text;
            insertEmp.Parameters.Add(":EventDate", OracleDbType.Date).Value = dateTimePicker1.Value.Date; // Corrected conversion to DateTime
            insertEmp.Parameters.Add(":EventTime", OracleDbType.Varchar2).Value = Time_richTextBox.Text; // Assuming dateTimePicker1 includes both date and time
            insertEmp.Parameters.Add(":Location", OracleDbType.Varchar2).Value = richTextBox5.Text;
            insertEmp.Parameters.Add(":Description", OracleDbType.Varchar2).Value = richTextBox4.Text;
            insertEmp.Parameters.Add(":EVENTFEE", OracleDbType.Int32).Value = Convert.ToInt32(EventFee_richTextBox.Text);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Event_Creation_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE =localhost:1521/xe;USER ID=DatabaseProject;PASSWORD=9200";
            con =new OracleConnection(conStr);
            updateGrid();
        }

        private void updateGrid()
        {
            con.Open();
            OracleCommand getEmps=con.CreateCommand();
            getEmps.CommandText = "Select * From Event_Creation";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR=getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            dataGridView1.DataSource = empDT;
            con.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            // Assuming 'con' is your OracleConnection object

            con.Open();

            // Assuming 'richTextBox1' is the control containing the ID of the record you want to delete
            OracleCommand deleteCommand = con.CreateCommand();
            deleteCommand.CommandText = "DELETE FROM EVENT_CREATION WHERE EventID = :EventID";
            deleteCommand.Parameters.Add(":EventID", OracleDbType.Int32).Value = Convert.ToInt32(richTextBox1.Text);

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

            OracleCommand updateCommand = null;

            try
            {
                con.Open();

                updateCommand = con.CreateCommand();
                updateCommand.CommandText = "UPDATE EVENT_CREATION SET EventName = :EventName, EventDate = :EventDate, EventTime = :EventTime, Location = :Location, Description = :Description,EVENTFEE= :EVENTFEE WHERE EventID = :EventID";
                updateCommand.Parameters.Add(":EventID", OracleDbType.Int32).Value = Convert.ToInt32(richTextBox1.Text);
                updateCommand.Parameters.Add(":EventName", OracleDbType.Varchar2).Value = richTextBox6.Text;
                updateCommand.Parameters.Add(":EventDate", OracleDbType.Date).Value = dateTimePicker1.Value.Date;
                updateCommand.Parameters.Add(":EventTime", OracleDbType.Varchar2).Value = Time_richTextBox.Text;
                updateCommand.Parameters.Add(":Location", OracleDbType.Varchar2).Value = richTextBox5.Text;
                updateCommand.Parameters.Add(":Description", OracleDbType.Varchar2).Value = richTextBox4.Text;
                updateCommand.Parameters.Add(":EVENTFEE", OracleDbType.Int32).Value = Convert.ToInt32(EventFee_richTextBox.Text);
                updateCommand.CommandType = CommandType.Text;

                int rows = updateCommand.ExecuteNonQuery();

                if (rows > 0)
                    MessageBox.Show("Data Updated Successfully!");
                else
                    MessageBox.Show("No matching records found for update");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + "\n" + updateCommand?.CommandText);
            }
            finally
            {
                con.Close();
                updateGrid();  // Assuming 'updateGrid' is a method to refresh your grid after updating data
            }

        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            Admin  obj=new Admin();
            this.Hide();
            obj.Show();
        }
    }
}
