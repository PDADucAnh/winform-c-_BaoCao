using System;
using System.Windows.Forms;
using WindowsFormsApp1.BLL;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.GUI
{
    public partial class frmLogin : Form
    {
        // Gọi lớp nghiệp vụ
        AccountBLL bll = new AccountBLL();

        // Các thuộc tính public để truyền dữ liệu sang Form Main (Program.cs sẽ đọc)
        public int UserRole { get; private set; }
        public string DisplayName { get; private set; }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            string pass = txtPass.Text.Trim();

            // 1. Kiểm tra rỗng
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUser.Focus();
                return;
            }

            try
            {
                // 2. Gọi BLL kiểm tra
                AccountDTO account = bll.CheckLogin(user, pass);

                if (account != null)
                {
                    // 3. Đăng nhập thành công -> Lưu thông tin
                    this.UserRole = account.Role;
                    this.DisplayName = account.DisplayName;

                    // Trả về kết quả OK để Program.cs biết và mở Form Main
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPass.Clear();
                    txtPass.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}