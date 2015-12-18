using System;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;

namespace QLNK
{
    public partial class DangNhap : MaterialForm
    {
        SourceCode sc = new SourceCode();
        private readonly MaterialSkinManager materialSkinManager;
        public DangNhap()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            string id = txtTenDangNhap.Text;
            string password = txtMatKhau.Text;
            string phanQuyen = "";
            string nguoiSuDung = "";
            if (!id.Equals("") && !password.Equals(""))
            {
                if (sc.dangNhap(id,password,ref phanQuyen, ref nguoiSuDung) == 1)
                {
                    TrangChu f = new TrangChu(phanQuyen, nguoiSuDung);
                    this.Hide();
                    f.ShowDialog();
                    txtMatKhau.Text = "";
                    txtTenDangNhap.Text = "";
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                }
            }
            else
            {
                if (id.Equals(""))
                {
                    MessageBox.Show("Vui lòng nhập tài khoản");
                    txtTenDangNhap.Focus();
                }
               else
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu");
                    txtMatKhau.Focus();
                }
            }
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
            if (!char.IsControl(e.KeyChar) && char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}
