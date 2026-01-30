using System;


//Xây dựng tầng DTO (Data Transfer Object)
//Tầng này chứa các class đại diện cho dữ liệu, giúp truyền tải dữ liệu giữa các lớp mà không phụ thuộc vào database.
namespace WindowsFormsApp1.DTO
{
    public class StudentDTO
    {
        public int Id { get; set; } // StudentID trong database
        public string MSSV { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime Dob { get; set; }
        public string Phone { get; set; }
        public string Hometown { get; set; }

        // --- CẬP NHẬT MỚI ---

        // 1. ClassID: Dùng để lưu xuống Database (Quan trọng)
        // Dùng int? (Nullable) vì sinh viên có thể chưa được xếp lớp
        public int? ClassID { get; set; }

        // 2. ClassName: Dùng để HIỂN THỊ tên lớp lên lưới (Lấy từ bảng Class)
        // Biến này thay thế cho biến 'Class' cũ của bạn
        public string ClassName { get; set; }

        // Lưu ý: Tôi đổi tên 'Class' cũ thành 'ClassName' cho rõ nghĩa hơn.
        // Bạn nhớ sửa lại các chỗ binding dữ liệu cũ từ "Class" -> "ClassName" nhé.
    }
}