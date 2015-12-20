using System;
using System.Windows.Forms;
using MaterialSkin.Controls;
using static System.Int32;

namespace QLNK
{
    public partial class SuaKetHon : MaterialForm
    {
        readonly SourceCode _sourceCode = new SourceCode();
        private readonly string[] _itemKetHon;
        private bool _flagSave;
        public SuaKetHon(string[] itemKetHon)
        {
            InitializeComponent();
            _itemKetHon = itemKetHon;
            SetNormal(itemKetHon);
        }
        private void SetNormal(string[] items)
        {
            txtHoTenChong.Text = items[1];
            var arr = items[2].Split('/');
            switch (arr[0])
            {
                case "01": cbNgaySinhChong.SelectedIndex = 0; break;
                case "02": cbNgaySinhChong.SelectedIndex = 1; break;
                case "03": cbNgaySinhChong.SelectedIndex = 2; break;
                case "04": cbNgaySinhChong.SelectedIndex = 3; break;
                case "05": cbNgaySinhChong.SelectedIndex = 4; break;
                case "06": cbNgaySinhChong.SelectedIndex = 5; break;
                case "07": cbNgaySinhChong.SelectedIndex = 6; break;
                case "08": cbNgaySinhChong.SelectedIndex = 7; break;
                case "09": cbNgaySinhChong.SelectedIndex = 8; break;
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
                case "01": cbThangSinhChong.SelectedIndex = 0; break;
                case "02": cbThangSinhChong.SelectedIndex = 1; break;
                case "03": cbThangSinhChong.SelectedIndex = 2; break;
                case "04": cbThangSinhChong.SelectedIndex = 3; break;
                case "05": cbThangSinhChong.SelectedIndex = 4; break;
                case "06": cbThangSinhChong.SelectedIndex = 5; break;
                case "07": cbThangSinhChong.SelectedIndex = 6; break;
                case "08": cbThangSinhChong.SelectedIndex = 7; break;
                case "09": cbThangSinhChong.SelectedIndex = 8; break;
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
            }
            switch (items[3])
            {
                case "Kinh": cbDanTocChong.SelectedIndex = 0; break;
                case "Tày": cbDanTocChong.SelectedIndex = 1; break;
                case "Thái": cbDanTocChong.SelectedIndex = 2; break;
                case "Mường": cbDanTocChong.SelectedIndex = 3; break;
                case "Khơ Me": cbDanTocChong.SelectedIndex = 4; break;
                case "HMông": cbDanTocChong.SelectedIndex = 5; break;
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
                case "MNông": cbDanTocChong.SelectedIndex = 19; break;
                case "XTiêng": cbDanTocChong.SelectedIndex = 20; break;
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
                case "An Giang": cbQueQuanChong.SelectedIndex = 0; break;
                case "Bà Rịa - Vũng Tàu": cbQueQuanChong.SelectedIndex = 1; break;
                case "Bạc Liêu": cbQueQuanChong.SelectedIndex = 2; break;
                case "Bắc Kạn": cbQueQuanChong.SelectedIndex = 3; break;
                case "Bắc Giang": cbQueQuanChong.SelectedIndex = 4; break;
                case "Bắc Ninh": cbQueQuanChong.SelectedIndex = 5; break;
                case "Bến Tre": cbQueQuanChong.SelectedIndex = 6; break;
                case "Bình Dương": cbQueQuanChong.SelectedIndex = 7; break;
                case "Bình Định": cbQueQuanChong.SelectedIndex = 8; break;
                case "Bình Phước": cbQueQuanChong.SelectedIndex = 9; break;
                case "Bình Thuận": cbQueQuanChong.SelectedIndex = 10; break;
                case "Cà Mau": cbQueQuanChong.SelectedIndex = 11; break;
                case "Cao Bằng": cbQueQuanChong.SelectedIndex = 12; break;
                case "Cần Thơ": cbQueQuanChong.SelectedIndex = 13; break;
                case "Đà Nẵng": cbQueQuanChong.SelectedIndex = 14; break;
                case "Đắk Lắk": cbQueQuanChong.SelectedIndex = 15; break;
                case "Đắk Nông": cbQueQuanChong.SelectedIndex = 16; break;
                case "Đồng Nai": cbQueQuanChong.SelectedIndex = 17; break;
                case "Đồng Tháp": cbQueQuanChong.SelectedIndex = 18; break;
                case "Điện Biên": cbQueQuanChong.SelectedIndex = 19; break;
                case "Gia Lai": cbQueQuanChong.SelectedIndex = 20; break;
                case "Hà Giang": cbQueQuanChong.SelectedIndex = 21; break;
                case "Hà Nam": cbQueQuanChong.SelectedIndex = 22; break;
                case "Hà Nội": cbQueQuanChong.SelectedIndex = 23; break;
                case "Hà Tĩnh": cbQueQuanChong.SelectedIndex = 24; break;
                case "Hải Dương": cbQueQuanChong.SelectedIndex = 25; break;
                case "Hải Phòng": cbQueQuanChong.SelectedIndex = 26; break;
                case "Hòa Bình": cbQueQuanChong.SelectedIndex = 27; break;
                case "Hậu Giang": cbQueQuanChong.SelectedIndex = 28; break;
                case "Hưng Yên": cbQueQuanChong.SelectedIndex = 29; break;
                case "TPHCM": cbQueQuanChong.SelectedIndex = 30; break;
                case "Khánh Hòa": cbQueQuanChong.SelectedIndex = 31; break;
                case "Kiên Giang": cbQueQuanChong.SelectedIndex = 32; break;
                case "Kon Tum": cbQueQuanChong.SelectedIndex = 33; break;
                case "Lai Châu": cbQueQuanChong.SelectedIndex = 34; break;
                case "Lào Cai": cbQueQuanChong.SelectedIndex = 35; break;
                case "Lạng Sơn": cbQueQuanChong.SelectedIndex = 36; break;
                case "Lâm Đồng": cbQueQuanChong.SelectedIndex = 37; break;
                case "Long An": cbQueQuanChong.SelectedIndex = 38; break;
                case "Nam Định": cbQueQuanChong.SelectedIndex = 39; break;
                case "Nghệ An": cbQueQuanChong.SelectedIndex = 40; break;
                case "Ninh Bình": cbQueQuanChong.SelectedIndex = 41; break;
                case "Ninh Thuận": cbQueQuanChong.SelectedIndex = 42; break;
                case "Phú Thọ": cbQueQuanChong.SelectedIndex = 43; break;
                case "Phú Yên": cbQueQuanChong.SelectedIndex = 44; break;
                case "Quảng Bình": cbQueQuanChong.SelectedIndex = 45; break;
                case "Quảng Nam": cbQueQuanChong.SelectedIndex = 46; break;
                case "Quảng Ngãi": cbQueQuanChong.SelectedIndex = 47; break;
                case "Quảng Ninh": cbQueQuanChong.SelectedIndex = 48; break;
                case "Quảng Trị": cbQueQuanChong.SelectedIndex = 49; break;
                case "Sóc Trăng": cbQueQuanChong.SelectedIndex = 50; break;
                case "Sơn La": cbQueQuanChong.SelectedIndex = 51; break;
                case "Tây Ninh": cbQueQuanChong.SelectedIndex = 52; break;
                case "Thái Bình": cbQueQuanChong.SelectedIndex = 53; break;
                case "Thái Nguyên": cbQueQuanChong.SelectedIndex = 54; break;
                case "Thanh Hóa": cbQueQuanChong.SelectedIndex = 55; break;
                case "Thừa Thiên Huế": cbQueQuanChong.SelectedIndex = 56; break;
                case "Tiền Giang": cbQueQuanChong.SelectedIndex = 57; break;
                case "Trà Vinh": cbQueQuanChong.SelectedIndex = 58; break;
                case "Tuyên Quang": cbQueQuanChong.SelectedIndex = 59; break;
                case "Vĩnh Long": cbQueQuanChong.SelectedIndex = 60; break;
                case "Vĩnh Phúc": cbQueQuanChong.SelectedIndex = 61; break;
                case "Yên Bái": cbQueQuanChong.SelectedIndex = 62; break;
            }
            txtThuongTamTruChong.Text = items[5];
            txtCMNDChong.Text = items[6];
            txtHoTenVo.Text = items[7];
            var arr2 = items[8].Split('/');
            switch (arr2[0])
            {
                case "01": cbNgaySinhVo.SelectedIndex = 0; break;
                case "02": cbNgaySinhVo.SelectedIndex = 1; break;
                case "03": cbNgaySinhVo.SelectedIndex = 2; break;
                case "04": cbNgaySinhVo.SelectedIndex = 3; break;
                case "05": cbNgaySinhVo.SelectedIndex = 4; break;
                case "06": cbNgaySinhVo.SelectedIndex = 5; break;
                case "07": cbNgaySinhVo.SelectedIndex = 6; break;
                case "08": cbNgaySinhVo.SelectedIndex = 7; break;
                case "09": cbNgaySinhVo.SelectedIndex = 8; break;
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
                case "01": cbThangSinhVo.SelectedIndex = 0; break;
                case "02": cbThangSinhVo.SelectedIndex = 1; break;
                case "03": cbThangSinhVo.SelectedIndex = 2; break;
                case "04": cbThangSinhVo.SelectedIndex = 3; break;
                case "05": cbThangSinhVo.SelectedIndex = 4; break;
                case "06": cbThangSinhVo.SelectedIndex = 5; break;
                case "07": cbThangSinhVo.SelectedIndex = 6; break;
                case "08": cbThangSinhVo.SelectedIndex = 7; break;
                case "09": cbThangSinhVo.SelectedIndex = 8; break;
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
            }
            switch (items[9])
            {
                case "Kinh": cbDanTocVo.SelectedIndex = 0; break;
                case "Tày": cbDanTocVo.SelectedIndex = 1; break;
                case "Thái": cbDanTocVo.SelectedIndex = 2; break;
                case "Mường": cbDanTocVo.SelectedIndex = 3; break;
                case "Khơ Me": cbDanTocVo.SelectedIndex = 4; break;
                case "HMông": cbDanTocVo.SelectedIndex = 5; break;
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
                case "MNông": cbDanTocVo.SelectedIndex = 19; break;
                case "XTiêng": cbDanTocVo.SelectedIndex = 20; break;
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
                case "An Giang": cbQueQuanVo.SelectedIndex = 0; break;
                case "Bà Rịa - Vũng Tàu": cbQueQuanVo.SelectedIndex = 1; break;
                case "Bạc Liêu": cbQueQuanVo.SelectedIndex = 2; break;
                case "Bắc Kạn": cbQueQuanVo.SelectedIndex = 3; break;
                case "Bắc Giang": cbQueQuanVo.SelectedIndex = 4; break;
                case "Bắc Ninh": cbQueQuanVo.SelectedIndex = 5; break;
                case "Bến Tre": cbQueQuanVo.SelectedIndex = 6; break;
                case "Bình Dương": cbQueQuanVo.SelectedIndex = 7; break;
                case "Bình Định": cbQueQuanVo.SelectedIndex = 8; break;
                case "Bình Phước": cbQueQuanVo.SelectedIndex = 9; break;
                case "Bình Thuận": cbQueQuanVo.SelectedIndex = 10; break;
                case "Cà Mau": cbQueQuanVo.SelectedIndex = 11; break;
                case "Cao Bằng": cbQueQuanVo.SelectedIndex = 12; break;
                case "Cần Thơ": cbQueQuanVo.SelectedIndex = 13; break;
                case "Đà Nẵng": cbQueQuanVo.SelectedIndex = 14; break;
                case "Đắk Lắk": cbQueQuanVo.SelectedIndex = 15; break;
                case "Đắk Nông": cbQueQuanVo.SelectedIndex = 16; break;
                case "Đồng Nai": cbQueQuanVo.SelectedIndex = 17; break;
                case "Đồng Tháp": cbQueQuanVo.SelectedIndex = 18; break;
                case "Điện Biên": cbQueQuanVo.SelectedIndex = 19; break;
                case "Gia Lai": cbQueQuanVo.SelectedIndex = 20; break;
                case "Hà Giang": cbQueQuanVo.SelectedIndex = 21; break;
                case "Hà Nam": cbQueQuanVo.SelectedIndex = 22; break;
                case "Hà Nội": cbQueQuanVo.SelectedIndex = 23; break;
                case "Hà Tĩnh": cbQueQuanVo.SelectedIndex = 24; break;
                case "Hải Dương": cbQueQuanVo.SelectedIndex = 25; break;
                case "Hải Phòng": cbQueQuanVo.SelectedIndex = 26; break;
                case "Hòa Bình": cbQueQuanVo.SelectedIndex = 27; break;
                case "Hậu Giang": cbQueQuanVo.SelectedIndex = 28; break;
                case "Hưng Yên": cbQueQuanVo.SelectedIndex = 29; break;
                case "TPHCM": cbQueQuanVo.SelectedIndex = 30; break;
                case "Khánh Hòa": cbQueQuanVo.SelectedIndex = 31; break;
                case "Kiên Giang": cbQueQuanVo.SelectedIndex = 32; break;
                case "Kon Tum": cbQueQuanVo.SelectedIndex = 33; break;
                case "Lai Châu": cbQueQuanVo.SelectedIndex = 34; break;
                case "Lào Cai": cbQueQuanVo.SelectedIndex = 35; break;
                case "Lạng Sơn": cbQueQuanVo.SelectedIndex = 36; break;
                case "Lâm Đồng": cbQueQuanVo.SelectedIndex = 37; break;
                case "Long An": cbQueQuanVo.SelectedIndex = 38; break;
                case "Nam Định": cbQueQuanVo.SelectedIndex = 39; break;
                case "Nghệ An": cbQueQuanVo.SelectedIndex = 40; break;
                case "Ninh Bình": cbQueQuanVo.SelectedIndex = 41; break;
                case "Ninh Thuận": cbQueQuanVo.SelectedIndex = 42; break;
                case "Phú Thọ": cbQueQuanVo.SelectedIndex = 43; break;
                case "Phú Yên": cbQueQuanVo.SelectedIndex = 44; break;
                case "Quảng Bình": cbQueQuanVo.SelectedIndex = 45; break;
                case "Quảng Nam": cbQueQuanVo.SelectedIndex = 46; break;
                case "Quảng Ngãi": cbQueQuanVo.SelectedIndex = 47; break;
                case "Quảng Ninh": cbQueQuanVo.SelectedIndex = 48; break;
                case "Quảng Trị": cbQueQuanVo.SelectedIndex = 49; break;
                case "Sóc Trăng": cbQueQuanVo.SelectedIndex = 50; break;
                case "Sơn La": cbQueQuanVo.SelectedIndex = 51; break;
                case "Tây Ninh": cbQueQuanVo.SelectedIndex = 52; break;
                case "Thái Bình": cbQueQuanVo.SelectedIndex = 53; break;
                case "Thái Nguyên": cbQueQuanVo.SelectedIndex = 54; break;
                case "Thanh Hóa": cbQueQuanVo.SelectedIndex = 55; break;
                case "Thừa Thiên Huế": cbQueQuanVo.SelectedIndex = 56; break;
                case "Tiền Giang": cbQueQuanVo.SelectedIndex = 57; break;
                case "Trà Vinh": cbQueQuanVo.SelectedIndex = 58; break;
                case "Tuyên Quang": cbQueQuanVo.SelectedIndex = 59; break;
                case "Vĩnh Long": cbQueQuanVo.SelectedIndex = 60; break;
                case "Vĩnh Phúc": cbQueQuanVo.SelectedIndex = 61; break;
                case "Yên Bái": cbQueQuanVo.SelectedIndex = 62; break;
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
            var arr3 = items[14].Split('/');
            switch (arr3[0])
            {
                case "01": cbNgayDangKy.SelectedIndex = 0; break;
                case "02": cbNgayDangKy.SelectedIndex = 1; break;
                case "03": cbNgayDangKy.SelectedIndex = 2; break;
                case "04": cbNgayDangKy.SelectedIndex = 3; break;
                case "05": cbNgayDangKy.SelectedIndex = 4; break;
                case "06": cbNgayDangKy.SelectedIndex = 5; break;
                case "07": cbNgayDangKy.SelectedIndex = 6; break;
                case "08": cbNgayDangKy.SelectedIndex = 7; break;
                case "09": cbNgayDangKy.SelectedIndex = 8; break;
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
                case "01": cbThangDangKy.SelectedIndex = 0; break;
                case "02": cbThangDangKy.SelectedIndex = 1; break;
                case "03": cbThangDangKy.SelectedIndex = 2; break;
                case "04": cbThangDangKy.SelectedIndex = 3; break;
                case "05": cbThangDangKy.SelectedIndex = 4; break;
                case "06": cbThangDangKy.SelectedIndex = 5; break;
                case "07": cbThangDangKy.SelectedIndex = 6; break;
                case "08": cbThangDangKy.SelectedIndex = 7; break;
                case "09": cbThangDangKy.SelectedIndex = 8; break;
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
                case "2001": cbNamDangKy.SelectedIndex = 41; break;
                case "2002": cbNamDangKy.SelectedIndex = 42; break;
                case "2003": cbNamDangKy.SelectedIndex = 43; break;
                case "2004": cbNamDangKy.SelectedIndex = 44; break;
                case "2005": cbNamDangKy.SelectedIndex = 45; break;
                case "2006": cbNamDangKy.SelectedIndex = 46; break;
                case "2007": cbNamDangKy.SelectedIndex = 47; break;
                case "2008": cbNamDangKy.SelectedIndex = 48; break;
                case "2009": cbNamDangKy.SelectedIndex = 49; break;
                case "2010": cbNamDangKy.SelectedIndex = 50; break;
                case "2011": cbNamDangKy.SelectedIndex = 51; break;
                case "2012": cbNamDangKy.SelectedIndex = 52; break;
                case "2013": cbNamDangKy.SelectedIndex = 53; break;
                case "2014": cbNamDangKy.SelectedIndex = 54; break;
                case "2015": cbNamDangKy.SelectedIndex = 55; break;
            }
        }

        private void btnSuaChungNhanKetHon_Click(object sender, EventArgs e)
        {
            var ngayChong = cbNgaySinhChong.Text;
            var thangChong = cbThangSinhChong.Text;
            var namChong = cbNamSinhChong.Text;
            var ngayVo = cbNgaySinhVo.Text;
            var thangVo = cbThangSinhVo.Text;
            var namVo = cbNamSinhVo.Text;
            var ngayDk = cbNgayDangKy.Text;
            var thangDk = cbThangDangKy.Text;
            var namDk = cbNamDangKy.Text;

            var maKetHon = _itemKetHon[0];
            var hoTenChong = txtHoTenChong.Text;
            var ngaySinhChong = ngayChong + "/" + thangChong + "/" + namChong;
            var danTocChong = cbDanTocChong.Text;
            var queQuanChong = cbQueQuanChong.Text;
            var cmndChong = txtCMNDChong.Text;
            var thuongTamTruChong = txtThuongTamTruChong.Text;
            var hoTenVo = txtHoTenVo.Text;
            var ngaySinhVo = ngayVo + "/" + thangVo + "/" + namVo;
            var danTocVo = cbDanTocVo.Text;
            var queQuanVo = cbQueQuanVo.Text;
            var cmndVo = txtCMNDVo.Text;
            var thuongTamTruVo = txtThuongTamTruVo.Text;
            var khuVucDangKy = cbQueQuan.Text;
            var ngayDangKy = ngayDk + "/" + thangDk + "/" + namDk;

            if (!(maKetHon.Equals("")       || hoTenChong.Equals("")        || ngayChong.Equals("")         ||
                  thangChong.Equals("")     || namChong.Equals("")          || danTocChong.Equals("")       ||
                  queQuanChong.Equals("")   || cmndChong.Equals("")         || thuongTamTruChong.Equals("") ||
                  hoTenVo.Equals("")        || ngayVo.Equals("")            || thangVo.Equals("")           ||
                  namVo.Equals("")          || danTocVo.Equals("")          || queQuanVo.Equals("")         ||
                  cmndVo.Equals("")         || thuongTamTruVo.Equals("")    || khuVucDangKy.Equals("")      ||
                  ngayDk.Equals("")         || thangDk.Equals("")           || namDk.Equals("")))
            {
                var dialogResult = MessageBox.Show(_sourceCode.MsgboxUpdate, _sourceCode.MsgboxCapUpdate, MessageBoxButtons.YesNo);
                if (dialogResult != DialogResult.Yes) return;
                _flagSave = true;
                if (!_sourceCode.UpdateKetHon(maKetHon, hoTenChong, ngaySinhChong, danTocChong,
                    queQuanChong, thuongTamTruChong, cmndChong, hoTenVo,
                    ngaySinhVo, danTocVo, queQuanVo, thuongTamTruVo,
                    cmndVo, khuVucDangKy, ngayDangKy)) return;
                Close();
                MessageBox.Show(_sourceCode.SuccessUpdate);
            }
            else
            {
                MessageBox.Show(_sourceCode.ErrorBlank);
            }
        }

        private void SuaKetHon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_flagSave) return;
            var ngayChong = cbNgaySinhChong.Text;
            var thangChong = cbThangSinhChong.Text;
            var namChong = cbNamSinhChong.Text;
            var ngayVo = cbNgaySinhVo.Text;
            var thangVo = cbThangSinhVo.Text;
            var namVo = cbNamSinhVo.Text;
            var ngayDk = cbNgayDangKy.Text;
            var thangDk = cbThangDangKy.Text;
            var namDk = cbNamDangKy.Text;

