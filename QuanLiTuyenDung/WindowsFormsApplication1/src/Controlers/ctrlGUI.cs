using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.src.Controlers
{
    public class ctrlGUI : Services.connDB
    {
        public ctrlGUI()
        {

        }
        public List<clsUngVienUngTuyen> getDSUngVienChuaDeCu()
        {
            List<clsUngVienUngTuyen> lstUV = new List<clsUngVienUngTuyen>();
            var query = (from u in db.tblUNGVIENs
                         join v in db.tblVTTD_UNGTUYENs on u.MaUV equals v.MaUV_UV
                         where v.TrangThaiDC == false
                         select new { u, v }).Distinct().ToList();
            foreach (var uv in query)
            {
                lstUV.Add(new clsUngVienUngTuyen((int)uv.u.MaUV, uv.u.TenUV, uv.u.GioiTinh.ToString() == "Nam" ? true : false,
                        DateTime.Parse(uv.u.NgaySinh.ToString()), uv.u.Email, uv.u.CMND.ToString(), uv.u.SDT, uv.u.TrinhDoHV, uv.u.NgoaiNgu,
                        (int)uv.u.SoNamKN, uv.u.CV.ToString(), (int)uv.v.MaVT_VT, (bool)uv.v.TrangThaiDC, (bool)uv.v.TrangThaiPD));
            }
            return lstUV;
        }
        public List<clsViTriTuyenDung> GetVitriTuyenDung()
        {

            var query = (from VT in db.tblVITRI_TDs
                         select VT).ToList();

            List<clsViTriTuyenDung> lst_Vttd = new List<clsViTriTuyenDung>();

            foreach (var item in query)
            {
                clsViTriTuyenDung vt = new clsViTriTuyenDung((int)item.MaVT, item.TenVT, (int)item.SoLuong, item.DiaDiemLV,
                    (DateTime)item.NgayHetHan, item.MoTa, item.YeuCau, item.QuyenLoi, item.Luong);
                lst_Vttd.Add(vt);
            }
            return lst_Vttd;
        }

        public List<string> GetTrinhDo()
        {
            var query = (from UV in db.tblUNGVIENs
                         select UV.TrinhDoHV).Distinct().ToList();
            List<string> lstTD = new List<string>();
            foreach (var item in query)
            {
                lstTD.Add(item);
            }
            return lstTD;
        }
        public List<string> GetNgoaiNgu()
        {
            var query = (from UV in db.tblUNGVIENs
                         select UV.NgoaiNgu).Distinct().ToList();
            List<string> lstNN = new List<string>();
            foreach (var item in query)
            {
                lstNN.Add(item);
            }
            return lstNN;
        }

        
    }
}
