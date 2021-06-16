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
    public partial class frmLoaiSanPham : DevComponents.DotNetBar.Office2007Form
    {
        public frmLoaiSanPham()
        {
            InitializeComponent();
        }
        public delegate void AddEventhander();
        public event AddEventhander AddLoaiSanPham;
        private void frmLoaiSanPham_Load(object sender, EventArgs e)
        {
            txtMaLoaiSanPham.Focus();
            lbID.Visible = false;
            load_LoaiSanPham();
        }
        private void load_LoaiSanPham()
        {
            string kv = "select * from tblLOAISANPHAM order by IDLoaiSP desc";
            var dt_kv = Dataconn.DataTable_Sql(kv);
            if (dt_kv.Rows.Count > 0)
            {
                dgvLoaiSanPham.DataSource = dt_kv;
            }
            else
            {
                MessageBox.Show("Không có bản ghi nào!");
            }
        }
        private void Xoa_txt()
        {
            txtMaLoaiSanPham.Text = "";
            txtTenLoaiSanPham.Text = "";
            txtMoTa.Text = "";
        }


        

        private void dgvLoaiSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void dgvLoaiSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lbID.Text = dgvLoaiSanPham.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtMaLoaiSanPham.Text = dgvLoaiSanPham.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTenLoaiSanPham.Text = dgvLoaiSanPham.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtMoTa.Text = dgvLoaiSanPham.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch
            {

            }
        }

       

        private void txtMaLoaiSanPham_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtTenLoaiSanPham.Focus();

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                string GetID = "SELECT TOP(1) * FROM tblLOAISANPHAM ORDER BY IDLoaiSP DESC";
                var dt_GetID = Dataconn.DataTable_Sql(GetID);
                int _ID = 1001;
                if (dt_GetID.Rows.Count > 0)
                {
                    _ID = 1000 + (Convert.ToInt32(dt_GetID.Rows[0]["IDLoaiSP"].ToString()));
                }
                txtMaLoaiSanPham.Text = "LSP" + DateTime.Now.ToString("ddMMyy") + _ID;
            }
            else
            {
                txtMaLoaiSanPham.Text = "";
            }
        }

        private void frmLoaiSanPham_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(AddLoaiSanPham != null)
                AddLoaiSanPham();
        }

        private void txtTenLoaiSanPham_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtMoTa.Focus();

            }
        }

        private void checkBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtTenLoaiSanPham.Focus();

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaLoaiSanPham.Text != "" && txtTenLoaiSanPham.Text != "")
            {
                var ktra_ID = Dataconn.DataTable_Sql("SELECT * FROM tblLOAISANPHAM WHERE MaLoaiSanPham='" + txtMaLoaiSanPham.Text.Trim() + "'");
                if (ktra_ID.Rows.Count > 0)
                {

                    MessageBox.Show("Trùng mã loại sản phẩm, hãy kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtMaLoaiSanPham.Text = "";
                    txtMaLoaiSanPham.Focus();
                }
                else
                {
                    string insert = "insert into tblLOAISANPHAM(MaLoaiSanPham,TenLoaiSanPham,Mota) VALUES(";
                    insert += "N'" + txtMaLoaiSanPham.Text + "',N'" + txtTenLoaiSanPham.Text + "',N'" + txtMoTa.Text + "')";
                    Dataconn.Execute_NonSQL(insert);
                    MessageBox.Show("Thêm mới bản ghi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load_LoaiSanPham();
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
            if (txtMaLoaiSanPham.Text.Trim() != "" && txtTenLoaiSanPham.Text.Trim() != "")
            {
                string update = "Update tblLOAISANPHAM SET MaLoaiSanPham=N'" + txtMaLoaiSanPham.Text + "',TenLoaiSanPham=N'" + txtTenLoaiSanPham.Text + "',MoTa=N'" + txtMoTa.Text + "'   where  IDLoaiSP='" + lbID.Text + "' ";
                Dataconn.Execute_NonSQL(update);
                MessageBox.Show("Sửa bản ghi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_LoaiSanPham();
                Xoa_txt();
            }
            else
            {
                MessageBox.Show("Chưa có bản ghi được chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                checkBox1.Checked = false;
            }
            checkBox1.Checked = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaLoaiSanPham.Text != "" && txtTenLoaiSanPham.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string delete = "delete tblLOAISANPHAM where IDLoaiSP='" + lbID.Text + "'";
                    Dataconn.Execute_NonSQL(delete);
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load_LoaiSanPham();
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