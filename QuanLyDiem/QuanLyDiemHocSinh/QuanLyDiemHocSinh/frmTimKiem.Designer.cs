
namespace QuanLyDiemHocSinh
{
    partial class frmTimKiem
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
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtMaHS = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.obtmahs = new System.Windows.Forms.RadioButton();
            this.obttenhs = new System.Windows.Forms.RadioButton();
            this.txttenhs = new System.Windows.Forms.TextBox();
            this.obtmadt = new System.Windows.Forms.RadioButton();
            this.obtmatg = new System.Windows.Forms.RadioButton();
            this.cbomadantoc = new System.Windows.Forms.ComboBox();
            this.cbomatongiao = new System.Windows.Forms.ComboBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiem.Location = new System.Drawing.Point(260, 19);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(261, 31);
            this.lblTimKiem.TabIndex = 0;
            this.lblTimKiem.Text = "Tìm Kiếm Học Sinh";
            // 
            // txtMaHS
            // 
            this.txtMaHS.Location = new System.Drawing.Point(220, 67);
            this.txtMaHS.Name = "txtMaHS";
            this.txtMaHS.Size = new System.Drawing.Size(113, 20);
            this.txtMaHS.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(786, 221);
            this.dataGridView1.TabIndex = 6;
            // 
            // obtmahs
            // 
            this.obtmahs.AutoSize = true;
            this.obtmahs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obtmahs.Location = new System.Drawing.Point(91, 62);
            this.obtmahs.Margin = new System.Windows.Forms.Padding(2);
            this.obtmahs.Name = "obtmahs";
            this.obtmahs.Size = new System.Drawing.Size(118, 24);
            this.obtmahs.TabIndex = 7;
            this.obtmahs.TabStop = true;
            this.obtmahs.Text = "Mã Học Sinh";
            this.obtmahs.UseVisualStyleBackColor = true;
            // 
            // obttenhs
            // 
            this.obttenhs.AutoSize = true;
            this.obttenhs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obttenhs.Location = new System.Drawing.Point(91, 103);
            this.obttenhs.Margin = new System.Windows.Forms.Padding(2);
            this.obttenhs.Name = "obttenhs";
            this.obttenhs.Size = new System.Drawing.Size(123, 24);
            this.obttenhs.TabIndex = 9;
            this.obttenhs.TabStop = true;
            this.obttenhs.Text = "Tên Học Sinh";
            this.obttenhs.UseVisualStyleBackColor = true;
            // 
            // txttenhs
            // 
            this.txttenhs.Location = new System.Drawing.Point(220, 108);
            this.txttenhs.Name = "txttenhs";
            this.txttenhs.Size = new System.Drawing.Size(113, 20);
            this.txttenhs.TabIndex = 8;
            // 
            // obtmadt
            // 
            this.obtmadt.AutoSize = true;
            this.obtmadt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obtmadt.Location = new System.Drawing.Point(91, 141);
            this.obtmadt.Margin = new System.Windows.Forms.Padding(2);
            this.obtmadt.Name = "obtmadt";
            this.obtmadt.Size = new System.Drawing.Size(113, 24);
            this.obtmadt.TabIndex = 9;
            this.obtmadt.TabStop = true;
            this.obtmadt.Text = "Mã Dân Tộc";
            this.obtmadt.UseVisualStyleBackColor = true;
            // 
            // obtmatg
            // 
            this.obtmatg.AutoSize = true;
            this.obtmatg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obtmatg.Location = new System.Drawing.Point(91, 174);
            this.obtmatg.Margin = new System.Windows.Forms.Padding(2);
            this.obtmatg.Name = "obtmatg";
            this.obtmatg.Size = new System.Drawing.Size(118, 24);
            this.obtmatg.TabIndex = 9;
            this.obtmatg.TabStop = true;
            this.obtmatg.Text = "Mã Tôn Giáo";
            this.obtmatg.UseVisualStyleBackColor = true;
            // 
            // cbomadantoc
            // 
            this.cbomadantoc.FormattingEnabled = true;
            this.cbomadantoc.Location = new System.Drawing.Point(220, 145);
            this.cbomadantoc.Margin = new System.Windows.Forms.Padding(2);
            this.cbomadantoc.Name = "cbomadantoc";
            this.cbomadantoc.Size = new System.Drawing.Size(113, 21);
            this.cbomadantoc.TabIndex = 10;
            // 
            // cbomatongiao
            // 
            this.cbomatongiao.FormattingEnabled = true;
            this.cbomatongiao.Location = new System.Drawing.Point(220, 179);
            this.cbomatongiao.Margin = new System.Windows.Forms.Padding(2);
            this.cbomatongiao.Name = "cbomatongiao";
            this.cbomatongiao.Size = new System.Drawing.Size(113, 21);
            this.cbomatongiao.TabIndex = 10;
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Image = global::QuanLyDiemHocSinh.Properties.Resources.thoat;
            this.btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoat.Location = new System.Drawing.Point(549, 131);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(133, 42);
            this.btnthoat.TabIndex = 11;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = global::QuanLyDiemHocSinh.Properties.Resources.xemdiem;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(550, 67);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(132, 43);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.cbomatongiao);
            this.Controls.Add(this.cbomadantoc);
            this.Controls.Add(this.obtmatg);
            this.Controls.Add(this.obtmadt);
            this.Controls.Add(this.obttenhs);
            this.Controls.Add(this.txttenhs);
            this.Controls.Add(this.obtmahs);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtMaHS);
            this.Controls.Add(this.lblTimKiem);
            this.Name = "frmTimKiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm";
            this.Load += new System.EventHandler(this.frmTimKiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtMaHS;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton obtmahs;
        private System.Windows.Forms.RadioButton obttenhs;
        private System.Windows.Forms.TextBox txttenhs;
        private System.Windows.Forms.RadioButton obtmadt;
        private System.Windows.Forms.RadioButton obtmatg;
        private System.Windows.Forms.ComboBox cbomadantoc;
        private System.Windows.Forms.ComboBox cbomatongiao;
        private System.Windows.Forms.Button btnthoat;
    }
}