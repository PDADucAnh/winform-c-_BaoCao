using System;


//Xây dựng tầng DTO (Data Transfer Object)
//Tầng này chứa các class đại diện cho dữ liệu, giúp truyền tải dữ liệu giữa các lớp mà không phụ thuộc vào database.
namespace WindowsFormsApp1.DTO
{
    public class StudentDTO
    {
        public int Id { get; set; }
        public string MSSV { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string Gender { get; set; }
        public DateTime Dob { get; set; }
        public string Hometown { get; set; }
        public string Phone { get; set; }
        // Sau này có thể thêm FacultyID ở đây
    }
}