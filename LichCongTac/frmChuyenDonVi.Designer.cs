namespace LichCongTac
{
    partial class frmChuyenDonVi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.txtDonViCanDoi = new System.Windows.Forms.TextBox();
            this.comboCauHinh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboLoaiChuyenDoi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtKetQua);
            this.groupBox1.Controls.Add(this.txtDonViCanDoi);
            this.groupBox1.Controls.Add(this.comboCauHinh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboLoaiChuyenDoi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-1, -8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 208);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kết Quả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Đơn Vị Cần Đổi";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(141, 145);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(256, 20);
            this.txtKetQua.TabIndex = 5;
            // 
            // txtDonViCanDoi
            // 
            this.txtDonViCanDoi.Location = new System.Drawing.Point(141, 108);
            this.txtDonViCanDoi.Name = "txtDonViCanDoi";
            this.txtDonViCanDoi.Size = new System.Drawing.Size(256, 20);
            this.txtDonViCanDoi.TabIndex = 4;
            this.txtDonViCanDoi.TextChanged += new System.EventHandler(this.txtDonViCanDoi_TextChanged);
            // 
            // comboCauHinh
            // 
            this.comboCauHinh.FormattingEnabled = true;
            this.comboCauHinh.Location = new System.Drawing.Point(141, 71);
            this.comboCauHinh.Name = "comboCauHinh";
            this.comboCauHinh.Size = new System.Drawing.Size(256, 21);
            this.comboCauHinh.TabIndex = 3;
            this.comboCauHinh.SelectedIndexChanged += new System.EventHandler(this.comboCauHinh_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cấu Hình";
            // 
            // comboLoaiChuyenDoi
            // 
            this.comboLoaiChuyenDoi.FormattingEnabled = true;
            this.comboLoaiChuyenDoi.Location = new System.Drawing.Point(141, 36);
            this.comboLoaiChuyenDoi.Name = "comboLoaiChuyenDoi";
            this.comboLoaiChuyenDoi.Size = new System.Drawing.Size(256, 21);
            this.comboLoaiChuyenDoi.TabIndex = 1;
            this.comboLoaiChuyenDoi.SelectedIndexChanged += new System.EventHandler(this.comboLoaiChuyenDoi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại Chuyển Đổi";
            // 
            // frmChuyenDonVi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(451, 198);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmChuyenDonVi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuyển Đơn Vị";
            this.Load += new System.EventHandler(this.frmChuyenDonVi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.TextBox txtDonViCanDoi;
        private System.Windows.Forms.ComboBox comboCauHinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboLoaiChuyenDoi;
        private System.Windows.Forms.Label label1;
    }
}