using System.Data.SqlClient;

//(Dùng để tái sử dụng kết nối)
namespace WindowsFormsApp1.DAL
{
    public class DatabaseConnection
    {
        // Nên lưu chuỗi này trong App.config thực tế, nhưng để đơn giản ta để ở đây
        private static string strConn = "Data Source=.;Initial Catalog=sale;Trusted_Connection=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(strConn);
        }
    }
}