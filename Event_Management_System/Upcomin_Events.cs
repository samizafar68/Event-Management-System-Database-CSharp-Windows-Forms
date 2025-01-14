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
    public partial class Upcomin_Events : Form
    {
        OracleConnection con;
        public Upcomin_Events()
        {
            InitializeComponent();
        }

        private void Upcomin_Events_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE =localhost:1521/xe;USER ID=DatabaseProject;PASSWORD=9200";
            con = new OracleConnection(conStr);
            updateGrid();
        }
        private void updateGrid()
        {
            con.Open();
            OracleCommand getEmps = con.CreateCommand();
            getEmps.CommandText = "Select * FROM Event_Creation WHERE EventDate >= SYSDATE ORDER BY EventDate";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            Upcoming_dataGridView1.DataSource = empDT;
            con.Close();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            User obj = new User();
            this.Hide();
            obj.Show();
        }
    }
}
