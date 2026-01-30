using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using ClosedXML.Excel; // Thư viện đọc/ghi Excel
using WindowsFormsApp1.DTO; // Để dùng StudentDTO

namespace WindowsFormsApp1.Utilities
{
    public static class ExcelHelper
    {
        // =============================================================
        // 1. XUẤT DỮ LIỆU RA EXCEL (Dùng chung cho mọi DataTable)
        // =============================================================
        public static void ExportToExcel(DataTable dt, string sheetName = "Sheet1")
        {
            try
            {
                // Mở hộp thoại chọn nơi lưu file
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", FileName = $"{sheetName}_{DateTime.Now:ddMMyyyy}.xlsx" })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add(dt, sheetName);
                            worksheet.Columns().AdjustToContents(); // Tự động chỉnh độ rộng cột
                            workbook.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xuất file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =============================================================
        // 2. NHẬP DANH SÁCH SINH VIÊN TỪ EXCEL (Logic đặc thù cho SV)
        // =============================================================
        // Hàm này trả về List<StudentDTO> để tầng BLL xử lý tiếp
        public static List<StudentDTO> ImportStudents(out string errorLog)
        {
            List<StudentDTO> listResult = new List<StudentDTO>();
            errorLog = "";

            try
            {
                // Mở hộp thoại chọn file
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx;*.xls", ValidateNames = true })
                {
                    if (ofd.ShowDialog() != DialogResult.OK)
                        return null; // Người dùng hủy chọn

                    using (var workbook = new XLWorkbook(ofd.FileName))
                    {
                        var worksheet = workbook.Worksheet(1); // Lấy sheet đầu tiên
                        var rows = worksheet.RangeUsed().RowsUsed();

                        foreach (var row in rows)
                        {
                            if (row.RowNumber() == 1) continue; // Bỏ qua tiêu đề

                            try
                            {
                                StudentDTO sv = new StudentDTO();

                                // --- MAPPING DỮ LIỆU ---
                                sv.MSSV = row.Cell(1).Value.ToString().Trim(); // Cột A
                                sv.Name = row.Cell(2).Value.ToString().Trim(); // Cột B
                                sv.Gender = row.Cell(3).Value.ToString().Trim(); // Cột C

                                // Xử lý Ngày sinh (Cột D)
                                HandleDateImport(row.Cell(4), sv);

                                // Xử lý SĐT (Cột E) - Thêm số 0
                                string rawPhone = row.Cell(5).Value.ToString().Trim();
                                if (rawPhone.Length == 9 && long.TryParse(rawPhone, out _))
                                    rawPhone = "0" + rawPhone;
                                sv.Phone = rawPhone;

                                // Xử lý Lớp (Cột G) - Lưu tên lớp tạm thời vào ClassName
                                sv.ClassName = row.Cell(7).Value.ToString().Trim();

                                sv.Hometown = row.Cell(8).Value.ToString().Trim(); // Cột H

                                listResult.Add(sv);
                            }
                            catch (Exception ex)
                            {
                                errorLog += $"Dòng {row.RowNumber()}: Lỗi định dạng ({ex.Message})\n";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                errorLog = "Lỗi đọc file hệ thống: " + ex.Message;
                return null;
            }

            return listResult;
        }

        // Hàm phụ: Xử lý logic ngày tháng phức tạp tách ra cho gọn
        private static void HandleDateImport(IXLCell cell, StudentDTO sv)
        {
            if (cell.IsEmpty())
            {
                sv.Dob = DateTime.Now.AddYears(-18); // Mặc định đủ tuổi nếu trống
            }
            else
            {
                if (cell.DataType == XLDataType.DateTime)
                {
                    sv.Dob = cell.GetDateTime();
                }
                else
                {
                    string rawDate = cell.Value.ToString().Trim();
                    string[] formats = { "dd/MM/yyyy", "d/M/yyyy", "M/d/yyyy", "MM/dd/yyyy", "yyyy-MM-dd" };

                    if (DateTime.TryParseExact(rawDate, formats,
                        System.Globalization.CultureInfo.InvariantCulture,
                        System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
                    {
                        sv.Dob = parsedDate;
                    }
                    else
                    {
                        // Fallback cuối cùng
                        sv.Dob = DateTime.TryParse(rawDate, out DateTime d) ? d : DateTime.Now;
                    }
                }
            }
        }
    }
}