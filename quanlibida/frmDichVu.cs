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
    public partial class frmDichVu : Form
    {
        public frmDichVu(BindingList<DichVu> dichVu)
        {
            InitializeComponent();
            this.dichVu = dichVu;

            lbDichVu.DataSource = dichVu;
            lbDichVu.DisplayMember = "ten";

        }

        public BindingList<DichVu> dichVu { get; private set; }

     

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DichVu selectedDichVu = lbDichVu.SelectedItem as DichVu;
            tbTenDV.Text = selectedDichVu.ten;
            tbGia.Text = selectedDichVu.gia.ToString();
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            string ten = tbTenDV.Text;
            int gia = Int32.Parse(tbGia.Text);
            DichVu dichVuMoi  = new DichVu(ten, gia);
            this.dichVu.Add(dichVuMoi);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm form1 = new MainForm();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             ((DichVu)lbDichVu.SelectedItem).ten = tbTenDV.Text;
            ((DichVu)lbDichVu.SelectedItem).gia = Int32.Parse(tbGia.Text);
            
        }
    }
}
