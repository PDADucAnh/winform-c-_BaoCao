using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class GradeDTO
    {
        public int StudentID { get; set; }
        public int SubjectID { get; set; }
        public double Score { get; set; } // Dùng double cho chuẩn SQL Float

        // Các thuộc tính phụ để hiển thị tên SV và tên Môn cho dễ nhìn
        public string StudentName { get; set; }
        public string MSSV { get; set; }
        public string SubjectName { get; set; }
    }
}
