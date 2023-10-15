namespace GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblQuanLySV = new System.Windows.Forms.Label();
            this.txtMasv = new System.Windows.Forms.TextBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblDiemTb = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.lblhoten = new System.Windows.Forms.Label();
            this.llbMaSv = new System.Windows.Forms.Label();
            this.lblthongtinsv = new System.Windows.Forms.Label();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.colMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColChuyenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAnh = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(891, 422);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 58;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblQuanLySV
            // 
            this.lblQuanLySV.AutoSize = true;
            this.lblQuanLySV.Location = new System.Drawing.Point(305, 25);
            this.lblQuanLySV.Name = "lblQuanLySV";
            this.lblQuanLySV.Size = new System.Drawing.Size(211, 16);
            this.lblQuanLySV.TabIndex = 57;
            this.lblQuanLySV.Text = "QUẢN LÝ THÔNG TIN SINH VIÊN";
            // 
            // txtMasv
            // 
            this.txtMasv.Location = new System.Drawing.Point(150, 102);
            this.txtMasv.Name = "txtMasv";
            this.txtMasv.Size = new System.Drawing.Size(169, 22);
            this.txtMasv.TabIndex = 56;
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(150, 139);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(169, 22);
            this.txtHoten.TabIndex = 55;
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(150, 176);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(169, 24);
            this.cmbKhoa.TabIndex = 54;
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(150, 217);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(169, 22);
            this.txtDiem.TabIndex = 53;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(260, 382);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 52;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(140, 382);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 51;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(29, 382);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 50;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblDiemTb
            // 
            this.lblDiemTb.AutoSize = true;
            this.lblDiemTb.Location = new System.Drawing.Point(23, 217);
            this.lblDiemTb.Name = "lblDiemTb";
            this.lblDiemTb.Size = new System.Drawing.Size(59, 16);
            this.lblDiemTb.TabIndex = 49;
            this.lblDiemTb.Text = "Điểm TB";
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(23, 184);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(38, 16);
            this.lblKhoa.TabIndex = 48;
            this.lblKhoa.Text = "Khoa";
            // 
            // lblhoten
            // 
            this.lblhoten.AutoSize = true;
            this.lblhoten.Location = new System.Drawing.Point(23, 145);
            this.lblhoten.Name = "lblhoten";
            this.lblhoten.Size = new System.Drawing.Size(52, 16);
            this.lblhoten.TabIndex = 47;
            this.lblhoten.Text = "Họ Tên";
            // 
            // llbMaSv
            // 
            this.llbMaSv.AutoSize = true;
            this.llbMaSv.Location = new System.Drawing.Point(23, 105);
            this.llbMaSv.Name = "llbMaSv";
            this.llbMaSv.Size = new System.Drawing.Size(65, 16);
            this.llbMaSv.TabIndex = 46;
            this.llbMaSv.Text = "Mã số SV";
            // 
            // lblthongtinsv
            // 
            this.lblthongtinsv.AutoSize = true;
            this.lblthongtinsv.Location = new System.Drawing.Point(12, 62);
            this.lblthongtinsv.Name = "lblthongtinsv";
            this.lblthongtinsv.Size = new System.Drawing.Size(119, 16);
            this.lblthongtinsv.TabIndex = 45;
            this.lblthongtinsv.Text = "Thông tin Sinh viên";
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMSSV,
            this.colHoten,
            this.colTenKhoa,
            this.colDiemTB,
            this.ColChuyenNganh});
            this.dgvSinhVien.Location = new System.Drawing.Point(361, 62);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.RowHeadersWidth = 51;
            this.dgvSinhVien.RowTemplate.Height = 24;
            this.dgvSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSinhVien.Size = new System.Drawing.Size(669, 343);
            this.dgvSinhVien.TabIndex = 44;
            this.dgvSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellClick);
            // 
            // colMSSV
            // 
            this.colMSSV.DataPropertyName = "StudentId";
            this.colMSSV.HeaderText = "Mã sinh viên";
            this.colMSSV.MinimumWidth = 6;
            this.colMSSV.Name = "colMSSV";
            this.colMSSV.Width = 125;
            // 
            // colHoten
            // 
            this.colHoten.DataPropertyName = "TENSV";
            this.colHoten.HeaderText = "Họ Tên";
            this.colHoten.MinimumWidth = 6;
            this.colHoten.Name = "colHoten";
            this.colHoten.Width = 125;
            // 
            // colTenKhoa
            // 
            this.colTenKhoa.DataPropertyName = "TENKHOA";
            this.colTenKhoa.HeaderText = "Tên Khoa";
            this.colTenKhoa.MinimumWidth = 6;
            this.colTenKhoa.Name = "colTenKhoa";
            this.colTenKhoa.Width = 125;
            // 
            // colDiemTB
            // 
            this.colDiemTB.DataPropertyName = "DTB";
            this.colDiemTB.HeaderText = "Điểm TB";
            this.colDiemTB.MinimumWidth = 6;
            this.colDiemTB.Name = "colDiemTB";
            this.colDiemTB.Width = 125;
            // 
            // ColChuyenNganh
            // 
            this.ColChuyenNganh.HeaderText = "Chuyên Ngành";
            this.ColChuyenNganh.MinimumWidth = 6;
            this.ColChuyenNganh.Name = "ColChuyenNganh";
            this.ColChuyenNganh.Width = 125;
            // 
            // lblAnh
            // 
            this.lblAnh.AutoSize = true;
            this.lblAnh.Location = new System.Drawing.Point(12, 287);
            this.lblAnh.Name = "lblAnh";
            this.lblAnh.Size = new System.Drawing.Size(81, 16);
            this.lblAnh.TabIndex = 59;
            this.lblAnh.Text = "Ảnh đại diện";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(150, 256);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(317, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 23);
            this.button1.TabIndex = 61;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 516);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAnh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblQuanLySV);
            this.Controls.Add(this.txtMasv);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.cmbKhoa);
            this.Controls.Add(this.txtDiem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblDiemTb);
            this.Controls.Add(this.lblKhoa);
            this.Controls.Add(this.lblhoten);
            this.Controls.Add(this.llbMaSv);
            this.Controls.Add(this.lblthongtinsv);
            this.Controls.Add(this.dgvSinhVien);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblQuanLySV;
        private System.Windows.Forms.TextBox txtMasv;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblDiemTb;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.Label lblhoten;
        private System.Windows.Forms.Label llbMaSv;
        private System.Windows.Forms.Label lblthongtinsv;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.Label lblAnh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColChuyenNganh;
    }
}

