﻿namespace QLNK
{
    partial class SuaNhanKhau
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
            this.groupGender = new System.Windows.Forms.GroupBox();
            this.rdNam = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdNu = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnSuaNhanKhau = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtNgheNghiep = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnHoKhau = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtMaHoKhau = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cbTonGiao = new System.Windows.Forms.ComboBox();
            this.cbDanToc = new System.Windows.Forms.ComboBox();
            this.cbQueQuan = new System.Windows.Forms.ComboBox();
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.cbNgay = new System.Windows.Forms.ComboBox();
            this.lblTonGiao = new MaterialSkin.Controls.MaterialLabel();
            this.lblGioiTinh = new MaterialSkin.Controls.MaterialLabel();
            this.lblNam = new MaterialSkin.Controls.MaterialLabel();
            this.lblThang = new MaterialSkin.Controls.MaterialLabel();
            this.lblNgay = new MaterialSkin.Controls.MaterialLabel();
            this.lblNgheNghiep = new MaterialSkin.Controls.MaterialLabel();
            this.lblMHK = new MaterialSkin.Controls.MaterialLabel();
            this.lblCMND = new MaterialSkin.Controls.MaterialLabel();
            this.lblDanToc = new MaterialSkin.Controls.MaterialLabel();
            this.lblQueQuan = new MaterialSkin.Controls.MaterialLabel();
            this.txtCMND = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtHoTen = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtMaNhanKhau = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblNgaySinh = new MaterialSkin.Controls.MaterialLabel();
            this.lblHoTen = new MaterialSkin.Controls.MaterialLabel();
            this.lblMNK = new MaterialSkin.Controls.MaterialLabel();
            this.groupGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupGender
            // 
            this.groupGender.BackColor = System.Drawing.Color.White;
            this.groupGender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupGender.Controls.Add(this.rdNam);
            this.groupGender.Controls.Add(this.rdNu);
            this.groupGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupGender.Location = new System.Drawing.Point(424, 203);
            this.groupGender.Name = "groupGender";
            this.groupGender.Size = new System.Drawing.Size(142, 45);
            this.groupGender.TabIndex = 63;
            this.groupGender.TabStop = false;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Depth = 0;
            this.rdNam.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdNam.Location = new System.Drawing.Point(3, 11);
            this.rdNam.Margin = new System.Windows.Forms.Padding(0);
            this.rdNam.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdNam.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdNam.Name = "rdNam";
            this.rdNam.Ripple = true;
            this.rdNam.Size = new System.Drawing.Size(66, 30);
            this.rdNam.TabIndex = 64;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Depth = 0;
            this.rdNu.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdNu.Location = new System.Drawing.Point(83, 11);
            this.rdNu.Margin = new System.Windows.Forms.Padding(0);
            this.rdNu.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdNu.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdNu.Name = "rdNu";
            this.rdNu.Ripple = true;
            this.rdNu.Size = new System.Drawing.Size(52, 30);
            this.rdNu.TabIndex = 65;
            this.rdNu.Text = "Nu";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // btnSuaNhanKhau
            // 
            this.btnSuaNhanKhau.Depth = 0;
            this.btnSuaNhanKhau.Location = new System.Drawing.Point(486, 429);
            this.btnSuaNhanKhau.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSuaNhanKhau.Name = "btnSuaNhanKhau";
            this.btnSuaNhanKhau.Primary = true;
            this.btnSuaNhanKhau.Size = new System.Drawing.Size(75, 62);
            this.btnSuaNhanKhau.TabIndex = 60;
            this.btnSuaNhanKhau.Text = "Lưu";
            this.btnSuaNhanKhau.UseVisualStyleBackColor = true;
            this.btnSuaNhanKhau.Click += new System.EventHandler(this.btnSuaNhanKhau_Click);
            // 
            // txtNgheNghiep
            // 
            this.txtNgheNghiep.BackColor = System.Drawing.Color.White;
            this.txtNgheNghiep.Depth = 0;
            this.txtNgheNghiep.Hint = "";
            this.txtNgheNghiep.Location = new System.Drawing.Point(168, 382);
            this.txtNgheNghiep.MaxLength = 100;
            this.txtNgheNghiep.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNgheNghiep.Name = "txtNgheNghiep";
            this.txtNgheNghiep.PasswordChar = '\0';
            this.txtNgheNghiep.SelectedText = "";
            this.txtNgheNghiep.SelectionLength = 0;
            this.txtNgheNghiep.SelectionStart = 0;
            this.txtNgheNghiep.Size = new System.Drawing.Size(398, 28);
            this.txtNgheNghiep.TabIndex = 59;
            this.txtNgheNghiep.TabStop = false;
            this.txtNgheNghiep.UseSystemPasswordChar = false;
            // 
            // btnHoKhau
            // 
            this.btnHoKhau.Depth = 0;
            this.btnHoKhau.Location = new System.Drawing.Point(425, 330);
            this.btnHoKhau.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHoKhau.Name = "btnHoKhau";
            this.btnHoKhau.Primary = true;
            this.btnHoKhau.Size = new System.Drawing.Size(141, 43);
            this.btnHoKhau.TabIndex = 58;
            this.btnHoKhau.Text = "Chọn hộ khẩu";
            this.btnHoKhau.UseVisualStyleBackColor = true;
            // 
            // txtMaHoKhau
            // 
            this.txtMaHoKhau.BackColor = System.Drawing.Color.White;
            this.txtMaHoKhau.Depth = 0;
            this.txtMaHoKhau.Hint = "";
            this.txtMaHoKhau.Location = new System.Drawing.Point(168, 337);
            this.txtMaHoKhau.MaxLength = 10;
            this.txtMaHoKhau.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMaHoKhau.Name = "txtMaHoKhau";
            this.txtMaHoKhau.PasswordChar = '\0';
            this.txtMaHoKhau.SelectedText = "";
            this.txtMaHoKhau.SelectionLength = 0;
            this.txtMaHoKhau.SelectionStart = 0;
            this.txtMaHoKhau.Size = new System.Drawing.Size(251, 28);
            this.txtMaHoKhau.TabIndex = 57;
            this.txtMaHoKhau.TabStop = false;
            this.txtMaHoKhau.UseSystemPasswordChar = false;
            this.txtMaHoKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaHoKhau_KeyPress);
            // 
            // cbTonGiao
            // 
            this.cbTonGiao.DropDownHeight = 140;
            this.cbTonGiao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTonGiao.FormattingEnabled = true;
            this.cbTonGiao.IntegralHeight = false;
            this.cbTonGiao.Items.AddRange(new object[] {
            "Phật giáo",
            "Công giáo",
            "Tin Lành",
            "Cao Đài",
            "Hồi giáo",
            "Bahá í",
            "Minh Sư Đạo",
            "Minh Lý Đạo",
            "Bà-la-môn"});
            this.cbTonGiao.Location = new System.Drawing.Point(424, 257);
            this.cbTonGiao.Name = "cbTonGiao";
            this.cbTonGiao.Size = new System.Drawing.Size(142, 24);
            this.cbTonGiao.TabIndex = 56;
            // 
            // cbDanToc
            // 
            this.cbDanToc.DropDownHeight = 140;
            this.cbDanToc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDanToc.FormattingEnabled = true;
            this.cbDanToc.IntegralHeight = false;
            this.cbDanToc.Items.AddRange(new object[] {
            "Kinh",
            "Tày",
            "Thái",
            "Mường",
            "Khơ Me",
            "H\'Mông",
            "Nùng",
            "Hoa",
            "Dao",
            "Gia Rai",
            "Ê Đê",
            "Ba Na",
            "Xơ Đăng",
            "Sán Chay",
            "Cơ Ho",
            "Chăm",
            "Sán Dìu",
            "Hrê",
            "Ra Glai",
            "M\'Nông",
            "X’Tiêng",
            "Bru-Vân Kiều",
            "Thổ",
            "Khơ Mú",
            "Cơ Tu",
            "Giáy",
            "Giẻ Triêng",
            "Tà Ôi",
            "Mạ",
            "Co",
            "Chơ Ro",
            "Xinh Mun",
            "Hà Nhì",
            "Chu Ru",
            "Lào",
            "Kháng",
            "La Chí",
            "Phú Lá",
            "La Hủ",
            "La Ha",
            "Pà Thẻn",
            "Chứt",
            "Lự",
            "Lô Lô",
            "Mảng",
            "Cờ Lao",
            "Bố Y",
            "Cống",
            "Ngái",
            "Si La",
            "Pu Péo",
            "Rơ măm",
            "Brâu",
            "Ơ Đu",
            "Thành phần khác"});
            this.cbDanToc.Location = new System.Drawing.Point(168, 257);
            this.cbDanToc.Name = "cbDanToc";
            this.cbDanToc.Size = new System.Drawing.Size(142, 24);
            this.cbDanToc.TabIndex = 55;
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
            this.cbQueQuan.Location = new System.Drawing.Point(168, 216);
            this.cbQueQuan.Name = "cbQueQuan";
            this.cbQueQuan.Size = new System.Drawing.Size(142, 24);
            this.cbQueQuan.TabIndex = 54;
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
            "2000"});
            this.cbNam.Location = new System.Drawing.Point(493, 172);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(68, 24);
            this.cbNam.TabIndex = 53;
            // 
            // cbThang
            // 
            this.cbThang.DropDownHeight = 140;
            this.cbThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThang.FormattingEnabled = true;
            this.cbThang.IntegralHeight = false;
            this.cbThang.Items.AddRange(new object[] {
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
            this.cbThang.Location = new System.Drawing.Point(363, 172);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(48, 24);
            this.cbThang.TabIndex = 52;
            // 
            // cbNgay
            // 
            this.cbNgay.DropDownHeight = 140;
            this.cbNgay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNgay.FormattingEnabled = true;
            this.cbNgay.IntegralHeight = false;
            this.cbNgay.Items.AddRange(new object[] {
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
            "31"});
            this.cbNgay.Location = new System.Drawing.Point(224, 172);
            this.cbNgay.Name = "cbNgay";
            this.cbNgay.Size = new System.Drawing.Size(48, 24);
            this.cbNgay.TabIndex = 51;
            // 
            // lblTonGiao
            // 
            this.lblTonGiao.AutoSize = true;
            this.lblTonGiao.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTonGiao.Depth = 0;
            this.lblTonGiao.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTonGiao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTonGiao.Location = new System.Drawing.Point(335, 257);
            this.lblTonGiao.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTonGiao.Name = "lblTonGiao";
            this.lblTonGiao.Size = new System.Drawing.Size(84, 24);
            this.lblTonGiao.TabIndex = 50;
            this.lblTonGiao.Text = "Tôn giáo";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGioiTinh.Depth = 0;
            this.lblGioiTinh.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblGioiTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGioiTinh.Location = new System.Drawing.Point(335, 216);
            this.lblGioiTinh.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(80, 24);
            this.lblGioiTinh.TabIndex = 49;
            this.lblGioiTinh.Text = "Giới tính";
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNam.Depth = 0;
            this.lblNam.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNam.Location = new System.Drawing.Point(436, 172);
            this.lblNam.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(51, 24);
            this.lblNam.TabIndex = 48;
            this.lblNam.Text = "Năm";
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblThang.Depth = 0;
            this.lblThang.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblThang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblThang.Location = new System.Drawing.Point(295, 172);
            this.lblThang.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(62, 24);
            this.lblThang.TabIndex = 47;
            this.lblThang.Text = "Tháng";
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNgay.Depth = 0;
            this.lblNgay.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNgay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNgay.Location = new System.Drawing.Point(164, 172);
            this.lblNgay.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(54, 24);
            this.lblNgay.TabIndex = 46;
            this.lblNgay.Text = "Ngày";
            // 
            // lblNgheNghiep
            // 
            this.lblNgheNghiep.AutoSize = true;
            this.lblNgheNghiep.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNgheNghiep.Depth = 0;
            this.lblNgheNghiep.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNgheNghiep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNgheNghiep.Location = new System.Drawing.Point(34, 386);
            this.lblNgheNghiep.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNgheNghiep.Name = "lblNgheNghiep";
            this.lblNgheNghiep.Size = new System.Drawing.Size(117, 24);
            this.lblNgheNghiep.TabIndex = 45;
            this.lblNgheNghiep.Text = "Nghề nghiệp";
            // 
            // lblMHK
            // 
            this.lblMHK.AutoSize = true;
            this.lblMHK.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMHK.Depth = 0;
            this.lblMHK.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblMHK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMHK.Location = new System.Drawing.Point(43, 341);
            this.lblMHK.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMHK.Name = "lblMHK";
            this.lblMHK.Size = new System.Drawing.Size(108, 24);
            this.lblMHK.TabIndex = 44;
            this.lblMHK.Text = "Mã hộ khẩu";
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCMND.Depth = 0;
            this.lblCMND.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCMND.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCMND.Location = new System.Drawing.Point(86, 297);
            this.lblCMND.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(65, 24);
            this.lblCMND.TabIndex = 43;
            this.lblCMND.Text = "CMND";
            // 
            // lblDanToc
            // 
            this.lblDanToc.AutoSize = true;
            this.lblDanToc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDanToc.Depth = 0;
            this.lblDanToc.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDanToc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDanToc.Location = new System.Drawing.Point(77, 255);
            this.lblDanToc.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDanToc.Name = "lblDanToc";
            this.lblDanToc.Size = new System.Drawing.Size(74, 24);
            this.lblDanToc.TabIndex = 42;
            this.lblDanToc.Text = "Dân tộc";
            // 
            // lblQueQuan
            // 
            this.lblQueQuan.AutoSize = true;
            this.lblQueQuan.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblQueQuan.Depth = 0;
            this.lblQueQuan.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblQueQuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblQueQuan.Location = new System.Drawing.Point(62, 214);
            this.lblQueQuan.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblQueQuan.Name = "lblQueQuan";
            this.lblQueQuan.Size = new System.Drawing.Size(89, 24);
            this.lblQueQuan.TabIndex = 41;
            this.lblQueQuan.Text = "Quê quán";
            // 
            // txtCMND
            // 
            this.txtCMND.BackColor = System.Drawing.Color.White;
            this.txtCMND.Depth = 0;
            this.txtCMND.Hint = "";
            this.txtCMND.Location = new System.Drawing.Point(168, 293);
            this.txtCMND.MaxLength = 9;
            this.txtCMND.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.PasswordChar = '\0';
            this.txtCMND.SelectedText = "";
            this.txtCMND.SelectionLength = 0;
            this.txtCMND.SelectionStart = 0;
            this.txtCMND.Size = new System.Drawing.Size(398, 28);
            this.txtCMND.TabIndex = 40;
            this.txtCMND.TabStop = false;
            this.txtCMND.UseSystemPasswordChar = false;
            this.txtCMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCMND_KeyPress);
            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.Color.White;
            this.txtHoTen.Depth = 0;
            this.txtHoTen.Hint = "";
            this.txtHoTen.Location = new System.Drawing.Point(168, 126);
            this.txtHoTen.MaxLength = 50;
            this.txtHoTen.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.PasswordChar = '\0';
            this.txtHoTen.SelectedText = "";
            this.txtHoTen.SelectionLength = 0;
            this.txtHoTen.SelectionStart = 0;
            this.txtHoTen.Size = new System.Drawing.Size(393, 28);
            this.txtHoTen.TabIndex = 39;
            this.txtHoTen.TabStop = false;
            this.txtHoTen.UseSystemPasswordChar = false;
            this.txtHoTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoTen_KeyPress);
            // 
            // txtMaNhanKhau
            // 
            this.txtMaNhanKhau.BackColor = System.Drawing.Color.White;
            this.txtMaNhanKhau.Depth = 0;
            this.txtMaNhanKhau.Enabled = false;
            this.txtMaNhanKhau.Hint = "";
            this.txtMaNhanKhau.Location = new System.Drawing.Point(168, 85);
            this.txtMaNhanKhau.MaxLength = 10;
            this.txtMaNhanKhau.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMaNhanKhau.Name = "txtMaNhanKhau";
            this.txtMaNhanKhau.PasswordChar = '\0';
            this.txtMaNhanKhau.SelectedText = "";
            this.txtMaNhanKhau.SelectionLength = 0;
            this.txtMaNhanKhau.SelectionStart = 0;
            this.txtMaNhanKhau.Size = new System.Drawing.Size(393, 28);
            this.txtMaNhanKhau.TabIndex = 38;
            this.txtMaNhanKhau.TabStop = false;
            this.txtMaNhanKhau.UseSystemPasswordChar = false;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNgaySinh.Depth = 0;
            this.lblNgaySinh.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNgaySinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNgaySinh.Location = new System.Drawing.Point(57, 172);
            this.lblNgaySinh.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(94, 24);
            this.lblNgaySinh.TabIndex = 37;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.BackColor = System.Drawing.Color.White;
            this.lblHoTen.Depth = 0;
            this.lblHoTen.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblHoTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHoTen.Location = new System.Drawing.Point(85, 130);
            this.lblHoTen.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(66, 24);
            this.lblHoTen.TabIndex = 36;
            this.lblHoTen.Text = "Họ tên";
            // 
            // lblMNK
            // 
            this.lblMNK.AutoSize = true;
            this.lblMNK.BackColor = System.Drawing.Color.White;
            this.lblMNK.Depth = 0;
            this.lblMNK.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblMNK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMNK.Location = new System.Drawing.Point(24, 89);
            this.lblMNK.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMNK.Name = "lblMNK";
            this.lblMNK.Size = new System.Drawing.Size(127, 24);
            this.lblMNK.TabIndex = 35;
            this.lblMNK.Text = "Mã nhân khẩu";
            this.lblMNK.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SuaNhanKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 508);
            this.Controls.Add(this.groupGender);
            this.Controls.Add(this.btnSuaNhanKhau);
            this.Controls.Add(this.txtNgheNghiep);
            this.Controls.Add(this.btnHoKhau);
            this.Controls.Add(this.txtMaHoKhau);
            this.Controls.Add(this.cbTonGiao);
            this.Controls.Add(this.cbDanToc);
            this.Controls.Add(this.cbQueQuan);
            this.Controls.Add(this.cbNam);
            this.Controls.Add(this.cbThang);
            this.Controls.Add(this.cbNgay);
            this.Controls.Add(this.lblTonGiao);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblNam);
            this.Controls.Add(this.lblThang);
            this.Controls.Add(this.lblNgay);
            this.Controls.Add(this.lblNgheNghiep);
            this.Controls.Add(this.lblMHK);
            this.Controls.Add(this.lblCMND);
            this.Controls.Add(this.lblDanToc);
            this.Controls.Add(this.lblQueQuan);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMaNhanKhau);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblMNK);
            this.Name = "SuaNhanKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SỬA THÔNG TIN NHÂN KHẨU";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SuaNhanKhau_FormClosing);
            this.groupGender.ResumeLayout(false);
            this.groupGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupGender;
        private MaterialSkin.Controls.MaterialRaisedButton btnSuaNhanKhau;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNgheNghiep;
        private MaterialSkin.Controls.MaterialRaisedButton btnHoKhau;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMaHoKhau;
        private System.Windows.Forms.ComboBox cbTonGiao;
        private System.Windows.Forms.ComboBox cbDanToc;
        private System.Windows.Forms.ComboBox cbQueQuan;
        private System.Windows.Forms.ComboBox cbNam;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.ComboBox cbNgay;
        private MaterialSkin.Controls.MaterialLabel lblTonGiao;
        private MaterialSkin.Controls.MaterialLabel lblGioiTinh;
        private MaterialSkin.Controls.MaterialLabel lblNam;
        private MaterialSkin.Controls.MaterialLabel lblThang;
        private MaterialSkin.Controls.MaterialLabel lblNgay;
        private MaterialSkin.Controls.MaterialLabel lblNgheNghiep;
        private MaterialSkin.Controls.MaterialLabel lblMHK;
        private MaterialSkin.Controls.MaterialLabel lblCMND;
        private MaterialSkin.Controls.MaterialLabel lblDanToc;
        private MaterialSkin.Controls.MaterialLabel lblQueQuan;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCMND;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtHoTen;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMaNhanKhau;
        private MaterialSkin.Controls.MaterialLabel lblNgaySinh;
        private MaterialSkin.Controls.MaterialLabel lblHoTen;
        private MaterialSkin.Controls.MaterialLabel lblMNK;
        private MaterialSkin.Controls.MaterialRadioButton rdNam;
        private MaterialSkin.Controls.MaterialRadioButton rdNu;
    }
}