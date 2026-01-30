namespace WindowsFormsApp1.GUI.ManagementForms
{
    partial class frmSubject
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
            this.numCredits = new System.Windows.Forms.NumericUpDown();
            this.lbCredits = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.dgvSubject = new System.Windows.Forms.DataGridView();
            this.panelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCredits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubject)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.numCredits);
            this.gbInfo.Controls.Add(this.lbCredits);
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
            this.gbInfo.Text = "Thông tin Môn học";
            // 
            // numCredits
            // 
            this.numCredits.Location = new System.Drawing.Point(100, 120);
            this.numCredits.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numCredits.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCredits.Name = "numCredits";
            this.numCredits.Size = new System.Drawing.Size(100, 22);
            this.numCredits.TabIndex = 5;
            this.numCredits.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // lbCredits
            // 
            this.lbCredits.AutoSize = true;
            this.lbCredits.Location = new System.Drawing.Point(20, 123);
            this.lbCredits.Name = "lbCredits";
            this.lbCredits.Size = new System.Drawing.Size(63, 16);
            this.lbCredits.TabIndex = 4;
            this.lbCredits.Text = "Số tín chỉ:";
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
            this.lbName.Size = new System.Drawing.Size(64, 16);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Tên Môn:";
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
            this.lbID.Size = new System.Drawing.Size(58, 16);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "Mã Môn:";
            // 
            // dgvSubject
            // 
            this.dgvSubject.AllowUserToAddRows = false;
            this.dgvSubject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSubject.Location = new System.Drawing.Point(0, 0);
            this.dgvSubject.Name = "dgvSubject";
            this.dgvSubject.ReadOnly = true;
            this.dgvSubject.RowHeadersWidth = 51;
            this.dgvSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubject.Size = new System.Drawing.Size(662, 493);
            this.dgvSubject.TabIndex = 1;
            this.dgvSubject.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubject_CellClick);
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
            // frmSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.dgvSubject);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.panelButtons);
            this.Name = "frmSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Môn học";
            this.Load += new System.EventHandler(this.frmSubject_Load);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCredits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubject)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.DataGridView dgvSubject;
        private System.Windows.Forms.FlowLayoutPanel panelButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.NumericUpDown numCredits;
        private System.Windows.Forms.Label lbCredits;
    }
}