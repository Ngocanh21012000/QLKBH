using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace QuanLiKhoBanHang
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static string phanquyen;
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
            KeyDown += new KeyEventHandler(Form_KeyDown);
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                var helperDialog = new Helpers.Helper();
                helperDialog.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void buttonItem4_Click(object sender, EventArgs e)
        {
            frmSanPham frm1 = new frmSanPham();
            if (CheckExitsForm(frm1)) return;            
           // frm1.MdiParent = this;
            frm1.ShowDialog();
        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {           
            //this.Close();
            Application.Exit();
        }
        private bool CheckExitsForm(Form form)
        {
            foreach (var child in this.MdiChildren)
            {
                if (child.Name==form.Name)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }
        private void ActiveChild(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name==name)
                {
                    frm.Activate();
                    break;
                }
            }
        }
       

        private void buttonItem5_Click(object sender, EventArgs e)
        {
            frmLoaiSanPham frmLoaisp = new frmLoaiSanPham();
            if (CheckExitsForm(frmLoaisp)) return;
          // frmLoaisp.MdiParent = this;
            frmLoaisp.ShowDialog();
        }

        private void buttonItem7_Click(object sender, EventArgs e)
        {
            frmNhaSanXuat frmNSX = new frmNhaSanXuat();
            if (CheckExitsForm(frmNSX)) return;
          // frmNSX.MdiParent = this;
            frmNSX.ShowDialog();
        }

       

      

      

        private void buttonItem11_Click(object sender, EventArgs e)
        {
            frmNhapKhoK frmNK = new frmNhapKhoK();
           if (CheckExitsForm(frmNK)) return;
            frmNK.ShowDialog();
        }

        private void buttonItem12_Click(object sender, EventArgs e)
        {
            frmXuatKhoK frmXK = new frmXuatKhoK();
            if (CheckExitsForm(frmXK)) return;
           // frmXK.MdiParent = this;
           frmXK.ShowDialog();
        }

        
     
        
       

        private void buttonItem14_Click(object sender, EventArgs e)
        {
            frmNhanVien frmNV = new frmNhanVien();
            frmNV.ShowDialog();
        }

        private void buttonItem27_Click(object sender, EventArgs e)
        {
            frmThongKe frmTK = new frmThongKe();
            frmTK.ShowDialog();
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            frmAcount frmac = new frmAcount();
            frmac.ShowDialog();
        }

        private void ribbonTabItem3_Click(object sender, EventArgs e)
        {

        }

        private void ribbonTabItem1_Click(object sender, EventArgs e)
        {

        }

        private void ribbonTabItem2_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonItem8_Click(object sender, EventArgs e)
        {
            var helperDialog = new Helpers.Helper();
            helperDialog.ShowDialog();
        }
    }
}
