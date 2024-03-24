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
    public partial class frmBanBida : Form
    {
     

        public BindingList<DichVu> dichVu { get; private set; }
        public ArrayList banBidas { get; private set; }
        public ArrayList doanhThus { get; private set; }

        public frmBanBida(ArrayList banBidas,BindingList<DichVu> dichVus,ArrayList doanhThus)
        {
            InitializeComponent();
            this.dichVu = dichVus;
            this.banBidas = banBidas;
            this.doanhThus = doanhThus;
        }

     

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm form1 = new MainForm();
            form1.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmChiTietBan frmChiTietBan = new frmChiTietBan((BanBida)banBidas[0],dichVu,doanhThus);
            frmChiTietBan.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmChiTietBan frmChiTietBan = new frmChiTietBan((BanBida)banBidas[1], dichVu, doanhThus);
            frmChiTietBan.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frmChiTietBan frmChiTietBan = new frmChiTietBan((BanBida)banBidas[2], dichVu, doanhThus);
            frmChiTietBan.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmChiTietBan frmChiTietBan = new frmChiTietBan((BanBida)banBidas[3], dichVu, doanhThus);
            frmChiTietBan.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmChiTietBan frmChiTietBan = new frmChiTietBan((BanBida)banBidas[4], dichVu, doanhThus);
            frmChiTietBan.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmChiTietBan frmChiTietBan = new frmChiTietBan((BanBida)banBidas[5], dichVu, doanhThus);
            frmChiTietBan.Show();
        }

        private void frmBanBida_Load(object sender, EventArgs e)
        {

        }
    }
}
