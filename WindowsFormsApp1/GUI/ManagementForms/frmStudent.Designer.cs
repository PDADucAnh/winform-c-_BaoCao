namespace WindowsFormsApp1.GUI.ManagementForms
{
    partial class frmStudent
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.tbHometown = new System.Windows.Forms.TextBox();
            this.lbHometown = new System.Windows.Forms.Label();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.lbDob = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.lbGender = new System.Windows.Forms.Label();
            // --- THAY ĐỔI QUAN TRỌNG: DÙNG COMBOBOX CHO LỚP ---
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.lbClass = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.tbMSSV = new System.Windows.Forms.TextBox();
            this.lbMSSV = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btNew = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btExportExcel = new System.Windows.Forms.Button();
            this.btImportExcel = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.gbInfo.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
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
            // gbInfo
            // 
            this.gbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInfo.Controls.Add(this.tbPhone);
            this.gbInfo.Controls.Add(this.lbPhone);
            this.gbInfo.Controls.Add(this.tbHometown);
            this.gbInfo.Controls.Add(this.lbHometown);
            this.gbInfo.Controls.Add(this.dtpDob);
            this.gbInfo.Controls.Add(this.lbDob);
            this.gbInfo.Controls.Add(this.cbGender);
            this.gbInfo.Controls.Add(this.lbGender);
            this.gbInfo.Controls.Add(this.cbClass);
            this.gbInfo.Controls.Add(this.lbClass);
            this.gbInfo.Controls.Add(this.tbName);
            this.gbInfo.Controls.Add(this.lbName);
            this.gbInfo.Controls.Add(this.tbMSSV);
            this.gbInfo.Controls.Add(this.lbMSSV);
            this.gbInfo.Location = new System.Drawing.Point(12, 275);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(958, 160);
            this.gbInfo.TabIndex = 1;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Thông tin sinh viên";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(480, 107);
            this.tbPhone.MaxLength = 10;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(150, 22);
            this.tbPhone.TabIndex = 6;
            this.tbPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumber_KeyPress);
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(400, 110);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(37, 16);
            this.lbPhone.TabIndex = 10;
            this.lbPhone.Text = "SĐT:";
            // 
            // tbHometown
            // 
            this.tbHometown.Location = new System.Drawing.Point(730, 27);
            this.tbHometown.Multiline = true;
            this.tbHometown.Name = "tbHometown";
            this.tbHometown.Size = new System.Drawing.Size(200, 62);
            this.tbHometown.TabIndex = 7;
            // 
            // lbHometown
            // 
            this.lbHometown.AutoSize = true;
            this.lbHometown.Location = new System.Drawing.Point(650, 30);
            this.lbHometown.Name = "lbHometown";
            this.lbHometown.Size = new System.Drawing.Size(68, 16);
            this.lbHometown.TabIndex = 12;
            this.lbHometown.Text = "Quê quán:";
            // 
            // dtpDob
            // 
            this.dtpDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDob.Location = new System.Drawing.Point(480, 67);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(150, 22);
            this.dtpDob.TabIndex = 5;
            // 
            // lbDob
            // 
            this.lbDob.AutoSize = true;
            this.lbDob.Location = new System.Drawing.Point(400, 70);
            this.lbDob.Name = "lbDob";
            this.lbDob.Size = new System.Drawing.Size(70, 16);
            this.lbDob.TabIndex = 8;
            this.lbDob.Text = "Ngày sinh:";
            // 
            // cbGender
            // 
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
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(400, 30);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(57, 16);
            this.lbGender.TabIndex = 6;
            this.lbGender.Text = "Giới tính:";
            // 
            // cbClass (COMBOBOX MỚI)
            // 
            this.cbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(100, 107);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(180, 24);
            this.cbClass.TabIndex = 3;
            // 
            // lbClass
            // 
            this.lbClass.AutoSize = true;
            this.lbClass.Location = new System.Drawing.Point(20, 110);
            this.lbClass.Name = "lbClass";
            this.lbClass.Size = new System.Drawing.Size(33, 16);
            this.lbClass.TabIndex = 4;
            this.lbClass.Text = "Lớp:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(100, 67);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(250, 22);
            this.tbName.TabIndex = 2;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(20, 70);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(49, 16);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Họ tên:";
            // 
            // tbMSSV
            // 
            this.tbMSSV.Location = new System.Drawing.Point(100, 27);
            this.tbMSSV.MaxLength = 10;
            this.tbMSSV.Name = "tbMSSV";
            this.tbMSSV.Size = new System.Drawing.Size(180, 22);
            this.tbMSSV.TabIndex = 1;
            this.tbMSSV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumber_KeyPress);
            // 
            // lbMSSV
            // 
            this.lbMSSV.AutoSize = true;
            this.lbMSSV.Location = new System.Drawing.Point(20, 30);
            this.lbMSSV.Name = "lbMSSV";
            this.lbMSSV.Size = new System.Drawing.Size(48, 16);
            this.lbMSSV.TabIndex = 0;
            this.lbMSSV.Text = "MSSV:";
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btNew);
            this.panelButtons.Controls.Add(this.btDelete);
            this.panelButtons.Controls.Add(this.btEdit);
            this.panelButtons.Controls.Add(this.btExportExcel);
            this.panelButtons.Controls.Add(this.btImportExcel);
            this.panelButtons.Controls.Add(this.btExit);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.panelButtons.Location = new System.Drawing.Point(0, 463);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.panelButtons.Size = new System.Drawing.Size(982, 60);
            this.panelButtons.TabIndex = 2;
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(13, 13);
            this.btNew.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(100, 35);
            this.btNew.TabIndex = 8;
            this.btNew.Text = "Thêm";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(126, 13);
            this.btDelete.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(100, 35);
            this.btDelete.TabIndex = 9;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(239, 13);
            this.btEdit.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(100, 35);
            this.btEdit.TabIndex = 10;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btExportExcel
            // 
            this.btExportExcel.Location = new System.Drawing.Point(352, 13);
            this.btExportExcel.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btExportExcel.Name = "btExportExcel";
            this.btExportExcel.Size = new System.Drawing.Size(100, 35);
            this.btExportExcel.TabIndex = 12;
            this.btExportExcel.Text = "Xuất Excel";
            this.btExportExcel.UseVisualStyleBackColor = true;
            this.btExportExcel.Click += new System.EventHandler(this.btExportExcel_Click);
            // 
            // btImportExcel
            // 
            this.btImportExcel.Location = new System.Drawing.Point(465, 13);
            this.btImportExcel.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btImportExcel.Name = "btImportExcel";
            this.btImportExcel.Size = new System.Drawing.Size(100, 35);
            this.btImportExcel.TabIndex = 13;
            this.btImportExcel.Text = "Nhập Excel";
            this.btImportExcel.UseVisualStyleBackColor = true;
            this.btImportExcel.Click += new System.EventHandler(this.btImportExcel_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(578, 13);
            this.btExit.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(100, 35);
            this.btExit.TabIndex = 11;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 523);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.dgvStudent);
            this.Name = "frmStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Sinh viên";
            this.Load += new System.EventHandler(this.frmStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.panelButtons.ResumeLayout(false);
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
        // private System.Windows.Forms.TextBox tbClass; // ĐÃ XÓA
        private System.Windows.Forms.ComboBox cbClass; // ĐÃ THÊM
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label lbDob;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.Label lbHometown;
        private System.Windows.Forms.TextBox tbHometown;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.FlowLayoutPanel panelButtons;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btExportExcel;
        private System.Windows.Forms.Button btImportExcel;
    }
}