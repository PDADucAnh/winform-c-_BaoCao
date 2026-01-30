using System;
using System.Windows.Forms;
using WindowsFormsApp1.BLL;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.GUI.ManagementForms
{
    public partial class frmClass : Form
    {
        // Khởi tạo các tầng nghiệp vụ
        ClassBLL classBLL = new ClassBLL();
        MajorBLL majorBLL = new MajorBLL();

        public frmClass()
        {
            InitializeComponent();
        }

        private void frmClass_Load(object sender, EventArgs e)
        {
            LoadComboMajor();
            LoadData();
        }

        // 1. Load danh sách Ngành vào ComboBox
        void LoadComboMajor()
        {
            cbMajor.DataSource = majorBLL.GetList();
            cbMajor.DisplayMember = "MajorName";
            cbMajor.ValueMember = "MajorID";
            cbMajor.SelectedIndex = -1;
        }

        // 2. Load danh sách Lớp vào Grid
        void LoadData()
        {
            dgvClass.DataSource = classBLL.GetList();
            FormatGrid();
        }

        void FormatGrid()
        {
            if (dgvClass.Columns.Contains("ClassID")) dgvClass.Columns["ClassID"].HeaderText = "Mã Lớp";
            if (dgvClass.Columns.Contains("ClassName")) dgvClass.Columns["ClassName"].HeaderText = "Tên Lớp";
            if (dgvClass.Columns.Contains("MajorName")) dgvClass.Columns["MajorName"].HeaderText = "Thuộc Ngành";

            // Ẩn cột ID kỹ thuật
            if (dgvClass.Columns.Contains("MajorID")) dgvClass.Columns["MajorID"].Visible = false;
        }

        void ClearInput()
        {
            txtID.Clear();
            txtName.Clear();
            cbMajor.SelectedIndex = -1;
        }

        // --- CÁC NÚT CHỨC NĂNG ---

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbMajor.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Ngành học cho lớp!");
                return;
            }

            ClassDTO cl = new ClassDTO();
            cl.ClassName = txtName.Text;
            cl.MajorID = (int)cbMajor.SelectedValue;

            string res = classBLL.AddClass(cl);
            MessageBox.Show(res);

            if (res.Contains("thành công"))
            {
                LoadData();
                ClearInput();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvClass.SelectedRows.Count > 0)
            {
                if (cbMajor.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn Ngành học!");
                    return;
                }

                ClassDTO cl = new ClassDTO();
                cl.ClassID = Convert.ToInt32(txtID.Text);
                cl.ClassName = txtName.Text;
                cl.MajorID = (int)cbMajor.SelectedValue;

                string res = classBLL.UpdateClass(cl);
                MessageBox.Show(res);

                if (res.Contains("thành công"))
                {
                    LoadData();
                    ClearInput();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lớp cần sửa.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvClass.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa lớp này?\nLưu ý: Các sinh viên thuộc lớp này sẽ bị mất thông tin lớp.", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(txtID.Text);
                    string res = classBLL.DeleteClass(id);
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
                MessageBox.Show("Vui lòng chọn lớp cần xóa.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // --- SỰ KIỆN GRID VIEW ---

        private void dgvClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvClass.Rows[e.RowIndex];
                txtID.Text = row.Cells["ClassID"].Value.ToString();
                txtName.Text = row.Cells["ClassName"].Value.ToString();

                // Tự động chọn Ngành tương ứng
                if (row.Cells["MajorID"].Value != DBNull.Value)
                {
                    cbMajor.SelectedValue = row.Cells["MajorID"].Value;
                }
                else
                {
                    cbMajor.SelectedIndex = -1;
                }
            }
        }
    }
}