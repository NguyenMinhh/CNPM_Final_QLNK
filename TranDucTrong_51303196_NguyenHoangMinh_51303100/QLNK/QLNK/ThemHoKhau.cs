using System;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;

namespace QLNK
{
    public partial class ThemHoKhau : MaterialForm
    {
        SourceCode sc = new SourceCode();
        public ThemHoKhau()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbNam.SelectedIndex = -1;
            cbNgay.SelectedIndex = -1;
            cbThang.SelectedIndex = -1;
            txtHoTenChuHo.Text = "";
            cbQueQuan.Text = "";
            txtDiaChi.Text = "";
            txtCMNDChuHo.Text = "";
        }
        private void btnThemHoKhau_Click(object sender, EventArgs e)
        {
            string maHoKhau = sc.setPrimaryKey("HOKHAU", "MHK");
            string tenChuHo = txtHoTenChuHo.Text;
            string cmndChuHo = txtCMNDChuHo.Text;
            string khuVuc = cbQueQuan.Text;
            string diaChi = txtDiaChi.Text;
            string ngayLap = cbNgay.Text + "/" + cbThang.Text + "/" + cbNam.Text;
            string ngay = cbThang.Text;
            string thang = cbNgay.Text;
            string nam = cbNam.Text;
            if (!(maHoKhau.Equals("")   || tenChuHo.Equals("")  || cmndChuHo.Equals("") ||
                  ngay.Equals("")       || thang.Equals("")     || nam.Equals("")       ||
                  diaChi.Equals("")     || khuVuc.Equals("")))
            {

                if (sc.addHoKhau(maHoKhau, tenChuHo, cmndChuHo, khuVuc, diaChi, ngayLap))
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

        private void txtHoTenChuHo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtCMNDChuHo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
