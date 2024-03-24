using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlibida
{
    public class NhanVien
    {
        public string ten { get;  set; }
        public string ngaySinh { get;  set; }
        public string viTri { get;  set; }
        public string sdt { get;  set; }
        public string diaChi { get;  set; }
        public string luong { get;  set; }
        public string email { get;  set; }

        public NhanVien(string ten, string ngaySinh, string viTri, string email, string sdt, string diaChi, string luong)
        {
            this.ten = ten;
            this.ngaySinh = ngaySinh;
            this.viTri = viTri;
            this.email = email;
            this.sdt = sdt;
            this.diaChi = diaChi;
            this.luong = luong;

        }
    }
}
