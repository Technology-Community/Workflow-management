namespace LichCongTac
{
    partial class frmLichCongTac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLichCongTac));
            this.mcLichCongViec = new Pabo.Calendar.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbNoiDungCongViec = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboTimeEnd = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboMinutesEnd = new System.Windows.Forms.ComboBox();
            this.comboHourEnd = new System.Windows.Forms.ComboBox();
            this.comboTimeStart = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboMinutesStart = new System.Windows.Forms.ComboBox();
            this.comboHourStart = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNgayXongCV = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDongY = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mcLichCongViec
            // 
            this.mcLichCongViec.ActiveMonth.Month = 5;
            this.mcLichCongViec.ActiveMonth.Year = 2008;
            this.mcLichCongViec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mcLichCongViec.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mcLichCongViec.Culture = new System.Globalization.CultureInfo("vi-VN");
            this.mcLichCongViec.Footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcLichCongViec.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.mcLichCongViec.Header.GradientMode = Pabo.Calendar.mcGradientMode.Vertical;
            this.mcLichCongViec.Header.TextColor = System.Drawing.Color.White;
            this.mcLichCongViec.Header.YearSelectors = true;
            this.mcLichCongViec.ImageList = null;
            this.mcLichCongViec.Location = new System.Drawing.Point(18, 23);
            this.mcLichCongViec.MaxDate = new System.DateTime(2018, 4, 29, 11, 27, 56, 578);
            this.mcLichCongViec.MinDate = new System.DateTime(1998, 4, 29, 11, 27, 56, 578);
            this.mcLichCongViec.Month.BackgroundImage = null;
            this.mcLichCongViec.Month.BorderStyles.Focus = System.Windows.Forms.ButtonBorderStyle.None;
            this.mcLichCongViec.Month.Colors.Days.Border = System.Drawing.Color.Empty;
            this.mcLichCongViec.Month.Colors.Disabled.BackColor1 = System.Drawing.Color.Empty;
            this.mcLichCongViec.Month.Colors.Disabled.Date = System.Drawing.Color.Empty;
            this.mcLichCongViec.Month.Colors.Disabled.Text = System.Drawing.Color.Empty;
            this.mcLichCongViec.Month.Colors.Focus.Date = System.Drawing.Color.Empty;
            this.mcLichCongViec.Month.Colors.Weekend.Saturday = false;
            this.mcLichCongViec.Month.Colors.Weekend.Text = System.Drawing.Color.Red;
            this.mcLichCongViec.Month.DateFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcLichCongViec.Month.FormatTrailing = false;
            this.mcLichCongViec.Month.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcLichCongViec.Name = "mcLichCongViec";
            this.mcLichCongViec.SelectTrailingDates = false;
            this.mcLichCongViec.ShowWeeknumbers = true;
            this.mcLichCongViec.Size = new System.Drawing.Size(534, 291);
            this.mcLichCongViec.TabIndex = 0;
            this.mcLichCongViec.Weekdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.mcLichCongViec.Weeknumbers.Align = Pabo.Calendar.mcWeeknumberAlign.Center;
            this.mcLichCongViec.Weeknumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.mcLichCongViec.DayDoubleClick += new Pabo.Calendar.DayClickEventHandler(this.mcLichCongViec_DayDoubleClick);
            this.mcLichCongViec.MonthChanged += new Pabo.Calendar.MonthChangedEventHandler(this.mcLichCongViec_MonthChanged);
            this.mcLichCongViec.DayMouseMove += new Pabo.Calendar.DayMouseMoveEventHandler(this.mcLichCongViec_DayMouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ngày Bắt Đầu\r\nLàm Công Việc\r\n";
            // 
            // rtbNoiDungCongViec
            // 
            this.rtbNoiDungCongViec.Location = new System.Drawing.Point(172, 145);
            this.rtbNoiDungCongViec.MaxLength = 500;
            this.rtbNoiDungCongViec.Name = "rtbNoiDungCongViec";
            this.rtbNoiDungCongViec.Size = new System.Drawing.Size(349, 99);
            this.rtbNoiDungCongViec.TabIndex = 4;
            this.rtbNoiDungCongViec.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nội Dung\r\nCông Việc\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.mcLichCongViec);
            this.groupBox1.Location = new System.Drawing.Point(-2, -6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 336);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboTimeEnd);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.comboMinutesEnd);
            this.groupBox2.Controls.Add(this.comboHourEnd);
            this.groupBox2.Controls.Add(this.comboTimeStart);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comboMinutesStart);
            this.groupBox2.Controls.Add(this.comboHourStart);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dtpNgayXongCV);
            this.groupBox2.Controls.Add(this.dtpNgayBatDau);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnLamMoi);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnDongY);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.rtbNoiDungCongViec);
            this.groupBox2.Location = new System.Drawing.Point(-2, 352);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(571, 306);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lịch Làm Việc";
            // 
            // comboTimeEnd
            // 
            this.comboTimeEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTimeEnd.FormattingEnabled = true;
            this.comboTimeEnd.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.comboTimeEnd.Location = new System.Drawing.Point(455, 100);
            this.comboTimeEnd.Name = "comboTimeEnd";
            this.comboTimeEnd.Size = new System.Drawing.Size(66, 21);
            this.comboTimeEnd.TabIndex = 24;
            this.comboTimeEnd.SelectedIndexChanged += new System.EventHandler(this.comboTimeEnd_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(306, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Phút";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(169, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Giờ";
            // 
            // comboMinutesEnd
            // 
            this.comboMinutesEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMinutesEnd.FormattingEnabled = true;
            this.comboMinutesEnd.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60"});
            this.comboMinutesEnd.Location = new System.Drawing.Point(341, 100);
            this.comboMinutesEnd.Name = "comboMinutesEnd";
            this.comboMinutesEnd.Size = new System.Drawing.Size(108, 21);
            this.comboMinutesEnd.TabIndex = 21;
            this.comboMinutesEnd.SelectedIndexChanged += new System.EventHandler(this.comboMinutesEnd_SelectedIndexChanged);
            // 
            // comboHourEnd
            // 
            this.comboHourEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboHourEnd.FormattingEnabled = true;
            this.comboHourEnd.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboHourEnd.Location = new System.Drawing.Point(192, 100);
            this.comboHourEnd.Name = "comboHourEnd";
            this.comboHourEnd.Size = new System.Drawing.Size(108, 21);
            this.comboHourEnd.TabIndex = 20;
            this.comboHourEnd.SelectedIndexChanged += new System.EventHandler(this.comboHourEnd_SelectedIndexChanged);
            // 
            // comboTimeStart
            // 
            this.comboTimeStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTimeStart.FormattingEnabled = true;
            this.comboTimeStart.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.comboTimeStart.Location = new System.Drawing.Point(455, 62);
            this.comboTimeStart.Name = "comboTimeStart";
            this.comboTimeStart.Size = new System.Drawing.Size(66, 21);
            this.comboTimeStart.TabIndex = 19;
            this.comboTimeStart.SelectedIndexChanged += new System.EventHandler(this.comboTimeStart_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(306, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Phút";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Giờ";
            // 
            // comboMinutesStart
            // 
            this.comboMinutesStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMinutesStart.FormattingEnabled = true;
            this.comboMinutesStart.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60"});
            this.comboMinutesStart.Location = new System.Drawing.Point(341, 62);
            this.comboMinutesStart.Name = "comboMinutesStart";
            this.comboMinutesStart.Size = new System.Drawing.Size(108, 21);
            this.comboMinutesStart.TabIndex = 16;
            this.comboMinutesStart.SelectedIndexChanged += new System.EventHandler(this.comboMinutesStart_SelectedIndexChanged);
            // 
            // comboHourStart
            // 
            this.comboHourStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboHourStart.FormattingEnabled = true;
            this.comboHourStart.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboHourStart.Location = new System.Drawing.Point(192, 62);
            this.comboHourStart.Name = "comboHourStart";
            this.comboHourStart.Size = new System.Drawing.Size(108, 21);
            this.comboHourStart.TabIndex = 15;
            this.comboHourStart.SelectedIndexChanged += new System.EventHandler(this.comboHour_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Thời Gian Kết Thúc ==>";
            // 
            // dtpNgayXongCV
            // 
            this.dtpNgayXongCV.Checked = false;
            this.dtpNgayXongCV.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayXongCV.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayXongCV.Location = new System.Drawing.Point(379, 22);
            this.dtpNgayXongCV.Name = "dtpNgayXongCV";
            this.dtpNgayXongCV.ShowCheckBox = true;
            this.dtpNgayXongCV.Size = new System.Drawing.Size(98, 20);
            this.dtpNgayXongCV.TabIndex = 13;
            this.dtpNgayXongCV.ValueChanged += new System.EventHandler(this.dtpNgayXongCV_ValueChanged);
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Checked = false;
            this.dtpNgayBatDau.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(152, 22);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.ShowCheckBox = true;
            this.dtpNgayBatDau.Size = new System.Drawing.Size(98, 20);
            this.dtpNgayBatDau.TabIndex = 12;
            this.dtpNgayBatDau.ValueChanged += new System.EventHandler(this.dtpNgayBatDau_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Thời Gian Bắt Đầu ==>";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.White;
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(240, 263);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(68, 23);
            this.btnLamMoi.TabIndex = 9;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ngày Dự Định\r\nXong Công Việc\r\n";
            // 
            // btnDongY
            // 
            this.btnDongY.BackColor = System.Drawing.Color.White;
            this.btnDongY.Image = ((System.Drawing.Image)(resources.GetObject("btnDongY.Image")));
            this.btnDongY.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDongY.Location = new System.Drawing.Point(166, 263);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(68, 23);
            this.btnDongY.TabIndex = 3;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDongY.UseVisualStyleBackColor = false;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(314, 263);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(68, 23);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmLichCongTac
            // 
            this.AcceptButton = this.btnDongY;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(568, 658);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmLichCongTac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch Công Việc";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.RichTextBox rtbNoiDungCongViec;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLamMoi;
        private Pabo.Calendar.MonthCalendar mcLichCongViec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.DateTimePicker dtpNgayXongCV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboMinutesStart;
        private System.Windows.Forms.ComboBox comboHourStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboTimeStart;
        private System.Windows.Forms.ComboBox comboTimeEnd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboMinutesEnd;
        private System.Windows.Forms.ComboBox comboHourEnd;


    }
}

