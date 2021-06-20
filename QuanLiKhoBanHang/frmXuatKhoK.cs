using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiKhoBanHang
{
    public partial class frmXuatKhoK : Form
    {
        private int i;
        public frmXuatKhoK()
        {
            InitializeComponent();
        }

        public void getSearchMaPhieu(string _getmaphieu)
        {
            txtSoPhieu.Text = "";
            txtSoPhieu.Text = _getmaphieu;
            load_data_temp();
        }

        private void load_data_temp()
        {
            var dt_dataTemp = Dataconn.DataTable_Sql("SELECT k.MaSanPham,k.TenSanPham,k.TenDVT,k.DonGia,k.SoLuong,k.ThanhTien,k.ID FROM tblXUATKHO_K k WHERE k.SoPhieu='" + txtSoPhieu.Text.Trim() + "'");
            if (dt_dataTemp.Rows.Count > 0)
            {
                dgvThongTinSanPham.DataSource = dt_dataTemp;
                //dgvThongTinSanPham.Columns[5].Visible = false;
            }
            else
            {
                dgvThongTinSanPham.DataSource = "";
            }
        }

        private void frmXuatKhoK_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
            GetMaNhanVien();
            GetMaSanPham();
        }

        private void CheckBoxTaoSoPhieu_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxTaoSoPhieu.Checked == true)
            {
                string GetID = "SELECT TOP(1) * FROM tblXUATKHO_K ORDER BY ID DESC";
                var dt_GetID = Dataconn.DataTable_Sql(GetID);
                int _ID = 1000;
                if (dt_GetID.Rows.Count > 0)
                {
                    _ID = 1000 + (Convert.ToInt32(dt_GetID.Rows[0]["ID"].ToString()));
                }
                txtSoPhieu.Text = "PX" + DateTime.Now.ToString("ddMMyy") + _ID;
            }
            else
            {
                txtSoPhieu.Text = "";
            }
        }

        private void GetMaNhanVien()
        {
            var dt_loadMaNV = Dataconn.DataTable_Sql("SELECT * FROM tblNHANVIEN");
            if (dt_loadMaNV.Rows.Count > 0)
            {
                cbMaNhanVien.DataSource = dt_loadMaNV;
                cbMaNhanVien.DisplayMember = "MaNhanVien";
                cbMaNhanVien.ValueMember = "MaNhanVien";

            }
        }

        private void cbMaNhanVien_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cbMaNhanVien.Text == "")
                txtTenNhanVien.Text = "";
            // Khi chọn Mã nhân viên thì tên nhân viên tự động hiện ra
            str = "Select TenNhanVien from tblNHANVIEN where MaNhanVien = N'" + cbMaNhanVien.SelectedValue + "'";
            txtTenNhanVien.Text = Dataconn.GetFieldValues(str);
        }

        private void GetMaSanPham()
        {
            var dt_MaSanPham = Dataconn.DataTable_Sql("SELECT MaSanPham, TenSanPham FROM tblSANPHAM ORDER BY IDSanPham DESC");
            if (dt_MaSanPham.Rows.Count > 0)
            {
                cbMaSanPham.DataSource = dt_MaSanPham;
                cbMaSanPham.DisplayMember = "MaSanPham";
                cbMaSanPham.ValueMember = "MaSanPham";
            }
        }

        private void cbMaSanPham_TextChanged(object sender, EventArgs e)
        {
            string strSP;
            if (cbMaSanPham.Text == "")
                txtTenSanPham.Text = "";
            // Khi chọn Mã sản phẩm thì tên sản phẩm tự động hiện ra
            strSP = "Select TenSanPham from tblSANPHAM where MaSanPham = N'" + cbMaSanPham.SelectedValue + "'";
            txtTenSanPham.Text = Dataconn.GetFieldValues(strSP);
            // Khi chọn Mã sản phẩm thì đơn giá tự động hiện ra
            strSP = "Select GiaBanLe from tblSANPHAM where MaSanPham = N'" + cbMaSanPham.SelectedValue + "'";
            txtDonGia.Text = Dataconn.GetFieldValues(strSP);
            // Khi chọn Mã sản phẩm thì đơn vị tính tự động hiện ra
            strSP = "select d.TenDVT from tblSANPHAM s inner join tblDONVITINH d on s.MaDVT = d.MaDVT where s.MaSanPham = N'" + cbMaSanPham.SelectedValue + "'";
            
        }

        private void btnTimMaSanPham_Click(object sender, EventArgs e)
        {
            frmTimMaSanPham frmTimMaSP = new frmTimMaSanPham();
            frmTimMaSP.TimKiem += frmTimMaSP_TimKiem;
            frmTimMaSP.ShowDialog();
        }
        void frmTimMaSP_TimKiem(string ma, string ten)
        {
            cbMaSanPham.Text = ma;
            txtTenSanPham.Text = ten;
        }

        private void xoatxt()
        {
            cbMaSanPham.SelectedIndex = 0;
            txtTenSanPham.ResetText();
            txtDonGia.ResetText();
           
            txtSoLuong.ResetText();
            txtThanhTien.ResetText();
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            var ktra_TonKho = Dataconn.DataTable_Sql("SELECT (ISNULL(nhapsoluong,0) - ISNULL(xuatsoluong,0)) as tonkho FROM (SELECT tblNHAPKHO_K.MaSanPham, SUM(tblNHAPKHO_K.SoLuong) as nhapsoluong FROM tblNHAPKHO_K GROUP BY tblNHAPKHO_K.MaSanPham) as nhap LEFT JOIN (SELECT tblXUATKHO_K.MaSanPham, SUM(tblXUATKHO_K.SoLuong) as xuatsoluong FROM tblXUATKHO_K GROUP BY tblXUATKHO_K.MaSanPham) as xuat ON nhap.MaSanPham = xuat.MaSanPham  WHERE nhap.MaSanPham ='" + cbMaSanPham.SelectedValue + "'");

            int SoLuongTon = 0;

            if (ktra_TonKho.Rows.Count > 0)
            {
                int.TryParse(ktra_TonKho.Rows[0][0].ToString(), out SoLuongTon);
            }

            if (SoLuongTon == 0)
            {

                MessageBox.Show("Không có sản phẩm trong kho. Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                xoatxt();
            }
            else
            {
                int SoLuongHienTai;
                if (!string.IsNullOrEmpty(txtSoLuong.Text.Trim()))
                {
                    if (int.TryParse(txtSoLuong.Text.Trim(), out SoLuongHienTai))
                    {
                        if (SoLuongHienTai > 0)
                        {
                            if (SoLuongTon < SoLuongHienTai)
                            {
                                MessageBox.Show("Sản phẩm trong kho hiện tại không đủ. Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                xoatxt();
                            }
                            else
                            {
                                dgvThongTinSanPham.Rows.Add();
                                dgvThongTinSanPham.Rows[dgvThongTinSanPham.Rows.Count - 1].Cells["MaSanPham"].Value = cbMaSanPham.SelectedValue;
                                dgvThongTinSanPham.Rows[dgvThongTinSanPham.Rows.Count - 1].Cells["TenSanPham"].Value = txtTenSanPham.Text;
                                dgvThongTinSanPham.Rows[dgvThongTinSanPham.Rows.Count - 1].Cells["DonGia"].Value = txtDonGia.Text;
                              
                                dgvThongTinSanPham.Rows[dgvThongTinSanPham.Rows.Count - 1].Cells["SoLuong"].Value = txtSoLuong.Text;
                                dgvThongTinSanPham.Rows[dgvThongTinSanPham.Rows.Count - 1].Cells["ThanhTien"].Value = txtThanhTien.Text;
                                xoatxt();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nhập số lượng không đúng. Vui lòng kiểm tra lại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtSoLuong.ResetText(); ;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nhập số lượng không đúng. Vui lòng kiểm tra lại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtSoLuong.ResetText(); ;
                    }
                }
            }
       
        }

        private void btnSuaSanPham_Click(object sender, EventArgs e)
        {
            if (dgvThongTinSanPham.CurrentRow != null)
            {
                dgvThongTinSanPham.CurrentRow.Cells["MaSanPham"].Value = cbMaSanPham.SelectedValue;
                dgvThongTinSanPham.CurrentRow.Cells["TenSanPham"].Value = txtTenSanPham.Text;
                dgvThongTinSanPham.CurrentRow.Cells["DonGia"].Value = txtDonGia.Text;
              
                dgvThongTinSanPham.CurrentRow.Cells["SoLuong"].Value = txtSoLuong.Text;
                dgvThongTinSanPham.CurrentRow.Cells["ThanhTien"].Value = txtThanhTien.Text;
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                xoatxt();
            }
            else
            {
                MessageBox.Show("Chưa chọn bản ghi để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnXoaSanPham_Click(object sender, EventArgs e)
        {
            if (dgvThongTinSanPham.CurrentRow != null)
            {
                dgvThongTinSanPham.Rows.RemoveAt(dgvThongTinSanPham.CurrentRow.Index);
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                xoatxt();
            }
            else
            {
                MessageBox.Show("Chưa chọn bản ghi để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            if (!string.IsNullOrEmpty(txtSoLuong.Text) &&
                 !int.TryParse(txtSoLuong.Text, out i)
              )
            {
                MessageBox.Show("Vui lòng nhập số nguyên dương!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Text = "";
            }

            //Khi thay đổi số lượng thì thực hiện tính lại thành tiền
            double tt, sl, dg;
            if (txtSoLuong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoLuong.Text);
            if (txtDonGia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDonGia.Text);
            tt = sl * dg;
            txtThanhTien.Text = tt.ToString();
        }

        private void dgvThongTinSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbMaSanPham.Text = dgvThongTinSanPham.Rows[e.RowIndex].Cells["MaSanPham"].Value.ToString();
            txtTenSanPham.Text = dgvThongTinSanPham.Rows[e.RowIndex].Cells["TenSanPham"].Value.ToString();
            txtDonGia.Text = dgvThongTinSanPham.Rows[e.RowIndex].Cells["DonGia"].Value.ToString();
          
            txtSoLuong.Text = dgvThongTinSanPham.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString();
            txtThanhTien.Text = dgvThongTinSanPham.Rows[e.RowIndex].Cells["ThanhTien"].Value.ToString(); 
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtSoPhieu.Text.Trim() == "" || cbMaNhanVien.Text == "" || dgvThongTinSanPham.Rows.Count < 1)
            {
                MessageBox.Show("Thông tin phiếu xuất kho không đầy đủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                var ktra_ID = Dataconn.DataTable_Sql("SELECT * FROM tblXUATKHO_K WHERE SoPhieu ='" + txtSoPhieu.Text.Trim() + "'");
                if (ktra_ID.Rows.Count > 0)
                {
                    MessageBox.Show("Trùng số phiếu, hãy kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    for (int i = 0; i < dgvThongTinSanPham.Rows.Count; i++)
                    {
                        String insert = "INSERT INTO tblXUATKHO_K(SoPhieu, NgayXuat, MaNhanVien, TenNhanVien, DiaChi, SoDienThoai, MaSanPham, TenSanPham, DonGia, SoLuong,ThanhTien) VALUES ('";

                        insert += txtSoPhieu.Text.Trim() + "','";
                        insert += dateTimePicker1.Value.Date.ToString("yyyyMMdd") + "','";
                        insert += cbMaNhanVien.SelectedValue.ToString() + "',N'";
                        insert += txtTenNhanVien.Text.Trim() + "','";

                        insert += dgvThongTinSanPham.Rows[i].Cells["MaSanPham"].Value.ToString() + "',N'";
                        insert += dgvThongTinSanPham.Rows[i].Cells["TenSanPham"].Value.ToString() + "','";
                        insert += dgvThongTinSanPham.Rows[i].Cells["DonGia"].Value.ToString() + "',N'";
                        insert += dgvThongTinSanPham.Rows[i].Cells["SoLuong"].Value.ToString() + "',N'";
                        insert += dgvThongTinSanPham.Rows[i].Cells["ThanhTien"].Value.ToString() + "')";
                        //string sGhichu = dgvThongTinSanPham.Rows[i].Cells["GhiChu"].Value==null ? string.Empty : dgvThongTinSanPham.Rows[i].Cells["GhiChu"].Value.ToString();
                        //insert += sGhichu + "')";
                        Dataconn.Execute_NonSQL(insert);
                    }
                    MessageBox.Show("Thêm phiếu xuất kho thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            CheckBoxTaoSoPhieu.Checked = false;
        }

       

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }



        private void Xoa_txt()
        {
            while (dgvThongTinSanPham.Rows.Count > 0)
            {
                dgvThongTinSanPham.Rows.RemoveAt(0);
            }
            xoatxt();
            txtSoPhieu.ResetText();
            CheckBoxTaoSoPhieu.Checked = false;
            cbMaNhanVien.SelectedIndex = 0;
            txtTenNhanVien.ResetText();
           
            txtDiaChiKhachHang.ResetText();
            txtDienThoaiKhachHang.ResetText();
        }

    
        //private void frmTimPhieuXuatKho_TimKiemSP(string sophieu, DateTime ngayxuat, string manhanvien, string ID)
        //{
        //    throw new NotImplementedException();
        //}
        private void frmTimPhieuXuatKho_TimKiemSP(string sophieu, DateTime ngayxuat, string manhanvien, string makhachhang, string ID)
        {
            //throw new NotImplementedException();
            txtSoPhieu.Text = sophieu;
            dateTimePicker1.Value = ngayxuat;
            cbMaNhanVien.Text = manhanvien;
            
            //txtGhiChu.Text = ghichu;
            lbID.Text = ID;
        }



        //internal void getSearchMaPhieu(string s)
        //{
        //    throw new NotImplementedException();
        //}




        public DateTime ngayxuat { get; set; }

      

        private void groupPanel2_Click(object sender, EventArgs e)
        {

        }
    }
}