            var maKetHon = _itemKetHon[0];
            var hoTenChong = txtHoTenChong.Text;
            var ngaySinhChong = ngayChong + "/" + thangChong + "/" + namChong;
            var danTocChong = cbDanTocChong.Text;
            var queQuanChong = cbQueQuanChong.Text;
            var cmndChong = txtCMNDChong.Text;
            var thuongTamTruChong = txtThuongTamTruChong.Text;
            var hoTenVo = txtHoTenVo.Text;
            var ngaySinhVo = ngayVo + "/" + thangVo + "/" + namVo;
            var danTocVo = cbDanTocVo.Text;
            var queQuanVo = cbQueQuanVo.Text;
            var cmndVo = txtCMNDVo.Text;
            var thuongTamTruVo = txtThuongTamTruVo.Text;
            var khuVucDangKy = cbQueQuan.Text;
            var ngayDangKy = ngayDk + "/" + thangDk + "/" + namDk;

            if ((!maKetHon.Equals(_itemKetHon[0])        || !hoTenChong.Equals(_itemKetHon[1])        ||
                 !ngaySinhChong.Equals(_itemKetHon[2])   || !danTocChong.Equals(_itemKetHon[3])       ||
                 !queQuanChong.Equals(_itemKetHon[4])    || !thuongTamTruChong.Equals(_itemKetHon[5]) ||
                 !cmndChong.Equals(_itemKetHon[6])       || !hoTenVo.Equals(_itemKetHon[7])           ||
                 !ngaySinhVo.Equals(_itemKetHon[8])      || !danTocVo.Equals(_itemKetHon[9])          ||
                 !queQuanVo.Equals(_itemKetHon[10])      || !thuongTamTruVo.Equals(_itemKetHon[11])   ||
                 !cmndVo.Equals(_itemKetHon[12])         || !khuVucDangKy.Equals(_itemKetHon[13])     ||
                 !ngayDangKy.Equals(_itemKetHon[14])))
            {
                DialogResult dialogResult = MessageBox.Show(_sourceCode.MsgboxUpdate,
                    _sourceCode.MsgboxCapExit,
                    MessageBoxButtons.YesNoCancel);
                if (dialogResult == DialogResult.Yes)
                {
                    if (!(maKetHon.Equals("")       || hoTenChong.Equals("")    || ngayChong.Equals("")         ||
                          thangChong.Equals("")     || namChong.Equals("")      || danTocChong.Equals("")       ||
                          queQuanChong.Equals("")   || cmndChong.Equals("")     || thuongTamTruChong.Equals("") ||
                          hoTenVo.Equals("")        || ngayVo.Equals("")        || thangVo.Equals("")           ||
                          namVo.Equals("")          || danTocVo.Equals("")      || queQuanVo.Equals("")         ||
                          cmndVo.Equals("")         || thuongTamTruVo.Equals("")|| khuVucDangKy.Equals("")      ||
                          ngayDk.Equals("")         || thangDk.Equals("")       || namDk.Equals("")))
                    {
                        if (_sourceCode.UpdateKetHon(maKetHon, hoTenChong, ngaySinhChong, danTocChong,
                            queQuanChong, thuongTamTruChong, cmndChong, hoTenVo,
                            ngaySinhVo, danTocVo, queQuanVo, thuongTamTruVo,
                            cmndVo, khuVucDangKy, ngayDangKy))
                        {
                            MessageBox.Show(_sourceCode.SuccessUpdate);
                        }
                    }
                    else
                    {
                        MessageBox.Show(_sourceCode.ErrorBlank);
                        e.Cancel = true;
                    }
                }
                else if (dialogResult == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
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
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == scMove)
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

        private void cbQueQuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Visible = cbQueQuan.Text != _itemKetHon[13];
        }

