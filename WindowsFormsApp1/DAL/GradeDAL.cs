using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAL
{
    public class GradeDAL
    {
        // Lấy bảng điểm đầy đủ (Có tên SV, Tên Môn)
        public DataTable GetFullGrades()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                // --- SỬA LỖI TẠI DÒNG JOIN BÊN DƯỚI ---
                // Sửa s.StudentID thành s.Id (vì bảng Student có khóa chính là Id)
                string query = @"SELECT g.StudentID, s.MSSV, s.Name AS StudentName, 
                                        g.SubjectID, sub.SubjectName, g.Score 
                                 FROM Grade g
                                 JOIN Student s ON g.StudentID = s.Id 
                                 JOIN Subject sub ON g.SubjectID = sub.SubjectID";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }

        // Thêm hoặc Cập nhật điểm (Upsert)
        public bool SaveGrade(GradeDTO gr)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                // Kiểm tra xem đã có điểm chưa
                string checkQuery = "SELECT COUNT(*) FROM Grade WHERE StudentID=@StdID AND SubjectID=@SubID";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@StdID", gr.StudentID);
                checkCmd.Parameters.AddWithValue("@SubID", gr.SubjectID);

                int count = (int)checkCmd.ExecuteScalar();

                string query = "";
                if (count > 0)
                {
                    // Update
                    query = "UPDATE Grade SET Score = @Score WHERE StudentID = @StdID AND SubjectID = @SubID";
                }
                else
                {
                    // Insert
                    query = "INSERT INTO Grade (StudentID, SubjectID, Score) VALUES (@StdID, @SubID, @Score)";
                }

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StdID", gr.StudentID);
                cmd.Parameters.AddWithValue("@SubID", gr.SubjectID);
                cmd.Parameters.AddWithValue("@Score", gr.Score);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteGrade(int stdID, int subID)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Grade WHERE StudentID = @StdID AND SubjectID = @SubID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StdID", stdID);
                cmd.Parameters.AddWithValue("@SubID", subID);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}