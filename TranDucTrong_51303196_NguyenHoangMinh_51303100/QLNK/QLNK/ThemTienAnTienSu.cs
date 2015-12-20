using System;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.Drawing;

namespace QLNK
{
    public partial class ThemTienAnTienSu : MaterialForm
    {
        readonly SourceCode _sourceCode = new SourceCode();
        public ThemTienAnTienSu()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaNhanKhau.Text = "";
            txtTenTienAnTienSu.Text = "";
            cbQueQuan.SelectedIndex = -1;
            cbNgay.SelectedIndex = -1;
            cbThang.SelectedIndex = -1;
            cbNam.SelectedIndex = -1;
        }

        private void btnThemTienAnTienSu_Click(object sender, EventArgs e)
        {
            var ngay = cbNgay.Text;
            var thang = cbThang.Text;
            var nam = cbNam.Text;
            
            var maTienAnTienSu = _sourceCode.SetPrimaryKey("TIENANTIENSU", "TATS");
            var maNhanKhau = txtMaNhanKhau.Text;
            var tenTienAnTienSu = txtTenTienAnTienSu.Text;
            var noiXetXu = cbQueQuan.Text;
            var ngayThucThi = ngay + "/" + thang + "/" + nam;
            if (!(maTienAnTienSu.Equals("") || maNhanKhau.Equals("")|| tenTienAnTienSu.Equals("") ||
                  noiXetXu.Equals("")       || ngay.Equals("")      || thang.Equals("")           ||
                  nam.Equals("")))
            {
                if (!_sourceCode.AddTienAnTienSu(maTienAnTienSu, maNhanKhau, tenTienAnTienSu, noiXetXu, ngayThucThi))
                    return;
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

        private void txtTenTienAnTienSu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtMaNhanKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btnNhanKhau_Click(object sender, EventArgs e)
        {
            Location = new Point(188,171);
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
