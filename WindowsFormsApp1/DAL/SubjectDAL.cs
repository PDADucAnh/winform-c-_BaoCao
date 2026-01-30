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
    public class SubjectDAL
    {
        public DataTable GetAllSubjects()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Subject";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }

        public bool InsertSubject(SubjectDTO sub)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Subject (SubjectName, Credits) VALUES (@Name, @Credits)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", sub.SubjectName);
                cmd.Parameters.AddWithValue("@Credits", sub.Credits);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateSubject(SubjectDTO sub)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                string query = "UPDATE Subject SET SubjectName = @Name, Credits = @Credits WHERE SubjectID = @ID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", sub.SubjectID);
                cmd.Parameters.AddWithValue("@Name", sub.SubjectName);
                cmd.Parameters.AddWithValue("@Credits", sub.Credits);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteSubject(int id)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Subject WHERE SubjectID = @ID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", id);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
