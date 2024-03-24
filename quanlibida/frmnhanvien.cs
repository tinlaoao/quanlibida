using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlibida
{
    public partial class frmnhanvien : Form
    {
        public BindingList<NhanVien> nhanViens { get; private set; }

        public frmnhanvien(BindingList<NhanVien> nhanViens)
        {
            InitializeComponent();
            this.nhanViens = nhanViens;
        
            foreach (NhanVien nv in nhanViens)
            { 
                string[] row = { nv.ten, nv.ngaySinh, nv.viTri, nv.email, nv.sdt, nv.diaChi, nv.luong };
                var listViewItem = new ListViewItem(row);
                lvTTNV.Items.Add(listViewItem);

            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frmnhanvien_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem itemNhanVien = new System.Windows.Forms.ListViewItem(new string[] { txtTen.Text, dtpkNgaySinh.Text, txtViTri.Text, txtEmail.Text, txtSDT.Text, txtDiaChi.Text, txtLuong.Text });
            lvTTNV.Items.AddRange(new System.Windows.Forms.ListViewItem[] { itemNhanVien });
            nhanViens.Add(new NhanVien(txtTen.Text, dtpkNgaySinh.Text, txtViTri.Text, txtEmail.Text, txtSDT.Text, txtDiaChi.Text, txtLuong.Text));
            btnHuy_Click(sender, e);

        }



        private void btnXoa_Click(object sender, EventArgs e)
        {
            var nhanvien = lvTTNV.SelectedItems[0];
            for(int i = 0;i<nhanViens.Count; i++)
            {
                NhanVien nv = nhanViens[i];
                if (nv.email.Equals(nhanvien.SubItems[3].Text))
                {

                    nhanViens.Remove(nv);
                    break;

                }
            }
            //foreach (NhanVien nv in nhanViens)
            //{
            //    if (nv.email.Equals(nhanvien.SubItems[3].Text))
            //    {

            //        nhanViens.Remove(nv);

            //    }
            //}
            nhanvien.Remove();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            var nhanvien = lvTTNV.SelectedItems;
            nhanvien[0].SubItems[0].Text = txtTen.Text;
            int nam, thang, ngay;
            string[] textngaythang = dtpkNgaySinh.Text.Split('/');
            nam = Convert.ToInt32(textngaythang[2]);
            thang = Convert.ToInt32(textngaythang[1]);
            ngay = Convert.ToInt32(textngaythang[0]);
            nhanvien[0].SubItems[1].Text = new DateTime(nam, thang, ngay).ToString("dd/M/yyyy", CultureInfo.InvariantCulture);
            nhanvien[0].SubItems[2].Text = txtViTri.Text;
            nhanvien[0].SubItems[3].Text = txtEmail.Text;
            nhanvien[0].SubItems[4].Text = txtSDT.Text;
            nhanvien[0].SubItems[5].Text = txtDiaChi.Text;
            nhanvien[0].SubItems[6].Text = txtLuong.Text;
            foreach (NhanVien nv in nhanViens)
            {
                if (nv.email.Equals(nhanvien[0].SubItems[3].Text))
                {
                    nv.ten = txtTen.Text;
                    nv.ngaySinh = nhanvien[0].SubItems[1].Text;
                    nv.viTri = txtViTri.Text;

                    nv.sdt = txtSDT.Text;
                    nv.diaChi = txtDiaChi.Text;
                    nv.luong = txtLuong.Text;

                }
            }
            btnHuy_Click(sender, e);
        }

        private void lvTTNV_ItemsSelectiom(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var item = e.Item;
            txtTen.Text = item.SubItems[0].Text;
            int nam, thang, ngay;
            string[] textngaythang = item.SubItems[1].Text.Split('/');
            nam = Convert.ToInt32(textngaythang[2]);
            thang = Convert.ToInt32(textngaythang[1]);
            ngay = Convert.ToInt32(textngaythang[0]);
            dtpkNgaySinh.Text = new DateTime(nam, thang, ngay).ToString();
            txtViTri.Text = item.SubItems[2].Text;
            txtEmail.Text = item.SubItems[3].Text;
            txtSDT.Text = item.SubItems[4].Text;
            txtDiaChi.Text = item.SubItems[5].Text;
            txtLuong.Text = item.SubItems[6].Text;
            

        }

        private void lvTTNV_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtLuong.Text = "";
            txtSDT.Text = "";
            txtTen.Text = "";
            txtViTri.Text = "";
            dtpkNgaySinh.Value = DateTime.Now;
        }
    }
}
