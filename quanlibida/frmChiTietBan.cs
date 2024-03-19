using System;
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

        //public frmChiTietBan()
        //{
        //    initializecomponent();
        //}

        public frmChiTietBan(BanBida banBida,BindingList<DichVu> dichVus)
        {
            InitializeComponent();
            this.dichVus = dichVus;
            this.banBida = banBida;
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

            lvHoaDon.Items.Add("Bat dau:" + batDau.ToString("HH:mm:ss"));
            lvHoaDon.Items.Add("Ket thuc: " + ketThuc.ToString("HH:mm:ss"));
            lvHoaDon.Items.Add("Tong thoi gian: " + (ketThuc - batDau));
            lvHoaDon.Items.Add("Tong tien: " + tong);
            
            toggleStart("off");

        }

       

        private void listView1_SelectedndexChanged(object sender, EventArgs e)
        {

        }
    }
}
