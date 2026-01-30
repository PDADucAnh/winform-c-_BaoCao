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
    public class SubjectBLL
    {
        SubjectDAL dal = new SubjectDAL();

        public DataTable GetList()
        {
            return dal.GetAllSubjects();
        }

        public string AddSubject(SubjectDTO sub)
        {
            if (string.IsNullOrEmpty(sub.SubjectName)) return "Tên môn trống!";
            if (sub.Credits <= 0) return "Số tín chỉ phải > 0!";

            if (dal.InsertSubject(sub)) return "Thêm thành công!";
            return "Thêm thất bại!";
        }

        public string UpdateSubject(SubjectDTO sub)
        {
            if (string.IsNullOrEmpty(sub.SubjectName)) return "Tên môn trống!";
            if (sub.Credits <= 0) return "Số tín chỉ phải > 0!";

            if (dal.UpdateSubject(sub)) return "Sửa thành công!";
            return "Sửa thất bại!";
        }

        public string DeleteSubject(int id)
        {
            if (dal.DeleteSubject(id)) return "Xóa thành công!";
            return "Xóa thất bại!";
        }
    }
}
