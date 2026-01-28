using System;
using System.Windows.Forms;
using WindowsFormsApp1.BLL;
using WindowsFormsApp1.DTO;
using ClosedXML.Excel;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        StudentBLL bll = new StudentBLL(); // Khởi tạo lớp nghiệp vụ

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            // 1. Lấy dữ liệu từ BLL
            dgvStudent.DataSource = bll.GetStudentList();

            // 2. Đổi tên cột hiển thị (Mapping từ tên biến sang Tiếng Việt)
            // Lưu ý: Tên trong ngoặc vuông ["..."] phải khớp chính xác với tên thuộc tính trong StudentDTO

            if (dgvStudent.Columns.Contains("MSSV"))
                dgvStudent.Columns["MSSV"].HeaderText = "Ma So SV";

            if (dgvStudent.Columns.Contains("Name"))
                dgvStudent.Columns["Name"].HeaderText = "Ho Ten";

            if (dgvStudent.Columns.Contains("Class"))
                dgvStudent.Columns["Class"].HeaderText = "Lop";

            if (dgvStudent.Columns.Contains("Gender"))
                dgvStudent.Columns["Gender"].HeaderText = "Gioi Tinh";

            if (dgvStudent.Columns.Contains("Dob"))
                dgvStudent.Columns["Dob"].HeaderText = "Ngay Sinh";

            if (dgvStudent.Columns.Contains("Hometown"))
                dgvStudent.Columns["Hometown"].HeaderText = "Que Quan";

            if (dgvStudent.Columns.Contains("Phone"))
                dgvStudent.Columns["Phone"].HeaderText = "SDT";

            // 3. Ẩn cột ID (Vì ID là kỹ thuật, người dùng không cần thấy)
            if (dgvStudent.Columns.Contains("Id"))
                dgvStudent.Columns["Id"].Visible = false;

            // 4. (Tùy chọn) Định dạng lại cột Ngày sinh cho dễ nhìn (dd/MM/yyyy)
            if (dgvStudent.Columns.Contains("Dob"))
                dgvStudent.Columns["Dob"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }
        // --- CÁC HÀM TIỆN ÍCH BỔ TRỢ (Đã thêm mới để fix lỗi) ---

        // Hàm xóa trắng các ô nhập liệu sau khi thêm/xóa/sửa
        // 1. Cập nhật hàm ClearInput (Để mở khóa ô MSSV khi thêm mới)
        private void ClearInput()
        {
            tbMSSV.Clear();
            tbName.Clear();
            tbClass.Clear();
            tbHometown.Clear();
            tbPhone.Clear();
            cbGender.SelectedIndex = -1;
            dtpDob.Value = DateTime.Now;

            // QUAN TRỌNG: Cho phép nhập MSSV lại (trạng thái thêm mới)
            tbMSSV.Enabled = true;
        }
        // Hàm chặn nhập chữ cái vào ô số (MSSV, Phone)
        private void tbNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự không phải số
            }
        }

        // ---------------------------------------------------------

        private void btNew_Click(object sender, EventArgs e)
        {
            // 1. Đóng gói dữ liệu từ giao diện vào DTO
            StudentDTO sv = new StudentDTO();
            sv.MSSV = tbMSSV.Text;
            sv.Name = tbName.Text;
            sv.Class = tbClass.Text;
            sv.Gender = cbGender.Text;
            sv.Dob = dtpDob.Value;
            sv.Hometown = tbHometown.Text;
            sv.Phone = tbPhone.Text;

            // 2. Gửi xuống BLL xử lý và nhận thông báo
            string result = bll.AddStudent(sv);

            // 3. Hiển thị kết quả
            MessageBox.Show(result);

            // 4. Nếu thành công thì tải lại bảng
            if (result.Contains("thành công"))
            {
                LoadData();
                ClearInput();
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudent.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // Lấy ID từ dòng đang chọn
                    int id = Convert.ToInt32(dgvStudent.CurrentRow.Cells["Id"].Value);
                    string result = bll.DeleteStudent(id);
                    MessageBox.Show(result);
                    LoadData();
                    ClearInput();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng để xóa.");
            }
        }

        // Hàm xử lý sự kiện nút Sửa (Đã thêm mới)
        // 3. Cập nhật nút Sửa (btEdit_Click)
        private void btEdit_Click(object sender, EventArgs e)
        {
            if (dgvStudent.SelectedRows.Count > 0)
            {
                // Đóng gói dữ liệu
                StudentDTO sv = new StudentDTO();
                // Lấy ID ẩn (đây là chìa khóa để biết đang sửa ai)
                sv.Id = Convert.ToInt32(dgvStudent.CurrentRow.Cells["Id"].Value);

                // MSSV lấy từ ô nhập (dù bị khóa nhưng text vẫn còn)
                // Tuy nhiên DAL sẽ bỏ qua trường này nên giá trị ở đây không ảnh hưởng DB
                sv.MSSV = tbMSSV.Text;

                sv.Name = tbName.Text;
                sv.Class = tbClass.Text;
                sv.Gender = cbGender.Text;
                sv.Dob = dtpDob.Value;
                sv.Hometown = tbHometown.Text;
                sv.Phone = tbPhone.Text;

                // Gọi hàm BLL
                string result = bll.UpdateStudent(sv);
                MessageBox.Show(result);

                // Nếu thành công thì tải lại bảng và xóa trắng (để mở lại ô MSSV)
                if (result.Contains("thành công"))
                {
                    LoadData();
                    ClearInput();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng để sửa.");
            }
        }
        // Hàm xử lý sự kiện nút Thoát (Đã thêm mới)
        private void btExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thoát", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Hàm xử lý khi click vào dòng trong bảng -> Đổ dữ liệu lên ô nhập (Đã thêm mới)
        // 2. Cập nhật sự kiện CellClick (Để khóa ô MSSV khi chọn dòng)
        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudent.Rows[e.RowIndex];
                tbMSSV.Text = row.Cells["MSSV"].Value != null ? row.Cells["MSSV"].Value.ToString() : "";
                tbName.Text = row.Cells["Name"].Value != null ? row.Cells["Name"].Value.ToString() : "";
                tbClass.Text = row.Cells["Class"].Value != null ? row.Cells["Class"].Value.ToString() : "";
                cbGender.Text = row.Cells["Gender"].Value != null ? row.Cells["Gender"].Value.ToString() : "";

                if (row.Cells["Dob"].Value != null && row.Cells["Dob"].Value != DBNull.Value)
                    dtpDob.Value = Convert.ToDateTime(row.Cells["Dob"].Value);

                tbHometown.Text = row.Cells["Hometown"].Value != null ? row.Cells["Hometown"].Value.ToString() : "";
                tbPhone.Text = row.Cells["Phone"].Value != null ? row.Cells["Phone"].Value.ToString() : "";

                // QUAN TRỌNG: Khóa ô MSSV để người dùng biết là không được sửa
                tbMSSV.Enabled = false;
            }
        }
        private void btExportExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Lấy DataTable từ BLL 
                        System.Data.DataTable dt = bll.GetStudentList();

                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.Worksheets.Add(dt, "DanhSachSinhVien");
                            workbook.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("Xuất Excel thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }
    }
}