        private void cbNgayDangKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            var str = _itemKetHon[14].Split('/');
            label2.Visible = cbNgayDangKy.Text != str[0];
        }

        private void cbThangDangKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            var str = _itemKetHon[14].Split('/');
            label2.Visible = cbThangDangKy.Text != str[1];
        }

        private void cbNamDangKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(cbNamDangKy.Text.Equals("") || cbNamSinhChong.Text.Equals("")))
            {
                var test = Parse(cbNamDangKy.Text) - Parse(cbNamSinhChong.Text);
                if (test < 20 && test > 0)
                {
                    MessageBox.Show(@"Chưa đủ tuổi đăng ký kết hôn!");
                    cbNamDangKy.SelectedIndex = -1;
                }
                else if (test < 0)
                {
                    MessageBox.Show(@"Không hợp lệ!");
                    cbNamDangKy.SelectedIndex = -1;
                }
            }

            if (!(cbNamDangKy.Text.Equals("") || cbNamSinhVo.Text.Equals("")))
            {
                var test = Parse(cbNamDangKy.Text) - Parse(cbNamSinhVo.Text);
                if (test < 18 && test > 0)
                {
                    MessageBox.Show(@"Chưa đủ tuổi đăng ký kết hôn!");
                    cbNamDangKy.SelectedIndex = -1;
                }
                else if (test < 0)
                {
                    MessageBox.Show(@"Không hợp lệ!");
                    cbNamDangKy.SelectedIndex = -1;
                }
            }
            var str = _itemKetHon[14].Split('/');
            label2.Visible = cbNamDangKy.Text != str[2];
        }

        private void txtHoTenChong_TextChanged(object sender, EventArgs e)
        {
            label3.Visible = txtHoTenChong.Text != _itemKetHon[1];
        }

        private void cbNgaySinhChong_SelectedIndexChanged(object sender, EventArgs e)
        {
            var str = _itemKetHon[2].Split('/');
            label4.Visible = cbNgaySinhChong.Text != str[0];
        }

        private void cbThangSinhChong_SelectedIndexChanged(object sender, EventArgs e)
        {
            var str = _itemKetHon[2].Split('/');
            label4.Visible = cbThangSinhChong.Text != str[1];
        }

        private void cbNamSinhChong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(cbNamDangKy.Text.Equals("") || cbNamSinhChong.Text.Equals("")))
            {
                var test = Parse(cbNamDangKy.Text) - Parse(cbNamSinhChong.Text);
                if (test < 20 && test > 0)
                {
                    MessageBox.Show(@"Chưa đủ tuổi đăng ký kết hôn!");
                    cbNamSinhChong.SelectedIndex = -1;
                }
                else if (test < 0)
                {
                    MessageBox.Show(@"Không hợp lệ!");
                    cbNamSinhChong.SelectedIndex = -1;
                }
            }
            var str = _itemKetHon[2].Split('/');
            label4.Visible = cbNamSinhChong.Text != str[2];
        }

        private void cbDanTocChong_SelectedIndexChanged(object sender, EventArgs e)
        {
            label5.Visible = cbDanTocChong.Text != _itemKetHon[3];
        }

        private void txtCMNDChong_TextChanged(object sender, EventArgs e)
        {
            label7.Visible = txtCMNDChong.Text != _itemKetHon[6];
        }

        private void txtThuongTamTruChong_TextChanged(object sender, EventArgs e)
        {
            label8.Visible = txtThuongTamTruChong.Text != _itemKetHon[5];
        }

        private void txtHoTenVo_TextChanged(object sender, EventArgs e)
        {
            label9.Visible = txtHoTenVo.Text != _itemKetHon[7];
        }

        private void cbNgaySinhVo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var str = _itemKetHon[8].Split('/');
            label10.Visible = cbNgaySinhVo.Text != str[0];
        }

        private void cbThangSinhVo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var str = _itemKetHon[8].Split('/');
            label10.Visible = cbThangSinhVo.Text != str[1];
        }

        private void cbNamSinhVo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(cbNamDangKy.Text.Equals("") || cbNamSinhVo.Text.Equals("")))
            {
                var test = Parse(cbNamDangKy.Text) - Parse(cbNamSinhVo.Text);
                if (test < 18 && test > 0)
                {
                    MessageBox.Show(@"Chưa đủ tuổi đăng ký kết hôn!");
                    cbNamSinhVo.SelectedIndex = -1;
                }
                else if (test < 0)
                {
                    MessageBox.Show(@"Không hợp lệ!");
                    cbNamSinhVo.SelectedIndex = -1;
                }
            }
            var str = _itemKetHon[8].Split('/');
            label10.Visible = cbNamSinhVo.Text != str[2];
        }

        private void cbDanTocVo_SelectedIndexChanged(object sender, EventArgs e)
        {
            label11.Visible = cbDanTocVo.Text != _itemKetHon[9];
        }

        private void txtCMNDVo_TextChanged(object sender, EventArgs e)
        {
            label13.Visible = txtCMNDVo.Text != _itemKetHon[12];
        }

        private void txtThuongTamTruVo_TextChanged(object sender, EventArgs e)
        {
            label14.Visible = txtThuongTamTruVo.Text != _itemKetHon[11];
        }

        private void cbQueQuanChong_SelectedIndexChanged(object sender, EventArgs e)
        {
            label6.Visible = cbQueQuanChong.Text != _itemKetHon[4];
        }

        private void cbQueQuanVo_SelectedIndexChanged(object sender, EventArgs e)
        {
            label12.Visible = cbQueQuanVo.Text != _itemKetHon[10];
        }
    }
}
