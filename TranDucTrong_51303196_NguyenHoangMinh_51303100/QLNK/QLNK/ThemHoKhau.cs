using System;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace QLNK
{
    public partial class ThemHoKhau : MaterialForm
    {
        readonly SourceCode _sourceCode = new SourceCode();
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
            var maHoKhau = _sourceCode.SetPrimaryKey("HOKHAU", "MHK");
            var tenChuHo = txtHoTenChuHo.Text;
            var cmndChuHo = txtCMNDChuHo.Text;
            var khuVuc = cbQueQuan.Text;
            var diaChi = txtDiaChi.Text;
            var ngayLap = cbNgay.Text + "/" + cbThang.Text + "/" + cbNam.Text;
            var ngay = cbThang.Text;
            var thang = cbNgay.Text;
            var nam = cbNam.Text;
            if (!(maHoKhau.Equals("")   || tenChuHo.Equals("")  || cmndChuHo.Equals("") ||
                  ngay.Equals("")       || thang.Equals("")     || nam.Equals("")       ||
                  diaChi.Equals("")     || khuVuc.Equals("")))
            {
                if (!_sourceCode.AddHoKhau(maHoKhau, tenChuHo, cmndChuHo, khuVuc, diaChi, ngayLap)) return;
                MessageBox.Show(_sourceCode.SuccessAdd);
                Close();
            }
            else
            {
                MessageBox.Show(_sourceCode.ErrorBlank);
            }
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
