using System;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace QLNK
{
    public partial class ThemNhanKhau : MaterialForm
    {
        SourceCode sc = new SourceCode();
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
            string maNhanKhau = sc.setPrimaryKey("NHANKHAU", "MNK"); ;
            string hoTen = txtHoTen.Text;
            string ngay = cbNgay.Text;
            string thang = cbThang.Text;
            string nam = cbNam.Text;
            string ngaySinh = ngay + "/" + thang + "/" + nam;
            string gioiTinh = (rdNam.Checked && !rdNu.Checked) ? "Nam" : "Nữ";
            string danToc = cbDanToc.Text;
            string queQuan = cbQueQuan.Text;
            string tonGiao = cbTonGiao.Text;
            string cmnd = txtCMND.Text;
            string maHoKhau = txtMaHoKhau.Text;
            string ngheNghiep = txtNgheNghiep.Text;

            if (!(maNhanKhau.Equals("") || hoTen.Equals("")     || (!rdNam.Checked && !rdNu.Checked)    ||
                  ngay.Equals("")       || thang.Equals("")     || nam.Equals("")        || danToc.Equals("")||
                  queQuan.Equals("")    || tonGiao.Equals("")   || maHoKhau.Equals("")   || ngheNghiep.Equals("")))
            {
                if (txtCMND.Enabled == false)
                {
                    cmnd = "";
                    if (sc.addNhanKhau(maNhanKhau, hoTen, ngaySinh, gioiTinh, queQuan,
                                   tonGiao, danToc, cmnd, maHoKhau, ngheNghiep))
                    {
                        MessageBox.Show(sc.SUCCESS_ADD);
                        this.Close();
                    }
                }
                else
                {
                    if (!cmnd.Equals(""))
                    {
                        if (sc.addNhanKhau(maNhanKhau, hoTen, ngaySinh, gioiTinh, queQuan,
                                           tonGiao, danToc, cmnd, maHoKhau, ngheNghiep))
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
    }
}