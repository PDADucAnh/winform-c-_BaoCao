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
    public class ClassDAL
    {
        public DataTable GetAllClasses()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                // LEFT JOIN vì có thể lớp chưa phân ngành
                string query = @"SELECT c.ClassID, c.ClassName, c.MajorID, m.MajorName 
                                 FROM Class c 
                                 LEFT JOIN Major m ON c.MajorID = m.MajorID";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }

        public bool InsertClass(ClassDTO cl)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Class (ClassName, MajorID) VALUES (@Name, @MajorID)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", cl.ClassName);
                // Xử lý nếu MajorID là null
                if (cl.MajorID == null) cmd.Parameters.AddWithValue("@MajorID", DBNull.Value);
                else cmd.Parameters.AddWithValue("@MajorID", cl.MajorID);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateClass(ClassDTO cl)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                string query = "UPDATE Class SET ClassName = @Name, MajorID = @MajorID WHERE ClassID = @ID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", cl.ClassID);
                cmd.Parameters.AddWithValue("@Name", cl.ClassName);
                if (cl.MajorID == null) cmd.Parameters.AddWithValue("@MajorID", DBNull.Value);
                else cmd.Parameters.AddWithValue("@MajorID", cl.MajorID);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteClass(int id)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Class WHERE ClassID = @ID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", id);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
