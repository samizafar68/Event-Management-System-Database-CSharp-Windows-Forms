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
    public partial class Schedule_Event : Form
    {
        public Schedule_Event()
        {
            InitializeComponent();
        }

        private void Schedule_Event_button_Click(object sender, EventArgs e)
        {
            Display_Schedule_Events obj=new Display_Schedule_Events();
            this.Hide();
            obj.Show();
        }

        private void Event_Create_button_Click(object sender, EventArgs e)
        {
            Display_ALL_Schedule_Event obj=new Display_ALL_Schedule_Event();
            this.Hide();
            obj.Show();
        }

        private void Display_Speaker_button_Click(object sender, EventArgs e)
        {
            Display_Speakers_Record obj=new Display_Speakers_Record();
            this.Hide();
            obj.Show();
        }

        private void Display_Session_button_Click(object sender, EventArgs e)
        {
            Display_Session_Record obj=new Display_Session_Record();
            this.Hide();
            obj.Show();
        }

        private void create_Activity_button_Click(object sender, EventArgs e)
        {
            Display_Activity_Record obj=new Display_Activity_Record();
            this.Hide();
            obj.Show();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            Admin obj = new Admin();
            this.Hide();
            obj.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
