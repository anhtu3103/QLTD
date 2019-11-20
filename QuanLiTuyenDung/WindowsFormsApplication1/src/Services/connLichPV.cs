using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.src.Services
{
    public class connLichPV : connDB
    {
        public connLichPV()
        {
            db.Connection.Open();
        }
        //public tblSach CheckIfExists(string maS)
        //{            
        //    tblSach s = db.tblSaches.Where(t => t.MaSach == maS).FirstOrDefault();
        //    if (s != null)
        //    {               
        //        return s;

        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}

        public int InsertLich(clsLichPhongVan lichThem)
        {
            System.Data.Common.DbTransaction insTran = db.Connection.BeginTransaction();
            //insTran = db.Connection.BeginTransaction();
            try
            {
                db.Transaction = insTran;

                db.SubmitChanges();
                db.Transaction.Commit();
                return 1;

            }
            catch (Exception ex)
            {
                db.Transaction.Rollback();
                throw new Exception(ex.Message);
            }
        }

        //public bool Sua(tblSach sSua)
        //{
        //    System.Data.Common.DbTransaction suaTran = db.Connection.BeginTransaction();
        //    try
        //    {
        //        db.Transaction = suaTran;
        //        tblSach s = db.tblSaches.Where(t => t.MaSach == sSua.MaSach).FirstOrDefault();
        //        s.TenSach = sSua.TenSach;
        //        s.ChuDe = sSua.ChuDe;
        //        s.NamXB = sSua.NamXB;
        //        s.MaTG = sSua.MaTG;
        //        s.MaNXB = sSua.MaNXB;
        //        s.MaKho = sSua.MaKho;

        //        db.SubmitChanges();
        //        db.Transaction.Commit();
        //        return true;

        //    }
        //    catch (Exception ex)
        //    {
        //        db.Transaction.Rollback();
        //        throw new Exception("Lỗi không sửa được" + ex.Message);
        //    }
        //}

        //public int DeleteSach(tblSach sXoa)
        //{

        //    System.Data.Common.DbTransaction xoaTran = db.Connection.BeginTransaction();
        //    try
        //    {
        //        db.Transaction = xoaTran;

        //        tblSach s = db.tblSaches.Where(t => t.MaSach == sXoa.MaSach).FirstOrDefault();
        //        if (s != null)
        //        {
        //            db.tblSaches.DeleteOnSubmit(s);
        //            db.SubmitChanges();
        //            db.Transaction.Commit();
        //            return 1;
        //        }
        //        else
        //            return 0;

        //    }
        //    catch (Exception ex)
        //    {
        //        db.Transaction.Rollback();
        //        throw new Exception(ex.Message);

        //    }

        //}
    }
}
