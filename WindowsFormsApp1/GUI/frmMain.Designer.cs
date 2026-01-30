namespace WindowsFormsApp1.GUI
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            // Đã xóa dòng ComponentResourceManager gây lỗi
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDiem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnLop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnKhoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnMonHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSinhVien = new System.Windows.Forms.ToolStripButton();
            this.tsbDiem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbLop = new System.Windows.Forms.ToolStripButton();
            this.tsbKhoa = new System.Windows.Forms.ToolStripButton();
            this.tsbMonHoc = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDangXuat = new System.Windows.Forms.ToolStripButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnHeThong,
            this.mnQuanLy});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1082, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnHeThong
            // 
            this.mnHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnDangXuat,
            this.toolStripSeparator1,
            this.mnThoat});
            this.mnHeThong.Name = "mnHeThong";
            this.mnHeThong.Size = new System.Drawing.Size(85, 26);
            this.mnHeThong.Text = "&Hệ thống";
            // 
            // mnDangXuat
            // 
            this.mnDangXuat.Name = "mnDangXuat";
            this.mnDangXuat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnDangXuat.Size = new System.Drawing.Size(224, 26);
            this.mnDangXuat.Text = "Đăng xuất";
            this.mnDangXuat.Click += new System.EventHandler(this.mnDangXuat_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // mnThoat
            // 
            this.mnThoat.Name = "mnThoat";
            this.mnThoat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnThoat.Size = new System.Drawing.Size(224, 26);
            this.mnThoat.Text = "Thoát";
            this.mnThoat.Click += new System.EventHandler(this.mnThoat_Click);
            // 
            // mnQuanLy
            // 
            this.mnQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnSinhVien,
            this.mnDiem,
            this.toolStripSeparator2,
            this.mnLop,
            this.mnKhoa,
            this.mnMonHoc});
            this.mnQuanLy.Name = "mnQuanLy";
            this.mnQuanLy.Size = new System.Drawing.Size(73, 26);
            this.mnQuanLy.Text = "&Quản lý";
            // 
            // mnSinhVien
            // 
            this.mnSinhVien.Name = "mnSinhVien";
            this.mnSinhVien.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnSinhVien.Size = new System.Drawing.Size(235, 26);
            this.mnSinhVien.Text = "Sinh viên";
            this.mnSinhVien.Click += new System.EventHandler(this.mnSinhVien_Click);
            // 
            // mnDiem
            // 
            this.mnDiem.Name = "mnDiem";
            this.mnDiem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.mnDiem.Size = new System.Drawing.Size(235, 26);
            this.mnDiem.Text = "Điểm số";
            this.mnDiem.Click += new System.EventHandler(this.mnDiem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(232, 6);
            // 
            // mnLop
            // 
            this.mnLop.Name = "mnLop";
            this.mnLop.Size = new System.Drawing.Size(235, 26);
            this.mnLop.Text = "Lớp học";
            this.mnLop.Click += new System.EventHandler(this.mnLop_Click);
            // 
            // mnKhoa
            // 
            this.mnKhoa.Name = "mnKhoa";
            this.mnKhoa.Size = new System.Drawing.Size(235, 26);
            this.mnKhoa.Text = "Khoa / Ngành";
            this.mnKhoa.Click += new System.EventHandler(this.mnKhoa_Click);
            // 
            // mnMonHoc
            // 
            this.mnMonHoc.Name = "mnMonHoc";
            this.mnMonHoc.Size = new System.Drawing.Size(235, 26);
            this.mnMonHoc.Text = "Môn học";
            this.mnMonHoc.Click += new System.EventHandler(this.mnMonHoc_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lblTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 627);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1082, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(126, 20);
            this.lblStatus.Text = "Trạng thái: Ready";
            // 
            // lblTime
            // 
            this.lblTime.Name = "lblTime";
            this.lblTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTime.Size = new System.Drawing.Size(941, 20);
            this.lblTime.Spring = true;
            this.lblTime.Text = "Time";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSinhVien,
            this.tsbDiem,
            this.toolStripSeparator3,
            this.tsbLop,
            this.tsbKhoa,
            this.tsbMonHoc,
            this.toolStripSeparator4,
            this.tsbDangXuat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 30);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1082, 50);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbSinhVien
            // 
            this.tsbSinhVien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            // Đã xóa dòng gán Image gây lỗi
            this.tsbSinhVien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSinhVien.Name = "tsbSinhVien";
            this.tsbSinhVien.Padding = new System.Windows.Forms.Padding(5);
            this.tsbSinhVien.Size = new System.Drawing.Size(89, 47);
            this.tsbSinhVien.Text = "Sinh viên";
            this.tsbSinhVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbSinhVien.Click += new System.EventHandler(this.mnSinhVien_Click);
            // 
            // tsbDiem
            // 
            this.tsbDiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            // Đã xóa dòng gán Image gây lỗi
            this.tsbDiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDiem.Name = "tsbDiem";
            this.tsbDiem.Padding = new System.Windows.Forms.Padding(5);
            this.tsbDiem.Size = new System.Drawing.Size(81, 47);
            this.tsbDiem.Text = "Điểm số";
            this.tsbDiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbDiem.Click += new System.EventHandler(this.mnDiem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 50);
            // 
            // tsbLop
            // 
            // Đã xóa dòng gán Image gây lỗi
            this.tsbLop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLop.Name = "tsbLop";
            this.tsbLop.Size = new System.Drawing.Size(66, 47);
            this.tsbLop.Text = "Lớp học";
            this.tsbLop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbLop.Click += new System.EventHandler(this.mnLop_Click);
            // 
            // tsbKhoa
            // 
            // Đã xóa dòng gán Image gây lỗi
            this.tsbKhoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbKhoa.Name = "tsbKhoa";
            this.tsbKhoa.Size = new System.Drawing.Size(47, 47);
            this.tsbKhoa.Text = "Khoa";
            this.tsbKhoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbKhoa.Click += new System.EventHandler(this.mnKhoa_Click);
            // 
            // tsbMonHoc
            // 
            // Đã xóa dòng gán Image gây lỗi
            this.tsbMonHoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMonHoc.Name = "tsbMonHoc";
            this.tsbMonHoc.Size = new System.Drawing.Size(71, 47);
            this.tsbMonHoc.Text = "Môn học";
            this.tsbMonHoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbMonHoc.Click += new System.EventHandler(this.mnMonHoc_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 50);
            // 
            // tsbDangXuat
            // 
            // Đã xóa dòng gán Image gây lỗi
            this.tsbDangXuat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDangXuat.Name = "tsbDangXuat";
            this.tsbDangXuat.Size = new System.Drawing.Size(81, 47);
            this.tsbDangXuat.Text = "Đăng xuất";
            this.tsbDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbDangXuat.Click += new System.EventHandler(this.mnDangXuat_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            // Đã xóa dòng gán Icon gây lỗi
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống Quản lý Sinh viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnThoat;
        private System.Windows.Forms.ToolStripMenuItem mnQuanLy;
        private System.Windows.Forms.ToolStripMenuItem mnKhoa;
        private System.Windows.Forms.ToolStripMenuItem mnLop;
        private System.Windows.Forms.ToolStripMenuItem mnMonHoc;
        private System.Windows.Forms.ToolStripMenuItem mnSinhVien;
        private System.Windows.Forms.ToolStripMenuItem mnDiem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSinhVien;
        private System.Windows.Forms.ToolStripButton tsbDiem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbLop;
        private System.Windows.Forms.ToolStripButton tsbKhoa;
        private System.Windows.Forms.ToolStripButton tsbMonHoc;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbDangXuat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.Timer timer1;
    }
}