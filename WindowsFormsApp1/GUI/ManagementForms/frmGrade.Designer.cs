namespace WindowsFormsApp1.GUI.ManagementForms
{
    partial class frmGrade
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
            this.lblRank = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.cbStudent = new System.Windows.Forms.ComboBox();
            this.lblStudent = new System.Windows.Forms.Label();
            this.dgvGrade = new System.Windows.Forms.DataGridView();
            this.panelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrade)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.lblRank);
            this.gbInfo.Controls.Add(this.txtScore);
            this.gbInfo.Controls.Add(this.lblScore);
            this.gbInfo.Controls.Add(this.cbSubject);
            this.gbInfo.Controls.Add(this.lblSubject);
            this.gbInfo.Controls.Add(this.cbStudent);
            this.gbInfo.Controls.Add(this.lblStudent);
            this.gbInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbInfo.Location = new System.Drawing.Point(0, 0);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(982, 100);
            this.gbInfo.TabIndex = 0;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Thông tin nhập điểm";
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRank.ForeColor = System.Drawing.Color.Red;
            this.lblRank.Location = new System.Drawing.Point(820, 30);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(69, 18);
            this.lblRank.TabIndex = 6;
            this.lblRank.Text = "(Xếp loại)";
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(710, 27);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(100, 22);
            this.txtScore.TabIndex = 5;
            this.txtScore.TextChanged += new System.EventHandler(this.txtScore_TextChanged);
            this.txtScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtScore_KeyPress);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(650, 30);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(41, 16);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Điểm:";
            // 
            // cbSubject
            // 
            this.cbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Location = new System.Drawing.Point(400, 27);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(200, 24);
            this.cbSubject.TabIndex = 3;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(330, 30);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(61, 16);
            this.lblSubject.TabIndex = 2;
            this.lblSubject.Text = "Môn học:";
            // 
            // cbStudent
            // 
            this.cbStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStudent.FormattingEnabled = true;
            this.cbStudent.Location = new System.Drawing.Point(100, 27);
            this.cbStudent.Name = "cbStudent";
            this.cbStudent.Size = new System.Drawing.Size(200, 24);
            this.cbStudent.TabIndex = 1;
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Location = new System.Drawing.Point(20, 30);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(64, 16);
            this.lblStudent.TabIndex = 0;
            this.lblStudent.Text = "Sinh viên:";
            // 
            // dgvGrade
            // 
            this.dgvGrade.AllowUserToAddRows = false;
            this.dgvGrade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGrade.Location = new System.Drawing.Point(0, 100);
            this.dgvGrade.Name = "dgvGrade";
            this.dgvGrade.ReadOnly = true;
            this.dgvGrade.RowHeadersWidth = 51;
            this.dgvGrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrade.Size = new System.Drawing.Size(982, 393);
            this.dgvGrade.TabIndex = 1;
            this.dgvGrade.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrade_CellClick);
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnSave);
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
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(852, 13);
            this.btnSave.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Lưu Điểm";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(739, 13);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 35);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(626, 13);
            this.btnExit.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 35);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.dgvGrade);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.gbInfo);
            this.Name = "frmGrade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Điểm số";
            this.Load += new System.EventHandler(this.frmGrade_Load);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrade)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.DataGridView dgvGrade;
        private System.Windows.Forms.FlowLayoutPanel panelButtons;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cbStudent;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblRank;
    }
}