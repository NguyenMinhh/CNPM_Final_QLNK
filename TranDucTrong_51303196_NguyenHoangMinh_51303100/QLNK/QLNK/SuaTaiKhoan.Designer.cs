namespace QLNK
{
    partial class SuaTaiKhoan
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
            this.btnClear = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnLuu = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtMatKhauMoi1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtMatKhauCu = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtMatKhauMoi2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Depth = 0;
            this.btnClear.Location = new System.Drawing.Point(271, 226);
            this.btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClear.Name = "btnClear";
            this.btnClear.Primary = true;
            this.btnClear.Size = new System.Drawing.Size(75, 55);
            this.btnClear.TabIndex = 194;
            this.btnClear.Text = "Xóa";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Depth = 0;
            this.btnLuu.Location = new System.Drawing.Point(365, 227);
            this.btnLuu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Primary = true;
            this.btnLuu.Size = new System.Drawing.Size(75, 55);
            this.btnLuu.TabIndex = 193;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtMatKhauMoi1
            // 
            this.txtMatKhauMoi1.Depth = 0;
            this.txtMatKhauMoi1.Hint = "";
            this.txtMatKhauMoi1.Location = new System.Drawing.Point(217, 134);
            this.txtMatKhauMoi1.MaxLength = 20;
            this.txtMatKhauMoi1.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMatKhauMoi1.Name = "txtMatKhauMoi1";
            this.txtMatKhauMoi1.PasswordChar = '\0';
            this.txtMatKhauMoi1.SelectedText = "";
            this.txtMatKhauMoi1.SelectionLength = 0;
            this.txtMatKhauMoi1.SelectionStart = 0;
            this.txtMatKhauMoi1.Size = new System.Drawing.Size(223, 28);
            this.txtMatKhauMoi1.TabIndex = 192;
            this.txtMatKhauMoi1.TabStop = false;
            this.txtMatKhauMoi1.UseSystemPasswordChar = false;
            this.txtMatKhauMoi1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatKhauMoi1_KeyPress);
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.Depth = 0;
            this.txtMatKhauCu.Enabled = false;
            this.txtMatKhauCu.Hint = "";
            this.txtMatKhauCu.Location = new System.Drawing.Point(217, 87);
            this.txtMatKhauCu.MaxLength = 20;
            this.txtMatKhauCu.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.PasswordChar = '\0';
            this.txtMatKhauCu.SelectedText = "";
            this.txtMatKhauCu.SelectionLength = 0;
            this.txtMatKhauCu.SelectionStart = 0;
            this.txtMatKhauCu.Size = new System.Drawing.Size(223, 28);
            this.txtMatKhauCu.TabIndex = 191;
            this.txtMatKhauCu.TabStop = false;
            this.txtMatKhauCu.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(63, 134);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(126, 24);
            this.materialLabel2.TabIndex = 188;
            this.materialLabel2.Text = "Mật khẩu mới";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(76, 87);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(113, 24);
            this.materialLabel1.TabIndex = 187;
            this.materialLabel1.Text = "Mật khẩu cũ";
            // 
            // txtMatKhauMoi2
            // 
            this.txtMatKhauMoi2.Depth = 0;
            this.txtMatKhauMoi2.Hint = "";
            this.txtMatKhauMoi2.Location = new System.Drawing.Point(217, 182);
            this.txtMatKhauMoi2.MaxLength = 20;
            this.txtMatKhauMoi2.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMatKhauMoi2.Name = "txtMatKhauMoi2";
            this.txtMatKhauMoi2.PasswordChar = '\0';
            this.txtMatKhauMoi2.SelectedText = "";
            this.txtMatKhauMoi2.SelectionLength = 0;
            this.txtMatKhauMoi2.SelectionStart = 0;
            this.txtMatKhauMoi2.Size = new System.Drawing.Size(223, 28);
            this.txtMatKhauMoi2.TabIndex = 196;
            this.txtMatKhauMoi2.TabStop = false;
            this.txtMatKhauMoi2.UseSystemPasswordChar = false;
            this.txtMatKhauMoi2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatKhauMoi2_KeyPress);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(19, 182);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(170, 24);
            this.materialLabel3.TabIndex = 195;
            this.materialLabel3.Text = "Xác nhận mật khẩu";
            // 
            // SuaTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 300);
            this.Controls.Add(this.txtMatKhauMoi2);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtMatKhauMoi1);
            this.Controls.Add(this.txtMatKhauCu);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "SuaTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐỔI MẬT KHẨU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnClear;
        private MaterialSkin.Controls.MaterialRaisedButton btnLuu;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMatKhauMoi1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMatKhauCu;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMatKhauMoi2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}