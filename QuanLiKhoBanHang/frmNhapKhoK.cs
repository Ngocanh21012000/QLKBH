﻿using System;
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
    public partial class frmNhapKhoK : Form
    {
        private int i;
        public frmNhapKhoK()
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
            string k = "SELECT *  FROM tblNHAPKHO_K ";
            var dt_k = Dataconn.DataTable_Sql(k);
            if (dt_k.Rows.Count > 0)
            {
                dgvThongTinSanPham.DataSource = dt_k;
            }
            else
            {
                dgvThongTinSanPham.DataSource = "";
            }
           
        }

        private void frmNhapKhoK_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
            GetMaNhanVien();
            GetMaSanPham();

            load_data_temp();
        }
        
        private void CheckBoxTaoSoPhieu_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxTaoSoPhieu.Checked == true)
            {
                string GetID = "SELECT TOP(1) * FROM tblNHAPKHO_K ORDER BY ID DESC";
                var dt_GetID = Dataconn.DataTable_Sql(GetID);
                int _ID = 1000;
                if (dt_GetID.Rows.Count > 0)
                {
                    _ID = 1000 + (Convert.ToInt32(dt_GetID.Rows[0]["ID"].ToString()));
                }
                txtSoPhieu.Text = "PN" + DateTime.Now.ToString("ddMMyy") + _ID;
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
            strSP = "Select GiaNhap from tblSANPHAM where MaSanPham = N'" + cbMaSanPham.SelectedValue + "'";
            txtDonGia.Text = Dataconn.GetFieldValues(strSP);
            
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

        private void btnThemMaSanPham_Click(object sender, EventArgs e)
        {
            frmSanPham frmSP = new frmSanPham();
            frmSP.AddSanPham+=frmSP_AddSanPham;
            frmSP.ShowDialog();
        }
        void frmSP_AddSanPham()
        {
            GetMaSanPham();
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

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
           
        }
        private void xoatxt()
        {
            cbMaSanPham.SelectedIndex = 0;
            txtTenSanPham.ResetText();
            txtDonGia.ResetText();
          
            txtSoLuong.ResetText();
            txtThanhTien.ResetText();
        }

        private void btnSuaSanPham_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoaSanPham_Click(object sender, EventArgs e)
        {
            
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
            {
                if (txtSoPhieu.Text.Trim() == "" || cbMaNhanVien.Text == "" || dgvThongTinSanPham.Rows.Count < 1)
                {
                    MessageBox.Show("Thông tin phiếu nhập kho không đầy đủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    var ktra_ID = Dataconn.DataTable_Sql("SELECT * FROM tblNHAPKHO_K WHERE SoPhieu ='" + txtSoPhieu.Text.Trim() + "'");
                    if (ktra_ID.Rows.Count > 0)
                    {
                        MessageBox.Show("Trùng số phiếu, hãy kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        for (int i = 0; i < dgvThongTinSanPham.Rows.Count; i++)
                        {
                            String insert = "INSERT INTO tblNHAPKHO_K(SoPhieu, NgayLap, MaNhanVien, TenNhanVien, MaSanPham, TenSanPham, DonGia, SoLuong, ThanhTien) VALUES ('";

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
                        MessageBox.Show("Thêm phiếu nhập kho thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
                CheckBoxTaoSoPhieu.Checked = false;
            }
        }



        private void btnXoa_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

       
        private void frmTimPhieuNhapKho_TimKiemSP(string sophieu, DateTime ngaylap, string nhacungcap, string manhanvien, string ID)
        {
            //throw new NotImplementedException();

            txtSoPhieu.Text = sophieu;
            dateTimePicker1.Value = ngaylap;
            cbMaNhanVien.Text = manhanvien;
            //txtGhiChu.Text = ghichu;
            lbID.Text = ID;
        }

      
       
        private void dgvThongTinSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
