namespace WindowsFormsApplication1
{
    partial class frmChinh
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChinh));
            this.lvwDSUV = new System.Windows.Forms.ListView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDoiMK = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.mnuNhanUV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXemDSUV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXemDSDC = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXemDSPD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQL_VTTD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThemVT = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXoaVT = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPheDuyetUV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaoTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHuyTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.lblQuyen = new System.Windows.Forms.Label();
            this.grbLoc = new System.Windows.Forms.GroupBox();
            this.cboKinhNghiem = new System.Windows.Forms.ComboBox();
            this.btnXemYeuCau = new System.Windows.Forms.Button();
            this.BtnLocUV = new System.Windows.Forms.Button();
            this.lblKinhNghiem = new System.Windows.Forms.Label();
            this.lblTrinhDo = new System.Windows.Forms.Label();
            this.lblNgoaiNgu = new System.Windows.Forms.Label();
            this.lblViTri = new System.Windows.Forms.Label();
            this.cboNgoaiNgu = new System.Windows.Forms.ComboBox();
            this.cboTrinhDo = new System.Windows.Forms.ComboBox();
            this.cboVTTD = new System.Windows.Forms.ComboBox();
            this.lblDSUV = new System.Windows.Forms.Label();
            this.pnlDSUV = new System.Windows.Forms.Panel();
            this.lblTongUV = new System.Windows.Forms.Label();
            this.txtTongUV = new System.Windows.Forms.TextBox();
            this.pnlXuLy = new System.Windows.Forms.Panel();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnDeXuatUV = new System.Windows.Forms.Button();
            this.btnChuyenDS = new System.Windows.Forms.Button();
            this.btnHuyDC = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menu.SuspendLayout();
            this.grbLoc.SuspendLayout();
            this.pnlDSUV.SuspendLayout();
            this.pnlXuLy.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwDSUV
            // 
            this.lvwDSUV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwDSUV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwDSUV.FullRowSelect = true;
            this.lvwDSUV.GridLines = true;
            listViewItem1.Checked = true;
            listViewItem1.StateImageIndex = 1;
            this.lvwDSUV.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvwDSUV.Location = new System.Drawing.Point(12, 63);
            this.lvwDSUV.Name = "lvwDSUV";
            this.lvwDSUV.Size = new System.Drawing.Size(997, 243);
            this.lvwDSUV.TabIndex = 22;
            this.lvwDSUV.UseCompatibleStateImageBehavior = false;
            this.lvwDSUV.View = System.Windows.Forms.View.Details;
            this.lvwDSUV.DoubleClick += new System.EventHandler(this.lvwDSUV_DoubleClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(878, 17);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(124, 47);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDoiMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMK.Image = ((System.Drawing.Image)(resources.GetObject("btnDoiMK.Image")));
            this.btnDoiMK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoiMK.Location = new System.Drawing.Point(906, 42);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(109, 35);
            this.btnDoiMK.TabIndex = 18;
            this.btnDoiMK.Text = "Đổi mật khẩu";
            this.btnDoiMK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDoiMK.UseVisualStyleBackColor = true;
            // 
            // menu
            // 
            this.menu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNhanUV,
            this.mnuXemDSUV,
            this.mnuQL_VTTD,
            this.mnuPheDuyetUV,
            this.mnuQLNhanVien});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1021, 24);
            this.menu.TabIndex = 19;
            this.menu.Text = "menuStrip1";
            // 
            // mnuNhanUV
            // 
            this.mnuNhanUV.Image = ((System.Drawing.Image)(resources.GetObject("mnuNhanUV.Image")));
            this.mnuNhanUV.Name = "mnuNhanUV";
            this.mnuNhanUV.Size = new System.Drawing.Size(206, 20);
            this.mnuNhanUV.Text = "Nhận Danh Sách Ứng Viên";
            // 
            // mnuXemDSUV
            // 
            this.mnuXemDSUV.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuXemDSDC,
            this.mnuXemDSPD});
            this.mnuXemDSUV.Image = ((System.Drawing.Image)(resources.GetObject("mnuXemDSUV.Image")));
            this.mnuXemDSUV.Name = "mnuXemDSUV";
            this.mnuXemDSUV.Size = new System.Drawing.Size(202, 20);
            this.mnuXemDSUV.Text = "Xem Danh Sách Ứng Viên";
            // 
            // mnuXemDSDC
            // 
            this.mnuXemDSDC.Image = ((System.Drawing.Image)(resources.GetObject("mnuXemDSDC.Image")));
            this.mnuXemDSDC.Name = "mnuXemDSDC";
            this.mnuXemDSDC.Size = new System.Drawing.Size(247, 22);
            this.mnuXemDSDC.Text = "Xem Danh Sách Đề Cử";
            this.mnuXemDSDC.Click += new System.EventHandler(this.mnuXemDSDC_Click);
            // 
            // mnuXemDSPD
            // 
            this.mnuXemDSPD.Image = ((System.Drawing.Image)(resources.GetObject("mnuXemDSPD.Image")));
            this.mnuXemDSPD.Name = "mnuXemDSPD";
            this.mnuXemDSPD.Size = new System.Drawing.Size(247, 22);
            this.mnuXemDSPD.Text = "Xem Danh Sách Phê Duyệt";
            this.mnuXemDSPD.Click += new System.EventHandler(this.mnuXemDSPD_Click);
            // 
            // mnuQL_VTTD
            // 
            this.mnuQL_VTTD.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThemVT,
            this.mnuXoaVT});
            this.mnuQL_VTTD.Image = ((System.Drawing.Image)(resources.GetObject("mnuQL_VTTD.Image")));
            this.mnuQL_VTTD.Name = "mnuQL_VTTD";
            this.mnuQL_VTTD.Size = new System.Drawing.Size(205, 20);
            this.mnuQL_VTTD.Text = "Quản Lý Vị Trí Tuyển Dụng";
            this.mnuQL_VTTD.Click += new System.EventHandler(this.mnuQL_VTTD_Click);
            // 
            // mnuThemVT
            // 
            this.mnuThemVT.Image = ((System.Drawing.Image)(resources.GetObject("mnuThemVT.Image")));
            this.mnuThemVT.Name = "mnuThemVT";
            this.mnuThemVT.Size = new System.Drawing.Size(149, 22);
            this.mnuThemVT.Text = "Thêm Vị Trí";
            this.mnuThemVT.Click += new System.EventHandler(this.mnuThemVT_Click);
            // 
            // mnuXoaVT
            // 
            this.mnuXoaVT.Image = ((System.Drawing.Image)(resources.GetObject("mnuXoaVT.Image")));
            this.mnuXoaVT.Name = "mnuXoaVT";
            this.mnuXoaVT.Size = new System.Drawing.Size(149, 22);
            this.mnuXoaVT.Text = "Xóa Vị Trí";
            // 
            // mnuPheDuyetUV
            // 
            this.mnuPheDuyetUV.Image = ((System.Drawing.Image)(resources.GetObject("mnuPheDuyetUV.Image")));
            this.mnuPheDuyetUV.Name = "mnuPheDuyetUV";
            this.mnuPheDuyetUV.Size = new System.Drawing.Size(165, 20);
            this.mnuPheDuyetUV.Text = "Phê Duyệt Ứng Viên";
            this.mnuPheDuyetUV.Click += new System.EventHandler(this.mnuPheDuyetUV_Click);
            // 
            // mnuQLNhanVien
            // 
            this.mnuQLNhanVien.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTaoTaiKhoan,
            this.mnuHuyTaiKhoan});
            this.mnuQLNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("mnuQLNhanVien.Image")));
            this.mnuQLNhanVien.Name = "mnuQLNhanVien";
            this.mnuQLNhanVien.Size = new System.Drawing.Size(159, 20);
            this.mnuQLNhanVien.Text = "Quản Lý Nhân Viên";
            // 
            // mnuTaoTaiKhoan
            // 
            this.mnuTaoTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("mnuTaoTaiKhoan.Image")));
            this.mnuTaoTaiKhoan.Name = "mnuTaoTaiKhoan";
            this.mnuTaoTaiKhoan.Size = new System.Drawing.Size(169, 22);
            this.mnuTaoTaiKhoan.Text = "Tạo Tài Khoản";
            this.mnuTaoTaiKhoan.Click += new System.EventHandler(this.mnuTaoTaiKhoan_Click);
            // 
            // mnuHuyTaiKhoan
            // 
            this.mnuHuyTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("mnuHuyTaiKhoan.Image")));
            this.mnuHuyTaiKhoan.Name = "mnuHuyTaiKhoan";
            this.mnuHuyTaiKhoan.Size = new System.Drawing.Size(169, 22);
            this.mnuHuyTaiKhoan.Text = "Hủy Tài Khoản";
            this.mnuHuyTaiKhoan.Click += new System.EventHandler(this.mnuHuyTaiKhoan_Click);
            // 
            // lblQuyen
            // 
            this.lblQuyen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuyen.AutoSize = true;
            this.lblQuyen.Location = new System.Drawing.Point(910, 13);
            this.lblQuyen.Name = "lblQuyen";
            this.lblQuyen.Size = new System.Drawing.Size(38, 13);
            this.lblQuyen.TabIndex = 15;
            this.lblQuyen.Text = "Quyền";
            // 
            // grbLoc
            // 
            this.grbLoc.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.grbLoc.Controls.Add(this.cboKinhNghiem);
            this.grbLoc.Controls.Add(this.btnXemYeuCau);
            this.grbLoc.Controls.Add(this.lblQuyen);
            this.grbLoc.Controls.Add(this.btnDoiMK);
            this.grbLoc.Controls.Add(this.BtnLocUV);
            this.grbLoc.Controls.Add(this.lblKinhNghiem);
            this.grbLoc.Controls.Add(this.lblTrinhDo);
            this.grbLoc.Controls.Add(this.lblNgoaiNgu);
            this.grbLoc.Controls.Add(this.lblViTri);
            this.grbLoc.Controls.Add(this.cboNgoaiNgu);
            this.grbLoc.Controls.Add(this.cboTrinhDo);
            this.grbLoc.Controls.Add(this.cboVTTD);
            this.grbLoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbLoc.Location = new System.Drawing.Point(0, 24);
            this.grbLoc.Name = "grbLoc";
            this.grbLoc.Size = new System.Drawing.Size(1021, 91);
            this.grbLoc.TabIndex = 23;
            this.grbLoc.TabStop = false;
            this.grbLoc.Text = "Lọc";
            // 
            // cboKinhNghiem
            // 
            this.cboKinhNghiem.FormattingEnabled = true;
            this.cboKinhNghiem.Location = new System.Drawing.Point(489, 21);
            this.cboKinhNghiem.Name = "cboKinhNghiem";
            this.cboKinhNghiem.Size = new System.Drawing.Size(108, 21);
            this.cboKinhNghiem.TabIndex = 14;
            // 
            // btnXemYeuCau
            // 
            this.btnXemYeuCau.Enabled = false;
            this.btnXemYeuCau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemYeuCau.Image = ((System.Drawing.Image)(resources.GetObject("btnXemYeuCau.Image")));
            this.btnXemYeuCau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemYeuCau.Location = new System.Drawing.Point(48, 48);
            this.btnXemYeuCau.Name = "btnXemYeuCau";
            this.btnXemYeuCau.Size = new System.Drawing.Size(144, 35);
            this.btnXemYeuCau.TabIndex = 12;
            this.btnXemYeuCau.Text = "Xem Yêu cầu";
            this.btnXemYeuCau.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXemYeuCau.UseVisualStyleBackColor = true;
            this.btnXemYeuCau.Click += new System.EventHandler(this.btnXemYeuCau_Click);
            // 
            // BtnLocUV
            // 
            this.BtnLocUV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLocUV.Image = ((System.Drawing.Image)(resources.GetObject("BtnLocUV.Image")));
            this.BtnLocUV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLocUV.Location = new System.Drawing.Point(631, 13);
            this.BtnLocUV.Name = "BtnLocUV";
            this.BtnLocUV.Size = new System.Drawing.Size(74, 33);
            this.BtnLocUV.TabIndex = 10;
            this.BtnLocUV.Text = "Lọc";
            this.BtnLocUV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLocUV.UseVisualStyleBackColor = true;
            this.BtnLocUV.Click += new System.EventHandler(this.BtnLocUV_Click);
            // 
            // lblKinhNghiem
            // 
            this.lblKinhNghiem.AutoSize = true;
            this.lblKinhNghiem.Location = new System.Drawing.Point(488, 5);
            this.lblKinhNghiem.Name = "lblKinhNghiem";
            this.lblKinhNghiem.Size = new System.Drawing.Size(68, 13);
            this.lblKinhNghiem.TabIndex = 13;
            this.lblKinhNghiem.Text = "Kinh nghiệm:";
            // 
            // lblTrinhDo
            // 
            this.lblTrinhDo.AutoSize = true;
            this.lblTrinhDo.Location = new System.Drawing.Point(225, 5);
            this.lblTrinhDo.Name = "lblTrinhDo";
            this.lblTrinhDo.Size = new System.Drawing.Size(51, 13);
            this.lblTrinhDo.TabIndex = 11;
            this.lblTrinhDo.Text = "Trình Độ:";
            // 
            // lblNgoaiNgu
            // 
            this.lblNgoaiNgu.AutoSize = true;
            this.lblNgoaiNgu.Location = new System.Drawing.Point(353, 5);
            this.lblNgoaiNgu.Name = "lblNgoaiNgu";
            this.lblNgoaiNgu.Size = new System.Drawing.Size(59, 13);
            this.lblNgoaiNgu.TabIndex = 9;
            this.lblNgoaiNgu.Text = "Ngoại ngữ:";
            // 
            // lblViTri
            // 
            this.lblViTri.AutoSize = true;
            this.lblViTri.Location = new System.Drawing.Point(45, 5);
            this.lblViTri.Name = "lblViTri";
            this.lblViTri.Size = new System.Drawing.Size(36, 13);
            this.lblViTri.TabIndex = 3;
            this.lblViTri.Text = "Vị Trí:";
            // 
            // cboNgoaiNgu
            // 
            this.cboNgoaiNgu.FormattingEnabled = true;
            this.cboNgoaiNgu.Location = new System.Drawing.Point(354, 21);
            this.cboNgoaiNgu.Name = "cboNgoaiNgu";
            this.cboNgoaiNgu.Size = new System.Drawing.Size(108, 21);
            this.cboNgoaiNgu.TabIndex = 2;
            // 
            // cboTrinhDo
            // 
            this.cboTrinhDo.FormattingEnabled = true;
            this.cboTrinhDo.Location = new System.Drawing.Point(219, 21);
            this.cboTrinhDo.Name = "cboTrinhDo";
            this.cboTrinhDo.Size = new System.Drawing.Size(108, 21);
            this.cboTrinhDo.TabIndex = 1;
            // 
            // cboVTTD
            // 
            this.cboVTTD.FormattingEnabled = true;
            this.cboVTTD.Location = new System.Drawing.Point(48, 21);
            this.cboVTTD.Name = "cboVTTD";
            this.cboVTTD.Size = new System.Drawing.Size(144, 21);
            this.cboVTTD.TabIndex = 0;
            this.cboVTTD.SelectedIndexChanged += new System.EventHandler(this.cboVTTD_SelectedIndexChanged);
            this.cboVTTD.SelectionChangeCommitted += new System.EventHandler(this.cboVTTD_SelectionChangeCommitted);
            // 
            // lblDSUV
            // 
            this.lblDSUV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDSUV.AutoSize = true;
            this.lblDSUV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSUV.Location = new System.Drawing.Point(440, 21);
            this.lblDSUV.Name = "lblDSUV";
            this.lblDSUV.Size = new System.Drawing.Size(170, 20);
            this.lblDSUV.TabIndex = 1;
            this.lblDSUV.Text = "Danh sách Ứng viên";
            // 
            // pnlDSUV
            // 
            this.pnlDSUV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDSUV.BackColor = System.Drawing.Color.LightGreen;
            this.pnlDSUV.Controls.Add(this.lblTongUV);
            this.pnlDSUV.Controls.Add(this.lvwDSUV);
            this.pnlDSUV.Controls.Add(this.txtTongUV);
            this.pnlDSUV.Controls.Add(this.lblDSUV);
            this.pnlDSUV.Location = new System.Drawing.Point(0, 113);
            this.pnlDSUV.Name = "pnlDSUV";
            this.pnlDSUV.Size = new System.Drawing.Size(1021, 349);
            this.pnlDSUV.TabIndex = 24;
            // 
            // lblTongUV
            // 
            this.lblTongUV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTongUV.AutoSize = true;
            this.lblTongUV.Location = new System.Drawing.Point(877, 315);
            this.lblTongUV.Name = "lblTongUV";
            this.lblTongUV.Size = new System.Drawing.Size(81, 13);
            this.lblTongUV.TabIndex = 34;
            this.lblTongUV.Text = "Tổng Ứng viên:";
            // 
            // txtTongUV
            // 
            this.txtTongUV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTongUV.Location = new System.Drawing.Point(967, 312);
            this.txtTongUV.Name = "txtTongUV";
            this.txtTongUV.ReadOnly = true;
            this.txtTongUV.Size = new System.Drawing.Size(42, 20);
            this.txtTongUV.TabIndex = 33;
            // 
            // pnlXuLy
            // 
            this.pnlXuLy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlXuLy.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlXuLy.Controls.Add(this.btnLuu);
            this.pnlXuLy.Controls.Add(this.btnDeXuatUV);
            this.pnlXuLy.Controls.Add(this.btnChuyenDS);
            this.pnlXuLy.Controls.Add(this.btnThoat);
            this.pnlXuLy.Controls.Add(this.btnHuyDC);
            this.pnlXuLy.Location = new System.Drawing.Point(0, 461);
            this.pnlXuLy.Name = "pnlXuLy";
            this.pnlXuLy.Size = new System.Drawing.Size(1021, 92);
            this.pnlXuLy.TabIndex = 26;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(260, 16);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(130, 47);
            this.btnLuu.TabIndex = 17;
            this.btnLuu.TabStop = false;
            this.btnLuu.Text = "Lưu Danh Sách";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnDeXuatUV
            // 
            this.btnDeXuatUV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeXuatUV.AutoSize = true;
            this.btnDeXuatUV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeXuatUV.Image = ((System.Drawing.Image)(resources.GetObject("btnDeXuatUV.Image")));
            this.btnDeXuatUV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeXuatUV.Location = new System.Drawing.Point(40, 16);
            this.btnDeXuatUV.Name = "btnDeXuatUV";
            this.btnDeXuatUV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDeXuatUV.Size = new System.Drawing.Size(152, 47);
            this.btnDeXuatUV.TabIndex = 15;
            this.btnDeXuatUV.Text = "Đề Xuất Ứng Viên";
            this.btnDeXuatUV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeXuatUV.UseVisualStyleBackColor = true;
            this.btnDeXuatUV.Click += new System.EventHandler(this.btnDeXuatUV_Click);
            // 
            // btnChuyenDS
            // 
            this.btnChuyenDS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChuyenDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenDS.Image = ((System.Drawing.Image)(resources.GetObject("btnChuyenDS.Image")));
            this.btnChuyenDS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChuyenDS.Location = new System.Drawing.Point(666, 16);
            this.btnChuyenDS.Name = "btnChuyenDS";
            this.btnChuyenDS.Size = new System.Drawing.Size(144, 47);
            this.btnChuyenDS.TabIndex = 18;
            this.btnChuyenDS.Text = "Chuyển DS Đề cử";
            this.btnChuyenDS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChuyenDS.UseVisualStyleBackColor = true;
            this.btnChuyenDS.Click += new System.EventHandler(this.btnChuyenDS_Click);
            // 
            // btnHuyDC
            // 
            this.btnHuyDC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuyDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyDC.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyDC.Image")));
            this.btnHuyDC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyDC.Location = new System.Drawing.Point(458, 16);
            this.btnHuyDC.Name = "btnHuyDC";
            this.btnHuyDC.Size = new System.Drawing.Size(140, 47);
            this.btnHuyDC.TabIndex = 16;
            this.btnHuyDC.Text = "Hủy Đề cử";
            this.btnHuyDC.UseVisualStyleBackColor = true;
            this.btnHuyDC.Click += new System.EventHandler(this.btnHuyDC_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1021, 547);
            this.Controls.Add(this.pnlXuLy);
            this.Controls.Add(this.pnlDSUV);
            this.Controls.Add(this.grbLoc);
            this.Controls.Add(this.menu);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menu;
            this.Name = "frmChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Chủ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmChinh_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.grbLoc.ResumeLayout(false);
            this.grbLoc.PerformLayout();
            this.pnlDSUV.ResumeLayout(false);
            this.pnlDSUV.PerformLayout();
            this.pnlXuLy.ResumeLayout(false);
            this.pnlXuLy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDoiMK;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanUV;
        private System.Windows.Forms.ToolStripMenuItem mnuPheDuyetUV;
        private System.Windows.Forms.ToolStripMenuItem mnuQLNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuTaoTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnuHuyTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnuQL_VTTD;
        private System.Windows.Forms.ToolStripMenuItem mnuXemDSUV;
        private System.Windows.Forms.ToolStripMenuItem mnuXemDSDC;
        private System.Windows.Forms.ToolStripMenuItem mnuXemDSPD;
        private System.Windows.Forms.ToolStripMenuItem mnuThemVT;
        private System.Windows.Forms.ToolStripMenuItem mnuXoaVT;
        private System.Windows.Forms.Label lblQuyen;
        private System.Windows.Forms.GroupBox grbLoc;
        private System.Windows.Forms.ComboBox cboKinhNghiem;
        private System.Windows.Forms.Button btnXemYeuCau;
        private System.Windows.Forms.Button BtnLocUV;
        private System.Windows.Forms.Label lblKinhNghiem;
        private System.Windows.Forms.Label lblTrinhDo;
        private System.Windows.Forms.Label lblNgoaiNgu;
        private System.Windows.Forms.Label lblViTri;
        private System.Windows.Forms.ComboBox cboNgoaiNgu;
        private System.Windows.Forms.ComboBox cboTrinhDo;
        private System.Windows.Forms.ComboBox cboVTTD;
        private System.Windows.Forms.Label lblDSUV;
        private System.Windows.Forms.Panel pnlDSUV;
        private System.Windows.Forms.Label lblTongUV;
        private System.Windows.Forms.TextBox txtTongUV;
        private System.Windows.Forms.Panel pnlXuLy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnDeXuatUV;
        private System.Windows.Forms.Button btnChuyenDS;
        private System.Windows.Forms.Button btnHuyDC;
        private System.Windows.Forms.ListView lvwDSUV;
        private System.Windows.Forms.ImageList imageList1;
    }
}