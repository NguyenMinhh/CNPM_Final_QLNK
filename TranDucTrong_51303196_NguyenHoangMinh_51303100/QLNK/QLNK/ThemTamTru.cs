using System;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace QLNK
{
    public partial class ThemTamTru : MaterialForm
    {
        SourceCode sc = new SourceCode();
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
            int viTriTamTru = cbTamTru.SelectedIndex;
            string tamTru = cbTamTru.Text;
            string ngay = cbNgay.Text;
            string thang = cbThang.Text;
            string nam = cbNam.Text;

            string maTamTru = sc.setPrimaryKey("TAMTRU", "MTT"); ;
            string maNhanKhau = txtMaNhanKhau.Text;
            string tenNoiTamTru = "";
            if (viTriTamTru == 1 || viTriTamTru == 3)
            {
                tenNoiTamTru = cbTamTru.Text + " " + txtTenNoiTamTru.Text;
            }
            else
            {
                tenNoiTamTru = cbTamTru.Text;
            }
            string diaChi = txtDiaChi.Text;
            string soDienThoai = txtSoDienThoai.Text;
            string thoiHan = cbNgay.Text + "/" + cbThang.Text + "/" + cbNam.Text;

            if (!(maTamTru.Equals("")   || maNhanKhau.Equals("")|| ngay.Equals("")  ||
                thang.Equals("")        || nam.Equals("")       || tamTru.Equals("")||
                diaChi.Equals("")       || soDienThoai.Equals("")))
            {
                if (viTriTamTru == 1 || viTriTamTru == 3)
                {
                    if (!txtTenNoiTamTru.Text.Equals(""))
                    {
                        if (sc.addTamTru(maTamTru, maNhanKhau, tenNoiTamTru,
                                         diaChi, soDienThoai, thoiHan))
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
                else
                {
                    if (sc.addTamTru(maTamTru, maNhanKhau, tenNoiTamTru,
                                     diaChi, soDienThoai, thoiHan))
                    {
                        MessageBox.Show(sc.SUCCESS_ADD);
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show(sc.ERROR_BLANK);
            }
        }

        private void cbTamTru_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbTamTru.SelectedIndex;
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
    }
}
