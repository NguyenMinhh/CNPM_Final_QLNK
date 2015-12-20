using System;
using MaterialSkin.Controls;
using System.Windows.Forms;
using MaterialSkin;

namespace QLNK
{
    public partial class TrangChu : MaterialForm
    {
        readonly SourceCode _sourceCode = new SourceCode();
        public readonly MaterialSkinManager MaterialSkinManager;
        private int _colorSchemeIndex;
        private int _textColorSchemeIndex;
        private readonly string[] _itemNhanKhau = new string[10];
        private readonly string[] _itemHoKhau = new string[6];
        private readonly string[] _itemTamTru = new string[6];
        private readonly string[] _itemChungTu = new string[13];
        private readonly string[] _itemKetHon = new string[15];
        private readonly string[] _itemTienAnTienSu = new string[5];
        private readonly string[] _itemTaiKhoan = new string[4];
        private bool _flagNhanKhau;
        private bool _flagHoKhau;
        private bool _flagTamTru;
        private bool _flagKetHon;
        private bool _flagTienAnTienSu;
        private bool _flagChungTu;
        private bool _flagTaiKhoan;
        private bool _logOut;

        public TrangChu(string phanQuyen, string nguoiSuDung)
        {
            InitializeComponent();
            lblUserName.Text = nguoiSuDung;
            MaterialSkinManager = MaterialSkinManager.Instance;
            MaterialSkinManager.AddFormToManage(this);
            ChangeColor();
            SetAuthorities(phanQuyen);
        }

        //----------------------------------------------------------------------BTN CHÍNH
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show(@"Đăng xuất tài khoản ?", @"Xác nhận đăng xuất", MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes) return;
            _logOut = true;
            Close();
        }

