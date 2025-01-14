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
    public partial class Display_Registered : Form
    {
        OracleConnection con;
        public Display_Registered()
        {
            InitializeComponent();
        }

        private void Display_Registered_Load(object sender, EventArgs e)
        {

            string conStr = @"DATA SOURCE =localhost:1521/xe;USER ID=DatabaseProject;PASSWORD=9200";
            con = new OracleConnection(conStr);
            updateGrid();
        }
        private void updateGrid()
        {
            con.Open();
            OracleCommand getEmps = con.CreateCommand();
            getEmps.CommandText = "Select * From Event_Creation";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            Registerd_Detail_dataGridView1.DataSource = empDT;
            con.Close();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            Schedule_Event obj=new Schedule_Event();
            this.Hide();
            obj.Show();
        }
    }
}
