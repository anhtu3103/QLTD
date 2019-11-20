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
    public partial class frmQLViTriTuyenDung : Form
    {
        src.Services.connVTTD cnnVTTD = new src.Services.connVTTD();
        public frmQLViTriTuyenDung()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmQLViTriTuyenDung_Load(object sender, EventArgs e)
        {

        }

        private void btnThemVT_Click(object sender, EventArgs e)
        {
            if(txtTenVT.Text == "" || txtSoLuong.Text == "" || txtLuong.Text == "" || txtDiaDiem.Text == "" || rtxtMoTa.Text == "" 
                || rtxtQuyenLoi.Text == "" || rtxtYeuCau.Text == "")
            {
                MessageBox.Show("Bạn cần điền đầy đủ thông tin cho tất cả các ô!", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int outputSL;
            clsViTriTuyenDung vtThem = new clsViTriTuyenDung();
            vtThem._StrTenViTri = txtTenVT.Text;

            if (int.TryParse(txtSoLuong.Text, out outputSL))
            {
                if(outputSL < 1)
                {
                    MessageBox.Show("Số lượng phải > 0", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                vtThem._SoLuong = outputSL;
               
            }
            else // nhập vào khong phải là số
            {
                MessageBox.Show("Bạn phải nhập số trong ô số lượng", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                
            }

            vtThem._StrDiaDiemLV = txtDiaDiem.Text;
            vtThem._MucLuong = txtLuong.Text;
            vtThem._NgayHetHan = dtpNgayHetHan.Value;
            vtThem._StrMoTa = rtxtMoTa.Text;
            vtThem._StrQuyenLoi = rtxtQuyenLoi.Text;
            vtThem._StrYeuCau = rtxtYeuCau.Text;
            if (cnnVTTD.ThemVTTD(vtThem))
            {
                MessageBox.Show("Thêm thành công!");
            }
            else
            {
                MessageBox.Show("Thêm thất bại\nHãy thêm lại!");
            }

        }
    }
}
