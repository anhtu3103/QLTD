using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.src.Controlers
{
    class ctrlQLNhanVien : Services.connDB
    {
        public ctrlQLNhanVien()
        {
            
        }

        public List<clsNhanVienTuyenDung> GetDSNVChuaCoTK()
        {
            List<clsNhanVienTuyenDung> lstNV = new List<clsNhanVienTuyenDung>();
            var query = db.tblNHANVIENs.Where(n => !db.tblTAIKHOANs.Any(tk => n.ID == tk.ID_NV)).ToList();
            foreach (var i in query)
            {
                clsNhanVienTuyenDung nv = new clsNhanVienTuyenDung();
                nv._Id_NV = i.ID.ToString();
                nv._StrHoTen_NV = i.TenNV;
                nv._StrChucVu = i.ChucVu;
                lstNV.Add(nv);
            }
            return lstNV;
        }

        public List<clsNhanVienTuyenDung> GetDSNVDaCoTK()
        {
            List<clsNhanVienTuyenDung> lstNV = new List<clsNhanVienTuyenDung>();
            var query = db.tblNHANVIENs.Where(n => db.tblTAIKHOANs.Any(tk => n.ID == tk.ID_NV)).ToList();
            foreach (var i in query)
            {
                clsNhanVienTuyenDung nv = new clsNhanVienTuyenDung();
                nv._Id_NV = i.ID.ToString();
                nv._StrHoTen_NV = i.TenNV;
                nv._StrChucVu = i.ChucVu;
                lstNV.Add(nv);
            }
            return lstNV;
        }

        public List<clsRole> GetDataForcboRole()
        {
            List<clsRole> lstRole = new List<clsRole>();
            var query = db.tblROLEs.Select(t => t).ToList();
            foreach (var item in query)
            {
                clsRole r = new clsRole((int)item.MaRole, item.TenRole, item.MoTa);
                lstRole.Add(r);
            }
            
            return lstRole;
        }

        public string[] GetThongTinChoTaiKhoan(int maTK)
        {
            //List<String> lstTTTK = new List<String>();
            var query = db.tblROLEs.Join(db.tblTAIKHOANs, r => r.MaRole, t => t.MaRole_R, (r, t) => new { r, t })
                        .Where(rt => rt.t.ID_NV == maTK).Select(rt => new { rt.t.ID_NV, rt.r.TenRole, rt.t.Passwords, rt.t.Usernames }).FirstOrDefault();

            string[] thongtinTK = new string[] { query.ID_NV.ToString(), query.Usernames, query.Passwords, query.TenRole };
            return thongtinTK;
        }
    }
}
