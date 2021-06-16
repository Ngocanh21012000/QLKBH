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
    public partial class frmTimMaSanPham : Form
    {
        public delegate void TimKiemSP(string ma, string ten);
        public event TimKiemSP TimKiem;

        public frmTimMaSanPham()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Trim() != "")
            {
                var timkiemsp = " SELECT MaSanPham, TenSanPham, SoLuong, GiaNhap, GiaBanLe, GhiChu FROM tblSANPHAM WHERE MaSanPham LIKE N'%" + txtTimKiem.Text + "%' OR TenSanPham LIKE N'%" + txtTimKiem.Text + "%' OR SoLuong LIKE N'%" + txtTimKiem.Text + "%' OR GiaBanLe LIKE N'%" + txtTimKiem.Text + "%' OR GiaNhap LIKE N'%" + txtTimKiem.Text + "%' OR GhiChu LIKE N'%" + txtTimKiem.Text + "%' ";
                var dt_timkiemsp = Dataconn.DataTable_Sql(timkiemsp);
                if (dt_timkiemsp.Rows.Count > 0)
                {
                    dgvTimKiemMaSanPham.DataSource = dt_timkiemsp;
                    txtTimKiem.Text = "";
                }
                else
                {
                    MessageBox.Show("Chưa có thông tin sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtTimKiem.Text = "";
                    //dgvTimKiemMaSanPham.DataSource = "";
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập thông tin sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmTimMaSanPham_Load(object sender, EventArgs e)
        {
            txtTimKiem.Focus();
            Load_SanPham();

        }

        private void Load_SanPham()
        {
            string kv = "SELECT MaSanPham, TenSanPham, SoLuong, GiaNhap, GiaBanLe, GhiChu FROM tblSANPHAM ORDER BY IDSanPham DESC";
            var dt_kv = Dataconn.DataTable_Sql(kv);
            if (dt_kv.Rows.Count > 0)
            {
                dgvTimKiemMaSanPham.DataSource = dt_kv;
            }
            else
            {
                MessageBox.Show("Không có bản ghi nào!");
            }
        }

        private void dgvTimKiemMaSanPham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string maSP = dgvTimKiemMaSanPham.Rows[e.RowIndex].Cells[0].Value.ToString();
            string tenSP = dgvTimKiemMaSanPham.Rows[e.RowIndex].Cells[1].Value.ToString(); 
            TimKiem(maSP, tenSP);
            this.Close();
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnTimKiem.Focus();

            }
        }
    }
}
