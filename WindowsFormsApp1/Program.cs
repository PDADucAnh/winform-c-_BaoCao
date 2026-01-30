using System;
using System.Windows.Forms;
using WindowsFormsApp1.GUI; // Import thư mục chứa các Form

namespace WindowsFormsApp1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // BƯỚC 1: Chạy form Đăng nhập dưới dạng Hộp thoại (Dialog)
            // Lúc này chưa chạy Application.Run, nên đóng form này app chưa tắt
            frmLogin login = new frmLogin();

            // Lệnh này sẽ tạm dừng code tại đây cho đến khi người dùng Đăng nhập hoặc Tắt form
            if (login.ShowDialog() == DialogResult.OK)
            {
                // BƯỚC 2: Nếu đăng nhập thành công (trả về OK)
                // Lấy thông tin Role và Tên từ form Login để truyền sang Main
                int role = login.UserRole;
                string name = login.DisplayName;

                // BƯỚC 3: Bắt đầu chạy Form Chính (frmMain)
                // Đây mới là luồng chính của ứng dụng
                Application.Run(new frmMain(role, name));
            }
            else
            {
                // Nếu người dùng bấm Thoát hoặc tắt nút X ở form Login -> Tắt luôn app
                Application.Exit();
            }
        }
    }
}