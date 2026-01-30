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
    public class GradeBLL
    {
        GradeDAL dal = new GradeDAL();

        public DataTable GetList()
        {
            return dal.GetFullGrades();
        }

        public string SaveGrade(GradeDTO gr)
        {
            // Validate điểm
            if (gr.Score < 0 || gr.Score > 10)
                return "Điểm số phải nằm trong khoảng 0 đến 10!";

            if (gr.StudentID <= 0 || gr.SubjectID <= 0)
                return "Dữ liệu Sinh viên hoặc Môn học không hợp lệ!";

            if (dal.SaveGrade(gr))
                return "Lưu điểm thành công!";
            else
                return "Lưu điểm thất bại!";
        }

        public string DeleteGrade(int stdID, int subID)
        {
            if (dal.DeleteGrade(stdID, subID))
                return "Xóa điểm thành công!";
            return "Xóa thất bại!";
        }

        // Tiện ích: Tính xếp loại dựa trên điểm số (Dùng để hiển thị lên UI nếu cần)
        public string GetRank(double score)
        {
            if (score >= 8.5) return "Giỏi";
            if (score >= 7.0) return "Khá";
            if (score >= 5.5) return "Trung bình";
            if (score >= 4.0) return "Yếu";
            return "Kém";
        }
    }
}
