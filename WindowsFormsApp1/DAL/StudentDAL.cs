using System;
using System.Collections.Generic;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using WindowsFormsApp1.DTO;

//(Thực thi các lệnh CRUD)
namespace WindowsFormsApp1.DAL
{
    public class StudentDAL
    {
        // 1. Lấy danh sách sinh viên
        public DataTable GetAllStudents()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Student";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }

        // 2. Thêm sinh viên (Sử dụng SqlParameter để chống SQL Injection)
        public bool InsertStudent(StudentDTO sv)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Student (MSSV, Name, Class, Gender, Dob, Hometown, Phone) VALUES (@MSSV, @Name, @Class, @Gender, @Dob, @Hometown, @Phone)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@MSSV", sv.MSSV);
                cmd.Parameters.AddWithValue("@Name", sv.Name);
                cmd.Parameters.AddWithValue("@Class", sv.Class);
                cmd.Parameters.AddWithValue("@Gender", sv.Gender);
                cmd.Parameters.AddWithValue("@Dob", sv.Dob);
                cmd.Parameters.AddWithValue("@Hometown", sv.Hometown);
                cmd.Parameters.AddWithValue("@Phone", sv.Phone);

                // ExecuteNonQuery trả về số dòng bị ảnh hưởng. > 0 nghĩa là thành công.
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // 3. Xóa sinh viên
        public bool DeleteStudent(int id)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Student WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // 4. Sửa sinh viên (Bạn tự viết tương tự Insert nhé)
        // Thêm hàm này vào class StudentDAL
        public bool UpdateStudent(StudentDTO sv)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                // CẬP NHẬT TẤT CẢ TRỪ MSSV (Vì MSSV là bất biến)
                string query = @"UPDATE Student 
                         SET Name = @Name, 
                             Class = @Class, 
                             Gender = @Gender, 
                             Dob = @Dob, 
                             Hometown = @Hometown, 
                             Phone = @Phone 
                         WHERE Id = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);

                // Tham số ID dùng để tìm dòng cần sửa
                cmd.Parameters.AddWithValue("@Id", sv.Id);

                // Các tham số thông tin mới
                cmd.Parameters.AddWithValue("@Name", sv.Name);
                cmd.Parameters.AddWithValue("@Class", sv.Class);
                cmd.Parameters.AddWithValue("@Gender", sv.Gender);
                cmd.Parameters.AddWithValue("@Dob", sv.Dob);
                cmd.Parameters.AddWithValue("@Hometown", sv.Hometown);
                cmd.Parameters.AddWithValue("@Phone", sv.Phone);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool InsertListStudents(List<StudentDTO> students)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                // 1. Bắt đầu Transaction
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    string query = @"INSERT INTO Student (MSSV, Name, Class, Gender, Dob, Hometown, Phone) 
                             VALUES (@MSSV, @Name, @Class, @Gender, @Dob, @Hometown, @Phone)";

                    foreach (var sv in students)
                    {
                        // Lưu ý: Phải truyền 'transaction' vào SqlCommand
                        using (SqlCommand cmd = new SqlCommand(query, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@MSSV", sv.MSSV);
                            cmd.Parameters.AddWithValue("@Name", sv.Name);
                            cmd.Parameters.AddWithValue("@Class", sv.Class);
                            cmd.Parameters.AddWithValue("@Gender", sv.Gender);
                            cmd.Parameters.AddWithValue("@Dob", sv.Dob);
                            cmd.Parameters.AddWithValue("@Hometown", sv.Hometown);
                            cmd.Parameters.AddWithValue("@Phone", sv.Phone);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    // 2. Nếu chạy hết vòng lặp mà không lỗi -> Commit (Lưu thật sự)
                    transaction.Commit();
                    return true;
                }
                catch (Exception)
                {
                    // 3. Nếu có bất kỳ lỗi nào -> Rollback (Hủy toàn bộ, coi như chưa làm gì)
                    transaction.Rollback();
                    throw; // Ném lỗi ra ngoài để BLL biết
                }
            }
        }
    }
}