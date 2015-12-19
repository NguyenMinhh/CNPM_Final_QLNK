using System;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace QLNK
{
    public partial class SuaTamTru : MaterialForm
    {
        SourceCode sc = new SourceCode();
        private string[] itemTamTru;
        private bool flagSave = false;
        public SuaTamTru(String[] itemTamTru)
        {
            InitializeComponent();
            this.itemTamTru = itemTamTru;
            setNormal(itemTamTru);
        }

        private void setNormalNoiTamTru(string items)
        {
            string[] str = items.Split(' ');
            string noiTamTru = str[0] + " " + str[1];
            switch (noiTamTru)
            {
                case "Nhà trọ": cbTamTru.SelectedIndex = 0; break;
                case "Nhà nghỉ": cbTamTru.SelectedIndex = 1; txtTenNoiTamTru.Visible = true; break;
                case "Nhà riêng": cbTamTru.SelectedIndex = 2; break;
                case "Khách sạn": cbTamTru.SelectedIndex = 3; txtTenNoiTamTru.Visible = true; break;
                case "Nhà người": cbTamTru.SelectedIndex = 4; break;
            }
            if (noiTamTru != "Nhà người")
            {
                txtTenNoiTamTru.Text = "";
                int strLength = str.Length;
                for (int i = 2; i < strLength; i++)
                {
                    txtTenNoiTamTru.Text += str[i];
                    if (strLength - i > 1)
                    {
                        txtTenNoiTamTru.Text += " ";
                    }
                }
            }
        }

        private void setNormal(string[] items)
        {
            txtMaNhanKhau.Text = items[1];
            setNormalNoiTamTru(items[2]);
            txtDiaChi.Text = items[3];
            txtSoDienThoai.Text = items[4];
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

        private void btnSuaTamTru_Click(object sender, EventArgs e)
        {
            int viTriTamTru = cbTamTru.SelectedIndex;
            string tamTru = cbTamTru.Text;
            string ngay = cbNgay.Text;
            string thang = cbThang.Text;
            string nam = cbNam.Text;
            string maTamTru = itemTamTru[0];
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
                  thang.Equals("")      || nam.Equals("")       || tamTru.Equals("")||
                  diaChi.Equals("")     || soDienThoai.Equals("")))
            {
                if (viTriTamTru == 1 || viTriTamTru == 3)
                {
                    if (!txtTenNoiTamTru.Text.Equals(""))
                    {
                        DialogResult dialogResult = MessageBox.Show(sc.MSGBOX_UPDATE, sc.MSGBOX_CAP_UPDATE, MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            flagSave = true;
                            if (sc.updateTamTru(maTamTru, maNhanKhau, tenNoiTamTru,
                                             diaChi, soDienThoai, thoiHan))
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
                    DialogResult dialogResult = MessageBox.Show(sc.MSGBOX_UPDATE, sc.MSGBOX_CAP_UPDATE, MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        flagSave = true;
                        if (sc.updateTamTru(maTamTru, maNhanKhau, tenNoiTamTru,
                                         diaChi, soDienThoai, thoiHan))
                        {
                            this.Close();
                            MessageBox.Show(sc.SUCCESS_UPDATE);
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


        private void SuaTamTru_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flagSave == false)
            {
                int viTriTamTru = cbTamTru.SelectedIndex;
                string tamTru = cbTamTru.Text;
                string ngay = cbNgay.Text;
                string thang = cbThang.Text;
                string nam = cbNam.Text;
                string maTamTru = itemTamTru[0];
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

                if ((!maTamTru.Equals(itemTamTru[0])    || !maNhanKhau.Equals(itemTamTru[1])||
                    !tenNoiTamTru.Equals(itemTamTru[2]) || !diaChi.Equals(itemTamTru[3])    ||
                    !soDienThoai.Equals(itemTamTru[4])  || !thoiHan.Equals(itemTamTru[5])))
                {
                    DialogResult dialogResult = MessageBox.Show(sc.MSGBOX_UPDATE,
                                            sc.MSGBOX_CAP_EXIT,
                                            MessageBoxButtons.YesNoCancel);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (!(maTamTru.Equals("")   || maNhanKhau.Equals("")|| ngay.Equals("")  ||
                              thang.Equals("")      || nam.Equals("")       || tamTru.Equals("")||
                              diaChi.Equals("")     || soDienThoai.Equals("")))
                        {
                            if (sc.updateTamTru(maTamTru, maNhanKhau, tenNoiTamTru,
                                                diaChi, soDienThoai, thoiHan))
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

        private void txtMaNhanKhau_TextChanged(object sender, EventArgs e)
        {
            if (txtMaNhanKhau.Text != itemTamTru[1])
            {
                label1.Visible = true;
            }
            else
            {
                label1.Visible = false;
            }
        }

        private void txtTenNoiTamTru_TextChanged(object sender, EventArgs e)
        {
            string[] str = itemTamTru[2].Split(' ');
            string temp = "";
            int strLength = str.Length;
            for (int i = 2; i < strLength; i++)
            {
                temp += str[i];
                if (strLength - i > 1)
                {
                    temp += " ";
                }
            }
            if (txtTenNoiTamTru.Text != temp)
            {
                label2.Visible = true;
            }
            else
            {
                label2.Visible = false;
            }
        }

        private void cbTamTru_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] str = itemTamTru[2].Split(' ');
            string noiTamTru = str[0] + " " + str[1];
            if (noiTamTru == "Nhà người")
            {
                if (cbTamTru.SelectedIndex != 4)
                {
                    label2.Visible = true;
                }
                else
                {
                    label2.Visible = false;
                }
            }
            else
            {
                if (cbTamTru.Text != noiTamTru)
                {
                    label2.Visible = true;
                }
                else
                {
                    label2.Visible = false;
                }
            }
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

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            if (txtDiaChi.Text != itemTamTru[3])
            {
                label3.Visible = true;
            }
            else
            {
                label3.Visible = false;
            }
        }

        private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            if (txtSoDienThoai.Text != itemTamTru[4])
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
            string[] str = itemTamTru[5].Split('/');
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
            string[] str = itemTamTru[5].Split('/');
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
            string[] str = itemTamTru[5].Split('/');
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
