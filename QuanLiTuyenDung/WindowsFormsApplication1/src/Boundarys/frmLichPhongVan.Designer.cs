namespace WindowsFormsApplication1
{
    partial class frmLichPhongVan
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
            this.txtGio = new System.Windows.Forms.TextBox();
            this.rtxtDiaDiem = new System.Windows.Forms.RichTextBox();
            this.btnDatLich = new System.Windows.Forms.Button();
            this.dtpThoiGian = new System.Windows.Forms.DateTimePicker();
            this.lblDiaDiem = new System.Windows.Forms.Label();
            this.tblTieuDeDatLich = new System.Windows.Forms.Label();
            this.lblTG = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGio
            // 
            this.txtGio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGio.Location = new System.Drawing.Point(138, 98);
            this.txtGio.Name = "txtGio";
            this.txtGio.Size = new System.Drawing.Size(178, 20);
            this.txtGio.TabIndex = 39;
            // 
            // rtxtDiaDiem
            // 
            this.rtxtDiaDiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rtxtDiaDiem.Location = new System.Drawing.Point(70, 204);
            this.rtxtDiaDiem.Name = "rtxtDiaDiem";
            this.rtxtDiaDiem.Size = new System.Drawing.Size(281, 53);
            this.rtxtDiaDiem.TabIndex = 38;
            this.rtxtDiaDiem.Text = "";
            // 
            // btnDatLich
            // 
            this.btnDatLich.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDatLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatLich.Location = new System.Drawing.Point(70, 294);
            this.btnDatLich.Name = "btnDatLich";
            this.btnDatLich.Size = new System.Drawing.Size(133, 35);
            this.btnDatLich.TabIndex = 37;
            this.btnDatLich.Text = "Đặt lịch";
            this.btnDatLich.UseVisualStyleBackColor = true;
            // 
            // dtpThoiGian
            // 
            this.dtpThoiGian.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpThoiGian.Location = new System.Drawing.Point(70, 129);
            this.dtpThoiGian.Name = "dtpThoiGian";
            this.dtpThoiGian.Size = new System.Drawing.Size(246, 20);
            this.dtpThoiGian.TabIndex = 36;
            // 
            // lblDiaDiem
            // 
            this.lblDiaDiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDiaDiem.AutoSize = true;
            this.lblDiaDiem.Location = new System.Drawing.Point(67, 176);
            this.lblDiaDiem.Name = "lblDiaDiem";
            this.lblDiaDiem.Size = new System.Drawing.Size(52, 13);
            this.lblDiaDiem.TabIndex = 35;
            this.lblDiaDiem.Text = "Địa điểm:";
            // 
            // tblTieuDeDatLich
            // 
            this.tblTieuDeDatLich.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tblTieuDeDatLich.AutoSize = true;
            this.tblTieuDeDatLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblTieuDeDatLich.Location = new System.Drawing.Point(118, 45);
            this.tblTieuDeDatLich.Name = "tblTieuDeDatLich";
            this.tblTieuDeDatLich.Size = new System.Drawing.Size(147, 20);
            this.tblTieuDeDatLich.TabIndex = 34;
            this.tblTieuDeDatLich.Text = "Thông tin đặt lịch";
            // 
            // lblTG
            // 
            this.lblTG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTG.AutoSize = true;
            this.lblTG.Location = new System.Drawing.Point(67, 101);
            this.lblTG.Name = "lblTG";
            this.lblTG.Size = new System.Drawing.Size(54, 13);
            this.lblTG.TabIndex = 33;
            this.lblTG.Text = "Thời gian:";
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(218, 294);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(133, 35);
            this.btnHuy.TabIndex = 40;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmLichPhongVan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 370);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.txtGio);
            this.Controls.Add(this.rtxtDiaDiem);
            this.Controls.Add(this.btnDatLich);
            this.Controls.Add(this.dtpThoiGian);
            this.Controls.Add(this.lblDiaDiem);
            this.Controls.Add(this.tblTieuDeDatLich);
            this.Controls.Add(this.lblTG);
            this.Name = "frmLichPhongVan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLichPhongVan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGio;
        private System.Windows.Forms.RichTextBox rtxtDiaDiem;
        private System.Windows.Forms.Button btnDatLich;
        private System.Windows.Forms.DateTimePicker dtpThoiGian;
        private System.Windows.Forms.Label lblDiaDiem;
        private System.Windows.Forms.Label tblTieuDeDatLich;
        private System.Windows.Forms.Label lblTG;
        private System.Windows.Forms.Button btnHuy;
    }
}