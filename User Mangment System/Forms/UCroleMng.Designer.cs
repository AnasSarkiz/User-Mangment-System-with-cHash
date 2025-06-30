namespace User_Mangment_System.Forms
{
    partial class UCroleMng
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
            this.dgvRoles = new System.Windows.Forms.DataGridView();
            this.btnAddRole = new System.Windows.Forms.Button();

            // 
            // UCroleMng
            // 
            this.BackColor = System.Drawing.Color.FromArgb(34, 40, 49);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Size = new System.Drawing.Size(600, 350);

            // 
            // lblTitle
            // 
            this.lblTitle.Text = "Role Management";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Size = new System.Drawing.Size(300, 40);

            // 
            // dgvRoles
            // 
            this.dgvRoles.BackgroundColor = System.Drawing.Color.FromArgb(51, 58, 68);
            this.dgvRoles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRoles.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(44, 54, 63);
            this.dgvRoles.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRoles.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(51, 58, 68);
            this.dgvRoles.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRoles.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(34, 40, 49);
            this.dgvRoles.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvRoles.EnableHeadersVisualStyles = false;
            this.dgvRoles.Location = new System.Drawing.Point(30, 70);
            this.dgvRoles.Size = new System.Drawing.Size(540, 200);
            this.dgvRoles.ReadOnly = true;
            this.dgvRoles.RowHeadersVisible = false;

            // 
            // btnAddRole
            // 
            this.btnAddRole.BackColor = System.Drawing.Color.FromArgb(44, 54, 63);
            this.btnAddRole.FlatAppearance.BorderSize = 0;
            this.btnAddRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRole.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnAddRole.ForeColor = System.Drawing.Color.White;
            this.btnAddRole.Location = new System.Drawing.Point(470, 280);
            this.btnAddRole.Size = new System.Drawing.Size(100, 35);
            this.btnAddRole.Text = "Add Role";
            this.btnAddRole.UseVisualStyleBackColor = false;
            // this.btnAddRole.Click += new System.EventHandler(this.btnAddRole_Click); // Uncomment and implement if needed

            // 
            // Add controls
            // 
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvRoles);
            this.Controls.Add(this.btnAddRole);
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.Button btnAddRole;
    }
}
