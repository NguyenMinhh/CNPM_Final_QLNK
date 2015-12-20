using System;
using System.Windows.Forms;
using MaterialSkin.Controls;
using static System.Int32;

namespace QLNK
{
    public partial class ThemKetHon : MaterialForm
    {
        readonly SourceCode _sourceCode = new SourceCode();
        public ThemKetHon()
        {
            InitializeComponent();
        }

        private void btnThemKetHon_Click(object sender, EventArgs e)
        {
            var ngayChong = cbNgaySinhChong.Text;
            var thangChong = cbThangSinhChong.Text;
            var namChong = cbNamSinhChong.Text;
            var ngayVo = cbNgaySinhVo.Text;
            var thangVo = cbThangSinhVo.Text;
            var namVo = cbNamSinhVo.Text;
            var ngayDk = cbNgayDangKy.Text;
            var thangDk = cbThangDangKy.Text;
            var namDk = cbNamDangKy.Text;

            var maKetHon = _sourceCode.SetPrimaryKey("KETHON", "MKH");
            var hoTenChong = txtHoTenChong.Text;
            var ngaySinhChong = ngayChong + "/" + thangChong + "/" + namChong;
            var danTocChong = cbDanTocChong.Text;
            var queQuanChong = cbQueQuanChong.Text;
            var cmndChong = txtCMNDChong.Text;
            var thuongTamTruChong = txtThuongTamTruChong.Text;
            var hoTenVo = txtHoTenVo.Text;
            var ngaySinhVo = ngayVo + "/" + thangVo + "/" + namVo;
            var danTocVo = cbDanTocVo.Text;
            var queQuanVo = cbQueQuanVo.Text;
            var cmndVo = txtCMNDVo.Text;
            var thuongTamTruVo = txtThuongTamTruVo.Text;
            var khuVucDangKy = cbQueQuan.Text;
            var ngayDangKy = ngayDk + "/" + thangDk + "/" + namDk;

            if (!(maKetHon.Equals("")       || hoTenChong.Equals("")    || ngayChong.Equals("")         ||
                  thangChong.Equals("")     || namChong.Equals("")      || danTocChong.Equals("")       ||
                  queQuanChong.Equals("")   || cmndChong.Equals("")     || thuongTamTruChong.Equals("") ||
                  hoTenVo.Equals("")        || ngayVo.Equals("")        || thangVo.Equals("")           ||
                  namVo.Equals("")          || danTocVo.Equals("")      || queQuanVo.Equals("")         ||
                  cmndVo.Equals("")         || thuongTamTruVo.Equals("")|| khuVucDangKy.Equals("")      ||
                  ngayDk.Equals("")         || thangDk.Equals("")       || namDk.Equals("")))
            {
                if (!_sourceCode.AddKetHon(maKetHon, hoTenChong, ngaySinhChong, danTocChong, queQuanChong, thuongTamTruChong,
                    cmndChong, hoTenVo, ngaySinhVo, danTocVo, queQuanVo, thuongTamTruVo, cmndVo, khuVucDangKy, ngayDangKy))
                    return;
                MessageBox.Show(_sourceCode.SuccessAdd);
                Close();
            }
            else
            {
                MessageBox.Show(_sourceCode.ErrorBlank);
            }
        }

        private void btnClearChong_Click(object sender, EventArgs e)
        {
            txtHoTenChong.Text = "";
            cbNgaySinhChong.SelectedIndex = -1;
            cbThangSinhChong.SelectedIndex = -1;
            cbNamSinhChong.SelectedIndex = -1;
            cbDanTocChong.SelectedIndex = -1;
            cbQueQuanChong.SelectedIndex = -1;
            txtCMNDChong.Text = "";
            txtThuongTamTruChong.Text = "";
        }

        private void btnClearVo_Click(object sender, EventArgs e)
        {
            txtHoTenVo.Text = "";
            cbNgaySinhVo.SelectedIndex = -1;
            cbThangSinhVo.SelectedIndex = -1;
            cbNamSinhVo.SelectedIndex = -1;
            cbDanTocVo.SelectedIndex = -1;
            cbQueQuanVo.SelectedIndex = -1;
            txtCMNDVo.Text = "";
            txtThuongTamTruVo.Text = "";
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

        private void txtHoTenChong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtHoTenVo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtCMNDChong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtCMNDVo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void cbNamDangKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(cbNamDangKy.Text.Equals("") || cbNamSinhChong.Text.Equals("")))
            {
                var test = Parse(cbNamDangKy.Text) - Parse(cbNamSinhChong.Text);
                if (test < 20 && test > 0)
                {
                    MessageBox.Show(@"Chưa đủ tuổi đăng ký kết hôn!");
                    cbNamDangKy.SelectedIndex = -1;
                }
                else if (test < 0)
                {
                    MessageBox.Show(@"Không hợp lệ!");
                    cbNamDangKy.SelectedIndex = -1;
                }
            }

            if (!(cbNamDangKy.Text.Equals("") || cbNamSinhVo.Text.Equals("")))
            {
                var test = Parse(cbNamDangKy.Text) - Parse(cbNamSinhVo.Text);
                if (test < 18 && test > 0)
                {
                    MessageBox.Show(@"Chưa đủ tuổi đăng ký kết hôn!");
                    cbNamDangKy.SelectedIndex = -1;
                }
                else if (test < 0)
                {
                    MessageBox.Show(@"Không hợp lệ!");
                    cbNamDangKy.SelectedIndex = -1;
                }
            }
        }

        private void cbNamSinhChong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNamDangKy.Text.Equals("") || cbNamSinhChong.Text.Equals("")) return;
            var test = Parse(cbNamDangKy.Text) - Parse(cbNamSinhChong.Text);
            if (test < 20 && test > 0)
            {
                MessageBox.Show(@"Chưa đủ tuổi đăng ký kết hôn!");
                cbNamSinhChong.SelectedIndex = -1;
            }
            else if (test < 0)
            {
                MessageBox.Show(@"Không hợp lệ!");
                cbNamSinhChong.SelectedIndex = -1;
            }
        }

        private void cbNamSinhVo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNamDangKy.Text.Equals("") || cbNamSinhVo.Text.Equals("")) return;
            var test = Parse(cbNamDangKy.Text) - Parse(cbNamSinhVo.Text);
            if (test < 18 && test > 0)
            {
                MessageBox.Show(@"Chưa đủ tuổi đăng ký kết hôn!");
                cbNamSinhVo.SelectedIndex = -1;
            }
            else if (test < 0)
            {
                MessageBox.Show(@"Không hợp lệ!");
                cbNamSinhVo.SelectedIndex = -1;
            }
        }

    }
}
