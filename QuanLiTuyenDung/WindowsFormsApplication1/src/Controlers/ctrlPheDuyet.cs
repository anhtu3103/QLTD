using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.src.Controlers
{
    public class ctrlPheDuyet : Services.connDB
    {
        public ctrlPheDuyet()
        {
            
        }
        public List<clsUngVienUngTuyen> GetUngVienDeCu()
        {
            List<clsUngVienUngTuyen> lstUV = new List<clsUngVienUngTuyen>();
            var query = db.tblUNGVIENs.Join(db.tblVTTD_UNGTUYENs, u => u.MaUV, v => v.MaUV_UV, (u, v) => new { u, v })
                .Where(uv => uv.v.TrangThaiDC == true ).Distinct().ToList();
            foreach (var uv in query)
            {
                lstUV.Add(new clsUngVienUngTuyen((int)uv.u.MaUV, uv.u.TenUV, uv.u.GioiTinh.ToString() == "Nam" ? true : false,
                        DateTime.Parse(uv.u.NgaySinh.ToString()), uv.u.Email, uv.u.CMND.ToString(), uv.u.SDT, uv.u.TrinhDoHV, uv.u.NgoaiNgu,
                        (int)uv.u.SoNamKN, uv.u.CV.ToString(), (int)uv.v.MaVT_VT, (bool)uv.v.TrangThaiDC, (bool)uv.v.TrangThaiPD));
            }
            return lstUV;
        }

        public List<clsUngVienUngTuyen> GetUVPheDuyetChuaCoLich()
        {
            List<clsUngVienUngTuyen> lstUV = new List<clsUngVienUngTuyen>();
            //get nhung ung vien co vi tri = maVT va TTDC = false
            var query = db.tblUNGVIENs.Join(db.tblVTTD_UNGTUYENs, u => u.MaUV, v => v.MaUV_UV, (u, v) => new { u, v })
                .Where(uv => uv.v.TrangThaiDC == true)
                .Where(uv => !db.tblLICHPV_UNGVIENs.Any(l => uv.u.MaUV == l.MaUV_UV))
                .Distinct().ToList();
            foreach (var uv in query)
            {
                lstUV.Add(new clsUngVienUngTuyen((int)uv.u.MaUV, uv.u.TenUV, uv.u.GioiTinh.ToString() == "Nam" ? true : false,
                        DateTime.Parse(uv.u.NgaySinh.ToString()), uv.u.Email, uv.u.CMND.ToString(), uv.u.SDT, uv.u.TrinhDoHV, uv.u.NgoaiNgu,
                        (int)uv.u.SoNamKN, uv.u.CV.ToString(), (int)uv.v.MaVT_VT, (bool)uv.v.TrangThaiDC, (bool)uv.v.TrangThaiPD));
            }
            return lstUV;
        }


        public List<clsUngVienUngTuyen> TimKiemUVDeCuTheoViTri(int maVT)
        {
            List<clsUngVienUngTuyen> lstUV = new List<clsUngVienUngTuyen>();
            //get nhung ung vien co vi tri = maVT va TTDC = false
            var query = db.tblUNGVIENs.Join(db.tblVTTD_UNGTUYENs, u => u.MaUV, v => v.MaUV_UV, (u, v) => new { u, v })
                .Where(uv => uv.v.MaVT_VT == maVT && uv.v.TrangThaiDC == true).ToList();
            foreach (var uv in query)
            {
                lstUV.Add(new clsUngVienUngTuyen((int)uv.u.MaUV, uv.u.TenUV, uv.u.GioiTinh.ToString() == "Nam" ? true : false,
                        DateTime.Parse(uv.u.NgaySinh.ToString()), uv.u.Email, uv.u.CMND.ToString(), uv.u.SDT, uv.u.TrinhDoHV, uv.u.NgoaiNgu,
                        (int)uv.u.SoNamKN, uv.u.CV.ToString(), (int)uv.v.MaVT_VT, (bool)uv.v.TrangThaiDC, (bool)uv.v.TrangThaiPD));
            }
            return lstUV;
        }

        public List<clsUngVienUngTuyen> TimKiemUVPheDuyetTheoViTri(int maVT)
        {
            List<clsUngVienUngTuyen> lstUV = new List<clsUngVienUngTuyen>();
            //get nhung ung vien co vi tri = maVT va TTDC = false

            var query = db.tblUNGVIENs.Join(db.tblVTTD_UNGTUYENs, u => u.MaUV, v => v.MaUV_UV, (u, v) => new { u, v })
                .Where(uv => uv.v.MaVT_VT == maVT && uv.v.TrangThaiDC == true)
                .Where(uv => !db.tblLICHPV_UNGVIENs.Any(l => uv.u.MaUV == l.MaUV_UV)).ToList();
            foreach (var uv in query)
            {
                lstUV.Add(new clsUngVienUngTuyen((int)uv.u.MaUV, uv.u.TenUV, uv.u.GioiTinh.ToString() == "Nam" ? true : false,
                        DateTime.Parse(uv.u.NgaySinh.ToString()), uv.u.Email, uv.u.CMND.ToString(), uv.u.SDT, uv.u.TrinhDoHV, uv.u.NgoaiNgu,
                        (int)uv.u.SoNamKN, uv.u.CV.ToString(), (int)uv.v.MaVT_VT, (bool)uv.v.TrangThaiDC, (bool)uv.v.TrangThaiPD));
            }
            return lstUV;
        }


    }
}

