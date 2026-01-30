using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class ClassDTO
    {
        public int ClassID { get; set; }
        public string ClassName { get; set; }
        public int? MajorID { get; set; } // Có thể null (int?) nếu chưa phân ngành

        // Thuộc tính phụ: Hiển thị tên Ngành
        public string MajorName { get; set; }
    }
}
