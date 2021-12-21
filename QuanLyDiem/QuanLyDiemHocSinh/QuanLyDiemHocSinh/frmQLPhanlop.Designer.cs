
namespace QuanLyDiemHocSinh
{
    partial class frmQLPhanlop
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblMaNH = new System.Windows.Forms.Label();
            this.cboMaNH = new System.Windows.Forms.ComboBox();
            this.cboMaKhoi = new System.Windows.Forms.ComboBox();
            this.lblMaKL = new System.Windows.Forms.Label();
            this.cboMaLop = new System.Windows.Forms.ComboBox();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.cboMaHS = new System.Windows.Forms.ComboBox();
            this.lblMaHS = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTaomoi = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHÂN LỚP";
            // 
            // lblMaNH
            // 
            this.lblMaNH.AutoSize = true;
            this.lblMaNH.Location = new System.Drawing.Point(47, 106);
            this.lblMaNH.Name = "lblMaNH";
            this.lblMaNH.Size = new System.Drawing.Size(71, 13);
            this.lblMaNH.TabIndex = 1;
            this.lblMaNH.Text = "Mã Năm học:";
            // 
            // cboMaNH
            // 
            this.cboMaNH.FormattingEnabled = true;
            this.cboMaNH.Location = new System.Drawing.Point(121, 103);
            this.cboMaNH.Name = "cboMaNH";
            this.cboMaNH.Size = new System.Drawing.Size(121, 21);
            this.cboMaNH.TabIndex = 2;
            // 
            // cboMaKhoi
            // 
            this.cboMaKhoi.FormattingEnabled = true;
            this.cboMaKhoi.Location = new System.Drawing.Point(121, 145);
            this.cboMaKhoi.Name = "cboMaKhoi";
            this.cboMaKhoi.Size = new System.Drawing.Size(121, 21);
            this.cboMaKhoi.TabIndex = 4;
            // 
            // lblMaKL
            // 
            this.lblMaKL.AutoSize = true;
            this.lblMaKL.Location = new System.Drawing.Point(47, 148);
            this.lblMaKL.Name = "lblMaKL";
            this.lblMaKL.Size = new System.Drawing.Size(49, 13);
            this.lblMaKL.TabIndex = 3;
            this.lblMaKL.Text = "Mã Khối:";
            // 
            // cboMaLop
            // 
            this.cboMaLop.FormattingEnabled = true;
            this.cboMaLop.Location = new System.Drawing.Point(405, 106);
            this.cboMaLop.Name = "cboMaLop";
            this.cboMaLop.Size = new System.Drawing.Size(121, 21);
            this.cboMaLop.TabIndex = 6;
            this.cboMaLop.SelectedIndexChanged += new System.EventHandler(this.cboMaLop_SelectedIndexChanged);
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Location = new System.Drawing.Point(330, 106);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(46, 13);
            this.lblMaLop.TabIndex = 5;
            this.lblMaLop.Text = "Mã Lớp:";
            // 
            // cboMaHS
            // 
            this.cboMaHS.FormattingEnabled = true;
            this.cboMaHS.Location = new System.Drawing.Point(405, 148);
            this.cboMaHS.Name = "cboMaHS";
            this.cboMaHS.Size = new System.Drawing.Size(121, 21);
            this.cboMaHS.TabIndex = 8;
            // 
            // lblMaHS
            // 
            this.lblMaHS.AutoSize = true;
            this.lblMaHS.Location = new System.Drawing.Point(330, 151);
            this.lblMaHS.Name = "lblMaHS";
            this.lblMaHS.Size = new System.Drawing.Size(70, 13);
            this.lblMaHS.TabIndex = 7;
            this.lblMaHS.Text = "Mã Học sinh:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(743, 188);
            this.dataGridView1.TabIndex = 9;
            // 
            // btnTaomoi
            // 
            this.btnTaomoi.Location = new System.Drawing.Point(562, 103);
            this.btnTaomoi.Name = "btnTaomoi";
            this.btnTaomoi.Size = new System.Drawing.Size(75, 26);
            this.btnTaomoi.TabIndex = 10;
            this.btnTaomoi.Text = "Thêm mới";
            this.btnTaomoi.UseVisualStyleBackColor = true;
            this.btnTaomoi.Click += new System.EventHandler(this.btnTaomoi_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(669, 106);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(562, 148);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(669, 151);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmQLPhanlop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnTaomoi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cboMaHS);
            this.Controls.Add(this.lblMaHS);
            this.Controls.Add(this.cboMaLop);
            this.Controls.Add(this.lblMaLop);
            this.Controls.Add(this.cboMaKhoi);
            this.Controls.Add(this.lblMaKL);
            this.Controls.Add(this.cboMaNH);
            this.Controls.Add(this.lblMaNH);
            this.Controls.Add(this.label1);
            this.Name = "frmQLPhanlop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLPhanLop";
            this.Load += new System.EventHandler(this.frmQLPhanlop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMaNH;
        private System.Windows.Forms.ComboBox cboMaNH;
        private System.Windows.Forms.ComboBox cboMaKhoi;
        private System.Windows.Forms.Label lblMaKL;
        private System.Windows.Forms.ComboBox cboMaLop;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.ComboBox cboMaHS;
        private System.Windows.Forms.Label lblMaHS;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTaomoi;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
    }
}