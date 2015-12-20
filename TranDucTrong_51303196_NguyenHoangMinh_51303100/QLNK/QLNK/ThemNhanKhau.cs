using System;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.Drawing;

namespace QLNK
{
    public partial class ThemNhanKhau : MaterialForm
    {
        readonly SourceCode _sourceCode = new SourceCode();
        public ThemNhanKhau()
        {
            InitializeComponent();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            cbDanToc.SelectedIndex = -1;
            cbNam.SelectedIndex = -1;
            cbNgay.SelectedIndex = -1;
            cbQueQuan.SelectedIndex = -1;
            cbThang.SelectedIndex = -1;
            cbTonGiao.SelectedIndex = -1;
            rdNam.Checked = false;
            rdNu.Checked = false;
            txtCMND.Text = "";
            txtHoTen.Text = "";
            txtMaHoKhau.Text = "";
            txtNgheNghiep.Text = "";
        }
        private void btnThemNhanKhau_Click(object sender, EventArgs e)
        {
            var maNhanKhau = _sourceCode.SetPrimaryKey("NHANKHAU", "MNK");
            var hoTen = txtHoTen.Text;
            var ngay = cbNgay.Text;
            var thang = cbThang.Text;
            var nam = cbNam.Text;
            var ngaySinh = ngay + "/" + thang + "/" + nam;
            var gioiTinh = (rdNam.Checked && !rdNu.Checked) ? "Nam" : "Nữ";
            var danToc = cbDanToc.Text;
            var queQuan = cbQueQuan.Text;
            var tonGiao = cbTonGiao.Text;
            var cmnd = txtCMND.Text;
            var maHoKhau = txtMaHoKhau.Text;
            var ngheNghiep = txtNgheNghiep.Text;

            if (!(maNhanKhau.Equals("") || hoTen.Equals("")     || (!rdNam.Checked && !rdNu.Checked)    ||
                  ngay.Equals("")       || thang.Equals("")     || nam.Equals("")        || danToc.Equals("")||
                  queQuan.Equals("")    || tonGiao.Equals("")   || maHoKhau.Equals("")   || ngheNghiep.Equals("")))
            {
                if (txtCMND.Enabled == false)
                {
                    cmnd = "";
                    if (!_sourceCode.AddNhanKhau(maNhanKhau, hoTen, ngaySinh, gioiTinh, queQuan, tonGiao, danToc, cmnd, maHoKhau, ngheNghiep))
                        return;
                    MessageBox.Show(_sourceCode.SuccessAdd);
                    Close();
                }
                else
                {
                    if (!cmnd.Equals(""))
                    {
                        if (!_sourceCode.AddNhanKhau(maNhanKhau, hoTen, ngaySinh, gioiTinh, queQuan, tonGiao, danToc, cmnd, maHoKhau, ngheNghiep))
                            return;
                        MessageBox.Show(_sourceCode.SuccessAdd);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show(_sourceCode.ErrorBlank);
                    }
                }
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

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtMaHoKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void cbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbNam.Text)
            {
                case "2000":
                case "2001":
                case "2002":
                case "2003":
                case "2004":
                case "2005":
                case "2006":
                case "2007":
                case "2008":
                case "2009":
                case "2010":
                case "2011":
                case "2012":
                case "2013":
                case "2014":
                case "2015":
                    txtCMND.Enabled = false; lblCMND.Enabled = false; break;
                default:
                    txtCMND.Enabled = true; lblCMND.Enabled = true; break;
            }
        }

        private void btnHoKhau_Click(object sender, EventArgs e)
        {
            Location = new Point(188, 121);
            var hk = new HoKhau();
            hk.ShowDialog();
            if (!hk.GetMhk().Equals("") && hk.GetFlagSave())
            {
                txtMaHoKhau.Text = hk.GetMhk();
            }
            CenterToScreen();
        }
    }
}