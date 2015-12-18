using System;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace QLNK
{
    public partial class SuaKetHon : MaterialForm
    {
        SourceCode sc = new SourceCode();
        private string[] itemKetHon;
        private bool flagSave = false;
        public SuaKetHon(string[] itemKetHon)
        {
            InitializeComponent();
            this.itemKetHon = itemKetHon;
            setNormal(itemKetHon);
        }

        private void setNormal(string[] items)
        {
            txtMaKetHon.Text = items[0];
            txtHoTenChong.Text = items[1];
            string[] arr = items[2].Split('/');
            switch (arr[0])
            {
                case "1": cbNgaySinhChong.SelectedIndex = 0; break;
                case "2": cbNgaySinhChong.SelectedIndex = 1; break;
                case "3": cbNgaySinhChong.SelectedIndex = 2; break;
                case "4": cbNgaySinhChong.SelectedIndex = 3; break;
                case "5": cbNgaySinhChong.SelectedIndex = 4; break;
                case "6": cbNgaySinhChong.SelectedIndex = 5; break;
                case "7": cbNgaySinhChong.SelectedIndex = 6; break;
                case "8": cbNgaySinhChong.SelectedIndex = 7; break;
                case "9": cbNgaySinhChong.SelectedIndex = 8; break;
                case "10": cbNgaySinhChong.SelectedIndex = 9; break;
                case "11": cbNgaySinhChong.SelectedIndex = 10; break;
                case "12": cbNgaySinhChong.SelectedIndex = 11; break;
                case "13": cbNgaySinhChong.SelectedIndex = 12; break;
                case "14": cbNgaySinhChong.SelectedIndex = 13; break;
                case "15": cbNgaySinhChong.SelectedIndex = 14; break;
                case "16": cbNgaySinhChong.SelectedIndex = 15; break;
                case "17": cbNgaySinhChong.SelectedIndex = 16; break;
                case "18": cbNgaySinhChong.SelectedIndex = 17; break;
                case "19": cbNgaySinhChong.SelectedIndex = 18; break;
                case "20": cbNgaySinhChong.SelectedIndex = 19; break;
                case "21": cbNgaySinhChong.SelectedIndex = 20; break;
                case "22": cbNgaySinhChong.SelectedIndex = 21; break;
                case "23": cbNgaySinhChong.SelectedIndex = 22; break;
                case "24": cbNgaySinhChong.SelectedIndex = 23; break;
                case "25": cbNgaySinhChong.SelectedIndex = 24; break;
                case "26": cbNgaySinhChong.SelectedIndex = 25; break;
                case "27": cbNgaySinhChong.SelectedIndex = 26; break;
                case "28": cbNgaySinhChong.SelectedIndex = 27; break;
                case "29": cbNgaySinhChong.SelectedIndex = 28; break;
                case "30": cbNgaySinhChong.SelectedIndex = 29; break;
                case "31": cbNgaySinhChong.SelectedIndex = 30; break;
            }
            switch (arr[1])
            {
                case "1": cbThangSinhChong.SelectedIndex = 0; break;
                case "2": cbThangSinhChong.SelectedIndex = 1; break;
                case "3": cbThangSinhChong.SelectedIndex = 2; break;
                case "4": cbThangSinhChong.SelectedIndex = 3; break;
                case "5": cbThangSinhChong.SelectedIndex = 4; break;
                case "6": cbThangSinhChong.SelectedIndex = 5; break;
                case "7": cbThangSinhChong.SelectedIndex = 6; break;
                case "8": cbThangSinhChong.SelectedIndex = 7; break;
                case "9": cbThangSinhChong.SelectedIndex = 8; break;
                case "10": cbThangSinhChong.SelectedIndex = 9; break;
                case "11": cbThangSinhChong.SelectedIndex = 10; break;
                case "12": cbThangSinhChong.SelectedIndex = 11; break;
            }
            switch (arr[2])
            {
                case "1960": cbNamSinhChong.SelectedIndex = 0; break;
                case "1961": cbNamSinhChong.SelectedIndex = 1; break;
                case "1962": cbNamSinhChong.SelectedIndex = 2; break;
                case "1963": cbNamSinhChong.SelectedIndex = 3; break;
                case "1964": cbNamSinhChong.SelectedIndex = 4; break;
                case "1965": cbNamSinhChong.SelectedIndex = 5; break;
                case "1966": cbNamSinhChong.SelectedIndex = 6; break;
                case "1967": cbNamSinhChong.SelectedIndex = 7; break;
                case "1968": cbNamSinhChong.SelectedIndex = 8; break;
                case "1969": cbNamSinhChong.SelectedIndex = 9; break;
                case "1970": cbNamSinhChong.SelectedIndex = 10; break;
                case "1971": cbNamSinhChong.SelectedIndex = 11; break;
                case "1972": cbNamSinhChong.SelectedIndex = 12; break;
                case "1973": cbNamSinhChong.SelectedIndex = 13; break;
                case "1974": cbNamSinhChong.SelectedIndex = 14; break;
                case "1975": cbNamSinhChong.SelectedIndex = 15; break;
                case "1976": cbNamSinhChong.SelectedIndex = 16; break;
                case "1977": cbNamSinhChong.SelectedIndex = 17; break;
                case "1978": cbNamSinhChong.SelectedIndex = 18; break;
                case "1979": cbNamSinhChong.SelectedIndex = 19; break;
                case "1980": cbNamSinhChong.SelectedIndex = 20; break;
                case "1981": cbNamSinhChong.SelectedIndex = 21; break;
                case "1982": cbNamSinhChong.SelectedIndex = 22; break;
                case "1983": cbNamSinhChong.SelectedIndex = 23; break;
                case "1984": cbNamSinhChong.SelectedIndex = 24; break;
                case "1985": cbNamSinhChong.SelectedIndex = 25; break;
                case "1986": cbNamSinhChong.SelectedIndex = 26; break;
                case "1987": cbNamSinhChong.SelectedIndex = 27; break;
                case "1988": cbNamSinhChong.SelectedIndex = 28; break;
                case "1989": cbNamSinhChong.SelectedIndex = 29; break;
                case "1990": cbNamSinhChong.SelectedIndex = 30; break;
                case "1991": cbNamSinhChong.SelectedIndex = 31; break;
                case "1992": cbNamSinhChong.SelectedIndex = 32; break;
                case "1993": cbNamSinhChong.SelectedIndex = 33; break;
                case "1994": cbNamSinhChong.SelectedIndex = 34; break;
                case "1995": cbNamSinhChong.SelectedIndex = 35; break;
                case "1996": cbNamSinhChong.SelectedIndex = 36; break;
                case "1997": cbNamSinhChong.SelectedIndex = 37; break;
                case "1998": cbNamSinhChong.SelectedIndex = 38; break;
                case "1999": cbNamSinhChong.SelectedIndex = 39; break;
                case "2000": cbNamSinhChong.SelectedIndex = 40; break;
            }
            switch (items[3])
            {
                case "Kinh": cbDanTocChong.SelectedIndex = 0; break;
                case "Tày": cbDanTocChong.SelectedIndex = 1; break;
                case "Thái": cbDanTocChong.SelectedIndex = 2; break;
                case "Mường": cbDanTocChong.SelectedIndex = 3; break;
                case "Khơ Me": cbDanTocChong.SelectedIndex = 4; break;
                case "H'Mông": cbDanTocChong.SelectedIndex = 5; break;
                case "Nùng": cbDanTocChong.SelectedIndex = 6; break;
                case "Hoa": cbDanTocChong.SelectedIndex = 7; break;
                case "Dao": cbDanTocChong.SelectedIndex = 8; break;
                case "Gia Rai": cbDanTocChong.SelectedIndex = 9; break;
                case "Ê Đê": cbDanTocChong.SelectedIndex = 10; break;
                case "Ba Na": cbDanTocChong.SelectedIndex = 11; break;
                case "Xơ Đăng": cbDanTocChong.SelectedIndex = 12; break;
                case "Sán Chay": cbDanTocChong.SelectedIndex = 13; break;
                case "Cơ Ho": cbDanTocChong.SelectedIndex = 14; break;
                case "Chăm": cbDanTocChong.SelectedIndex = 15; break;
                case "Sán Dìu": cbDanTocChong.SelectedIndex = 16; break;
                case "Hrê": cbDanTocChong.SelectedIndex = 17; break;
                case "Ra Glai": cbDanTocChong.SelectedIndex = 18; break;
                case "M'Nông": cbDanTocChong.SelectedIndex = 19; break;
                case "X’Tiêng": cbDanTocChong.SelectedIndex = 20; break;
                case "Bru-Vân Kiều": cbDanTocChong.SelectedIndex = 21; break;
                case "Thổ": cbDanTocChong.SelectedIndex = 22; break;
                case "Khơ Mú": cbDanTocChong.SelectedIndex = 23; break;
                case "Cơ Tu": cbDanTocChong.SelectedIndex = 24; break;
                case "Giáy": cbDanTocChong.SelectedIndex = 25; break;
                case "Giẻ Triêng": cbDanTocChong.SelectedIndex = 26; break;
                case "Tà Ôi": cbDanTocChong.SelectedIndex = 27; break;
                case "Mạ": cbDanTocChong.SelectedIndex = 28; break;
                case "Co": cbDanTocChong.SelectedIndex = 29; break;
                case "Chơ Ro": cbDanTocChong.SelectedIndex = 30; break;
                case "Xinh Mun": cbDanTocChong.SelectedIndex = 31; break;
                case "Hà Nhì": cbDanTocChong.SelectedIndex = 32; break;
                case "Chu Ru": cbDanTocChong.SelectedIndex = 33; break;
                case "Lào": cbDanTocChong.SelectedIndex = 34; break;
                case "Kháng": cbDanTocChong.SelectedIndex = 35; break;
                case "La Chí": cbDanTocChong.SelectedIndex = 36; break;
                case "Phú Lá": cbDanTocChong.SelectedIndex = 37; break;
                case "La Hủ": cbDanTocChong.SelectedIndex = 38; break;
                case "La Ha": cbDanTocChong.SelectedIndex = 39; break;
                case "Pà Thẻn": cbDanTocChong.SelectedIndex = 40; break;
                case "Chứt": cbDanTocChong.SelectedIndex = 41; break;
                case "Lự": cbDanTocChong.SelectedIndex = 42; break;
                case "Lô Lô": cbDanTocChong.SelectedIndex = 43; break;
                case "Mảng": cbDanTocChong.SelectedIndex = 44; break;
                case "Cờ Lao": cbDanTocChong.SelectedIndex = 45; break;
                case "Bố Y": cbDanTocChong.SelectedIndex = 46; break;
                case "Cống": cbDanTocChong.SelectedIndex = 47; break;
                case "Ngái": cbDanTocChong.SelectedIndex = 48; break;
                case "Si La": cbDanTocChong.SelectedIndex = 49; break;
                case "Pu Péo": cbDanTocChong.SelectedIndex = 50; break;
                case "Rơ măm": cbDanTocChong.SelectedIndex = 51; break;
                case "Brâu": cbDanTocChong.SelectedIndex = 52; break;
                case "Ơ Đu": cbDanTocChong.SelectedIndex = 53; break;
                case "Thành phần khác": cbDanTocChong.SelectedIndex = 54; break;
            }
            switch (items[4])
            {
                case "Afghanistan": cbQuocTichChong.SelectedIndex = 0; break;
                case "Akrotiri và Dhekelia": cbQuocTichChong.SelectedIndex = 1; break;
                case "Ả Rập Saudi": cbQuocTichChong.SelectedIndex = 2; break;
                case "Armenia": cbQuocTichChong.SelectedIndex = 3; break;
                case "Azerbaijan": cbQuocTichChong.SelectedIndex = 4; break;
                case "Ấn Độ": cbQuocTichChong.SelectedIndex = 5; break;
                case "Bahrain": cbQuocTichChong.SelectedIndex = 6; break;
                case "Bangladesh": cbQuocTichChong.SelectedIndex = 7; break;
                case "Bhutan": cbQuocTichChong.SelectedIndex = 8; break;
                case "Brunei": cbQuocTichChong.SelectedIndex = 9; break;
                case "Campuchia": cbQuocTichChong.SelectedIndex = 10; break;
                case "Đài Loan": cbQuocTichChong.SelectedIndex = 11; break;
                case "Georgia": cbQuocTichChong.SelectedIndex = 12; break;
                case "Hồng Kông": cbQuocTichChong.SelectedIndex = 13; break;
                case "Indonesia": cbQuocTichChong.SelectedIndex = 14; break;
                case "Iran": cbQuocTichChong.SelectedIndex = 15; break;
                case "Iraq": cbQuocTichChong.SelectedIndex = 16; break;
                case "Israel": cbQuocTichChong.SelectedIndex = 17; break;
                case "Jordan": cbQuocTichChong.SelectedIndex = 18; break;
                case "Kazakhstan": cbQuocTichChong.SelectedIndex = 19; break;
                case "Kuwait": cbQuocTichChong.SelectedIndex = 20; break;
                case "Kyrgyzstan": cbQuocTichChong.SelectedIndex = 21; break;
                case "Lào": cbQuocTichChong.SelectedIndex = 22; break;
                case "Liban": cbQuocTichChong.SelectedIndex = 23; break;
                case "Ma Cao": cbQuocTichChong.SelectedIndex = 24; break;
                case "Malaysia": cbQuocTichChong.SelectedIndex = 25; break;
                case "Kuala Lumpur": cbQuocTichChong.SelectedIndex = 26; break;
                case "Maldives": cbQuocTichChong.SelectedIndex = 27; break;
                case "Mông Cổ": cbQuocTichChong.SelectedIndex = 28; break;
                case "Myanma": cbQuocTichChong.SelectedIndex = 29; break;
                case "Nagorno-Karabakh": cbQuocTichChong.SelectedIndex = 30; break;
                case "Nepal": cbQuocTichChong.SelectedIndex = 31; break;
                case "Nga": cbQuocTichChong.SelectedIndex = 32; break;
                case "Nhật Bản": cbQuocTichChong.SelectedIndex = 33; break;
                case "Oman": cbQuocTichChong.SelectedIndex = 34; break;
                case "Pakistan": cbQuocTichChong.SelectedIndex = 35; break;
                case "Palestine": cbQuocTichChong.SelectedIndex = 36; break;
                case "Philippines": cbQuocTichChong.SelectedIndex = 37; break;
                case "Qatar": cbQuocTichChong.SelectedIndex = 38; break;
                case "Singapore": cbQuocTichChong.SelectedIndex = 39; break;
                case "Bắc Síp": cbQuocTichChong.SelectedIndex = 40; break;
                case "Síp": cbQuocTichChong.SelectedIndex = 41; break;
                case "Sri Lanka": cbQuocTichChong.SelectedIndex = 42; break;
                case "Syria": cbQuocTichChong.SelectedIndex = 43; break;
                case "Tajikistan": cbQuocTichChong.SelectedIndex = 44; break;
                case "Thái Lan": cbQuocTichChong.SelectedIndex = 45; break;
                case "Đông Timor": cbQuocTichChong.SelectedIndex = 46; break;
                case "Thổ Nhĩ Kỳ": cbQuocTichChong.SelectedIndex = 47; break;
                case "Triều Tiên": cbQuocTichChong.SelectedIndex = 48; break;
                case "Hàn Quốc": cbQuocTichChong.SelectedIndex = 49; break;
                case "Trung Quốc": cbQuocTichChong.SelectedIndex = 50; break;
                case "Turkmenistan": cbQuocTichChong.SelectedIndex = 51; break;
                case "Uzbekistan": cbQuocTichChong.SelectedIndex = 52; break;
                case "Việt Nam": cbQuocTichChong.SelectedIndex = 53; break;
                case "Yemen": cbQuocTichChong.SelectedIndex = 54; break;
            }
            txtThuongTamTruChong.Text = items[5];
            txtCMNDChong.Text = items[6];
            txtHoTenVo.Text = items[7];
            string[] arr2 = items[8].Split('/');
            switch (arr2[0])
            {
                case "1": cbNgaySinhVo.SelectedIndex = 0; break;
                case "2": cbNgaySinhVo.SelectedIndex = 1; break;
                case "3": cbNgaySinhVo.SelectedIndex = 2; break;
                case "4": cbNgaySinhVo.SelectedIndex = 3; break;
                case "5": cbNgaySinhVo.SelectedIndex = 4; break;
                case "6": cbNgaySinhVo.SelectedIndex = 5; break;
                case "7": cbNgaySinhVo.SelectedIndex = 6; break;
                case "8": cbNgaySinhVo.SelectedIndex = 7; break;
                case "9": cbNgaySinhVo.SelectedIndex = 8; break;
                case "10": cbNgaySinhVo.SelectedIndex = 9; break;
                case "11": cbNgaySinhVo.SelectedIndex = 10; break;
                case "12": cbNgaySinhVo.SelectedIndex = 11; break;
                case "13": cbNgaySinhVo.SelectedIndex = 12; break;
                case "14": cbNgaySinhVo.SelectedIndex = 13; break;
                case "15": cbNgaySinhVo.SelectedIndex = 14; break;
                case "16": cbNgaySinhVo.SelectedIndex = 15; break;
                case "17": cbNgaySinhVo.SelectedIndex = 16; break;
                case "18": cbNgaySinhVo.SelectedIndex = 17; break;
                case "19": cbNgaySinhVo.SelectedIndex = 18; break;
                case "20": cbNgaySinhVo.SelectedIndex = 19; break;
                case "21": cbNgaySinhVo.SelectedIndex = 20; break;
                case "22": cbNgaySinhVo.SelectedIndex = 21; break;
                case "23": cbNgaySinhVo.SelectedIndex = 22; break;
                case "24": cbNgaySinhVo.SelectedIndex = 23; break;
                case "25": cbNgaySinhVo.SelectedIndex = 24; break;
                case "26": cbNgaySinhVo.SelectedIndex = 25; break;
                case "27": cbNgaySinhVo.SelectedIndex = 26; break;
                case "28": cbNgaySinhVo.SelectedIndex = 27; break;
                case "29": cbNgaySinhVo.SelectedIndex = 28; break;
                case "30": cbNgaySinhVo.SelectedIndex = 29; break;
                case "31": cbNgaySinhVo.SelectedIndex = 30; break;
            }
            switch (arr2[1])
            {
                case "1": cbThangSinhVo.SelectedIndex = 0; break;
                case "2": cbThangSinhVo.SelectedIndex = 1; break;
                case "3": cbThangSinhVo.SelectedIndex = 2; break;
                case "4": cbThangSinhVo.SelectedIndex = 3; break;
                case "5": cbThangSinhVo.SelectedIndex = 4; break;
                case "6": cbThangSinhVo.SelectedIndex = 5; break;
                case "7": cbThangSinhVo.SelectedIndex = 6; break;
                case "8": cbThangSinhVo.SelectedIndex = 7; break;
                case "9": cbThangSinhVo.SelectedIndex = 8; break;
                case "10": cbThangSinhVo.SelectedIndex = 9; break;
                case "11": cbThangSinhVo.SelectedIndex = 10; break;
                case "12": cbThangSinhVo.SelectedIndex = 11; break;
            }
            switch (arr2[2])
            {
                case "1960": cbNamSinhVo.SelectedIndex = 0; break;
                case "1961": cbNamSinhVo.SelectedIndex = 1; break;
                case "1962": cbNamSinhVo.SelectedIndex = 2; break;
                case "1963": cbNamSinhVo.SelectedIndex = 3; break;
                case "1964": cbNamSinhVo.SelectedIndex = 4; break;
                case "1965": cbNamSinhVo.SelectedIndex = 5; break;
                case "1966": cbNamSinhVo.SelectedIndex = 6; break;
                case "1967": cbNamSinhVo.SelectedIndex = 7; break;
                case "1968": cbNamSinhVo.SelectedIndex = 8; break;
                case "1969": cbNamSinhVo.SelectedIndex = 9; break;
                case "1970": cbNamSinhVo.SelectedIndex = 10; break;
                case "1971": cbNamSinhVo.SelectedIndex = 11; break;
                case "1972": cbNamSinhVo.SelectedIndex = 12; break;
                case "1973": cbNamSinhVo.SelectedIndex = 13; break;
                case "1974": cbNamSinhVo.SelectedIndex = 14; break;
                case "1975": cbNamSinhVo.SelectedIndex = 15; break;
                case "1976": cbNamSinhVo.SelectedIndex = 16; break;
                case "1977": cbNamSinhVo.SelectedIndex = 17; break;
                case "1978": cbNamSinhVo.SelectedIndex = 18; break;
                case "1979": cbNamSinhVo.SelectedIndex = 19; break;
                case "1980": cbNamSinhVo.SelectedIndex = 20; break;
                case "1981": cbNamSinhVo.SelectedIndex = 21; break;
                case "1982": cbNamSinhVo.SelectedIndex = 22; break;
                case "1983": cbNamSinhVo.SelectedIndex = 23; break;
                case "1984": cbNamSinhVo.SelectedIndex = 24; break;
                case "1985": cbNamSinhVo.SelectedIndex = 25; break;
                case "1986": cbNamSinhVo.SelectedIndex = 26; break;
                case "1987": cbNamSinhVo.SelectedIndex = 27; break;
                case "1988": cbNamSinhVo.SelectedIndex = 28; break;
                case "1989": cbNamSinhVo.SelectedIndex = 29; break;
                case "1990": cbNamSinhVo.SelectedIndex = 30; break;
                case "1991": cbNamSinhVo.SelectedIndex = 31; break;
                case "1992": cbNamSinhVo.SelectedIndex = 32; break;
                case "1993": cbNamSinhVo.SelectedIndex = 33; break;
                case "1994": cbNamSinhVo.SelectedIndex = 34; break;
                case "1995": cbNamSinhVo.SelectedIndex = 35; break;
                case "1996": cbNamSinhVo.SelectedIndex = 36; break;
                case "1997": cbNamSinhVo.SelectedIndex = 37; break;
                case "1998": cbNamSinhVo.SelectedIndex = 38; break;
                case "1999": cbNamSinhVo.SelectedIndex = 39; break;
                case "2000": cbNamSinhVo.SelectedIndex = 40; break;
            }
            switch (items[9])
            {
                case "Kinh": cbDanTocVo.SelectedIndex = 0; break;
                case "Tày": cbDanTocVo.SelectedIndex = 1; break;
                case "Thái": cbDanTocVo.SelectedIndex = 2; break;
                case "Mường": cbDanTocVo.SelectedIndex = 3; break;
                case "Khơ Me": cbDanTocVo.SelectedIndex = 4; break;
                case "H'Mông": cbDanTocVo.SelectedIndex = 5; break;
                case "Nùng": cbDanTocVo.SelectedIndex = 6; break;
                case "Hoa": cbDanTocVo.SelectedIndex = 7; break;
                case "Dao": cbDanTocVo.SelectedIndex = 8; break;
                case "Gia Rai": cbDanTocVo.SelectedIndex = 9; break;
                case "Ê Đê": cbDanTocVo.SelectedIndex = 10; break;
                case "Ba Na": cbDanTocVo.SelectedIndex = 11; break;
                case "Xơ Đăng": cbDanTocVo.SelectedIndex = 12; break;
                case "Sán Chay": cbDanTocVo.SelectedIndex = 13; break;
                case "Cơ Ho": cbDanTocVo.SelectedIndex = 14; break;
                case "Chăm": cbDanTocVo.SelectedIndex = 15; break;
                case "Sán Dìu": cbDanTocVo.SelectedIndex = 16; break;
                case "Hrê": cbDanTocVo.SelectedIndex = 17; break;
                case "Ra Glai": cbDanTocVo.SelectedIndex = 18; break;
                case "M'Nông": cbDanTocVo.SelectedIndex = 19; break;
                case "X’Tiêng": cbDanTocVo.SelectedIndex = 20; break;
                case "Bru-Vân Kiều": cbDanTocVo.SelectedIndex = 21; break;
                case "Thổ": cbDanTocVo.SelectedIndex = 22; break;
                case "Khơ Mú": cbDanTocVo.SelectedIndex = 23; break;
                case "Cơ Tu": cbDanTocVo.SelectedIndex = 24; break;
                case "Giáy": cbDanTocVo.SelectedIndex = 25; break;
                case "Giẻ Triêng": cbDanTocVo.SelectedIndex = 26; break;
                case "Tà Ôi": cbDanTocVo.SelectedIndex = 27; break;
                case "Mạ": cbDanTocVo.SelectedIndex = 28; break;
                case "Co": cbDanTocVo.SelectedIndex = 29; break;
                case "Chơ Ro": cbDanTocVo.SelectedIndex = 30; break;
                case "Xinh Mun": cbDanTocVo.SelectedIndex = 31; break;
                case "Hà Nhì": cbDanTocVo.SelectedIndex = 32; break;
                case "Chu Ru": cbDanTocVo.SelectedIndex = 33; break;
                case "Lào": cbDanTocVo.SelectedIndex = 34; break;
                case "Kháng": cbDanTocVo.SelectedIndex = 35; break;
                case "La Chí": cbDanTocVo.SelectedIndex = 36; break;
                case "Phú Lá": cbDanTocVo.SelectedIndex = 37; break;
                case "La Hủ": cbDanTocVo.SelectedIndex = 38; break;
                case "La Ha": cbDanTocVo.SelectedIndex = 39; break;
                case "Pà Thẻn": cbDanTocVo.SelectedIndex = 40; break;
                case "Chứt": cbDanTocVo.SelectedIndex = 41; break;
                case "Lự": cbDanTocVo.SelectedIndex = 42; break;
                case "Lô Lô": cbDanTocVo.SelectedIndex = 43; break;
                case "Mảng": cbDanTocVo.SelectedIndex = 44; break;
                case "Cờ Lao": cbDanTocVo.SelectedIndex = 45; break;
                case "Bố Y": cbDanTocVo.SelectedIndex = 46; break;
                case "Cống": cbDanTocVo.SelectedIndex = 47; break;
                case "Ngái": cbDanTocVo.SelectedIndex = 48; break;
                case "Si La": cbDanTocVo.SelectedIndex = 49; break;
                case "Pu Péo": cbDanTocVo.SelectedIndex = 50; break;
                case "Rơ măm": cbDanTocVo.SelectedIndex = 51; break;
                case "Brâu": cbDanTocVo.SelectedIndex = 52; break;
                case "Ơ Đu": cbDanTocVo.SelectedIndex = 53; break;
                case "Thành phần khác": cbDanTocVo.SelectedIndex = 54; break;
            }
            switch (items[10])
            {
                case "Afghanistan": cbQuocTichVo.SelectedIndex = 0; break;
                case "Akrotiri và Dhekelia": cbQuocTichVo.SelectedIndex = 1; break;
                case "Ả Rập Saudi": cbQuocTichVo.SelectedIndex = 2; break;
                case "Armenia": cbQuocTichVo.SelectedIndex = 3; break;
                case "Azerbaijan": cbQuocTichVo.SelectedIndex = 4; break;
                case "Ấn Độ": cbQuocTichVo.SelectedIndex = 5; break;
                case "Bahrain": cbQuocTichVo.SelectedIndex = 6; break;
                case "Bangladesh": cbQuocTichVo.SelectedIndex = 7; break;
                case "Bhutan": cbQuocTichVo.SelectedIndex = 8; break;
                case "Brunei": cbQuocTichVo.SelectedIndex = 9; break;
                case "Campuchia": cbQuocTichVo.SelectedIndex = 10; break;
                case "Đài Loan": cbQuocTichVo.SelectedIndex = 11; break;
                case "Georgia": cbQuocTichVo.SelectedIndex = 12; break;
                case "Hồng Kông": cbQuocTichVo.SelectedIndex = 13; break;
                case "Indonesia": cbQuocTichVo.SelectedIndex = 14; break;
                case "Iran": cbQuocTichVo.SelectedIndex = 15; break;
                case "Iraq": cbQuocTichVo.SelectedIndex = 16; break;
                case "Israel": cbQuocTichVo.SelectedIndex = 17; break;
                case "Jordan": cbQuocTichVo.SelectedIndex = 18; break;
                case "Kazakhstan": cbQuocTichVo.SelectedIndex = 19; break;
                case "Kuwait": cbQuocTichVo.SelectedIndex = 20; break;
                case "Kyrgyzstan": cbQuocTichVo.SelectedIndex = 21; break;
                case "Lào": cbQuocTichVo.SelectedIndex = 22; break;
                case "Liban": cbQuocTichVo.SelectedIndex = 23; break;
                case "Ma Cao": cbQuocTichVo.SelectedIndex = 24; break;
                case "Malaysia": cbQuocTichVo.SelectedIndex = 25; break;
                case "Kuala Lumpur": cbQuocTichVo.SelectedIndex = 26; break;
                case "Maldives": cbQuocTichVo.SelectedIndex = 27; break;
                case "Mông Cổ": cbQuocTichVo.SelectedIndex = 28; break;
                case "Myanma": cbQuocTichVo.SelectedIndex = 29; break;
                case "Nagorno-Karabakh": cbQuocTichVo.SelectedIndex = 30; break;
                case "Nepal": cbQuocTichVo.SelectedIndex = 31; break;
                case "Nga": cbQuocTichVo.SelectedIndex = 32; break;
                case "Nhật Bản": cbQuocTichVo.SelectedIndex = 33; break;
                case "Oman": cbQuocTichVo.SelectedIndex = 34; break;
                case "Pakistan": cbQuocTichVo.SelectedIndex = 35; break;
                case "Palestine": cbQuocTichVo.SelectedIndex = 36; break;
                case "Philippines": cbQuocTichVo.SelectedIndex = 37; break;
                case "Qatar": cbQuocTichVo.SelectedIndex = 38; break;
                case "Singapore": cbQuocTichVo.SelectedIndex = 39; break;
                case "Bắc Síp": cbQuocTichVo.SelectedIndex = 40; break;
                case "Síp": cbQuocTichVo.SelectedIndex = 41; break;
                case "Sri Lanka": cbQuocTichVo.SelectedIndex = 42; break;
                case "Syria": cbQuocTichVo.SelectedIndex = 43; break;
                case "Tajikistan": cbQuocTichVo.SelectedIndex = 44; break;
                case "Thái Lan": cbQuocTichVo.SelectedIndex = 45; break;
                case "Đông Timor": cbQuocTichVo.SelectedIndex = 46; break;
                case "Thổ Nhĩ Kỳ": cbQuocTichVo.SelectedIndex = 47; break;
                case "Triều Tiên": cbQuocTichVo.SelectedIndex = 48; break;
                case "Hàn Quốc": cbQuocTichVo.SelectedIndex = 49; break;
                case "Trung Quốc": cbQuocTichVo.SelectedIndex = 50; break;
                case "Turkmenistan": cbQuocTichVo.SelectedIndex = 51; break;
                case "Uzbekistan": cbQuocTichVo.SelectedIndex = 52; break;
                case "Việt Nam": cbQuocTichVo.SelectedIndex = 53; break;
                case "Yemen": cbQuocTichVo.SelectedIndex = 54; break;
            }
            txtThuongTamTruVo.Text = items[11];
            txtCMNDVo.Text = items[12];
            switch (items[13])
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
            string[] arr3 = items[14].Split('/');
            switch (arr3[0])
            {
                case "1": cbNgayDangKy.SelectedIndex = 0; break;
                case "2": cbNgayDangKy.SelectedIndex = 1; break;
                case "3": cbNgayDangKy.SelectedIndex = 2; break;
                case "4": cbNgayDangKy.SelectedIndex = 3; break;
                case "5": cbNgayDangKy.SelectedIndex = 4; break;
                case "6": cbNgayDangKy.SelectedIndex = 5; break;
                case "7": cbNgayDangKy.SelectedIndex = 6; break;
                case "8": cbNgayDangKy.SelectedIndex = 7; break;
                case "9": cbNgayDangKy.SelectedIndex = 8; break;
                case "10": cbNgayDangKy.SelectedIndex = 9; break;
                case "11": cbNgayDangKy.SelectedIndex = 10; break;
                case "12": cbNgayDangKy.SelectedIndex = 11; break;
                case "13": cbNgayDangKy.SelectedIndex = 12; break;
                case "14": cbNgayDangKy.SelectedIndex = 13; break;
                case "15": cbNgayDangKy.SelectedIndex = 14; break;
                case "16": cbNgayDangKy.SelectedIndex = 15; break;
                case "17": cbNgayDangKy.SelectedIndex = 16; break;
                case "18": cbNgayDangKy.SelectedIndex = 17; break;
                case "19": cbNgayDangKy.SelectedIndex = 18; break;
                case "20": cbNgayDangKy.SelectedIndex = 19; break;
                case "21": cbNgayDangKy.SelectedIndex = 20; break;
                case "22": cbNgayDangKy.SelectedIndex = 21; break;
                case "23": cbNgayDangKy.SelectedIndex = 22; break;
                case "24": cbNgayDangKy.SelectedIndex = 23; break;
                case "25": cbNgayDangKy.SelectedIndex = 24; break;
                case "26": cbNgayDangKy.SelectedIndex = 25; break;
                case "27": cbNgayDangKy.SelectedIndex = 26; break;
                case "28": cbNgayDangKy.SelectedIndex = 27; break;
                case "29": cbNgayDangKy.SelectedIndex = 28; break;
                case "30": cbNgayDangKy.SelectedIndex = 29; break;
                case "31": cbNgayDangKy.SelectedIndex = 30; break;
            }
            switch (arr3[1])
            {
                case "1": cbThangDangKy.SelectedIndex = 0; break;
                case "2": cbThangDangKy.SelectedIndex = 1; break;
                case "3": cbThangDangKy.SelectedIndex = 2; break;
                case "4": cbThangDangKy.SelectedIndex = 3; break;
                case "5": cbThangDangKy.SelectedIndex = 4; break;
                case "6": cbThangDangKy.SelectedIndex = 5; break;
                case "7": cbThangDangKy.SelectedIndex = 6; break;
                case "8": cbThangDangKy.SelectedIndex = 7; break;
                case "9": cbThangDangKy.SelectedIndex = 8; break;
                case "10": cbThangDangKy.SelectedIndex = 9; break;
                case "11": cbThangDangKy.SelectedIndex = 10; break;
                case "12": cbThangDangKy.SelectedIndex = 11; break;
            }
            switch (arr3[2])
            {
                case "1960": cbNamDangKy.SelectedIndex = 0; break;
                case "1961": cbNamDangKy.SelectedIndex = 1; break;
                case "1962": cbNamDangKy.SelectedIndex = 2; break;
                case "1963": cbNamDangKy.SelectedIndex = 3; break;
                case "1964": cbNamDangKy.SelectedIndex = 4; break;
                case "1965": cbNamDangKy.SelectedIndex = 5; break;
                case "1966": cbNamDangKy.SelectedIndex = 6; break;
                case "1967": cbNamDangKy.SelectedIndex = 7; break;
                case "1968": cbNamDangKy.SelectedIndex = 8; break;
                case "1969": cbNamDangKy.SelectedIndex = 9; break;
                case "1970": cbNamDangKy.SelectedIndex = 10; break;
                case "1971": cbNamDangKy.SelectedIndex = 11; break;
                case "1972": cbNamDangKy.SelectedIndex = 12; break;
                case "1973": cbNamDangKy.SelectedIndex = 13; break;
                case "1974": cbNamDangKy.SelectedIndex = 14; break;
                case "1975": cbNamDangKy.SelectedIndex = 15; break;
                case "1976": cbNamDangKy.SelectedIndex = 16; break;
                case "1977": cbNamDangKy.SelectedIndex = 17; break;
                case "1978": cbNamDangKy.SelectedIndex = 18; break;
                case "1979": cbNamDangKy.SelectedIndex = 19; break;
                case "1980": cbNamDangKy.SelectedIndex = 20; break;
                case "1981": cbNamDangKy.SelectedIndex = 21; break;
                case "1982": cbNamDangKy.SelectedIndex = 22; break;
                case "1983": cbNamDangKy.SelectedIndex = 23; break;
                case "1984": cbNamDangKy.SelectedIndex = 24; break;
                case "1985": cbNamDangKy.SelectedIndex = 25; break;
                case "1986": cbNamDangKy.SelectedIndex = 26; break;
                case "1987": cbNamDangKy.SelectedIndex = 27; break;
                case "1988": cbNamDangKy.SelectedIndex = 28; break;
                case "1989": cbNamDangKy.SelectedIndex = 29; break;
                case "1990": cbNamDangKy.SelectedIndex = 30; break;
                case "1991": cbNamDangKy.SelectedIndex = 31; break;
                case "1992": cbNamDangKy.SelectedIndex = 32; break;
                case "1993": cbNamDangKy.SelectedIndex = 33; break;
                case "1994": cbNamDangKy.SelectedIndex = 34; break;
                case "1995": cbNamDangKy.SelectedIndex = 35; break;
                case "1996": cbNamDangKy.SelectedIndex = 36; break;
                case "1997": cbNamDangKy.SelectedIndex = 37; break;
                case "1998": cbNamDangKy.SelectedIndex = 38; break;
                case "1999": cbNamDangKy.SelectedIndex = 39; break;
                case "2000": cbNamDangKy.SelectedIndex = 40; break;
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
        }

        private void btnSuaChungNhanKetHon_Click(object sender, EventArgs e)
        {
            string ngayChong = cbNgaySinhChong.Text;
            string thangChong = cbThangSinhChong.Text;
            string namChong = cbNamSinhChong.Text;
            string ngayVo = cbNgaySinhVo.Text;
            string thangVo = cbThangSinhVo.Text;
            string namVo = cbNamSinhVo.Text;
            string ngayDK = cbNgayDangKy.Text;
            string thangDK = cbThangDangKy.Text;
            string namDK = cbNamDangKy.Text;

            string maKetHon = txtMaKetHon.Text;
            string hoTenChong = txtHoTenChong.Text;
            string ngaySinhChong = ngayChong + "/" + thangChong + "/" + namChong;
            string danTocChong = cbDanTocChong.Text;
            string quocTichChong = cbQuocTichChong.Text;
            string cmndChong = txtCMNDChong.Text;
            string thuongTamTruChong = txtThuongTamTruChong.Text;
            string hoTenVo = txtHoTenVo.Text;
            string ngaySinhVo = ngayVo + "/" + thangVo + "/" + namVo;
            string danTocVo = cbDanTocVo.Text;
            string quocTichVo = cbQuocTichVo.Text;
            string cmndVo = txtCMNDVo.Text;
            string thuongTamTruVo = txtThuongTamTruVo.Text;
            string khuVucDangKy = cbQueQuan.Text;
            string ngayDangKy = ngayDK + "/" + thangDK + "/" + namDK;

            if (!(maKetHon.Equals("")       || hoTenChong.Equals("")        || ngayChong.Equals("")         ||
                  thangChong.Equals("")     || namChong.Equals("")          || danTocChong.Equals("")       ||
                  quocTichChong.Equals("")  || cmndChong.Equals("")         || thuongTamTruChong.Equals("") ||
                  hoTenVo.Equals("")        || ngayVo.Equals("")            || thangVo.Equals("")           ||
                  namVo.Equals("")          || cbDanTocVo.Equals("")        || cbQuocTichVo.Equals("")      ||
                  txtCMNDVo.Equals("")      || txtThuongTamTruVo.Equals("") || cbQueQuan.Equals("")         ||
                  ngayDK.Equals("")         || thangDK.Equals("")           || namDK.Equals("")))
            {
                DialogResult dialogResult = MessageBox.Show(sc.MSGBOX_UPDATE, sc.MSGBOX_CAP_UPDATE, MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    flagSave = true;
                    if (sc.updateKetHon(maKetHon, hoTenChong, ngaySinhChong, danTocChong,
                                        quocTichChong, thuongTamTruChong, cmndChong, hoTenVo,
                                        ngaySinhVo, danTocVo, quocTichVo, thuongTamTruVo,
                                        cmndVo, khuVucDangKy, ngayDangKy))
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

        private void SuaKetHon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flagSave == false)
            {
                string ngayChong = cbNgaySinhChong.Text;
                string thangChong = cbThangSinhChong.Text;
                string namChong = cbNamSinhChong.Text;
                string ngayVo = cbNgaySinhVo.Text;
                string thangVo = cbThangSinhVo.Text;
                string namVo = cbNamSinhVo.Text;
                string ngayDK = cbNgayDangKy.Text;
                string thangDK = cbThangDangKy.Text;
                string namDK = cbNamDangKy.Text;

                string maKetHon = txtMaKetHon.Text;
                string hoTenChong = txtHoTenChong.Text;
                string ngaySinhChong = ngayChong + "/" + thangChong + "/" + namChong;
                string danTocChong = cbDanTocChong.Text;
                string quocTichChong = cbQuocTichChong.Text;
                string cmndChong = txtCMNDChong.Text;
                string thuongTamTruChong = txtThuongTamTruChong.Text;
                string hoTenVo = txtHoTenVo.Text;
                string ngaySinhVo = ngayVo + "/" + thangVo + "/" + namVo;
                string danTocVo = cbDanTocVo.Text;
                string quocTichVo = cbQuocTichVo.Text;
                string cmndVo = txtCMNDVo.Text;
                string thuongTamTruVo = txtThuongTamTruVo.Text;
                string khuVucDangKy = cbQueQuan.Text;
                string ngayDangKy = ngayDK + "/" + thangDK + "/" + namDK;

                if ((!maKetHon.Equals(itemKetHon[0])        || !hoTenChong.Equals(itemKetHon[1])        ||
                     !ngaySinhChong.Equals(itemKetHon[2])   || !danTocChong.Equals(itemKetHon[3])       ||
                     !quocTichChong.Equals(itemKetHon[4])   || !thuongTamTruChong.Equals(itemKetHon[5]) ||
                     !cmndChong.Equals(itemKetHon[6])       || !hoTenVo.Equals(itemKetHon[7])           ||
                     !ngaySinhVo.Equals(itemKetHon[8])      || !danTocVo.Equals(itemKetHon[9])          ||
                     !quocTichVo.Equals(itemKetHon[10])     || !thuongTamTruVo.Equals(itemKetHon[11])   ||
                     !cmndVo.Equals(itemKetHon[12])         || !khuVucDangKy.Equals(itemKetHon[13])     ||
                     !ngayDangKy.Equals(itemKetHon[14])))
                {
                    DialogResult dialogResult = MessageBox.Show(sc.MSGBOX_UPDATE,
                                                                sc.MSGBOX_CAP_EXIT,
                                                                MessageBoxButtons.YesNoCancel);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (!(maKetHon.Equals("")       || hoTenChong.Equals("")        || ngayChong.Equals("")         ||
                              thangChong.Equals("")     || namChong.Equals("")          || danTocChong.Equals("")       ||
                              quocTichChong.Equals("")  || cmndChong.Equals("")         || thuongTamTruChong.Equals("") ||
                              hoTenVo.Equals("")        || ngayVo.Equals("")            || thangVo.Equals("")           ||
                              namVo.Equals("")          || cbDanTocVo.Equals("")        || cbQuocTichVo.Equals("")      ||
                              txtCMNDVo.Equals("")      || txtThuongTamTruVo.Equals("") || cbQueQuan.Equals("")         ||
                              ngayDK.Equals("")         || thangDK.Equals("")           || namDK.Equals("")))
                        {
                            if (sc.updateKetHon(maKetHon, hoTenChong, ngaySinhChong, danTocChong,
                                                quocTichChong, thuongTamTruChong, cmndChong, hoTenVo,
                                                ngaySinhVo, danTocVo, quocTichVo, thuongTamTruVo,
                                                cmndVo, khuVucDangKy, ngayDangKy))
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

        private void txtHoTenChong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtHoTenVo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtCMNDChong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtCMNDVo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
