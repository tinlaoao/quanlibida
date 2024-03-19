namespace quanlibida
{
    partial class MainForm
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
            this.btnBan = new System.Windows.Forms.Button();
            this.btnDichVu = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBan
            // 
            this.btnBan.Location = new System.Drawing.Point(243, 37);
            this.btnBan.Margin = new System.Windows.Forms.Padding(4, 5, 6, 7);
            this.btnBan.Name = "btnBan";
            this.btnBan.Size = new System.Drawing.Size(287, 66);
            this.btnBan.TabIndex = 1;
            this.btnBan.Text = "Bàn Bida";
            this.btnBan.UseVisualStyleBackColor = true;
            this.btnBan.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDichVu
            // 
            this.btnDichVu.Location = new System.Drawing.Point(243, 223);
            this.btnDichVu.Margin = new System.Windows.Forms.Padding(4, 5, 6, 7);
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.Size = new System.Drawing.Size(287, 66);
            this.btnDichVu.TabIndex = 2;
            this.btnDichVu.Text = "Dịch vụ";
            this.btnDichVu.UseVisualStyleBackColor = true;
            this.btnDichVu.Click += new System.EventHandler(this.btnDichVu_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Location = new System.Drawing.Point(243, 314);
            this.btnBaoCao.Margin = new System.Windows.Forms.Padding(4, 5, 6, 7);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(287, 66);
            this.btnBaoCao.TabIndex = 3;
            this.btnBaoCao.Text = "Báo cáo thống kê";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Location = new System.Drawing.Point(243, 129);
            this.btnNhanVien.Margin = new System.Windows.Forms.Padding(4, 5, 6, 7);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(287, 66);
            this.btnNhanVien.TabIndex = 4;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNhanVien);
            this.Controls.Add(this.btnBaoCao);
            this.Controls.Add(this.btnDichVu);
            this.Controls.Add(this.btnBan);
            this.Name = "MainForm";
            this.Text = "Quản lí";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBan;
        private System.Windows.Forms.Button btnDichVu;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnNhanVien;
    }
}

