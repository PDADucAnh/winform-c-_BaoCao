using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WindowsFormsApp1.DAL;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.BLL
{
    public class FacultyBLL
    {
        FacultyDAL dal = new FacultyDAL();

        public DataTable GetList()
        {
            return dal.GetAllFaculties();
        }

        public string AddFaculty(FacultyDTO fa)
        {
            if (string.IsNullOrEmpty(fa.FacultyName))
                return "Tên khoa không được để trống!";

            if (dal.InsertFaculty(fa))
                return "Thêm khoa thành công!";
            return "Thêm thất bại!";
        }

        public string UpdateFaculty(FacultyDTO fa)
        {
            if (string.IsNullOrEmpty(fa.FacultyName))
                return "Tên khoa không được để trống!";

            if (dal.UpdateFaculty(fa))
                return "Cập nhật thành công!";
            return "Cập nhật thất bại!";
        }

        public string DeleteFaculty(int id)
        {
            // Có thể thêm logic: Kiểm tra xem Khoa này có Ngành nào chưa? Nếu có thì không cho xóa.
            if (dal.DeleteFaculty(id))
                return "Xóa thành công!";
            return "Xóa thất bại (Có thể khoa đang chứa dữ liệu ngành)!";
        }
    }
}
