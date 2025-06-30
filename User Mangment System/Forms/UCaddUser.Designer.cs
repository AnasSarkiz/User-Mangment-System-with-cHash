namespace User_Mangment_System.Forms
{
    partial class UCaddUser
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.addUserBtn = new System.Windows.Forms.Button();

            // 
            // UCaddUser
            // 
            this.BackColor = System.Drawing.Color.FromArgb(34, 40, 49);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Size = new System.Drawing.Size(500, 350);

            // 
            // lblTitle
            // 
            this.lblTitle.Text = "Add New User";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Size = new System.Drawing.Size(300, 40);

            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(51, 58, 68);
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUsername.Location = new System.Drawing.Point(30, 80);
            this.txtUsername.Size = new System.Drawing.Size(300, 34);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "Username";
            this.txtUsername.GotFocus += (s, e) => { if (txtUsername.Text == "Username") { txtUsername.Text = ""; txtUsername.ForeColor = System.Drawing.Color.White; } };
            this.txtUsername.LostFocus += (s, e) => { if (string.IsNullOrWhiteSpace(txtUsername.Text)) { txtUsername.Text = "Username"; txtUsername.ForeColor = System.Drawing.Color.Gray; } };
            this.txtUsername.ForeColor = System.Drawing.Color.Gray;

            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(51, 58, 68);
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPassword.Location = new System.Drawing.Point(30, 130);
            this.txtPassword.Size = new System.Drawing.Size(300, 34);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "Password";
            this.txtPassword.UseSystemPasswordChar = false;
            this.txtPassword.GotFocus += (s, e) => { if (txtPassword.Text == "Password") { txtPassword.Text = ""; txtPassword.ForeColor = System.Drawing.Color.White; txtPassword.UseSystemPasswordChar = true; } };
            this.txtPassword.LostFocus += (s, e) => { if (string.IsNullOrWhiteSpace(txtPassword.Text)) { txtPassword.Text = "Password"; txtPassword.ForeColor = System.Drawing.Color.Gray; txtPassword.UseSystemPasswordChar = false; } };

            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.FromArgb(51, 58, 68);
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(30, 180);
            this.txtConfirmPassword.Size = new System.Drawing.Size(300, 34);
            this.txtConfirmPassword.TabIndex = 2;
            this.txtConfirmPassword.Text = "Confirm Password";
            this.txtConfirmPassword.UseSystemPasswordChar = false;
            this.txtConfirmPassword.GotFocus += (s, e) => { if (txtConfirmPassword.Text == "Confirm Password") { txtConfirmPassword.Text = ""; txtConfirmPassword.ForeColor = System.Drawing.Color.White; txtConfirmPassword.UseSystemPasswordChar = true; } };
            this.txtConfirmPassword.LostFocus += (s, e) => { if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text)) { txtConfirmPassword.Text = "Confirm Password"; txtConfirmPassword.ForeColor = System.Drawing.Color.Gray; txtConfirmPassword.UseSystemPasswordChar = false; } };

            // 
            // cmbRole
            // 
            this.cmbRole.BackColor = System.Drawing.Color.FromArgb(51, 58, 68);
            this.cmbRole.ForeColor = System.Drawing.Color.White;
            this.cmbRole.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbRole.Location = new System.Drawing.Point(30, 230);
            this.cmbRole.Size = new System.Drawing.Size(300, 34);
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.Items.AddRange(new object[] { "Admin", "Editor", "Viewer" });
            this.cmbRole.TabIndex = 3;

            // 
            // addUserBtn
            // 
            this.addUserBtn.BackColor = System.Drawing.Color.FromArgb(44, 54, 63);
            this.addUserBtn.FlatAppearance.BorderSize = 0;
            this.addUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUserBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addUserBtn.ForeColor = System.Drawing.Color.White;
            this.addUserBtn.Location = new System.Drawing.Point(30, 280);
            this.addUserBtn.Size = new System.Drawing.Size(300, 40);
            this.addUserBtn.TabIndex = 4;
            this.addUserBtn.Text = "Add User";
            this.addUserBtn.UseVisualStyleBackColor = false;
            this.addUserBtn.Click += new System.EventHandler(this.button2_Click);

            // 
            // Add controls
            // 
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.addUserBtn);
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Button addUserBtn;
    }
}
