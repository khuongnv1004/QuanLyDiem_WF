using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemHocSinh
{
    public partial class frmMain : Form
    {
        private int childFormNumber = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void stripDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDangNhap frm1 = new frmDangNhap();
            frm1.Show();
        }

        private void btnQuanLyHocSinh_Click(object sender, EventArgs e)
        {
            frmQLHocSinh frm1 = new frmQLHocSinh();
            frm1.Show();
            this.Close();
                    
        }

        private void btnQuanLyGiaoVien_Click(object sender, EventArgs e)
        {
            frmQLGiaovien frm1 = new frmQLGiaovien();
            frm1.Show();
            this.Close();
        }

        private void btnQuanLyLop_Click(object sender, EventArgs e)
        {
            frmQLLop frm1 = new frmQLLop();
            frm1.Show();
            this.Close();
        }

        private void btnQuanLyDiem_Click(object sender, EventArgs e)
        {
            frmQuanLyDiem frm1 = new frmQuanLyDiem();
            frm1.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnQLPhanlop_Click(object sender, EventArgs e)
        {
            frmQLPhanlop frm1 = new frmQLPhanlop();
            frm1.Show();
            this.Close();
        }

        private void stripTheoHS_Click(object sender, EventArgs e)
        {
            frmTimKiem frm1 = new frmTimKiem();
            frm1.Show();
            this.Close();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc muốn thoát không?",
               "Thông Báo", MessageBoxButtons.YesNo);
            Application.Exit();
        }

        private void báoCáoĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaocao frm1 = new frmBaocao();
            frm1.Show();
        }

        private void xemĐiểmHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXemDiem frm1 = new frmXemDiem();
            frm1.Show();
            this.Close();
        }
    }
}
