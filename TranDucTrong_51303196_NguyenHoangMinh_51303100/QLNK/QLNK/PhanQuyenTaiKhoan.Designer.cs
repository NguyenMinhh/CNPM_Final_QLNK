namespace QLNK
{
    partial class PhanQuyenTaiKhoan
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
            this.btnLuu = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtTenDangNhap = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cbQuyenHanh = new System.Windows.Forms.ComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.Depth = 0;
            this.btnLuu.Location = new System.Drawing.Point(337, 188);
            this.btnLuu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Primary = true;
            this.btnLuu.Size = new System.Drawing.Size(75, 56);
            this.btnLuu.TabIndex = 190;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Depth = 0;
            this.txtTenDangNhap.Enabled = false;
            this.txtTenDangNhap.Hint = "";
            this.txtTenDangNhap.Location = new System.Drawing.Point(189, 89);
            this.txtTenDangNhap.MaxLength = 20;
            this.txtTenDangNhap.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.PasswordChar = '\0';
            this.txtTenDangNhap.SelectedText = "";
            this.txtTenDangNhap.SelectionLength = 0;
            this.txtTenDangNhap.SelectionStart = 0;
            this.txtTenDangNhap.Size = new System.Drawing.Size(223, 28);
            this.txtTenDangNhap.TabIndex = 189;
            this.txtTenDangNhap.TabStop = false;
            this.txtTenDangNhap.UseSystemPasswordChar = false;
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
            this.cbQuyenHanh.Location = new System.Drawing.Point(189, 140);
            this.cbQuyenHanh.Name = "cbQuyenHanh";
            this.cbQuyenHanh.Size = new System.Drawing.Size(223, 24);
            this.cbQuyenHanh.TabIndex = 188;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(50, 140);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(107, 24);
            this.materialLabel3.TabIndex = 187;
            this.materialLabel3.Text = "Quyền hành";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(23, 89);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(134, 24);
            this.materialLabel1.TabIndex = 186;
            this.materialLabel1.Text = "Tên đăng nhập";
            // 
            // PhanQuyenTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 264);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.cbQuyenHanh);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel1);
            this.Name = "PhanQuyenTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHÂN QUYỀN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PhanQuyenTaiKhoan_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnLuu;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTenDangNhap;
        private System.Windows.Forms.ComboBox cbQuyenHanh;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}