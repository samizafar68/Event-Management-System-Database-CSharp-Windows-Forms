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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Admin_button_Click(object sender, EventArgs e)
        {
            login obj = new login();
            this.Hide();
            obj.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void user_button_Click(object sender, EventArgs e)
        {
            User_login obj=new User_login();
            this.Hide();
            obj.Show();
        }
    }
}
