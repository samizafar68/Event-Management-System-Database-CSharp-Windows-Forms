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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            User_login obj=new User_login();
            this.Hide();
            obj.Show();
        }

        private void Event_Create_button_Click(object sender, EventArgs e)
        {
            Participant_Registration obj=new Participant_Registration();
            this.Hide();
            obj.Show();
        }

        private void Schedule_Event_button_Click(object sender, EventArgs e)
        {
            Upcomin_Events obj=new Upcomin_Events();
            this.Hide();
            obj.Show();
        }

        private void Create_Session_button_Click(object sender, EventArgs e)
        {
            User_Registerd_Events_Info obj=new User_Registerd_Events_Info();
            this.Hide();
            obj.Show();
        }

        private void User_Notification_button_Click(object sender, EventArgs e)
        {
            User_Notification obj=new User_Notification();
            this.Hide();
            obj.Show();
        }

        private void create_Activity_button_Click(object sender, EventArgs e)
        {
            Participant_Feedback obj=new Participant_Feedback();
            this.Hide();
            obj.Show();
        }
    }
}
