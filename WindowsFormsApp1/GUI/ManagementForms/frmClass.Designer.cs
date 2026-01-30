namespace WindowsFormsApp1.GUI.ManagementForms
{
    partial class frmClass
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
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.cbMajor = new System.Windows.Forms.ComboBox();
            this.lbMajor = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.dgvClass = new System.Windows.Forms.DataGridView();
            this.panelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.cbMajor);
            this.gbInfo.Controls.Add(this.lbMajor);
            this.gbInfo.Controls.Add(this.txtName);
            this.gbInfo.Controls.Add(this.lbName);
            this.gbInfo.Controls.Add(this.txtID);
            this.gbInfo.Controls.Add(this.lbID);
            this.gbInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbInfo.Location = new System.Drawing.Point(662, 0);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(320, 493);
            this.gbInfo.TabIndex = 0;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Thông tin Lớp học";
            // 
            // cbMajor
            // 
            this.cbMajor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMajor.FormattingEnabled = true;
            this.cbMajor.Location = new System.Drawing.Point(100, 120);
            this.cbMajor.Name = "cbMajor";
            this.cbMajor.Size = new System.Drawing.Size(200, 24);
            this.cbMajor.TabIndex = 5;
            // 
            // lbMajor
            // 
            this.lbMajor.AutoSize = true;
            this.lbMajor.Location = new System.Drawing.Point(20, 123);
            this.lbMajor.Name = "lbMajor";
            this.lbMajor.Size = new System.Drawing.Size(75, 16);
            this.lbMajor.TabIndex = 4;
            this.lbMajor.Text = "Ngành học:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(100, 80);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 22);
            this.txtName.TabIndex = 3;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(20, 83);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(60, 16);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Tên Lớp:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(100, 40);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 1;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(20, 43);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(55, 16);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "Mã Lớp:";
            // 
            // dgvClass
            // 
            this.dgvClass.AllowUserToAddRows = false;
            this.dgvClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClass.Location = new System.Drawing.Point(0, 0);
            this.dgvClass.Name = "dgvClass";
            this.dgvClass.ReadOnly = true;
            this.dgvClass.RowHeadersWidth = 51;
            this.dgvClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClass.Size = new System.Drawing.Size(662, 493);
            this.dgvClass.TabIndex = 1;
            this.dgvClass.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClass_CellClick);
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnAdd);
            this.panelButtons.Controls.Add(this.btnEdit);
            this.panelButtons.Controls.Add(this.btnDelete);
            this.panelButtons.Controls.Add(this.btnExit);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.panelButtons.Location = new System.Drawing.Point(0, 493);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Padding = new System.Windows.Forms.Padding(10);
            this.panelButtons.Size = new System.Drawing.Size(982, 60);
            this.panelButtons.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(852, 13);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(739, 13);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 35);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(626, 13);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 35);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(513, 13);
            this.btnExit.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 35);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.dgvClass);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.panelButtons);
            this.Name = "frmClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Lớp học";
            this.Load += new System.EventHandler(this.frmClass_Load);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.DataGridView dgvClass;
        private System.Windows.Forms.FlowLayoutPanel panelButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbMajor;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.ComboBox cbMajor;
    }
}