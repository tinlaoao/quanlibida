using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlibida
{
    public class DoanhThu
    {
        public double doanhThu { get; set; }
        public string loai { get; set; }
        public DateTime thoiGian { get; set; }

        public DoanhThu(double doanhThu, string loai,DateTime thoiGian) {
            this.doanhThu = doanhThu;
            this.loai = loai;
            this.thoiGian = thoiGian;
        }
    }
}
