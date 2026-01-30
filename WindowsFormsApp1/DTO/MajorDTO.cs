using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class MajorDTO
    {
        public int MajorID { get; set; }
        public string MajorName { get; set; }
        public int FacultyID { get; set; } // Khóa ngoại liên kết với Khoa

        // Thuộc tính phụ (Optional): Dùng để hiển thị tên Khoa lên Grid nếu cần
        public string FacultyName { get; set; }
    }
}
