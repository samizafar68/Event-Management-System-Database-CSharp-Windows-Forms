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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Event_Management_System
{
    public partial class Create_Activity : Form
    {
        OracleConnection con;
        public Create_Activity()
        {
            InitializeComponent();
        }

        private void Create_Activity_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE =localhost:1521/xe;USER ID=DatabaseProject;PASSWORD=9200";
            con = new OracleConnection(conStr);
            updateGrid();
        }
        private void updateGrid()
        {
            con.Open();
            OracleCommand getEmps = con.CreateCommand();
            getEmps.CommandText = "Select * From ACTIVITY";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            Activity_dataGridView1.DataSource = empDT;
            con.Close();
        }

        private void Insert_button_Click(object sender, EventArgs e)
        {
            // Assuming 'con' is your OracleConnection object

            con.Open();

            // Assuming 'richTextBox1', 'richTextBox6', 'dateTimePicker1', 'richTextBox3', 'richTextBox5', 'richTextBox4' are your input controls
            OracleCommand insertEmp = con.CreateCommand();
            insertEmp.CommandText = "INSERT INTO ACTIVITY (ActivityID, EVENTID, SessionID, ActivityName,ActivityDate, Location, Description) " +
                                    "VALUES (:ActivityID, :EVENTID, :SessionID, :ActivityName,:ActivityDate, :Location, :Description)";

            insertEmp.Parameters.Add(":ActivityID", OracleDbType.Int32).Value = Convert.ToInt32(Activity_richTextBox2.Text);
            insertEmp.Parameters.Add(":EVENTID", OracleDbType.Int32).Value = Convert.ToInt32(Actvity_richTextBox1.Text);
            insertEmp.Parameters.Add(":SessionID", OracleDbType.Int32).Value = Convert.ToInt32(Activity_richTextBox6.Text);// Corrected conversion to DateTime
            insertEmp.Parameters.Add(":ActivityName", OracleDbType.Varchar2).Value = Activity_richTextBox3.Text; // Assuming dateTimePicker1 includes both date and time
            insertEmp.Parameters.Add(":ActivityDate", OracleDbType.TimeStamp).Value = Activity_dateTimePicker1.Value;
            insertEmp.Parameters.Add(":Location", OracleDbType.Varchar2).Value = Activity_richTextBox5.Text;
            insertEmp.Parameters.Add(":Description", OracleDbType.Varchar2).Value = Ativity_richTextBox4.Text;


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

             // Assuming 'Activity_richTextBox2' is the control containing the ID of the activity you want to delete
             OracleCommand deleteActivity = con.CreateCommand();
             deleteActivity.CommandText = "DELETE FROM ACTIVITY WHERE ActivityID = :ActivityID";
             deleteActivity.Parameters.Add(":ActivityID", OracleDbType.Int32).Value = Convert.ToInt32(Activity_richTextBox2.Text);

             deleteActivity.CommandType = CommandType.Text;

             try
             {
                 int rows = deleteActivity.ExecuteNonQuery();
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

         /*   if (textBox2->Text == "HIRE DATE(DD-JAN-YYYY)" && textBox3->Text == "SALARY")
            {
                con.Open();
                OracleCommand ^ command = gcnew OracleCommand("UPDATE emp SET ename = '" + textBox1->Text + "' WHERE id = " + textBox4->Text, orc);
                command->ExecuteNonQuery();
                orc->Close();
                MessageBox::Show("Employee name Updated successfully", "Successfull");
                PopulateListView();
            }
            else if (textBox1->Text == "EMPLOYEE NAME" && textBox3->Text == "SALARY")
            {
                orc->Open();
                OracleCommand ^ command = gcnew OracleCommand("UPDATE emp SET hire_date =" + textBox2->Text + "WHERE id = " + textBox4->Text, orc);
                command->ExecuteNonQuery();
                orc->Close();
                MessageBox::Show("Employee hire date Updated successfully", "Successfull");
                PopulateListView();
            }
            else if (textBox1->Text == "EMPLOYEE NAME" && textBox2->Text == "HIRE DATE(DD-JAN-YYYY)")
            {
                orc->Open();
                OracleCommand ^ command = gcnew OracleCommand("UPDATE emp SET sal =" + textBox3->Text + "WHERE id = " + textBox4->Text, orc);
                command->ExecuteNonQuery();
                orc->Close();
                MessageBox::Show("Employee Salary Updated successfully", "Successfull");
                PopulateListView();
            }

            PopulateListView();*/

            // Assuming 'con' is your OracleConnection object
            con.Open();
            string activityId;
            activityId = Ativity_richTextBox4.Text;

                OracleCommand updateActivity = con.CreateCommand();
                updateActivity.CommandText = "UPDATE ACTIVITY " +
                                              "SET EVENTID = :EVENTID, SessionID = :SessionID, ActivityName = :ActivityName, ActivityDate = :ActivityDate, " +
                                              "Location = :Location, Description = :Description " +
                                              "WHERE ActivityID = :ActivityID";

                try
                {
                    updateActivity.Parameters.Add(":ActivityID", OracleDbType.Int32).Value = activityId;
                    updateActivity.Parameters.Add(":EVENTID", OracleDbType.Int32).Value = Convert.ToInt32(Actvity_richTextBox1.Text);
                    updateActivity.Parameters.Add(":SessionID", OracleDbType.Int32).Value = Convert.ToInt32(Activity_richTextBox6.Text);
                    updateActivity.Parameters.Add(":ActivityName", OracleDbType.Varchar2).Value = Activity_richTextBox3.Text;

                    // Convert DateTime to OracleDate
                    updateActivity.Parameters.Add(":ActivityDate", OracleDbType.Date).Value = (object)Activity_dateTimePicker1.Value ?? DBNull.Value;

                    updateActivity.Parameters.Add(":Location", OracleDbType.Varchar2).Value = Activity_richTextBox5.Text;
                    updateActivity.Parameters.Add(":Description", OracleDbType.Varchar2).Value = Ativity_richTextBox4.Text;

                    updateActivity.CommandType = CommandType.Text;

                    int rows = updateActivity.ExecuteNonQuery();

                    if (rows > 0)
                        MessageBox.Show("Data Updated Successfully!");
                    else
                        MessageBox.Show("No matching records found for update.");


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
