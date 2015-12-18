using System;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace QLNK
{
    public partial class SuaNhanKhau : MaterialForm
    {
        SourceCode sc = new SourceCode();
        private string[] itemNhanKhau;
        private bool flagSave = false;
        public SuaNhanKhau(string[] itemNhanKhau)
        {
            InitializeComponent();
            this.itemNhanKhau = itemNhanKhau;
            setNormal(itemNhanKhau);
        }

        private void setNormal(string[] items)
        {
            txtMaNhanKhau.Text = items[0];
            txtHoTen.Text = items[1];
            string[] arr = items[2].Split('/');
            switch (arr[0])
            {
                case "1": cbNgay.SelectedIndex = 0; break;
                case "2": cbNgay.SelectedIndex = 1; break;
                case "3": cbNgay.SelectedIndex = 2; break;
                case "4": cbNgay.SelectedIndex = 3; break;
                case "5": cbNgay.SelectedIndex = 4; break;
                case "6": cbNgay.SelectedIndex = 5; break;
                case "7": cbNgay.SelectedIndex = 6; break;
                case "8": cbNgay.SelectedIndex = 7; break;
                case "9": cbNgay.SelectedIndex = 8; break;
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
                case "1": cbThang.SelectedIndex = 0; break;
                case "2": cbThang.SelectedIndex = 1; break;
                case "3": cbThang.SelectedIndex = 2; break;
                case "4": cbThang.SelectedIndex = 3; break;
                case "5": cbThang.SelectedIndex = 4; break;
                case "6": cbThang.SelectedIndex = 5; break;
                case "7": cbThang.SelectedIndex = 6; break;
                case "8": cbThang.SelectedIndex = 7; break;
                case "9": cbThang.SelectedIndex = 8; break;
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
            }
            switch (items[4])
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
            switch (items[5])
            {
                case "Phật giáo": cbTonGiao.SelectedIndex = 0; break;
                case "Công giáo": cbTonGiao.SelectedIndex = 1; break;
                case "Tin Lành": cbTonGiao.SelectedIndex = 2; break;
                case "Cao Đài": cbTonGiao.SelectedIndex = 3; break;
                case "Hồi giáo": cbTonGiao.SelectedIndex = 4; break;
                case "Bahá í": cbTonGiao.SelectedIndex = 5; break;
                case "Minh Sư Đạo": cbTonGiao.SelectedIndex = 6; break;
                case "Minh Lý Đạo": cbTonGiao.SelectedIndex = 7; break;
            }
            switch (items[6])
            {
                case "Kinh": cbDanToc.SelectedIndex = 0; break;
                case "Tày": cbDanToc.SelectedIndex = 1; break;
                case "Thái": cbDanToc.SelectedIndex = 2; break;
                case "Mường": cbDanToc.SelectedIndex = 3; break;
                case "Khơ Me": cbDanToc.SelectedIndex = 4; break;
                case "H'Mông": cbDanToc.SelectedIndex = 5; break;
                case "Nùng": cbDanToc.SelectedIndex = 6; break;
                case "Hoa": cbDanToc.SelectedIndex = 7; break;
                case "Dao": cbDanToc.SelectedIndex = 8; break;
                case "Gia Rai": cbDanToc.SelectedIndex = 9; break;
                case "Ê Đê": cbDanToc.SelectedIndex = 10; break;
                case "Ba Na": cbDanToc.SelectedIndex = 11; break;
                case "Xơ Đăng": cbDanToc.SelectedIndex = 12; break;
                case "Sán Chay": cbDanToc.SelectedIndex = 13; break;
                case "Cơ Ho": cbDanToc.SelectedIndex = 14; break;
                case "Chăm": cbDanToc.SelectedIndex = 15; break;
                case "Sán Dìu": cbDanToc.SelectedIndex = 16; break;
                case "Hrê": cbDanToc.SelectedIndex = 17; break;
                case "Ra Glai": cbDanToc.SelectedIndex = 18; break;
                case "M'Nông": cbDanToc.SelectedIndex = 19; break;
                case "X’Tiêng": cbDanToc.SelectedIndex = 20; break;
                case "Bru-Vân Kiều": cbDanToc.SelectedIndex = 21; break;
                case "Thổ": cbDanToc.SelectedIndex = 22; break;
                case "Khơ Mú": cbDanToc.SelectedIndex = 23; break;
                case "Cơ Tu": cbDanToc.SelectedIndex = 24; break;
                case "Giáy": cbDanToc.SelectedIndex = 25; break;
                case "Giẻ Triêng": cbDanToc.SelectedIndex = 26; break;
                case "Tà Ôi": cbDanToc.SelectedIndex = 27; break;
                case "Mạ": cbDanToc.SelectedIndex = 28; break;
                case "Co": cbDanToc.SelectedIndex = 29; break;
                case "Chơ Ro": cbDanToc.SelectedIndex = 30; break;
                case "Xinh Mun": cbDanToc.SelectedIndex = 31; break;
                case "Hà Nhì": cbDanToc.SelectedIndex = 32; break;
                case "Chu Ru": cbDanToc.SelectedIndex = 33; break;
                case "Lào": cbDanToc.SelectedIndex = 34; break;
                case "Kháng": cbDanToc.SelectedIndex = 35; break;
                case "La Chí": cbDanToc.SelectedIndex = 36; break;
                case "Phú Lá": cbDanToc.SelectedIndex = 37; break;
                case "La Hủ": cbDanToc.SelectedIndex = 38; break;
                case "La Ha": cbDanToc.SelectedIndex = 39; break;
                case "Pà Thẻn": cbDanToc.SelectedIndex = 40; break;
                case "Chứt": cbDanToc.SelectedIndex = 41; break;
                case "Lự": cbDanToc.SelectedIndex = 42; break;
                case "Lô Lô": cbDanToc.SelectedIndex = 43; break;
                case "Mảng": cbDanToc.SelectedIndex = 44; break;
                case "Cờ Lao": cbDanToc.SelectedIndex = 45; break;
                case "Bố Y": cbDanToc.SelectedIndex = 46; break;
                case "Cống": cbDanToc.SelectedIndex = 47; break;
                case "Ngái": cbDanToc.SelectedIndex = 48; break;
                case "Si La": cbDanToc.SelectedIndex = 49; break;
                case "Pu Péo": cbDanToc.SelectedIndex = 50; break;
                case "Rơ măm": cbDanToc.SelectedIndex = 51; break;
                case "Brâu": cbDanToc.SelectedIndex = 52; break;
                case "Ơ Đu": cbDanToc.SelectedIndex = 53; break;
                case "Thành phần khác": cbDanToc.SelectedIndex = 54; break;
            }
            txtCMND.Text = items[7];
            txtMaHoKhau.Text = items[8];
            txtNgheNghiep.Text = items[9];
            switch (items[3])
            {
                case "Nam": rdNam.Checked = true; break;
                case "Nữ": rdNu.Checked = true; break;
            }
        }

        private void btnSuaNhanKhau_Click(object sender, EventArgs e)
        {
            string maNhanKhau = txtMaNhanKhau.Text;
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

            if (!(maNhanKhau.Equals("") || hoTen.Equals("") || (!rdNam.Checked && !rdNu.Checked) ||
                  ngay.Equals("") || thang.Equals("") || nam.Equals("") || danToc.Equals("") ||
                  queQuan.Equals("") || tonGiao.Equals("") || cmnd.Equals("") ||
                  maHoKhau.Equals("") || ngheNghiep.Equals("")))
            {
                DialogResult dialogResult = MessageBox.Show("Có chắc muốn cập nhập thông tin không", "Xác nhận sửa thông tin", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    flagSave = true;
                    if (sc.updateNhanKhau(maNhanKhau, hoTen, ngaySinh, gioiTinh, queQuan,
                                          tonGiao, danToc, cmnd, maHoKhau, ngheNghiep))
                    {
                        this.Close();
                        MessageBox.Show("Cập nhật thành công");
                    }
                }
            }
            else
            {
                MessageBox.Show("Điền đầy đủ rồi hẵng cập nhật");
            }
        }

        private void SuaNhanKhau_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flagSave == false)
            {
                string maNhanKhau = txtMaNhanKhau.Text;
                string hoTen = txtHoTen.Text;
                string ngaySinh = cbNgay.Text + "/" + cbThang.Text + "/" + cbNam.Text;
                string gioiTinh = (rdNam.Checked && !rdNu.Checked) ? "Nam" : "Nữ";
                string danToc = cbDanToc.Text;
                string queQuan = cbQueQuan.Text;
                string tonGiao = cbTonGiao.Text;
                string cmnd = txtCMND.Text;
                string maHoKhau = txtMaHoKhau.Text;
                string ngheNghiep = txtNgheNghiep.Text;

                if ((!maNhanKhau.Equals(itemNhanKhau[0]) || !hoTen.Equals(itemNhanKhau[1]) ||
                     !ngaySinh.Equals(itemNhanKhau[2]) || !gioiTinh.Equals(itemNhanKhau[3]) ||
                     !queQuan.Equals(itemNhanKhau[4]) || !tonGiao.Equals(itemNhanKhau[5]) ||
                     !danToc.Equals(itemNhanKhau[6]) || !cmnd.Equals(itemNhanKhau[7]) ||
                     !maHoKhau.Equals(itemNhanKhau[8]) || !ngheNghiep.Equals(itemNhanKhau[9])))
                {
                    DialogResult dialogResult = MessageBox.Show("Có muốn lưu thông tin đã sửa ?",
                                                                "Xác nhận thoát", MessageBoxButtons.YesNoCancel);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (sc.updateNhanKhau(maNhanKhau, hoTen, ngaySinh, gioiTinh, queQuan,
                                              tonGiao, danToc, cmnd, maHoKhau, ngheNghiep))
                        {
                            MessageBox.Show("Cập nhật thành công");
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
    }
}