        private void btnPhanQuyen_Click(object sender, EventArgs e)
        {
            if (listView7.SelectedIndices.Count > 0)
            {
                Hide();
                var f3 = new PhanQuyenTaiKhoan(_itemTaiKhoan);
                f3.ShowDialog();
                _sourceCode.DisplayTaiKhoan(listView7);
                Show();
            }
            else
            {
                MessageBox.Show(@"Vui lòng chọn tài khoản cần phân quyền!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (tabPage1.Focus())
            {
                if (listView1.SelectedIndices.Count > 0)
                {
                    Hide();
                    var f3 = new SuaNhanKhau(_itemNhanKhau);
                    f3.ShowDialog();
                    _sourceCode.DisplayNhanKhau(listView1, 0);
                    Show();
                }
                else
                {
                    MessageBox.Show(@"Vui lòng chọn thông tin nhân khẩu cần chỉnh sửa!");
                }
            }
            else if (tabPage2.Focus())
            {
                if (listView2.SelectedIndices.Count > 0)
                {
                    Hide();
                    var f3 = new SuaHoKhau(_itemHoKhau);
                    f3.ShowDialog();
                    _sourceCode.DisplayHoKhau(listView2, 0);
                    Show();
                }
                else
                {
                    MessageBox.Show(@"Vui lòng chọn thông tin hộ khẩu cần chỉnh sửa!");
                }
            }
            else if (tabPage3.Focus())
            {
                if (listView3.SelectedIndices.Count > 0)
                {
                    Hide();
                    var f3 = new SuaTamTru(_itemTamTru);
                    f3.ShowDialog();
                    _sourceCode.DisplayTamTru(listView3);
                    Show();
                }
                else
                {
                    MessageBox.Show(@"Vui lòng chọn thông tin tạm trú cần chỉnh sửa!");
                }
            }
            else if (tabPage4.Focus())
            {
                if (listView4.SelectedIndices.Count > 0)
                {
                    Hide();
                    var f3 = new SuaChungTu(_itemChungTu);
                    f3.ShowDialog();
                    _sourceCode.DisplayChungTu(listView4);
                    Show();
                }
                else
                {
                    MessageBox.Show(@"Vui lòng chọn thông tin chứng tử cần chỉnh sửa!");
                }
            }
            else if (tabPage5.Focus())
            {
                if (listView5.SelectedIndices.Count > 0)
                {
                    Hide();
                    var f3 = new SuaKetHon(_itemKetHon);
                    f3.ShowDialog();
                    _sourceCode.DisplayKetHon(listView5);
                    Show();
                }
                else
                {
                    MessageBox.Show(@"Vui lòng chọn thông tin chứng nhận kết hôn cần chỉnh sửa!");
                }
            }
            else if (tabPage6.Focus())
            {
                if (listView6.SelectedIndices.Count > 0)
                {
                    Hide();
                    var f3 = new SuaTienAnTienSu(_itemTienAnTienSu);
                    f3.ShowDialog();
                    _sourceCode.DisplayTienAnTienSu(listView6);
                    Show();
                }
                else
                {
                    MessageBox.Show(@"Vui lòng chọn thông tin tiền án tiền sự cần chỉnh sửa!");
                }
            }
            else if (tabPage8.Focus())
            {
                if (listView7.SelectedIndices.Count > 0)
                {
                    Hide();
                    var f3 = new SuaTaiKhoan(_itemTaiKhoan);
                    f3.ShowDialog();
                    _sourceCode.DisplayTaiKhoan(listView7);
                    Show();
                }
                else
                {
                    MessageBox.Show(@"Vui lòng chọn tài khoản cần đổi mật khẩu");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tabPage1.Focus())
            {
                _sourceCode.XoaCsdl(listView1, "NHANKHAU", "MNK");
            }
            else if (tabPage2.Focus())
            {
                _sourceCode.XoaCsdl(listView2, "HOKHAU", "MHK");
            }
            else if (tabPage3.Focus())
            {
                _sourceCode.XoaCsdl(listView3, "TAMTRU", "MTT");
            }
            else if (tabPage4.Focus())
            {
                _sourceCode.XoaCsdl(listView4, "CHUNGTU", "MCT");
            }
            else if (tabPage5.Focus())
            {
                _sourceCode.XoaCsdl(listView5, "KETHON", "MKH");
            }
            else if (tabPage6.Focus())
            {
                _sourceCode.XoaCsdl(listView6, "TIENANTIENSU", "MaTATS");
            }
            else if (tabPage8.Focus())
            {
                _sourceCode.XoaCsdl(listView7, "CANBO", "TaiKhoan");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (tabPage1.Focus())
            {
                Hide();
                var f = new ThemNhanKhau();
                f.ShowDialog();
                _sourceCode.DisplayNhanKhau(listView1, 0);
                Show();
            }
            else if (tabPage2.Focus())
            {
                Hide();
                var f = new ThemHoKhau();
                f.ShowDialog();
                _sourceCode.DisplayHoKhau(listView2, 0);
                Show();
            }
            else if (tabPage3.Focus())
            {
                Hide();
                var f = new ThemTamTru();
                f.ShowDialog();
                _sourceCode.DisplayTamTru(listView3);
                Show();
            }
            else if (tabPage4.Focus())
            {
                Hide();
                var f = new ThemChungTu();
                f.ShowDialog();
                _sourceCode.DisplayChungTu(listView4);
                Show();
            }
            else if (tabPage5.Focus())
            {
                Hide();
                var f = new ThemKetHon();
                f.ShowDialog();
                _sourceCode.DisplayKetHon(listView5);
                Show();
            }
            else if (tabPage6.Focus())
            {
                Hide();
                var f = new ThemTienAnTienSu();
                f.ShowDialog();
                _sourceCode.DisplayTienAnTienSu(listView6);
                Show();
            }
            else if (tabPage8.Focus())
            {
                Hide();
                var f = new ThemTaiKhoan();
                f.ShowDialog();
                _sourceCode.DisplayTaiKhoan(listView7);
                Show();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int index;
            if (cbNhanKhau.Visible)
            {
                index = cbNhanKhau.SelectedIndex;
                switch (index)
                {
                    case -1:
                        MessageBox.Show(_sourceCode.ErrorBlankFindItem);
                        break;
                    case 0:
                    case 1:
                    case 7:
                    case 8:
                    case 9:
                        if (txtInput.Text == "")
                        {
                            MessageBox.Show(_sourceCode.ErrorBlankFind);
                        }
                        else
                        {
                            if (index == 0)
                                _sourceCode.FindAndDisplay("NHANKHAU", "MNK", txtInput.Text, listViewNhanKhau);
                            else if (index == 1)
                                _sourceCode.FindAndDisplay("NHANKHAU", "Ten", txtInput.Text, listViewNhanKhau);
                            else if (index == 7)
                                _sourceCode.FindAndDisplay("NHANKHAU", "CMND", txtInput.Text, listViewNhanKhau);
                            else if (index == 8)
                                _sourceCode.FindAndDisplay("NHANKHAU", "MHK", txtInput.Text, listViewNhanKhau);
                            else if (index == 9)
                                _sourceCode.FindAndDisplay("NHANKHAU", "NgheNghiep", txtInput.Text, listViewNhanKhau);
                        }
                        break;
                    case 2:
                        if (cbNgay.Text.Equals("") || cbThang.Text.Equals("") || cbNam.Text.Equals(""))
                        {
                            MessageBox.Show(_sourceCode.ErrorBlankFind);
                        }
                        else
                        {
                            _sourceCode.FindAndDisplay("NHANKHAU", "NgaySinh", cbNgay.Text + "/" + cbThang.Text + "/" + cbNam.Text, listViewNhanKhau);
                        }
                        break;
                    case 3:
                        if (rdTimNam.Checked == false && rdTimNu.Checked == false)
                        {
                            MessageBox.Show(_sourceCode.ErrorBlankFind);
                        }
                        else
                        {
                            var gioiTinh = rdTimNam.Checked ? "Nam" : "Nữ";
                            _sourceCode.FindAndDisplay("NHANKHAU", "GioiTinh", gioiTinh, listViewNhanKhau);
                        }
                        break;
                    case 4:
                        if (cbQueQuan.Text.Equals(""))
                        {
                            MessageBox.Show(_sourceCode.ErrorBlankFind);
                        }
                        else
                        {
                            _sourceCode.FindAndDisplay("NHANKHAU", "QueQuan", cbQueQuan.Text, listViewNhanKhau);
                        }
                        break;
                    case 5:
                        if (cbTonGiao.Text.Equals(""))
                        {
                            MessageBox.Show(_sourceCode.ErrorBlankFind);
                        }
                        else
                        {
                            _sourceCode.FindAndDisplay("NHANKHAU", "TonGiao", cbTonGiao.Text, listViewNhanKhau);
                        }
                        break;
                    case 6:
                        if (cbDanToc.Text.Equals(""))
                        {
                            MessageBox.Show(_sourceCode.ErrorBlankFind);
                        }
                        else
                        {
                            _sourceCode.FindAndDisplay("NHANKHAU", "DanToc", cbDanToc.Text, listViewNhanKhau);
                        }
                        break;
                }
            }

            if (cbHoKhau.Visible)
            {
                index = cbHoKhau.SelectedIndex;
                switch (index)
                {
                    case -1:
                        MessageBox.Show(_sourceCode.ErrorBlankFindItem);
                        break;
                    case 0:
                    case 1:
                    case 2:
                        if (txtInput.Text == "")
                        {
                            MessageBox.Show(_sourceCode.ErrorBlankFind);
                        }
                        else
                        {
                            switch (index)
                            {
                                case 0:
                                    _sourceCode.FindAndDisplay("HOKHAU", "MHK", txtInput.Text, listViewHoKhau);
                                    break;
                                case 1:
                                    _sourceCode.FindAndDisplay("HOKHAU", "TenChuHo", txtInput.Text, listViewHoKhau);
                                    break;
                                case 2:
                                    _sourceCode.FindAndDisplay("HOKHAU", "CMNDChuHo", txtInput.Text, listViewHoKhau);
                                    break;
                            }
                        }
                        break;
                    case 3:
                        if (cbQueQuan.Text == "")
                        {
                            MessageBox.Show(_sourceCode.ErrorBlankFind);
                        }
                        else
                        {
                            _sourceCode.FindAndDisplay("HOKHAU", "KhuVuc", cbQueQuan.Text, listViewHoKhau);
                        }
                        break;
                    case 4:
                        if (cbNgay.Text.Equals("") || cbThang.Text.Equals("") || cbNam.Text.Equals(""))
                        {
                            MessageBox.Show(_sourceCode.ErrorBlankFind);
                        }
                        else
                        {
                            _sourceCode.FindAndDisplay("HOKHAU", "NgayLap", cbNgay.Text + "/" + cbThang.Text + "/" + cbNam.Text, listViewHoKhau);
                        }
                        break;
                }
            }

            if (cbChungTu.Visible)
            {
                index = cbChungTu.SelectedIndex;
                switch (index)
                {
                    case -1:
                        MessageBox.Show(_sourceCode.ErrorBlankFindItem);
                        break;
                    case 0:
                    case 1:
                    case 3:
                    case 7:
                        if (txtInput.Text == "")
                        {
                            MessageBox.Show(_sourceCode.ErrorBlankFind);
                        }
                        else
                        {
                            switch (index)
                            {
                                case 0:
                                    _sourceCode.FindAndDisplay("CHUNGTU", "MCT", txtInput.Text, listViewChungTu);
                                    break;
                                case 1:
                                    _sourceCode.FindAndDisplay("CHUNGTU", "TenNguoiKhai", txtInput.Text, listViewChungTu);
                                    break;
                                case 3:
                                    _sourceCode.FindAndDisplay("CHUNGTU", "TenNguoiMat", txtInput.Text, listViewChungTu);
                                    break;
                                case 7:
                                    _sourceCode.FindAndDisplay("CHUNGTU", "CMND", txtInput.Text, listViewChungTu);
                                    break;
                            }
                        }
                        break;
                    case 2:
                        if (cbQuanHe.Text.Equals(""))
                        {
                            MessageBox.Show(_sourceCode.ErrorBlankFind);
                        }
                        else
                        {
                            _sourceCode.FindAndDisplay("CHUNGTU", "QHVoiNguoiMat", cbQuanHe.Text, listViewChungTu);
                        }
                        break;
                    case 4:
                    case 8:
                    case 11:
                        if (cbNgay.Text.Equals("") || cbThang.Text.Equals("") || cbNam.Text.Equals(""))
                        {
                            MessageBox.Show(_sourceCode.ErrorBlankFind);
                        }
                        else
                        {
                            switch (index)
                            {
                                case 4:
                                    _sourceCode.FindAndDisplay("CHUNGTU", "NgaySinh", cbNgay.Text + "/" + cbThang.Text + "/" + cbNam.Text, listViewChungTu);
                                    break;
                                case 8:
                                    _sourceCode.FindAndDisplay("CHUNGTU", "NgayMat", cbNgay.Text + "/" + cbThang.Text + "/" + cbNam.Text, listViewChungTu);
                                    break;
                                case 11:
                                    _sourceCode.FindAndDisplay("CHUNGTU", "NgayDK", cbNgay.Text + "/" + cbThang.Text + "/" + cbNam.Text, listViewChungTu);
                                    break;
                            }
                        }
                        break;
                    case 5:
                        if (cbDanToc.Text.Equals(""))
                        {
                            MessageBox.Show(_sourceCode.ErrorBlankFind);
                        }
                        else
                        {
                            _sourceCode.FindAndDisplay("CHUNGTU", "DanToc", cbDanToc.Text, listViewChungTu);
                        }
                        break;
                    case 6:
                        if (cbQuocTich.Text.Equals(""))
                        {
                            MessageBox.Show(_sourceCode.ErrorBlankFind);
                        }
                        else
                        {
                            _sourceCode.FindAndDisplay("CHUNGTU", "QuocTich", cbQuocTich.Text, listViewChungTu);
                        }
                        break;
                    case 9:
                        if (cbGio.Text.Equals("") || cbPhut.Text.Equals(""))
                        {
                            MessageBox.Show(_sourceCode.ErrorBlankFind);
                        }
                        else
                        {
                            _sourceCode.FindAndDisplay("CHUNGTU", "GioMat", cbGio.Text + ":" + cbPhut.Text, listViewChungTu);
                        }
                        break;
                    case 10:
                        if (cbQueQuan.Text.Equals(""))
                        {
                            MessageBox.Show(_sourceCode.ErrorBlankFind);
                        }
                        else
                        {
                            _sourceCode.FindAndDisplay("CHUNGTU", "KVDK", cbQueQuan.Text, listViewChungTu);
                        }
                        break;
                }
            }

            if (cbKetHon.Visible)
            {
                index = cbKetHon.SelectedIndex;
                switch (index)
                {
                    case -1:
                        MessageBox.Show(_sourceCode.ErrorBlankFindItem);
                        break;
                    case 0:
                    case 1:
                    case 5:
                    case 6:
                    case 10:
                        if (txtInput.Text == "")
                        {
                            MessageBox.Show(_sourceCode.ErrorBlankFind);
                        }
                        else
                        {
                            switch (index)
                            {
                                case 0:
                                    _sourceCode.FindAndDisplay("KETHON", "MKH", txtInput.Text, listViewKetHon);
                                    break;
                                case 1:
                                    _sourceCode.FindAndDisplay("KETHON", "TenChong", txtInput.Text, listViewKetHon);
                                    break;
                                case 5:
                                    _sourceCode.FindAndDisplay("KETHON", "CMNDChong", txtInput.Text, listViewKetHon);
                                    break;
                                case 6:
                                    _sourceCode.FindAndDisplay("KETHON", "TenVo", txtInput.Text, listViewKetHon);
                                    break;
                                case 10:
                                    _sourceCode.FindAndDisplay("KETHON", "CMNDVo", txtInput.Text, listViewKetHon);
                                    break;
                            }
                        }
                        break;
                    case 2:
                    case 7:
                    case 12:
                        if (cbNgay.Text.Equals("") || cbThang.Text.Equals("") || cbNam.Text.Equals(""))
                        {
                            MessageBox.Show(_sourceCode.ErrorBlankFind);
                        }
                        else
                        {
                            switch (index)
                            {
                                case 2:
                                    _sourceCode.FindAndDisplay("KETHON", "NgaySinhChong", cbNgay.Text + "/" + cbThang.Text + "/" + cbNam.Text, listViewKetHon);
                                    break;
                                case 7:
                                    _sourceCode.FindAndDisplay("KETHON", "NgaySinhVo", cbNgay.Text + "/" + cbThang.Text + "/" + cbNam.Text, listViewKetHon);
                                    break;
                                case 12:
                                    _sourceCode.FindAndDisplay("KETHON", "NgayDK", cbNgay.Text + "/" + cbThang.Text + "/" + cbNam.Text, listViewKetHon);
                                    break;
                            }
                        }
                        break;
                    case 3:
                    case 8:
                        if (cbDanToc.Text.Equals(""))
                        {
                            MessageBox.Show(_sourceCode.ErrorBlankFind);
                        }
                        else
                        {
                            switch (index)
                            {
                                case 3:
                                    _sourceCode.FindAndDisplay("KETHON", "DanTocChong", cbDanToc.Text, listViewKetHon);
                                    break;
                                case 8:
                                    _sourceCode.FindAndDisplay("KETHON", "DanTocVo", cbDanToc.Text, listViewKetHon);
                                    break;
                            }
                        }
                        break;
                    case 4:
                    case 9:
                    case 11:
                        if (cbQueQuan.Text.Equals(""))
                        {
                            MessageBox.Show(_sourceCode.ErrorBlankFind);
                        }
                        else
                        {
                            switch (index)
                            {
                                case 4:
                                    _sourceCode.FindAndDisplay("KETHON", "QueQuanChong", cbQueQuan.Text, listViewKetHon);
                                    break;
                                case 9:
                                    _sourceCode.FindAndDisplay("KETHON", "QueQuanVo", cbQueQuan.Text, listViewKetHon);
                                    break;
                                case 11:
                                    _sourceCode.FindAndDisplay("KETHON", "KVDK", cbQueQuan.Text, listViewKetHon);
                                    break;
                            }
                        }
                        break;
                }
            }

            if (cbTamTru.Visible)
            {
                index = cbKetHon.SelectedIndex;
                switch (index)
                {
                    case -1:
                        MessageBox.Show(_sourceCode.ErrorBlankFindItem);
                        break;
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                        if (txtInput.Text == "")
                        {
                            MessageBox.Show(_sourceCode.ErrorBlankFind);
                        }
                        else
                        {
                            switch (index)
                            {
                                case 0:
                                    _sourceCode.FindAndDisplay("TAMTRU", "MTT", txtInput.Text, listViewTamTru);
                                    break;
                                case 1:
                                    _sourceCode.FindAndDisplay("TAMTRU", "MNK", txtInput.Text, listViewTamTru);
                                    break;
                                case 2:
                                    _sourceCode.FindAndDisplay("TAMTRU", "TenNoiTamTru", txtInput.Text, listViewTamTru);
                                    break;
                                case 3:
                                    _sourceCode.FindAndDisplay("TAMTRU", "SoDienThoai", txtInput.Text, listViewTamTru);
                                    break;
                            }
                        }
                        break;
                    case 4:
                        if (cbNgay.Text.Equals("") || cbThang.Text.Equals("") || cbNam.Text.Equals(""))
                        {
                            MessageBox.Show(_sourceCode.ErrorBlankFind);
                        }
                        else
                        {
                            _sourceCode.FindAndDisplay("TAMTRU", "ThoiHan", cbNgay.Text + "/" + cbThang.Text + "/" + cbNam.Text, listViewTamTru);
                        }
                        break;
                }
            }

            if (!cbTienAnTienSu.Visible) return;
            index = cbKetHon.SelectedIndex;
            switch (index)
            {
                case -1:
                    MessageBox.Show(_sourceCode.ErrorBlankFindItem);
                    break;
                case 0:
                case 1:
                case 2:
                    if (txtInput.Text == "")
                    {
                        MessageBox.Show(_sourceCode.ErrorBlankFind);
                    }
                    else
                    {
                        switch (index)
                        {
                            case 0:
                                _sourceCode.FindAndDisplay("TIENANTIENSU", "MaTATS", txtInput.Text, listViewTienAnTienSu);
                                break;
                            case 1:
                                _sourceCode.FindAndDisplay("TIENANTIENSU", "MNK", txtInput.Text, listViewTienAnTienSu);
                                break;
                            case 2:
                                _sourceCode.FindAndDisplay("TIENANTIENSU", "TenTATS", txtInput.Text, listViewTienAnTienSu);
                                break;
                        }
                    }
                    break;
                case 3:
                    if (cbQueQuan.Text.Equals(""))
                    {
                        MessageBox.Show(_sourceCode.ErrorBlankFind);
                    }
                    else
                    {
                        _sourceCode.FindAndDisplay("TIENANTIENSU", "NoiXetXu", cbQueQuan.Text, listViewTienAnTienSu);
                    }
                    break;
                case 4:
                    if (cbNgay.Text.Equals("") || cbThang.Text.Equals("") || cbNam.Text.Equals(""))
                    {
                        MessageBox.Show(_sourceCode.ErrorBlankFind);
                    }
                    else
                    {
                        _sourceCode.FindAndDisplay("TIENANTIENSU", "NgayThucThi", cbNgay.Text + "/" + cbThang.Text + "/" + cbNam.Text, listViewTienAnTienSu);
                    }
                    break;
            }
        }
        
        //-------------------------------------------LƯU THÔNG TIN KHI CLICK VÀO ĐỐI TƯỢNG
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count <= 0) return;
            var selectedItems = listView1.SelectedItems;
            for (var i = 0; i < _itemNhanKhau.Length; i++)
            {
                _itemNhanKhau[i] = selectedItems[0].SubItems[i].Text;
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedIndices.Count <= 0) return;
            var selectedItems = listView2.SelectedItems;
            for (var i = 0; i < _itemHoKhau.Length; i++)
            {
                _itemHoKhau[i] = selectedItems[0].SubItems[i].Text;
            }
        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView3.SelectedIndices.Count <= 0) return;
            var selectedItems = listView3.SelectedItems;
            for (var i = 0; i < _itemTamTru.Length; i++)
            {
                _itemTamTru[i] = selectedItems[0].SubItems[i].Text;
            }
        }

        private void listView4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView4.SelectedIndices.Count <= 0) return;
            var selectedItems = listView4.SelectedItems;
            for (var i = 0; i < _itemChungTu.Length; i++)
            {
                _itemChungTu[i] = selectedItems[0].SubItems[i].Text;
            }
        }

