using BUS;
using DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        private SinhVienBLL sinhVienBLL;
        private KhoaBLL khoaBLL;
        private string imagePath;
        public Form1()
        {
            InitializeComponent();
            sinhVienBLL = new SinhVienBLL();
            khoaBLL = new KhoaBLL();


        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog.FileName;
                pictureBox1.Image = Image.FromFile(imagePath);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMasv.Text == "" || txtHoten.Text == "" || txtDiem.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                if (txtMasv.Text == "" || txtHoten.Text == "" || txtDiem.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (imagePath == null)
                {
                    MessageBox.Show("Vui lòng tải ảnh trước khi thêm sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string fileName = txtMasv.Text + Path.GetExtension(imagePath);
                    string imagePathInFolder = Path.Combine(@"D:\Winform\BaLop\GUI\Images", fileName);

                    student sv = new student();
                    sv.StudentId = Convert.ToInt32(txtMasv.Text);
                    sv.FullName = txtHoten.Text;
                    sv.FacultyId = Convert.ToInt32(cmbKhoa.SelectedValue.ToString());
                    sv.AverageScore = float.Parse(txtDiem.Text);
                    sv.MajorlId = Convert.ToInt32(cmbKhoa.SelectedValue.ToString());
                    sv.Avatar = imagePathInFolder;

                    sinhVienBLL.AddSinhVien(sv);

                    File.Copy(imagePath, imagePathInFolder);

                    BindGrid(sinhVienBLL.GetAllSinhVien());
                    MessageBox.Show("Thêm sinh viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        

        private void btnSua_Click(object sender, EventArgs e)
        {
            int mssv = Convert.ToInt32(txtMasv.Text);
            student sv = sinhVienBLL.GetSinhVienByMSSV(mssv);

            if (sv != null)
            {
                string fileName = txtMasv.Text + Path.GetExtension(imagePath);
                string imagePathInFolder = Path.Combine(@"D:\Winform\BaLop\GUI\Images", fileName);
                sv.FullName = txtHoten.Text;
                sv.FacultyId = Convert.ToInt32(cmbKhoa.SelectedValue.ToString());
                sv.AverageScore = float.Parse(txtDiem.Text);
                sv.Avatar = imagePathInFolder;

                sinhVienBLL.UpdateSinhVien(sv);
                File.Copy(imagePath, imagePathInFolder);
                BindGrid(sinhVienBLL.GetAllSinhVien());

                MessageBox.Show("Sửa sinh viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }


        }



        private void btnXoa_Click(object sender, EventArgs e)
        {
            int mssv = Convert.ToInt32(txtMasv.Text);
            student sv = sinhVienBLL.GetSinhVienByMSSV(mssv);

            if (sv != null)
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn xóa sinh viên này.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    sinhVienBLL.DeleteSinhVien(sv);

                    BindGrid(sinhVienBLL.GetAllSinhVien());
                    txtHoten.Clear();
                    txtMasv.Clear();
                    txtDiem.Clear();
                    txtMasv.Clear();
                    pictureBox1.Image = null;
                    MessageBox.Show("Xóa sinh viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Mã sinh viên này không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HienThiKhoa()
        {
            List<Faculty> listKhoa = khoaBLL.GetAllKhoa();

            cmbKhoa.DataSource = listKhoa;
            cmbKhoa.DisplayMember = "FacultyName";
            cmbKhoa.ValueMember = "FacultyId";
        }

        private void BindGrid(List<student> listSV)
        {
            dgvSinhVien.Rows.Clear();

            foreach (student item in listSV)
            {
                int index = dgvSinhVien.Rows.Add();
                dgvSinhVien.Rows[index].Cells[0].Value = item.StudentId;
                dgvSinhVien.Rows[index].Cells[1].Value = item.FullName;
                dgvSinhVien.Rows[index].Cells[2].Value = item.Faculty.FacultyName;
                dgvSinhVien.Rows[index].Cells[3].Value = item.AverageScore;
                if (item.Major != null)
                {
                    dgvSinhVien.Rows[index].Cells[4].Value = item.Major.MajorName + "";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiKhoa();
            BindGrid(sinhVienBLL.GetAllSinhVien());
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < dgvSinhVien.Rows.Count)
            {
                DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];
                txtMasv.Text = row.Cells[0].Value?.ToString();
                txtHoten.Text = row.Cells[1].Value?.ToString();
                cmbKhoa.Text = row.Cells[2].Value?.ToString();
                txtDiem.Text = row.Cells[3].Value?.ToString();

                if (int.TryParse(row.Cells[0].Value?.ToString(), out int studentId))
                {
                    student student = sinhVienBLL.GetSinhVienByMSSV(studentId);

                    if (student != null)
                    {
                        if (!string.IsNullOrEmpty(student.Avatar))
                        {
                            try
                            {
                                pictureBox1.Image = Image.FromFile(student.Avatar);
                            }
                            catch (Exception ex)
                            {
                                pictureBox1.Image = null;
                                MessageBox.Show("Không thể tải hình ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            pictureBox1.Image = null;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Mã số sinh viên không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }


}



