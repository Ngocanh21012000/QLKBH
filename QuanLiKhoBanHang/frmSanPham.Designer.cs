namespace QuanLiKhoBanHang
{
    partial class frmSanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSanPham));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonX6 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX5 = new DevComponents.DotNetBar.ButtonX();
            this.cbNhaSX = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX22 = new DevComponents.DotNetBar.LabelX();
            this.cbLoaisp = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtGiaBanLe = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtGiaNhap = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtGhiChu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenSanPham = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMasp = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX21 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.labelX17 = new DevComponents.DotNetBar.LabelX();
            this.labelX16 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX15 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.lbID = new System.Windows.Forms.Label();
            this.txtTimKiem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbTimKiem = new DevComponents.DotNetBar.LabelX();
            this.txttugia = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbTu = new DevComponents.DotNetBar.LabelX();
            this.lbDen = new DevComponents.DotNetBar.LabelX();
            this.txtdengia = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbTheogia = new DevComponents.DotNetBar.LabelX();
            this.btnTimKiem = new DevComponents.DotNetBar.ButtonX();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.btnSua = new DevComponents.DotNetBar.ButtonX();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnNhapLai = new DevComponents.DotNetBar.ButtonX();
            this.dgvSanPham = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBanLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(545, 28);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(95, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "SẢN PHẨM";
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.checkBox1);
            this.groupPanel1.Controls.Add(this.buttonX6);
            this.groupPanel1.Controls.Add(this.buttonX5);
            this.groupPanel1.Controls.Add(this.cbNhaSX);
            this.groupPanel1.Controls.Add(this.labelX22);
            this.groupPanel1.Controls.Add(this.cbLoaisp);
            this.groupPanel1.Controls.Add(this.txtGiaBanLe);
            this.groupPanel1.Controls.Add(this.txtGiaNhap);
            this.groupPanel1.Controls.Add(this.txtGhiChu);
            this.groupPanel1.Controls.Add(this.txtTenSanPham);
            this.groupPanel1.Controls.Add(this.txtMasp);
            this.groupPanel1.Controls.Add(this.labelX21);
            this.groupPanel1.Controls.Add(this.labelX8);
            this.groupPanel1.Controls.Add(this.labelX14);
            this.groupPanel1.Controls.Add(this.labelX17);
            this.groupPanel1.Controls.Add(this.labelX16);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.labelX15);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel1.Location = new System.Drawing.Point(174, 85);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(825, 199);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 4;
            this.groupPanel1.Text = "Thông tin sản phẩm";
            this.groupPanel1.Click += new System.EventHandler(this.groupPanel1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(275, 22);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(75, 17);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "Tạo mã?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkBox1_KeyPress);
            // 
            // buttonX6
            // 
            this.buttonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX6.Image = ((System.Drawing.Image)(resources.GetObject("buttonX6.Image")));
            this.buttonX6.Location = new System.Drawing.Point(674, 22);
            this.buttonX6.Name = "buttonX6";
            this.buttonX6.Size = new System.Drawing.Size(30, 23);
            this.buttonX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX6.TabIndex = 20;
            this.buttonX6.Click += new System.EventHandler(this.buttonX6_Click);
            // 
            // buttonX5
            // 
            this.buttonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX5.Image = ((System.Drawing.Image)(resources.GetObject("buttonX5.Image")));
            this.buttonX5.Location = new System.Drawing.Point(308, 78);
            this.buttonX5.Name = "buttonX5";
            this.buttonX5.Size = new System.Drawing.Size(30, 23);
            this.buttonX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX5.TabIndex = 20;
            this.buttonX5.Click += new System.EventHandler(this.buttonX5_Click);
            // 
            // cbNhaSX
            // 
            this.cbNhaSX.DisplayMember = "Text";
            this.cbNhaSX.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbNhaSX.FormattingEnabled = true;
            this.cbNhaSX.ItemHeight = 15;
            this.cbNhaSX.Location = new System.Drawing.Point(483, 24);
            this.cbNhaSX.Name = "cbNhaSX";
            this.cbNhaSX.Size = new System.Drawing.Size(151, 21);
            this.cbNhaSX.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbNhaSX.TabIndex = 16;
            this.cbNhaSX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbNhaSX_KeyPress);
            // 
            // labelX22
            // 
            // 
            // 
            // 
            this.labelX22.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX22.Location = new System.Drawing.Point(54, 78);
            this.labelX22.Name = "labelX22";
            this.labelX22.Size = new System.Drawing.Size(85, 23);
            this.labelX22.TabIndex = 4;
            this.labelX22.Text = "Loại sản phẩm";
            // 
            // cbLoaisp
            // 
            this.cbLoaisp.DisplayMember = "Text";
            this.cbLoaisp.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLoaisp.FormattingEnabled = true;
            this.cbLoaisp.ItemHeight = 15;
            this.cbLoaisp.Location = new System.Drawing.Point(152, 78);
            this.cbLoaisp.Name = "cbLoaisp";
            this.cbLoaisp.Size = new System.Drawing.Size(151, 21);
            this.cbLoaisp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbLoaisp.TabIndex = 15;
            this.cbLoaisp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbNhomSP_KeyPress);
            // 
            // txtGiaBanLe
            // 
            // 
            // 
            // 
            this.txtGiaBanLe.Border.Class = "TextBoxBorder";
            this.txtGiaBanLe.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGiaBanLe.Location = new System.Drawing.Point(663, 52);
            this.txtGiaBanLe.Name = "txtGiaBanLe";
            this.txtGiaBanLe.PreventEnterBeep = true;
            this.txtGiaBanLe.Size = new System.Drawing.Size(103, 20);
            this.txtGiaBanLe.TabIndex = 20;
            this.txtGiaBanLe.TextChanged += new System.EventHandler(this.txtGiaBanLe_TextChanged);
            this.txtGiaBanLe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaBanLe_KeyPress);
            // 
            // txtGiaNhap
            // 
            // 
            // 
            // 
            this.txtGiaNhap.Border.Class = "TextBoxBorder";
            this.txtGiaNhap.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGiaNhap.Location = new System.Drawing.Point(483, 54);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.PreventEnterBeep = true;
            this.txtGiaNhap.Size = new System.Drawing.Size(103, 20);
            this.txtGiaNhap.TabIndex = 19;
            this.txtGiaNhap.TextChanged += new System.EventHandler(this.textBoxX3_TextChanged);
            this.txtGiaNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxX3_KeyPress);
            // 
            // txtGhiChu
            // 
            // 
            // 
            // 
            this.txtGhiChu.Border.Class = "TextBoxBorder";
            this.txtGhiChu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGhiChu.Location = new System.Drawing.Point(474, 107);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.PreventEnterBeep = true;
            this.txtGhiChu.Size = new System.Drawing.Size(286, 51);
            this.txtGhiChu.TabIndex = 25;
            // 
            // txtTenSanPham
            // 
            // 
            // 
            // 
            this.txtTenSanPham.Border.Class = "TextBoxBorder";
            this.txtTenSanPham.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenSanPham.Location = new System.Drawing.Point(152, 50);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.PreventEnterBeep = true;
            this.txtTenSanPham.Size = new System.Drawing.Size(151, 20);
            this.txtTenSanPham.TabIndex = 14;
            this.txtTenSanPham.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenSanPham_KeyPress);
            // 
            // txtMasp
            // 
            // 
            // 
            // 
            this.txtMasp.Border.Class = "TextBoxBorder";
            this.txtMasp.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMasp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMasp.Location = new System.Drawing.Point(152, 18);
            this.txtMasp.Name = "txtMasp";
            this.txtMasp.PreventEnterBeep = true;
            this.txtMasp.Size = new System.Drawing.Size(117, 22);
            this.txtMasp.TabIndex = 13;
            this.txtMasp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMasp_KeyPress);
            // 
            // labelX21
            // 
            // 
            // 
            // 
            this.labelX21.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX21.Location = new System.Drawing.Point(406, 51);
            this.labelX21.Name = "labelX21";
            this.labelX21.Size = new System.Drawing.Size(62, 23);
            this.labelX21.TabIndex = 7;
            this.labelX21.Text = "Giá nhập";
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX8.Location = new System.Drawing.Point(601, 50);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(54, 23);
            this.labelX8.TabIndex = 6;
            this.labelX8.Text = "Giá bán";
            // 
            // labelX14
            // 
            // 
            // 
            // 
            this.labelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX14.Location = new System.Drawing.Point(406, 107);
            this.labelX14.Name = "labelX14";
            this.labelX14.SingleLineColor = System.Drawing.SystemColors.Control;
            this.labelX14.Size = new System.Drawing.Size(62, 23);
            this.labelX14.TabIndex = 9;
            this.labelX14.Text = "Ghi chú";
            // 
            // labelX17
            // 
            // 
            // 
            // 
            this.labelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX17.Location = new System.Drawing.Point(388, 24);
            this.labelX17.Name = "labelX17";
            this.labelX17.Size = new System.Drawing.Size(75, 23);
            this.labelX17.TabIndex = 9;
            this.labelX17.Text = "Nhà sản xuất";
            this.labelX17.Click += new System.EventHandler(this.labelX17_Click);
            // 
            // labelX16
            // 
            // 
            // 
            // 
            this.labelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX16.Location = new System.Drawing.Point(54, 49);
            this.labelX16.Name = "labelX16";
            this.labelX16.Size = new System.Drawing.Size(75, 23);
            this.labelX16.TabIndex = 10;
            this.labelX16.Text = "Tên sản phẩm";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(388, 24);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 9;
            this.labelX5.Text = "Nhà sản xuất";
            // 
            // labelX15
            // 
            // 
            // 
            // 
            this.labelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX15.Location = new System.Drawing.Point(54, 18);
            this.labelX15.Name = "labelX15";
            this.labelX15.Size = new System.Drawing.Size(75, 23);
            this.labelX15.TabIndex = 11;
            this.labelX15.Text = "Mã sản phẩm";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(54, 46);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 10;
            this.labelX4.Text = "Tên sản phẩm";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(54, 15);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 11;
            this.labelX2.Text = "Mã sản phẩm";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(123, 18);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(30, 13);
            this.lbID.TabIndex = 26;
            this.lbID.Text = "lbID";
            // 
            // txtTimKiem
            // 
            // 
            // 
            // 
            this.txtTimKiem.Border.Class = "TextBoxBorder";
            this.txtTimKiem.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(929, 15);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PreventEnterBeep = true;
            this.txtTimKiem.Size = new System.Drawing.Size(142, 20);
            this.txtTimKiem.TabIndex = 31;
            // 
            // lbTimKiem
            // 
            // 
            // 
            // 
            this.lbTimKiem.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimKiem.Location = new System.Drawing.Point(831, 12);
            this.lbTimKiem.Name = "lbTimKiem";
            this.lbTimKiem.Size = new System.Drawing.Size(91, 23);
            this.lbTimKiem.TabIndex = 32;
            this.lbTimKiem.Text = "Thông tin tìm kiếm";
            // 
            // txttugia
            // 
            // 
            // 
            // 
            this.txttugia.Border.Class = "TextBoxBorder";
            this.txttugia.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txttugia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttugia.Location = new System.Drawing.Point(975, 49);
            this.txttugia.Name = "txttugia";
            this.txttugia.PreventEnterBeep = true;
            this.txttugia.Size = new System.Drawing.Size(78, 20);
            this.txttugia.TabIndex = 34;
            this.txttugia.TextChanged += new System.EventHandler(this.txttugia_TextChanged);
            // 
            // lbTu
            // 
            // 
            // 
            // 
            this.lbTu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTu.Location = new System.Drawing.Point(953, 48);
            this.lbTu.Name = "lbTu";
            this.lbTu.Size = new System.Drawing.Size(16, 23);
            this.lbTu.TabIndex = 36;
            this.lbTu.Text = "Từ";
            // 
            // lbDen
            // 
            // 
            // 
            // 
            this.lbDen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDen.Location = new System.Drawing.Point(1061, 48);
            this.lbDen.Name = "lbDen";
            this.lbDen.Size = new System.Drawing.Size(25, 23);
            this.lbDen.TabIndex = 37;
            this.lbDen.Text = "đến";
            // 
            // txtdengia
            // 
            // 
            // 
            // 
            this.txtdengia.Border.Class = "TextBoxBorder";
            this.txtdengia.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdengia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdengia.Location = new System.Drawing.Point(1088, 50);
            this.txtdengia.Name = "txtdengia";
            this.txtdengia.PreventEnterBeep = true;
            this.txtdengia.Size = new System.Drawing.Size(79, 20);
            this.txtdengia.TabIndex = 38;
            this.txtdengia.TextChanged += new System.EventHandler(this.txtdengia_TextChanged);
            // 
            // lbTheogia
            // 
            // 
            // 
            // 
            this.lbTheogia.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbTheogia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTheogia.Location = new System.Drawing.Point(895, 47);
            this.lbTheogia.Name = "lbTheogia";
            this.lbTheogia.Size = new System.Drawing.Size(49, 23);
            this.lbTheogia.TabIndex = 39;
            this.lbTheogia.Text = "Theo giá";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTimKiem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = global::QuanLiKhoBanHang.Properties.Resources.if_Search_278771;
            this.btnTimKiem.Location = new System.Drawing.Point(1079, 13);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(88, 23);
            this.btnTimKiem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTimKiem.TabIndex = 30;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::QuanLiKhoBanHang.Properties.Resources.if_Save_27876;
            this.btnThem.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btnThem.Location = new System.Drawing.Point(361, 301);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(72, 35);
            this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThem.TabIndex = 22;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::QuanLiKhoBanHang.Properties.Resources.if_Edit_27845__1_;
            this.btnSua.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btnSua.Location = new System.Drawing.Point(485, 301);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(65, 35);
            this.btnSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSua.TabIndex = 23;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::QuanLiKhoBanHang.Properties.Resources.if_Remove_278741;
            this.btnXoa.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btnXoa.Location = new System.Drawing.Point(602, 301);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(66, 35);
            this.btnXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoa.TabIndex = 24;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNhapLai.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNhapLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapLai.Image = global::QuanLiKhoBanHang.Properties.Resources.if_Synchronize_27883;
            this.btnNhapLai.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btnNhapLai.Location = new System.Drawing.Point(723, 301);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(81, 35);
            this.btnNhapLai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNhapLai.TabIndex = 25;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSanPham,
            this.TenSanPham,
            this.TenLoaiSanPham,
            this.TenNSX,
            this.GiaNhap,
            this.GiaBanLe,
            this.trangthai,
            this.GhiChu});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSanPham.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSanPham.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvSanPham.Location = new System.Drawing.Point(61, 342);
            this.dgvSanPham.MultiSelect = false;
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSanPham.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(992, 274);
            this.dgvSanPham.TabIndex = 6;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            this.dgvSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellContentClick);
            // 
            // MaSanPham
            // 
            this.MaSanPham.DataPropertyName = "MaSanPham";
            this.MaSanPham.HeaderText = "Mã sản phẩm";
            this.MaSanPham.Name = "MaSanPham";
            this.MaSanPham.ReadOnly = true;
            // 
            // TenSanPham
            // 
            this.TenSanPham.DataPropertyName = "TenSanPham";
            this.TenSanPham.HeaderText = "Tên sản phẩm";
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.ReadOnly = true;
            this.TenSanPham.Width = 200;
            // 
            // TenLoaiSanPham
            // 
            this.TenLoaiSanPham.DataPropertyName = "TenLoaiSanPham";
            this.TenLoaiSanPham.HeaderText = "Loại sản phẩm";
            this.TenLoaiSanPham.Name = "TenLoaiSanPham";
            this.TenLoaiSanPham.ReadOnly = true;
            // 
            // TenNSX
            // 
            this.TenNSX.DataPropertyName = "TenNSX";
            this.TenNSX.HeaderText = "Tên nhà sản xuất";
            this.TenNSX.Name = "TenNSX";
            this.TenNSX.ReadOnly = true;
            this.TenNSX.Width = 150;
            // 
            // GiaNhap
            // 
            this.GiaNhap.DataPropertyName = "GiaNhap";
            dataGridViewCellStyle2.Format = "C0";
            dataGridViewCellStyle2.NullValue = null;
            this.GiaNhap.DefaultCellStyle = dataGridViewCellStyle2;
            this.GiaNhap.HeaderText = "Giá nhập";
            this.GiaNhap.Name = "GiaNhap";
            this.GiaNhap.ReadOnly = true;
            // 
            // GiaBanLe
            // 
            this.GiaBanLe.DataPropertyName = "GiaBanLe";
            dataGridViewCellStyle3.Format = "C0";
            dataGridViewCellStyle3.NullValue = null;
            this.GiaBanLe.DefaultCellStyle = dataGridViewCellStyle3;
            this.GiaBanLe.HeaderText = "Giá bán";
            this.GiaBanLe.Name = "GiaBanLe";
            this.GiaBanLe.ReadOnly = true;
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "trangthai";
            this.trangthai.HeaderText = "Trạng thái";
            this.trangthai.Name = "trangthai";
            this.trangthai.ReadOnly = true;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            // 
            // frmSanPham
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1191, 675);
            this.Controls.Add(this.lbTheogia);
            this.Controls.Add(this.txtdengia);
            this.Controls.Add(this.lbDen);
            this.Controls.Add(this.lbTu);
            this.Controls.Add(this.txttugia);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.lbTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnNhapLai);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sản Phẩm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSanPham_FormClosing);
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbNhaSX;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbLoaisp;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGiaBanLe;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGiaNhap;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenSanPham;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMasp;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX buttonX6;
        private DevComponents.DotNetBar.ButtonX buttonX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGhiChu;
        private DevComponents.DotNetBar.LabelX labelX14;
        private System.Windows.Forms.CheckBox checkBox1;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private DevComponents.DotNetBar.ButtonX btnSua;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.ButtonX btnNhapLai;
        private DevComponents.DotNetBar.LabelX labelX22;
        private DevComponents.DotNetBar.LabelX labelX21;
        private DevComponents.DotNetBar.LabelX labelX17;
        private DevComponents.DotNetBar.LabelX labelX16;
        private DevComponents.DotNetBar.LabelX labelX15;
        private System.Windows.Forms.Label lbID;
        private DevComponents.DotNetBar.ButtonX btnTimKiem;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTimKiem;
        private DevComponents.DotNetBar.LabelX lbTimKiem;
        private DevComponents.DotNetBar.Controls.TextBoxX txttugia;
        private DevComponents.DotNetBar.LabelX lbTu;
        private DevComponents.DotNetBar.LabelX lbDen;
        private DevComponents.DotNetBar.Controls.TextBoxX txtdengia;
        private DevComponents.DotNetBar.LabelX lbTheogia;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBanLe;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}