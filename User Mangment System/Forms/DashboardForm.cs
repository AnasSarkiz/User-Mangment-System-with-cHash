using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User_Mangment_System.Forms;
using User_Mangment_System.Models;

namespace User_Mangment_System
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private readonly User currentUser;

        public DashboardForm(User user)
        {
            InitializeComponent();
            currentUser = user;

        }


        public void showUserControl(UserControl userControl)
        {
            mainPanel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(userControl);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            showUserControl(new UCaddUser(currentUser));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showUserControl(new UClistUsers());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (currentUser.Role == UserRole.Admin)
            {
                showUserControl(new UCroleMng());
            }
            else
            {
                MessageBox.Show("Only admin can view this page.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            showUserControl(new UCevents());
        }
    }
}
