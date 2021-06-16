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
    public partial class frmNhaSanXuat : DevComponents.DotNetBar.Office2007Form
    {
        public frmNhaSanXuat()
        {
            InitializeComponent();
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void frmNhaSanXuat_Load(object sender, EventArgs e)
        {
            txtMaNhaSanXuat.Focus();
            lbID.Visible = false;
            load_NhaSanXuat();
        }
        private void load_NhaSanXuat()
        {
            string kv = "select * from tblNHASANXUAT order by IDNSX DESC";
            var dt_kv = Dataconn.DataTable_Sql(kv);
            if (dt_kv.Rows.Count > 0)
            {
                dgvNhaSanXuat.DataSource = dt_kv;
            }
            else
            {
                MessageBox.Show("Không có bản ghi nào!");
            }
        }
        private void Xoa_txt()
        {
            txtMaNhaSanXuat.Text = "";
            txtDiaChi.Text = "";
           
            txtDienThoaiDiDong.Text = "";
            txtEmail.Text = "";
           
            txtTenNhaSanXuat.Text = "";
            
        }

        

        private void dgvNhaSanXuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }
        private void dgvNhaSanXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lbID.Text = dgvNhaSanXuat.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtMaNhaSanXuat.Text = dgvNhaSanXuat.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTenNhaSanXuat.Text = dgvNhaSanXuat.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDiaChi.Text = dgvNhaSanXuat.Rows[e.RowIndex].Cells[3].Value.ToString();
               
                txtDienThoaiDiDong.Text = dgvNhaSanXuat.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtEmail.Text = dgvNhaSanXuat.Rows[e.RowIndex].Cells[6].Value.ToString();
                
            }
            catch
            {

            }
        }
        

        private void txtMaNhaSanXuat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtTenNhaSanXuat.Focus();

            }
        }

        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                string GetID = "SELECT TOP(1) * FROM tblNHASANXUAT ORDER BY IDNSX DESC";
                var dt_GetID = Dataconn.DataTable_Sql(GetID);
                int _ID = 1001;
                if (dt_GetID.Rows.Count > 0)
                {
                    _ID = 1000 + (Convert.ToInt32(dt_GetID.Rows[0]["IDNSX"].ToString()));
                }
                txtMaNhaSanXuat.Text = "NSX" + DateTime.Now.ToString("ddMMyy") + _ID;
            }
            else
            {
                txtMaNhaSanXuat.Text = "";
            }
        }

        public delegate void AddEventhander();
        public event AddEventhander AddNhaSanXuat;

        private void frmNhaSanXuat_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (AddNhaSanXuat != null)
            AddNhaSanXuat();
        }

        private void checkBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtTenNhaSanXuat.Focus();

            }
        }

        private void txtTenNhaSanXuat_KeyPress(object sender, KeyPressEventArgs e)
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
                txtDienThoaiDiDong.Focus();
            }
        }

    

        private void txtDienThoaiDiDong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtEmail.Focus();
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

   
        private void Xoa_txt_DienThoaiDD()
        {
            txtDienThoaiDiDong.Text = "";
        }
        private void txtDienThoaiDiDong_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNhaSanXuat.Text.Trim() != "" && txtTenNhaSanXuat.Text.Trim() != "")
            {
                var ktra_ID = Dataconn.DataTable_Sql("SELECT * FROM tblNHASANXUAT WHERE MaNSX='" + txtMaNhaSanXuat.Text.Trim() + "'");
                if (ktra_ID.Rows.Count > 0)
                {

                    MessageBox.Show("Trùng mã nhà sản xuất, hãy kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtMaNhaSanXuat.Text = "";
                    txtMaNhaSanXuat.Focus();
                }
                else
                {
                    string insert = "insert into tblNHASANXUAT(MaNSX,TenNSX,DiaChi,DienThoaiDD,Email) VALUES(";
                    insert += "N'" + txtMaNhaSanXuat.Text.Trim() + "',N'" + txtTenNhaSanXuat.Text.Trim() + "',N'" + txtDiaChi.Text.Trim()  + "',N'" + txtDienThoaiDiDong.Text.Trim() + "',N'" + txtEmail.Text.Trim()  + "')";
                    Dataconn.Execute_NonSQL(insert);
                    MessageBox.Show("Thêm mới bản ghi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load_NhaSanXuat();
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
            if (txtMaNhaSanXuat.Text.Trim() != "" && txtTenNhaSanXuat.Text.Trim() != "")
            {
                string update = "Update tblNHASANXUAT SET MaNSX=N'" + txtMaNhaSanXuat.Text.Trim() + "',TenNSX=N'" + txtTenNhaSanXuat.Text.Trim() + "',DiaChi=N'" + txtDiaChi.Text.Trim()  + "',DienThoaiDD=N'" + txtDienThoaiDiDong.Text.Trim() + "',Email=N'" + txtEmail.Text.Trim() + "'   where  IDNSX='" + lbID.Text + "' ";
                Dataconn.Execute_NonSQL(update);
                MessageBox.Show("Sửa bản ghi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_NhaSanXuat();
                Xoa_txt();
            }
            else
            {
                MessageBox.Show("Chưa có bản ghi được chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            checkBox1.Checked = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNhaSanXuat.Text != "" && txtTenNhaSanXuat.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string delete = "delete tblNHASANXUAT where IDNSX='" + lbID.Text + "'";
                    Dataconn.Execute_NonSQL(delete);
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load_NhaSanXuat();
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
        }

       
    }
}