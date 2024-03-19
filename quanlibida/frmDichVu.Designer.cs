namespace quanlibida
{
    partial class frmDichVu
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
            this.lvDichVu = new System.Windows.Forms.ListView();
            this.lbDichVu = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbTenDV = new System.Windows.Forms.TextBox();
            this.tbGia = new System.Windows.Forms.TextBox();
            this.btnThemDV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvDichVu
            // 
            this.lvDichVu.HideSelection = false;
            this.lvDichVu.Location = new System.Drawing.Point(522, 105);
            this.lvDichVu.Name = "lvDichVu";
            this.lvDichVu.Size = new System.Drawing.Size(528, 286);
            this.lvDichVu.TabIndex = 0;
            this.lvDichVu.UseCompatibleStateImageBehavior = false;
            // 
            // lbDichVu
            // 
            this.lbDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDichVu.FormattingEnabled = true;
            this.lbDichVu.ItemHeight = 29;
            this.lbDichVu.Location = new System.Drawing.Point(12, 36);
            this.lbDichVu.Name = "lbDichVu";
            this.lbDichVu.Size = new System.Drawing.Size(414, 468);
            this.lbDichVu.TabIndex = 1;
            this.lbDichVu.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(551, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thong tin dich vu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(552, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ten dich vu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(552, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gia";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(556, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cap nhat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbTenDV
            // 
            this.tbTenDV.Location = new System.Drawing.Point(671, 196);
            this.tbTenDV.Name = "tbTenDV";
            this.tbTenDV.Size = new System.Drawing.Size(297, 22);
            this.tbTenDV.TabIndex = 7;
            // 
            // tbGia
            // 
            this.tbGia.Location = new System.Drawing.Point(671, 234);
            this.tbGia.Name = "tbGia";
            this.tbGia.Size = new System.Drawing.Size(297, 22);
            this.tbGia.TabIndex = 8;
            // 
            // btnThemDV
            // 
            this.btnThemDV.Location = new System.Drawing.Point(800, 315);
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.Size = new System.Drawing.Size(215, 38);
            this.btnThemDV.TabIndex = 9;
            this.btnThemDV.Text = "Them";
            this.btnThemDV.UseVisualStyleBackColor = true;
            this.btnThemDV.Click += new System.EventHandler(this.btnThemDV_Click);
            // 
            // frmDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 617);
            this.Controls.Add(this.btnThemDV);
            this.Controls.Add(this.tbGia);
            this.Controls.Add(this.tbTenDV);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDichVu);
            this.Controls.Add(this.lvDichVu);
            this.Name = "frmDichVu";
            this.Text = "frmDichVu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvDichVu;
        private System.Windows.Forms.ListBox lbDichVu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbTenDV;
        private System.Windows.Forms.TextBox tbGia;
        private System.Windows.Forms.Button btnThemDV;
    }
}