using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class clsTruongPhongTuyenDung : clsNhanVienTuyenDung
    {
        public clsTruongPhongTuyenDung() : base()
        {

        }

        public clsTruongPhongTuyenDung(string id, string hoTen, string chucVu, clsTaiKhoan taiKhoan) : base(id, hoTen, chucVu, taiKhoan)
        {

        }


    }
}
