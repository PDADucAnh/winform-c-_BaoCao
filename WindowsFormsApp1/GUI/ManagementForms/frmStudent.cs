using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp1.BLL;
using WindowsFormsApp1.DTO;
using WindowsFormsApp1.Utilities; // Sử dụng tiện ích Excel

namespace WindowsFormsApp1.GUI.ManagementForms
{
    public partial class frmStudent : Form
    {
        // Khởi tạo các BLL cần thiết
        StudentBLL studentBLL = new StudentBLL();
        ClassBLL classBLL = new ClassBLL();

        public frmStudent()
        {
            InitializeComponent();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            LoadComboBoxClass(); // Load danh sách lớp trước
            LoadData();          // Load danh sách sinh viên sau
        }

        // 1. Hàm load danh sách Lớp vào ComboBox
        private void LoadComboBoxClass()
        {
            cbClass.DataSource = classBLL.GetList();
            cbClass.DisplayMember = "ClassName"; // Hiển thị tên lớp (VD: CCQ2211K)
            cbClass.ValueMember = "ClassID";     // Giá trị ngầm là ID (VD: 1, 2...)
            cbClass.SelectedIndex = -1;          // Mặc định không chọn gì
        }

        // 2. Hàm load danh sách Sinh viên lên lưới
        private void LoadData()
        {
            dgvStudent.DataSource = studentBLL.GetStudentList();
            FormatGrid();
        }

        // Định dạng tên cột cho đẹp (Mapping)
        private void FormatGrid()
        {
            if (dgvStudent.Columns.Contains("MSSV")) dgvStudent.Columns["MSSV"].HeaderText = "Mã SV";
            if (dgvStudent.Columns.Contains("Name")) dgvStudent.Columns["Name"].HeaderText = "Họ Tên";
            if (dgvStudent.Columns.Contains("Gender")) dgvStudent.Columns["Gender"].HeaderText = "Giới Tính";
            if (dgvStudent.Columns.Contains("Dob"))
            {
                dgvStudent.Columns["Dob"].HeaderText = "Ngày Sinh";
                dgvStudent.Columns["Dob"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            if (dgvStudent.Columns.Contains("Phone")) dgvStudent.Columns["Phone"].HeaderText = "SĐT";
            if (dgvStudent.Columns.Contains("Hometown")) dgvStudent.Columns["Hometown"].HeaderText = "Quê Quán";

            // --- QUAN TRỌNG: Hiển thị Tên Lớp thay vì ID ---
            if (dgvStudent.Columns.Contains("ClassName"))
            {
                dgvStudent.Columns["ClassName"].HeaderText = "Lớp";
                dgvStudent.Columns["ClassName"].Visible = true;
            }

            // Ẩn các cột ID kỹ thuật
            if (dgvStudent.Columns.Contains("Id")) dgvStudent.Columns["Id"].Visible = false;
            if (dgvStudent.Columns.Contains("ClassID")) dgvStudent.Columns["ClassID"].Visible = false;
        }

        private void ClearInput()
        {
            tbMSSV.Clear();
            tbName.Clear();
            cbClass.SelectedIndex = -1; // Reset chọn lớp
            tbHometown.Clear();
            tbPhone.Clear();
            cbGender.SelectedIndex = -1;
            dtpDob.Value = DateTime.Now;
            tbMSSV.Enabled = true; // Mở khóa MSSV để thêm mới
        }

        // --- CÁC NÚT CHỨC NĂNG ---

        private void btNew_Click(object sender, EventArgs e)
        {
            StudentDTO sv = new StudentDTO();
            sv.MSSV = tbMSSV.Text;
            sv.Name = tbName.Text;
            sv.Gender = cbGender.Text;
            sv.Dob = dtpDob.Value;
            sv.Hometown = tbHometown.Text;
            sv.Phone = tbPhone.Text;

            // Lấy ID lớp từ ComboBox
            if (cbClass.SelectedValue != null)
            {
                sv.ClassID = (int)cbClass.SelectedValue;
            }

            string result = studentBLL.AddStudent(sv);
            MessageBox.Show(result);

            if (result.Contains("thành công"))
            {
                LoadData();
                ClearInput();
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (dgvStudent.SelectedRows.Count > 0)
            {
                StudentDTO sv = new StudentDTO();
                sv.Id = Convert.ToInt32(dgvStudent.CurrentRow.Cells["Id"].Value);
                sv.MSSV = tbMSSV.Text; // Dù bị khóa nhưng vẫn gán để không null
                sv.Name = tbName.Text;
                sv.Gender = cbGender.Text;
                sv.Dob = dtpDob.Value;
                sv.Hometown = tbHometown.Text;
                sv.Phone = tbPhone.Text;

                if (cbClass.SelectedValue != null)
                    sv.ClassID = (int)cbClass.SelectedValue;

                string result = studentBLL.UpdateStudent(sv);
                MessageBox.Show(result);

                if (result.Contains("thành công"))
                {
                    LoadData();
                    ClearInput();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa.");
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudent.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvStudent.CurrentRow.Cells["Id"].Value);
                    string result = studentBLL.DeleteStudent(id);
                    MessageBox.Show(result);
                    LoadData();
                    ClearInput();
                }
            }
        }

        // --- SỰ KIỆN GRID VIEW ---

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudent.Rows[e.RowIndex];

                tbMSSV.Text = row.Cells["MSSV"].Value?.ToString();
                tbName.Text = row.Cells["Name"].Value?.ToString();
                cbGender.Text = row.Cells["Gender"].Value?.ToString();

                if (row.Cells["Dob"].Value != DBNull.Value)
                    dtpDob.Value = Convert.ToDateTime(row.Cells["Dob"].Value);

                tbHometown.Text = row.Cells["Hometown"].Value?.ToString();
                tbPhone.Text = row.Cells["Phone"].Value?.ToString();

                // Tự động chọn Lớp trên ComboBox dựa vào ClassID của dòng đang chọn
                if (row.Cells["ClassID"].Value != null && row.Cells["ClassID"].Value != DBNull.Value)
                {
                    cbClass.SelectedValue = row.Cells["ClassID"].Value;
                }
                else
                {
                    cbClass.SelectedIndex = -1;
                }

                tbMSSV.Enabled = false; // Khóa MSSV khi chọn sửa
            }
        }

