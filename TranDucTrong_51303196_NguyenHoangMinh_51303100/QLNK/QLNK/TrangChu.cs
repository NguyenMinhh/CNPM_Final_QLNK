using System;
using MaterialSkin.Controls;
using System.Windows.Forms;
using MaterialSkin;

namespace QLNK
{
    public partial class TrangChu : MaterialForm
    {
        SourceCode sc = new SourceCode();
        private readonly MaterialSkinManager materialSkinManager;
        private int colorSchemeIndex;
        private int textColorSchemeIndex;
        private string[] itemNhanKhau = new string[10];
        private string[] itemHoKhau = new string[6];
        private string[] itemTamTru = new string[6];
        private string[] itemChungTu = new string[13];
        private string[] itemKetHon = new string[15];
        private string[] itemTienAnTienSu = new string[5];
        private string[] itemTaiKhoan = new string[4];
        private Boolean flagNhanKhau = false;
        private Boolean flagHoKhau = false;
        private Boolean flagTamTru = false;
        private Boolean flagKetHon = false;
        private Boolean flagTienAnTienSu = false;
        private Boolean flagChungTu = false;
        private Boolean flagTaiKhoan = false;
        private bool logOut = false;

        public TrangChu(string phanQuyen, string nguoiSuDung)
        {
            InitializeComponent();
            lblUserName.Text = nguoiSuDung;
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            changeColor();
            setAuthorities(phanQuyen);
        }

