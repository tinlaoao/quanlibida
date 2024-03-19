using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlibida
{
    public class DichVu
    {
        public DichVu(string ten, int gia) {
            this.ten = ten;
            this.gia = gia;
        }

        public string ten { get; set; }
        public int gia { get; set; }
    }
}
