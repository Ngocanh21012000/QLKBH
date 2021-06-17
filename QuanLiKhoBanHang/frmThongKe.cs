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
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            //dateTimePicker1.Visible = true;
            //dateTimePicker1.Value = DateTime.Today;
            //dateTimePicker2.Visible = true;
            //dateTimePicker2.Value = DateTime.Today;
        }

        private void rdTonKhoHienTai_CheckedChanged(object sender, EventArgs e)
        {
            if (rdTonKhoHienTai.Checked == true)
            {
                
                txtTimKiem.Visible = true;
                txtTimKiem.Text = "";
                txtTimKiem.Focus();
            }
        }

       
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (rdTonKhoHienTai.Checked == true)
            {
                if (txtTimKiem.Text == "")
                {
                    string timkiem = "SELECT nhap.MaSanPham, nhap.TenSanPham, nhap.SoLuongNhap, xuat.SoLuongXuat, (ISNULL(SoLuongNhap,0) - ISNULL(SoLuongXuat,0)) as SoLuongTon FROM (SELECT tblNHAPKHO_K.MaSanPham, tblNHAPKHO_K.TenSanPham, SUM(tblNHAPKHO_K.SoLuong) as SoLuongNhap FROM tblNHAPKHO_K GROUP BY tblNHAPKHO_K.MaSanPham, tblNHAPKHO_K.TenSanPham) as nhap LEFT JOIN (SELECT tblXUATKHO_K.MaSanPham, SUM(tblXUATKHO_K.SoLuong) as SoLuongXuat FROM tblXUATKHO_K GROUP BY tblXUATKHO_K.MaSanPham) as xuat ON nhap.MaSanPham = xuat.MaSanPham ";
                    var dt_timkiem = Dataconn.DataTable_Sql(timkiem);
                    if (dt_timkiem.Rows.Count > 0)
                    {
                        dgvThongTinPhieuNhapKho.DataSource = dt_timkiem;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy bản ghi phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        while (dgvThongTinPhieuNhapKho.Rows.Count > 0)
                        {
                            dgvThongTinPhieuNhapKho.Rows.RemoveAt(0);
                        }
                    }
                }
                else
                {
                    string timkiemTonKho = "SELECT nhap.MaSanPham, nhap.TenSanPham, nhap.SoLuongNhap, xuat.SoLuongXuat, (ISNULL(SoLuongNhap,0) - ISNULL(SoLuongXuat,0)) as SoLuongTon FROM (SELECT tblNHAPKHO_K.MaSanPham, tblNHAPKHO_K.TenSanPham, SUM(tblNHAPKHO_K.SoLuong) as SoLuongNhap FROM tblNHAPKHO_K GROUP BY tblNHAPKHO_K.MaSanPham, tblNHAPKHO_K.TenSanPham) as nhap LEFT JOIN (SELECT tblXUATKHO_K.MaSanPham, SUM(tblXUATKHO_K.SoLuong) as SoLuongXuat FROM tblXUATKHO_K GROUP BY tblXUATKHO_K.MaSanPham) as xuat ON nhap.MaSanPham = xuat.MaSanPham WHERE nhap.MaSanPham ='" + txtTimKiem.Text.Trim().Replace("'", "") + "'";
                    var dt_timkiemTonKho = Dataconn.DataTable_Sql(timkiemTonKho);
                    if (dt_timkiemTonKho.Rows.Count > 0)
                    {
                        dgvThongTinPhieuNhapKho.DataSource = dt_timkiemTonKho;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy bản ghi phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        while (dgvThongTinPhieuNhapKho.Rows.Count > 0)
                        {
                            dgvThongTinPhieuNhapKho.Rows.RemoveAt(0);
                        }
                        txtTimKiem.ResetText();
                    }
                }
            }
        }

        private void dgvThongTinPhieuNhapKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