        // --- IMPORT / EXPORT EXCEL (Dùng ExcelHelper) ---

        private void btExportExcel_Click(object sender, EventArgs e)
        {
            // Lấy DataTable từ DataSource của GridView (đã có đủ cột)
            // Tuy nhiên, DataSource gốc là từ BLL, ta nên lấy lại từ BLL cho chuẩn
            System.Data.DataTable dt = studentBLL.GetStudentList();
            ExcelHelper.ExportToExcel(dt, "DanhSachSinhVien");
        }

        private void btImportExcel_Click(object sender, EventArgs e)
        {
            string fileError;
            // 1. Gọi Helper để đọc file
            List<StudentDTO> listSV = ExcelHelper.ImportStudents(out fileError);

            if (listSV != null && listSV.Count > 0)
            {
                int success, fail;
                string dbError;

                // 2. Gọi BLL để validate và lưu
                studentBLL.ImportStudents(listSV, out success, out fail, out dbError);

                // 3. Hiển thị kết quả
                LoadData();
                string msg = $"Tổng dòng đọc được: {listSV.Count}\n" +
                             $"- Thành công: {success}\n" +
                             $"- Thất bại: {fail}";

                if (!string.IsNullOrEmpty(fileError) || !string.IsNullOrEmpty(dbError))
                    msg += $"\n\nChi tiết lỗi:\n{fileError}\n{dbError}";

                MessageBox.Show(msg, "Kết quả Import", MessageBoxButtons.OK, fail > 0 ? MessageBoxIcon.Warning : MessageBoxIcon.Information);
            }
            else if (!string.IsNullOrEmpty(fileError))
            {
                MessageBox.Show(fileError, "Lỗi đọc file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng form con, quay về form cha Main
        }

        // Chặn nhập chữ cho SĐT và MSSV
        private void tbNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}