        //----------------------------------------------------------------------BTN CHÍNH
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Đăng xuất tài khoản ?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                logOut = true;
                this.Close();
            }
        }

        private void btnPhanQuyen_Click(object sender, EventArgs e)
        {
            if (listView7.SelectedIndices.Count > 0)
            {
                this.Hide();
                PhanQuyenTaiKhoan f3 = new PhanQuyenTaiKhoan(itemTaiKhoan);
                f3.ShowDialog();
                sc.displayTaiKhoan(listView7);
                this.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần phân quyền!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (this.tabPage1.Focus())
            {
                if (listView1.SelectedIndices.Count > 0)
                {
                    this.Hide();
                    SuaNhanKhau f3 = new SuaNhanKhau(itemNhanKhau);
                    f3.ShowDialog();
                    sc.displayNhanKhau(listView1);
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn thông tin nhân khẩu cần chỉnh sửa!");
                }
            }
            else if (this.tabPage2.Focus())
            {
                if (listView2.SelectedIndices.Count > 0)
                {
                    this.Hide();
                    SuaHoKhau f3 = new SuaHoKhau(itemHoKhau);
                    f3.ShowDialog();
                    sc.displayHoKhau(listView2);
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn thông tin hộ khẩu cần chỉnh sửa!");
                }
            }
            else if (this.tabPage3.Focus())
            {
                if (listView3.SelectedIndices.Count > 0)
                {
                    this.Hide();
                    SuaTamTru f3 = new SuaTamTru(itemTamTru);
                    f3.ShowDialog();
                    sc.displayTamTru(listView3);
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn thông tin tạm trú cần chỉnh sửa!");
                }
            }
            else if (this.tabPage4.Focus())
            {
                if (listView4.SelectedIndices.Count > 0)
                {
                    this.Hide();
                    SuaChungTu f3 = new SuaChungTu(itemChungTu);
                    f3.ShowDialog();
                    sc.displayChungTu(listView4);
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn thông tin chứng tử cần chỉnh sửa!");
                }
            }
            else if (this.tabPage5.Focus())
            {
                if (listView5.SelectedIndices.Count > 0)
                {
                    this.Hide();
                    SuaKetHon f3 = new SuaKetHon(itemKetHon);
                    f3.ShowDialog();
                    sc.displayKetHon(listView5);
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn thông tin chứng nhận kết hôn cần chỉnh sửa!");
                }
            }
            else if (this.tabPage6.Focus())
            {
                if (listView6.SelectedIndices.Count > 0)
                {
                    this.Hide();
                    SuaTienAnTienSu f3 = new SuaTienAnTienSu(itemTienAnTienSu);
                    f3.ShowDialog();
                    sc.displayTienAnTienSu(listView6);
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn thông tin tiền án tiền sự cần chỉnh sửa!");
                }
            }
            else if (this.tabPage8.Focus())
            {
                if (listView7.SelectedIndices.Count > 0)
                {
                    this.Hide();
                    SuaTaiKhoan f3 = new SuaTaiKhoan(itemTaiKhoan);
                    f3.ShowDialog();
                    sc.displayTaiKhoan(listView7);
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn tài khoản cần đổi mật khẩu");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (this.tabPage1.Focus())
            {
                sc.xoaCSDL(listView1, "NHANKHAU", "MNK");
            }
            else if (this.tabPage2.Focus())
            {
                sc.xoaCSDL(listView2, "HOKHAU", "MHK");
            }
            else if (this.tabPage3.Focus())
            {
                sc.xoaCSDL(listView3, "TAMTRU", "MTT");
            }
            else if (this.tabPage4.Focus())
            {
                sc.xoaCSDL(listView4, "CHUNGTU", "MCT");
            }
            else if (this.tabPage5.Focus())
            {
                sc.xoaCSDL(listView5, "KETHON", "MKH");
            }
            else if (this.tabPage6.Focus())
            {
                sc.xoaCSDL(listView6, "TIENANTIENSU", "MaTATS");
            }
            else if (this.tabPage8.Focus())
            {
                sc.xoaCSDL(listView7, "CANBO", "TaiKhoan");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (this.tabPage1.Focus())
            {
                this.Hide();
                ThemNhanKhau f = new ThemNhanKhau();
                f.ShowDialog();
                sc.displayNhanKhau(listView1);
                this.Show();
            }
            else if (this.tabPage2.Focus())
            {
                this.Hide();
                ThemHoKhau f = new ThemHoKhau();
                f.ShowDialog();
                sc.displayHoKhau(listView2);
                this.Show();
            }
            else if (this.tabPage3.Focus())
            {
                this.Hide();
                ThemTamTru f = new ThemTamTru();
                f.ShowDialog();
                sc.displayTamTru(listView3);
                this.Show();
            }
            else if (this.tabPage4.Focus())
            {
                this.Hide();
                ThemChungTu f = new ThemChungTu();
                f.ShowDialog();
                sc.displayChungTu(listView4);
                this.Show();
            }
            else if (this.tabPage5.Focus())
            {
                this.Hide();
                ThemKetHon f = new ThemKetHon();
                f.ShowDialog();
                sc.displayKetHon(listView5);
                this.Show();
            }
            else if (this.tabPage6.Focus())
            {
                this.Hide();
                ThemTienAnTienSu f = new ThemTienAnTienSu();
                f.ShowDialog();
                sc.displayTienAnTienSu(listView6);
                this.Show();
            }
            else if (this.tabPage8.Focus())
            {
                this.Hide();
                ThemTaiKhoan f = new ThemTaiKhoan();
                f.ShowDialog();
                sc.displayTaiKhoan(listView7);
                this.Show();
            }
        }

        //-------------------------------------------LƯU THÔNG TIN KHI CLICK VÀO ĐỐI TƯỢNG
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                int index = listView1.FocusedItem.Index;
                var selectedItems = listView1.SelectedItems;
                for (int i = 0; i < itemNhanKhau.Length; i++)
                {
                    itemNhanKhau[i] = selectedItems[0].SubItems[i].Text;
                }
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedIndices.Count > 0)
            {
                int index = listView2.FocusedItem.Index;
                var selectedItems = listView2.SelectedItems;
                for (int i = 0; i < itemHoKhau.Length; i++)
                {
                    itemHoKhau[i] = selectedItems[0].SubItems[i].Text;
                }
            }
        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView3.SelectedIndices.Count > 0)
            {
                int index = listView3.FocusedItem.Index;
                var selectedItems = listView3.SelectedItems;
                for (int i = 0; i < itemTamTru.Length; i++)
                {
                    itemTamTru[i] = selectedItems[0].SubItems[i].Text;
                }
            }
        }

        private void listView4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView4.SelectedIndices.Count > 0)
            {
                int index = listView4.FocusedItem.Index;
                var selectedItems = listView4.SelectedItems;
                for (int i = 0; i < itemChungTu.Length; i++)
                {
                    itemChungTu[i] = selectedItems[0].SubItems[i].Text;
                }
            }
        }

        private void listView5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView5.SelectedIndices.Count > 0)
            {
                int index = listView5.FocusedItem.Index;
                var selectedItems = listView5.SelectedItems;
                for (int i = 0; i < itemKetHon.Length; i++)
                {
                    itemKetHon[i] = selectedItems[0].SubItems[i].Text;
                }
            }
        }

        private void listView6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView6.SelectedIndices.Count > 0)
            {
                int index = listView6.FocusedItem.Index;
                var selectedItems = listView6.SelectedItems;
                for (int i = 0; i < itemTienAnTienSu.Length; i++)
                {
                    itemTienAnTienSu[i] = selectedItems[0].SubItems[i].Text;
                }
            }
        }

        private void listView7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView7.SelectedIndices.Count > 0)
            {
                int index = listView7.FocusedItem.Index;
                var selectedItems = listView7.SelectedItems;
                for (int i = 0; i < itemTaiKhoan.Length; i++)
                {
                    itemTaiKhoan[i] = selectedItems[0].SubItems[i].Text;
                }
            }
        }

        //--------------------------------------------------------------SỰ KIỆN CHO TABPAGE
        private void materialTabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            int tabpageIndex = e.TabPageIndex;
            tabpageSelect(tabpageIndex);
            hideMainButton();
            switch (tabpageIndex)
            {
                case 0: if (flagNhanKhau) { showMainButton(); } break;
                case 1: if (flagHoKhau) { showMainButton(); } break;
                case 2: if (flagTamTru) { showMainButton(); } break;
                case 3: if (flagChungTu) { showMainButton(); } break;
                case 4: if (flagKetHon) { showMainButton(); } break;
                case 5: if (flagTienAnTienSu) { showMainButton(); } break;
                case 7: if (flagTaiKhoan) { showMainButton(); btnPhanQuyen.Visible = true;} break;
            }
        }

        //--------------------------------------------------------------BTN TABPAGE TRA CUU
        private void btnNhanKhau_Click(object sender, EventArgs e)
        {
            hideTitleAndListViewAndComboBox();
            hideComboboxChange();
            txtInput.Visible = true;
            lblTimNhanKhau.Visible = true;
            listViewNhanKhau.Visible = true;
            cbNhanKhau.Visible = true;
        }

        private void btnHoKhau_Click(object sender, EventArgs e)
        {
            hideTitleAndListViewAndComboBox();
            hideComboboxChange();
            txtInput.Visible = true;
            lblTimHoKhau.Visible = true;
            listViewHoKhau.Visible = true;
            cbHoKhau.Visible = true;
        }

        private void btnTamTru_Click(object sender, EventArgs e)
        {
            hideTitleAndListViewAndComboBox();
            hideComboboxChange();
            txtInput.Visible = true;
            lblTimTamTru.Visible = true;
            listViewTamTru.Visible = true;
            cbTamTru.Visible = true;
        }

        private void btnChungTu_Click(object sender, EventArgs e)
        {
            hideTitleAndListViewAndComboBox();
            hideComboboxChange();
            txtInput.Visible = true;
            lblTimChungTu.Visible = true;
            listViewChungTu.Visible = true;
            cbChungTu.Visible = true;
        }

        private void btnKetHon_Click(object sender, EventArgs e)
        {
            hideTitleAndListViewAndComboBox();
            hideComboboxChange();
            txtInput.Visible = true;
            lblKetHon.Visible = true;
            listViewKetHon.Visible = true;
            cbKetHon.Visible = true;
        }

        private void btnTienAnTienSu_Click(object sender, EventArgs e)
        {
            hideTitleAndListViewAndComboBox();
            hideComboboxChange();
            txtInput.Visible = true;
            lblTienAnTienSu.Visible = true;
            listViewTienAnTienSu.Visible = true;
            cbTienAnTienSu.Visible = true;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int index;
            if (cbNhanKhau.Visible)
            {
                index = cbNhanKhau.SelectedIndex;
                if (index == -1)
                {
                    MessageBox.Show("Vui lòng chọn mục cần tra cứu");
                }
                else
                {
                    if (index == 2)
                    {
                        if (cbNgay.SelectedIndex == -1 || cbThang.SelectedIndex == -1 || cbNam.SelectedIndex == -1)
                        {
                            MessageBox.Show("Vui lòng chọn thông tin cần tra cứu");
                        }
                    }
                    else if (index == 3)
                    {
                        if (rdTimNam.Checked == false && rdTimNu.Checked == false)
                        {

                        }
                    }
                    else if (index == 4)
                    {
                        if (cbQueQuan.SelectedIndex == -1)
                        {
                            MessageBox.Show("Vui lòng chọn thông tin cần tra cứu");
                        }
                    }
                    else if (index == 5)
                    {
                        if (cbTonGiao.SelectedIndex == -1)
                        {
                            MessageBox.Show("Vui lòng chọn thông tin cần tra cứu");
                        }
                    }
                    else if (index == 6)
                    {
                        if (cbDanToc.SelectedIndex == -1)
                        {
                            MessageBox.Show("Vui lòng chọn thông tin cần tra cứu");
                        }
                    }
                    else
                    {
                        if (txtInput.Text.Equals(""))
                        {
                            MessageBox.Show("Vui lòng nhập thông tin cần tra cứu");
                        }
                    }
                }
            }

            if (cbHoKhau.Visible)
            {
                index = cbHoKhau.SelectedIndex;
                if (index == -1)
                {
                    MessageBox.Show("Vui lòng chọn mục cần tra cứu");
                }
                else
                {
                    if (index == 3)
                    {
                        if (cbQueQuan.SelectedIndex == -1)
                        {
                            MessageBox.Show("Vui lòng chọn thông tin cần tra cứu");
                        }
                    }
                    else if (index == 4)
                    {
                        if (cbNgay.SelectedIndex == -1 || cbThang.SelectedIndex == -1 || cbNam.SelectedIndex == -1)
                        {
                            MessageBox.Show("Vui lòng chọn thông tin cần tra cứu");
                        }
                    }
                    else
                    {
                        if (txtInput.Text.Equals(""))
                        {
                            MessageBox.Show("Vui lòng nhập thông tin cần tra cứu");
                        }
                    }
                }
            }

            if (cbChungTu.Visible)
            {
                index = cbChungTu.SelectedIndex;
                if (index == -1)
                {
                    MessageBox.Show("Vui lòng chọn mục cần tra cứu");
                }
                else
                {
                    if (index == 2)
                    {
                        if (cbQuanHe.SelectedIndex == -1)
                        {
                            MessageBox.Show("Vui lòng chọn thông tin cần tra cứu");
                        }
                    }
                    else if (index == 4 || index == 8 || index == 11)
                    {
                        if (cbNgay.SelectedIndex == -1 || cbThang.SelectedIndex == -1 || cbNam.SelectedIndex == -1)
                        {
                            MessageBox.Show("Vui lòng chọn thông tin cần tra cứu");
                        }
                    }
                    else if (index == 5)
                    {
                        if (cbDanToc.SelectedIndex == -1)
                        {
                            MessageBox.Show("Vui lòng chọn thông tin cần tra cứu");
                        }
                    }
                    else if (index == 6)
                    {
                        if (cbQuocTich.SelectedIndex == -1)
                        {
                            MessageBox.Show("Vui lòng chọn thông tin cần tra cứu");
                        }
                    }
                    else if (index == 9)
                    {
                        if (cbGio.SelectedIndex == -1 || cbPhut.SelectedIndex == -1)
                        {
                            MessageBox.Show("Vui lòng chọn thông tin cần tra cứu");
                        }
                    }
                    else if (index == 10)
                    {
                        if (cbQueQuan.SelectedIndex == -1)
                        {
                            MessageBox.Show("Vui lòng chọn thông tin cần tra cứu");
                        }
                    }
                    else
                    {
                        if (txtInput.Text.Equals(""))
                        {
                            MessageBox.Show("Vui lòng nhập thông tin cần tra cứu");
                        }
                    }
                }
            }

            if (cbKetHon.Visible)
            {
                index = cbKetHon.SelectedIndex;
                if (index == -1)
                {
                    MessageBox.Show("Vui lòng chọn mục cần tra cứu");
                }
                else
                {
                    if (index == 2 || index == 7 || index == 12)
                    {
                        if (cbNgay.SelectedIndex == -1 || cbThang.SelectedIndex == -1 || cbNam.SelectedIndex == -1)
                        {
                            MessageBox.Show("Vui lòng chọn thông tin cần tra cứu");
                        }
                    }
                    else if (index == 3 || index == 8)
                    {
                        if (cbDanToc.SelectedIndex == -1)
                        {
                            MessageBox.Show("Vui lòng chọn thông tin cần tra cứu");
                        }
                    }
                    else if (index == 4 || index == 9)
                    {
                        if (cbQuocTich.SelectedIndex == -1)
                        {
                            MessageBox.Show("Vui lòng chọn thông tin cần tra cứu");
                        }
                    }
                    else if (index == 11)
                    {
                        if (cbQueQuan.SelectedIndex == -1)
                        {
                            MessageBox.Show("Vui lòng chọn thông tin cần tra cứu");
                        }
                    }
                    else
                    {
                        if (txtInput.Text.Equals(""))
                        {
                            MessageBox.Show("Vui lòng nhập thông tin cần tra cứu");
                        }
                    }
                }
            }
            if (cbTamTru.Visible)
            {
                index = cbKetHon.SelectedIndex;
                if (index == -1)
                {
                    MessageBox.Show("Vui lòng chọn mục cần tra cứu");
                }
                else
                {
                    if (index == 4)
                    {
                        if (cbNgay.SelectedIndex == -1 || cbThang.SelectedIndex == -1 || cbNam.SelectedIndex == -1)
                        {
                            MessageBox.Show("Vui lòng chọn thông tin cần tra cứu");
                        }
                    }
                    else
                    {
                        if (txtInput.Text.Equals(""))
                        {
                            MessageBox.Show("Vui lòng nhập thông tin cần tra cứu");
                        }
                    }
                }
            }
            if (cbTienAnTienSu.Visible)
            {
                index = cbKetHon.SelectedIndex;
                if (index == -1)
                {
                    MessageBox.Show("Vui lòng chọn mục cần tra cứu");
                }
                else
                {
                    if (index == 2)
                    {
                        if (cbQueQuan.SelectedIndex == -1)
                        {
                            MessageBox.Show("Vui lòng chọn thông tin cần tra cứu");
                        }
                    }
                    else if (index == 3)
                    {
                        if (cbNgay.SelectedIndex == -1 || cbThang.SelectedIndex == -1 || cbNam.SelectedIndex == -1)
                        {
                            MessageBox.Show("Vui lòng chọn thông tin cần tra cứu");
                        }
                    }
                    else
                    {
                        if (txtInput.Text.Equals(""))
                        {
                            MessageBox.Show("Vui lòng nhập thông tin cần tra cứu");
                        }
                    }
                }
            }
        }

        //-----------------------------------------------------------COMBOX TABPAGE TRA CUU
        private void cbNhanKhau_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbNhanKhau.SelectedIndex;
            hideComboboxChange();
            if (index == 2)
            {
                lblDauGach1.Visible = true;
                lblDauGach2.Visible = true;
                cbNgay.Visible = true;
                cbThang.Visible = true;
                cbNam.Visible = true;
            }
            else if (index == 3)
            {
                rdTimNam.Visible = true;
                rdTimNu.Visible = true;
            }
            else if (index == 4)
            {
                cbQueQuan.Visible = true;
            }
            else if (index == 5)
            {
                cbTonGiao.Visible = true;
            }
            else if (index == 6)
            {
                cbDanToc.Visible = true;
            }
            else
            {
                txtInput.Visible = true;
            }
        }

        private void cbHoKhau_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbHoKhau.SelectedIndex;
            hideComboboxChange();
            if (index == 3)
            {
                cbQueQuan.Visible = true;
            }
            else if (index == 4)
            {
                lblDauGach1.Visible = true;
                lblDauGach2.Visible = true;
                cbNgay.Visible = true;
                cbThang.Visible = true;
                cbNam.Visible = true;
            }
            else
            {
                txtInput.Visible = true;
            }
        }

        private void cbTamTru_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbTamTru.SelectedIndex;
            hideComboboxChange();
            if (index == 4)
            {
                lblDauGach1.Visible = true;
                lblDauGach2.Visible = true;
                cbNgay.Visible = true;
                cbThang.Visible = true;
                cbNam.Visible = true;
            }
            else
            {
                txtInput.Visible = true;
            }
        }

        private void cbChungTu_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbChungTu.SelectedIndex;
            hideComboboxChange();
            if (index == 2)
            {
                cbQuanHe.Visible = true;
            }
            else if (index == 4 || index == 8 || index == 11)
            {
                lblDauGach1.Visible = true;
                lblDauGach2.Visible = true;
                cbNgay.Visible = true;
                cbThang.Visible = true;
                cbNam.Visible = true;
            }
            else if (index == 5)
            {
                cbDanToc.Visible = true;
            }
            else if (index == 6)
            {
                cbQuocTich.Visible = true;
            }
            else if (index == 9)
            {
                cbGio.Visible = true;
                cbPhut.Visible = true;
                lblDauHaiCham.Visible = true;
            }
            else if (index == 10)
            {
                cbQueQuan.Visible = true;
            }
            else
            {
                txtInput.Visible = true;
            }
        }

        private void cbKetHon_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbKetHon.SelectedIndex;
            hideComboboxChange();
            if (index == 2 || index == 7 || index == 12)
            {
                lblDauGach1.Visible = true;
                lblDauGach2.Visible = true;
                cbNgay.Visible = true;
                cbThang.Visible = true;
                cbNam.Visible = true;
            }
            else if (index == 3 || index == 8)
            {
                cbDanToc.Visible = true;
            }
            else if (index == 4 || index == 9)
            {
                cbQuocTich.Visible = true;
            }
            else if (index == 11)
            {
                cbQueQuan.Visible = true;
            }
            else
            {
                txtInput.Visible = true;
            }
        }

        private void cbTienAnTienSu_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbTienAnTienSu.SelectedIndex;
            hideComboboxChange();
            if (index == 2)
            {
                cbQueQuan.Visible = true;
            }
            else if (index == 3)
            {
                lblDauGach1.Visible = true;
                lblDauGach2.Visible = true;
                cbNgay.Visible = true;
                cbThang.Visible = true;
                cbNam.Visible = true;
            }
            else
            {
                txtInput.Visible = true;
            }
        }

        //----------------------------------------------------------------------HIDE/SHOW
        private void hideTabpageTraCuu()
        {
            materialTabControl1.SetBounds(2, 110, 1372, 450);
            showMainButton();
            materialDivider2.Visible = true;
            if (btnSua.Text == "Đổi mật khẩu")
            {
                btnSua.Text = "Sửa";
            }
        }

        private void hideTabpageTaiKhoan()
        {
            btnPhanQuyen.Visible = false;
            btnSua.SetBounds(375, 554, 154, 70);
            btnXoa.SetBounds(591, 554, 154, 70);
            btnThem.SetBounds(802, 554, 154, 70);
        }

        private void showTabpageTaiKhoan()
        {
            btnSua.Text = "Đổi mật khẩu";
            btnPhanQuyen.Visible = true;
            btnPhanQuyen.SetBounds(270, 554, 154, 70);
            btnSua.SetBounds(485, 554, 154, 70);
            btnXoa.SetBounds(700, 554, 154, 70);
            btnThem.SetBounds(910, 554, 154, 70);
        }

        private void hideTitleAndListViewAndComboBox()
        {
            lblTimChungTu.Visible = false;
            lblTimHoKhau.Visible = false;
            lblTimNhanKhau.Visible = false;
            lblTimTamTru.Visible = false;
            lblKetHon.Visible = false;
            lblTienAnTienSu.Visible = false;

            listViewKetHon.Visible = false;
            listViewTamTru.Visible = false;
            listViewNhanKhau.Visible = false;
            listViewHoKhau.Visible = false;
            listViewChungTu.Visible = false;
            listViewTienAnTienSu.Visible = false;

            cbChungTu.Visible = false;
            cbHoKhau.Visible = false;
            cbKetHon.Visible = false;
            cbNhanKhau.Visible = false;
            cbTamTru.Visible = false;
            cbTienAnTienSu.Visible = false;
        }

        private void hideComboboxChange()
        {
            rdTimNam.Visible = false;
            rdTimNu.Visible = false;
            txtInput.Visible = false;
            cbQueQuan.Visible = false;
            cbTonGiao.Visible = false;
            cbQuocTich.Visible = false;
            cbDanToc.Visible = false;
            lblDauGach1.Visible = false;
            lblDauGach2.Visible = false;
            cbNgay.Visible = false;
            cbThang.Visible = false;
            cbNam.Visible = false;
            cbQuanHe.Visible = false;
            cbGio.Visible = false;
            cbPhut.Visible = false;
            lblDauHaiCham.Visible = false;
        }

        private void showTabpageTraCuu()
        {
            materialTabControl1.SetBounds(2, 110, 1372, 500);
            hideMainButton();
            materialDivider2.Visible = false;
            btnPhanQuyen.Visible = false;
        }

        private void hideMainButton()
        {
            btnThem.Visible = false;
            btnXoa.Visible = false;
            btnSua.Visible = false;
            btnPhanQuyen.Visible = false;
        }

        private void showMainButton()
        {
            btnThem.Visible = true;
            btnXoa.Visible = true;
            btnSua.Visible = true;
        }

        private void tabpageSelect(int tabpageIndex)
        {
            if (tabpageIndex == 0 || tabpageIndex == 1 || tabpageIndex == 2 ||
                tabpageIndex == 3 || tabpageIndex == 4 || tabpageIndex == 5)
            {
                hideTabpageTraCuu();
                hideTabpageTaiKhoan();
                if (tabpageIndex == 0) { sc.displayNhanKhau(listView1); }
                else if (tabpageIndex == 1) { sc.displayHoKhau(listView2); }
                else if (tabpageIndex == 2) { sc.displayTamTru(listView3); }
                else if (tabpageIndex == 3) { sc.displayChungTu(listView4); }
                else if (tabpageIndex == 4) { sc.displayKetHon(listView5); }
                else { sc.displayTienAnTienSu(listView6); }
            }
            else
            {
                if (tabpageIndex == 6) { hideTabpageTaiKhoan(); showTabpageTraCuu(); }
                else { hideTabpageTraCuu(); showTabpageTaiKhoan(); sc.displayTaiKhoan(listView7); }
            }
        }

        //---------------------------------------------------------------------------CLOCK
        private void demThoiGian_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
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

        //--------------------------------------------------------X Button to close program
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (logOut == false)
            {
                switch (MessageBox.Show(this, "Thoát khỏi chương trình ?", "Xác nhận thoát", MessageBoxButtons.YesNo))
                {
                    case DialogResult.No:
                        e.Cancel = true;
                        break;
                    default:
                        Environment.Exit(1);
                        break;
                }
            }
        }

        //-----------------------------------------------------------------------Phan Quyen
        private void setAuthorities(string phanQuyen)
        {
            switch (phanQuyen)
            {
                case "1": this.materialTabControl1.SelectedTab = tabPage8; sc.displayTaiKhoan(listView7); showTabpageTaiKhoan(); flagTaiKhoan = true; break;
                case "2": this.materialTabControl1.SelectedTab = tabPage1; sc.displayNhanKhau(listView1); flagNhanKhau = true; materialTabControl1.TabPages.Remove(tabPage8); break;
                case "3": this.materialTabControl1.SelectedTab = tabPage2; sc.displayHoKhau(listView2); flagHoKhau = true; materialTabControl1.TabPages.Remove(tabPage8); break;
                case "4": this.materialTabControl1.SelectedTab = tabPage3; sc.displayTamTru(listView3); flagTamTru = true; materialTabControl1.TabPages.Remove(tabPage8); break;
                case "5": this.materialTabControl1.SelectedTab = tabPage4; sc.displayChungTu(listView4); flagChungTu = true; materialTabControl1.TabPages.Remove(tabPage8); break;
                case "6": this.materialTabControl1.SelectedTab = tabPage5; sc.displayKetHon(listView5); flagKetHon = true; materialTabControl1.TabPages.Remove(tabPage8); break;
                case "7": this.materialTabControl1.SelectedTab = tabPage6; sc.displayTienAnTienSu(listView6); flagTienAnTienSu = true; materialTabControl1.TabPages.Remove(tabPage8); break;
            }
        }

        //---------------------------------------------------------------------Change color
        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            colorSchemeIndex++;
            if (colorSchemeIndex > 5)
                colorSchemeIndex = 0;
            int rValue = 0;
            int gValue = 0;
            int bValue = 0;
            switch (colorSchemeIndex)
            {
                case 0:
                    rValue = 55; gValue = 71; bValue = 79;
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
                    break;
                case 1:
                    rValue = 38; gValue = 166; bValue = 154;
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal400, Primary.Teal600, Primary.Teal200, Accent.DeepOrange700, TextShade.WHITE);
                    break;
                case 2:
                    rValue = 76; gValue = 175; bValue = 80;
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Green500, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);
                    break;
                case 3:
                    rValue = 63; gValue = 81; bValue = 181;
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
                    break;
                case 4:
                    rValue = 156; gValue = 39; bValue = 176;
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple500, Primary.Purple700, Primary.Purple200, Accent.Yellow200, TextShade.WHITE);
                    break;
                case 5:
                    rValue = 244; gValue = 67; bValue = 54;
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Red500, Primary.Red900, Primary.Red400, Accent.Green400, TextShade.WHITE);
                    break;
            }
            //MessageBox.Show(materialSkinManager.ColorScheme.DarkPrimaryColor.Name);
            this.lblUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(rValue)))), ((int)(((byte)(gValue)))), ((int)(((byte)(bValue)))));
            this.lblClock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(rValue)))), ((int)(((byte)(gValue)))), ((int)(((byte)(bValue)))));
            this.lblDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(rValue)))), ((int)(((byte)(gValue)))), ((int)(((byte)(bValue)))));
        }

        private void changeColor()
        {
            int rValue = 0;
            int gValue = 0;
            int bValue = 0;
            switch (materialSkinManager.ColorScheme.DarkPrimaryColor.Name)
            {
                case "ff00897b": rValue = 38; gValue = 166; bValue = 154; break;
                case "ff303f9f": rValue = 63; gValue = 81; bValue = 181; break;
                case "ff388e3c": rValue = 76; gValue = 175; bValue = 80; break;
                case "ff263238": rValue = 55; gValue = 71; bValue = 79; break;
                case "ff7b1fa2": rValue = 156; gValue = 39; bValue = 176; break;
                case "ffb71c1c": rValue = 244; gValue = 67; bValue = 54; break;
            }
            this.lblUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(rValue)))), ((int)(((byte)(gValue)))), ((int)(((byte)(bValue)))));
            this.lblClock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(rValue)))), ((int)(((byte)(gValue)))), ((int)(((byte)(bValue)))));
            this.lblDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(rValue)))), ((int)(((byte)(gValue)))), ((int)(((byte)(bValue)))));
        }

        private void btnChangeTextColor_Click(object sender, EventArgs e)
        {
            textColorSchemeIndex++;
            if (textColorSchemeIndex > 4)
                textColorSchemeIndex = 0;
            int rValue = 0;
            int gValue = 0;
            int bValue = 0;
            switch (textColorSchemeIndex)
            {
                case 0:
                    rValue = 0; gValue = 0; bValue = 192;
                    break;
                case 1:
                    //la cay
                    rValue = 0; gValue = 100; bValue = 0;
                    break;
                case 2:
                    //cam
                    rValue = 255; gValue = 140; bValue = 0;
                    break;
                case 3:
                    //tim
                    rValue = 153; gValue = 50; bValue = 204;
                    break;
                case 4:
                    rValue = 255; gValue = 0; bValue = 0;
                    break;
            }
            this.listViewNhanKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(rValue)))), ((int)(((byte)(gValue)))), ((int)(((byte)(bValue)))));
            this.listViewHoKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(rValue)))), ((int)(((byte)(gValue)))), ((int)(((byte)(bValue)))));
            this.listViewChungTu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(rValue)))), ((int)(((byte)(gValue)))), ((int)(((byte)(bValue)))));
            this.listViewKetHon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(rValue)))), ((int)(((byte)(gValue)))), ((int)(((byte)(bValue)))));
            this.listViewTamTru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(rValue)))), ((int)(((byte)(gValue)))), ((int)(((byte)(bValue)))));
            this.listViewTienAnTienSu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(rValue)))), ((int)(((byte)(gValue)))), ((int)(((byte)(bValue)))));
            this.listView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(rValue)))), ((int)(((byte)(gValue)))), ((int)(((byte)(bValue)))));
            this.listView2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(rValue)))), ((int)(((byte)(gValue)))), ((int)(((byte)(bValue)))));
            this.listView3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(rValue)))), ((int)(((byte)(gValue)))), ((int)(((byte)(bValue)))));
            this.listView4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(rValue)))), ((int)(((byte)(gValue)))), ((int)(((byte)(bValue)))));
            this.listView5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(rValue)))), ((int)(((byte)(gValue)))), ((int)(((byte)(bValue)))));
            this.listView6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(rValue)))), ((int)(((byte)(gValue)))), ((int)(((byte)(bValue)))));
            this.listView7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(rValue)))), ((int)(((byte)(gValue)))), ((int)(((byte)(bValue)))));
        }
    }
}
