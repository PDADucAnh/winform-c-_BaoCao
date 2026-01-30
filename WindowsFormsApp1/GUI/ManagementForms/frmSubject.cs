using System;
using System.Windows.Forms;
using WindowsFormsApp1.BLL;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.GUI.ManagementForms
{
    public partial class frmSubject : Form
    {
        SubjectBLL subjectBLL = new SubjectBLL();

        public frmSubject()
        {
            InitializeComponent();
        }

        private void frmSubject_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            dgvSubject.DataSource = subjectBLL.GetList();
            FormatGrid();
        }

        void FormatGrid()
        {
            if (dgvSubject.Columns.Contains("SubjectID")) dgvSubject.Columns["SubjectID"].HeaderText = "Mã Môn";
            if (dgvSubject.Columns.Contains("SubjectName")) dgvSubject.Columns["SubjectName"].HeaderText = "Tên Môn Học";
            if (dgvSubject.Columns.Contains("Credits")) dgvSubject.Columns["Credits"].HeaderText = "Số Tín Chỉ";
        }

        void ClearInput()
        {
            txtID.Clear();
            txtName.Clear();
            numCredits.Value = 3; // Mặc định 3 tín chỉ
        }

        // --- CÁC NÚT CHỨC NĂNG ---

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SubjectDTO sub = new SubjectDTO();
            sub.SubjectName = txtName.Text;
            sub.Credits = (int)numCredits.Value;

            string res = subjectBLL.AddSubject(sub);
            MessageBox.Show(res);

            if (res.Contains("thành công"))
            {
                LoadData();
                ClearInput();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvSubject.SelectedRows.Count > 0)
            {
                SubjectDTO sub = new SubjectDTO();
                sub.SubjectID = Convert.ToInt32(txtID.Text);
                sub.SubjectName = txtName.Text;
                sub.Credits = (int)numCredits.Value;

                string res = subjectBLL.UpdateSubject(sub);
                MessageBox.Show(res);

                if (res.Contains("thành công"))
                {
                    LoadData();
                    ClearInput();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn môn học cần sửa.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSubject.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa môn học này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(txtID.Text);
                    string res = subjectBLL.DeleteSubject(id);
                    MessageBox.Show(res);

                    if (res.Contains("thành công"))
                    {
                        LoadData();
                        ClearInput();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn môn học cần xóa.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // --- SỰ KIỆN GRID VIEW ---

        private void dgvSubject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSubject.Rows[e.RowIndex];
                txtID.Text = row.Cells["SubjectID"].Value.ToString();
                txtName.Text = row.Cells["SubjectName"].Value.ToString();
                numCredits.Value = Convert.ToDecimal(row.Cells["Credits"].Value);
            }
        }
    }
}