using System.Windows.Forms;
using MaterialSkin.Controls;
using System;

namespace QLNK
{
    public partial class SuaTaiKhoan : MaterialForm
    {
        readonly SourceCode _sourceCode = new SourceCode();
        private readonly string[] _itemTaiKhoan;
        public SuaTaiKhoan(string[] itemTaiKhoan)
        {
            InitializeComponent();
            _itemTaiKhoan = itemTaiKhoan;
            SetNormal(itemTaiKhoan);
        }

        private void SetNormal(string[] items)
        {
            txtMatKhauCu.Text = items[1];
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var matKhauMoi1 = txtMatKhauMoi1.Text;
            var matKhauMoi2 = txtMatKhauMoi2.Text;
            var tenTaiKhoan = _itemTaiKhoan[0];
            var ngayCapNhat = DateTime.Now.ToString("dd/MM/yyyy") + " " + DateTime.Now.ToString("HH:mm:ss");
            if (!(matKhauMoi1.Equals("") || matKhauMoi2.Equals("")))
            {
                if (matKhauMoi1 == matKhauMoi2)
                {
                    var dialogResult = MessageBox.Show(@"Lưu mật khẩu mới ?", _sourceCode.MsgboxCapUpdate, MessageBoxButtons.YesNo);
                    if (dialogResult != DialogResult.Yes) return;
                    if (!_sourceCode.UpdateMatKhau(tenTaiKhoan, matKhauMoi1, ngayCapNhat)) return;
                    Close();
                    MessageBox.Show(_sourceCode.SuccessUpdate);
                }
                else
                {
                    MessageBox.Show(@"Xác nhận mật khẩu mới thất bại!");
                }
            }
            else
            {
                MessageBox.Show(_sourceCode.ErrorBlank);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMatKhauMoi1.Text = "";
            txtMatKhauMoi2.Text = "";
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

        private void txtMatKhauMoi1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtMatKhauMoi2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMatKhauMoi2_TextChanged(object sender, EventArgs e)
        {
            if (!txtMatKhauMoi1.Text.Equals(txtMatKhauMoi2.Text))
            {
                lblErrorPassword.Visible = true;
            }
            if (txtMatKhauMoi2.Text.Equals(txtMatKhauMoi1.Text))
            {
                lblErrorPassword.Visible = false;
            }
        }
    }
}
