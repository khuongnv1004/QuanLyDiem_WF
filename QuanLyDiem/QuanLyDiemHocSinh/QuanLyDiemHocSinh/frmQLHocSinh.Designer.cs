 
namespace QuanLyDiemHocSinh
{
    partial class frmQLHocSinh
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
            this.lblQuanLyHocSinh = new System.Windows.Forms.Label();
            this.txtMaHS = new System.Windows.Forms.TextBox();
            this.lblMaHS = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDanToc = new System.Windows.Forms.Label();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.dataDanhSachHS = new System.Windows.Forms.DataGridView();
            this.dateNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.cboMaDantoc = new System.Windows.Forms.ComboBox();
            this.cboMaTongiao = new System.Windows.Forms.ComboBox();
            this.lblMaTongiao = new System.Windows.Forms.Label();
            this.lblHotenCha = new System.Windows.Forms.Label();
            this.txtTencha = new System.Windows.Forms.TextBox();
            this.lblHotenMe = new System.Windows.Forms.Label();
            this.txtTenMe = new System.Windows.Forms.TextBox();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnTaomoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataDanhSachHS)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuanLyHocSinh
            // 
            this.lblQuanLyHocSinh.AutoSize = true;
            this.lblQuanLyHocSinh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQuanLyHocSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLyHocSinh.Location = new System.Drawing.Point(312, 19);
            this.lblQuanLyHocSinh.Name = "lblQuanLyHocSinh";
            this.lblQuanLyHocSinh.Size = new System.Drawing.Size(465, 33);
            this.lblQuanLyHocSinh.TabIndex = 0;
            this.lblQuanLyHocSinh.Text = "---------Danh Sách Học Sinh---------";
            // 
            // txtMaHS
            // 
            this.txtMaHS.Location = new System.Drawing.Point(118, 103);
            this.txtMaHS.Name = "txtMaHS";
            this.txtMaHS.Size = new System.Drawing.Size(152, 20);
            this.txtMaHS.TabIndex = 1;
            // 
            // lblMaHS
            // 
            this.lblMaHS.AutoSize = true;
            this.lblMaHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHS.Location = new System.Drawing.Point(26, 106);
            this.lblMaHS.Name = "lblMaHS";
            this.lblMaHS.Size = new System.Drawing.Size(88, 13);
            this.lblMaHS.TabIndex = 2;
            this.lblMaHS.Text = "Mã Học Sinh :";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(26, 146);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(57, 13);
            this.lblHoTen.TabIndex = 4;
            this.lblHoTen.Text = "Họ Tên :";
            this.lblHoTen.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(118, 146);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(152, 20);
            this.txtHoTen.TabIndex = 3;
            this.txtHoTen.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Location = new System.Drawing.Point(26, 188);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(68, 13);
            this.lblGioiTinh.TabIndex = 6;
            this.lblGioiTinh.Text = "Giới Tính :";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Location = new System.Drawing.Point(26, 231);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(73, 13);
            this.lblNgaySinh.TabIndex = 8;
            this.lblNgaySinh.Text = "Ngày Sinh :";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(26, 269);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(56, 13);
            this.lblDiaChi.TabIndex = 10;
            this.lblDiaChi.Text = "Địa Chỉ :";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(118, 269);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(152, 20);
            this.txtDiaChi.TabIndex = 9;
            // 
            // lblDanToc
            // 
            this.lblDanToc.AutoSize = true;
            this.lblDanToc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanToc.Location = new System.Drawing.Point(26, 310);
            this.lblDanToc.Name = "lblDanToc";
            this.lblDanToc.Size = new System.Drawing.Size(77, 13);
            this.lblDanToc.TabIndex = 12;
            this.lblDanToc.Text = "Mã Dân tộc:";
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nu"});
            this.cboGioiTinh.Location = new System.Drawing.Point(118, 188);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(152, 21);
            this.cboGioiTinh.TabIndex = 13;
            // 
            // dataDanhSachHS
            // 
            this.dataDanhSachHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDanhSachHS.Location = new System.Drawing.Point(312, 103);
            this.dataDanhSachHS.Name = "dataDanhSachHS";
            this.dataDanhSachHS.Size = new System.Drawing.Size(660, 340);
            this.dataDanhSachHS.TabIndex = 14;
            // 
            // dateNgaysinh
            // 
            this.dateNgaysinh.CustomFormat = "dd/MM/yyyy";
            this.dateNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgaysinh.Location = new System.Drawing.Point(118, 225);
            this.dateNgaysinh.Name = "dateNgaysinh";
            this.dateNgaysinh.Size = new System.Drawing.Size(152, 20);
            this.dateNgaysinh.TabIndex = 18;
            // 
            // cboMaDantoc
            // 
            this.cboMaDantoc.FormattingEnabled = true;
            this.cboMaDantoc.Location = new System.Drawing.Point(118, 310);
            this.cboMaDantoc.Name = "cboMaDantoc";
            this.cboMaDantoc.Size = new System.Drawing.Size(152, 21);
            this.cboMaDantoc.TabIndex = 19;
            // 
            // cboMaTongiao
            // 
            this.cboMaTongiao.FormattingEnabled = true;
            this.cboMaTongiao.Location = new System.Drawing.Point(119, 344);
            this.cboMaTongiao.Name = "cboMaTongiao";
            this.cboMaTongiao.Size = new System.Drawing.Size(151, 21);
            this.cboMaTongiao.TabIndex = 21;
            // 
            // lblMaTongiao
            // 
            this.lblMaTongiao.AutoSize = true;
            this.lblMaTongiao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaTongiao.Location = new System.Drawing.Point(26, 344);
            this.lblMaTongiao.Name = "lblMaTongiao";
            this.lblMaTongiao.Size = new System.Drawing.Size(84, 13);
            this.lblMaTongiao.TabIndex = 20;
            this.lblMaTongiao.Text = "Mã Tôn Giáo:";
            // 
            // lblHotenCha
            // 
            this.lblHotenCha.AutoSize = true;
            this.lblHotenCha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotenCha.Location = new System.Drawing.Point(26, 380);
            this.lblHotenCha.Name = "lblHotenCha";
            this.lblHotenCha.Size = new System.Drawing.Size(79, 13);
            this.lblHotenCha.TabIndex = 23;
            this.lblHotenCha.Text = "Họ Tên Cha:";
            // 
            // txtTencha
            // 
            this.txtTencha.Location = new System.Drawing.Point(118, 380);
            this.txtTencha.Name = "txtTencha";
            this.txtTencha.Size = new System.Drawing.Size(152, 20);
            this.txtTencha.TabIndex = 22;
            // 
            // lblHotenMe
            // 
            this.lblHotenMe.AutoSize = true;
            this.lblHotenMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotenMe.Location = new System.Drawing.Point(26, 413);
            this.lblHotenMe.Name = "lblHotenMe";
            this.lblHotenMe.Size = new System.Drawing.Size(74, 13);
            this.lblHotenMe.TabIndex = 25;
            this.lblHotenMe.Text = "Họ Tên Mẹ:";
            // 
            // txtTenMe
            // 
            this.txtTenMe.Location = new System.Drawing.Point(119, 413);
            this.txtTenMe.Name = "txtTenMe";
            this.txtTenMe.Size = new System.Drawing.Size(151, 20);
            this.txtTenMe.TabIndex = 24;
            // 
            // btnSapXep
            // 
            this.btnSapXep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSapXep.Image = global::QuanLyDiemHocSinh.Properties.Resources.hocluc;
            this.btnSapXep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSapXep.Location = new System.Drawing.Point(866, 41);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(106, 56);
            this.btnSapXep.TabIndex = 29;
            this.btnSapXep.Text = "Sắp Xếp";
            this.btnSapXep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSapXep.UseVisualStyleBackColor = true;
            this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::QuanLyDiemHocSinh.Properties.Resources.thoat;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.Location = new System.Drawing.Point(1004, 472);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(95, 56);
            this.btnThoat.TabIndex = 28;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnIn
            // 
            this.btnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Image = global::QuanLyDiemHocSinh.Properties.Resources.closephanlop;
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIn.Location = new System.Drawing.Point(1004, 400);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(95, 56);
            this.btnIn.TabIndex = 27;
            this.btnIn.Text = "Xuất danh sách";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnTaomoi
            // 
            this.btnTaomoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaomoi.Image = global::QuanLyDiemHocSinh.Properties.Resources.add;
            this.btnTaomoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaomoi.Location = new System.Drawing.Point(1004, 103);
            this.btnTaomoi.Name = "btnTaomoi";
            this.btnTaomoi.Size = new System.Drawing.Size(95, 56);
            this.btnTaomoi.TabIndex = 26;
            this.btnTaomoi.Text = "Tạo mới";
            this.btnTaomoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaomoi.UseVisualStyleBackColor = true;
            this.btnTaomoi.Click += new System.EventHandler(this.btnTaomoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::QuanLyDiemHocSinh.Properties.Resources.delete;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(1004, 322);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 56);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::QuanLyDiemHocSinh.Properties.Resources.refresh;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(1004, 250);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(95, 56);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::QuanLyDiemHocSinh.Properties.Resources.save;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(1004, 178);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 56);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmQLHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 591);
            this.Controls.Add(this.btnSapXep);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnTaomoi);
            this.Controls.Add(this.lblHotenMe);
            this.Controls.Add(this.txtTenMe);
            this.Controls.Add(this.lblHotenCha);
            this.Controls.Add(this.txtTencha);
            this.Controls.Add(this.cboMaTongiao);
            this.Controls.Add(this.lblMaTongiao);
            this.Controls.Add(this.cboMaDantoc);
            this.Controls.Add(this.dateNgaysinh);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataDanhSachHS);
            this.Controls.Add(this.cboGioiTinh);
            this.Controls.Add(this.lblDanToc);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblMaHS);
            this.Controls.Add(this.txtMaHS);
            this.Controls.Add(this.lblQuanLyHocSinh);
            this.Name = "frmQLHocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Học Sinh";
            this.Load += new System.EventHandler(this.frmQLHocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDanhSachHS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuanLyHocSinh;
        private System.Windows.Forms.TextBox txtMaHS;
        private System.Windows.Forms.Label lblMaHS;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblDanToc;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.DataGridView dataDanhSachHS;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DateTimePicker dateNgaysinh;
        private System.Windows.Forms.ComboBox cboMaDantoc;
        private System.Windows.Forms.ComboBox cboMaTongiao;
        private System.Windows.Forms.Label lblMaTongiao;
        private System.Windows.Forms.Label lblHotenCha;
        private System.Windows.Forms.TextBox txtTencha;
        private System.Windows.Forms.Label lblHotenMe;
        private System.Windows.Forms.TextBox txtTenMe;
        private System.Windows.Forms.Button btnTaomoi;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSapXep;
    }
}

