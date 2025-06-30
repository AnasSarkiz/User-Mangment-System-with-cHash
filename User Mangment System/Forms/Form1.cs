using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using User_Mangment_System.DAL;
using User_Mangment_System.Forms;
using User_Mangment_System.Models;
using UserManagementSystem.Utilities;

namespace User_Mangment_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const int MaxAttemptsLevel1 = 3; // قفل لمدة دقيقة
        private const int MaxAttemptsLevel2 = 4; // قفل لمدة 5 دقائق
        private const int MaxAttemptsLevel3 = 5; // قفل لمدة 24 ساعة



        private void btnLogin_Click(object sender, EventArgs e)
        {
            string inputUsername = txtUsername.Text.Trim();
            string inputPassword = txtPassword.Text;

            UserDAL userDal = new UserDAL();
            User user = userDal.GetUserByUsername(inputUsername);

            if (user == null)
            {
                MessageBox.Show("User not found.");
            }
            else if (user.IsLocked)
            {
                MessageBox.Show("Your account is locked.");
            }
            else if (!PasswordHasher.VerifyPassword(inputPassword, user.PasswordHash)) // مقارنة التشفير
            {
                user.FailedAttempts++;
                user.LastAttempt = DateTime.Now;

                if (user.FailedAttempts >= 3)
                {
                    user.IsLocked = true;
                    MessageBox.Show("Account locked after 3 failed attempts.");
                }
                else
                {
                    MessageBox.Show("Incorrect password.");
                }

                userDal.UpdateUserLoginAttempts(user);
            }
            else
            {
                // تسجيل دخول ناجح
                user.FailedAttempts = 0;
                user.IsLocked = false;
                user.LastAttempt = DateTime.Now;
                userDal.UpdateUserLoginAttempts(user);

                MessageBox.Show($"Welcome {user.Username} - Role: {user.Role}");

                UCaddUser add = new UCaddUser(user);
                DashboardForm dashboard = new DashboardForm(user);
                this.Hide();
                dashboard.Show();
            }
        }

            private bool ShouldLock(int attempts)
        {
            return attempts >= MaxAttemptsLevel1;
        }

        private string GetLockMessage(int attempts, TimeSpan timeSinceLast)
        {
            if (attempts >= MaxAttemptsLevel3 && timeSinceLast.TotalHours < 24)
                return "الحساب مقفل لمدة 24 ساعة. الرجاء المحاولة لاحقًا.";
            else if (attempts >= MaxAttemptsLevel2 && timeSinceLast.TotalMinutes < 5)
                return "الحساب مقفل لمدة 5 دقائق. الرجاء المحاولة لاحقًا.";
            else if (attempts >= MaxAttemptsLevel1 && timeSinceLast.TotalMinutes < 1)
                return "الحساب مقفل لمدة دقيقة. الرجاء المحاولة لاحقًا.";
            else
                return "الحساب مقفل. الرجاء المحاولة لاحقًا.";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}