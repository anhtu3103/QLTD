using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmDangNhap : Form
    {
        src.DAOs.DB_QLTD.DataQuanLiTuyenDungDataContext db = null;
        public frmDangNhap()
        {
            InitializeComponent();
            db = new src.DAOs.DB_QLTD.DataQuanLiTuyenDungDataContext();
            this.Size = new Size(500, 500);
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin Username và Password!!");
                return;
            }
            
            var check = KiemTraTaiKhoan(txtUser.Text, txtPass.Text);
            if (check != null) // dung tai khoan va mat khau
            {
                frmChinh frmC = new frmChinh((int)KiemTraTaiKhoan(txtUser.Text, txtPass.Text).MaRole_R);

                //ánh xạ tài khoản qa form chính
                frmC.taikhoan = new clsTaiKhoan((int)check.ID_NV, check.Usernames, check.Passwords, (int)check.MaRole_R);

                frmC.IsMdiContainer = true;
                this.Hide();
                frmC.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Thông tin nhập sai!!");
            }

        }


        public src.DAOs.DB_QLTD.tblTAIKHOAN KiemTraTaiKhoan(string user, string pass)
        {
            src.DAOs.DB_QLTD.tblTAIKHOAN query = db.tblTAIKHOANs.Where(t => t.Usernames == user && t.Passwords == pass).FirstOrDefault();
            //clsTaiKhoan tk = new clsTaiKhoan(query.ID, query.Usernames, query.Passwords, (int)query.MaRole);

            return query;
        }
        public int getMaQuyen(src.DAOs.DB_QLTD.tblTAIKHOAN t)
        {
            int maQ = -1;

            return maQ;
        }

        private void btnThoatDN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            panel1.Location = new Point(this.Width / 3, this.Height / 4);
            txtUser.Text = "nvtd5";
            txtPass.Text = "1234";
            
        }

        
    }
}
