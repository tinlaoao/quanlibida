namespace quanlibida
{
    partial class frmDoanhThu
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.lvDoanhThu = new System.Windows.Forms.ListView();
            this.ngay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loaiban = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.doanhThu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvDoanhThu
            // 
            this.lvDoanhThu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ngay,
            this.loaiban,
            this.doanhThu});
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            this.lvDoanhThu.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.lvDoanhThu.HideSelection = false;
            this.lvDoanhThu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lvDoanhThu.Location = new System.Drawing.Point(69, 81);
            this.lvDoanhThu.Name = "lvDoanhThu";
            this.lvDoanhThu.Size = new System.Drawing.Size(656, 329);
            this.lvDoanhThu.TabIndex = 0;
            this.lvDoanhThu.UseCompatibleStateImageBehavior = false;
            this.lvDoanhThu.View = System.Windows.Forms.View.Details;
            this.lvDoanhThu.SelectedIndexChanged += new System.EventHandler(this.lvDoanhThu_SelectedIndexChanged);
            // 
            // ngay
            // 
            this.ngay.Text = "Ngay";
            this.ngay.Width = 122;
            // 
            // loaiban
            // 
            this.loaiban.Text = "Loai";
            this.loaiban.Width = 172;
            // 
            // doanhThu
            // 
            this.doanhThu.Text = "Doanh thu";
            this.doanhThu.Width = 114;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doanh thu hom nay";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvDoanhThu);
            this.Name = "frmDoanhThu";
            this.Text = "frmDoanhThu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvDoanhThu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader ngay;
        private System.Windows.Forms.ColumnHeader loaiban;
        private System.Windows.Forms.ColumnHeader doanhThu;
    }
}