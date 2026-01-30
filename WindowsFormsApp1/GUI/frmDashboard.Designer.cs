namespace WindowsFormsApp1.GUI
{
    partial class frmDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnStudent = new System.Windows.Forms.Panel();
            this.lblNumStudent = new System.Windows.Forms.Label();
            this.lblTitleStudent = new System.Windows.Forms.Label();
            this.pnClass = new System.Windows.Forms.Panel();
            this.lblNumClass = new System.Windows.Forms.Label();
            this.lblTitleClass = new System.Windows.Forms.Label();
            this.pnSubject = new System.Windows.Forms.Panel();
            this.lblNumSubject = new System.Windows.Forms.Label();
            this.lblTitleSubject = new System.Windows.Forms.Label();
            this.pnFaculty = new System.Windows.Forms.Panel();
            this.lblNumFaculty = new System.Windows.Forms.Label();
            this.lblTitleFaculty = new System.Windows.Forms.Label();
            this.pnStudent.SuspendLayout();
            this.pnClass.SuspendLayout();
            this.pnSubject.SuspendLayout();
            this.pnFaculty.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(425, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TỔNG QUAN HỆ THỐNG";
            // 
            // pnStudent (Xanh dương)
            // 
            this.pnStudent.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnStudent.Controls.Add(this.lblNumStudent);
            this.pnStudent.Controls.Add(this.lblTitleStudent);
            this.pnStudent.Location = new System.Drawing.Point(40, 80);
            this.pnStudent.Name = "pnStudent";
            this.pnStudent.Size = new System.Drawing.Size(220, 150);
            this.pnStudent.TabIndex = 1;
            // 
            // lblNumStudent
            // 
            this.lblNumStudent.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lblNumStudent.ForeColor = System.Drawing.Color.White;
            this.lblNumStudent.Location = new System.Drawing.Point(0, 60);
            this.lblNumStudent.Name = "lblNumStudent";
            this.lblNumStudent.Size = new System.Drawing.Size(220, 50);
            this.lblNumStudent.TabIndex = 1;
            this.lblNumStudent.Text = "0";
            this.lblNumStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleStudent
            // 
            this.lblTitleStudent.AutoSize = true;
            this.lblTitleStudent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitleStudent.ForeColor = System.Drawing.Color.White;
            this.lblTitleStudent.Location = new System.Drawing.Point(20, 20);
            this.lblTitleStudent.Name = "lblTitleStudent";
            this.lblTitleStudent.Size = new System.Drawing.Size(111, 24);
            this.lblTitleStudent.TabIndex = 0;
            this.lblTitleStudent.Text = "SINH VIÊN";
            // 
            // pnClass (Xanh lá)
            // 
            this.pnClass.BackColor = System.Drawing.Color.SeaGreen;
            this.pnClass.Controls.Add(this.lblNumClass);
            this.pnClass.Controls.Add(this.lblTitleClass);
            this.pnClass.Location = new System.Drawing.Point(290, 80);
            this.pnClass.Name = "pnClass";
            this.pnClass.Size = new System.Drawing.Size(220, 150);
            this.pnClass.TabIndex = 2;
            // 
            // lblNumClass
            // 
            this.lblNumClass.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lblNumClass.ForeColor = System.Drawing.Color.White;
            this.lblNumClass.Location = new System.Drawing.Point(0, 60);
            this.lblNumClass.Name = "lblNumClass";
            this.lblNumClass.Size = new System.Drawing.Size(220, 50);
            this.lblNumClass.TabIndex = 1;
            this.lblNumClass.Text = "0";
            this.lblNumClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleClass
            // 
            this.lblTitleClass.AutoSize = true;
            this.lblTitleClass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitleClass.ForeColor = System.Drawing.Color.White;
            this.lblTitleClass.Location = new System.Drawing.Point(20, 20);
            this.lblTitleClass.Name = "lblTitleClass";
            this.lblTitleClass.Size = new System.Drawing.Size(99, 24);
            this.lblTitleClass.TabIndex = 0;
            this.lblTitleClass.Text = "LỚP HỌC";
            // 
            // pnSubject (Cam)
            // 
            this.pnSubject.BackColor = System.Drawing.Color.DarkOrange;
            this.pnSubject.Controls.Add(this.lblNumSubject);
            this.pnSubject.Controls.Add(this.lblTitleSubject);
            this.pnSubject.Location = new System.Drawing.Point(540, 80);
            this.pnSubject.Name = "pnSubject";
            this.pnSubject.Size = new System.Drawing.Size(220, 150);
            this.pnSubject.TabIndex = 3;
            // 
            // lblNumSubject
            // 
            this.lblNumSubject.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lblNumSubject.ForeColor = System.Drawing.Color.White;
            this.lblNumSubject.Location = new System.Drawing.Point(0, 60);
            this.lblNumSubject.Name = "lblNumSubject";
            this.lblNumSubject.Size = new System.Drawing.Size(220, 50);
            this.lblNumSubject.TabIndex = 1;
            this.lblNumSubject.Text = "0";
            this.lblNumSubject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleSubject
            // 
            this.lblTitleSubject.AutoSize = true;
            this.lblTitleSubject.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitleSubject.ForeColor = System.Drawing.Color.White;
            this.lblTitleSubject.Location = new System.Drawing.Point(20, 20);
            this.lblTitleSubject.Name = "lblTitleSubject";
            this.lblTitleSubject.Size = new System.Drawing.Size(104, 24);
            this.lblTitleSubject.TabIndex = 0;
            this.lblTitleSubject.Text = "MÔN HỌC";
            // 
            // pnFaculty (Đỏ)
            // 
            this.pnFaculty.BackColor = System.Drawing.Color.Crimson;
            this.pnFaculty.Controls.Add(this.lblNumFaculty);
            this.pnFaculty.Controls.Add(this.lblTitleFaculty);
            this.pnFaculty.Location = new System.Drawing.Point(790, 80);
            this.pnFaculty.Name = "pnFaculty";
            this.pnFaculty.Size = new System.Drawing.Size(220, 150);
            this.pnFaculty.TabIndex = 4;
            // 
            // lblNumFaculty
            // 
            this.lblNumFaculty.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lblNumFaculty.ForeColor = System.Drawing.Color.White;
            this.lblNumFaculty.Location = new System.Drawing.Point(0, 60);
            this.lblNumFaculty.Name = "lblNumFaculty";
            this.lblNumFaculty.Size = new System.Drawing.Size(220, 50);
            this.lblNumFaculty.TabIndex = 1;
            this.lblNumFaculty.Text = "0";
            this.lblNumFaculty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleFaculty
            // 
            this.lblTitleFaculty.AutoSize = true;
            this.lblTitleFaculty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitleFaculty.ForeColor = System.Drawing.Color.White;
            this.lblTitleFaculty.Location = new System.Drawing.Point(20, 20);
            this.lblTitleFaculty.Name = "lblTitleFaculty";
            this.lblTitleFaculty.Size = new System.Drawing.Size(66, 24);
            this.lblTitleFaculty.TabIndex = 0;
            this.lblTitleFaculty.Text = "KHOA";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1050, 500);
            this.Controls.Add(this.pnFaculty);
            this.Controls.Add(this.pnSubject);
            this.Controls.Add(this.pnClass);
            this.Controls.Add(this.pnStudent);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.pnStudent.ResumeLayout(false);
            this.pnStudent.PerformLayout();
            this.pnClass.ResumeLayout(false);
            this.pnClass.PerformLayout();
            this.pnSubject.ResumeLayout(false);
            this.pnSubject.PerformLayout();
            this.pnFaculty.ResumeLayout(false);
            this.pnFaculty.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnStudent;
        private System.Windows.Forms.Label lblNumStudent;
        private System.Windows.Forms.Label lblTitleStudent;
        private System.Windows.Forms.Panel pnClass;
        private System.Windows.Forms.Label lblNumClass;
        private System.Windows.Forms.Label lblTitleClass;
        private System.Windows.Forms.Panel pnSubject;
        private System.Windows.Forms.Label lblNumSubject;
        private System.Windows.Forms.Label lblTitleSubject;
        private System.Windows.Forms.Panel pnFaculty;
        private System.Windows.Forms.Label lblNumFaculty;
        private System.Windows.Forms.Label lblTitleFaculty;
    }
}