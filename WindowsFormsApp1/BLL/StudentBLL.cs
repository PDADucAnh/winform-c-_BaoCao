using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Text.RegularExpressions;
using WindowsFormsApp1.DAL;
using WindowsFormsApp1.DTO;

//Xây dựng tầng BLL (Business Logic Layer)
//Đây là "bộ não" kiểm tra tính đúng đắn của dữ liệu trước khi gọi DAL.

namespace WindowsFormsApp1.BLL
{
    public class StudentBLL
    {
        StudentDAL dal = new StudentDAL();

        public DataTable GetStudentList()
        {
            return dal.GetAllStudents();
        }

        public string AddStudent(StudentDTO sv)
        {
            // --- VALIDATION (Kiểm tra logic) ---

            // 1. Kiểm tra rỗng
            if (string.IsNullOrEmpty(sv.MSSV) || string.IsNullOrEmpty(sv.Name))
                return "MSSV và Tên không được để trống!";

            // 2. Kiểm tra định dạng số (10 chữ số) cho MSSV và Phone
            // Biểu thức chính quy: ^[0-9]{10}$ nghĩa là bắt đầu và kết thúc phải là số, dài đúng 10 ký tự
            if (!Regex.IsMatch(sv.MSSV, @"^[0-9]{10}$"))
                return "MSSV phải là 10 chữ số!";

            if (!Regex.IsMatch(sv.Phone, @"^[0-9]{10}$"))
                return "Số điện thoại phải là 10 chữ số!";

            // 3. Kiểm tra tuổi >= 18
            int age = DateTime.Now.Year - sv.Dob.Year;
            if (age < 18)
                return "Sinh viên phải từ 18 tuổi trở lên!";

            // --- GỌI DAL ---
            try
            {
                if (dal.InsertStudent(sv))
                    return "Thêm thành công!";
                else
                    return "Thêm thất bại (Lỗi Database)!";
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                if (ex.Number == 2627) return "MSSV đã tồn tại!";
                return "Lỗi SQL: " + ex.Message;
            }
        }
        // Thêm hàm này vào class StudentBLL
        public string UpdateStudent(StudentDTO sv)
        {
            // --- VALIDATION CHO VIỆC SỬA ---

            // 1. Kiểm tra rỗng (Tên)
            if (string.IsNullOrEmpty(sv.Name))
                return "Tên không được để trống!";

            // 2. Kiểm tra SĐT (MSSV không sửa nên không cần check lại)
            if (!Regex.IsMatch(sv.Phone, @"^[0-9]{10}$"))
                return "Số điện thoại phải là 10 chữ số!";

            // 3. Kiểm tra tuổi
            int age = DateTime.Now.Year - sv.Dob.Year;
            if (age < 18)
                return "Sinh viên phải từ 18 tuổi trở lên!";

            // --- GỌI DAL ---
            try
            {
                if (dal.UpdateStudent(sv))
                    return "Cập nhật thành công!";
                else
                    return "Cập nhật thất bại (Không tìm thấy ID)!";
            }
            catch (Exception ex)
            {
                return "Lỗi hệ thống: " + ex.Message;
            }
        }
        public string DeleteStudent(int id)
        {
            if (dal.DeleteStudent(id)) return "Xóa thành công!";
            else return "Xóa thất bại!";
        }

        // Thêm hàm bổ trợ này vào class StudentBLL (để dùng chung cho cả Thêm lẻ và Thêm list)
        private string ValidateStudentData(StudentDTO sv)
        {
            if (string.IsNullOrEmpty(sv.MSSV) || string.IsNullOrEmpty(sv.Name))
                return "MSSV và Tên trống";

            if (!System.Text.RegularExpressions.Regex.IsMatch(sv.MSSV, @"^[0-9]{10}$"))
                return "MSSV sai định dạng";

            if (!System.Text.RegularExpressions.Regex.IsMatch(sv.Phone, @"^[0-9]{10}$"))
                return "SĐT sai định dạng";

            int age = DateTime.Now.Year - sv.Dob.Year;
            if (age < 18)
                return "Chưa đủ 18 tuổi";

            return "OK"; // Dữ liệu ổn
        }

        // Thêm hàm này vào class StudentBLL
        public string ImportStudents(List<StudentDTO> rawList, out int success, out int fail, out string errorLog)
        {
            List<StudentDTO> validList = new List<StudentDTO>();
            success = 0;
            fail = 0;
            errorLog = "";
            int rowIndex = 0; // Để đếm dòng báo lỗi cho người dùng

            // 1. Giai đoạn SÀNG LỌC (Validation)
            foreach (var sv in rawList)
            {
                rowIndex++;
                string check = ValidateStudentData(sv);

                if (check == "OK")
                {
                    validList.Add(sv);
                }
                else
                {
                    fail++;
                    errorLog += $"Dòng {rowIndex}: {check} (MSSV: {sv.MSSV})\n";
                }
            }

            // 2. Giai đoạn INSERT TRANSACTION
            if (validList.Count > 0)
            {
                try
                {
                    // Gọi DAL để insert 1 lần cục validList
                    bool dbResult = dal.InsertListStudents(validList);

                    if (dbResult)
                    {
                        success = validList.Count;
                    }
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    // Trường hợp lỗi DB (ví dụ: trùng MSSV trong DB mà code chưa check được)
                    // Vì dùng Transaction nên nếu lỗi là toàn bộ validList bị hủy
                    success = 0;
                    fail += validList.Count;

                    if (ex.Number == 2627)
                        errorLog += "\nLỖI DATABASE: Có MSSV trong danh sách đã tồn tại trong hệ thống. Giao dịch bị hủy bỏ.";
                    else
                        errorLog += $"\nLỖI DATABASE: {ex.Message}. Giao dịch bị hủy bỏ.";
                }
            }

            return "Hoàn tất xử lý.";
        }
    }
}
