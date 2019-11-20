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
    public partial class frmXemDuyetUV : Form
    {
        src.Controlers.ctrlGUI ctrGUI = new src.Controlers.ctrlGUI();
        src.Controlers.ctrlDeXuat ctrQLTD = new src.Controlers.ctrlDeXuat();
        src.Controlers.ctrlPheDuyet ctrPD = new src.Controlers.ctrlPheDuyet();
        src.Services.connVTTD_UngVien cnnVT_UV = new src.Services.connVTTD_UngVien();
        List<clsUngVienUngTuyen> dsDeCu = new List<clsUngVienUngTuyen>();
        List<clsUngVienUngTuyen> dsPD = new List<clsUngVienUngTuyen>();
        List<clsUngVienUngTuyen> dsUV = null;
        public enum TrangThaiForm
        {
            PheDuyet,
            XemDeCu,
            XemPheDuyet
        }
        public TrangThaiForm ttForm;

        public void Set_TrangThaiForm(TrangThaiForm tt)
        {
            if (ttForm == TrangThaiForm.PheDuyet) // trang thai phe duyet ung vien   
            {
                lvwDSUV.CheckBoxes = false;
                lblDSUV.Text = "Danh Sách Ứng Viên Đề Cử";
                btnDatLich.Enabled = false;
                btnDatLich.Visible = false;
                // btnPheDuyetUV.Visible = true;
                btnPheDuyetUV.Enabled = false;
                btnLuu.Visible = false;
                // btnChuyenDS.Visible = true;
                btnChuyenDS.Enabled = false;
                btnHuy.Visible = false;
                //pnlPheDuyet.Visible = true;

            }
            else if (ttForm == TrangThaiForm.XemDeCu) // trang thai xem danh sach de cu
            {
                lvwDSUV.CheckBoxes = false;
                btnDatLich.Visible = false;
                lblDSUV.Text = "Danh Sách Ứng Viên Đề Cử";
                btnPheDuyetUV.Visible = false;
                btnLuu.Visible = false;
                btnChuyenDS.Visible = false;
                btnHuy.Visible = false;
                //btnThoat.Location = new Point(this.Size.Width/2 , this.Size.Height - 30);
                btnThoat.Anchor = AnchorStyles.Bottom & AnchorStyles.Right;
                //pnlPheDuyet.Visible = false;

                btnReset.Visible = false;
            }
            else if (ttForm == TrangThaiForm.XemPheDuyet) // trang thai xem danh sach phe duyet
            {
                lvwDSUV.CheckBoxes = false;
                lblDSUV.Text = "Danh Sách Ứng Viên Đã Phê Duyệt";
                btnDatLich.Enabled = false;
                btnDatLich.Visible = true;
                btnPheDuyetUV.Visible = false;
                btnLuu.Visible = false;
                btnChuyenDS.Visible = false;
                btnHuy.Visible = false;
                //pnlPheDuyet.Visible = true;
            }
        }

        #region Xu Li Form
        private void TieuDeLvwDSUV()
        {

            lvwDSUV.View = View.Details;
            lvwDSUV.FullRowSelect = true;
            lvwDSUV.GridLines = true;
            lvwDSUV.Columns.Add("Mã", 50);
            lvwDSUV.Columns.Add("Họ và Tên", 180);
            lvwDSUV.Columns.Add("Giới Tính", 65);
            lvwDSUV.Columns.Add("Ngày Sinh", 120);
            lvwDSUV.Columns.Add("CMND", 110);
            lvwDSUV.Columns.Add("Email", 180);
            lvwDSUV.Columns.Add("Số Điện Thoại", 100);
            lvwDSUV.Columns.Add("Trình Độ", 120);
            lvwDSUV.Columns.Add("Ngoại Ngữ", 120);
            lvwDSUV.Columns.Add("Năm Kinh Nghiệm", 100);

        }
        private void LoadToListView(List<clsUngVienUngTuyen> dsLoc)
        {

            lvwDSUV.Items.Clear();
            ListViewItem lvi = null;
            foreach (var uv in dsLoc)
            {
                lvi = new ListViewItem(new String[] {uv._MaUV.ToString(), uv._StrTenUV, uv._GioiTinh == true ? "Nam": "Nữ",
                    uv._NgaySinh.ToString("dd'/'MM'/'yyyy"), uv._StrCMND.ToString(), uv._StrEmail, uv._StrSDT, uv._StrTrinhDo, uv._StrNgoaiNgu, uv._SoNam_KinhNghiem.ToString()});
                lvwDSUV.Items.Add(lvi);
                lvi.Tag = uv;
            }
            txtTongUV.Text = dsLoc.Count.ToString();
        }
        #endregion

        public frmXemDuyetUV()
        {
            InitializeComponent();

        }

        private void btnDSDC_Click(object sender, EventArgs e)
        {
            pnlPheDuyet.Visible = true;
            btnDatLich.Enabled = false;
            tt = TrangThaiLV.DSDC;
            ChuyenTrangThai(tt);
        }

        private void btnDSPD_Click(object sender, EventArgs e)
        {
            pnlPheDuyet.Visible = false;
            btnDatLich.Enabled = true;
            // tt = TrangThai.DSPD;
            // ChuyenTrangThai(tt);
        }

        public enum TrangThaiLV { DSDC, DSPD }
        public TrangThaiLV tt;
        public void An_button(TrangThaiLV tt)
        {
            if (tt == TrangThaiLV.DSDC)
            {
                this.btnLuu.Visible = false;
                this.btnChuyenDS.Visible = true;
                this.btnHuy.Visible = false;
                this.btnPheDuyetUV.Visible = true;
                this.lblDSUV.Text = "Danh Sách Ứng Viên Đề Cử";
                this.btnChuyenDS.Text = "Chuyển DS Phê Duyệt";

            }
            else
            {
                this.btnLuu.Visible = true;
                this.btnChuyenDS.Visible = true;
                this.btnHuy.Visible = true;
                this.btnPheDuyetUV.Visible = false;
                this.lblDSUV.Text = "Danh Sách Ứng Viên Phê Duyệt";
                this.btnChuyenDS.Text = "Chuyển DS Đề Cử";

            }
        }
        private void ChuyenTrangThai(TrangThaiLV tt)
        {
            if (tt == TrangThaiLV.DSDC)
            {
                this.btnLuu.Visible = false;
                this.btnChuyenDS.Visible = false;
                this.btnHuy.Visible = false;
                this.btnPheDuyetUV.Visible = true;
                this.lblDSUV.Text = "Danh Sách Ứng Viên Đề Cử";

            }
            else
            {
                this.btnLuu.Visible = true;
                this.btnChuyenDS.Visible = true;
                this.btnHuy.Visible = true;
                this.btnPheDuyetUV.Visible = false;
                this.lblDSUV.Text = "Danh Sách Ứng Viên Phê Duyệt";


            }
        }

        private void frmXemDuyetUV_Load(object sender, EventArgs e)
        {
            //pnlPheDuyet.Visible = false;
            //btnDatLich.Enabled = false;
            Set_TrangThaiForm(ttForm);
            //Load DL cho combobox
            List<clsViTriTuyenDung> lstVT = ctrGUI.GetVitriTuyenDung();
            cboVTTD.DataSource = lstVT;
            cboVTTD.DisplayMember = "_StrTenViTri";
            cboVTTD.ValueMember = "_MaVT";
            cboVTTD.SelectedIndex = -1;

            TieuDeLvwDSUV();
            //Load DL cho listview
            if (ttForm == TrangThaiForm.XemPheDuyet)
            {
                List<clsUngVienUngTuyen> dsUVPheDuyet = ctrPD.GetUVPheDuyetChuaCoLich();
                LoadToListView(dsUVPheDuyet);
            }
            else
            {
                dsUV = ctrPD.GetUngVienDeCu();
                LoadToListView(dsUV);
            }

        }

        private void btnChuyenDS_Click(object sender, EventArgs e)
        {
            if (btnChuyenDS.Text == "Chuyển DS Đề Cử")
            {
                tt = TrangThaiLV.DSDC;
            }
            else
            {
                tt = TrangThaiLV.DSPD;
            }
            //chuyen trang thai danh sach
            if (tt == TrangThaiLV.DSDC)
            {
                An_button(tt);
                LoadToListView(dsDeCu);
                tt = TrangThaiLV.DSPD;
            }
            else
            {
                An_button(tt);
                LoadToListView(dsPD);
                tt = TrangThaiLV.DSDC;
            }
        }



        private void cboVTTD_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lvwDSUV.CheckBoxes = true;
            var item = cboVTTD.SelectedItem;
            int ma = ((clsViTriTuyenDung)item)._MaVT;
            btnDatLich.Enabled = true;
            if (ttForm == TrangThaiForm.XemPheDuyet)
            {
                List<clsUngVienUngTuyen> dsUVPD = ctrPD.TimKiemUVPheDuyetTheoViTri(ma);
                LoadToListView(dsUVPD);
            }
            else
            {
                dsDeCu.Clear();
                dsDeCu = ctrPD.TimKiemUVDeCuTheoViTri(ma);
                LoadToListView(dsDeCu);
                btnPheDuyetUV.Enabled = true;
                btnChuyenDS.Enabled = true;

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvwDSUV.Items)
            {
                if (item.Checked == true)
                {
                    var uv = item.Tag;
                    var uvTemp = ((clsUngVienUngTuyen)uv);
                    ctrQLTD.ChuyenDSUV(dsPD, dsDeCu, uvTemp);
                    LoadToListView(dsPD);
                }
            }
        }

        private void btnPheDuyetUV_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc muốn đề cử các ứng viên này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //Đồng ý đề cử
            if (kq == DialogResult.OK)
            {
                int count = 0;
                foreach (ListViewItem lvi in lvwDSUV.Items)
                {
                    //chuyen danh sach cac item đc chon
                    if (lvi.Checked == true)
                    {
                        count++;
                        var uv = lvi.Tag;
                        clsUngVienUngTuyen uvTemp = ((clsUngVienUngTuyen)uv);
                        ctrQLTD.ChuyenDSUV(dsDeCu, dsPD, uvTemp);
                    }
                }
                if (count == 0)
                {
                    MessageBox.Show("Hãy chọn ít nhất một ứng viên để đề cử");
                }
                else
                {
                    LoadToListView(dsDeCu);
                    btnDatLich.Enabled = false;
                    cboVTTD.Enabled = false;
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            btnDatLich.Enabled = true;
            cboVTTD.Enabled = true;
            if(cnnVT_UV.UpdateTrangThaiPD(dsPD))
            {
                MessageBox.Show("Cập nhật thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công!\nHãy lưu lại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dsDeCu.Clear();
            dsPD.Clear();
            ttForm = TrangThaiForm.PheDuyet;
            frmXemDuyetUV_Load(sender,e);
        }

        private void btnDatLich_Click(object sender, EventArgs e)
        {
            if (ttForm == TrangThaiForm.PheDuyet)
            {
                ttForm = TrangThaiForm.XemPheDuyet;
                //Set_TrangThaiForm(ttForm);
                //List<clsUngVienUngTuyen> dsUVPheDuyet = ctrPD.GetUVPheDuyetChuaCoLich();
                //LoadToListView(dsUVPheDuyet);
                //btnDatLich.Enabled = true;
                frmXemDuyetUV_Load(sender,e);
            }
            else
            {
                frmLichPhongVan frmLichPV = new frmLichPhongVan();
                frmLichPV.ShowDialog();
            }

        }
        #region Set lại DB, dùng để test
        src.Services.connVTTD_UngVien cnn = new src.Services.connVTTD_UngVien();
        private void btnReset_Click(object sender, EventArgs e)
        {
            if (ttForm == TrangThaiForm.XemPheDuyet)
            {
                if (cnn.UpdateTrangThaiPD_False(dsPD))
                {
                    MessageBox.Show("Reset thành công");
                }
            }
            else if (ttForm == TrangThaiForm.PheDuyet)
            {
                if (cnn.UpdateTrangThaiDeCu_False(dsUV))
                {
                    MessageBox.Show("Reset thành công");
                }

            }
        }
        #endregion
    }
}
