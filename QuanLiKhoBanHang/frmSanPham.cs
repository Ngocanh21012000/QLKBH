using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace QuanLiKhoBanHang
{
    // DevComponents.DotNetBar.RibbonForm
    public partial class frmSanPham :DevComponents.DotNetBar.Office2007Form
    {

        public delegate void AddEventhander();
        public event AddEventhander AddSanPham;

        public frmSanPham()
        {
            InitializeComponent();
        }
        private void GetNhomSP()
        {
            var dt_NhomSP = Dataconn.DataTable_Sql("SELECT * FROM tblLOAISANPHAM ORDER BY IDLoaiSP DESC");
            if (dt_NhomSP.Rows.Count>0)
            {
                cbNhomSP.DataSource = dt_NhomSP;
                cbNhomSP.DisplayMember = "TenLoaiSanPham";
                cbNhomSP.ValueMember = "MaLoaiSanPham";
            }
        }
        private void GetNhaSX()
        {
            var dt_NhaSX = Dataconn.DataTable_Sql("SELECT * FROM tblNHASANXUAT ORDER BY IDNSX DESC");
            if (dt_NhaSX.Rows.Count > 0)
            {
                cbNhaSX.DataSource = dt_NhaSX;
                cbNhaSX.DisplayMember = "TenNSX";
                cbNhaSX.ValueMember = "MaNSX";
            }
        }
       
       
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            txtMasp.Focus();
            GetNhomSP();
            GetNhaSX();
         
         
            lbID.Visible = false;
            load_SanPham();
            //dgvSanPham.Columns["GiaNhap"].DefaultCellStyle.Format = "N0";
            //dgvSanPham.Columns["GiaBanLe"].DefaultCellStyle.Format = "N0";
        }
        private void load_SanPham()
        {//                         0               1           2                       3           4       5           6           7               8
            string kv = "select sp.IDSanPham, sp.MaSanPham, sp.TenSanPham, lsp.TenLoaiSanPham, nsx.TenNSX, sp.GiaNhap, sp.GiaBanLe, ";
            kv += "  sp.GhiChu from tblSANPHAM sp inner join tblNHASANXUAT nsx on sp.MaNhaSanXuat = nsx.MaNSX inner join ";
          
           kv += " tblLOAISANPHAM lsp on sp.MaLoaiSanPham = lsp.MaLoaiSanPham order by IDSanPham DESC";
            var dt_kv = Dataconn.DataTable_Sql(kv);
            if (dt_kv.Rows.Count > 0)
            {
                dgvSanPham.DataSource = dt_kv;
            }
            else
            {
                MessageBox.Show("Không có bản ghi nào!");
            }
            checkBox1.Checked = false;
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            frmLoaiSanPham frmNhomsp = new frmLoaiSanPham();
            frmNhomsp.AddLoaiSanPham += frmNhomsp_AddLoaiSanPham;
            frmNhomsp.ShowDialog();
        }

        void frmNhomsp_AddLoaiSanPham()
        {
            GetNhomSP();
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            frmNhaSanXuat frmNhasx = new frmNhaSanXuat();
            frmNhasx.AddNhaSanXuat += frmNhasx_AddNhaSanXuat;
            frmNhasx.ShowDialog();
        }
        void frmNhasx_AddNhaSanXuat()
        {
            GetNhaSX();
        }
       
     
        
      
       
        private void textBoxX3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtGiaBanLe.Focus();

            }
        }

        private void textBoxX3_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            if (!string.IsNullOrEmpty(txtGiaNhap.Text) &&
                 !int.TryParse(txtGiaNhap.Text, out i)
              )
            {
                MessageBox.Show("Vui lòng nhập số!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaNhap.Text = "";
            }             
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                string GetID = "SELECT TOP(1) * FROM tblSANPHAM ORDER BY IDSanPham DESC";
                var dt_GetID = Dataconn.DataTable_Sql(GetID);
                int _ID = 1001;
                if (dt_GetID.Rows.Count>0)
                {
                    _ID = 1000 + (Convert.ToInt32( dt_GetID.Rows[0]["IDSanPham"].ToString()));
                }
                txtMasp.Text = "SP" + DateTime.Now.ToString("ddMMyy") + _ID;          
            }
            else
            {
                txtMasp.Text = "";
            }
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void txtMasp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtTenSanPham.Focus();

            }
        }
        private void Xoa_txt()
        {
            txtMasp.Text = "";
            txtTenSanPham.Text = "";
            txtGiaNhap.Text = "";
            txtGiaBanLe.Text = "";
           
            txtGhiChu.Text = "";
            txtTimKiem.Text = "";
            txttugia.Text = "";
            txtdengia.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
          
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            {
                lbID.Text = dgvSanPham.Rows[e.RowIndex].Cells["IDSanPham"].Value.ToString();
                txtMasp.Text = dgvSanPham.Rows[e.RowIndex].Cells["MaSanPham"].Value.ToString();
                txtTenSanPham.Text = dgvSanPham.Rows[e.RowIndex].Cells["TenSanPham"].Value.ToString();
                cbNhomSP.Text = dgvSanPham.Rows[e.RowIndex].Cells["TenLoaiSanPham"].Value.ToString();
                cbNhaSX.Text = dgvSanPham.Rows[e.RowIndex].Cells["TenNSX"].Value.ToString();
               
                txtGiaNhap.Text = dgvSanPham.Rows[e.RowIndex].Cells["GiaNhap"].Value.ToString();
                txtGiaBanLe.Text = dgvSanPham.Rows[e.RowIndex].Cells["GiaBanLe"].Value.ToString();
                ;
                txtGhiChu.Text = dgvSanPham.Rows[e.RowIndex].Cells["GhiChu"].Value.ToString();
            }
            catch 
            {
            
            }
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
        }

        private void txttugia_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            if (!string.IsNullOrEmpty(txttugia.Text) &&
                 !int.TryParse(txttugia.Text, out i)
              )
            {
                MessageBox.Show("Vui lòng nhập số!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Xoa_txt();
            }            
        }

        private void txtdengia_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            if (!string.IsNullOrEmpty(txtdengia.Text) &&
                 !int.TryParse(txtdengia.Text, out i)
              )
            {
                MessageBox.Show("Vui lòng nhập số!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Xoa_txt();
            }            
        }

        private void txtTenSanPham_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cbNhomSP.Focus();

            }
        }

        private void cbNhomSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cbNhaSX.Focus();

            }
        }

        private void cbNhaSX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtGiaNhap.Focus();

            }
        }

       

        private void txtGiaBanLe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtGhiChu.Focus();
            }
        }


      

       

        
        private void checkBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtTenSanPham.Focus();

            }
        }

        private void txtGiaBanLe_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            if (!string.IsNullOrEmpty(txtGiaBanLe.Text) &&
                 !int.TryParse(txtGiaBanLe.Text, out i)
              )
            {
                MessageBox.Show("Vui lòng nhập số!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaBanLe.Text = "";
            }
        }

        private void frmSanPham_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (AddSanPham != null)
                AddSanPham();
        }

        private void labelX17_Click(object sender, EventArgs e)
        {

        }
    }
}