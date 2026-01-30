using System;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;
using WindowsFormsApp1.DAL;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.BLL
{
    public class StudentBLL
    {
        StudentDAL dal = new StudentDAL();

        public DataTable GetStudentList()
        {
            return dal.GetAllStudents();
        }

        // Hàm kiểm tra chung
        private string ValidateStudentData(StudentDTO sv)
        {
            if (string.IsNullOrEmpty(sv.MSSV) || string.IsNullOrEmpty(sv.Name))
                return "MSSV và Tên không được để trống!";

            if (!Regex.IsMatch(sv.MSSV, @"^[0-9]{10}$"))
                return "MSSV phải là 10 chữ số!";

            if (!Regex.IsMatch(sv.Phone, @"^[0-9]{10}$"))
                return "Số điện thoại phải là 10 chữ số!";

            int age = DateTime.Now.Year - sv.Dob.Year;
            if (age < 18)
                return "Sinh viên phải từ 18 tuổi trở lên!";
            
            return "OK";
        }

        public string AddStudent(StudentDTO sv)
        {
            string check = ValidateStudentData(sv);
            if (check != "OK") return check;

            try
            {
                if (dal.InsertStudent(sv)) return "Thêm thành công!";
                else return "Thêm thất bại (Lỗi Database)!";
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                if (ex.Number == 2627) return "MSSV đã tồn tại!";
                return "Lỗi SQL: " + ex.Message;
            }
        }

        public string UpdateStudent(StudentDTO sv)
        {
            // Khi sửa thì không check trùng MSSV nữa
            if (string.IsNullOrEmpty(sv.Name)) return "Tên trống!";
            
            // Check tuổi
            int age = DateTime.Now.Year - sv.Dob.Year;
            if (age < 18) return "Sinh viên phải từ 18 tuổi trở lên!";

            if (dal.UpdateStudent(sv)) return "Cập nhật thành công!";
            else return "Cập nhật thất bại!";
        }

        public string DeleteStudent(int id)
        {
            if (dal.DeleteStudent(id)) return "Xóa thành công!";
            else return "Xóa thất bại!";
        }

        // Logic Import Excel (Transaction)
        public void ImportStudents(List<StudentDTO> rawList, out int success, out int fail, out string errorLog)
        {
            List<StudentDTO> validList = new List<StudentDTO>();
            success = 0;
            fail = 0;
            errorLog = "";
            int rowIndex = 0;

            foreach (var sv in rawList)
            {
                rowIndex++;
                string check = ValidateStudentData(sv);
                
                if (check == "OK")
                {
                    // LƯU Ý: Ở đây ta chưa xử lý việc ánh xạ Tên Lớp -> ID Lớp.
                    // Nếu muốn hoàn hảo, bạn cần viết thêm hàm FindClassIDByName trong ClassBLL
                    // Tạm thời nếu Excel không có ClassID, hệ thống sẽ lưu NULL.
                    validList.Add(sv);
                }
                else
                {
                    fail++;
                    errorLog += $"Dòng {rowIndex}: {check} (MSSV: {sv.MSSV})\n";
                }
            }

            if (validList.Count > 0)
            {
                try
                {
                    if (dal.InsertListStudents(validList))
                        success = validList.Count;
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    success = 0;
                    fail += validList.Count;
                    errorLog += $"\nLỖI DATABASE (Transaction Rollback): {ex.Message}";
                }
            }
        }
    }
}