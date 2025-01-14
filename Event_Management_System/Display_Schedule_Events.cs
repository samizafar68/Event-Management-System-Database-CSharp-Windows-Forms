using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using iText.Kernel.Pdf;
//using iText.Layout;
//using iText.Layout.Element;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Oracle.ManagedDataAccess.Client;
namespace Event_Management_System
{
    public partial class Display_Schedule_Events : Form
    {
        OracleConnection con;
        public Display_Schedule_Events()
        {
            InitializeComponent();
        }

        private void Display_Schedule_Events_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE =localhost:1521/xe;USER ID=DatabaseProject;PASSWORD=9200";
            con = new OracleConnection(conStr);
            updateGrid();
        }
        private void updateGrid()
        {
            con.Open();
            OracleCommand getEmps = con.CreateCommand();
            getEmps.CommandText = "SELECT    E.EventID,    E.EventName,    COUNT(DISTINCT P.ParticipantRegistrationID) AS Total_Registered_Participant,   SUM(P.Payment) AS Event_Collected_Money,   COUNT(DISTINCT F.ParticipantRegistrationID) AS Total_Attendence_in_Event FROM    Event_Creation E JOIN    ParticipantRegistration P ON E.EventID = P.EventID LEFT JOIN     Feedback F ON E.EventID = F.EventID GROUP BY   E.EventID, E.EventName ORDER BY   Event_Collected_Money DESC";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            File_dataGridView1.DataSource = empDT;
            con.Close();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            Schedule_Event obj=new Schedule_Event();
            this.Hide();
            obj.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void savbutton_Click(object sender, EventArgs e)
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

                                int rowCount = File_dataGridView1.Rows.Count;
                                //int currentRow = 0;
                                doc.Add(new Paragraph("Event And Participant Registerd And Revenue Report \n"));
                                // Add content from DataGridView to PDF
                                foreach (DataGridViewRow row in File_dataGridView1.Rows)
                                {
                                   

                                    foreach (DataGridViewCell cell in row.Cells)
                                    {
                                        string attributeName = File_dataGridView1.Columns[cell.ColumnIndex].HeaderText;
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
