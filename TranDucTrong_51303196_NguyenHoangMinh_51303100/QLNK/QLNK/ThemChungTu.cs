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

            string maChungTu = txtMaChungTu.Text;
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
                  thangSinh.Equals("")      || namSinh.Equals("")       || danToc.Equals("")        ||
                  quocTich.Equals("")       || cmnd.Equals("")          || ngayMat.Equals("")       ||
                  thangMat.Equals("")       || namMat.Equals("")        || gioMat.Equals("")        ||
                  phutMat.Equals("")        || cbQueQuan.Equals("")     || ngayDK.Equals("")        ||
                  thangDK.Equals("")        || namDK.Equals("")))
            {
                if (sc.addChungTu(maChungTu, tenNguoiKhai, thuongTamTru, qhVoiNguoiMat,
                                  tenNguoiMat, ngaySinhNguoiMat, danToc, quocTich, cmnd,
                                  ngayQuaDoi, thoiGianQuaDoi, khuVucDangKy, ngayDangKy))
                {
                    MessageBox.Show("Thêm thành công");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Điền đầy đủ rồi hẵng thêm");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaChungTu.Text = "";
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

        private void txtMaChungTu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
