namespace LichCongTac
{
    partial class frmGioiThieu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGioiThieu));
            this.label1 = new System.Windows.Forms.Label();
            this.picBoxGioiThieu = new System.Windows.Forms.PictureBox();
            this.timerGt1 = new System.Windows.Forms.Timer(this.components);
            this.imageListGt = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGioiThieu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(82, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHẦN MỀM QUẢN LÝ CÔNG VIỆC";
            // 
            // picBoxGioiThieu
            // 
            this.picBoxGioiThieu.Location = new System.Drawing.Point(204, 105);
            this.picBoxGioiThieu.Name = "picBoxGioiThieu";
            this.picBoxGioiThieu.Size = new System.Drawing.Size(100, 100);
            this.picBoxGioiThieu.TabIndex = 1;
            this.picBoxGioiThieu.TabStop = false;
            // 
            // timerGt1
            // 
            this.timerGt1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imageListGt
            // 
            this.imageListGt.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListGt.ImageStream")));
            this.imageListGt.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListGt.Images.SetKeyName(0, "");
            this.imageListGt.Images.SetKeyName(1, "");
            this.imageListGt.Images.SetKeyName(2, "");
            this.imageListGt.Images.SetKeyName(3, "");
            this.imageListGt.Images.SetKeyName(4, "");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "CopyRight By LTV12_Ced@sit.com.vn\r\n\r\n";
            // 
            // timerLabel
            // 
            this.timerLabel.Tick += new System.EventHandler(this.timerLabel_Tick);
            // 
            // frmGioiThieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(536, 286);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picBoxGioiThieu);
            this.Controls.Add(this.label1);
            this.Name = "frmGioiThieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmGioiThieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGioiThieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBoxGioiThieu;
        private System.Windows.Forms.Timer timerGt1;
        private System.Windows.Forms.ImageList imageListGt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timerLabel;
    }
}