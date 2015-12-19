using System;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace QLNK
{
    public partial class SuaChungTu : MaterialForm
    {
        SourceCode sc = new SourceCode();
        private string[] itemChungTu;
        private bool flagSave = false;
        public SuaChungTu(string[] itemChungTu)
        {
            InitializeComponent();
            this.itemChungTu = itemChungTu;
            setNormal(itemChungTu);
        }

        private void setNormal(string[] items)
        {
            txtNguoiKhai.Text = items[1];
            txtThuongTamTru.Text = items[2];
            switch (items[3])
            {
                case "Con": cbQuanHeVoiNguoiMat.SelectedIndex = 0; break;
                case "Cháu": cbQuanHeVoiNguoiMat.SelectedIndex = 1; break;
                case "Cha": cbQuanHeVoiNguoiMat.SelectedIndex = 2; break;
                case "Mẹ": cbQuanHeVoiNguoiMat.SelectedIndex = 3; break;
                case "Ông": cbQuanHeVoiNguoiMat.SelectedIndex = 4; break;
                case "Bà": cbQuanHeVoiNguoiMat.SelectedIndex = 5; break;
                case "Cô": cbQuanHeVoiNguoiMat.SelectedIndex = 6; break;
                case "Cậu": cbQuanHeVoiNguoiMat.SelectedIndex = 7; break;
                case "Chú": cbQuanHeVoiNguoiMat.SelectedIndex = 8; break;
                case "Bác": cbQuanHeVoiNguoiMat.SelectedIndex = 9; break;
                case "Dì": cbQuanHeVoiNguoiMat.SelectedIndex = 10; break;
            }
            txtTenNguoiMat.Text = items[4];
            string[] arr = items[5].Split('/');
            switch (arr[0])
            {
                case "01": cbNgaySinh.SelectedIndex = 0; break;
                case "02": cbNgaySinh.SelectedIndex = 1; break;
                case "03": cbNgaySinh.SelectedIndex = 2; break;
                case "04": cbNgaySinh.SelectedIndex = 3; break;
                case "05": cbNgaySinh.SelectedIndex = 4; break;
                case "06": cbNgaySinh.SelectedIndex = 5; break;
                case "07": cbNgaySinh.SelectedIndex = 6; break;
                case "08": cbNgaySinh.SelectedIndex = 7; break;
                case "09": cbNgaySinh.SelectedIndex = 8; break;
                case "10": cbNgaySinh.SelectedIndex = 9; break;
                case "11": cbNgaySinh.SelectedIndex = 10; break;
                case "12": cbNgaySinh.SelectedIndex = 11; break;
                case "13": cbNgaySinh.SelectedIndex = 12; break;
                case "14": cbNgaySinh.SelectedIndex = 13; break;
                case "15": cbNgaySinh.SelectedIndex = 14; break;
                case "16": cbNgaySinh.SelectedIndex = 15; break;
                case "17": cbNgaySinh.SelectedIndex = 16; break;
                case "18": cbNgaySinh.SelectedIndex = 17; break;
                case "19": cbNgaySinh.SelectedIndex = 18; break;
                case "20": cbNgaySinh.SelectedIndex = 19; break;
                case "21": cbNgaySinh.SelectedIndex = 20; break;
                case "22": cbNgaySinh.SelectedIndex = 21; break;
                case "23": cbNgaySinh.SelectedIndex = 22; break;
                case "24": cbNgaySinh.SelectedIndex = 23; break;
                case "25": cbNgaySinh.SelectedIndex = 24; break;
                case "26": cbNgaySinh.SelectedIndex = 25; break;
                case "27": cbNgaySinh.SelectedIndex = 26; break;
                case "28": cbNgaySinh.SelectedIndex = 27; break;
                case "29": cbNgaySinh.SelectedIndex = 28; break;
                case "30": cbNgaySinh.SelectedIndex = 29; break;
                case "31": cbNgaySinh.SelectedIndex = 30; break;
            }
            switch (arr[1])
            {
                case "01": cbThangSinh.SelectedIndex = 0; break;
                case "02": cbThangSinh.SelectedIndex = 1; break;
                case "03": cbThangSinh.SelectedIndex = 2; break;
                case "04": cbThangSinh.SelectedIndex = 3; break;
                case "05": cbThangSinh.SelectedIndex = 4; break;
                case "06": cbThangSinh.SelectedIndex = 5; break;
                case "07": cbThangSinh.SelectedIndex = 6; break;
                case "08": cbThangSinh.SelectedIndex = 7; break;
                case "09": cbThangSinh.SelectedIndex = 8; break;
                case "10": cbThangSinh.SelectedIndex = 9; break;
                case "11": cbThangSinh.SelectedIndex = 10; break;
                case "12": cbThangSinh.SelectedIndex = 11; break;
            }
            switch (arr[2])
            {
                case "1960": cbNamSinh.SelectedIndex = 0; break;
                case "1961": cbNamSinh.SelectedIndex = 1; break;
                case "1962": cbNamSinh.SelectedIndex = 2; break;
                case "1963": cbNamSinh.SelectedIndex = 3; break;
                case "1964": cbNamSinh.SelectedIndex = 4; break;
                case "1965": cbNamSinh.SelectedIndex = 5; break;
                case "1966": cbNamSinh.SelectedIndex = 6; break;
                case "1967": cbNamSinh.SelectedIndex = 7; break;
                case "1968": cbNamSinh.SelectedIndex = 8; break;
                case "1969": cbNamSinh.SelectedIndex = 9; break;
                case "1970": cbNamSinh.SelectedIndex = 10; break;
                case "1971": cbNamSinh.SelectedIndex = 11; break;
                case "1972": cbNamSinh.SelectedIndex = 12; break;
                case "1973": cbNamSinh.SelectedIndex = 13; break;
                case "1974": cbNamSinh.SelectedIndex = 14; break;
                case "1975": cbNamSinh.SelectedIndex = 15; break;
                case "1976": cbNamSinh.SelectedIndex = 16; break;
                case "1977": cbNamSinh.SelectedIndex = 17; break;
                case "1978": cbNamSinh.SelectedIndex = 18; break;
                case "1979": cbNamSinh.SelectedIndex = 19; break;
                case "1980": cbNamSinh.SelectedIndex = 20; break;
                case "1981": cbNamSinh.SelectedIndex = 21; break;
                case "1982": cbNamSinh.SelectedIndex = 22; break;
                case "1983": cbNamSinh.SelectedIndex = 23; break;
                case "1984": cbNamSinh.SelectedIndex = 24; break;
                case "1985": cbNamSinh.SelectedIndex = 25; break;
                case "1986": cbNamSinh.SelectedIndex = 26; break;
                case "1987": cbNamSinh.SelectedIndex = 27; break;
                case "1988": cbNamSinh.SelectedIndex = 28; break;
                case "1989": cbNamSinh.SelectedIndex = 29; break;
                case "1990": cbNamSinh.SelectedIndex = 30; break;
                case "1991": cbNamSinh.SelectedIndex = 31; break;
                case "1992": cbNamSinh.SelectedIndex = 32; break;
                case "1993": cbNamSinh.SelectedIndex = 33; break;
                case "1994": cbNamSinh.SelectedIndex = 34; break;
                case "1995": cbNamSinh.SelectedIndex = 35; break;
                case "1996": cbNamSinh.SelectedIndex = 36; break;
                case "1997": cbNamSinh.SelectedIndex = 37; break;
                case "1998": cbNamSinh.SelectedIndex = 38; break;
                case "1999": cbNamSinh.SelectedIndex = 39; break;
                case "2000": cbNamSinh.SelectedIndex = 40; break;
                case "2001": cbNamSinh.SelectedIndex = 41; break;
                case "2002": cbNamSinh.SelectedIndex = 42; break;
                case "2003": cbNamSinh.SelectedIndex = 43; break;
                case "2004": cbNamSinh.SelectedIndex = 44; break;
                case "2005": cbNamSinh.SelectedIndex = 45; break;
                case "2006": cbNamSinh.SelectedIndex = 46; break;
                case "2007": cbNamSinh.SelectedIndex = 47; break;
                case "2008": cbNamSinh.SelectedIndex = 48; break;
                case "2009": cbNamSinh.SelectedIndex = 49; break;
                case "2010": cbNamSinh.SelectedIndex = 50; break;
                case "2011": cbNamSinh.SelectedIndex = 51; break;
                case "2012": cbNamSinh.SelectedIndex = 52; break;
                case "2013": cbNamSinh.SelectedIndex = 53; break;
                case "2014": cbNamSinh.SelectedIndex = 54; break;
                case "2015": cbNamSinh.SelectedIndex = 55; break;
            }
            switch (items[6])
            {
                case "": cbDanToc.SelectedIndex = -1; cbDanToc.Enabled = false; lblDanToc.Enabled = false; break;
                case "Kinh": cbDanToc.SelectedIndex = 0; break;
                case "Tày": cbDanToc.SelectedIndex = 1; break;
                case "Thái": cbDanToc.SelectedIndex = 2; break;
                case "Mường": cbDanToc.SelectedIndex = 3; break;
                case "Khơ Me": cbDanToc.SelectedIndex = 4; break;
                case "HMông": cbDanToc.SelectedIndex = 5; break;
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
                case "MNông": cbDanToc.SelectedIndex = 19; break;
                case "XTiêng": cbDanToc.SelectedIndex = 20; break;
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
            switch (items[7])
            {
                case "Afghanistan": cbQuocTich.SelectedIndex = 0; break;
                case "Akrotiri và Dhekelia": cbQuocTich.SelectedIndex = 1; break;
                case "Ả Rập Saudi": cbQuocTich.SelectedIndex = 2; break;
                case "Armenia": cbQuocTich.SelectedIndex = 3; break;
                case "Azerbaijan": cbQuocTich.SelectedIndex = 4; break;
                case "Ấn Độ": cbQuocTich.SelectedIndex = 5; break;
                case "Bahrain": cbQuocTich.SelectedIndex = 6; break;
                case "Bangladesh": cbQuocTich.SelectedIndex = 7; break;
                case "Bhutan": cbQuocTich.SelectedIndex = 8; break;
                case "Brunei": cbQuocTich.SelectedIndex = 9; break;
                case "Campuchia": cbQuocTich.SelectedIndex = 10; break;
                case "Đài Loan": cbQuocTich.SelectedIndex = 11; break;
                case "Georgia": cbQuocTich.SelectedIndex = 12; break;
                case "Hồng Kông": cbQuocTich.SelectedIndex = 13; break;
                case "Indonesia": cbQuocTich.SelectedIndex = 14; break;
                case "Iran": cbQuocTich.SelectedIndex = 15; break;
                case "Iraq": cbQuocTich.SelectedIndex = 16; break;
                case "Israel": cbQuocTich.SelectedIndex = 17; break;
                case "Jordan": cbQuocTich.SelectedIndex = 18; break;
                case "Kazakhstan": cbQuocTich.SelectedIndex = 19; break;
                case "Kuwait": cbQuocTich.SelectedIndex = 20; break;
                case "Kyrgyzstan": cbQuocTich.SelectedIndex = 21; break;
                case "Lào": cbQuocTich.SelectedIndex = 22; break;
                case "Liban": cbQuocTich.SelectedIndex = 23; break;
                case "Ma Cao": cbQuocTich.SelectedIndex = 24; break;
                case "Malaysia": cbQuocTich.SelectedIndex = 25; break;
                case "Kuala Lumpur": cbQuocTich.SelectedIndex = 26; break;
                case "Maldives": cbQuocTich.SelectedIndex = 27; break;
                case "Mông Cổ": cbQuocTich.SelectedIndex = 28; break;
                case "Myanma": cbQuocTich.SelectedIndex = 29; break;
                case "Nagorno-Karabakh": cbQuocTich.SelectedIndex = 30; break;
                case "Nepal": cbQuocTich.SelectedIndex = 31; break;
                case "Nga": cbQuocTich.SelectedIndex = 32; break;
                case "Nhật Bản": cbQuocTich.SelectedIndex = 33; break;
                case "Oman": cbQuocTich.SelectedIndex = 34; break;
                case "Pakistan": cbQuocTich.SelectedIndex = 35; break;
                case "Palestine": cbQuocTich.SelectedIndex = 36; break;
                case "Philippines": cbQuocTich.SelectedIndex = 37; break;
                case "Qatar": cbQuocTich.SelectedIndex = 38; break;
                case "Singapore": cbQuocTich.SelectedIndex = 39; break;
                case "Bắc Síp": cbQuocTich.SelectedIndex = 40; break;
                case "Síp": cbQuocTich.SelectedIndex = 41; break;
                case "Sri Lanka": cbQuocTich.SelectedIndex = 42; break;
                case "Syria": cbQuocTich.SelectedIndex = 43; break;
                case "Tajikistan": cbQuocTich.SelectedIndex = 44; break;
                case "Thái Lan": cbQuocTich.SelectedIndex = 45; break;
                case "Đông Timor": cbQuocTich.SelectedIndex = 46; break;
                case "Thổ Nhĩ Kỳ": cbQuocTich.SelectedIndex = 47; break;
                case "Triều Tiên": cbQuocTich.SelectedIndex = 48; break;
                case "Hàn Quốc": cbQuocTich.SelectedIndex = 49; break;
                case "Trung Quốc": cbQuocTich.SelectedIndex = 50; break;
                case "Turkmenistan": cbQuocTich.SelectedIndex = 51; break;
                case "Uzbekistan": cbQuocTich.SelectedIndex = 52; break;
                case "Việt Nam": cbQuocTich.SelectedIndex = 53; break;
                case "Yemen": cbQuocTich.SelectedIndex = 54; break;
            }
            if (items[8].Equals(""))
            {
                lblCMND.Enabled = false;
                txtCMND.Enabled = false;
            }
            else
            {
                txtCMND.Text = items[8];
            }
            string[] arr2 = items[9].Split('/');
            switch (arr2[0])
            {
                case "01": cbNgayMat.SelectedIndex = 0; break;
                case "02": cbNgayMat.SelectedIndex = 1; break;
                case "03": cbNgayMat.SelectedIndex = 2; break;
                case "04": cbNgayMat.SelectedIndex = 3; break;
                case "05": cbNgayMat.SelectedIndex = 4; break;
                case "06": cbNgayMat.SelectedIndex = 5; break;
                case "07": cbNgayMat.SelectedIndex = 6; break;
                case "08": cbNgayMat.SelectedIndex = 7; break;
                case "09": cbNgayMat.SelectedIndex = 8; break;
                case "10": cbNgayMat.SelectedIndex = 9; break;
                case "11": cbNgayMat.SelectedIndex = 10; break;
                case "12": cbNgayMat.SelectedIndex = 11; break;
                case "13": cbNgayMat.SelectedIndex = 12; break;
                case "14": cbNgayMat.SelectedIndex = 13; break;
                case "15": cbNgayMat.SelectedIndex = 14; break;
                case "16": cbNgayMat.SelectedIndex = 15; break;
                case "17": cbNgayMat.SelectedIndex = 16; break;
                case "18": cbNgayMat.SelectedIndex = 17; break;
                case "19": cbNgayMat.SelectedIndex = 18; break;
                case "20": cbNgayMat.SelectedIndex = 19; break;
                case "21": cbNgayMat.SelectedIndex = 20; break;
                case "22": cbNgayMat.SelectedIndex = 21; break;
                case "23": cbNgayMat.SelectedIndex = 22; break;
                case "24": cbNgayMat.SelectedIndex = 23; break;
                case "25": cbNgayMat.SelectedIndex = 24; break;
                case "26": cbNgayMat.SelectedIndex = 25; break;
                case "27": cbNgayMat.SelectedIndex = 26; break;
                case "28": cbNgayMat.SelectedIndex = 27; break;
                case "29": cbNgayMat.SelectedIndex = 28; break;
                case "30": cbNgayMat.SelectedIndex = 29; break;
                case "31": cbNgayMat.SelectedIndex = 30; break;
            }
            switch (arr2[1])
            {
                case "01": cbThangMat.SelectedIndex = 0; break;
                case "02": cbThangMat.SelectedIndex = 1; break;
                case "03": cbThangMat.SelectedIndex = 2; break;
                case "04": cbThangMat.SelectedIndex = 3; break;
                case "05": cbThangMat.SelectedIndex = 4; break;
                case "06": cbThangMat.SelectedIndex = 5; break;
                case "07": cbThangMat.SelectedIndex = 6; break;
                case "08": cbThangMat.SelectedIndex = 7; break;
                case "09": cbThangMat.SelectedIndex = 8; break;
                case "10": cbThangMat.SelectedIndex = 9; break;
                case "11": cbThangMat.SelectedIndex = 10; break;
                case "12": cbThangMat.SelectedIndex = 11; break;
            }
            switch (arr2[2])
            {
                case "1960": cbNamMat.SelectedIndex = 0; break;
                case "1961": cbNamMat.SelectedIndex = 1; break;
                case "1962": cbNamMat.SelectedIndex = 2; break;
                case "1963": cbNamMat.SelectedIndex = 3; break;
                case "1964": cbNamMat.SelectedIndex = 4; break;
                case "1965": cbNamMat.SelectedIndex = 5; break;
                case "1966": cbNamMat.SelectedIndex = 6; break;
                case "1967": cbNamMat.SelectedIndex = 7; break;
                case "1968": cbNamMat.SelectedIndex = 8; break;
                case "1969": cbNamMat.SelectedIndex = 9; break;
                case "1970": cbNamMat.SelectedIndex = 10; break;
                case "1971": cbNamMat.SelectedIndex = 11; break;
                case "1972": cbNamMat.SelectedIndex = 12; break;
                case "1973": cbNamMat.SelectedIndex = 13; break;
                case "1974": cbNamMat.SelectedIndex = 14; break;
                case "1975": cbNamMat.SelectedIndex = 15; break;
                case "1976": cbNamMat.SelectedIndex = 16; break;
                case "1977": cbNamMat.SelectedIndex = 17; break;
                case "1978": cbNamMat.SelectedIndex = 18; break;
                case "1979": cbNamMat.SelectedIndex = 19; break;
                case "1980": cbNamMat.SelectedIndex = 20; break;
                case "1981": cbNamMat.SelectedIndex = 21; break;
                case "1982": cbNamMat.SelectedIndex = 22; break;
                case "1983": cbNamMat.SelectedIndex = 23; break;
                case "1984": cbNamMat.SelectedIndex = 24; break;
                case "1985": cbNamMat.SelectedIndex = 25; break;
                case "1986": cbNamMat.SelectedIndex = 26; break;
                case "1987": cbNamMat.SelectedIndex = 27; break;
                case "1988": cbNamMat.SelectedIndex = 28; break;
                case "1989": cbNamMat.SelectedIndex = 29; break;
                case "1990": cbNamMat.SelectedIndex = 30; break;
                case "1991": cbNamMat.SelectedIndex = 31; break;
                case "1992": cbNamMat.SelectedIndex = 32; break;
                case "1993": cbNamMat.SelectedIndex = 33; break;
                case "1994": cbNamMat.SelectedIndex = 34; break;
                case "1995": cbNamMat.SelectedIndex = 35; break;
                case "1996": cbNamMat.SelectedIndex = 36; break;
                case "1997": cbNamMat.SelectedIndex = 37; break;
                case "1998": cbNamMat.SelectedIndex = 38; break;
                case "1999": cbNamMat.SelectedIndex = 39; break;
                case "2000": cbNamMat.SelectedIndex = 40; break;
                case "2001": cbNamMat.SelectedIndex = 41; break;
                case "2002": cbNamMat.SelectedIndex = 42; break;
                case "2003": cbNamMat.SelectedIndex = 43; break;
                case "2004": cbNamMat.SelectedIndex = 44; break;
                case "2005": cbNamMat.SelectedIndex = 45; break;
                case "2006": cbNamMat.SelectedIndex = 46; break;
                case "2007": cbNamMat.SelectedIndex = 47; break;
                case "2008": cbNamMat.SelectedIndex = 48; break;
                case "2009": cbNamMat.SelectedIndex = 49; break;
                case "2010": cbNamMat.SelectedIndex = 50; break;
                case "2011": cbNamMat.SelectedIndex = 51; break;
                case "2012": cbNamMat.SelectedIndex = 52; break;
                case "2013": cbNamMat.SelectedIndex = 53; break;
                case "2014": cbNamMat.SelectedIndex = 54; break;
                case "2015": cbNamMat.SelectedIndex = 55; break;
            }
            string[] arr3 = items[10].Split(':');
            switch (arr3[0])
            {
                case "00": cbGio.SelectedIndex = 0; break;
                case "01": cbGio.SelectedIndex = 1; break;
                case "02": cbGio.SelectedIndex = 2; break;
                case "03": cbGio.SelectedIndex = 3; break;
                case "04": cbGio.SelectedIndex = 4; break;
                case "05": cbGio.SelectedIndex = 5; break;
                case "06": cbGio.SelectedIndex = 6; break;
                case "07": cbGio.SelectedIndex = 7; break;
                case "08": cbGio.SelectedIndex = 8; break;
                case "09": cbGio.SelectedIndex = 9; break;
                case "10": cbGio.SelectedIndex = 10; break;
                case "11": cbGio.SelectedIndex = 11; break;
                case "12": cbGio.SelectedIndex = 12; break;
                case "13": cbGio.SelectedIndex = 13; break;
                case "14": cbGio.SelectedIndex = 14; break;
                case "15": cbGio.SelectedIndex = 15; break;
                case "16": cbGio.SelectedIndex = 16; break;
                case "17": cbGio.SelectedIndex = 17; break;
                case "18": cbGio.SelectedIndex = 18; break;
                case "19": cbGio.SelectedIndex = 19; break;
                case "20": cbGio.SelectedIndex = 20; break;
                case "21": cbGio.SelectedIndex = 21; break;
                case "22": cbGio.SelectedIndex = 22; break;
                case "23": cbGio.SelectedIndex = 23; break;
            }
            switch (arr3[1])
            {
                case "00": cbPhut.SelectedIndex = 0; break;
                case "01": cbPhut.SelectedIndex = 1; break;
                case "02": cbPhut.SelectedIndex = 2; break;
                case "03": cbPhut.SelectedIndex = 3; break;
                case "04": cbPhut.SelectedIndex = 4; break;
                case "05": cbPhut.SelectedIndex = 5; break;
                case "06": cbPhut.SelectedIndex = 6; break;
                case "07": cbPhut.SelectedIndex = 7; break;
                case "08": cbPhut.SelectedIndex = 8; break;
                case "09": cbPhut.SelectedIndex = 9; break;
                case "10": cbPhut.SelectedIndex = 10; break;
                case "11": cbPhut.SelectedIndex = 11; break;
                case "12": cbPhut.SelectedIndex = 12; break;
                case "13": cbPhut.SelectedIndex = 13; break;
                case "14": cbPhut.SelectedIndex = 14; break;
                case "15": cbPhut.SelectedIndex = 15; break;
                case "16": cbPhut.SelectedIndex = 16; break;
                case "17": cbPhut.SelectedIndex = 17; break;
                case "18": cbPhut.SelectedIndex = 18; break;
                case "19": cbPhut.SelectedIndex = 19; break;
                case "20": cbPhut.SelectedIndex = 20; break;
                case "21": cbPhut.SelectedIndex = 21; break;
                case "22": cbPhut.SelectedIndex = 22; break;
                case "23": cbPhut.SelectedIndex = 23; break;
                case "24": cbPhut.SelectedIndex = 24; break;
                case "25": cbPhut.SelectedIndex = 25; break;
                case "26": cbPhut.SelectedIndex = 26; break;
                case "27": cbPhut.SelectedIndex = 27; break;
                case "28": cbPhut.SelectedIndex = 28; break;
                case "29": cbPhut.SelectedIndex = 29; break;
                case "30": cbPhut.SelectedIndex = 30; break;
                case "31": cbPhut.SelectedIndex = 31; break;
                case "32": cbPhut.SelectedIndex = 32; break;
                case "33": cbPhut.SelectedIndex = 33; break;
                case "34": cbPhut.SelectedIndex = 34; break;
                case "35": cbPhut.SelectedIndex = 35; break;
                case "36": cbPhut.SelectedIndex = 36; break;
                case "37": cbPhut.SelectedIndex = 37; break;
                case "38": cbPhut.SelectedIndex = 38; break;
                case "39": cbPhut.SelectedIndex = 39; break;
                case "40": cbPhut.SelectedIndex = 40; break;
                case "41": cbPhut.SelectedIndex = 41; break;
                case "42": cbPhut.SelectedIndex = 42; break;
                case "43": cbPhut.SelectedIndex = 43; break;
                case "44": cbPhut.SelectedIndex = 44; break;
                case "45": cbPhut.SelectedIndex = 45; break;
                case "46": cbPhut.SelectedIndex = 46; break;
                case "47": cbPhut.SelectedIndex = 47; break;
                case "48": cbPhut.SelectedIndex = 48; break;
                case "49": cbPhut.SelectedIndex = 49; break;
                case "50": cbPhut.SelectedIndex = 50; break;
                case "51": cbPhut.SelectedIndex = 51; break;
                case "52": cbPhut.SelectedIndex = 52; break;
                case "53": cbPhut.SelectedIndex = 53; break;
                case "54": cbPhut.SelectedIndex = 54; break;
                case "55": cbPhut.SelectedIndex = 55; break;
                case "56": cbPhut.SelectedIndex = 56; break;
                case "57": cbPhut.SelectedIndex = 57; break;
                case "58": cbPhut.SelectedIndex = 58; break;
                case "59": cbPhut.SelectedIndex = 59; break;
            }
            switch (items[11])
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
            string[] arr4 = items[12].Split('/');
            switch (arr4[0])
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
            switch (arr4[1])
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
            switch (arr4[2])
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

        private void btnSuaChungTu_Click(object sender, EventArgs e)
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

            string maChungTu = itemChungTu[0];
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
                            DialogResult dialogResult = MessageBox.Show(sc.MSGBOX_UPDATE, sc.MSGBOX_CAP_UPDATE, MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                flagSave = true;
                                if (sc.updateChungTu(maChungTu, tenNguoiKhai, thuongTamTru, qhVoiNguoiMat,
                                                  tenNguoiMat, ngaySinhNguoiMat, danToc, quocTich, cmnd,
                                                  ngayQuaDoi, thoiGianQuaDoi, khuVucDangKy, ngayDangKy))
                                {
                                    this.Close();
                                    MessageBox.Show(sc.SUCCESS_UPDATE);
                                }
                            }
                        }
                        else
                        {
                            if (!danToc.Equals(""))
                            {
                                DialogResult dialogResult = MessageBox.Show(sc.MSGBOX_UPDATE, sc.MSGBOX_CAP_UPDATE, MessageBoxButtons.YesNo);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    flagSave = true;
                                    if (sc.updateChungTu(maChungTu, tenNguoiKhai, thuongTamTru, qhVoiNguoiMat,
                                                      tenNguoiMat, ngaySinhNguoiMat, danToc, quocTich, cmnd,
                                                      ngayQuaDoi, thoiGianQuaDoi, khuVucDangKy, ngayDangKy))
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
                    }
                    else
                    {
                        if (cbDanToc.Enabled == false)
                        {
                            danToc = "";
                            if (!cmnd.Equals(""))
                            {
                                DialogResult dialogResult = MessageBox.Show(sc.MSGBOX_UPDATE, sc.MSGBOX_CAP_UPDATE, MessageBoxButtons.YesNo);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    flagSave = true;
                                    if (sc.updateChungTu(maChungTu, tenNguoiKhai, thuongTamTru, qhVoiNguoiMat,
                                                      tenNguoiMat, ngaySinhNguoiMat, danToc, quocTich, cmnd,
                                                      ngayQuaDoi, thoiGianQuaDoi, khuVucDangKy, ngayDangKy))
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
                        else
                        {
                            if (!(cmnd.Equals("") || danToc.Equals("")))
                            {
                                DialogResult dialogResult = MessageBox.Show(sc.MSGBOX_UPDATE, sc.MSGBOX_CAP_UPDATE, MessageBoxButtons.YesNo);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    flagSave = true;
                                    if (sc.updateChungTu(maChungTu, tenNguoiKhai, thuongTamTru, qhVoiNguoiMat,
                                                      tenNguoiMat, ngaySinhNguoiMat, danToc, quocTich, cmnd,
                                                      ngayQuaDoi, thoiGianQuaDoi, khuVucDangKy, ngayDangKy))
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
                    }
                
            }
            else
            {
                MessageBox.Show(sc.ERROR_BLANK);
            }
        }

        private void SuaChungTu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flagSave == false)
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

                string maChungTu = itemChungTu[0];
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

                if ((!maChungTu.Equals(itemChungTu[0])      || !tenNguoiKhai.Equals(itemChungTu[1])     ||
                     !thuongTamTru.Equals(itemChungTu[2])   || !qhVoiNguoiMat.Equals(itemChungTu[3])    ||
                     !tenNguoiMat.Equals(itemChungTu[4])    || !ngaySinhNguoiMat.Equals(itemChungTu[5]) ||
                     !danToc.Equals(itemChungTu[6])         || !quocTich.Equals(itemChungTu[7])         ||
                     !cmnd.Equals(itemChungTu[8])           || !ngayQuaDoi.Equals(itemChungTu[9])       ||
                     !thoiGianQuaDoi.Equals(itemChungTu[10])|| !khuVucDangKy.Equals(itemChungTu[11])    ||
                     !ngayDangKy.Equals(itemChungTu[12])))
                {
                    DialogResult dialogResult = MessageBox.Show(sc.MSGBOX_UPDATE,
                                                                sc.MSGBOX_CAP_EXIT,
                                                                MessageBoxButtons.YesNoCancel);
                    if (dialogResult == DialogResult.Yes)
                    {
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
                                    if (sc.updateChungTu(maChungTu, tenNguoiKhai, thuongTamTru, qhVoiNguoiMat,
                                                      tenNguoiMat, ngaySinhNguoiMat, danToc, quocTich, cmnd,
                                                      ngayQuaDoi, thoiGianQuaDoi, khuVucDangKy, ngayDangKy))
                                    {
                                        MessageBox.Show(sc.SUCCESS_UPDATE);
                                    }
                                }
                                else
                                {
                                    if (!danToc.Equals(""))
                                    {
                                        if (sc.updateChungTu(maChungTu, tenNguoiKhai, thuongTamTru, qhVoiNguoiMat,
                                                          tenNguoiMat, ngaySinhNguoiMat, danToc, quocTich, cmnd,
                                                          ngayQuaDoi, thoiGianQuaDoi, khuVucDangKy, ngayDangKy))
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
                            }
                            else
                            {
                                if (cbDanToc.Enabled == false)
                                {
                                    danToc = "";
                                    if (!cmnd.Equals(""))
                                    {
                                        if (sc.updateChungTu(maChungTu, tenNguoiKhai, thuongTamTru, qhVoiNguoiMat,
                                                          tenNguoiMat, ngaySinhNguoiMat, danToc, quocTich, cmnd,
                                                          ngayQuaDoi, thoiGianQuaDoi, khuVucDangKy, ngayDangKy))
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
                                else
                                {
                                    if (!(cmnd.Equals("") || danToc.Equals("")))
                                    {
                                        if (sc.updateChungTu(maChungTu, tenNguoiKhai, thuongTamTru, qhVoiNguoiMat,
                                                          tenNguoiMat, ngaySinhNguoiMat, danToc, quocTich, cmnd,
                                                          ngayQuaDoi, thoiGianQuaDoi, khuVucDangKy, ngayDangKy))
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

        private void txtNguoiKhai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtTenNguoiMat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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

        private void cbNgayDangKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] str = itemChungTu[12].Split('/');
            if (cbNgayDangKy.Text != str[0])
            {
                label5.Visible = true;
            }
            else
            {
                label5.Visible = false;
            }
            detectNamDangKyVaNamSinh(3);
            detectNamDangKyVaNamMat(3);
        }

        private void cbThangDangKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] str = itemChungTu[12].Split('/');
            if (cbThangDangKy.Text != str[1])
            {
                label5.Visible = true;
            }
            else
            {
                label5.Visible = false;
            }
            detectNamDangKyVaNamSinh(2);
            detectNamDangKyVaNamMat(2);
        }

        private void cbNamDangKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] str = itemChungTu[12].Split('/');
            if (cbNamDangKy.Text != str[2])
            {
                label5.Visible = true;
            }
            else
            {
                label5.Visible = false;
            }
            detectNamDangKyVaNamSinh(1);
            detectNamDangKyVaNamMat(1);
        }

        private void cbNgaySinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] str = itemChungTu[5].Split('/');
            if (cbNgaySinh.Text != str[0])
            {
                label7.Visible = true;
            }
            else
            {
                label7.Visible = false;
            }
            detectNamDangKyVaNamSinh(6);
            detectNamMatVaNamSinh(6);
        }

        private void cbThangSinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] str = itemChungTu[5].Split('/');
            if (cbThangSinh.Text != str[1])
            {
                label7.Visible = true;
            }
            else
            {
                label7.Visible = false;
            }
            detectNamDangKyVaNamSinh(5);
            detectNamMatVaNamSinh(5);
        }

        private void cbNamSinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] str = itemChungTu[5].Split('/');
            if (cbNamSinh.Text != str[2])
            {
                label7.Visible = true;
            }
            else
            {
                label7.Visible = false;
            }
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
            string[] str = itemChungTu[9].Split('/');
            if (cbNgayMat.Text != str[0])
            {
                label11.Visible = true;
            }
            else
            {
                label11.Visible = false;
            }
            detectNamDangKyVaNamMat(6);
            detectNamMatVaNamSinh(3);
        }

        private void cbThangMat_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] str = itemChungTu[9].Split('/');
            if (cbThangMat.Text != str[1])
            {
                label11.Visible = true;
            }
            else
            {
                label11.Visible = false;
            }
            detectNamDangKyVaNamMat(5);
            detectNamMatVaNamSinh(2);
        }

        private void cbNamMat_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] str = itemChungTu[9].Split('/');
            if (cbNamMat.Text != str[2])
            {
                label11.Visible = true;
            }
            else
            {
                label11.Visible = false;
            }
            detectNamDangKyVaNamMat(4);
            detectNamMatVaNamSinh(1);
        }

        private void cbQuocTich_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbQuocTich.Text != itemChungTu[7])
            {
                label9.Visible = true;
            }
            else
            {
                label9.Visible = false;
            }
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

        private void txtNguoiKhai_TextChanged(object sender, EventArgs e)
        {
            if (txtNguoiKhai.Text != itemChungTu[1])
            {
                label2.Visible = true;
            }
            else
            {
                label2.Visible = false;
            }
        }

        private void txtThuongTamTru_TextChanged(object sender, EventArgs e)
        {
            if (txtThuongTamTru.Text != itemChungTu[2])
            {
                label3.Visible = true;
            }
            else
            {
                label3.Visible = false;
            }
        }

        private void cbQuanHeVoiNguoiMat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbQuanHeVoiNguoiMat.Text != itemChungTu[3])
            {
                label1.Visible = true;
            }
            else
            {
                label1.Visible = false;
            }
        }

        private void cbQueQuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbQueQuan.Text != itemChungTu[11])
            {
                label4.Visible = true;
            }
            else
            {
                label4.Visible = false;
            }
        }

        private void txtTenNguoiMat_TextChanged(object sender, EventArgs e)
        {
            if (txtTenNguoiMat.Text != itemChungTu[4])
            {
                label6.Visible = true;
            }
            else
            {
                label6.Visible = false;
            }
        }

        private void cbDanToc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDanToc.Text != itemChungTu[6])
            {
                label8.Visible = true;
            }
            else
            {
                label8.Visible = false;
            }
        }

        private void txtCMND_TextChanged(object sender, EventArgs e)
        {
            if (txtCMND.Text != itemChungTu[8])
            {
                label10.Visible = true;
            }
            else
            {
                label10.Visible = false;
            }
        }

        private void cbGio_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] str = itemChungTu[10].Split(':');
            if (cbGio.Text != str[0])
            {
                label12.Visible = true;
            }
            else
            {
                label12.Visible = false;
            }
        }

        private void cbPhut_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] str = itemChungTu[10].Split(':');
            if (cbPhut.Text != str[1])
            {
                label12.Visible = true;
            }
            else
            {
                label12.Visible = false;
            }
        }

    }
}
