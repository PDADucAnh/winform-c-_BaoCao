using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Security.Cryptography;
using System.Text;
using WindowsFormsApp1.DAL;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.BLL
{
    public class AccountBLL
    {
        AccountDAL dal = new AccountDAL();

        // Hàm Đăng nhập
        public AccountDTO CheckLogin(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                return null;

            // Mã hóa mật khẩu trước khi gửi xuống DB so sánh (Optional nhưng nên làm)
            // Ở đây tôi viết hàm MD5 đơn giản, hoặc bạn có thể gửi password thô nếu DB lưu thô
            // string passwordHash = MD5Hash(password); 

            // Vì dữ liệu mẫu ở bước trước ta lưu text thường ("123456") nên ta gửi text thường
            return dal.Login(username, password);
        }

        // Tiện ích mã hóa MD5 (Dùng nếu sau này bạn muốn bảo mật hơn)
        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
    }
}
