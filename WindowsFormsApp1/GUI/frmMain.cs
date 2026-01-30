using System;
using System.Windows.Forms;
using WindowsFormsApp1.GUI.ManagementForms;

namespace WindowsFormsApp1.GUI
{
    public partial class frmMain : Form
    {
        private int _userRole;
        private string _displayName;

        // Constructor nhận thông tin người dùng từ frmLogin
        public frmMain(int role, string name)
        {
            InitializeComponent();
            this._userRole = role;
            this._displayName = name;

            SetupUI();
            this.Load += FrmMain_Load;
        }

        // Sự kiện Đồng hồ (Cần thiết cho Designer)
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lblTime != null)
            {
                lblTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                ShowDashboard();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải Dashboard: " + ex.Message);
            }
        }

        private void ShowDashboard()
        {
            frmDashboard dash = new frmDashboard();
            dash.MdiParent = this;
            dash.Dock = DockStyle.Fill;
            dash.Show();
        }

        private void SetupUI()
        {
            string roleName = (_userRole == 0) ? "Quản Trị Viên" : "Nhân Viên";
            lblStatus.Text = $"Xin chào: {_displayName} | Quyền: {roleName} | Thời gian: {DateTime.Now:dd/MM/yyyy}";
            this.Text = $"Hệ thống Quản lý Sinh viên - [{roleName}]";

            if (_userRole == 1) // Staff
            {
                // mnKhoa.Enabled = false;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == childForm.GetType())
                {
                    f.Activate();
                    return;
                }
            }
            childForm.MdiParent = this;
            childForm.Show();
        }

        // --- CÁC SỰ KIỆN MENU ---
        private void mnSinhVien_Click(object sender, EventArgs e) => OpenChildForm(new frmStudent());
        private void mnKhoa_Click(object sender, EventArgs e) => OpenChildForm(new frmFaculty());
        private void mnLop_Click(object sender, EventArgs e) => OpenChildForm(new frmClass());
        private void mnMonHoc_Click(object sender, EventArgs e) => OpenChildForm(new frmSubject());
        private void mnDiem_Click(object sender, EventArgs e) => OpenChildForm(new frmGrade());

        private void mnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Restart();
                Environment.Exit(0);
            }
        }

        private void mnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}