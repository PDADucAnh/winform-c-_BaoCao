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
    public class ClassBLL
    {
        ClassDAL dal = new ClassDAL();

        public DataTable GetList()
        {
            return dal.GetAllClasses();
        }

        public string AddClass(ClassDTO cl)
        {
            if (string.IsNullOrEmpty(cl.ClassName)) return "Tên lớp trống!";

            if (dal.InsertClass(cl)) return "Thêm thành công!";
            return "Thêm thất bại (Tên lớp có thể đã tồn tại)!";
        }

        public string UpdateClass(ClassDTO cl)
        {
            if (string.IsNullOrEmpty(cl.ClassName)) return "Tên lớp trống!";

            if (dal.UpdateClass(cl)) return "Sửa thành công!";
            return "Sửa thất bại!";
        }

        public string DeleteClass(int id)
        {
            if (dal.DeleteClass(id)) return "Xóa thành công!";
            return "Xóa thất bại!";
        }
    }
}
