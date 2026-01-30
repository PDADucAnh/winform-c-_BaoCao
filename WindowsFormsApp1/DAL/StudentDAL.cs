using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAL
{
    public class StudentDAL
    {
        public DataTable GetAllStudents()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                // JOIN với Class để lấy tên lớp hiển thị lên Grid
                string query = @"SELECT s.Id, s.MSSV, s.Name, s.Gender, 
                                        s.Dob, s.Phone, s.Hometown, s.ClassID, c.ClassName
                                 FROM Student s
                                 LEFT JOIN Class c ON s.ClassID = c.ClassID";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }

        public bool InsertStudent(StudentDTO sv)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                // ID tự tăng nên không cần INSERT
                string query = @"INSERT INTO Student (MSSV, Name, Gender, Dob, Phone, Hometown, ClassID) 
                                 VALUES (@MSSV, @Name, @Gender, @Dob, @Phone, @Hometown, @ClassID)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@MSSV", sv.MSSV);
                cmd.Parameters.AddWithValue("@Name", sv.Name);
                cmd.Parameters.AddWithValue("@Gender", sv.Gender);
                cmd.Parameters.AddWithValue("@Dob", sv.Dob);
                cmd.Parameters.AddWithValue("@Phone", sv.Phone);
                cmd.Parameters.AddWithValue("@Hometown", sv.Hometown);

                // Xử lý ClassID null
                if (sv.ClassID == null || sv.ClassID == 0) cmd.Parameters.AddWithValue("@ClassID", DBNull.Value);
                else cmd.Parameters.AddWithValue("@ClassID", sv.ClassID);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateStudent(StudentDTO sv)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                // Không update MSSV
                string query = @"UPDATE Student 
                                 SET Name = @Name, Gender = @Gender, Dob = @Dob, 
                                     Phone = @Phone, Hometown = @Hometown, ClassID = @ClassID
                                 WHERE Id = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", sv.Id);
                cmd.Parameters.AddWithValue("@Name", sv.Name);
                cmd.Parameters.AddWithValue("@Gender", sv.Gender);
                cmd.Parameters.AddWithValue("@Dob", sv.Dob);
                cmd.Parameters.AddWithValue("@Phone", sv.Phone);
                cmd.Parameters.AddWithValue("@Hometown", sv.Hometown);

                if (sv.ClassID == null || sv.ClassID == 0) cmd.Parameters.AddWithValue("@ClassID", DBNull.Value);
                else cmd.Parameters.AddWithValue("@ClassID", sv.ClassID);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

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

        // Transaction Import (Đã cập nhật cho DB mới)
        public bool InsertListStudents(List<StudentDTO> students)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    string query = @"INSERT INTO Student (MSSV, Name, Gender, Dob, Phone, Hometown, ClassID) 
                                     VALUES (@MSSV, @Name, @Gender, @Dob, @Phone, @Hometown, @ClassID)";

                    foreach (var sv in students)
                    {
                        using (SqlCommand cmd = new SqlCommand(query, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@MSSV", sv.MSSV);
                            cmd.Parameters.AddWithValue("@Name", sv.Name);
                            cmd.Parameters.AddWithValue("@Gender", sv.Gender);
                            cmd.Parameters.AddWithValue("@Dob", sv.Dob);
                            cmd.Parameters.AddWithValue("@Phone", sv.Phone);
                            cmd.Parameters.AddWithValue("@Hometown", sv.Hometown);
                            // Mặc định Import từ Excel sẽ chưa có ClassID (hoặc phải xử lý tìm ID theo tên Lớp ở BLL)
                            // Tạm thời để NULL nếu chưa xử lý logic tìm lớp
                            if (sv.ClassID == null || sv.ClassID == 0) cmd.Parameters.AddWithValue("@ClassID", DBNull.Value);
                            else cmd.Parameters.AddWithValue("@ClassID", sv.ClassID);

                            cmd.ExecuteNonQuery();
                        }
                    }
                    transaction.Commit();
                    return true;
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }
}