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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
            txtNgaySinh.Mask = "00/00/0000";
            txtNgaySinh.KeyUp += new KeyEventHandler(msDate_KeyUp);
        }

        // Kiểm tra tính hợp lệ của ngày tháng năm sinh
 
      void msDate_KeyUp(object sender, KeyEventArgs e)
      {
          if (txtNgaySinh.MaskFull)
         {
            try
            {
                DateTime.ParseExact(txtNgaySinh.Text, "dd/MM/yyyy", null);
            }
            catch
            {
                MessageBox.Show("Ngày không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               txtNgaySinh.ResetText();
            }
         }
      }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            txtMaNhanVien.Focus();
            lbID.Visible = false;
            load_NhanVien();
            cbGioiTinh.Items.Add("Nam");
            cbGioiTinh.Items.Add("Nữ");
            cbGioiTinh.SelectedIndex = 0; 
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                string GetID = "SELECT TOP(1) * FROM tblNHANVIEN ORDER BY IDNhanVien DESC";
                var dt_GetID = Dataconn.DataTable_Sql(GetID);
                int _ID = 1001;
                if (dt_GetID.Rows.Count > 0)
                {
                    _ID = 1000 + (Convert.ToInt32(dt_GetID.Rows[0]["IDNhanVien"].ToString()));
                }
                txtMaNhanVien.Text = "NV" + DateTime.Now.ToString("ddMMyy") + _ID;
            }
            else
            {
                txtMaNhanVien.ResetText();
            }
        }

        private void load_NhanVien()
        {
            string kv = "SELECT MaNhanVien,TenNhanVien,GioiTinh,NgaySinh,DienThoai,DiaChi,GhiChu,IDNhanVien FROM tblNHANVIEN ORDER BY IDNhanVien DESC";
            var dt_kv = Dataconn.DataTable_Sql(kv);
            if (dt_kv.Rows.Count > 0)
            {
                dgvNhanVien.DataSource = dt_kv;
            }
            else
            {
                MessageBox.Show("Không có bản ghi nào!");
            }
        }

        private void Xoa_txt()
        {
            txtMaNhanVien.ResetText();
            txtTenNhanVien.ResetText();
            txtDiaChi.ResetText();
            txtDienThoai.ResetText();
            txtNgaySinh.ResetText();
            txtGhiChu.ResetText();
            cbGioiTinh.SelectedIndex = 0; 
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text != "" && txtTenNhanVien.Text != "" && txtNgaySinh.Text != "")
            {
                var ktra_ID = Dataconn.DataTable_Sql("SELECT * FROM tblNHANVIEN WHERE MaNhanVien='" + txtMaNhanVien.Text.Trim() + "'");
                if (ktra_ID.Rows.Count > 0)
                {

                    MessageBox.Show("Trùng mã nhân viên, hãy kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaNhanVien.ResetText();
                    txtMaNhanVien.Focus();
                }
                else
                {
                    string test = txtNgaySinh.Text.Replace("/", "").Trim();
                    string ngaySinh="";
                    if (test == "") ngaySinh = "NULL";
                    else ngaySinh = "'"+Convert.ToDateTime(txtNgaySinh.Text).ToString("yyyyMMdd")+"'";
                        
                    //DateTime ngaysinh = Convert.ToDateTime(txtNgaySinh.Text);
                    string insert = "INSERT INTO tblNHANVIEN(MaNhanVien,TenNhanVien,DiaChi,DienThoai,NgaySinh,GioiTinh,GhiChu) VALUES(";
                    insert += "N'" + txtMaNhanVien.Text + "',N'" + txtTenNhanVien.Text + "',N'" + txtDiaChi.Text + "',N'" + txtDienThoai.Text + "'," + ngaySinh + ", N'" + cbGioiTinh.SelectedItem.ToString() + "',N'" + txtGhiChu.Text + "')";
                    Dataconn.Execute_NonSQL(insert);
                    MessageBox.Show("Thêm mới bản ghi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load_NhanVien();
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
            if (txtMaNhanVien.Text.Trim() != "" && txtTenNhanVien.Text.Trim() != "")
            {
                DateTime ngaysinh = Convert.ToDateTime(txtNgaySinh.Text);
                string update = "Update tblNHANVIEN SET MaNhanVien=N'" + txtMaNhanVien.Text + "',TenNhanVien=N'" + txtTenNhanVien.Text + "',GioiTinh=N'" + cbGioiTinh.SelectedItem.ToString() + "', NgaySinh='" + ngaysinh.ToString("yyyyMMdd") + "', DienThoai='" + txtDienThoai.Text + "', DiaChi=N'" + txtDiaChi.Text + "',GhiChu=N'" + txtGhiChu.Text + "'   where  IDNhanVien='" + lbID.Text + "' ";
                Dataconn.Execute_NonSQL(update);
                MessageBox.Show("Sửa bản ghi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_NhanVien();
                Xoa_txt();
            }
            else
            {
                MessageBox.Show("Chưa có bản ghi được chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            checkBox1.Checked = false;
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lbID.Text = dgvNhanVien.Rows[e.RowIndex].Cells["IDNhanVien"].Value.ToString();
                txtMaNhanVien.Text = dgvNhanVien.Rows[e.RowIndex].Cells["MaNhanVien"].Value.ToString();
                txtTenNhanVien.Text = dgvNhanVien.Rows[e.RowIndex].Cells["TenNhanVien"].Value.ToString();
                cbGioiTinh.Text = dgvNhanVien.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString();
                txtNgaySinh.Text = dgvNhanVien.Rows[e.RowIndex].Cells["NgaySinh"].Value.ToString();
                txtDienThoai.Text = dgvNhanVien.Rows[e.RowIndex].Cells["DienThoai"].Value.ToString();
                txtDiaChi.Text = dgvNhanVien.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
                txtGhiChu.Text = dgvNhanVien.Rows[e.RowIndex].Cells["GhiChu"].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text != "" && txtTenNhanVien.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string delete = "delete tblNHANVIEN where IDNhanVien='" + lbID.Text + "'";
                    Dataconn.Execute_NonSQL(delete);
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load_NhanVien();
                    Xoa_txt();
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn bản ghi để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            checkBox1.Checked = false;
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            Xoa_txt();
            checkBox1.Checked = false;
            txtMaNhanVien.Focus();
        }

        private void txtMaNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtTenNhanVien.Focus();

            }
        }

        private void checkBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtTenNhanVien.Focus();

            }
        }

        private void txtTenNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtDienThoai.Focus();

            }
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cbGioiTinh.Focus();

            }
        }

        private void cbGioiTinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtNgaySinh.Focus();

            }
        }

        private void txtNgaySinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtDiaChi.Focus();

            }
        }

        private void txtDiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtGhiChu.Focus();

            }
        }

        private void txtDienThoai_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            if (!string.IsNullOrEmpty(txtDienThoai.Text) &&
                 !int.TryParse(txtDienThoai.Text, out i)
              )
            {
                MessageBox.Show("Vui lòng nhập số!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDienThoai.ResetText();
            }
        }

        private void txtNgaySinh_TextChanged(object sender, EventArgs e)
        {
            //int i = 0;
            //if (!string.IsNullOrEmpty(txtNgaySinh.Text) &&
            //     !int.TryParse(txtNgaySinh.Text, out i)
            //  )
            //{
            //    MessageBox.Show("Vui lòng nhập số!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtNgaySinh.Text = "";
            //}
        }



    }
}
