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
