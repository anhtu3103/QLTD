﻿using System;
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
    public partial class frmQLNV : Form
    {
        //src.DAOs.DB_QLTD.DataQuanLiTuyenDungDataContext db = null;
        List<clsNhanVienTuyenDung> dsNV = null;

        src.Services.connTaiKhoan cnnTK = new src.Services.connTaiKhoan();
        src.Controlers.ctrlQLNhanVien ctrQLNV = new src.Controlers.ctrlQLNhanVien();
        public frmQLNV()
        {
            InitializeComponent();
            //db = new src.DAOs.DB_QLTD.DataQuanLiTuyenDungDataContext();
        }


        //check tạo hay xóa tài khoản
        public bool check; //True là tạo tài khoản, False là xóa tài khoản
        private void frmQLNV_Load(object sender, EventArgs e)
        {
            TrangThaiHienThi();
            txtUser.Text = "";
            txtPass.Text = "";
            
            TieuDeListView();
            if (this.check == true)
            {
                cboRole.ResetText();
                dsNV = ctrQLNV.GetDSNVChuaCoTK();
                LoadToListView(dsNV);
            }
            else
            {
                cboRole.ResetText();
                dsNV = ctrQLNV.GetDSNVDaCoTK();
                LoadToListView(dsNV);
            }
        }

        
        private void LoadToListView(List<clsNhanVienTuyenDung> lstNV)
        {
            
            ListViewItem lvi = null;
            foreach (clsNhanVienTuyenDung nv in lstNV)
            {
                lvi = new ListViewItem(new String[] { nv._Id_NV, nv._StrHoTen_NV, nv._StrChucVu });
                lvwDSNV.Items.Add(lvi);
                lvi.Tag = nv;
            }

        }
        private void TieuDeListView()
        {
            lvwDSNV.Items.Clear();
            lvwDSNV.View = View.Details;
            lvwDSNV.FullRowSelect = true;
            lvwDSNV.GridLines = true;
            lvwDSNV.Columns.Add("Mã NV");
            lvwDSNV.Columns.Add("Tên Nhân viên", 300);
            lvwDSNV.Columns.Add("Chức vụ", 200);

        }
        private void TrangThaiHienThi()
        {
            btnXuLy.Enabled = false;
            if (check == true) //Tạo tài khoản
            {
                lblTieuDe.Text = "TẠO TÀI KHOẢN";
                lblDSNV.Text = "Danh Sách Nhân Viên Chưa Có Tài Khoản";
                btnXuLy.Text = "Tạo Tài Khoản";
                
                
            }
            else // Hủy tài khoản
            {
                lblTieuDe.Text = "HỦY TÀI KHOẢN";
                lblDSNV.Text = "Danh Sách Nhân Viên Đã Có Tài Khoản";
                btnXuLy.Text = "Hủy Tài Khoản";
            }
        }

        private void lvwDSNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwDSNV.SelectedItems.Count > 0)
            {
                btnXuLy.Enabled = true;
                if (this.check == true)//trang thai Tạo Tài Khoản
                {
                    txtUser.Tag = lvwDSNV.SelectedItems[0].Text;
                    txtUser.Text = "nvtd"+lvwDSNV.SelectedItems[0].Text;
                    txtPass.Text = "1234";
                    var lstRole = ctrQLNV.GetDataForcboRole();
                    lstRole.Insert(0, new clsRole(0, "--Chọn Role--", ""));
                    cboRole.DataSource = lstRole;
                    cboRole.DisplayMember = "_StrTenRole";
                    cboRole.ValueMember = "_MaRole";
                    cboRole.SelectedIndex = 0;
                    
                }
                else//trạng thái hủy tài khoản
                {
                    int maNVChon = int.Parse(lvwDSNV.SelectedItems[0].Text);

                    //cboRole.Items.Clear();
                    //cboRole.Items.Add(query.TenRole);
                    //cboRole.SelectedIndex = 0;
                    string[] ttTaiKhoan = ctrQLNV.GetThongTinChoTaiKhoan(maNVChon);
                    txtUser.Tag = ttTaiKhoan[0];
                    txtUser.Text = ttTaiKhoan[1];
                    txtPass.Text = ttTaiKhoan[2];
                    cboRole.Text = ttTaiKhoan[3];

                }
            }
        }

        private void lvwDSNV_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnXuLy_Click(object sender, EventArgs e)
        {
           if (this.check == true)//Tao tai khoan
            {
                if (cboRole.SelectedIndex == 0)
                {
                    MessageBox.Show("Hãy chọn Role cho tài khoản");
                }
                else
                {
                    DialogResult dlr = MessageBox.Show("Bạn chắc chắn muốn tạo tài khoản không??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlr == DialogResult.Yes) // dong y tao tai khoan
                    {
                        //luu tai khoan
                        clsTaiKhoan tkThem = new clsTaiKhoan();
                        tkThem._Id_NV = int.Parse(txtUser.Tag.ToString());
                        tkThem._StrUsername = txtUser.Text;
                        tkThem._StrPassWord = txtPass.Text;
                        tkThem._MaRole = (int)cboRole.SelectedValue;
                        if (cnnTK.ThemTaiKhoan(tkThem))// luu DB thanh cong
                        {
                            MessageBox.Show("Tạo tài khoản thành công!");
                            check = true;
                            frmQLNV_Load(sender, e);
                        }
                        else // luu DB that bai
                        {
                            MessageBox.Show("Tạo tài khoản không thành công!\nHãy tạo lại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else // khong dong y tao tai khoan
                        MessageBox.Show("Tài khoản chưa được tạo!!");
                }
                
            }
            else // Huy tai khoan
            {
                DialogResult dlr = MessageBox.Show("Bạn chắc chắn muốn hủy tài khoản này không??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    int maTKHuy = int.Parse(txtUser.Tag.ToString());
                    if (cnnTK.XoaTaiKhoan(maTKHuy))
                    {
                        MessageBox.Show("Hủy tài khoản thành công!");
                        check = false;
                        frmQLNV_Load(sender, e);
                    }
                    else // luu DB that bai
                    {
                        MessageBox.Show("Hủy tài khoản không thành công!\nHãy hủy lại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                    MessageBox.Show("Tài khoản chưa được hủy!!");
                
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

