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
        public ArrayList banBidas { get; private set; }

        BanBida ban1 = new BanBida("ban 1", "phang", new ArrayList());
        BanBida ban2 = new BanBida("ban 2", "phang", new ArrayList());
        BanBida ban3 = new BanBida("ban 3", "phang", new ArrayList());
        BanBida ban4 = new BanBida("ban 4", "lo", new ArrayList());
        BanBida ban5 = new BanBida("ban 5", "lo", new ArrayList());
        BanBida ban6 = new BanBida("ban 6", "lo", new ArrayList());
        public MainForm()
        {
            InitializeComponent();
            this.dichVu = new BindingList<DichVu>();
            this.banBidas = new ArrayList();
            banBidas.Add(ban1);
            banBidas.Add(ban2);
            banBidas.Add(ban3);
            banBidas.Add(ban4);
            banBidas.Add(ban5);
            banBidas.Add(ban6);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmBanBida frmBanBida = new frmBanBida(banBidas,dichVu);
            frmBanBida.Show();
            //this.Hide();

        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            frmDichVu frmDichVu = new frmDichVu(dichVu);

            frmDichVu.Show();
            //this.Hide();
        }
    }
}
