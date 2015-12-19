namespace QLNK
{
    partial class ThemTaiKhoan
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.cbQuyenHanh = new System.Windows.Forms.ComboBox();
            this.txtTenDangNhap = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtMatKhau = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnLuu = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnClear = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtNguoiSuDung = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(31, 88);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(134, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Tên đăng nhập";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(77, 136);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(88, 24);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Mật khẩu";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(58, 230);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(107, 24);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Quyền hành";
            // 
            // cbQuyenHanh
            // 
            this.cbQuyenHanh.DropDownHeight = 140;
            this.cbQuyenHanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuyenHanh.FormattingEnabled = true;
            this.cbQuyenHanh.IntegralHeight = false;
            this.cbQuyenHanh.Items.AddRange(new object[] {
            "Quản Lý Tài Khoản",
            "Quản Lý Nhân Khẩu",
            "Quản Lý Hộ Khẩu",
            "Quản Lý Tạm Trú",
            "Quản Lý Chứng Tử",
            "Quản Lý Chứng Nhận Kết Hôn",
            "Quản Lý Tiền Án Tiền Sự"});
            this.cbQuyenHanh.Location = new System.Drawing.Point(197, 230);
            this.cbQuyenHanh.Name = "cbQuyenHanh";
            this.cbQuyenHanh.Size = new System.Drawing.Size(223, 24);
            this.cbQuyenHanh.TabIndex = 182;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Depth = 0;
            this.txtTenDangNhap.Hint = "";
            this.txtTenDangNhap.Location = new System.Drawing.Point(197, 88);
            this.txtTenDangNhap.MaxLength = 20;
            this.txtTenDangNhap.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.PasswordChar = '\0';
            this.txtTenDangNhap.SelectedText = "";
            this.txtTenDangNhap.SelectionLength = 0;
            this.txtTenDangNhap.SelectionStart = 0;
            this.txtTenDangNhap.Size = new System.Drawing.Size(223, 28);
            this.txtTenDangNhap.TabIndex = 183;
            this.txtTenDangNhap.TabStop = false;
            this.txtTenDangNhap.UseSystemPasswordChar = false;
            this.txtTenDangNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenDangNhap_KeyPress);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Depth = 0;
            this.txtMatKhau.Hint = "";
            this.txtMatKhau.Location = new System.Drawing.Point(197, 136);
            this.txtMatKhau.MaxLength = 20;
            this.txtMatKhau.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '\0';
            this.txtMatKhau.SelectedText = "";
            this.txtMatKhau.SelectionLength = 0;
            this.txtMatKhau.SelectionStart = 0;
            this.txtMatKhau.Size = new System.Drawing.Size(223, 28);
            this.txtMatKhau.TabIndex = 184;
            this.txtMatKhau.TabStop = false;
            this.txtMatKhau.UseSystemPasswordChar = false;
            this.txtMatKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatKhau_KeyPress);
            // 
            // btnLuu
            // 
            this.btnLuu.Depth = 0;
            this.btnLuu.Location = new System.Drawing.Point(345, 274);
            this.btnLuu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Primary = true;
            this.btnLuu.Size = new System.Drawing.Size(75, 56);
            this.btnLuu.TabIndex = 185;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnClear
            // 
            this.btnClear.Depth = 0;
            this.btnClear.Location = new System.Drawing.Point(244, 274);
            this.btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClear.Name = "btnClear";
            this.btnClear.Primary = true;
            this.btnClear.Size = new System.Drawing.Size(75, 56);
            this.btnClear.TabIndex = 186;
            this.btnClear.Text = "Xóa";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtNguoiSuDung
            // 
            this.txtNguoiSuDung.Depth = 0;
            this.txtNguoiSuDung.Hint = "";
            this.txtNguoiSuDung.Location = new System.Drawing.Point(197, 182);
            this.txtNguoiSuDung.MaxLength = 50;
            this.txtNguoiSuDung.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNguoiSuDung.Name = "txtNguoiSuDung";
            this.txtNguoiSuDung.PasswordChar = '\0';
            this.txtNguoiSuDung.SelectedText = "";
            this.txtNguoiSuDung.SelectionLength = 0;
            this.txtNguoiSuDung.SelectionStart = 0;
            this.txtNguoiSuDung.Size = new System.Drawing.Size(223, 28);
            this.txtNguoiSuDung.TabIndex = 188;
            this.txtNguoiSuDung.TabStop = false;
            this.txtNguoiSuDung.UseSystemPasswordChar = false;
            this.txtNguoiSuDung.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNguoiSuDung_KeyPress);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(28, 182);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(137, 24);
            this.materialLabel4.TabIndex = 187;
            this.materialLabel4.Text = "Người sử dụng";
            // 
            // ThemTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 345);
            this.Controls.Add(this.txtNguoiSuDung);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.cbQuyenHanh);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.MaximizeBox = false;
            this.Name = "ThemTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÊM TÀI KHOẢN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.ComboBox cbQuyenHanh;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTenDangNhap;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMatKhau;
        private MaterialSkin.Controls.MaterialRaisedButton btnLuu;
        private MaterialSkin.Controls.MaterialRaisedButton btnClear;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNguoiSuDung;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
    }
}