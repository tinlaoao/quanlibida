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
    public partial class MainForm : Form
    {
        public BindingList<DichVu> dichVu { get; private set; }
        public BindingList<NhanVien> nhanViens { get;  set; }
        public ArrayList banBidas { get; private set; }
        public ArrayList doanhThus { get; private set; }
        DichVu dv1 = new DichVu("coca", 10000);
        DichVu dv2= new DichVu("pepsi", 10000);
        DichVu dv3 = new DichVu("snack", 10000);
        DichVu dv4 = new DichVu("string", 10000);
        DichVu dv5 = new DichVu("my tom", 10000);
    
        BanBida ban1 = new BanBida("ban 1", "phang", new ArrayList());
        BanBida ban2 = new BanBida("ban 2", "phang", new ArrayList());
        BanBida ban3 = new BanBida("ban 3", "phang", new ArrayList());
        BanBida ban4 = new BanBida("ban 4", "lo", new ArrayList());
        BanBida ban5 = new BanBida("ban 5", "lo", new ArrayList());
        BanBida ban6 = new BanBida("ban 6", "lo", new ArrayList());
        NhanVien nv1 = new NhanVien("aaa", "26/6/2004", "giam doc", "gd@gm.com", "999999", "hcm", "10000");
        NhanVien nv2 = new NhanVien("bbb", "26/6/2002", "an hai", "gd@gm.com", "988889", "hcm", "789");
        NhanVien nv3 = new NhanVien("ccc", "26/6/2001", "bao", "gd@gm.com", "777", "hcm", "999");
        NhanVien nv4 = new NhanVien("ddd", "26/6/2006", "bao ve", "gd@gm.com", "55555", "hcm", "9999");
        NhanVien nv5 = new NhanVien("ddd", "26/6/2006", "ao ve", "d@gm.com", "55555", "hcm", "9999");
        public MainForm()
        {
            InitializeComponent();
            this.dichVu = new BindingList<DichVu>();
            this.banBidas = new ArrayList();
            this.nhanViens = new BindingList<NhanVien>();
            this.doanhThus = new ArrayList();
          
            banBidas.Add(ban1);
            banBidas.Add(ban2);
            banBidas.Add(ban3);
            banBidas.Add(ban4);
            banBidas.Add(ban5);
            banBidas.Add(ban6);
            nhanViens.Add(nv1);
            nhanViens.Add(nv2);
            nhanViens.Add(nv3);
            nhanViens.Add(nv4);
            nhanViens.Add(nv5);
            dichVu.Add(dv1);
            dichVu.Add(dv2);
            dichVu.Add(dv3);
            dichVu.Add(dv4);
            dichVu.Add(dv5);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmBanBida frmBanBida = new frmBanBida(banBidas,dichVu,doanhThus);
            frmBanBida.Show();
            //this.Hide();

        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            frmDichVu frmDichVu = new frmDichVu(dichVu);

            frmDichVu.Show();
            //this.Hide();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            frmnhanvien frmnhanvien = new frmnhanvien(nhanViens);

            frmnhanvien.Show();
            //this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      

        private void button1_Click(object sender, EventArgs e)
        {
frmDoanhThu frmDoanhThu = new frmDoanhThu(doanhThus);

            frmDoanhThu.Show();
        }
    }
}
