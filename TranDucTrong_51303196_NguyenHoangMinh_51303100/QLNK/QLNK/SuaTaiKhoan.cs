using System.Windows.Forms;
using MaterialSkin.Controls;
using System;

namespace QLNK
{
    public partial class SuaTaiKhoan : MaterialForm
    {
        SourceCode sc = new SourceCode();
        private string[] itemTaiKhoan;
        public SuaTaiKhoan(string[] itemTaiKhoan)
        {
            InitializeComponent();
            this.itemTaiKhoan = itemTaiKhoan;
            setNormal(itemTaiKhoan);
        }

        private void setNormal(string[] items)
        {
            txtMatKhauCu.Text = items[1];
        }

        private void btnLuu_Click(object sender, System.EventArgs e)
        {
            string matKhauMoi1 = txtMatKhauMoi1.Text;
            string matKhauMoi2 = txtMatKhauMoi2.Text;
            string tenTaiKhoan = itemTaiKhoan[0];
            string ngayCapNhat = DateTime.Now.ToString("dd/MM/yyyy") + " " + DateTime.Now.ToString("HH:mm:ss");
            if (!(matKhauMoi1.Equals("") || matKhauMoi2.Equals("")))
            {
                if (matKhauMoi1 == matKhauMoi2)
                {
                    DialogResult dialogResult = MessageBox.Show("Lưu mật khẩu mới ?", sc.MSGBOX_CAP_UPDATE, MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (sc.updateMatKhau(tenTaiKhoan, matKhauMoi1, ngayCapNhat))
                        {
                            this.Close();
                            MessageBox.Show(sc.SUCCESS_UPDATE);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Xác nhận mật khẩu mới thất bại!");
                }
            }
            else
            {
                MessageBox.Show(sc.ERROR_BLANK);
            }
        }

        private void btnClear_Click(object sender, System.EventArgs e)
        {
            txtMatKhauMoi1.Text = "";
            txtMatKhauMoi2.Text = "";
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
