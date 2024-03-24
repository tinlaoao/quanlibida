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
    public partial class frmDoanhThu : Form
    {
        public frmDoanhThu(ArrayList doanhThus)
        {
            InitializeComponent();
            this.doanhThus = doanhThus;
            foreach(DoanhThu doanhThu in doanhThus)
            {
                ListViewItem dt = new System.Windows.Forms.ListViewItem(new string[] { doanhThu.thoiGian.ToString(), doanhThu.loai, doanhThu.doanhThu.ToString() });
                lvDoanhThu.Items.AddRange(new System.Windows.Forms.ListViewItem[] { dt });
                
            }
        }

        public ArrayList doanhThus { get; private set; }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lvDoanhThu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
