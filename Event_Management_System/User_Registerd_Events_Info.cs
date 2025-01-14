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
    public partial class User_Registerd_Events_Info : Form
    {
        OracleConnection con;
        public User_Registerd_Events_Info()
        {
            InitializeComponent();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            User obj = new User();
            this.Hide();
            obj.Show();
        }

        private void User_Registerd_Events_Info_Load(object sender, EventArgs e)
        {

            string conStr = @"DATA SOURCE =localhost:1521/xe;USER ID=DatabaseProject;PASSWORD=9200";
            con = new OracleConnection(conStr);
     
        }
        private void updateGrid()
        {
            try
            {
                con.Open();

                // Get the ParticipantRegistrationID from the TextBox
                int participantRegistrationID = Convert.ToInt32(Registerd_Id_richTextBox2.Text);

                OracleCommand getEmps = con.CreateCommand();
                getEmps.CommandText = "SELECT P.ParticipantRegistrationID, P.Name,P.RegistrationDate,E.EventID,E.EventName,E.EventDate,E.EventTime,E.Location FROM ParticipantRegistration P INNER JOIN Event_Creation E ON P.EventID=E.EventID Where ParticipantRegistrationID = :ID";
                getEmps.Parameters.Add(":ID", OracleDbType.Int32).Value = participantRegistrationID;
                getEmps.CommandType = CommandType.Text;

                OracleDataReader empDR = getEmps.ExecuteReader();
                DataTable empDT = new DataTable();
                empDT.Load(empDR);

                if (empDT.Rows.Count > 0)
                {
                    Registerd_User_dataGridView1.DataSource = empDT;
                }
                else
                {
                    // No records found for the given ParticipantRegistrationID
                    MessageBox.Show("No records found for the given ParticipantRegistrationID");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

           }

        private void Registerd_Id_richTextBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Search_button1_Click(object sender, EventArgs e)
        {
            updateGrid(); 
        }
    }
}
