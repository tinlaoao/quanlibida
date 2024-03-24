using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlibida
{
    public partial class frmChiTietBan : Form
    {
        public BindingList<DichVu> dichVus { get; private set; }

        private BanBida banBida;

        public ArrayList doanhThus { get; private set; }

        //public frmChiTietBan()
        //{
        //    initializecomponent();
        //}

        public frmChiTietBan(BanBida banBida,BindingList<DichVu> dichVus,ArrayList doanhThus)
        {
            InitializeComponent();
            this.dichVus = dichVus;
            this.banBida = banBida;
            this.doanhThus = doanhThus;
            lbTen.Text = banBida.getTen();
            if (banBida.GetBatDau() != DateTime.MinValue)
            {
                toggleStart("on");
            }
            else
            {
                toggleStart("off");
            }

        }
        private void toggleStart(string status)
        {
            if (status == "on")
            {

                
                lbBatDau.Text = banBida.GetBatDau().ToString("HH:mm:ss");
                btnTinhTien.Enabled = true;
                btnDichVu.Enabled = true;
                btnStart.Enabled = false;
            }
            else
            {
                
                lbBatDau.Text = "null";
                btnTinhTien.Enabled = false;
                btnDichVu.Enabled = false;
                btnStart.Enabled = true;
            }
        }
        private void frmChiTietBan_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lvHoaDon.Items.Clear();
            DateTime gioHienTai = DateTime.Now;
            if (gioHienTai.TimeOfDay < DateTime.Parse("5/5/2005 8:00:00").TimeOfDay || gioHienTai.TimeOfDay > DateTime.Parse("5/5/2005 23:00:00").TimeOfDay)
            {
                MessageBox.Show("Chua mo cua", "thong bao");
                return;
            }
            banBida.Start();
            toggleStart("on");
        
        }



        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            banBida.Stop(); 
            lvHoaDon.Visible = true;
            DateTime batDau = banBida.GetBatDau();
            DateTime ketThuc = banBida.getKetThuc();
            double tong = banBida.tinhTongTien();
            Dictionary<DichVu, int> dichVuMap = new Dictionary<DichVu, int>();
            foreach(DichVu v in banBida.dichVu)
            {
                if (!dichVuMap.ContainsKey(v))
                {
                dichVuMap.Add(v,1);
                }
                else
                {
                    dichVuMap[v] += 1;
                }
            }
            lvHoaDon.Items.Add("Bat dau:" + batDau.ToString("HH:mm:ss"));
            lvHoaDon.Items.Add("Ket thuc: " + ketThuc.ToString("HH:mm:ss"));
            lvHoaDon.Items.Add("Tong thoi gian: " + (ketThuc - batDau));
            foreach(var pair in dichVuMap)
            {
                lvHoaDon.Items.Add($"Dich vu: {pair.Value} {pair.Key.ten}");
            }
            lvHoaDon.Items.Add("Tong tien: " + tong);
            banBida.dichVu.Clear();
            DoanhThu doanhThu = new DoanhThu(tong, banBida.getLoai(), ketThuc);
            
            doanhThus.Add(doanhThu);
            toggleStart("off");

        }

       

        private void listView1_SelectedndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            frmChonDichVu chonDichVu = new frmChonDichVu(dichVus,banBida);

            chonDichVu.Show();
           
        }

        private void btnBaoHanh_Click(object sender, EventArgs e)
        {
            DateTime gioHienTai = DateTime.Now;
            DateTime gio2NamSau = DateTime.Now.AddYears(2);
            lbHienTai.Text = gioHienTai.ToString("dd/MM/yyyy");
            lb2Nam.Text = gio2NamSau.ToString("dd/MM/yyyy");
            doanhThus.Add(new DoanhThu(200000,"Bao hanh",gioHienTai));
            btnBaoHanh.Enabled=false;
        }
    }
}
