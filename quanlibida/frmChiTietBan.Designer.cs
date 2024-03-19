namespace quanlibida
{
    partial class frmChiTietBan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbBatDau = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btnBaoHanh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDichVu = new System.Windows.Forms.Button();
            this.lvHoaDon = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.Location = new System.Drawing.Point(46, 21);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(56, 29);
            this.lbTen.TabIndex = 0;
            this.lbTen.Text = "Ten";
            this.lbTen.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start:";
            // 
            // lbBatDau
            // 
            this.lbBatDau.AutoSize = true;
            this.lbBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBatDau.Location = new System.Drawing.Point(122, 89);
            this.lbBatDau.Name = "lbBatDau";
            this.lbBatDau.Size = new System.Drawing.Size(51, 29);
            this.lbBatDau.TabIndex = 2;
            this.lbBatDau.Text = "null";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(49, 145);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(172, 62);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Enabled = false;
            this.btnTinhTien.Location = new System.Drawing.Point(53, 316);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(172, 62);
            this.btnTinhTien.TabIndex = 4;
            this.btnTinhTien.Text = "Tinh Tien";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btnBaoHanh
            // 
            this.btnBaoHanh.Location = new System.Drawing.Point(56, 509);
            this.btnBaoHanh.Name = "btnBaoHanh";
            this.btnBaoHanh.Size = new System.Drawing.Size(172, 62);
            this.btnBaoHanh.TabIndex = 7;
            this.btnBaoHanh.Text = "Bao hanh";
            this.btnBaoHanh.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(307, 450);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "8/2022 - 8/2024";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 450);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Thong tin bao hanh:";
            // 
            // btnDichVu
            // 
            this.btnDichVu.Enabled = false;
            this.btnDichVu.Location = new System.Drawing.Point(53, 230);
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.Size = new System.Drawing.Size(172, 62);
            this.btnDichVu.TabIndex = 8;
            this.btnDichVu.Text = "Dich vu";
            this.btnDichVu.UseVisualStyleBackColor = true;
            // 
            // lvHoaDon
            // 
            this.lvHoaDon.HideSelection = false;
            this.lvHoaDon.Location = new System.Drawing.Point(285, 145);
            this.lvHoaDon.Name = "lvHoaDon";
            this.lvHoaDon.Size = new System.Drawing.Size(690, 233);
            this.lvHoaDon.TabIndex = 9;
            this.lvHoaDon.UseCompatibleStateImageBehavior = false;
            this.lvHoaDon.View = System.Windows.Forms.View.List;
            this.lvHoaDon.Visible = false;
            this.lvHoaDon.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedndexChanged);
            // 
            // frmChiTietBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 706);
            this.Controls.Add(this.lvHoaDon);
            this.Controls.Add(this.btnDichVu);
            this.Controls.Add(this.btnBaoHanh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbBatDau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTen);
            this.Name = "frmChiTietBan";
            this.Text = "frmChiTietBan";
            this.Load += new System.EventHandler(this.frmChiTietBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbBatDau;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnTinhTien;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btnBaoHanh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDichVu;
        private System.Windows.Forms.ListView lvHoaDon;
    }
}