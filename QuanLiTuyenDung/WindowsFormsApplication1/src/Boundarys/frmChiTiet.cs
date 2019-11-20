using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmChiTiet : Form
    {
        
        string noiDung;
        
        private string thongTin;
        public enum TrangThai { XemYeuCau, XemCV };

        TrangThai tt;
        
             
        
        public frmChiTiet(TrangThai trangThai, string tieuDe, string str)
        {
            InitializeComponent();
            thongTin = tieuDe;
            tt = trangThai;
            noiDung = str;
        }

        private void frmChiTiet_Load(object sender, EventArgs e)
        {
            this.Size = new Size(670, 720);
            TrangThaiHienThi(tt);
        }

        public void TrangThaiHienThi(TrangThai tt)
        {
            txtThongTin.Text = thongTin;
            arcoCV.Visible = false;
            rtfTTChiTiet.Visible = true;
            if (tt == TrangThai.XemYeuCau) //Trạng thái Xem yều cầu tuyển dụng
            {
                lblThongTin.Text = "Vị trí tuyển dụng:";
                lblTieuDe.Text = "YÊU CẦU";
                rtfTTChiTiet.Text = noiDung;

            }
            else //Trạng thái Xem CV
            {
                lblThongTin.Text = "Hồ sơ Ứng Viên";
                lblTieuDe.Text = "CV";
                arcoCV.Visible = true;
                rtfTTChiTiet.Visible = false;

                //using (OpenFileDialog ofd = new OpenFileDialog() { ValidateNames = true, Multiselect = false, Filter = "PDF*|.pdf" })
                //{
                //    ofd.ShowDialog();
                //}
                //string txtPath = "Nguyen-Van-A-TopCV.vn-110919.205226.pdf";
                string path = Path.GetFullPath("Nguyen-Van-A-TopCV.vn-110919.205226.pdf");
 
                arcoCV.src = path;
            }
        }
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
