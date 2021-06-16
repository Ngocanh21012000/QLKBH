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
    public partial class frmAcount : Form
    {
        public frmAcount()
        {
            InitializeComponent();
        }

        private void xoatxt()
        {
            txtMatKhau.ResetText();
            txtTenDangNhap.ResetText();
        }
        private void btnPhanQuyen_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text != "" && txtMatKhau.Text != "")
            {
                var ktra_ID = Dataconn.DataTable_Sql("SELECT * FROM tblDANGNHAP WHERE TenDangNhap='" + txtTenDangNhap.Text.Trim() + "'");
                if (ktra_ID.Rows.Count > 0)
                {
                    txtTenDangNhap.ResetText();
                    txtMatKhau.ResetText();
                    txtTenDangNhap.Focus();
                    Form1 manHinhChinh = new Form1();
                    manHinhChinh.ShowDialog();
                }
                else
                {
      
                    MessageBox.Show(" Đăng nhập thất bại!");
                    xoatxt();
           
                }

            }
            else
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin!");
            } 
        }

        private void txtTenDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtMatKhau.Focus();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmAcount_Load(object sender, EventArgs e)
        {

        }
    }
}
