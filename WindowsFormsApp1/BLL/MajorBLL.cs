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
    public class MajorBLL
    {
        MajorDAL dal = new MajorDAL();

        public DataTable GetList()
        {
            return dal.GetAllMajors();
        }

        public string AddMajor(MajorDTO mj)
        {
            if (string.IsNullOrEmpty(mj.MajorName)) return "Tên ngành trống!";
            if (mj.FacultyID <= 0) return "Chưa chọn Khoa!";

            if (dal.InsertMajor(mj)) return "Thêm thành công!";
            return "Thêm thất bại!";
        }

        public string UpdateMajor(MajorDTO mj)
        {
            if (string.IsNullOrEmpty(mj.MajorName)) return "Tên ngành trống!";

            if (dal.UpdateMajor(mj)) return "Sửa thành công!";
            return "Sửa thất bại!";
        }

        public string DeleteMajor(int id)
        {
            if (dal.DeleteMajor(id)) return "Xóa thành công!";
            return "Xóa thất bại!";
        }
    }
}
