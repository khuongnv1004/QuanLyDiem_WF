namespace QuanLyDiemHocSinh
{
    partial class frmBaocao
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
            this.CRV_BCDIEM = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CRV_BCDIEM
            // 
            this.CRV_BCDIEM.ActiveViewIndex = -1;
            this.CRV_BCDIEM.AutoSize = true;
            this.CRV_BCDIEM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRV_BCDIEM.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRV_BCDIEM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRV_BCDIEM.Location = new System.Drawing.Point(0, 0);
            this.CRV_BCDIEM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CRV_BCDIEM.Name = "CRV_BCDIEM";
            this.CRV_BCDIEM.Size = new System.Drawing.Size(600, 366);
            this.CRV_BCDIEM.TabIndex = 0;
            this.CRV_BCDIEM.ToolPanelWidth = 150;
            // 
            // frmBaocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.CRV_BCDIEM);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmBaocao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBaocao";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBaocao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRV_BCDIEM;
    }
}