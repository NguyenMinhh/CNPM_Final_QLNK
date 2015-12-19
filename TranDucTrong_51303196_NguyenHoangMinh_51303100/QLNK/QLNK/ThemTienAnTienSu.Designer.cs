namespace QLNK
{
    partial class ThemTienAnTienSu
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
            this.btnThemTienAnTienSu = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtTenTienAnTienSu = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lblMKV = new MaterialSkin.Controls.MaterialLabel();
            this.lblHoTen2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnClear = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cbQueQuan = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnNhanKhau
            // 
            this.btnNhanKhau.Depth = 0;
            this.btnNhanKhau.Location = new System.Drawing.Point(429, 74);
            this.btnNhanKhau.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNhanKhau.Name = "btnNhanKhau";
            this.btnNhanKhau.Primary = true;
            this.btnNhanKhau.Size = new System.Drawing.Size(156, 43);
            this.btnNhanKhau.TabIndex = 323;
            this.btnNhanKhau.Text = "Chọn nhân khẩu";
            this.btnNhanKhau.UseVisualStyleBackColor = true;
            // 
            // txtMaNhanKhau
            // 
            this.txtMaNhanKhau.BackColor = System.Drawing.Color.White;
            this.txtMaNhanKhau.Depth = 0;
            this.txtMaNhanKhau.Hint = "";
            this.txtMaNhanKhau.Location = new System.Drawing.Point(192, 81);
            this.txtMaNhanKhau.MaxLength = 10;
            this.txtMaNhanKhau.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMaNhanKhau.Name = "txtMaNhanKhau";
            this.txtMaNhanKhau.PasswordChar = '\0';
            this.txtMaNhanKhau.SelectedText = "";
            this.txtMaNhanKhau.SelectionLength = 0;
            this.txtMaNhanKhau.SelectionStart = 0;
            this.txtMaNhanKhau.Size = new System.Drawing.Size(231, 28);
            this.txtMaNhanKhau.TabIndex = 322;
            this.txtMaNhanKhau.TabStop = false;
            this.txtMaNhanKhau.UseSystemPasswordChar = false;
            this.txtMaNhanKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaNhanKhau_KeyPress);
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(190, 208);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(54, 24);
            this.materialLabel10.TabIndex = 320;
            this.materialLabel10.Text = "Ngày";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(41, 209);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(133, 24);
            this.materialLabel9.TabIndex = 321;
            this.materialLabel9.Text = "Ngày Thực Thi";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(315, 208);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(62, 24);
            this.materialLabel11.TabIndex = 315;
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
            this.cbThang.Location = new System.Drawing.Point(383, 208);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(56, 24);
            this.cbThang.TabIndex = 318;
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(460, 208);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(51, 24);
            this.materialLabel13.TabIndex = 316;
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
            this.cbNgay.Location = new System.Drawing.Point(245, 208);
            this.cbNgay.Name = "cbNgay";
            this.cbNgay.Size = new System.Drawing.Size(55, 24);
            this.cbNgay.TabIndex = 317;
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
            this.cbNam.Location = new System.Drawing.Point(517, 208);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(68, 24);
            this.cbNam.TabIndex = 319;
            // 
            // btnThemTienAnTienSu
            // 
            this.btnThemTienAnTienSu.Depth = 0;
            this.btnThemTienAnTienSu.Location = new System.Drawing.Point(510, 254);
            this.btnThemTienAnTienSu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThemTienAnTienSu.Name = "btnThemTienAnTienSu";
            this.btnThemTienAnTienSu.Primary = true;
            this.btnThemTienAnTienSu.Size = new System.Drawing.Size(75, 62);
            this.btnThemTienAnTienSu.TabIndex = 311;
            this.btnThemTienAnTienSu.Text = "Lưu";
            this.btnThemTienAnTienSu.UseVisualStyleBackColor = true;
            this.btnThemTienAnTienSu.Click += new System.EventHandler(this.btnThemTienAnTienSu_Click);
            // 
            // txtTenTienAnTienSu
            // 
            this.txtTenTienAnTienSu.BackColor = System.Drawing.Color.White;
            this.txtTenTienAnTienSu.Depth = 0;
            this.txtTenTienAnTienSu.Hint = "";
            this.txtTenTienAnTienSu.Location = new System.Drawing.Point(192, 126);
            this.txtTenTienAnTienSu.MaxLength = 50;
            this.txtTenTienAnTienSu.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTenTienAnTienSu.Name = "txtTenTienAnTienSu";
            this.txtTenTienAnTienSu.PasswordChar = '\0';
            this.txtTenTienAnTienSu.SelectedText = "";
            this.txtTenTienAnTienSu.SelectionLength = 0;
            this.txtTenTienAnTienSu.SelectionStart = 0;
            this.txtTenTienAnTienSu.Size = new System.Drawing.Size(393, 28);
            this.txtTenTienAnTienSu.TabIndex = 314;
            this.txtTenTienAnTienSu.TabStop = false;
            this.txtTenTienAnTienSu.UseSystemPasswordChar = false;
            this.txtTenTienAnTienSu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenTienAnTienSu_KeyPress);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(9, 130);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(165, 24);
            this.materialLabel1.TabIndex = 313;
            this.materialLabel1.Text = "Tên tiền án tiền sự";
            // 
            // lblMKV
            // 
            this.lblMKV.AutoSize = true;
            this.lblMKV.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMKV.Depth = 0;
            this.lblMKV.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblMKV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMKV.Location = new System.Drawing.Point(78, 169);
            this.lblMKV.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMKV.Name = "lblMKV";
            this.lblMKV.Size = new System.Drawing.Size(96, 24);
            this.lblMKV.TabIndex = 310;
            this.lblMKV.Text = "Nơi xét xử";
            // 
            // lblHoTen2
            // 
            this.lblHoTen2.AutoSize = true;
            this.lblHoTen2.BackColor = System.Drawing.Color.White;
            this.lblHoTen2.Depth = 0;
            this.lblHoTen2.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblHoTen2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHoTen2.Location = new System.Drawing.Point(47, 84);
            this.lblHoTen2.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblHoTen2.Name = "lblHoTen2";
            this.lblHoTen2.Size = new System.Drawing.Size(127, 24);
            this.lblHoTen2.TabIndex = 309;
            this.lblHoTen2.Text = "Mã nhân khẩu";
            // 
            // btnClear
            // 
            this.btnClear.Depth = 0;
            this.btnClear.Location = new System.Drawing.Point(410, 254);
            this.btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClear.Name = "btnClear";
            this.btnClear.Primary = true;
            this.btnClear.Size = new System.Drawing.Size(75, 62);
            this.btnClear.TabIndex = 324;
            this.btnClear.Text = "Xóa";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            this.cbQueQuan.Location = new System.Drawing.Point(192, 169);
            this.cbQueQuan.Name = "cbQueQuan";
            this.cbQueQuan.Size = new System.Drawing.Size(393, 24);
            this.cbQueQuan.TabIndex = 325;
            // 
            // ThemTienAnTienSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 332);
            this.Controls.Add(this.cbQueQuan);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnNhanKhau);
            this.Controls.Add(this.txtMaNhanKhau);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.materialLabel11);
            this.Controls.Add(this.cbThang);
            this.Controls.Add(this.materialLabel13);
            this.Controls.Add(this.cbNgay);
            this.Controls.Add(this.cbNam);
            this.Controls.Add(this.btnThemTienAnTienSu);
            this.Controls.Add(this.txtTenTienAnTienSu);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.lblMKV);
            this.Controls.Add(this.lblHoTen2);
            this.MaximizeBox = false;
            this.Name = "ThemTienAnTienSu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÊM TIỀN ÁN TIỀN SỰ";
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
        private MaterialSkin.Controls.MaterialRaisedButton btnThemTienAnTienSu;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTenTienAnTienSu;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lblMKV;
        private MaterialSkin.Controls.MaterialLabel lblHoTen2;
        private MaterialSkin.Controls.MaterialRaisedButton btnClear;
        private System.Windows.Forms.ComboBox cbQueQuan;
    }
}