using System;
using System.Windows.Forms;
using WindowsFormsApp1.BLL;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.GUI.ManagementForms
{
    public partial class frmFaculty : Form
    {
        // Khởi tạo các BLL cần thiết
        FacultyBLL facBLL = new FacultyBLL();
        MajorBLL majorBLL = new MajorBLL();

        public frmFaculty()
        {
            InitializeComponent();
        }

        private void frmFaculty_Load(object sender, EventArgs e)
        {
            LoadDataFaculty();
            LoadDataMajor();
            LoadComboFaculty(); // Load danh sách khoa vào ComboBox bên phần Ngành
        }

        // =======================================================
        // PHẦN 1: XỬ LÝ KHOA (FACULTY)
        // =======================================================
        void LoadDataFaculty()
        {
            dgvFaculty.DataSource = facBLL.GetList();
            if (dgvFaculty.Columns.Contains("FacultyName")) dgvFaculty.Columns["FacultyName"].HeaderText = "Tên Khoa";
            if (dgvFaculty.Columns.Contains("FacultyID")) dgvFaculty.Columns["FacultyID"].HeaderText = "Mã";
        }

        // Khi thêm/sửa/xóa Khoa -> Cần reload lại ComboBox bên Ngành
        void ReloadAll()
        {
            LoadDataFaculty();
            LoadComboFaculty();
        }

        private void btnAddFaculty_Click(object sender, EventArgs e)
        {
            FacultyDTO fa = new FacultyDTO() { FacultyName = txtFacName.Text };
            string res = facBLL.AddFaculty(fa);
            MessageBox.Show(res);
            if (res.Contains("thành công"))
            {
                ReloadAll();
                txtFacName.Clear();
            }
        }

        private void btnEditFaculty_Click(object sender, EventArgs e)
        {
            if (dgvFaculty.SelectedRows.Count > 0)
            {
                FacultyDTO fa = new FacultyDTO();
                fa.FacultyID = Convert.ToInt32(txtFacID.Text);
                fa.FacultyName = txtFacName.Text;

                string res = facBLL.UpdateFaculty(fa);
                MessageBox.Show(res);
                if (res.Contains("thành công")) ReloadAll();
            }
        }

        private void btnDelFaculty_Click(object sender, EventArgs e)
        {
            if (dgvFaculty.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Xóa Khoa sẽ xóa luôn các Ngành thuộc Khoa đó. Tiếp tục?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(txtFacID.Text);
                    string res = facBLL.DeleteFaculty(id);
                    MessageBox.Show(res);
                    if (res.Contains("thành công"))
                    {
                        ReloadAll();
                        LoadDataMajor(); // Reload cả bảng ngành vì có thể ngành bị xóa theo cascade
                    }
                }
            }
        }

        private void dgvFaculty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtFacID.Text = dgvFaculty.Rows[e.RowIndex].Cells["FacultyID"].Value.ToString();
                txtFacName.Text = dgvFaculty.Rows[e.RowIndex].Cells["FacultyName"].Value.ToString();
            }
        }

        // =======================================================
        // PHẦN 2: XỬ LÝ NGÀNH (MAJOR)
        // =======================================================
        void LoadDataMajor()
        {
            dgvMajor.DataSource = majorBLL.GetList();
            // Format cột
            if (dgvMajor.Columns.Contains("MajorName")) dgvMajor.Columns["MajorName"].HeaderText = "Tên Ngành";
            if (dgvMajor.Columns.Contains("FacultyName")) dgvMajor.Columns["FacultyName"].HeaderText = "Thuộc Khoa";
            // Ẩn các ID
            if (dgvMajor.Columns.Contains("MajorID")) dgvMajor.Columns["MajorID"].Visible = false;
            if (dgvMajor.Columns.Contains("FacultyID")) dgvMajor.Columns["FacultyID"].Visible = false;
        }

        void LoadComboFaculty()
        {
            cbFaculty.DataSource = facBLL.GetList();
            cbFaculty.DisplayMember = "FacultyName";
            cbFaculty.ValueMember = "FacultyID";
        }

        private void btnAddMajor_Click(object sender, EventArgs e)
        {
            MajorDTO mj = new MajorDTO();
            mj.MajorName = txtMajorName.Text;
            if (cbFaculty.SelectedValue != null)
                mj.FacultyID = (int)cbFaculty.SelectedValue;

            string res = majorBLL.AddMajor(mj);
            MessageBox.Show(res);
            if (res.Contains("thành công"))
            {
                LoadDataMajor();
                txtMajorName.Clear();
            }
        }

        private void btnEditMajor_Click(object sender, EventArgs e)
        {
            if (dgvMajor.SelectedRows.Count > 0)
            {
                MajorDTO mj = new MajorDTO();
                mj.MajorID = Convert.ToInt32(txtMajorID.Text);
                mj.MajorName = txtMajorName.Text;
                if (cbFaculty.SelectedValue != null)
                    mj.FacultyID = (int)cbFaculty.SelectedValue;

                string res = majorBLL.UpdateMajor(mj);
                MessageBox.Show(res);
                if (res.Contains("thành công")) LoadDataMajor();
            }
        }

        private void btnDelMajor_Click(object sender, EventArgs e)
        {
            if (dgvMajor.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn muốn xóa ngành này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(txtMajorID.Text);
                    string res = majorBLL.DeleteMajor(id);
                    MessageBox.Show(res);
                    if (res.Contains("thành công")) LoadDataMajor();
                }
            }
        }

        private void dgvMajor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMajor.Rows[e.RowIndex];
                txtMajorID.Text = row.Cells["MajorID"].Value.ToString();
                txtMajorName.Text = row.Cells["MajorName"].Value.ToString();

                // Tự động chọn Khoa tương ứng trên ComboBox
                if (row.Cells["FacultyID"].Value != DBNull.Value)
                {
                    cbFaculty.SelectedValue = row.Cells["FacultyID"].Value;
                }
            }
        }
    }
}