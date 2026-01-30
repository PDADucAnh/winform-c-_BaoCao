using System;
using System.Data.SqlClient;

namespace WindowsFormsApp1.DAL
{
    public class DashboardDAL
    {
        // Hàm chung để đếm số dòng trong 1 bảng bất kỳ
        private int GetCount(string tableName)
        {
            int count = 0;
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                string query = $"SELECT COUNT(*) FROM [{tableName}]"; // Dùng [] để tránh lỗi từ khóa
                SqlCommand cmd = new SqlCommand(query, conn);
                count = (int)cmd.ExecuteScalar();
            }
            return count;
        }

        public int CountStudents() => GetCount("Student");
        public int CountClasses() => GetCount("Class");
        public int CountFaculties() => GetCount("Faculty");
        public int CountSubjects() => GetCount("Subject");
    }
}