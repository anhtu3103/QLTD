
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.src.Controlers
{
    public class ctrlDeXuat : src.Services.connDB
    {
        public ctrlDeXuat()
        {

        }

        public List<clsUngVienUngTuyen> TimKiemTheoViTri(int maVT)
        {
            List<clsUngVienUngTuyen> lstUV = new List<clsUngVienUngTuyen>();
            //get nhung ung vien co vi tri = maVT va TTDC = false
            var query = db.tblUNGVIENs.Join(db.tblVTTD_UNGTUYENs, u => u.MaUV, v => v.MaUV_UV, (u, v) => new { u, v })
                .Where(uv => uv.v.MaVT_VT == maVT && uv.v.TrangThaiDC == false).Distinct().ToList();
            foreach (var uv in query)
            {
                lstUV.Add(new clsUngVienUngTuyen((int)uv.u.MaUV, uv.u.TenUV, uv.u.GioiTinh.ToString() == "Nam" ? true : false,
                        DateTime.Parse(uv.u.NgaySinh.ToString()), uv.u.Email, uv.u.CMND.ToString(), uv.u.SDT, uv.u.TrinhDoHV, uv.u.NgoaiNgu,
                        (int)uv.u.SoNamKN, uv.u.CV.ToString(), (int)uv.v.MaVT_VT, (bool)uv.v.TrangThaiDC, (bool)uv.v.TrangThaiPD));
            }
            return lstUV;
        }


        public List<clsUngVienUngTuyen> LocTheoTrinhDo(List<clsUngVienUngTuyen> lstUV_TK, string trinhDoHV)
        {
            List<clsUngVienUngTuyen> dsLoc = new List<clsUngVienUngTuyen>();
            foreach (var i in lstUV_TK)
            {
                if (i._StrTrinhDo == trinhDoHV)
                {
                    dsLoc.Add(i);
                }
            }
            return dsLoc;
        }

        public List<clsUngVienUngTuyen> LocTheoNgoaiNgu(List<clsUngVienUngTuyen> lstUV_TK, string ngoaiNgu)
        {
            List<clsUngVienUngTuyen> dsLoc = new List<clsUngVienUngTuyen>();
            foreach (var i in lstUV_TK)
            {
                if (i._StrNgoaiNgu == ngoaiNgu)
                {
                    dsLoc.Add(i);
                }
            }
            return dsLoc;
        }

        public List<clsUngVienUngTuyen> LocTheoNamKinhNghiem(List<clsUngVienUngTuyen> lstUV_TK, string namKinhNghiem)
        {
            int soNam = -1;
            List<clsUngVienUngTuyen> dsLoc = new List<clsUngVienUngTuyen>();
            if (namKinhNghiem == "Chưa có kinh nghiệm")//namKN = 0
            {
                soNam = 0;
                foreach (var i in lstUV_TK)
                {
                    if (i._SoNam_KinhNghiem == soNam)
                    {
                        dsLoc.Add(i);
                    }
                }
            }
            else if (namKinhNghiem == "Dưới 1 năm")//namKN = 1
            {
                soNam = 1;
                foreach (var i in lstUV_TK)
                {
                    if (i._SoNam_KinhNghiem == soNam)
                    {
                        dsLoc.Add(i);
                    }
                }
            }
            else if (namKinhNghiem == "Trên 5 năm")//namKN > 5
            {
                soNam = 5;
                foreach (var i in lstUV_TK)
                {
                    if (i._SoNam_KinhNghiem > soNam)
                    {
                        dsLoc.Add(i);
                    }
                }
            }
            else if (namKinhNghiem == "Trên 3 năm")//namKN > 3
            {
                soNam = 3;
                foreach (var i in lstUV_TK)
                {
                    if (i._SoNam_KinhNghiem > soNam)
                    {
                        dsLoc.Add(i);
                    }
                }
            }
            else if (namKinhNghiem == "Trên 1 năm") // namKN > 1
            {
                soNam = 1;
                foreach (var i in lstUV_TK)
                {
                    if (i._SoNam_KinhNghiem > soNam)
                    {
                        dsLoc.Add(i);
                    }
                }
            }
            
            return dsLoc;
        }

        public void ChuyenDoiDanhSach(List<clsUngVienUngTuyen> nguon, List<clsUngVienUngTuyen> dich, int maUV)
        {
            foreach (clsUngVienUngTuyen item in nguon)
            {
                if (item._MaUV == maUV)
                {
                    clsUngVienUngTuyen uv = new clsUngVienUngTuyen(item);
                    dich.Add(uv);
                    nguon.Remove(item);
                    break;
                }
            }
        }

        public List<clsUngVienUngTuyen> ChuyenDSUV(List<clsUngVienUngTuyen> dsNguon, List<clsUngVienUngTuyen> dsDich, clsUngVienUngTuyen uvChuyen)
        {
            //clsUngVienUngTuyen uv = new clsUngVienUngTuyen();
            //uv = uvChuyen;
            dsDich.Add(uvChuyen);
            dsNguon.Remove(uvChuyen);
            return dsDich;
        }
        public List<clsUngVienUngTuyen> LocUV_theoVitri(List<clsUngVienUngTuyen> dsUV, int maVT)
        {
            List<clsUngVienUngTuyen> lstUV = new List<clsUngVienUngTuyen>();
            foreach (clsUngVienUngTuyen item in dsUV)
            {
                if (item._MaVT == maVT)
                    lstUV.Add(new clsUngVienUngTuyen(item));
            }
            return lstUV;
        }
    }
}
