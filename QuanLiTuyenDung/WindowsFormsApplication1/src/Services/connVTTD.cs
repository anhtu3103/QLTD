using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.src.Services
{
    public class connVTTD : connDB
    {
        public connVTTD()
        {
            db.Connection.Open();
        }

        public bool ThemVTTD(clsViTriTuyenDung uvAdd)
        {
            System.Data.Common.DbTransaction suaTran = db.Connection.BeginTransaction();
            try
            {
                db.Transaction = suaTran;

                src.DAOs.DB_QLTD.tblVITRI_TD vt = new DAOs.DB_QLTD.tblVITRI_TD();
                //vt.MaVT = 12;
                vt.TenVT = uvAdd._StrTenViTri;
                vt.SoLuong = uvAdd._SoLuong;
                vt.DiaDiemLV = uvAdd._StrDiaDiemLV;
                vt.Luong = uvAdd._MucLuong;
                vt.NgayHetHan = uvAdd._NgayHetHan;
                vt.MoTa = uvAdd._StrMoTa;
                vt.YeuCau = uvAdd._StrYeuCau;
                vt.QuyenLoi = uvAdd._StrQuyenLoi;
                db.tblVITRI_TDs.InsertOnSubmit(vt);
                db.SubmitChanges();

                db.Transaction.Commit();
                return true;
            }
            catch
            {
                db.Transaction.Rollback();
                return false;
            }
        }
    }
}
