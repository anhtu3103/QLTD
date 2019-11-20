using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class clsUngVienPhongVan : clsAbsUngVien
    {
        private clsLichPhongVan lichPV;

        public clsLichPhongVan _LichPV
        {
            get { return lichPV; }
            set { lichPV = value; }
        }


        public clsUngVienPhongVan() : base()
        {
            this.lichPV = new clsLichPhongVan();
        }

        public clsUngVienPhongVan(int maUV, string tenUV, bool gt, DateTime ngaySinh, string email, string soCMND, string sdt, string trinhDo,
            string ngoaiNgu, int namKN, int maNV, string cv, int mavitri, clsLichPhongVan lichPV)
            : base( maUV,  tenUV,  gt,  ngaySinh,  email,  soCMND,  sdt,  trinhDo, 
             ngoaiNgu,  namKN,  cv,  mavitri)
        {
            this.lichPV = new clsLichPhongVan(lichPV);
        }


    }
}
