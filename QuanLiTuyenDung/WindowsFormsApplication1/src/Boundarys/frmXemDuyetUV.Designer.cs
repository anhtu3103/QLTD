namespace WindowsFormsApplication1
{
    partial class frmXemDuyetUV
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.pnlPheDuyet = new System.Windows.Forms.Panel();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnPheDuyetUV = new System.Windows.Forms.Button();
            this.btnChuyenDS = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnDatLich = new System.Windows.Forms.Button();
            this.pnlThongTin = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblTongUV = new System.Windows.Forms.Label();
            this.txtTongUV = new System.Windows.Forms.TextBox();
            this.lvwDSUV = new System.Windows.Forms.ListView();
            this.lblDSUV = new System.Windows.Forms.Label();
            this.lblVTTD = new System.Windows.Forms.Label();
            this.cboVTTD = new System.Windows.Forms.ComboBox();
            this.pnlPheDuyet.SuspendLayout();
            this.pnlThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(704, 445);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(87, 43);
            this.btnThoat.TabIndex = 25;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // pnlPheDuyet
            // 
            this.pnlPheDuyet.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pnlPheDuyet.Controls.Add(this.btnLuu);
            this.pnlPheDuyet.Controls.Add(this.btnPheDuyetUV);
            this.pnlPheDuyet.Controls.Add(this.btnChuyenDS);
            this.pnlPheDuyet.Controls.Add(this.btnHuy);
            this.pnlPheDuyet.Location = new System.Drawing.Point(0, 439);
            this.pnlPheDuyet.Name = "pnlPheDuyet";
            this.pnlPheDuyet.Size = new System.Drawing.Size(678, 82);
            this.pnlPheDuyet.TabIndex = 27;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(294, 12);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(87, 43);
            this.btnLuu.TabIndex = 25;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnPheDuyetUV
            // 
            this.btnPheDuyetUV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPheDuyetUV.AutoSize = true;
            this.btnPheDuyetUV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPheDuyetUV.Location = new System.Drawing.Point(18, 12);
            this.btnPheDuyetUV.Name = "btnPheDuyetUV";
            this.btnPheDuyetUV.Size = new System.Drawing.Size(132, 43);
            this.btnPheDuyetUV.TabIndex = 23;
            this.btnPheDuyetUV.Text = "Phê Duyệt Ứng Viên";
            this.btnPheDuyetUV.UseVisualStyleBackColor = true;
            this.btnPheDuyetUV.Click += new System.EventHandler(this.btnPheDuyetUV_Click);
            // 
            // btnChuyenDS
            // 
            this.btnChuyenDS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChuyenDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenDS.Location = new System.Drawing.Point(513, 12);
            this.btnChuyenDS.Name = "btnChuyenDS";
            this.btnChuyenDS.Size = new System.Drawing.Size(149, 43);
            this.btnChuyenDS.TabIndex = 26;
            this.btnChuyenDS.Text = "Chuyển DS Phê Duyệt";
            this.btnChuyenDS.UseVisualStyleBackColor = true;
            this.btnChuyenDS.Click += new System.EventHandler(this.btnChuyenDS_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(407, 12);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(87, 43);
            this.btnHuy.TabIndex = 24;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnDatLich
            // 
            this.btnDatLich.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDatLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatLich.Location = new System.Drawing.Point(735, 16);
            this.btnDatLich.Name = "btnDatLich";
            this.btnDatLich.Size = new System.Drawing.Size(87, 43);
            this.btnDatLich.TabIndex = 24;
            this.btnDatLich.Text = "Đặt Lịch";
            this.btnDatLich.UseVisualStyleBackColor = true;
            this.btnDatLich.Click += new System.EventHandler(this.btnDatLich_Click);
            // 
            // pnlThongTin
            // 
            this.pnlThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlThongTin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlThongTin.Controls.Add(this.btnReset);
            this.pnlThongTin.Controls.Add(this.btnDatLich);
            this.pnlThongTin.Controls.Add(this.lblTongUV);
            this.pnlThongTin.Controls.Add(this.txtTongUV);
            this.pnlThongTin.Controls.Add(this.lvwDSUV);
            this.pnlThongTin.Controls.Add(this.lblDSUV);
            this.pnlThongTin.Controls.Add(this.lblVTTD);
            this.pnlThongTin.Controls.Add(this.cboVTTD);
            this.pnlThongTin.Location = new System.Drawing.Point(0, 0);
            this.pnlThongTin.Name = "pnlThongTin";
            this.pnlThongTin.Size = new System.Drawing.Size(847, 439);
            this.pnlThongTin.TabIndex = 26;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Location = new System.Drawing.Point(603, 26);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 33;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblTongUV
            // 
            this.lblTongUV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTongUV.AutoSize = true;
            this.lblTongUV.Location = new System.Drawing.Point(659, 117);
            this.lblTongUV.Name = "lblTongUV";
            this.lblTongUV.Size = new System.Drawing.Size(81, 13);
            this.lblTongUV.TabIndex = 32;
            this.lblTongUV.Text = "Tổng Ứng viên:";
            // 
            // txtTongUV
            // 
            this.txtTongUV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTongUV.Location = new System.Drawing.Point(749, 114);
            this.txtTongUV.Name = "txtTongUV";
            this.txtTongUV.Size = new System.Drawing.Size(42, 20);
            this.txtTongUV.TabIndex = 31;
            // 
            // lvwDSUV
            // 
            this.lvwDSUV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwDSUV.CheckBoxes = true;
            this.lvwDSUV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwDSUV.Location = new System.Drawing.Point(56, 140);
            this.lvwDSUV.Name = "lvwDSUV";
            this.lvwDSUV.Size = new System.Drawing.Size(735, 271);
            this.lvwDSUV.TabIndex = 30;
            this.lvwDSUV.UseCompatibleStateImageBehavior = false;
            this.lvwDSUV.View = System.Windows.Forms.View.Details;
            // 
            // lblDSUV
            // 
            this.lblDSUV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDSUV.AutoSize = true;
            this.lblDSUV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSUV.Location = new System.Drawing.Point(306, 92);
            this.lblDSUV.Name = "lblDSUV";
            this.lblDSUV.Size = new System.Drawing.Size(198, 24);
            this.lblDSUV.TabIndex = 27;
            this.lblDSUV.Text = "Danh sách Ứng viên";
            // 
            // lblVTTD
            // 
            this.lblVTTD.AutoSize = true;
            this.lblVTTD.Location = new System.Drawing.Point(15, 19);
            this.lblVTTD.Name = "lblVTTD";
            this.lblVTTD.Size = new System.Drawing.Size(92, 13);
            this.lblVTTD.TabIndex = 26;
            this.lblVTTD.Text = "Vị trí Tuyển dụng:";
            // 
            // cboVTTD
            // 
            this.cboVTTD.FormattingEnabled = true;
            this.cboVTTD.Location = new System.Drawing.Point(113, 16);
            this.cboVTTD.Name = "cboVTTD";
            this.cboVTTD.Size = new System.Drawing.Size(121, 21);
            this.cboVTTD.TabIndex = 25;
            this.cboVTTD.SelectionChangeCommitted += new System.EventHandler(this.cboVTTD_SelectionChangeCommitted);
            // 
            // frmXemDuyetUV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 521);
            this.Controls.Add(this.pnlPheDuyet);
            this.Controls.Add(this.pnlThongTin);
            this.Controls.Add(this.btnThoat);
            this.Name = "frmXemDuyetUV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phê Duyệt Ứng Viên";
            this.Load += new System.EventHandler(this.frmXemDuyetUV_Load);
            this.pnlPheDuyet.ResumeLayout(false);
            this.pnlPheDuyet.PerformLayout();
            this.pnlThongTin.ResumeLayout(false);
            this.pnlThongTin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel pnlPheDuyet;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnPheDuyetUV;
        private System.Windows.Forms.Button btnChuyenDS;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Panel pnlThongTin;
        private System.Windows.Forms.Label lblTongUV;
        private System.Windows.Forms.TextBox txtTongUV;
        private System.Windows.Forms.ListView lvwDSUV;
        private System.Windows.Forms.Label lblDSUV;
        private System.Windows.Forms.Label lblVTTD;
        private System.Windows.Forms.ComboBox cboVTTD;
        private System.Windows.Forms.Button btnDatLich;
        private System.Windows.Forms.Button btnReset;
    }
}