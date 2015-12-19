using System;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace QLNK
{
    public partial class ThemKetHon : MaterialForm
    {
        SourceCode sc = new SourceCode();
        public ThemKetHon()
        {
            InitializeComponent();
        }

        private void btnThemKetHon_Click(object sender, EventArgs e)
        {
            string ngayChong = cbNgaySinhChong.Text;
            string thangChong = cbThangSinhChong.Text;
            string namChong = cbNamSinhChong.Text;
            string ngayVo = cbNgaySinhVo.Text;
            string thangVo = cbThangSinhVo.Text;
            string namVo = cbNamSinhVo.Text;
            string ngayDK = cbNgayDangKy.Text;
            string thangDK = cbThangDangKy.Text;
            string namDK = cbNamDangKy.Text;

            string maKetHon = sc.setPrimaryKey("KETHON", "MKH");
            string hoTenChong = txtHoTenChong.Text;
            string ngaySinhChong = ngayChong + "/" + thangChong + "/" + namChong;
            string danTocChong = cbDanTocChong.Text;
            string queQuanChong = cbQueQuanChong.Text;
            string cmndChong = txtCMNDChong.Text;
            string thuongTamTruChong = txtThuongTamTruChong.Text;
            string hoTenVo = txtHoTenVo.Text;
            string ngaySinhVo = ngayVo + "/" + thangVo + "/" + namVo;
            string danTocVo = cbDanTocVo.Text;
            string queQuanVo = cbQueQuanVo.Text;
            string cmndVo = txtCMNDVo.Text;
            string thuongTamTruVo = txtThuongTamTruVo.Text;
            string khuVucDangKy = cbQueQuan.Text;
            string ngayDangKy = ngayDK + "/" + thangDK + "/" + namDK;

            if (!(maKetHon.Equals("")       || hoTenChong.Equals("")    || ngayChong.Equals("")         ||
                  thangChong.Equals("")     || namChong.Equals("")      || danTocChong.Equals("")       ||
                  queQuanChong.Equals("")   || cmndChong.Equals("")     || thuongTamTruChong.Equals("") ||
                  hoTenVo.Equals("")        || ngayVo.Equals("")        || thangVo.Equals("")           ||
                  namVo.Equals("")          || danTocVo.Equals("")      || queQuanVo.Equals("")         ||
                  cmndVo.Equals("")         || thuongTamTruVo.Equals("")|| khuVucDangKy.Equals("")      ||
                  ngayDK.Equals("")         || thangDK.Equals("")       || namDK.Equals("")))
            {
                if (sc.addKetHon(maKetHon, hoTenChong, ngaySinhChong, danTocChong, queQuanChong,
                                 thuongTamTruChong, cmndChong, hoTenVo, ngaySinhVo, danTocVo,
                                 queQuanVo, thuongTamTruVo, cmndVo, khuVucDangKy, ngayDangKy))
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
                int test = Int32.Parse(cbNamDangKy.Text) - Int32.Parse(cbNamSinhChong.Text);
                if (test < 20 && test > 0)
                {
                    MessageBox.Show("Chưa đủ tuổi đăng ký kết hôn!");
                    cbNamDangKy.SelectedIndex = -1;
                }
                else if (test < 0)
                {
                    MessageBox.Show("Không hợp lệ!");
                    cbNamDangKy.SelectedIndex = -1;
                }
            }

            if (!(cbNamDangKy.Text.Equals("") || cbNamSinhVo.Text.Equals("")))
            {
                int test = Int32.Parse(cbNamDangKy.Text) - Int32.Parse(cbNamSinhVo.Text);
                if (test < 18 && test > 0)
                {
                    MessageBox.Show("Chưa đủ tuổi đăng ký kết hôn!");
                    cbNamDangKy.SelectedIndex = -1;
                }
                else if (test < 0)
                {
                    MessageBox.Show("Không hợp lệ!");
                    cbNamDangKy.SelectedIndex = -1;
                }
            }
        }

        private void cbNamSinhChong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(cbNamDangKy.Text.Equals("") || cbNamSinhChong.Text.Equals("")))
            {
                int test = Int32.Parse(cbNamDangKy.Text) - Int32.Parse(cbNamSinhChong.Text);
                if (test < 20 && test > 0)
                {
                    MessageBox.Show("Chưa đủ tuổi đăng ký kết hôn!");
                    cbNamSinhChong.SelectedIndex = -1;
                }
                else if (test < 0)
                {
                    MessageBox.Show("Không hợp lệ!");
                    cbNamSinhChong.SelectedIndex = -1;
                }
            }
        }

        private void cbNamSinhVo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(cbNamDangKy.Text.Equals("") || cbNamSinhVo.Text.Equals("")))
            {
                int test = Int32.Parse(cbNamDangKy.Text) - Int32.Parse(cbNamSinhVo.Text);
                if (test < 18 && test > 0)
                {
                    MessageBox.Show("Chưa đủ tuổi đăng ký kết hôn!");
                    cbNamSinhVo.SelectedIndex = -1;
                }
                else if (test < 0)
                {
                    MessageBox.Show("Không hợp lệ!");
                    cbNamSinhVo.SelectedIndex = -1;
                }
            }
        }

    }
}
