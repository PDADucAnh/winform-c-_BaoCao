using System;
using System.Windows.Forms;
using WindowsFormsApp1.BLL;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.GUI.ManagementForms
{
    public partial class frmGrade : Form
    {
        GradeBLL gradeBLL = new GradeBLL();
        StudentBLL studentBLL = new StudentBLL();
        SubjectBLL subjectBLL = new SubjectBLL();

        public frmGrade()
        {
            InitializeComponent();
        }

        private void frmGrade_Load(object sender, EventArgs e)
        {
            LoadInitData();
        }

        void LoadInitData()
        {
            // 1. Load danh sách Sinh viên vào ComboBox
            cbStudent.DataSource = studentBLL.GetStudentList();
            cbStudent.DisplayMember = "Name"; // Nên nối chuỗi MSSV + Name trong DTO hoặc SQL để dễ nhìn
            cbStudent.ValueMember = "Id"; // Dùng StudentID

            // 2. Load danh sách Môn học vào ComboBox
            cbSubject.DataSource = subjectBLL.GetList();
            cbSubject.DisplayMember = "SubjectName";
            cbSubject.ValueMember = "SubjectID";

            // 3. Load Grid
            LoadGrid();
        }

        void LoadGrid()
        {
            dgvGrade.DataSource = gradeBLL.GetList();
            FormatGrid();
        }

        void FormatGrid()
        {
            if (dgvGrade.Columns.Contains("StudentName")) dgvGrade.Columns["StudentName"].HeaderText = "Tên Sinh Viên";
            if (dgvGrade.Columns.Contains("MSSV")) dgvGrade.Columns["MSSV"].HeaderText = "Mã SV";
            if (dgvGrade.Columns.Contains("SubjectName")) dgvGrade.Columns["SubjectName"].HeaderText = "Môn Học";
            if (dgvGrade.Columns.Contains("Score")) dgvGrade.Columns["Score"].HeaderText = "Điểm Số";

            // Ẩn các cột ID
            if (dgvGrade.Columns.Contains("StudentID")) dgvGrade.Columns["StudentID"].Visible = false;
            if (dgvGrade.Columns.Contains("SubjectID")) dgvGrade.Columns["SubjectID"].Visible = false;
        }

        // --- CÁC SỰ KIỆN NÚT BẤM ---

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbStudent.SelectedValue == null || cbSubject.SelectedValue == null || string.IsNullOrEmpty(txtScore.Text))
                {
                    MessageBox.Show("Vui lòng chọn đủ thông tin và nhập điểm!");
                    return;
                }

                GradeDTO gr = new GradeDTO();
                gr.StudentID = (int)cbStudent.SelectedValue;
                gr.SubjectID = (int)cbSubject.SelectedValue;

                if (!double.TryParse(txtScore.Text, out double score))
                {
                    MessageBox.Show("Điểm phải là số!");
                    return;
                }
                gr.Score = score;

                // Gọi BLL để lưu (Hàm SaveGrade trong BLL đã xử lý logic Insert hoặc Update)
                string result = gradeBLL.SaveGrade(gr);
                MessageBox.Show(result);

                if (result.Contains("thành công"))
                {
                    LoadGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvGrade.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn muốn xóa điểm môn này của sinh viên?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int stdID = Convert.ToInt32(dgvGrade.CurrentRow.Cells["StudentID"].Value);
                    int subID = Convert.ToInt32(dgvGrade.CurrentRow.Cells["SubjectID"].Value);

                    string result = gradeBLL.DeleteGrade(stdID, subID);
                    MessageBox.Show(result);

                    if (result.Contains("thành công")) LoadGrid();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng điểm cần xóa.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // --- SỰ KIỆN TIỆN ÍCH ---

        // Khi click vào Grid thì hiển thị ngược lại lên ComboBox
        private void dgvGrade_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvGrade.Rows[e.RowIndex];

                if (row.Cells["StudentID"].Value != DBNull.Value)
                    cbStudent.SelectedValue = row.Cells["StudentID"].Value;

                if (row.Cells["SubjectID"].Value != DBNull.Value)
                    cbSubject.SelectedValue = row.Cells["SubjectID"].Value;

                txtScore.Text = row.Cells["Score"].Value.ToString();
            }
        }

        // Chỉ cho nhập số và dấu chấm thập phân
        private void txtScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // Chỉ cho phép 1 dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        // Tính xếp loại ngay khi nhập
        private void txtScore_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtScore.Text, out double s))
            {
                lblRank.Text = gradeBLL.GetRank(s); // Hàm GetRank đã viết trong GradeBLL
            }
            else
            {
                lblRank.Text = "...";
            }
        }
    }
}