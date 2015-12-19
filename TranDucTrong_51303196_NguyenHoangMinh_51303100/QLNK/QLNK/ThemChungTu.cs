using System;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace QLNK
{
    public partial class ThemChungTu : MaterialForm
    {
        SourceCode sc = new SourceCode();
        public ThemChungTu()
        {
            InitializeComponent();
        }

        private void btnThemChungTu_Click(object sender, EventArgs e)
        {
            string ngayDK = cbNgayDangKy.Text;
            string thangDK = cbThangDangKy.Text;
            string namDK = cbNamDangKy.Text;
            string ngaySinh = cbNgaySinh.Text;
            string thangSinh = cbThangSinh.Text;
            string namSinh = cbNamSinh.Text;
            string ngayMat = cbNgayMat.Text;
            string thangMat = cbThangMat.Text;
            string namMat = cbNamMat.Text;
            string gioMat = cbGio.Text;
            string phutMat = cbPhut.Text;

            string maChungTu = sc.setPrimaryKey("CHUNGTU", "MCT");
            string tenNguoiKhai = txtNguoiKhai.Text;
            string thuongTamTru = txtThuongTamTru.Text;
            string qhVoiNguoiMat = cbQuanHeVoiNguoiMat.Text;
            string tenNguoiMat = txtTenNguoiMat.Text;
            string ngaySinhNguoiMat = ngaySinh + "/" + thangSinh + "/" + namSinh;
            string danToc = cbDanToc.Text;
            string quocTich = cbQuocTich.Text;
            string cmnd = txtCMND.Text;
            string ngayQuaDoi = ngayMat + "/" + thangMat + "/" + namMat;
            string thoiGianQuaDoi = gioMat + ":" + phutMat;
            string ngayDangKy = ngayDK + "/" + thangDK + "/" + namDK;
            string khuVucDangKy = cbQueQuan.Text;

            if (!(maChungTu.Equals("")      || tenNguoiKhai.Equals("")  || thuongTamTru.Equals("")  ||
                  qhVoiNguoiMat.Equals("")  || tenNguoiMat.Equals("")   || ngaySinh.Equals("")      ||
                  thangSinh.Equals("")      || namSinh.Equals("")       || quocTich.Equals("")      ||
                  ngayMat.Equals("")        || thangMat.Equals("")      || namMat.Equals("")        ||
                  gioMat.Equals("")         || phutMat.Equals("")       || cbQueQuan.Equals("")     ||
                  ngayDK.Equals("")         || thangDK.Equals("")       || namDK.Equals("")))
            {
                if (txtCMND.Enabled == false)
                {
                    cmnd = "";
                    if (cbDanToc.Enabled == false)
                    {
                        danToc = "";
                        if (sc.addChungTu(maChungTu, tenNguoiKhai, thuongTamTru, qhVoiNguoiMat,
                                          tenNguoiMat, ngaySinhNguoiMat, danToc, quocTich, cmnd,
                                          ngayQuaDoi, thoiGianQuaDoi, khuVucDangKy, ngayDangKy))
                        {
                            MessageBox.Show(sc.SUCCESS_ADD);
                            this.Close();
                        }
                    }
                    else
                    {
                        if (!danToc.Equals(""))
                        {
                            if (sc.addChungTu(maChungTu, tenNguoiKhai, thuongTamTru, qhVoiNguoiMat,
                                              tenNguoiMat, ngaySinhNguoiMat, danToc, quocTich, cmnd,
                                              ngayQuaDoi, thoiGianQuaDoi, khuVucDangKy, ngayDangKy))
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
                    if (cbDanToc.Enabled == false)
                    {
                        danToc = "";
                        if (!cmnd.Equals(""))
                        {
                            if (sc.addChungTu(maChungTu, tenNguoiKhai, thuongTamTru, qhVoiNguoiMat,
                                              tenNguoiMat, ngaySinhNguoiMat, danToc, quocTich, cmnd,
                                              ngayQuaDoi, thoiGianQuaDoi, khuVucDangKy, ngayDangKy))
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
                        if (!(cmnd.Equals("") || danToc.Equals("")))
                        {
                            if (sc.addChungTu(maChungTu, tenNguoiKhai, thuongTamTru, qhVoiNguoiMat,
                                              tenNguoiMat, ngaySinhNguoiMat, danToc, quocTich, cmnd,
                                              ngayQuaDoi, thoiGianQuaDoi, khuVucDangKy, ngayDangKy))
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
            }
            else
            {
                MessageBox.Show(sc.ERROR_BLANK);
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
        private void detectNamDangKyVaNamMat(int n)
        {
            if (!(cbNamDangKy.Text.Equals("") || cbNamMat.Text.Equals("")))
            {
                int namDangKy = Int32.Parse(cbNamDangKy.Text);
                int namMat = Int32.Parse(cbNamMat.Text);
                if (namDangKy == namMat)
                {
                    if (!(cbThangDangKy.Text.Equals("") || cbThangMat.Text.Equals("")))
                    {
                        int thangDangKy = Int32.Parse(cbThangDangKy.Text);
                        int thangMat = Int32.Parse(cbThangMat.Text);
                        if (thangDangKy == thangMat)
                        {
                            if (!(cbNgayDangKy.Text.Equals("") || cbNgayMat.Text.Equals("")))
                            {
                                int ngayDangKy = Int32.Parse(cbNgayDangKy.Text);
                                int ngayMat = Int32.Parse(cbNgayMat.Text);
                                if (ngayDangKy < ngayMat)
                                {
                                    MessageBox.Show("Không hợp lệ!");
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
                        }
                        else if (thangDangKy < thangMat)
                        {
                            MessageBox.Show("Không hợp lệ!");
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
                }
                else if (namDangKy < namMat)
                {
                    MessageBox.Show("Không hợp lệ!");
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
        }

        private void detectNamDangKyVaNamSinh(int n)
        {
            if (!(cbNamDangKy.Text.Equals("") || cbNamSinh.Text.Equals("")))
            {
                int namDangKy = Int32.Parse(cbNamDangKy.Text);
                int namSinh = Int32.Parse(cbNamSinh.Text);
                if (namDangKy == namSinh)
                {
                    if (!(cbThangDangKy.Text.Equals("") || cbThangSinh.Text.Equals("")))
                    {
                        int thangDangKy = Int32.Parse(cbThangDangKy.Text);
                        int thangSinh = Int32.Parse(cbThangSinh.Text);
                        if (thangDangKy == thangSinh)
                        {
                            if (!(cbNgayDangKy.Text.Equals("") || cbNgaySinh.Text.Equals("")))
                            {
                                int ngayDangKy = Int32.Parse(cbNgayDangKy.Text);
                                int ngaySinh = Int32.Parse(cbNgaySinh.Text);
                                if (ngayDangKy < ngaySinh)
                                {
                                    MessageBox.Show("Không hợp lệ!");
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
                        }
                        else if (thangDangKy < thangSinh)
                        {
                            MessageBox.Show("Không hợp lệ!");
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
                }
                else if (namDangKy < namSinh)
                {
                    MessageBox.Show("Không hợp lệ!");
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
        }

        private void detectNamMatVaNamSinh(int n)
        {
            if (!(cbNamSinh.Text.Equals("") || cbNamMat.Text.Equals("")))
            {
                int namMat = Int32.Parse(cbNamMat.Text);
                int namSinh = Int32.Parse(cbNamSinh.Text);
                if (namMat == namSinh)
                {
                    if (!(cbThangMat.Text.Equals("") || cbThangSinh.Text.Equals("")))
                    {
                        int thangMat = Int32.Parse(cbThangMat.Text);
                        int thangSinh = Int32.Parse(cbThangSinh.Text);
                        if (thangMat == thangSinh)
                        {
                            if (!(cbNgayMat.Text.Equals("") || cbNgaySinh.Text.Equals("")))
                            {
                                int ngayMat = Int32.Parse(cbNgayMat.Text);
                                int ngaySinh = Int32.Parse(cbNgaySinh.Text);
                                if (ngayMat < ngaySinh)
                                {
                                    MessageBox.Show("Không hợp lệ!");
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
                        }
                        else if (thangMat < thangSinh)
                        {
                            MessageBox.Show("Không hợp lệ!");
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
                }
                else if (namMat < namSinh)
                {
                    MessageBox.Show("Không hợp lệ!");
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
        }

        private void cbNamDangKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            detectNamDangKyVaNamSinh(1);
            detectNamDangKyVaNamMat(1);
        }

        private void cbThangDangKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            detectNamDangKyVaNamSinh(2);
            detectNamDangKyVaNamMat(2);
        }

        private void cbNgayDangKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            detectNamDangKyVaNamSinh(3);
            detectNamDangKyVaNamMat(3);
        }

        private void cbNgaySinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            detectNamDangKyVaNamSinh(6);
            detectNamMatVaNamSinh(6);
        }

        private void cbThangSinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            detectNamDangKyVaNamSinh(5);
            detectNamMatVaNamSinh(5);
        }

        private void cbNamSinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            detectNamDangKyVaNamSinh(4);
            detectNamMatVaNamSinh(4);
            switch (cbNamSinh.Text)
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

        private void cbNgayMat_SelectedIndexChanged(object sender, EventArgs e)
        {
            detectNamDangKyVaNamMat(6);
            detectNamMatVaNamSinh(3);
        }

        private void cbThangMat_SelectedIndexChanged(object sender, EventArgs e)
        {
            detectNamDangKyVaNamMat(5);
            detectNamMatVaNamSinh(2);
        }

        private void cbNamMat_SelectedIndexChanged(object sender, EventArgs e)
        {
            detectNamDangKyVaNamMat(4);
            detectNamMatVaNamSinh(1);
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
