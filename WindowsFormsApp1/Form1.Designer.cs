namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.btNew = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();

            // Khai báo các Label
            this.lbMSSV = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbClass = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbDob = new System.Windows.Forms.Label();
            this.lbHometown = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();

            // Khai báo các Control nhập liệu
            this.tbMSSV = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbClass = new System.Windows.Forms.TextBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.tbHometown = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();

            // GroupBox để nhóm thông tin (Tùy chọn, giúp giao diện đẹp hơn)
            this.gbInfo = new System.Windows.Forms.GroupBox();

            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.gbInfo.SuspendLayout();
            this.SuspendLayout();

            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Location = new System.Drawing.Point(12, 12);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.RowHeadersWidth = 51;
            this.dgvStudent.RowTemplate.Height = 24;
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.Size = new System.Drawing.Size(958, 250);
            this.dgvStudent.TabIndex = 0;
            this.dgvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellClick);

            // 
            // gbInfo (Khu vực nhập liệu)
            // 
            this.gbInfo.Controls.Add(this.tbPhone);
            this.gbInfo.Controls.Add(this.lbPhone);
            this.gbInfo.Controls.Add(this.tbHometown);
            this.gbInfo.Controls.Add(this.lbHometown);
            this.gbInfo.Controls.Add(this.dtpDob);
            this.gbInfo.Controls.Add(this.lbDob);
            this.gbInfo.Controls.Add(this.cbGender);
            this.gbInfo.Controls.Add(this.lbGender);
            this.gbInfo.Controls.Add(this.tbClass);
            this.gbInfo.Controls.Add(this.lbClass);
            this.gbInfo.Controls.Add(this.tbName);
            this.gbInfo.Controls.Add(this.lbName);
            this.gbInfo.Controls.Add(this.tbMSSV);
            this.gbInfo.Controls.Add(this.lbMSSV);
            this.gbInfo.Location = new System.Drawing.Point(12, 280);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(958, 160);
            this.gbInfo.TabIndex = 1;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Thông tin sinh viên";

            // --- Cột 1 ---
            // lbMSSV
            this.lbMSSV.AutoSize = true;
            this.lbMSSV.Location = new System.Drawing.Point(20, 30);
            this.lbMSSV.Name = "lbMSSV";
            this.lbMSSV.Size = new System.Drawing.Size(49, 17);
            this.lbMSSV.TabIndex = 0;
            this.lbMSSV.Text = "MSSV:";
            // tbMSSV
            this.tbMSSV.Location = new System.Drawing.Point(100, 27);
            this.tbMSSV.Name = "tbMSSV";
            this.tbMSSV.Size = new System.Drawing.Size(180, 22);
            this.tbMSSV.TabIndex = 1;
            this.tbMSSV.MaxLength = 10;
            this.tbMSSV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumber_KeyPress);

            // lbName
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(20, 70);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(54, 17);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Họ tên:";
            // tbName
            this.tbName.Location = new System.Drawing.Point(100, 67);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(250, 22);
            this.tbName.TabIndex = 2;

            // lbClass
            this.lbClass.AutoSize = true;
            this.lbClass.Location = new System.Drawing.Point(20, 110);
            this.lbClass.Name = "lbClass";
            this.lbClass.Size = new System.Drawing.Size(36, 17);
            this.lbClass.TabIndex = 4;
            this.lbClass.Text = "Lớp:";
            // tbClass
            this.tbClass.Location = new System.Drawing.Point(100, 107);
            this.tbClass.Name = "tbClass";
            this.tbClass.Size = new System.Drawing.Size(180, 22);
            this.tbClass.TabIndex = 3;

            // --- Cột 2 ---
            // lbGender
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(400, 30);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(64, 17);
            this.lbGender.TabIndex = 6;
            this.lbGender.Text = "Giới tính:";
            // cbGender
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbGender.Location = new System.Drawing.Point(480, 27);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(100, 24);
            this.cbGender.TabIndex = 4;

            // lbDob
            this.lbDob.AutoSize = true;
            this.lbDob.Location = new System.Drawing.Point(400, 70);
            this.lbDob.Name = "lbDob";
            this.lbDob.Size = new System.Drawing.Size(75, 17);
            this.lbDob.TabIndex = 8;
            this.lbDob.Text = "Ngày sinh:";
            // dtpDob
            this.dtpDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDob.Location = new System.Drawing.Point(480, 67);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(150, 22);
            this.dtpDob.TabIndex = 5;

            // lbPhone
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(400, 110);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(40, 17);
            this.lbPhone.TabIndex = 10;
            this.lbPhone.Text = "SĐT:";
            // tbPhone
            this.tbPhone.Location = new System.Drawing.Point(480, 107);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(150, 22);
            this.tbPhone.TabIndex = 6;
            this.tbPhone.MaxLength = 10;
            this.tbPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumber_KeyPress);

            // --- Cột 3 (Quê quán - Rộng hơn) ---
            // lbHometown
            this.lbHometown.AutoSize = true;
            this.lbHometown.Location = new System.Drawing.Point(650, 30);
            this.lbHometown.Name = "lbHometown";
            this.lbHometown.Size = new System.Drawing.Size(75, 17);
            this.lbHometown.TabIndex = 12;
            this.lbHometown.Text = "Quê quán:";
            // tbHometown
            this.tbHometown.Location = new System.Drawing.Point(730, 27);
            this.tbHometown.Multiline = true;
            this.tbHometown.Name = "tbHometown";
            this.tbHometown.Size = new System.Drawing.Size(200, 62);
            this.tbHometown.TabIndex = 7;

            // 
            // Các nút chức năng (Buttons)
            // 

            // btNew
            this.btNew.Location = new System.Drawing.Point(200, 460);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(100, 35);
            this.btNew.TabIndex = 8;
            this.btNew.Text = "Thêm";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);

            // btDelete
            this.btDelete.Location = new System.Drawing.Point(320, 460);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(100, 35);
            this.btDelete.TabIndex = 9;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);

            // btEdit
            this.btEdit.Location = new System.Drawing.Point(440, 460);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(100, 35);
            this.btEdit.TabIndex = 10;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);

            // btExit
            this.btExit.Location = new System.Drawing.Point(560, 460);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(100, 35);
            this.btExit.TabIndex = 11;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 523);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.dgvStudent);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Sinh viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.GroupBox gbInfo;

        private System.Windows.Forms.Label lbMSSV;
        private System.Windows.Forms.TextBox tbMSSV;

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbName;

        private System.Windows.Forms.Label lbClass;
        private System.Windows.Forms.TextBox tbClass;

        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.ComboBox cbGender;

        private System.Windows.Forms.Label lbDob;
        private System.Windows.Forms.DateTimePicker dtpDob;

        private System.Windows.Forms.Label lbHometown;
        private System.Windows.Forms.TextBox tbHometown;

        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.TextBox tbPhone;

        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btExit;
    }
}