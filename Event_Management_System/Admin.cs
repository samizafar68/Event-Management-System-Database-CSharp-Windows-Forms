using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Management_System
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            login obj = new login();
            this.Hide();
            obj.Show();
        }

        private void Event_Create_button_Click(object sender, EventArgs e)
        {
            Event_Creation obj=new Event_Creation();
            this.Hide();
            obj.Show();
        }

        private void Schedule_Event_button_Click(object sender, EventArgs e)
        {
            Schedule_Event obj=new Schedule_Event();
            this.Hide();
            obj.Show();
        }

        private void Manage_Speaker_button_Click(object sender, EventArgs e)
        {
            Manage_Speaker obj = new Manage_Speaker();
            this.Hide();
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Create_Session obj = new Create_Session();
            this.Hide();
            obj.Show();
        }

        private void create_Activity_button_Click(object sender, EventArgs e)
        {
            Create_Activity obj = new Create_Activity();
            this.Hide();
            obj.Show();
        }

        private void Welcome_label_Click(object sender, EventArgs e)
        {

        }
    }
}
