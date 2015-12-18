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

        private void clearChong()
        {
            txtHoTenChong.Text = "";
            cbNgaySinhChong.SelectedIndex = -1;
            cbThangSinhChong.SelectedIndex = -1;
            cbNamSinhChong.SelectedIndex = -1;
            cbDanTocChong.SelectedIndex = -1;
            cbQuocTichChong.SelectedIndex = -1;
            txtCMNDChong.Text = "";
            txtThuongTamTruChong.Text = "";
        }

        private void clearVo()
        {
            txtHoTenVo.Text = "";
            cbNgaySinhVo.SelectedIndex = -1;
            cbThangSinhVo.SelectedIndex = -1;
            cbNamSinhVo.SelectedIndex = -1;
            cbDanTocVo.SelectedIndex = -1;
            cbQuocTichVo.SelectedIndex = -1;
            txtCMNDVo.Text = "";
            txtThuongTamTruVo.Text = "";
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

            string maKetHon = txtMaKetHon.Text;
            string hoTenChong = txtHoTenChong.Text;
            string ngaySinhChong = ngayChong + "/" + thangChong + "/" + namChong;
            string danTocChong = cbDanTocChong.Text;
            string quocTichChong = cbQuocTichChong.Text;
            string cmndChong = txtCMNDChong.Text;
            string thuongTamTruChong = txtThuongTamTruChong.Text;
            string hoTenVo = txtHoTenVo.Text;
            string ngaySinhVo = ngayVo + "/" + thangVo + "/" + namVo;
            string danTocVo = cbDanTocVo.Text;
            string quocTichVo = cbQuocTichVo.Text;
            string cmndVo = txtCMNDVo.Text;
            string thuongTamTruVo = txtThuongTamTruVo.Text;
            string khuVucDangKy = cbQueQuan.Text;
            string ngayDangKy = ngayDK + "/" + thangDK + "/" + namDK;

            if (!(maKetHon.Equals("")       || hoTenChong.Equals("")        || ngayChong.Equals("")         ||
                  thangChong.Equals("")     || namChong.Equals("")          || danTocChong.Equals("")       ||
                  quocTichChong.Equals("")  || cmndChong.Equals("")         || thuongTamTruChong.Equals("") ||
                  hoTenVo.Equals("")        || ngayVo.Equals("")            || thangVo.Equals("")           ||
                  namVo.Equals("")          || cbDanTocVo.Equals("")        || cbQuocTichVo.Equals("")      ||
                  txtCMNDVo.Equals("")      || txtThuongTamTruVo.Equals("") || cbQueQuan.Equals("")         ||
                  ngayDK.Equals("")         || thangDK.Equals("")           || namDK.Equals("")))
            {
                if (sc.addKetHon(maKetHon, hoTenChong, ngaySinhChong, danTocChong, quocTichChong,
                                 thuongTamTruChong, cmndChong, hoTenVo, ngaySinhVo, danTocVo,
                                 quocTichVo, thuongTamTruVo, cmndVo, khuVucDangKy, ngayDangKy))
                {
                    MessageBox.Show("Thêm thành công");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Điền đầy đủ rồi hẵng thêm");
            }
        }

        private void btnClearChong_Click(object sender, EventArgs e)
        {
            clearChong();
        }

        private void btnClearVo_Click(object sender, EventArgs e)
        {
            clearVo();
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

        private void txtMaKetHon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
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
    }
}
