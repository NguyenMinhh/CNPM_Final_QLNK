using System;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.Drawing;

namespace QLNK
{
    public partial class ThemTamTru : MaterialForm
    {
        readonly SourceCode _sourceCode = new SourceCode();
        public ThemTamTru()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaNhanKhau.Text = "";
            cbTamTru.SelectedIndex = -1;
            txtDiaChi.Text = "";
            txtSoDienThoai.Text = "";
            cbNgay.SelectedIndex = -1;
            cbThang.SelectedIndex = -1;
            cbNam.SelectedIndex = -1;
        }

        private void btnThemTamTru_Click(object sender, EventArgs e)
        {
            var viTriTamTru = cbTamTru.SelectedIndex;
            var tamTru = cbTamTru.Text;
            var ngay = cbNgay.Text;
            var thang = cbThang.Text;
            var nam = cbNam.Text;

            var maTamTru = _sourceCode.SetPrimaryKey("TAMTRU", "MTT");
            var maNhanKhau = txtMaNhanKhau.Text;
            string tenNoiTamTru;
            if (viTriTamTru == 1 || viTriTamTru == 3)
            {
                tenNoiTamTru = cbTamTru.Text + " " + txtTenNoiTamTru.Text;
            }
            else
            {
                tenNoiTamTru = cbTamTru.Text;
            }
            var diaChi = txtDiaChi.Text;
            var soDienThoai = txtSoDienThoai.Text;
            var thoiHan = cbNgay.Text + "/" + cbThang.Text + "/" + cbNam.Text;

            if (!(maTamTru.Equals("")   || maNhanKhau.Equals("")|| ngay.Equals("")  ||
                thang.Equals("")        || nam.Equals("")       || tamTru.Equals("")||
                diaChi.Equals("")       || soDienThoai.Equals("")))
            {
                if (viTriTamTru == 1 || viTriTamTru == 3)
                {
                    if (!txtTenNoiTamTru.Text.Equals(""))
                    {
                        if (!_sourceCode.AddTamTru(maTamTru, maNhanKhau, tenNoiTamTru, diaChi, soDienThoai, thoiHan)) return;
                        MessageBox.Show(_sourceCode.SuccessAdd);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show(_sourceCode.ErrorBlank);
                    }
                }
                else
                {
                    if (!_sourceCode.AddTamTru(maTamTru, maNhanKhau, tenNoiTamTru, diaChi, soDienThoai, thoiHan)) return;
                    MessageBox.Show(_sourceCode.SuccessAdd);
                    Close();
                }
            }
            else
            {
                MessageBox.Show(_sourceCode.ErrorBlank);
            }
        }

        private void cbTamTru_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = cbTamTru.SelectedIndex;
            if (index == 1 || index == 3)
            {
                txtTenNoiTamTru.Visible = true;
            }
            else
            {
                txtTenNoiTamTru.Visible = false;
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

        private void txtMaNhanKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btnMaNhanKhau_Click(object sender, EventArgs e)
        {
            Location = new Point(188, 171);
            var nk = new NhanKhau();
            nk.ShowDialog();
            if (!nk.GetMnk().Equals("") && nk.GetFlagSave())
            {
                txtMaNhanKhau.Text = nk.GetMnk();
            }
            CenterToScreen();
        }
    }
}
