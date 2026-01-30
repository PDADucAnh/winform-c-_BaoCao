namespace WindowsFormsApp1.GUI.ManagementForms
{
    partial class frmFaculty
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
            // --- KHAI BÁO BIẾN CONTROL ---
            this.gbFaculty = new System.Windows.Forms.GroupBox();
            this.dgvFaculty = new System.Windows.Forms.DataGridView();
            this.btnDelFaculty = new System.Windows.Forms.Button();
            this.btnEditFaculty = new System.Windows.Forms.Button();
            this.btnAddFaculty = new System.Windows.Forms.Button();
            this.txtFacName = new System.Windows.Forms.TextBox();
            this.lblFacName = new System.Windows.Forms.Label();
            this.txtFacID = new System.Windows.Forms.TextBox();
            this.lblFacID = new System.Windows.Forms.Label();

            this.gbMajor = new System.Windows.Forms.GroupBox();
            this.cbFaculty = new System.Windows.Forms.ComboBox();
            this.lblMajorFac = new System.Windows.Forms.Label();
            this.dgvMajor = new System.Windows.Forms.DataGridView();
            this.btnDelMajor = new System.Windows.Forms.Button();
            this.btnEditMajor = new System.Windows.Forms.Button();
            this.btnAddMajor = new System.Windows.Forms.Button();
            this.txtMajorName = new System.Windows.Forms.TextBox();
            this.lblMajorName = new System.Windows.Forms.Label();
            this.txtMajorID = new System.Windows.Forms.TextBox();
            this.lblMajorID = new System.Windows.Forms.Label();

            this.gbFaculty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaculty)).BeginInit();
            this.gbMajor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMajor)).BeginInit();
            this.SuspendLayout();

            // ========================================================
            // GROUP BOX 1: QUẢN LÝ KHOA (BÊN TRÁI)
            // ========================================================
            this.gbFaculty.Controls.Add(this.dgvFaculty);
            this.gbFaculty.Controls.Add(this.btnDelFaculty);
            this.gbFaculty.Controls.Add(this.btnEditFaculty);
            this.gbFaculty.Controls.Add(this.btnAddFaculty);
            this.gbFaculty.Controls.Add(this.txtFacName);
            this.gbFaculty.Controls.Add(this.lblFacName);
            this.gbFaculty.Controls.Add(this.txtFacID);
            this.gbFaculty.Controls.Add(this.lblFacID);
            this.gbFaculty.Location = new System.Drawing.Point(12, 12);
            this.gbFaculty.Name = "gbFaculty";
            this.gbFaculty.Size = new System.Drawing.Size(480, 530);
            this.gbFaculty.TabIndex = 0;
            this.gbFaculty.TabStop = false;
            this.gbFaculty.Text = "Quản lý Khoa";

            // lblFacID
            this.lblFacID.AutoSize = true;
            this.lblFacID.Location = new System.Drawing.Point(20, 30);
            this.lblFacID.Name = "lblFacID";
            this.lblFacID.Size = new System.Drawing.Size(63, 16);
            this.lblFacID.Text = "Mã Khoa:";

            // txtFacID
            this.txtFacID.Location = new System.Drawing.Point(100, 27);
            this.txtFacID.Name = "txtFacID";
            this.txtFacID.ReadOnly = true;
            this.txtFacID.Size = new System.Drawing.Size(100, 22);
            this.txtFacID.TabIndex = 0;

            // lblFacName
            this.lblFacName.AutoSize = true;
            this.lblFacName.Location = new System.Drawing.Point(20, 70);
            this.lblFacName.Name = "lblFacName";
            this.lblFacName.Size = new System.Drawing.Size(68, 16);
            this.lblFacName.Text = "Tên Khoa:";

            // txtFacName
            this.txtFacName.Location = new System.Drawing.Point(100, 67);
            this.txtFacName.Name = "txtFacName";
            this.txtFacName.Size = new System.Drawing.Size(350, 22);
            this.txtFacName.TabIndex = 1;

            // btnAddFaculty
            this.btnAddFaculty.Location = new System.Drawing.Point(100, 110);
            this.btnAddFaculty.Name = "btnAddFaculty";
            this.btnAddFaculty.Size = new System.Drawing.Size(90, 30);
            this.btnAddFaculty.TabIndex = 2;
            this.btnAddFaculty.Text = "Thêm Khoa";
            this.btnAddFaculty.Click += new System.EventHandler(this.btnAddFaculty_Click);

            // btnEditFaculty
            this.btnEditFaculty.Location = new System.Drawing.Point(200, 110);
            this.btnEditFaculty.Name = "btnEditFaculty";
            this.btnEditFaculty.Size = new System.Drawing.Size(90, 30);
            this.btnEditFaculty.TabIndex = 3;
            this.btnEditFaculty.Text = "Sửa Khoa";
            this.btnEditFaculty.Click += new System.EventHandler(this.btnEditFaculty_Click);

            // btnDelFaculty
            this.btnDelFaculty.Location = new System.Drawing.Point(300, 110);
            this.btnDelFaculty.Name = "btnDelFaculty";
            this.btnDelFaculty.Size = new System.Drawing.Size(90, 30);
            this.btnDelFaculty.TabIndex = 4;
            this.btnDelFaculty.Text = "Xóa Khoa";
            this.btnDelFaculty.Click += new System.EventHandler(this.btnDelFaculty_Click);

            // dgvFaculty
            this.dgvFaculty.AllowUserToAddRows = false;
            this.dgvFaculty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFaculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFaculty.Location = new System.Drawing.Point(6, 160);
            this.dgvFaculty.Name = "dgvFaculty";
            this.dgvFaculty.ReadOnly = true;
            this.dgvFaculty.RowHeadersWidth = 51;
            this.dgvFaculty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFaculty.Size = new System.Drawing.Size(468, 360);
            this.dgvFaculty.TabIndex = 5;
            this.dgvFaculty.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFaculty_CellClick);

            // ========================================================
            // GROUP BOX 2: QUẢN LÝ NGÀNH (BÊN PHẢI)
            // ========================================================
            this.gbMajor.Controls.Add(this.cbFaculty);
            this.gbMajor.Controls.Add(this.lblMajorFac);
            this.gbMajor.Controls.Add(this.dgvMajor);
            this.gbMajor.Controls.Add(this.btnDelMajor);
            this.gbMajor.Controls.Add(this.btnEditMajor);
            this.gbMajor.Controls.Add(this.btnAddMajor);
            this.gbMajor.Controls.Add(this.txtMajorName);
            this.gbMajor.Controls.Add(this.lblMajorName);
            this.gbMajor.Controls.Add(this.txtMajorID);
            this.gbMajor.Controls.Add(this.lblMajorID);
            this.gbMajor.Location = new System.Drawing.Point(510, 12);
            this.gbMajor.Name = "gbMajor";
            this.gbMajor.Size = new System.Drawing.Size(480, 530);
            this.gbMajor.TabIndex = 1;
            this.gbMajor.TabStop = false;
            this.gbMajor.Text = "Quản lý Ngành học";

            // lblMajorID
            this.lblMajorID.AutoSize = true;
            this.lblMajorID.Location = new System.Drawing.Point(20, 30);
            this.lblMajorID.Name = "lblMajorID";
            this.lblMajorID.Size = new System.Drawing.Size(72, 16);
            this.lblMajorID.Text = "Mã Ngành:";

            // txtMajorID
            this.txtMajorID.Location = new System.Drawing.Point(100, 27);
            this.txtMajorID.Name = "txtMajorID";
            this.txtMajorID.ReadOnly = true;
            this.txtMajorID.Size = new System.Drawing.Size(100, 22);
            this.txtMajorID.TabIndex = 6;

            // lblMajorName
            this.lblMajorName.AutoSize = true;
            this.lblMajorName.Location = new System.Drawing.Point(20, 70);
            this.lblMajorName.Name = "lblMajorName";
            this.lblMajorName.Size = new System.Drawing.Size(77, 16);
            this.lblMajorName.Text = "Tên Ngành:";

            // txtMajorName
            this.txtMajorName.Location = new System.Drawing.Point(100, 67);
            this.txtMajorName.Name = "txtMajorName";
            this.txtMajorName.Size = new System.Drawing.Size(350, 22);
            this.txtMajorName.TabIndex = 7;

            // lblMajorFac (Chọn Khoa cho Ngành)
            this.lblMajorFac.AutoSize = true;
            this.lblMajorFac.Location = new System.Drawing.Point(20, 110);
            this.lblMajorFac.Name = "lblMajorFac";
            this.lblMajorFac.Size = new System.Drawing.Size(41, 16);
            this.lblMajorFac.Text = "Khoa:";

            // cbFaculty
            this.cbFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFaculty.FormattingEnabled = true;
            this.cbFaculty.Location = new System.Drawing.Point(100, 107);
            this.cbFaculty.Name = "cbFaculty";
            this.cbFaculty.Size = new System.Drawing.Size(350, 24);
            this.cbFaculty.TabIndex = 8;

            // btnAddMajor
            this.btnAddMajor.Location = new System.Drawing.Point(100, 150);
            this.btnAddMajor.Name = "btnAddMajor";
            this.btnAddMajor.Size = new System.Drawing.Size(90, 30);
            this.btnAddMajor.TabIndex = 9;
            this.btnAddMajor.Text = "Thêm Ngành";
            this.btnAddMajor.Click += new System.EventHandler(this.btnAddMajor_Click);

            // btnEditMajor
            this.btnEditMajor.Location = new System.Drawing.Point(200, 150);
            this.btnEditMajor.Name = "btnEditMajor";
            this.btnEditMajor.Size = new System.Drawing.Size(90, 30);
            this.btnEditMajor.TabIndex = 10;
            this.btnEditMajor.Text = "Sửa Ngành";
            this.btnEditMajor.Click += new System.EventHandler(this.btnEditMajor_Click);

            // btnDelMajor
            this.btnDelMajor.Location = new System.Drawing.Point(300, 150);
            this.btnDelMajor.Name = "btnDelMajor";
            this.btnDelMajor.Size = new System.Drawing.Size(90, 30);
            this.btnDelMajor.TabIndex = 11;
            this.btnDelMajor.Text = "Xóa Ngành";
            this.btnDelMajor.Click += new System.EventHandler(this.btnDelMajor_Click);

            // dgvMajor
            this.dgvMajor.AllowUserToAddRows = false;
            this.dgvMajor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMajor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMajor.Location = new System.Drawing.Point(6, 200);
            this.dgvMajor.Name = "dgvMajor";
            this.dgvMajor.ReadOnly = true;
            this.dgvMajor.RowHeadersWidth = 51;
            this.dgvMajor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMajor.Size = new System.Drawing.Size(468, 320);
            this.dgvMajor.TabIndex = 12;
            this.dgvMajor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMajor_CellClick);

            // ========================================================
            // FORM MAIN SETTINGS
            // ========================================================
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 553);
            this.Controls.Add(this.gbMajor);
            this.Controls.Add(this.gbFaculty);
            this.Name = "frmFaculty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Khoa và Ngành học";
            this.Load += new System.EventHandler(this.frmFaculty_Load);
            this.gbFaculty.ResumeLayout(false);
            this.gbFaculty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaculty)).EndInit();
            this.gbMajor.ResumeLayout(false);
            this.gbMajor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMajor)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbFaculty;
        private System.Windows.Forms.DataGridView dgvFaculty;
        private System.Windows.Forms.Button btnDelFaculty;
        private System.Windows.Forms.Button btnEditFaculty;
        private System.Windows.Forms.Button btnAddFaculty;
        private System.Windows.Forms.TextBox txtFacName;
        private System.Windows.Forms.Label lblFacName;
        private System.Windows.Forms.TextBox txtFacID;
        private System.Windows.Forms.Label lblFacID;

        private System.Windows.Forms.GroupBox gbMajor;
        private System.Windows.Forms.DataGridView dgvMajor;
        private System.Windows.Forms.Button btnDelMajor;
        private System.Windows.Forms.Button btnEditMajor;
        private System.Windows.Forms.Button btnAddMajor;
        private System.Windows.Forms.TextBox txtMajorName;
        private System.Windows.Forms.Label lblMajorName;
        private System.Windows.Forms.TextBox txtMajorID;
        private System.Windows.Forms.Label lblMajorID;
        private System.Windows.Forms.ComboBox cbFaculty;
        private System.Windows.Forms.Label lblMajorFac;
    }
}