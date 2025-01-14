using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
namespace Event_Management_System
{
    public partial class Participant_Feedback : Form
    {
        OracleConnection con;
        public Participant_Feedback()
        {
            InitializeComponent();
        }

        private void Insert_button_Click(object sender, EventArgs e)
        {
            // Assuming 'con' is your OracleConnection object

            con.Open();

            // Assuming 'richTextBox1', 'richTextBox6', 'dateTimePicker1', 'richTextBox3', 'richTextBox5', 'richTextBox4' are your input controls
            OracleCommand insertEmp = con.CreateCommand();
            insertEmp.CommandText = "INSERT INTO Feedback (FeedbackID, EventID,ParticipantRegistrationID, FeedbackDetails) " +
                                    "VALUES (FeedbackSeq.NEXTVAL, :EventID,:ParticipantRegistrationID, :FeedbackDetails)";
            insertEmp.Parameters.Add(":EventID", OracleDbType.Int32).Value = Convert.ToInt32(Feedback_Event_ID_richTextBox1.Text);
            insertEmp.Parameters.Add(":ParticipantRegistrationID", OracleDbType.Int32).Value =Convert.ToInt32( Feedbak_Participant_ID_richTextBox6.Text); // Corrected conversion to DateTime
            insertEmp.Parameters.Add(":FedbackDetails", OracleDbType.Varchar2).Value = Feedback_Detail_richTextBox3.Text; // Assuming dateTimePicker1 includes both date and time
            
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

        private void Participant_Feedback_Load(object sender, EventArgs e)
        {

            string conStr = @"DATA SOURCE =localhost:1521/xe;USER ID=DatabaseProject;PASSWORD=9200";
            con = new OracleConnection(conStr);
            updateGrid();
        }
        private void updateGrid()
        {
            con.Open();
            OracleCommand getEmps = con.CreateCommand();
            getEmps.CommandText = "SELECT * FROM Feedback";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            Feedback_dataGridView1.DataSource = empDT;
            con.Close();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            User obj=new User();
            this.Hide();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (MemoryStream memoryStream = new MemoryStream())
                        {
                            using (Document doc = new Document(PageSize.A4.Rotate()))
                            {
                                PdfWriter writer = PdfWriter.GetInstance(doc, memoryStream);
                                doc.Open();

                                int rowCount = Feedback_dataGridView1.Rows.Count;
                                //int currentRow = 0;
                                doc.Add(new Paragraph("Participant Feedback Report \n"));
                                // Add content from DataGridView to PDF
                                foreach (DataGridViewRow row in Feedback_dataGridView1.Rows)
                                {


                                    foreach (DataGridViewCell cell in row.Cells)
                                    {
                                        string attributeName = Feedback_dataGridView1.Columns[cell.ColumnIndex].HeaderText;
                                        doc.Add(new Paragraph($"{attributeName}: {cell.Value?.ToString() ?? ""}"));
                                    }
                                }
                            } // Document will be automatically closed when leaving this using block

                            // Save the content from MemoryStream to a file
                            File.WriteAllBytes(sfd.FileName, memoryStream.ToArray());

                            MessageBox.Show("PDF created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        } // MemoryStream will be automatically closed when leaving this using block
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
    }
}
