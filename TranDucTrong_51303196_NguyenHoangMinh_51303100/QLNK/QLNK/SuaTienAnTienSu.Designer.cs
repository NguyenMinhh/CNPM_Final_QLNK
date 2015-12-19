namespace QLNK
{
    partial class SuaTienAnTienSu
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
            this.btnNhanKhau = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtMaNhanKhau = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.cbNgay = new System.Windows.Forms.ComboBox();
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.btnSuaTienAnTienSu = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtTenTienAnTienSu = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lblMKV = new MaterialSkin.Controls.MaterialLabel();
            this.lblHoTen2 = new MaterialSkin.Controls.MaterialLabel();
            this.cbQueQuan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNhanKhau
            // 
            this.btnNhanKhau.Depth = 0;
            this.btnNhanKhau.Location = new System.Drawing.Point(429, 78);
            this.btnNhanKhau.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNhanKhau.Name = "btnNhanKhau";
            this.btnNhanKhau.Primary = true;
            this.btnNhanKhau.Size = new System.Drawing.Size(156, 43);
            this.btnNhanKhau.TabIndex = 306;
            this.btnNhanKhau.Text = "Chọn nhân khẩu";
            this.btnNhanKhau.UseVisualStyleBackColor = true;
            // 
            // txtMaNhanKhau
            // 
            this.txtMaNhanKhau.BackColor = System.Drawing.Color.White;
            this.txtMaNhanKhau.Depth = 0;
            this.txtMaNhanKhau.Hint = "";
            this.txtMaNhanKhau.Location = new System.Drawing.Point(192, 85);
            this.txtMaNhanKhau.MaxLength = 10;
            this.txtMaNhanKhau.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMaNhanKhau.Name = "txtMaNhanKhau";
            this.txtMaNhanKhau.PasswordChar = '\0';
            this.txtMaNhanKhau.SelectedText = "";
            this.txtMaNhanKhau.SelectionLength = 0;
            this.txtMaNhanKhau.SelectionStart = 0;
            this.txtMaNhanKhau.Size = new System.Drawing.Size(231, 28);
            this.txtMaNhanKhau.TabIndex = 305;
            this.txtMaNhanKhau.TabStop = false;
            this.txtMaNhanKhau.UseSystemPasswordChar = false;
            this.txtMaNhanKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaNhanKhau_KeyPress);
            this.txtMaNhanKhau.TextChanged += new System.EventHandler(this.txtMaNhanKhau_TextChanged);
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(190, 214);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(54, 24);
            this.materialLabel10.TabIndex = 301;
            this.materialLabel10.Text = "Ngày";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(41, 215);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(133, 24);
            this.materialLabel9.TabIndex = 302;
            this.materialLabel9.Text = "Ngày Thực Thi";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(315, 214);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(62, 24);
            this.materialLabel11.TabIndex = 296;
            this.materialLabel11.Text = "Tháng";
            // 
            // cbThang
            // 
            this.cbThang.DropDownHeight = 140;
            this.cbThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThang.FormattingEnabled = true;
            this.cbThang.IntegralHeight = false;
            this.cbThang.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cbThang.Location = new System.Drawing.Point(383, 214);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(56, 24);
            this.cbThang.TabIndex = 299;
            this.cbThang.SelectedIndexChanged += new System.EventHandler(this.cbThang_SelectedIndexChanged);
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(460, 214);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(51, 24);
            this.materialLabel13.TabIndex = 297;
            this.materialLabel13.Text = "Năm";
            // 
            // cbNgay
            // 
            this.cbNgay.DropDownHeight = 140;
            this.cbNgay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNgay.FormattingEnabled = true;
            this.cbNgay.IntegralHeight = false;
            this.cbNgay.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
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
            "31"});
            this.cbNgay.Location = new System.Drawing.Point(245, 214);
            this.cbNgay.Name = "cbNgay";
            this.cbNgay.Size = new System.Drawing.Size(55, 24);
            this.cbNgay.TabIndex = 298;
            this.cbNgay.SelectedIndexChanged += new System.EventHandler(this.cbNgay_SelectedIndexChanged);
            // 
            // cbNam
            // 
            this.cbNam.DropDownHeight = 140;
            this.cbNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNam.FormattingEnabled = true;
            this.cbNam.IntegralHeight = false;
            this.cbNam.Items.AddRange(new object[] {
            "1960",
            "1961",
            "1962",
            "1963",
            "1964",
            "1965",
            "1966",
            "1967",
            "1968",
            "1969",
            "1970",
            "1971",
            "1972",
            "1973",
            "1974",
            "1975",
            "1976",
            "1977",
            "1978",
            "1979",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015"});
            this.cbNam.Location = new System.Drawing.Point(517, 214);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(68, 24);
            this.cbNam.TabIndex = 300;
            this.cbNam.SelectedIndexChanged += new System.EventHandler(this.cbNam_SelectedIndexChanged);
            // 
            // btnSuaTienAnTienSu
            // 
            this.btnSuaTienAnTienSu.Depth = 0;
            this.btnSuaTienAnTienSu.Location = new System.Drawing.Point(510, 258);
            this.btnSuaTienAnTienSu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSuaTienAnTienSu.Name = "btnSuaTienAnTienSu";
            this.btnSuaTienAnTienSu.Primary = true;
            this.btnSuaTienAnTienSu.Size = new System.Drawing.Size(75, 62);
            this.btnSuaTienAnTienSu.TabIndex = 291;
            this.btnSuaTienAnTienSu.Text = "Lưu";
            this.btnSuaTienAnTienSu.UseVisualStyleBackColor = true;
            this.btnSuaTienAnTienSu.Click += new System.EventHandler(this.btnSuaTienAnTienSu_Click);
            // 
            // txtTenTienAnTienSu
            // 
            this.txtTenTienAnTienSu.BackColor = System.Drawing.Color.White;
            this.txtTenTienAnTienSu.Depth = 0;
            this.txtTenTienAnTienSu.Hint = "";
            this.txtTenTienAnTienSu.Location = new System.Drawing.Point(192, 130);
            this.txtTenTienAnTienSu.MaxLength = 50;
            this.txtTenTienAnTienSu.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTenTienAnTienSu.Name = "txtTenTienAnTienSu";
            this.txtTenTienAnTienSu.PasswordChar = '\0';
            this.txtTenTienAnTienSu.SelectedText = "";
            this.txtTenTienAnTienSu.SelectionLength = 0;
            this.txtTenTienAnTienSu.SelectionStart = 0;
            this.txtTenTienAnTienSu.Size = new System.Drawing.Size(393, 28);
            this.txtTenTienAnTienSu.TabIndex = 295;
            this.txtTenTienAnTienSu.TabStop = false;
            this.txtTenTienAnTienSu.UseSystemPasswordChar = false;
            this.txtTenTienAnTienSu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenTienAnTienSu_KeyPress);
            this.txtTenTienAnTienSu.TextChanged += new System.EventHandler(this.txtTenTienAnTienSu_TextChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(9, 134);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(165, 24);
            this.materialLabel1.TabIndex = 294;
            this.materialLabel1.Text = "Tên tiền án tiền sự";
            // 
            // lblMKV
            // 
            this.lblMKV.AutoSize = true;
            this.lblMKV.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMKV.Depth = 0;
            this.lblMKV.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblMKV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMKV.Location = new System.Drawing.Point(78, 174);
            this.lblMKV.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMKV.Name = "lblMKV";
            this.lblMKV.Size = new System.Drawing.Size(96, 24);
            this.lblMKV.TabIndex = 290;
            this.lblMKV.Text = "Nơi xét xử";
            // 
            // lblHoTen2
            // 
            this.lblHoTen2.AutoSize = true;
            this.lblHoTen2.BackColor = System.Drawing.Color.White;
            this.lblHoTen2.Depth = 0;
            this.lblHoTen2.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblHoTen2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHoTen2.Location = new System.Drawing.Point(47, 88);
            this.lblHoTen2.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblHoTen2.Name = "lblHoTen2";
            this.lblHoTen2.Size = new System.Drawing.Size(127, 24);
            this.lblHoTen2.TabIndex = 289;
            this.lblHoTen2.Text = "Mã nhân khẩu";
            // 
            // cbQueQuan
            // 
            this.cbQueQuan.DropDownHeight = 140;
            this.cbQueQuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQueQuan.FormattingEnabled = true;
            this.cbQueQuan.IntegralHeight = false;
            this.cbQueQuan.Items.AddRange(new object[] {
            "An Giang",
            "Bà Rịa - Vũng Tàu",
            "Bạc Liêu",
            "Bắc Kạn",
            "Bắc Giang",
            "Bắc Ninh",
            "Bến Tre",
            "Bình Dương",
            "Bình Định",
            "Bình Phước",
            "Bình Thuận",
            "Cà Mau",
            "Cao Bằng",
            "Cần Thơ",
            "Đà Nẵng",
            "Đắk Lắk",
            "Đắk Nông",
            "Đồng Nai",
            "Đồng Tháp",
            "Điện Biên",
            "Gia Lai",
            "Hà Giang",
            "Hà Nam",
            "Hà Nội",
            "Hà Tĩnh",
            "Hải Dương",
            "Hải Phòng",
            "Hòa Bình",
            "Hậu Giang",
            "Hưng Yên",
            "TPHCM",
            "Khánh Hòa",
            "Kiên Giang",
            "Kon Tum",
            "Lai Châu",
            "Lào Cai",
            "Lạng Sơn",
            "Lâm Đồng",
            "Long An",
            "Nam Định",
            "Nghệ An",
            "Ninh Bình",
            "Ninh Thuận",
            "Phú Thọ",
            "Phú Yên",
            "Quảng Bình",
            "Quảng Nam",
            "Quảng Ngãi",
            "Quảng Ninh",
            "Quảng Trị",
            "Sóc Trăng",
            "Sơn La",
            "Tây Ninh",
            "Thái Bình",
            "Thái Nguyên",
            "Thanh Hóa",
            "Thừa Thiên Huế",
            "Tiền Giang",
            "Trà Vinh",
            "Tuyên Quang",
            "Vĩnh Long",
            "Vĩnh Phúc",
            "Yên Bái"});
            this.cbQueQuan.Location = new System.Drawing.Point(192, 174);
            this.cbQueQuan.Name = "cbQueQuan";
            this.cbQueQuan.Size = new System.Drawing.Size(393, 24);
            this.cbQueQuan.TabIndex = 326;
            this.cbQueQuan.SelectedIndexChanged += new System.EventHandler(this.cbQueQuan_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(168, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 17);
            this.label4.TabIndex = 330;
            this.label4.Text = "(*)";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(168, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 17);
            this.label3.TabIndex = 329;
            this.label3.Text = "(*)";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(168, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 17);
            this.label2.TabIndex = 328;
            this.label2.Text = "(*)";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(168, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 327;
            this.label1.Text = "(*)";
            this.label1.Visible = false;
            // 
            // SuaTienAnTienSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 337);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbQueQuan);
            this.Controls.Add(this.btnNhanKhau);
            this.Controls.Add(this.txtMaNhanKhau);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.materialLabel11);
            this.Controls.Add(this.cbThang);
            this.Controls.Add(this.materialLabel13);
            this.Controls.Add(this.cbNgay);
            this.Controls.Add(this.cbNam);
            this.Controls.Add(this.btnSuaTienAnTienSu);
            this.Controls.Add(this.txtTenTienAnTienSu);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.lblMKV);
            this.Controls.Add(this.lblHoTen2);
            this.MaximizeBox = false;
            this.Name = "SuaTienAnTienSu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SỬA THÔNG TIN TIỀN ÁN TIỀN SỰ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SuaTienAnTienSu_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnNhanKhau;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMaNhanKhau;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private System.Windows.Forms.ComboBox cbThang;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private System.Windows.Forms.ComboBox cbNgay;
        private System.Windows.Forms.ComboBox cbNam;
        private MaterialSkin.Controls.MaterialRaisedButton btnSuaTienAnTienSu;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTenTienAnTienSu;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lblMKV;
        private MaterialSkin.Controls.MaterialLabel lblHoTen2;
        private System.Windows.Forms.ComboBox cbQueQuan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}