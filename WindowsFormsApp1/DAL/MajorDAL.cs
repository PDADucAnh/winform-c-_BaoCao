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
    public class MajorDAL
    {
        public DataTable GetAllMajors()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                // JOIN để lấy tên Khoa hiển thị cho đẹp
                string query = @"SELECT m.MajorID, m.MajorName, m.FacultyID, f.FacultyName 
                                 FROM Major m 
                                 INNER JOIN Faculty f ON m.FacultyID = f.FacultyID";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }

        public bool InsertMajor(MajorDTO mj)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Major (MajorName, FacultyID) VALUES (@Name, @FacID)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", mj.MajorName);
                cmd.Parameters.AddWithValue("@FacID", mj.FacultyID);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateMajor(MajorDTO mj)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                string query = "UPDATE Major SET MajorName = @Name, FacultyID = @FacID WHERE MajorID = @ID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", mj.MajorID);
                cmd.Parameters.AddWithValue("@Name", mj.MajorName);
                cmd.Parameters.AddWithValue("@FacID", mj.FacultyID);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteMajor(int id)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Major WHERE MajorID = @ID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", id);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
