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
                cbLoaisp.DataSource = dt_NhomSP;
                cbLoaisp.DisplayMember = "TenLoaiSanPham";
                cbLoaisp.ValueMember = "MaLoaiSanPham";
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
            if (txtMasp.Text.Trim() != "" && txtTenSanPham.Text.Trim() != "")
            {
                var ktra_ID = Dataconn.DataTable_Sql("SELECT * FROM tblSANPHAM WHERE MaSanPham='" + txtMasp.Text.Trim() + "'");
                if (ktra_ID.Rows.Count > 0)
                {
                    MessageBox.Show("Trùng mã sản phẩm, hãy kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtMasp.Text = "";
                    txtMasp.Focus();
                }
                else if (txtGiaNhap.Text.Trim() == "" && txtGiaBanLe.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn phải nhập đầy đủ thông tin giá của Sản phẩm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string insert = "insert into tblSANPHAM(MaSanPham,TenSanPham,MaNhaSanXuat,MaLoaiSanPham,GiaNhap,GiaBanLe,GhiChu) VALUES(";
                    insert += "N'" + txtMasp.Text.Trim() + "',N'" + txtTenSanPham.Text.Trim() + "','" + cbLoaisp.SelectedValue.ToString() + "','" + cbNhaSX.SelectedValue.ToString() + "',N'" + txtGiaNhap.Text.Trim() + "',N'" + txtGiaBanLe.Text.Trim() + "',N'" + txtGhiChu.Text.Trim() + "')";
                    Dataconn.Execute_NonSQL(insert);
                    MessageBox.Show("Thêm mới bản ghi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load_SanPham();
                    Xoa_txt();
                }
            }
            else
            {
                MessageBox.Show("Chưa thêm mới bản ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            checkBox1.Checked = false;

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
                cbLoaisp.Text = dgvSanPham.Rows[e.RowIndex].Cells["TenLoaiSanPham"].Value.ToString();
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
            if (txtTimKiem.Text.Trim() == "" && txttugia.Text.Trim() == "" && txtdengia.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập thông tin tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                txtTimKiem.Focus();
            }
            else
            {
                if (txttugia.Text.Trim() != "" && txtdengia.Text.Trim() != "" && txtTimKiem.Text.Trim() == "")
                {
                    var timkiemtheogia = "SELECT  sp.IDSanPham, sp.MaSanPham, sp.TenSanPham, lsp.TenLoaiSanPham, nsx.TenNSX,  sp.GiaNhap, sp.GiaBanLe,  sp.GhiChu";
                    timkiemtheogia += "   FROM    tblSANPHAM sp inner join tblNHASANXUAT nsx on sp.MaNhaSanXuat = nsx.MaNSX  inner join tblLOAISANPHAM lsp on sp.MaLoaiSanPham = lsp.MaLoaiSanPham    ";
                    timkiemtheogia += "   WHERE   sp.Giabanle BETWEEN " + txttugia.Text.Trim().Replace("'", "") + " AND " + txtdengia.Text.Trim().Replace("'", "") + "  ORDER BY sp.IDSanPham";
                    var dt_timkiemtheogia = Dataconn.DataTable_Sql(timkiemtheogia);
                    if (dt_timkiemtheogia.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        while (dgvSanPham.Rows.Count > 0)
                        {
                            dgvSanPham.Rows.RemoveAt(0);
                        }
                    }
                    else dgvSanPham.DataSource = dt_timkiemtheogia;
                }

                else if (txtTimKiem.Text.Trim() != "" && txttugia.Text.Trim() == "" && txtdengia.Text.Trim() == "")
                {
                    var timkiem = "SELECT  sp.IDSanPham, sp.MaSanPham, sp.TenSanPham, lsp.TenLoaiSanPham, nsx.TenNSX, sp.GiaNhap, sp.GiaBanLe,  sp.GhiChu";
                    timkiem += "   FROM    tblSANPHAM sp inner join tblNHASANXUAT nsx on sp.MaNhaSanXuat = nsx.MaNSX  inner join tblLOAISANPHAM lsp on sp.MaLoaiSanPham = lsp.MaLoaiSanPham    ";
                    timkiem += "   WHERE    sp.MaSanPham LIKE N'%" + txtTimKiem.Text + "%' OR sp.TenSanPham LIKE N'%" + txtTimKiem.Text + "%' OR lsp.TenLoaiSanPham LIKE N'%" + txtTimKiem.Text + "%' OR nsx.TenNSX LIKE N'%" + txtTimKiem.Text + "%'";
                    var dt_timkiem = Dataconn.DataTable_Sql(timkiem);
                    if (dt_timkiem.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        while (dgvSanPham.Rows.Count > 0)
                        {
                            dgvSanPham.Rows.RemoveAt(0);
                        }
                    }
                    else dgvSanPham.DataSource = dt_timkiem;

                }
                else
                {
                    MessageBox.Show("Nhập thông tin tìm kiếm không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    while (dgvSanPham.Rows.Count > 0)
                    {
                        dgvSanPham.Rows.RemoveAt(0);
                    }
                }
            }

            Xoa_txt();
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
                cbLoaisp.Focus();

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