        private void listView5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView5.SelectedIndices.Count <= 0) return;
            var selectedItems = listView5.SelectedItems;
            for (var i = 0; i < _itemKetHon.Length; i++)
            {
                _itemKetHon[i] = selectedItems[0].SubItems[i].Text;
            }
        }

        private void listView6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView6.SelectedIndices.Count <= 0) return;
            var selectedItems = listView6.SelectedItems;
            for (var i = 0; i < _itemTienAnTienSu.Length; i++)
            {
                _itemTienAnTienSu[i] = selectedItems[0].SubItems[i].Text;
            }
        }

        private void listView7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView7.SelectedIndices.Count <= 0) return;
            var selectedItems = listView7.SelectedItems;
            for (var i = 0; i < _itemTaiKhoan.Length; i++)
            {
                _itemTaiKhoan[i] = selectedItems[0].SubItems[i].Text;
            }
        }

        //--------------------------------------------------------------SỰ KIỆN CHO TABPAGE
        private void materialTabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            var tabpageIndex = e.TabPageIndex;
            TabpageSelect(tabpageIndex);
            HideMainButton();
            switch (tabpageIndex)
            {
                case 0: if (_flagNhanKhau) { ShowMainButton(); } break;
                case 1: if (_flagHoKhau) { ShowMainButton(); } break;
                case 2: if (_flagTamTru) { ShowMainButton(); } break;
                case 3: if (_flagChungTu) { ShowMainButton(); } break;
                case 4: if (_flagKetHon) { ShowMainButton(); } break;
                case 5: if (_flagTienAnTienSu) { ShowMainButton(); } break;
                case 7: if (_flagTaiKhoan) { ShowMainButton(); btnPhanQuyen.Visible = true;} break;
            }
        }

        //--------------------------------------------------------------BTN TABPAGE TRA CUU
        private void btnNhanKhau_Click(object sender, EventArgs e)
        {
            HideTitleAndListViewAndComboBox();
            HideComboboxChange();
            txtInput.Visible = true;
            lblTimNhanKhau.Visible = true;
            listViewNhanKhau.Visible = true;
            cbNhanKhau.Visible = true;
        }

        private void btnHoKhau_Click(object sender, EventArgs e)
        {
            HideTitleAndListViewAndComboBox();
            HideComboboxChange();
            txtInput.Visible = true;
            lblTimHoKhau.Visible = true;
            listViewHoKhau.Visible = true;
            cbHoKhau.Visible = true;
        }

        private void btnTamTru_Click(object sender, EventArgs e)
        {
            HideTitleAndListViewAndComboBox();
            HideComboboxChange();
            txtInput.Visible = true;
            lblTimTamTru.Visible = true;
            listViewTamTru.Visible = true;
            cbTamTru.Visible = true;
        }

        private void btnChungTu_Click(object sender, EventArgs e)
        {
            HideTitleAndListViewAndComboBox();
            HideComboboxChange();
            txtInput.Visible = true;
            lblTimChungTu.Visible = true;
            listViewChungTu.Visible = true;
            cbChungTu.Visible = true;
        }

        private void btnKetHon_Click(object sender, EventArgs e)
        {
            HideTitleAndListViewAndComboBox();
            HideComboboxChange();
            txtInput.Visible = true;
            lblKetHon.Visible = true;
            listViewKetHon.Visible = true;
            cbKetHon.Visible = true;
        }

        private void btnTienAnTienSu_Click(object sender, EventArgs e)
        {
            HideTitleAndListViewAndComboBox();
            HideComboboxChange();
            txtInput.Visible = true;
            lblTienAnTienSu.Visible = true;
            listViewTienAnTienSu.Visible = true;
            cbTienAnTienSu.Visible = true;
        }
        
        //-----------------------------------------------------------COMBOX TABPAGE TRA CUU
        private void cbNhanKhau_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = cbNhanKhau.SelectedIndex;
            HideComboboxChange();
            switch (index)
            {
                case 0:
                    txtInput.Visible = true;
                    txtInput.Text = @"MNK-";
                    break;
                case 2:
                    lblDauGach1.Visible = true;
                    lblDauGach2.Visible = true;
                    cbNgay.Visible = true;
                    cbThang.Visible = true;
                    cbNam.Visible = true;
                    break;
                case 3:
                    rdTimNam.Visible = true;
                    rdTimNu.Visible = true;
                    panel1.Visible = true;
                    break;
                case 4:
                    cbQueQuan.Visible = true;
                    break;
                case 5:
                    cbTonGiao.Visible = true;
                    break;
                case 6:
                    cbDanToc.Visible = true;
                    break;
                default:
                    txtInput.Visible = true;
                    txtInput.Text = "";
                    break;
            }
        }

        private void cbHoKhau_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = cbHoKhau.SelectedIndex;
            HideComboboxChange();
            switch (index)
            {
                case 0:
                    txtInput.Visible = true;
                    txtInput.Text = @"MHK-";
                    break;
                case 3:
                    cbQueQuan.Visible = true;
                    break;
                case 4:
                    lblDauGach1.Visible = true;
                    lblDauGach2.Visible = true;
                    cbNgay.Visible = true;
                    cbThang.Visible = true;
                    cbNam.Visible = true;
                    break;
                default:
                    txtInput.Visible = true;
                    txtInput.Text = "";
                    break;
            }
        }

        private void cbTamTru_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = cbTamTru.SelectedIndex;
            HideComboboxChange();
            switch (index)
            {
                case 0:
                    txtInput.Visible = true;
                    txtInput.Text = @"MTT-";
                    break;
                case 4:
                    lblDauGach1.Visible = true;
                    lblDauGach2.Visible = true;
                    cbNgay.Visible = true;
                    cbThang.Visible = true;
                    cbNam.Visible = true;
                    break;
                default:
                    txtInput.Visible = true;
                    txtInput.Text = "";
                    break;
            }
        }

        private void cbChungTu_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = cbChungTu.SelectedIndex;
            HideComboboxChange();
            switch (index)
            {
                case 0:
                    txtInput.Visible = true;
                    txtInput.Text = @"MCT-";
                    break;
                case 2:
                    cbQuanHe.Visible = true;
                    break;
                case 4:
                case 8:
                case 11:
                    lblDauGach1.Visible = true;
                    lblDauGach2.Visible = true;
                    cbNgay.Visible = true;
                    cbThang.Visible = true;
                    cbNam.Visible = true;
                    break;
                case 5:
                    cbDanToc.Visible = true;
                    break;
                case 6:
                    cbQuocTich.Visible = true;
                    break;
                case 9:
                    cbGio.Visible = true;
                    cbPhut.Visible = true;
                    lblDauHaiCham.Visible = true;
                    break;
                case 10:
                    cbQueQuan.Visible = true;
                    break;
                default:
                    txtInput.Visible = true;
                    txtInput.Text = "";
                    break;
            }
        }

        private void cbKetHon_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = cbKetHon.SelectedIndex;
            HideComboboxChange();
            switch (index)
            {
                case 0:
                    txtInput.Visible = true;
                    txtInput.Text = @"MKH-";
                    break;
                case 2:
                case 7:
                case 12:
                    lblDauGach1.Visible = true;
                    lblDauGach2.Visible = true;
                    cbNgay.Visible = true;
                    cbThang.Visible = true;
                    cbNam.Visible = true;
                    break;
                case 3:
                case 8:
                    cbDanToc.Visible = true;
                    break;
                case 4:
                case 9:
                    cbQuocTich.Visible = true;
                    break;
                case 11:
                    cbQueQuan.Visible = true;
                    break;
                default:
                    txtInput.Visible = true;
                    txtInput.Text = "";
                    break;
            }
        }

        private void cbTienAnTienSu_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = cbTienAnTienSu.SelectedIndex;
            HideComboboxChange();
            switch (index)
            {
                case 0:
                    txtInput.Visible = true;
                    txtInput.Text = @"TATS-";
                    break;
                case 2:
                    cbQueQuan.Visible = true;
                    break;
                case 3:
                    lblDauGach1.Visible = true;
                    lblDauGach2.Visible = true;
                    cbNgay.Visible = true;
                    cbThang.Visible = true;
                    cbNam.Visible = true;
                    break;
                default:
                    txtInput.Visible = true;
                    txtInput.Text = "";
                    break;
            }
        }

        //----------------------------------------------------------------------HIDE/SHOW
        private void HideTabpageTraCuu()
        {
            materialTabControl1.SetBounds(2, 110, 1372, 450);
            ShowMainButton();
            materialDivider2.Visible = true;
            if (btnSua.Text == @"Đổi mật khẩu")
            {
                btnSua.Text = @"Sửa";
            }
        }

        private void HideTabpageTaiKhoan()
        {
            btnPhanQuyen.Visible = false;
            btnSua.SetBounds(375, 554, 154, 70);
            btnXoa.SetBounds(591, 554, 154, 70);
            btnThem.SetBounds(802, 554, 154, 70);
        }

        private void ShowTabpageTaiKhoan()
        {
            btnSua.Text = @"Đổi mật khẩu";
            btnPhanQuyen.Visible = true;
            btnPhanQuyen.SetBounds(270, 554, 154, 70);
            btnSua.SetBounds(485, 554, 154, 70);
            btnXoa.SetBounds(700, 554, 154, 70);
            btnThem.SetBounds(910, 554, 154, 70);
        }

        private void HideTitleAndListViewAndComboBox()
        {
            lblTimChungTu.Visible = false;
            lblTimHoKhau.Visible = false;
            lblTimNhanKhau.Visible = false;
            lblTimTamTru.Visible = false;
            lblKetHon.Visible = false;
            lblTienAnTienSu.Visible = false;

            listViewKetHon.Visible = false;
            listViewKetHon.Items.Clear();
            listViewTamTru.Visible = false;
            listViewTamTru.Items.Clear();
            listViewNhanKhau.Visible = false;
            listViewNhanKhau.Items.Clear();
            listViewHoKhau.Visible = false;
            listViewHoKhau.Items.Clear();
            listViewChungTu.Visible = false;
            listViewChungTu.Items.Clear();
            listViewTienAnTienSu.Visible = false;
            listViewTienAnTienSu.Items.Clear();

            cbChungTu.Visible = false;
            cbChungTu.SelectedIndex = -1;
            cbHoKhau.Visible = false;
            cbHoKhau.SelectedIndex = -1;
            cbKetHon.Visible = false;
            cbKetHon.SelectedIndex = -1;
            cbNhanKhau.Visible = false;
            cbNhanKhau.SelectedIndex = -1;
            cbTamTru.Visible = false;
            cbTamTru.SelectedIndex = -1;
            cbTienAnTienSu.Visible = false;
            cbTienAnTienSu.SelectedIndex = -1;
        }

        private void HideComboboxChange()
        {
            panel1.Visible = false;
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

        private void ShowTabpageTraCuu()
        {
            materialTabControl1.SetBounds(2, 110, 1372, 500);
            HideMainButton();
            materialDivider2.Visible = false;
            btnPhanQuyen.Visible = false;
        }

        private void HideMainButton()
        {
            btnThem.Visible = false;
            btnXoa.Visible = false;
            btnSua.Visible = false;
            btnPhanQuyen.Visible = false;
        }

        private void ShowMainButton()
        {
            btnThem.Visible = true;
            btnXoa.Visible = true;
            btnSua.Visible = true;
        }

        private void TabpageSelect(int tabpageIndex)
        {
            switch (tabpageIndex)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    HideTabpageTraCuu(); HideTabpageTaiKhoan();
                    switch (tabpageIndex)
                    {
                        case 0:
                            _sourceCode.DisplayNhanKhau(listView1, 0);
                            break;
                        case 1:
                            _sourceCode.DisplayHoKhau(listView2, 0);
                            break;
                        case 2:
                            _sourceCode.DisplayTamTru(listView3);
                            break;
                        case 3:
                            _sourceCode.DisplayChungTu(listView4);
                            break;
                        case 4:
                            _sourceCode.DisplayKetHon(listView5);
                            break;
                        default:
                            _sourceCode.DisplayTienAnTienSu(listView6);
                            break;
                    }
                    break;
                case 6:
                    HideTabpageTaiKhoan(); ShowTabpageTraCuu();
                    break;
                default:
                    HideTabpageTraCuu(); ShowTabpageTaiKhoan(); _sourceCode.DisplayTaiKhoan(listView7);
                    break;
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

        //--------------------------------------------------------X Button to close program
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (_logOut) return;
            switch (MessageBox.Show(this, @"Thoát khỏi chương trình ?", @"Xác nhận thoát", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    Environment.Exit(1);
                    break;
            }
        }

        //-----------------------------------------------------------------------Phan Quyen
        private void SetAuthorities(string phanQuyen)
        {
            switch (phanQuyen)
            {
                case "1": materialTabControl1.SelectedTab = tabPage8; _sourceCode.DisplayTaiKhoan(listView7); ShowTabpageTaiKhoan(); _flagTaiKhoan = true; break;
                case "2": materialTabControl1.SelectedTab = tabPage1; _sourceCode.DisplayNhanKhau(listView1, 0); _flagNhanKhau = true; materialTabControl1.TabPages.Remove(tabPage8); break;
                case "3": materialTabControl1.SelectedTab = tabPage2; _sourceCode.DisplayHoKhau(listView2, 0); _flagHoKhau = true; materialTabControl1.TabPages.Remove(tabPage8); break;
                case "4": materialTabControl1.SelectedTab = tabPage3; _sourceCode.DisplayTamTru(listView3); _flagTamTru = true; materialTabControl1.TabPages.Remove(tabPage8); break;
                case "5": materialTabControl1.SelectedTab = tabPage4; _sourceCode.DisplayChungTu(listView4); _flagChungTu = true; materialTabControl1.TabPages.Remove(tabPage8); break;
                case "6": materialTabControl1.SelectedTab = tabPage5; _sourceCode.DisplayKetHon(listView5); _flagKetHon = true; materialTabControl1.TabPages.Remove(tabPage8); break;
                case "7": materialTabControl1.SelectedTab = tabPage6; _sourceCode.DisplayTienAnTienSu(listView6); _flagTienAnTienSu = true; materialTabControl1.TabPages.Remove(tabPage8); break;
            }
        }

        //---------------------------------------------------------------------Change color
        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            _colorSchemeIndex++;
            if (_colorSchemeIndex > 5)
                _colorSchemeIndex = 0;
            var rValue = 0;
            var gValue = 0;
            var bValue = 0;
            switch (_colorSchemeIndex)
            {
                case 0:
                    rValue = 55; gValue = 71; bValue = 79;
                    MaterialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
                    break;
                case 1:
                    rValue = 38; gValue = 166; bValue = 154;
                    MaterialSkinManager.ColorScheme = new ColorScheme(Primary.Teal400, Primary.Teal600, Primary.Teal200, Accent.DeepOrange700, TextShade.WHITE);
                    break;
                case 2:
                    rValue = 76; gValue = 175; bValue = 80;
                    MaterialSkinManager.ColorScheme = new ColorScheme(Primary.Green500, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);
                    break;
                case 3:
                    rValue = 63; gValue = 81; bValue = 181;
                    MaterialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
                    break;
                case 4:
                    rValue = 156; gValue = 39; bValue = 176;
                    MaterialSkinManager.ColorScheme = new ColorScheme(Primary.Purple500, Primary.Purple700, Primary.Purple200, Accent.Yellow200, TextShade.WHITE);
                    break;
                case 5:
                    rValue = 244; gValue = 67; bValue = 54;
                    MaterialSkinManager.ColorScheme = new ColorScheme(Primary.Red500, Primary.Red900, Primary.Red400, Accent.Green400, TextShade.WHITE);
                    break;
            }
            //MessageBox.Show(materialSkinManager.ColorScheme.DarkPrimaryColor.Name);
            lblUserName.BackColor = System.Drawing.Color.FromArgb((byte)(rValue), (byte)(gValue), (byte)(bValue));
            lblClock.BackColor = System.Drawing.Color.FromArgb((byte)(rValue), (byte)(gValue), (byte)(bValue));
            lblDate.BackColor = System.Drawing.Color.FromArgb((byte)(rValue), (byte)(gValue), (byte)(bValue));
        }

        private void ChangeColor()
        {
            var rValue = 0;
            var gValue = 0;
            var bValue = 0;
            switch (MaterialSkinManager.ColorScheme.DarkPrimaryColor.Name)
            {
                case "ff00897b": rValue = 38; gValue = 166; bValue = 154; break;
                case "ff303f9f": rValue = 63; gValue = 81; bValue = 181; break;
                case "ff388e3c": rValue = 76; gValue = 175; bValue = 80; break;
                case "ff263238": rValue = 55; gValue = 71; bValue = 79; break;
                case "ff7b1fa2": rValue = 156; gValue = 39; bValue = 176; break;
                case "ffb71c1c": rValue = 244; gValue = 67; bValue = 54; break;
            }
            lblUserName.BackColor = System.Drawing.Color.FromArgb((byte)(rValue), (byte)(gValue), (byte)(bValue));
            lblClock.BackColor = System.Drawing.Color.FromArgb((byte)(rValue), (byte)(gValue), (byte)(bValue));
            lblDate.BackColor = System.Drawing.Color.FromArgb((byte)(rValue), (byte)(gValue), (byte)(bValue));
        }

        private void btnChangeTextColor_Click(object sender, EventArgs e)
        {
            _textColorSchemeIndex++;
            if (_textColorSchemeIndex > 4)
                _textColorSchemeIndex = 0;
            var rValue = 0;
            var gValue = 0;
            var bValue = 0;
            switch (_textColorSchemeIndex)
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
            listViewNhanKhau.ForeColor = System.Drawing.Color.FromArgb((byte)(rValue), (byte)(gValue), (byte)(bValue));
            listViewHoKhau.ForeColor = System.Drawing.Color.FromArgb((byte)(rValue), (byte)(gValue), (byte)(bValue));
            listViewChungTu.ForeColor = System.Drawing.Color.FromArgb((byte)(rValue), (byte)(gValue), (byte)(bValue));
            listViewKetHon.ForeColor = System.Drawing.Color.FromArgb((byte)(rValue), (byte)(gValue), (byte)(bValue));
            listViewTamTru.ForeColor = System.Drawing.Color.FromArgb((byte)(rValue), (byte)(gValue), (byte)(bValue));
            listViewTienAnTienSu.ForeColor = System.Drawing.Color.FromArgb(((((byte)(rValue)))), (byte)(gValue), (byte)(bValue));
            listView1.ForeColor = System.Drawing.Color.FromArgb(((((byte)(rValue)))), (byte)(gValue), (byte)(bValue));
            listView2.ForeColor = System.Drawing.Color.FromArgb(((((byte)(rValue)))), (byte)(gValue), (byte)(bValue));
            listView3.ForeColor = System.Drawing.Color.FromArgb(((((byte)(rValue)))), (byte)(gValue), (byte)(bValue));
            listView4.ForeColor = System.Drawing.Color.FromArgb((byte)(rValue), (byte)(gValue), (byte)(bValue));
            listView5.ForeColor = System.Drawing.Color.FromArgb((byte)(rValue), (byte)(gValue), (byte)(bValue));
            listView6.ForeColor = System.Drawing.Color.FromArgb((byte)(rValue), (byte)(gValue), (byte)(bValue));
            listView7.ForeColor = System.Drawing.Color.FromArgb((byte)(rValue), (byte)(gValue), (byte)(bValue));
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            var text = txtInput.Text;
            if (cbNhanKhau.Visible && cbNhanKhau.SelectedIndex == 0)
            {
                if (text.Length < 4                 || text.Equals("")                  ||
                    !text[0].ToString().Equals("M") || !text[1].ToString().Equals("N")  ||
                    !text[2].ToString().Equals("K") || !text[3].ToString().Equals("-"))
                {
                    txtInput.Text = @"MNK-";
                }
            }
            if (cbHoKhau.Visible && cbHoKhau.SelectedIndex == 0)
            {
                if (text.Length < 4                 || text.Equals("")                  ||
                    !text[0].ToString().Equals("M") || !text[1].ToString().Equals("H")  ||
                    !text[2].ToString().Equals("K") || !text[3].ToString().Equals("-"))
                {
                    txtInput.Text = @"MHK-";
                }
            }
            if (cbTamTru.Visible && cbTamTru.SelectedIndex == 0)
            {
                if (text.Length < 4                 || text.Equals("")                  ||
                    !text[0].ToString().Equals("M") || !text[1].ToString().Equals("T")  ||
                    !text[2].ToString().Equals("T") || !text[3].ToString().Equals("-"))
                {
                    txtInput.Text = @"MTT-";
                }
            }
            if (cbChungTu.Visible && cbChungTu.SelectedIndex == 0)
            {
                if (text.Length < 4                 || text.Equals("")                  ||
                    !text[0].ToString().Equals("M") || !text[1].ToString().Equals("C")  ||
                    !text[2].ToString().Equals("T") || !text[3].ToString().Equals("-"))
                {
                    txtInput.Text = @"MCT-";
                }
            }
            if (cbKetHon.Visible && cbKetHon.SelectedIndex == 0)
            {
                if (text.Length < 4                 || text.Equals("")                  ||
                    !text[0].ToString().Equals("M") || !text[1].ToString().Equals("K")  ||
                    !text[2].ToString().Equals("H") || !text[3].ToString().Equals("-"))
                {
                    txtInput.Text = @"MKH-";
                }
            }
            if (cbTienAnTienSu.Visible && cbTienAnTienSu.SelectedIndex == 0)
            {
                if (text.Length < 5                 || text.Equals("")                  ||
                    !text[0].ToString().Equals("T") || !text[1].ToString().Equals("A")  ||
                    !text[2].ToString().Equals("T") || !text[3].ToString().Equals("S")  ||
                    !text[4].ToString().Equals("-"))
                {
                    txtInput.Text = @"TATS-";
                }
            }
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbNhanKhau.Visible && cbNhanKhau.SelectedIndex == 0)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    e.Handled = true;
            }
            if (cbHoKhau.Visible && cbHoKhau.SelectedIndex == 0)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    e.Handled = true;
            }
            if (cbTamTru.Visible && cbTamTru.SelectedIndex == 0)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    e.Handled = true;
            }
            if (cbChungTu.Visible && cbChungTu.SelectedIndex == 0)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    e.Handled = true;
            }
            if (cbKetHon.Visible && cbKetHon.SelectedIndex == 0)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    e.Handled = true;
            }
            if (cbTienAnTienSu.Visible && cbTienAnTienSu.SelectedIndex == 0)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    e.Handled = true;
            }
        }

    }
}
