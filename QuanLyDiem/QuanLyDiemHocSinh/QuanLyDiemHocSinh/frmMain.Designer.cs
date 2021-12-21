
namespace QuanLyDiemHocSinh
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.stripHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.stripDoiMK = new System.Windows.Forms.ToolStripMenuItem();
            this.stripDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.stripTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.stripTheoHS = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemĐiểmHọcSinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kếtQuảHọcSinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoĐiểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.grpDanhmuc = new System.Windows.Forms.GroupBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnQLPhanlop = new System.Windows.Forms.Button();
            this.btnQuanLyDiem = new System.Windows.Forms.Button();
            this.btnQuanLyLop = new System.Windows.Forms.Button();
            this.btnQuanLyGiaoVien = new System.Windows.Forms.Button();
            this.btnQuanLyHocSinh = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.grpDanhmuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripHeThong,
            this.stripTimKiem,
            this.thốngKêToolStripMenuItem,
            this.báoCáoToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1244, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // stripHeThong
            // 
            this.stripHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripDoiMK,
            this.stripDangXuat});
            this.stripHeThong.Name = "stripHeThong";
            this.stripHeThong.Size = new System.Drawing.Size(69, 20);
            this.stripHeThong.Text = "Hệ thống";
            // 
            // stripDoiMK
            // 
            this.stripDoiMK.Image = global::QuanLyDiemHocSinh.Properties.Resources.doimatkhaucontext;
            this.stripDoiMK.Name = "stripDoiMK";
            this.stripDoiMK.Size = new System.Drawing.Size(146, 22);
            this.stripDoiMK.Text = "Đổi Mật Khẩu";
            // 
            // stripDangXuat
            // 
            this.stripDangXuat.Image = global::QuanLyDiemHocSinh.Properties.Resources.dangxuat;
            this.stripDangXuat.Name = "stripDangXuat";
            this.stripDangXuat.Size = new System.Drawing.Size(146, 22);
            this.stripDangXuat.Text = "Đăng Xuất";
            this.stripDangXuat.Click += new System.EventHandler(this.stripDangXuat_Click);
            // 
            // stripTimKiem
            // 
            this.stripTimKiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripTheoHS});
            this.stripTimKiem.Name = "stripTimKiem";
            this.stripTimKiem.Size = new System.Drawing.Size(68, 20);
            this.stripTimKiem.Text = "Tìm kiếm";
            // 
            // stripTheoHS
            // 
            this.stripTheoHS.Image = global::QuanLyDiemHocSinh.Properties.Resources.tracuuhocsinh;
            this.stripTheoHS.Name = "stripTheoHS";
            this.stripTheoHS.Size = new System.Drawing.Size(171, 22);
            this.stripTheoHS.Text = "Tìm kiếm học sinh";
            this.stripTheoHS.Click += new System.EventHandler(this.stripTheoHS_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemĐiểmHọcSinhToolStripMenuItem,
            this.kếtQuảHọcSinhToolStripMenuItem});
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // xemĐiểmHọcSinhToolStripMenuItem
            // 
            this.xemĐiểmHọcSinhToolStripMenuItem.Name = "xemĐiểmHọcSinhToolStripMenuItem";
            this.xemĐiểmHọcSinhToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xemĐiểmHọcSinhToolStripMenuItem.Text = "Kêt quả học kỳ";
            this.xemĐiểmHọcSinhToolStripMenuItem.Click += new System.EventHandler(this.xemĐiểmHọcSinhToolStripMenuItem_Click);
            // 
            // kếtQuảHọcSinhToolStripMenuItem
            // 
            this.kếtQuảHọcSinhToolStripMenuItem.Name = "kếtQuảHọcSinhToolStripMenuItem";
            this.kếtQuảHọcSinhToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kếtQuảHọcSinhToolStripMenuItem.Text = "Kết quả cả năm";
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.báoCáoĐiểmToolStripMenuItem});
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // báoCáoĐiểmToolStripMenuItem
            // 
            this.báoCáoĐiểmToolStripMenuItem.Name = "báoCáoĐiểmToolStripMenuItem";
            this.báoCáoĐiểmToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.báoCáoĐiểmToolStripMenuItem.Text = "Báo cáo điểm";
            this.báoCáoĐiểmToolStripMenuItem.Click += new System.EventHandler(this.báoCáoĐiểmToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1244, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 563);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1244, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // grpDanhmuc
            // 
            this.grpDanhmuc.Controls.Add(this.btnthoat);
            this.grpDanhmuc.Controls.Add(this.btnQLPhanlop);
            this.grpDanhmuc.Controls.Add(this.btnQuanLyDiem);
            this.grpDanhmuc.Controls.Add(this.btnQuanLyLop);
            this.grpDanhmuc.Controls.Add(this.btnQuanLyGiaoVien);
            this.grpDanhmuc.Controls.Add(this.btnQuanLyHocSinh);
            this.grpDanhmuc.Location = new System.Drawing.Point(0, 52);
            this.grpDanhmuc.Name = "grpDanhmuc";
            this.grpDanhmuc.Size = new System.Drawing.Size(200, 508);
            this.grpDanhmuc.TabIndex = 4;
            this.grpDanhmuc.TabStop = false;
            this.grpDanhmuc.Text = "Danh mục";
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.Color.Crimson;
            this.btnthoat.Image = global::QuanLyDiemHocSinh.Properties.Resources.exit;
            this.btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoat.Location = new System.Drawing.Point(40, 419);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(99, 36);
            this.btnthoat.TabIndex = 9;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnQLPhanlop
            // 
            this.btnQLPhanlop.Image = global::QuanLyDiemHocSinh.Properties.Resources.dslophoc;
            this.btnQLPhanlop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLPhanlop.Location = new System.Drawing.Point(12, 340);
            this.btnQLPhanlop.Name = "btnQLPhanlop";
            this.btnQLPhanlop.Size = new System.Drawing.Size(164, 74);
            this.btnQLPhanlop.TabIndex = 8;
            this.btnQLPhanlop.Text = "Quản Lý Phân Lớp";
            this.btnQLPhanlop.UseVisualStyleBackColor = true;
            this.btnQLPhanlop.Click += new System.EventHandler(this.btnQLPhanlop_Click);
            // 
            // btnQuanLyDiem
            // 
            this.btnQuanLyDiem.Image = global::QuanLyDiemHocSinh.Properties.Resources.diem;
            this.btnQuanLyDiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyDiem.Location = new System.Drawing.Point(12, 262);
            this.btnQuanLyDiem.Name = "btnQuanLyDiem";
            this.btnQuanLyDiem.Size = new System.Drawing.Size(164, 72);
            this.btnQuanLyDiem.TabIndex = 7;
            this.btnQuanLyDiem.Text = "Quản Lý Điểm";
            this.btnQuanLyDiem.UseVisualStyleBackColor = true;
            this.btnQuanLyDiem.Click += new System.EventHandler(this.btnQuanLyDiem_Click);
            // 
            // btnQuanLyLop
            // 
            this.btnQuanLyLop.Image = global::QuanLyDiemHocSinh.Properties.Resources.lophoc;
            this.btnQuanLyLop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyLop.Location = new System.Drawing.Point(12, 182);
            this.btnQuanLyLop.Name = "btnQuanLyLop";
            this.btnQuanLyLop.Size = new System.Drawing.Size(164, 74);
            this.btnQuanLyLop.TabIndex = 6;
            this.btnQuanLyLop.Text = "Quản Lý Lớp";
            this.btnQuanLyLop.UseVisualStyleBackColor = true;
            this.btnQuanLyLop.Click += new System.EventHandler(this.btnQuanLyLop_Click);
            // 
            // btnQuanLyGiaoVien
            // 
            this.btnQuanLyGiaoVien.Image = global::QuanLyDiemHocSinh.Properties.Resources.dsgiaovien;
            this.btnQuanLyGiaoVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyGiaoVien.Location = new System.Drawing.Point(12, 106);
            this.btnQuanLyGiaoVien.Name = "btnQuanLyGiaoVien";
            this.btnQuanLyGiaoVien.Size = new System.Drawing.Size(164, 70);
            this.btnQuanLyGiaoVien.TabIndex = 6;
            this.btnQuanLyGiaoVien.Text = "Quản Lý Giáo Viên";
            this.btnQuanLyGiaoVien.UseVisualStyleBackColor = true;
            this.btnQuanLyGiaoVien.Click += new System.EventHandler(this.btnQuanLyGiaoVien_Click);
            // 
            // btnQuanLyHocSinh
            // 
            this.btnQuanLyHocSinh.Image = global::QuanLyDiemHocSinh.Properties.Resources.dshocsinh;
            this.btnQuanLyHocSinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyHocSinh.Location = new System.Drawing.Point(12, 34);
            this.btnQuanLyHocSinh.Name = "btnQuanLyHocSinh";
            this.btnQuanLyHocSinh.Size = new System.Drawing.Size(164, 66);
            this.btnQuanLyHocSinh.TabIndex = 6;
            this.btnQuanLyHocSinh.Text = "Quản Lý Học Sinh";
            this.btnQuanLyHocSinh.UseVisualStyleBackColor = true;
            this.btnQuanLyHocSinh.Click += new System.EventHandler(this.btnQuanLyHocSinh_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(197, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1047, 508);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 585);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpDanhmuc);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMain";
            this.Text = "Quản Lý Học Sinh";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.grpDanhmuc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem stripHeThong;
        private System.Windows.Forms.ToolStripMenuItem stripTimKiem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpDanhmuc;
        private System.Windows.Forms.Button btnQuanLyLop;
        private System.Windows.Forms.Button btnQuanLyGiaoVien;
        private System.Windows.Forms.Button btnQuanLyHocSinh;
        private System.Windows.Forms.ToolStripMenuItem stripDoiMK;
        private System.Windows.Forms.ToolStripMenuItem stripDangXuat;
        private System.Windows.Forms.ToolStripMenuItem stripTheoHS;
        private System.Windows.Forms.Button btnQuanLyDiem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem xemĐiểmHọcSinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kếtQuảHọcSinhToolStripMenuItem;
        private System.Windows.Forms.Button btnQLPhanlop;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoĐiểmToolStripMenuItem;
    }
}



