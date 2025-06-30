using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User_Mangment_System.DAL;
using User_Mangment_System.Models;

namespace User_Mangment_System.Forms
{
    public partial class UClistUsers : UserControl
    {
        public UClistUsers()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            try
            {
                UserDAL dal = new UserDAL();
                List<User> users = dal.GetAllUsers();

                dgvUsers.DataSource = null;
                dgvUsers.DataSource = users;

                // تعديل عرض الأعمدة وتنسيقها
                dgvUsers.Columns["PasswordHash"].Visible = false;  // اخفاء كلمة السر المشفرة
                dgvUsers.Columns["FailedAttempts"].HeaderText = "محاولات الدخول الفاشلة";
                dgvUsers.Columns["LastAttempt"].HeaderText = "آخر محاولة دخول";
                dgvUsers.Columns["IsLocked"].HeaderText = "مقفل؟";
                dgvUsers.Columns["Role"].HeaderText = "الصلاحية";
                dgvUsers.Columns["Username"].HeaderText = "اسم المستخدم";

                dgvUsers.AutoResizeColumns();
                dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل المستخدمين:\n" + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }
    }
}