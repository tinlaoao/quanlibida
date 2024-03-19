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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //if (txtEmail.Text.Length < 0 || txtEmail.Text != "admin") { MessageBox.Show("Nhap sai tai khoan", "thong bao"); return; }
            //if (txtMatKhau.Text.Length < 0 || txtMatKhau.Text != "admin") { MessageBox.Show("Nhap sai tai khoan", "thong bao"); return; }
            //MessageBox.Show("Chuc mung ban da dang nhap thanh cong", "thong bao");
            MainForm form1 = new MainForm();
            
            form1.Show();
            this.Hide();
            return;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

