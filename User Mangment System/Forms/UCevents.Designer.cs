namespace User_Mangment_System.Forms
{
    partial class UCevents
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
            this.txtEventLog = new System.Windows.Forms.TextBox();

            // 
            // UCevents
            // 
            this.BackColor = System.Drawing.Color.FromArgb(34, 40, 49);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Size = new System.Drawing.Size(500, 350);

            // 
            // lblTitle
            // 
            this.lblTitle.Text = "Events Log";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Size = new System.Drawing.Size(300, 40);

            // 
            // txtEventLog
            // 
            this.txtEventLog.BackColor = System.Drawing.Color.FromArgb(51, 58, 68);
            this.txtEventLog.ForeColor = System.Drawing.Color.White;
            this.txtEventLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEventLog.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtEventLog.Location = new System.Drawing.Point(30, 70);
            this.txtEventLog.Multiline = true;
            this.txtEventLog.Size = new System.Drawing.Size(440, 250);
            this.txtEventLog.ReadOnly = true;
            this.txtEventLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;

            // 
            // Add controls
            // 
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtEventLog);
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtEventLog;
    }
}
