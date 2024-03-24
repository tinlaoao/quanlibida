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
    public partial class frmChonDichVu : Form
    {
        public BindingList<DichVu> dichVus { get; }
        private ArrayList luaChon;
        private BanBida banBida;

        //public frmChonDichVu()
        //{
        //}

        public frmChonDichVu(BindingList<DichVu> dichVus,BanBida banBida)
        {
            InitializeComponent();
            this.dichVus = dichVus;
            this.banBida = banBida;
            this.luaChon = new ArrayList();
            lbLuaChon.DataSource =dichVus;
            lbLuaChon.DisplayMember = "ten";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int soLuong = Int32.Parse(txtSoLuong.Text);
            if(soLuong <=0) { return; }
            DichVu dichVuDaChon = (DichVu)lbLuaChon.SelectedItem;
            for (int i = 0; i < soLuong; i++)
            {
                luaChon.Add(dichVuDaChon);
            }
            lvKetQua.Items.Add(soLuong.ToString() + " " + dichVuDaChon.ten);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            lvKetQua.Clear();
            luaChon.Clear();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
           foreach(DichVu dv in luaChon)
            {
                banBida.dichVu.Add(dv);
            }
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbLuaChon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
