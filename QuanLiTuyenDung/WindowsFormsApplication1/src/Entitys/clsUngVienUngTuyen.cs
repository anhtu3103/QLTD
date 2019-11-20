using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class clsUngVienUngTuyen : clsAbsUngVien
    {
        private bool trangThaiDeCu;
        private bool trangThaiPheDuyet;
        

        public bool _TrangThaiDeCu
        {
            get { return trangThaiDeCu; }
            set { trangThaiDeCu = value; }
        }
        public bool _TrangThaiPheDuyet
        {
            get { return trangThaiPheDuyet; }
            set { trangThaiPheDuyet = value; }
        }

        public clsUngVienUngTuyen() : base()
        {
            this.trangThaiDeCu = false;
            this.trangThaiPheDuyet = false;

        }

        public clsUngVienUngTuyen(int maUV, string tenUV, bool gt, DateTime ngaySinh, string email, string soCMND, string sdt, string trinhDo,
            string ngoaiNgu, int namKN, string cv, int mavitri, bool trangThaiDC, bool trangThaiPD)
            : base( maUV,  tenUV,  gt,  ngaySinh,  email,  soCMND,  sdt,  trinhDo,
             ngoaiNgu,  namKN,  cv,  mavitri)
        {
            this.trangThaiDeCu = trangThaiDC;
            this.trangThaiPheDuyet = trangThaiPD;

        }

      
        public clsUngVienUngTuyen(clsUngVienUngTuyen ut)
        {
            this.maUV = ut._MaUV;
            this.strTenUV = ut._StrTenUV;
            this.ngaySinh = ut._NgaySinh;
            this.gioiTinh = ut._GioiTinh;
            this.strSDT = ut._StrSDT;
            this.strEmail = ut._StrEmail;
            this.strCMND = ut._StrCMND;
            this.strTrinhDo = ut._StrTrinhDo;
            this.strNgoaiNgu = ut._StrNgoaiNgu;
            this.soNam_KinhNghiem = ut._SoNam_KinhNghiem;
            this.strCV = ut._StrCV;
            this.maVT = ut._MaVT;
            this.trangThaiDeCu = ut._TrangThaiDeCu;
            this.trangThaiPheDuyet = ut._TrangThaiPheDuyet;

        }

        
    }
}
