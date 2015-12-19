using System;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace QLNK
{
    public partial class SuaHoKhau : MaterialForm
    {
        SourceCode sc = new SourceCode();
        private string[] itemHoKhau;
        private bool flagSave = false;
        public SuaHoKhau(String[] itemHoKhau)
        {
            InitializeComponent();
            this.itemHoKhau = itemHoKhau;
            setNormal(itemHoKhau);
        }

        private void setNormal(string[] items)
        {
            txtHoTenChuHo.Text = items[1];
            txtCMNDChuHo.Text = items[2];
            switch (items[3])
            {
                case "An Giang": cbQueQuan.SelectedIndex = 0; break;
                case "Bà Rịa - Vũng Tàu": cbQueQuan.SelectedIndex = 1; break;
                case "Bạc Liêu": cbQueQuan.SelectedIndex = 2; break;
                case "Bắc Kạn": cbQueQuan.SelectedIndex = 3; break;
                case "Bắc Giang": cbQueQuan.SelectedIndex = 4; break;
                case "Bắc Ninh": cbQueQuan.SelectedIndex = 5; break;
                case "Bến Tre": cbQueQuan.SelectedIndex = 6; break;
                case "Bình Dương": cbQueQuan.SelectedIndex = 7; break;
                case "Bình Định": cbQueQuan.SelectedIndex = 8; break;
                case "Bình Phước": cbQueQuan.SelectedIndex = 9; break;
                case "Bình Thuận": cbQueQuan.SelectedIndex = 10; break;
                case "Cà Mau": cbQueQuan.SelectedIndex = 11; break;
                case "Cao Bằng": cbQueQuan.SelectedIndex = 12; break;
                case "Cần Thơ": cbQueQuan.SelectedIndex = 13; break;
                case "Đà Nẵng": cbQueQuan.SelectedIndex = 14; break;
                case "Đắk Lắk": cbQueQuan.SelectedIndex = 15; break;
                case "Đắk Nông": cbQueQuan.SelectedIndex = 16; break;
                case "Đồng Nai": cbQueQuan.SelectedIndex = 17; break;
                case "Đồng Tháp": cbQueQuan.SelectedIndex = 18; break;
                case "Điện Biên": cbQueQuan.SelectedIndex = 19; break;
                case "Gia Lai": cbQueQuan.SelectedIndex = 20; break;
                case "Hà Giang": cbQueQuan.SelectedIndex = 21; break;
                case "Hà Nam": cbQueQuan.SelectedIndex = 22; break;
                case "Hà Nội": cbQueQuan.SelectedIndex = 23; break;
                case "Hà Tĩnh": cbQueQuan.SelectedIndex = 24; break;
                case "Hải Dương": cbQueQuan.SelectedIndex = 25; break;
                case "Hải Phòng": cbQueQuan.SelectedIndex = 26; break;
                case "Hòa Bình": cbQueQuan.SelectedIndex = 27; break;
                case "Hậu Giang": cbQueQuan.SelectedIndex = 28; break;
                case "Hưng Yên": cbQueQuan.SelectedIndex = 29; break;
                case "TPHCM": cbQueQuan.SelectedIndex = 30; break;
                case "Khánh Hòa": cbQueQuan.SelectedIndex = 31; break;
                case "Kiên Giang": cbQueQuan.SelectedIndex = 32; break;
                case "Kon Tum": cbQueQuan.SelectedIndex = 33; break;
                case "Lai Châu": cbQueQuan.SelectedIndex = 34; break;
                case "Lào Cai": cbQueQuan.SelectedIndex = 35; break;
                case "Lạng Sơn": cbQueQuan.SelectedIndex = 36; break;
                case "Lâm Đồng": cbQueQuan.SelectedIndex = 37; break;
                case "Long An": cbQueQuan.SelectedIndex = 38; break;
                case "Nam Định": cbQueQuan.SelectedIndex = 39; break;
                case "Nghệ An": cbQueQuan.SelectedIndex = 40; break;
                case "Ninh Bình": cbQueQuan.SelectedIndex = 41; break;
                case "Ninh Thuận": cbQueQuan.SelectedIndex = 42; break;
                case "Phú Thọ": cbQueQuan.SelectedIndex = 43; break;
                case "Phú Yên": cbQueQuan.SelectedIndex = 44; break;
                case "Quảng Bình": cbQueQuan.SelectedIndex = 45; break;
                case "Quảng Nam": cbQueQuan.SelectedIndex = 46; break;
                case "Quảng Ngãi": cbQueQuan.SelectedIndex = 47; break;
                case "Quảng Ninh": cbQueQuan.SelectedIndex = 48; break;
                case "Quảng Trị": cbQueQuan.SelectedIndex = 49; break;
                case "Sóc Trăng": cbQueQuan.SelectedIndex = 50; break;
                case "Sơn La": cbQueQuan.SelectedIndex = 51; break;
                case "Tây Ninh": cbQueQuan.SelectedIndex = 52; break;
                case "Thái Bình": cbQueQuan.SelectedIndex = 53; break;
                case "Thái Nguyên": cbQueQuan.SelectedIndex = 54; break;
                case "Thanh Hóa": cbQueQuan.SelectedIndex = 55; break;
                case "Thừa Thiên Huế": cbQueQuan.SelectedIndex = 56; break;
                case "Tiền Giang": cbQueQuan.SelectedIndex = 57; break;
                case "Trà Vinh": cbQueQuan.SelectedIndex = 58; break;
                case "Tuyên Quang": cbQueQuan.SelectedIndex = 59; break;
                case "Vĩnh Long": cbQueQuan.SelectedIndex = 60; break;
                case "Vĩnh Phúc": cbQueQuan.SelectedIndex = 61; break;
                case "Yên Bái": cbQueQuan.SelectedIndex = 62; break;
            }
            txtDiaChi.Text = items[4];
            string[] arr = items[5].Split('/');
            switch (arr[0])
            {
                case "01": cbNgay.SelectedIndex = 0; break;
                case "02": cbNgay.SelectedIndex = 1; break;
                case "03": cbNgay.SelectedIndex = 2; break;
                case "04": cbNgay.SelectedIndex = 3; break;
                case "05": cbNgay.SelectedIndex = 4; break;
                case "06": cbNgay.SelectedIndex = 5; break;
                case "07": cbNgay.SelectedIndex = 6; break;
                case "08": cbNgay.SelectedIndex = 7; break;
                case "09": cbNgay.SelectedIndex = 8; break;
                case "10": cbNgay.SelectedIndex = 9; break;
                case "11": cbNgay.SelectedIndex = 10; break;
                case "12": cbNgay.SelectedIndex = 11; break;
                case "13": cbNgay.SelectedIndex = 12; break;
                case "14": cbNgay.SelectedIndex = 13; break;
                case "15": cbNgay.SelectedIndex = 14; break;
                case "16": cbNgay.SelectedIndex = 15; break;
                case "17": cbNgay.SelectedIndex = 16; break;
                case "18": cbNgay.SelectedIndex = 17; break;
                case "19": cbNgay.SelectedIndex = 18; break;
                case "20": cbNgay.SelectedIndex = 19; break;
                case "21": cbNgay.SelectedIndex = 20; break;
                case "22": cbNgay.SelectedIndex = 21; break;
                case "23": cbNgay.SelectedIndex = 22; break;
                case "24": cbNgay.SelectedIndex = 23; break;
                case "25": cbNgay.SelectedIndex = 24; break;
                case "26": cbNgay.SelectedIndex = 25; break;
                case "27": cbNgay.SelectedIndex = 26; break;
                case "28": cbNgay.SelectedIndex = 27; break;
                case "29": cbNgay.SelectedIndex = 28; break;
                case "30": cbNgay.SelectedIndex = 29; break;
                case "31": cbNgay.SelectedIndex = 30; break;
            }
            switch (arr[1])
            {
                case "01": cbThang.SelectedIndex = 0; break;
                case "02": cbThang.SelectedIndex = 1; break;
                case "03": cbThang.SelectedIndex = 2; break;
                case "04": cbThang.SelectedIndex = 3; break;
                case "05": cbThang.SelectedIndex = 4; break;
                case "06": cbThang.SelectedIndex = 5; break;
                case "07": cbThang.SelectedIndex = 6; break;
                case "08": cbThang.SelectedIndex = 7; break;
                case "09": cbThang.SelectedIndex = 8; break;
                case "10": cbThang.SelectedIndex = 9; break;
                case "11": cbThang.SelectedIndex = 10; break;
                case "12": cbThang.SelectedIndex = 11; break;
            }
            switch (arr[2])
            {
                case "1960": cbNam.SelectedIndex = 0; break;
                case "1961": cbNam.SelectedIndex = 1; break;
                case "1962": cbNam.SelectedIndex = 2; break;
                case "1963": cbNam.SelectedIndex = 3; break;
                case "1964": cbNam.SelectedIndex = 4; break;
                case "1965": cbNam.SelectedIndex = 5; break;
                case "1966": cbNam.SelectedIndex = 6; break;
                case "1967": cbNam.SelectedIndex = 7; break;
                case "1968": cbNam.SelectedIndex = 8; break;
                case "1969": cbNam.SelectedIndex = 9; break;
                case "1970": cbNam.SelectedIndex = 10; break;
                case "1971": cbNam.SelectedIndex = 11; break;
                case "1972": cbNam.SelectedIndex = 12; break;
                case "1973": cbNam.SelectedIndex = 13; break;
                case "1974": cbNam.SelectedIndex = 14; break;
                case "1975": cbNam.SelectedIndex = 15; break;
                case "1976": cbNam.SelectedIndex = 16; break;
                case "1977": cbNam.SelectedIndex = 17; break;
                case "1978": cbNam.SelectedIndex = 18; break;
                case "1979": cbNam.SelectedIndex = 19; break;
                case "1980": cbNam.SelectedIndex = 20; break;
                case "1981": cbNam.SelectedIndex = 21; break;
                case "1982": cbNam.SelectedIndex = 22; break;
                case "1983": cbNam.SelectedIndex = 23; break;
                case "1984": cbNam.SelectedIndex = 24; break;
                case "1985": cbNam.SelectedIndex = 25; break;
                case "1986": cbNam.SelectedIndex = 26; break;
                case "1987": cbNam.SelectedIndex = 27; break;
                case "1988": cbNam.SelectedIndex = 28; break;
                case "1989": cbNam.SelectedIndex = 29; break;
                case "1990": cbNam.SelectedIndex = 30; break;
                case "1991": cbNam.SelectedIndex = 31; break;
                case "1992": cbNam.SelectedIndex = 32; break;
                case "1993": cbNam.SelectedIndex = 33; break;
                case "1994": cbNam.SelectedIndex = 34; break;
                case "1995": cbNam.SelectedIndex = 35; break;
                case "1996": cbNam.SelectedIndex = 36; break;
                case "1997": cbNam.SelectedIndex = 37; break;
                case "1998": cbNam.SelectedIndex = 38; break;
                case "1999": cbNam.SelectedIndex = 39; break;
                case "2000": cbNam.SelectedIndex = 40; break;
                case "2001": cbNam.SelectedIndex = 41; break;
                case "2002": cbNam.SelectedIndex = 42; break;
                case "2003": cbNam.SelectedIndex = 43; break;
                case "2004": cbNam.SelectedIndex = 44; break;
                case "2005": cbNam.SelectedIndex = 45; break;
                case "2006": cbNam.SelectedIndex = 46; break;
                case "2007": cbNam.SelectedIndex = 47; break;
                case "2008": cbNam.SelectedIndex = 48; break;
                case "2009": cbNam.SelectedIndex = 49; break;
                case "2010": cbNam.SelectedIndex = 50; break;
                case "2011": cbNam.SelectedIndex = 51; break;
                case "2012": cbNam.SelectedIndex = 52; break;
                case "2013": cbNam.SelectedIndex = 53; break;
                case "2014": cbNam.SelectedIndex = 54; break;
                case "2015": cbNam.SelectedIndex = 55; break;
            }
        }

        private void btnSuaHoKhau_Click(object sender, EventArgs e)
        {
            string maHoKhau = itemHoKhau[0];
            string tenChuHo = txtHoTenChuHo.Text;
            string cmndChuHo = txtCMNDChuHo.Text;
            string khuVuc = cbQueQuan.Text;
            string diaChi = txtDiaChi.Text;
            string ngayLap = cbNgay.Text + "/" + cbThang.Text + "/" + cbNam.Text;
            string ngay = cbThang.Text;
            string thang = cbNgay.Text;
            string nam = cbNam.Text;

            if (!(maHoKhau.Equals("")   || tenChuHo.Equals("")  || cmndChuHo.Equals("") ||
                  ngay.Equals("")       || thang.Equals("")     || nam.Equals("")       ||
                  diaChi.Equals("")     || khuVuc.Equals("")))
            {
                DialogResult dialogResult = MessageBox.Show(sc.MSGBOX_UPDATE, sc.MSGBOX_CAP_UPDATE, MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    flagSave = true;
                    if (sc.updateHoKhau(maHoKhau, tenChuHo, cmndChuHo, khuVuc, diaChi, ngayLap))
                    {
                        this.Close();
                        MessageBox.Show(sc.SUCCESS_UPDATE);
                    }
                }
            }
            else
            {
                MessageBox.Show(sc.ERROR_BLANK);
            }
        }

        private void SuaHoKhau_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flagSave == false)
            {
                string ngay = cbThang.Text;
                string thang = cbNgay.Text;
                string nam = cbNam.Text;
                string maHoKhau = itemHoKhau[0];
                string tenChuHo = txtHoTenChuHo.Text;
                string cmndChuHo = txtCMNDChuHo.Text;
                string khuVuc = cbQueQuan.Text;
                string diaChi = txtDiaChi.Text;
                string ngayLap = ngay + "/" + thang + "/" + nam;

                if ((!maHoKhau.Equals(itemHoKhau[0]) || !tenChuHo.Equals(itemHoKhau[1]) ||
                    !cmndChuHo.Equals(itemHoKhau[2]) || !khuVuc.Equals(itemHoKhau[3])   ||
                    !diaChi.Equals(itemHoKhau[4])    || !ngayLap.Equals(itemHoKhau[5])))
                {
                    DialogResult dialogResult = MessageBox.Show(sc.MSGBOX_UPDATE,
                                                                sc.MSGBOX_CAP_EXIT,
                                                                MessageBoxButtons.YesNoCancel);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (!(maHoKhau.Equals("")   || tenChuHo.Equals("")  || cmndChuHo.Equals("") ||
                              ngay.Equals("")       || thang.Equals("")     || nam.Equals("")       ||
                              diaChi.Equals("")     || khuVuc.Equals("")))
                        {
                            if (sc.updateHoKhau(maHoKhau, tenChuHo, cmndChuHo, khuVuc, diaChi, ngayLap))
                            {
                                MessageBox.Show(sc.SUCCESS_UPDATE);
                            }
                        }
                        else
                        {
                            MessageBox.Show(sc.ERROR_BLANK);
                            e.Cancel = true;
                        }
                    }
                    else if (dialogResult == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                }
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

        private void txtHoTenChuHo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtCMNDChuHo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtHoTenChuHo_TextChanged(object sender, EventArgs e)
        {
            if (txtHoTenChuHo.Text != itemHoKhau[1])
            {
                label1.Visible = true;
            }
            else
            {
                label1.Visible = false;
            }
        }

        private void txtCMNDChuHo_TextChanged(object sender, EventArgs e)
        {
            if (txtCMNDChuHo.Text != itemHoKhau[2])
            {
                label2.Visible = true;
            }
            else
            {
                label2.Visible = false;
            }
        }

        private void cbQueQuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbQueQuan.Text != itemHoKhau[3])
            {
                label3.Visible = true;
            }
            else
            {
                label3.Visible = false;
            }
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            if (txtDiaChi.Text != itemHoKhau[4])
            {
                label4.Visible = true;
            }
            else
            {
                label4.Visible = false;
            }
        }

        private void cbNgay_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] str = itemHoKhau[5].Split('/');
            if (cbNgay.Text != str[0])
            {
                label5.Visible = true;
            }
            else
            {
                label5.Visible = false;
            }
        }

        private void cbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] str = itemHoKhau[5].Split('/');
            if (cbThang.Text != str[1])
            {
                label5.Visible = true;
            }
            else
            {
                label5.Visible = false;
            }
        }

        private void cbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] str = itemHoKhau[5].Split('/');
            if (cbNam.Text != str[2])
            {
                label5.Visible = true;
            }
            else
            {
                label5.Visible = false;
            }
        }
    }
}
