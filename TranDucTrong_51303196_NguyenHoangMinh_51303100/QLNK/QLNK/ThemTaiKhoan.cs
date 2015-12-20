using System.Windows.Forms;
using MaterialSkin.Controls;
using System;

namespace QLNK
{
    public partial class ThemTaiKhoan : MaterialForm
    {
        readonly SourceCode _sourceCode = new SourceCode();
        public ThemTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var tenDangNhap = txtTenDangNhap.Text;
            var matKhau = txtMatKhau.Text;
            var phanQuyen = 0;
            var ngayCapNhat = DateTime.Now.ToString("dd/MM/yyyy") + " " + DateTime.Now.ToString("HH:mm:ss");
            switch (cbQuyenHanh.Text)
            {
                case "Quản Lý Tài Khoản": phanQuyen = 1; break;
                case "Quản Lý Nhân Khẩu": phanQuyen = 2; break;
                case "Quản Lý Hộ Khẩu": phanQuyen = 3; break;
                case "Quản Lý Tạm Trú": phanQuyen = 4; break;
                case "Quản Lý Chứng Tử": phanQuyen = 5; break;
                case "Quản Lý Chứng Nhận Kết Hôn": phanQuyen = 6; break;
                case "Quản Lý Tiền Án Tiền Sự": phanQuyen = 7; break;
            }
            var nguoiSuDung = txtNguoiSuDung.Text;

            if (!(tenDangNhap.Equals("") || matKhau.Equals("") || phanQuyen == 0))
            {
                if (!_sourceCode.AddTaiKhoan(tenDangNhap, matKhau, ngayCapNhat, phanQuyen, nguoiSuDung)) return;
                MessageBox.Show(_sourceCode.SuccessAdd);
                Close();
            }
            else
            {
                MessageBox.Show(_sourceCode.ErrorBlank);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
            cbQuyenHanh.SelectedIndex = -1;
            txtNguoiSuDung.Text = "";
        }

        //---------------------------------------------------------Prevent form from moving

        protected override void WndProc(ref Message message)
        {
            const int wmSyscommand = 0x0112;
            const int scMove = 0xF010;

            switch (message.Msg)
            {
                case wmSyscommand:
                    var command = message.WParam.ToInt32() & 0xfff0;
                    if (command == scMove)
                        return;
                    break;
            }

            base.WndProc(ref message);
        }

        private void txtTenDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtNguoiSuDung_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}
