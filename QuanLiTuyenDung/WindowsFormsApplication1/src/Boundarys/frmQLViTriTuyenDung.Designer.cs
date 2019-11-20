namespace WindowsFormsApplication1
{
    partial class frmQLViTriTuyenDung
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
            this.lblTenVT = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblDiaDiem = new System.Windows.Forms.Label();
            this.lblLuong = new System.Windows.Forms.Label();
            this.lblNgayHetHan = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.lblYeuCau = new System.Windows.Forms.Label();
            this.txtTenVT = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtDiaDiem = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.dtpNgayHetHan = new System.Windows.Forms.DateTimePicker();
            this.rtxtMoTa = new System.Windows.Forms.RichTextBox();
            this.rtxtYeuCau = new System.Windows.Forms.RichTextBox();
            this.rtxtQuyenLoi = new System.Windows.Forms.RichTextBox();
            this.lblQuyenLoi = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.btnThemVT = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTenVT
            // 
            this.lblTenVT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTenVT.AutoSize = true;
            this.lblTenVT.Location = new System.Drawing.Point(136, 73);
            this.lblTenVT.Name = "lblTenVT";
            this.lblTenVT.Size = new System.Drawing.Size(54, 13);
            this.lblTenVT.TabIndex = 0;
            this.lblTenVT.Text = "Tên Vị trí:";
            this.lblTenVT.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(134, 115);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(56, 13);
            this.lblSoLuong.TabIndex = 1;
            this.lblSoLuong.Text = "Số Lượng:";
            // 
            // lblDiaDiem
            // 
            this.lblDiaDiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDiaDiem.AutoSize = true;
            this.lblDiaDiem.Location = new System.Drawing.Point(96, 160);
            this.lblDiaDiem.Name = "lblDiaDiem";
            this.lblDiaDiem.Size = new System.Drawing.Size(94, 13);
            this.lblDiaDiem.TabIndex = 2;
            this.lblDiaDiem.Text = "Địa điểm làm việc:";
            // 
            // lblLuong
            // 
            this.lblLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLuong.AutoSize = true;
            this.lblLuong.Location = new System.Drawing.Point(149, 199);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(40, 13);
            this.lblLuong.TabIndex = 3;
            this.lblLuong.Text = "Lương:";
            // 
            // lblNgayHetHan
            // 
            this.lblNgayHetHan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNgayHetHan.AutoSize = true;
            this.lblNgayHetHan.Location = new System.Drawing.Point(116, 236);
            this.lblNgayHetHan.Name = "lblNgayHetHan";
            this.lblNgayHetHan.Size = new System.Drawing.Size(74, 13);
            this.lblNgayHetHan.TabIndex = 4;
            this.lblNgayHetHan.Text = "Ngày hết hạn:";
            // 
            // lblMoTa
            // 
            this.lblMoTa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Location = new System.Drawing.Point(28, 321);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(37, 13);
            this.lblMoTa.TabIndex = 5;
            this.lblMoTa.Text = "Mô tả:";
            // 
            // lblYeuCau
            // 
            this.lblYeuCau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblYeuCau.AutoSize = true;
            this.lblYeuCau.Location = new System.Drawing.Point(16, 438);
            this.lblYeuCau.Name = "lblYeuCau";
            this.lblYeuCau.Size = new System.Drawing.Size(50, 13);
            this.lblYeuCau.TabIndex = 6;
            this.lblYeuCau.Text = "Yêu cầu:";
            // 
            // txtTenVT
            // 
            this.txtTenVT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenVT.Location = new System.Drawing.Point(208, 71);
            this.txtTenVT.Name = "txtTenVT";
            this.txtTenVT.Size = new System.Drawing.Size(274, 20);
            this.txtTenVT.TabIndex = 8;
            this.txtTenVT.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSoLuong.Location = new System.Drawing.Point(208, 112);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(274, 20);
            this.txtSoLuong.TabIndex = 9;
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDiaDiem.Location = new System.Drawing.Point(208, 153);
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.Size = new System.Drawing.Size(274, 20);
            this.txtDiaDiem.TabIndex = 10;
            // 
            // txtLuong
            // 
            this.txtLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLuong.Location = new System.Drawing.Point(208, 194);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(274, 20);
            this.txtLuong.TabIndex = 12;
            // 
            // dtpNgayHetHan
            // 
            this.dtpNgayHetHan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpNgayHetHan.Location = new System.Drawing.Point(208, 230);
            this.dtpNgayHetHan.Name = "dtpNgayHetHan";
            this.dtpNgayHetHan.Size = new System.Drawing.Size(274, 20);
            this.dtpNgayHetHan.TabIndex = 13;
            // 
            // rtxtMoTa
            // 
            this.rtxtMoTa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rtxtMoTa.Location = new System.Drawing.Point(68, 273);
            this.rtxtMoTa.Name = "rtxtMoTa";
            this.rtxtMoTa.Size = new System.Drawing.Size(488, 111);
            this.rtxtMoTa.TabIndex = 14;
            this.rtxtMoTa.Text = "";
            // 
            // rtxtYeuCau
            // 
            this.rtxtYeuCau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rtxtYeuCau.Location = new System.Drawing.Point(68, 390);
            this.rtxtYeuCau.Name = "rtxtYeuCau";
            this.rtxtYeuCau.Size = new System.Drawing.Size(488, 111);
            this.rtxtYeuCau.TabIndex = 15;
            this.rtxtYeuCau.Text = "";
            // 
            // rtxtQuyenLoi
            // 
            this.rtxtQuyenLoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rtxtQuyenLoi.Location = new System.Drawing.Point(68, 507);
            this.rtxtQuyenLoi.Name = "rtxtQuyenLoi";
            this.rtxtQuyenLoi.Size = new System.Drawing.Size(488, 111);
            this.rtxtQuyenLoi.TabIndex = 18;
            this.rtxtQuyenLoi.Text = "";
            // 
            // lblQuyenLoi
            // 
            this.lblQuyenLoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblQuyenLoi.AutoSize = true;
            this.lblQuyenLoi.Location = new System.Drawing.Point(11, 557);
            this.lblQuyenLoi.Name = "lblQuyenLoi";
            this.lblQuyenLoi.Size = new System.Drawing.Size(54, 13);
            this.lblQuyenLoi.TabIndex = 17;
            this.lblQuyenLoi.Text = "Quyền lợi:";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(173, 24);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(333, 24);
            this.lblTieuDe.TabIndex = 19;
            this.lblTieuDe.Text = "Thêm Nội dung Vị Trí Tuyển Dụng";
            // 
            // btnThemVT
            // 
            this.btnThemVT.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnThemVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemVT.Location = new System.Drawing.Point(145, 641);
            this.btnThemVT.Name = "btnThemVT";
            this.btnThemVT.Size = new System.Drawing.Size(105, 43);
            this.btnThemVT.TabIndex = 20;
            this.btnThemVT.Text = "Thêm Vị Trí";
            this.btnThemVT.UseVisualStyleBackColor = true;
            this.btnThemVT.Click += new System.EventHandler(this.btnThemVT_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(346, 641);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(105, 43);
            this.btnThoat.TabIndex = 21;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // frmQLViTriTuyenDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(596, 706);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThemVT);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.rtxtQuyenLoi);
            this.Controls.Add(this.lblQuyenLoi);
            this.Controls.Add(this.rtxtYeuCau);
            this.Controls.Add(this.rtxtMoTa);
            this.Controls.Add(this.dtpNgayHetHan);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.txtDiaDiem);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtTenVT);
            this.Controls.Add(this.lblYeuCau);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.lblNgayHetHan);
            this.Controls.Add(this.lblLuong);
            this.Controls.Add(this.lblDiaDiem);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.lblTenVT);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmQLViTriTuyenDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQLViTriTuyenDung";
            this.Load += new System.EventHandler(this.frmQLViTriTuyenDung_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenVT;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblDiaDiem;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.Label lblNgayHetHan;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblYeuCau;
        private System.Windows.Forms.TextBox txtTenVT;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtDiaDiem;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.DateTimePicker dtpNgayHetHan;
        private System.Windows.Forms.RichTextBox rtxtMoTa;
        private System.Windows.Forms.RichTextBox rtxtYeuCau;
        private System.Windows.Forms.RichTextBox rtxtQuyenLoi;
        private System.Windows.Forms.Label lblQuyenLoi;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Button btnThemVT;
        private System.Windows.Forms.Button btnThoat;
    }
}