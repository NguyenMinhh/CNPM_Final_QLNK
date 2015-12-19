using System;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace QLNK
{
    public partial class ThemTienAnTienSu : MaterialForm
    {
        SourceCode sc = new SourceCode();
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
            string ngay = cbNgay.Text;
            string thang = cbThang.Text;
            string nam = cbNam.Text;

            
            string maTienAnTienSu = sc.setPrimaryKey("TIENANTIENSU", "TATS"); ;
            string maNhanKhau = txtMaNhanKhau.Text;
            string tenTienAnTienSu = txtTenTienAnTienSu.Text;
            string noiXetXu = cbQueQuan.Text;
            string ngayThucThi = ngay + "/" + thang + "/" + nam;
            if (!(maTienAnTienSu.Equals("") || maNhanKhau.Equals("")|| tenTienAnTienSu.Equals("") ||
                  noiXetXu.Equals("")       || ngay.Equals("")      || thang.Equals("")           ||
                  nam.Equals("")))
            {
                if (sc.addTienAnTienSu(maTienAnTienSu, maNhanKhau, tenTienAnTienSu, noiXetXu, ngayThucThi))
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

    }
}
