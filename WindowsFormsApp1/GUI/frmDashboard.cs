using System;
using System.Windows.Forms;
using WindowsFormsApp1.BLL;

namespace WindowsFormsApp1.GUI
{
    public partial class frmDashboard : Form
    {
        DashboardBLL bll = new DashboardBLL();

        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                // Lấy số liệu từ DB và gán vào các Label
                lblNumStudent.Text = bll.GetNumStudents().ToString();
                lblNumClass.Text = bll.GetNumClasses().ToString();
                lblNumSubject.Text = bll.GetNumSubjects().ToString();
                lblNumFaculty.Text = bll.GetNumFaculties().ToString();
            }
            catch (Exception ex)
            {
                // Nếu DB chưa có bảng hoặc lỗi kết nối thì hiển thị 0
                MessageBox.Show("Lỗi tải thống kê: " + ex.Message);
            }
        }
    }
}