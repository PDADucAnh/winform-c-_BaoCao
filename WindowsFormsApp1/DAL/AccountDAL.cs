using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAL
{
    public class AccountDAL
    {
        // Kiểm tra đăng nhập
        // Trả về AccountDTO nếu đúng, trả về null nếu sai
        public AccountDTO Login(string username, string password)
        {
            AccountDTO account = null;
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                // Lưu ý: Password ở đây đang so sánh text thô. Thực tế nên mã hóa MD5/SHA.
                string query = "SELECT * FROM Account WHERE Username = @user AND Password = @pass";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", password);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        account = new AccountDTO();
                        account.Username = reader["Username"].ToString();
                        account.DisplayName = reader["DisplayName"].ToString();
                        account.Role = (int)reader["Role"];
                        account.Password = reader["Password"].ToString();
                    }
                }
            }
            return account;
        }
    }
}
