using System;
using System.Windows.Forms;
using MaterialSkin.Controls;
using static System.Int32;

namespace QLNK
{
    public partial class ThemChungTu : MaterialForm
    {
        readonly SourceCode _sourceCode = new SourceCode();
        public ThemChungTu()
        {
            InitializeComponent();
        }

        private void btnThemChungTu_Click(object sender, EventArgs e)
        {
            var ngayDk = cbNgayDangKy.Text;
            var thangDk = cbThangDangKy.Text;
            var namDk = cbNamDangKy.Text;
            var ngaySinh = cbNgaySinh.Text;
            var thangSinh = cbThangSinh.Text;
            var namSinh = cbNamSinh.Text;
            var ngayMat = cbNgayMat.Text;
            var thangMat = cbThangMat.Text;
            var namMat = cbNamMat.Text;
            var gioMat = cbGio.Text;
            var phutMat = cbPhut.Text;

            var maChungTu = _sourceCode.SetPrimaryKey("CHUNGTU", "MCT");
            var tenNguoiKhai = txtNguoiKhai.Text;
            var thuongTamTru = txtThuongTamTru.Text;
            var qhVoiNguoiMat = cbQuanHeVoiNguoiMat.Text;
            var tenNguoiMat = txtTenNguoiMat.Text;
            var ngaySinhNguoiMat = ngaySinh + "/" + thangSinh + "/" + namSinh;
            var danToc = cbDanToc.Text;
            var quocTich = cbQuocTich.Text;
            var cmnd = txtCMND.Text;
            var ngayQuaDoi = ngayMat + "/" + thangMat + "/" + namMat;
            var thoiGianQuaDoi = gioMat + ":" + phutMat;
            var ngayDangKy = ngayDk + "/" + thangDk + "/" + namDk;
            var khuVucDangKy = cbQueQuan.Text;

            if (!(maChungTu.Equals("")      || tenNguoiKhai.Equals("")  || thuongTamTru.Equals("")  ||
                  qhVoiNguoiMat.Equals("")  || tenNguoiMat.Equals("")   || ngaySinh.Equals("")      ||
                  thangSinh.Equals("")      || namSinh.Equals("")       || quocTich.Equals("")      ||
                  ngayMat.Equals("")        || thangMat.Equals("")      || namMat.Equals("")        ||
                  gioMat.Equals("")         || phutMat.Equals("")       || khuVucDangKy.Equals("")     ||
                  ngayDk.Equals("")         || thangDk.Equals("")       || namDk.Equals("")))
            {
                if (txtCMND.Enabled == false)
                {
                    cmnd = "";
                    if (cbDanToc.Enabled == false)
                    {
                        danToc = "";
                        if (!_sourceCode.AddChungTu(maChungTu, tenNguoiKhai, thuongTamTru, qhVoiNguoiMat, tenNguoiMat, ngaySinhNguoiMat,
                                                    danToc, quocTich, cmnd, ngayQuaDoi, thoiGianQuaDoi, khuVucDangKy, ngayDangKy))
                            return;
                        MessageBox.Show(_sourceCode.SuccessAdd);
                        Close();
                    }
                    else
                    {
                        if (!danToc.Equals(""))
                        {
                            if (!_sourceCode.AddChungTu(maChungTu, tenNguoiKhai, thuongTamTru, qhVoiNguoiMat, tenNguoiMat, ngaySinhNguoiMat,
                                                        danToc, quocTich, cmnd, ngayQuaDoi, thoiGianQuaDoi, khuVucDangKy, ngayDangKy))
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
                    if (cbDanToc.Enabled == false)
                    {
                        danToc = "";
                        if (!cmnd.Equals(""))
                        {
                            if (!_sourceCode.AddChungTu(maChungTu, tenNguoiKhai, thuongTamTru, qhVoiNguoiMat, tenNguoiMat, ngaySinhNguoiMat,
                                                        danToc, quocTich, cmnd, ngayQuaDoi, thoiGianQuaDoi, khuVucDangKy, ngayDangKy))
                                return;
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
                        if (!(cmnd.Equals("") || danToc.Equals("")))
                        {
                            if (!_sourceCode.AddChungTu(maChungTu, tenNguoiKhai, thuongTamTru, qhVoiNguoiMat, tenNguoiMat, ngaySinhNguoiMat,
                                                        danToc, quocTich, cmnd, ngayQuaDoi, thoiGianQuaDoi, khuVucDangKy, ngayDangKy))
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
            }
            else
            {
                MessageBox.Show(_sourceCode.ErrorBlank);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNguoiKhai.Text = "";
            txtThuongTamTru.Text = "";
            cbQuanHeVoiNguoiMat.SelectedIndex = -1;
            cbNgayDangKy.SelectedIndex = -1;
            cbThangDangKy.SelectedIndex = -1;
            cbNamDangKy.SelectedIndex = -1;
            cbQueQuan.SelectedIndex = -1;
            txtTenNguoiMat.Text = "";
            cbNgaySinh.SelectedIndex = -1;
            cbThangSinh.SelectedIndex = -1;
            cbNamSinh.SelectedIndex = -1;
            cbDanToc.SelectedIndex = -1;
            cbQuocTich.SelectedIndex = -1;
            txtCMND.Text = "";
            cbNgayMat.SelectedIndex = -1;
            cbThangMat.SelectedIndex = -1;
            cbNamMat.SelectedIndex = -1;
            cbGio.SelectedIndex = -1;
            cbPhut.SelectedIndex = -1;
            lblDanToc.Enabled = true;
            lblCMND.Enabled = true;
            cbDanToc.Enabled = true;
            txtCMND.Enabled = true;
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

        //------------------------------------------------------------------------Key press

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtTenNguoiMat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtNguoiKhai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        //--------------------------------------------------------------------Không hợp lệ
        private void DetectNamDangKyVaNamMat(int n)
        {
            if (cbNamDangKy.Text.Equals("") || cbNamMat.Text.Equals("")) return;
            var namDangKy = Parse(cbNamDangKy.Text);
            var namMat = Parse(cbNamMat.Text);
            if (namDangKy == namMat)
            {
                if (cbThangDangKy.Text.Equals("") || cbThangMat.Text.Equals("")) return;
                var thangDangKy = Parse(cbThangDangKy.Text);
                var thangMat = Parse(cbThangMat.Text);
                if (thangDangKy == thangMat)
                {
                    if (cbNgayDangKy.Text.Equals("") || cbNgayMat.Text.Equals("")) return;
                    var ngayDangKy = Parse(cbNgayDangKy.Text);
                    var ngayMat = Parse(cbNgayMat.Text);
                    if (ngayDangKy >= ngayMat) return;
                    MessageBox.Show(@"Không hợp lệ!");
                    switch (n)
                    {
                        case 1: cbNamDangKy.SelectedIndex = -1; break;
                        case 2: cbThangDangKy.SelectedIndex = -1; break;
                        case 3: cbNgayDangKy.SelectedIndex = -1; break;
                        case 4: cbNamMat.SelectedIndex = -1; break;
                        case 5: cbThangMat.SelectedIndex = -1; break;
                        case 6: cbNgayMat.SelectedIndex = -1; break;
                    }
                }
                else if (thangDangKy < thangMat)
                {
                    MessageBox.Show(@"Không hợp lệ!");
                    switch (n)
                    {
                        case 1: cbNamDangKy.SelectedIndex = -1; break;
                        case 2: cbThangDangKy.SelectedIndex = -1; break;
                        case 3: cbNgayDangKy.SelectedIndex = -1; break;
                        case 4: cbNamMat.SelectedIndex = -1; break;
                        case 5: cbThangMat.SelectedIndex = -1; break;
                        case 6: cbNgayMat.SelectedIndex = -1; break;
                    }
                }
            }
            else if (namDangKy < namMat)
            {
                MessageBox.Show(@"Không hợp lệ!");
                switch (n)
                {
                    case 1: cbNamDangKy.SelectedIndex = -1; break;
                    case 2: cbThangDangKy.SelectedIndex = -1; break;
                    case 3: cbNgayDangKy.SelectedIndex = -1; break;
                    case 4: cbNamMat.SelectedIndex = -1; break;
                    case 5: cbThangMat.SelectedIndex = -1; break;
                    case 6: cbNgayMat.SelectedIndex = -1; break;
                }
            }
        }

        private void DetectNamDangKyVaNamSinh(int n)
        {
            if (cbNamDangKy.Text.Equals("") || cbNamSinh.Text.Equals("")) return;
            var namDangKy = Parse(cbNamDangKy.Text);
            var namSinh = Parse(cbNamSinh.Text);
            if (namDangKy == namSinh)
            {
                if (cbThangDangKy.Text.Equals("") || cbThangSinh.Text.Equals("")) return;
                var thangDangKy = Parse(cbThangDangKy.Text);
                var thangSinh = Parse(cbThangSinh.Text);
                if (thangDangKy == thangSinh)
                {
                    if (cbNgayDangKy.Text.Equals("") || cbNgaySinh.Text.Equals("")) return;
                    var ngayDangKy = Parse(cbNgayDangKy.Text);
                    var ngaySinh = Parse(cbNgaySinh.Text);
                    if (ngayDangKy >= ngaySinh) return;
                    MessageBox.Show(@"Không hợp lệ!");
                    switch (n)
                    {
                        case 1: cbNamDangKy.SelectedIndex = -1; break;
                        case 2: cbThangDangKy.SelectedIndex = -1; break;
                        case 3: cbNgayDangKy.SelectedIndex = -1; break;
                        case 4: cbNamSinh.SelectedIndex = -1; break;
                        case 5: cbThangSinh.SelectedIndex = -1; break;
                        case 6: cbNgaySinh.SelectedIndex = -1; break;
                    }
                }
                else if (thangDangKy < thangSinh)
                {
                    MessageBox.Show(@"Không hợp lệ!");
                    switch (n)
                    {
                        case 1: cbNamDangKy.SelectedIndex = -1; break;
                        case 2: cbThangDangKy.SelectedIndex = -1; break;
                        case 3: cbNgayDangKy.SelectedIndex = -1; break;
                        case 4: cbNamSinh.SelectedIndex = -1; break;
                        case 5: cbThangSinh.SelectedIndex = -1; break;
                        case 6: cbNgaySinh.SelectedIndex = -1; break;
                    }
                }
            }
            else if (namDangKy < namSinh)
            {
                MessageBox.Show(@"Không hợp lệ!");
                switch (n)
                {
                    case 1: cbNamDangKy.SelectedIndex = -1; break;
                    case 2: cbThangDangKy.SelectedIndex = -1; break;
                    case 3: cbNgayDangKy.SelectedIndex = -1; break;
                    case 4: cbNamSinh.SelectedIndex = -1; break;
                    case 5: cbThangSinh.SelectedIndex = -1; break;
                    case 6: cbNgaySinh.SelectedIndex = -1; break;
                }
            }
        }

        private void DetectNamMatVaNamSinh(int n)
        {
            if (cbNamSinh.Text.Equals("") || cbNamMat.Text.Equals("")) return;
            var namMat = Parse(cbNamMat.Text);
            var namSinh = Parse(cbNamSinh.Text);
            if (namMat == namSinh)
            {
                if (cbThangMat.Text.Equals("") || cbThangSinh.Text.Equals("")) return;
                var thangMat = Parse(cbThangMat.Text);
                var thangSinh = Parse(cbThangSinh.Text);
                if (thangMat == thangSinh)
                {
                    if (cbNgayMat.Text.Equals("") || cbNgaySinh.Text.Equals("")) return;
                    var ngayMat = Parse(cbNgayMat.Text);
                    var ngaySinh = Parse(cbNgaySinh.Text);
                    if (ngayMat >= ngaySinh) return;
                    MessageBox.Show(@"Không hợp lệ!");
                    switch (n)
                    {
                        case 1: cbNamMat.SelectedIndex = -1; break;
                        case 2: cbThangMat.SelectedIndex = -1; break;
                        case 3: cbNgayMat.SelectedIndex = -1; break;
                        case 4: cbNamSinh.SelectedIndex = -1; break;
                        case 5: cbThangSinh.SelectedIndex = -1; break;
                        case 6: cbNgaySinh.SelectedIndex = -1; break;
                    }
                }
                else if (thangMat < thangSinh)
                {
                    MessageBox.Show(@"Không hợp lệ!");
                    switch (n)
                    {
                        case 1: cbNamMat.SelectedIndex = -1; break;
                        case 2: cbThangMat.SelectedIndex = -1; break;
                        case 3: cbNgayMat.SelectedIndex = -1; break;
                        case 4: cbNamSinh.SelectedIndex = -1; break;
                        case 5: cbThangSinh.SelectedIndex = -1; break;
                        case 6: cbNgaySinh.SelectedIndex = -1; break;
                    }
                }
            }
            else if (namMat < namSinh)
            {
                MessageBox.Show(@"Không hợp lệ!");
                switch (n)
                {
                    case 1: cbNamMat.SelectedIndex = -1; break;
                    case 2: cbThangMat.SelectedIndex = -1; break;
                    case 3: cbNgayMat.SelectedIndex = -1; break;
                    case 4: cbNamSinh.SelectedIndex = -1; break;
                    case 5: cbThangSinh.SelectedIndex = -1; break;
                    case 6: cbNgaySinh.SelectedIndex = -1; break;
                }
            }
        }

        private void cbNamDangKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            DetectNamDangKyVaNamSinh(1);
            DetectNamDangKyVaNamMat(1);
        }

        private void cbThangDangKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            DetectNamDangKyVaNamSinh(2);
            DetectNamDangKyVaNamMat(2);
        }

        private void cbNgayDangKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            DetectNamDangKyVaNamSinh(3);
            DetectNamDangKyVaNamMat(3);
        }

        private void cbNgaySinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            DetectNamDangKyVaNamSinh(6);
            DetectNamMatVaNamSinh(6);
        }

        private void cbThangSinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            DetectNamDangKyVaNamSinh(5);
            DetectNamMatVaNamSinh(5);
        }

        private void cbNamSinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            DetectNamDangKyVaNamSinh(4);
            DetectNamMatVaNamSinh(4);
            if (cbNamMat.Text.Equals("") || cbNamSinh.Text.Equals("")) return;
            var test = Parse(cbNamMat.Text) - Parse(cbNamSinh.Text);
            switch (test)
            {
                case 0:
                case 1:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 11:
                case 12:
                case 13:
                case 14:
                    txtCMND.Enabled = false;
                    lblCMND.Enabled = false;
                    break;
                default:
                    txtCMND.Enabled = true;
                    lblCMND.Enabled = true;
                    break;
            }
        }

        private void cbNgayMat_SelectedIndexChanged(object sender, EventArgs e)
        {
            DetectNamDangKyVaNamMat(6);
            DetectNamMatVaNamSinh(3);
        }

        private void cbThangMat_SelectedIndexChanged(object sender, EventArgs e)
        {
            DetectNamDangKyVaNamMat(5);
            DetectNamMatVaNamSinh(2);
        }

        private void cbNamMat_SelectedIndexChanged(object sender, EventArgs e)
        {
            DetectNamDangKyVaNamMat(4);
            DetectNamMatVaNamSinh(1);
            if (cbNamMat.Text.Equals("") || cbNamSinh.Text.Equals("")) return;
            var test = Parse(cbNamMat.Text) - Parse(cbNamSinh.Text);
            switch (test)
            {
                case 0:
                case 1:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 11:
                case 12:
                case 13:
                case 14:
                    txtCMND.Enabled = false;
                    lblCMND.Enabled = false;
                    break;
                default:
                    txtCMND.Enabled = true;
                    lblCMND.Enabled = true;
                    break;
            }
        }

        private void cbQuocTich_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cbQuocTich.Text.Equals("Việt Nam"))
            {
                lblDanToc.Enabled = false;
                cbDanToc.Enabled = false;
            }
            else
            {
                lblDanToc.Enabled = true;
                cbDanToc.Enabled = true;
            }
        }

    }
}
