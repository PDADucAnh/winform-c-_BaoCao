using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // Chuỗi kết nối (Connection String) - Nên lưu trong App.config để bảo mật và dễ thay đổi
        string connectionString = "Data Source=.;Initial Catalog=sale;Trusted_Connection=True";
        SqlConnection conn;
        SqlDataAdapter adapter;
        DataTable dt;

        public Form1()
        {
            InitializeComponent();
        }

        // Hàm tải dữ liệu lên DataGridView
        private void LoadData()
        {
            try
            {
                using (conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Student";
                    adapter = new SqlDataAdapter(query, conn);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dgvStudent.DataSource = dt; // Đổi tên dgvCustomer -> dgvStudent cho phù hợp
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // Hàm kiểm tra tính hợp lệ của dữ liệu đầu vào (Validation)
        private bool ValidateInput()
        {
            // Kiểm tra MSSV
            if (string.IsNullOrWhiteSpace(tbMSSV.Text) || tbMSSV.Text.Length != 10 || !long.TryParse(tbMSSV.Text, out _))
            {
                MessageBox.Show("MSSV phải là chuỗi số 10 chữ số.");
                return false;
            }

            // Kiểm tra Tên
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sinh viên.");
                return false;
            }

            // Kiểm tra SĐT
            if (!string.IsNullOrWhiteSpace(tbPhone.Text) && (tbPhone.Text.Length != 10 || !long.TryParse(tbPhone.Text, out _)))
            {
                MessageBox.Show("Số điện thoại phải là chuỗi số 10 chữ số.");
                return false;
            }

            return true;
        }


        private void btNew_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                using (conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Student (MSSV, Name, Class, Gender, Dob, Hometown, Phone) VALUES (@MSSV, @Name, @Class, @Gender, @Dob, @Hometown, @Phone)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Sử dụng Parameters để tránh lỗi SQL Injection
                        cmd.Parameters.AddWithValue("@MSSV", tbMSSV.Text);
                        cmd.Parameters.AddWithValue("@Name", tbName.Text);
                        cmd.Parameters.AddWithValue("@Class", tbClass.Text);
                        cmd.Parameters.AddWithValue("@Gender", cbGender.Text); // ComboBox cho giới tính
                        cmd.Parameters.AddWithValue("@Dob", dtpDob.Value);     // DateTimePicker cho ngày sinh
                        cmd.Parameters.AddWithValue("@Hometown", tbHometown.Text);
                        cmd.Parameters.AddWithValue("@Phone", tbPhone.Text);

                        cmd.ExecuteNonQuery();
                    }
                }
                LoadData(); // Tải lại dữ liệu sau khi thêm
                ClearInput();
                MessageBox.Show("Thêm thành công!");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // Lỗi trùng khóa (MSSV trùng)
                    MessageBox.Show("MSSV đã tồn tại.");
                else
                    MessageBox.Show("Lỗi thêm: " + ex.Message);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudent.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng để xóa.");
                return;
            }

            // Lấy ID (khóa chính) của dòng đang chọn
            int idToDelete = Convert.ToInt32(dgvStudent.CurrentRow.Cells["Id"].Value);

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM Student WHERE Id = @Id";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Id", idToDelete);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    LoadData();
                    ClearInput();
                    MessageBox.Show("Xóa thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa: " + ex.Message);
                }
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (dgvStudent.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng để sửa.");
                return;
            }

            if (!ValidateInput()) return;

            int idToEdit = Convert.ToInt32(dgvStudent.CurrentRow.Cells["Id"].Value);

            try
            {
                using (conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Student SET MSSV=@MSSV, Name=@Name, Class=@Class, Gender=@Gender, Dob=@Dob, Hometown=@Hometown, Phone=@Phone WHERE Id=@Id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", idToEdit);
                        cmd.Parameters.AddWithValue("@MSSV", tbMSSV.Text);
                        cmd.Parameters.AddWithValue("@Name", tbName.Text);
                        cmd.Parameters.AddWithValue("@Class", tbClass.Text);
                        cmd.Parameters.AddWithValue("@Gender", cbGender.Text);
                        cmd.Parameters.AddWithValue("@Dob", dtpDob.Value);
                        cmd.Parameters.AddWithValue("@Hometown", tbHometown.Text);
                        cmd.Parameters.AddWithValue("@Phone", tbPhone.Text);

                        cmd.ExecuteNonQuery();
                    }
                }
                LoadData();
                MessageBox.Show("Cập nhật thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa: " + ex.Message);
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thoát", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Sự kiện khi click vào một dòng trên Grid -> Hiển thị thông tin lên các TextBox
        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudent.Rows[e.RowIndex];
                tbMSSV.Text = row.Cells["MSSV"].Value.ToString();
                tbName.Text = row.Cells["Name"].Value.ToString();
                tbClass.Text = row.Cells["Class"].Value.ToString();
                cbGender.Text = row.Cells["Gender"].Value.ToString();

                if (row.Cells["Dob"].Value != DBNull.Value)
                    dtpDob.Value = Convert.ToDateTime(row.Cells["Dob"].Value);

                tbHometown.Text = row.Cells["Hometown"].Value.ToString();
                tbPhone.Text = row.Cells["Phone"].Value.ToString();
            }
        }

        // Hàm xóa trắng các ô nhập liệu
        private void ClearInput()
        {
            tbMSSV.Clear();
            tbName.Clear();
            tbClass.Clear();
            tbHometown.Clear();
            tbPhone.Clear();
            cbGender.SelectedIndex = -1;
            dtpDob.Value = DateTime.Now;
        }

        // Ràng buộc chỉ nhập số cho MSSV và Phone ngay khi gõ phím
        private void tbNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự không phải số
            }
        }
    }
}