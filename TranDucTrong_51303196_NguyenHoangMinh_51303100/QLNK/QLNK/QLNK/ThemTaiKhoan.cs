using System.Windows.Forms;
using MaterialSkin.Controls;
using System;

namespace QLNK
{
    public partial class ThemTaiKhoan : MaterialForm
    {
        SourceCode sc = new SourceCode();
        public ThemTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, System.EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text;
            string matKhau = txtMatKhau.Text;
            int phanQuyen = 0;
            string ngayCapNhat = DateTime.Now.ToString("dd/MM/yyyy") + " " + DateTime.Now.ToString("HH:mm:ss");
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
            string nguoiSuDung = txtNguoiSuDung.Text;

            if (!(tenDangNhap.Equals("") || matKhau.Equals("") || phanQuyen == 0))
            {
                if (sc.addTaiKhoan(tenDangNhap, matKhau, ngayCapNhat, phanQuyen, nguoiSuDung))
                {
                    MessageBox.Show(sc.SUCCESS_ADD);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show(sc.ERROR_BLANK);
            }
        }

        private void btnClear_Click(object sender, System.EventArgs e)
        {
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
            cbQuyenHanh.SelectedIndex = -1;
            txtNguoiSuDung.Text = "";
        }

        //---------------------------------------------------------Prevent form from moving

        protected override void WndProc(ref Message message)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
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
