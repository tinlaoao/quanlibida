using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlibida
{
    public class BanBida
    {
        private DateTime batDau;
        private DateTime ketThuc;
        private string ten;
        private string loai;

        public ArrayList dichVu { get; private set; }

        public BanBida(String ten, String loai,ArrayList dichVu)
        {
            this.ten = ten;
            this.loai = loai;
            this.dichVu = dichVu;
        }

        private int gioSangPhut(TimeSpan thoiGianBatDau)
        {
            return thoiGianBatDau.Hours * 60 + thoiGianBatDau.Minutes;
        }
        public int tinhTongTien()
        {

            int phutBatDau = gioSangPhut(this.batDau.TimeOfDay);
            int phutKetThuc = gioSangPhut(this.ketThuc.TimeOfDay);
            int phutDoiGia = gioSangPhut(DateTime.Parse("5/5/2005 18:00:00").TimeOfDay);
            int tienKhungGio1 = 750;
            int tienKhungGio2 = 1000;
            int tongTien;
            
            //8--------18-s----e------23
            if (phutBatDau > phutDoiGia)
            {

                tongTien = (phutKetThuc - phutBatDau) * tienKhungGio2;
            }
            //8----s---e----18-------23
            else if (phutKetThuc < phutDoiGia)
            {

                tongTien = (phutKetThuc - phutBatDau) * tienKhungGio1;
            }
            //8----s----18----e---23
            else
            {
                tongTien = (phutDoiGia - phutBatDau) * tienKhungGio1 + (phutKetThuc - phutDoiGia) * tienKhungGio2;
            }
            this.batDau = DateTime.MinValue;
            foreach(DichVu dv in dichVu)
            {
                tongTien += dv.gia;
            }
            return tongTien;
        }
        internal string getLoai()
        {
            return loai;
        }
        internal string getTen()
        {
            return ten;
        }
        public void Start()
        {
            this.batDau = DateTime.Now;
        }
        public void Stop()
        {
            this.ketThuc = DateTime.Now;
        }
        public DateTime GetBatDau()
        {
            return batDau;
        }
        public DateTime getKetThuc() { return ketThuc; }
    }
}
