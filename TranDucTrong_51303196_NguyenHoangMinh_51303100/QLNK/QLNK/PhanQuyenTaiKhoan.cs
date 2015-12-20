using System.Windows.Forms;
using MaterialSkin.Controls;
using System;

namespace QLNK
{
    public partial class PhanQuyenTaiKhoan : MaterialForm
    {
        readonly SourceCode _sourceCode = new SourceCode();
        private readonly string[] _itemTaiKhoan;
        private bool _flagSave;
        public PhanQuyenTaiKhoan(string[] itemTaiKhoan)
        {
            InitializeComponent();
            _itemTaiKhoan = itemTaiKhoan;
            SetNormal(itemTaiKhoan);
        }

        private void SetNormal(string[] items)
        {
            txtTenDangNhap.Text = items[0];
            switch (items[3])
            {
                case "Quản Lý Tài Khoản": cbQuyenHanh.SelectedIndex = 0; break;
                case "Quản Lý Nhân Khẩu": cbQuyenHanh.SelectedIndex = 1; break;
                case "Quản Lý Hộ Khẩu": cbQuyenHanh.SelectedIndex = 2; break;
                case "Quản Lý Tạm Trú": cbQuyenHanh.SelectedIndex = 3; break;
                case "Quản Lý Chứng Tử": cbQuyenHanh.SelectedIndex = 4; break;
                case "Quản Lý Chứng Nhận Kết Hôn": cbQuyenHanh.SelectedIndex = 5; break;
                case "Quản Lý Tiền Án Tiền Sự": cbQuyenHanh.SelectedIndex = 6; break;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var tenDangNhap = txtTenDangNhap.Text;
            var phanQuyen = 0;
            var ngayCapNhat = DateTime.Now.ToString("dd/MM/yyyy") + " " + DateTime.Now.ToString("HH:mm:ss");
            switch (cbQuyenHanh.Text)
            {
                case "Quản Lý Tài Khoản": phanQuyen = 1; break;
                case "Quản Lý Nhân Khẩu": phanQuyen = 2; break;
                case "Quản Lý Hộ Khẩu": phanQuyen = 3; break;
                case "Quản Lý Tạm Trú": phanQuyen = 4; break;
                case "Quản Lý Chứng Tử": phanQuyen = 5; break;
                case "Quản Lý Chứng Nhận Kết Hôn": phanQuyen = 6; break;
                case "Quản Lý Tiền Án Tiền Sự": phanQuyen = 7; break;
            }
            var dialogResult = MessageBox.Show(_sourceCode.MsgboxUpdate, _sourceCode.MsgboxCapUpdate, MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes) return;
            _flagSave = true;
            if (!_sourceCode.UpdatePhanQuyen(tenDangNhap, phanQuyen, ngayCapNhat)) return;
            Close();
            MessageBox.Show(_sourceCode.SuccessUpdate);
        }

        private void PhanQuyenTaiKhoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_flagSave) return;
            var phanQuyen = 0;
            switch (cbQuyenHanh.Text)
            {
                case "Quản Lý Tài Khoản": phanQuyen = 1; break;
                case "Quản Lý Nhân Khẩu": phanQuyen = 2; break;
                case "Quản Lý Hộ Khẩu": phanQuyen = 3; break;
                case "Quản Lý Tạm Trú": phanQuyen = 4; break;
                case "Quản Lý Chứng Tử": phanQuyen = 5; break;
                case "Quản Lý Chứng Nhận Kết Hôn": phanQuyen = 6; break;
                case "Quản Lý Tiền Án Tiền Sự": phanQuyen = 7; break;
            }
            var tenDangNhap = txtTenDangNhap.Text;
            var quyenHanh = cbQuyenHanh.Text;
            var ngayCapNhat = DateTime.Now.ToString("dd/MM/yyyy") + " " + DateTime.Now.ToString("HH:mm:ss");
            if ((tenDangNhap.Equals(_itemTaiKhoan[0]) && quyenHanh.Equals(_itemTaiKhoan[3]))) return;
            var dialogResult = MessageBox.Show(_sourceCode.MsgboxUpdate, _sourceCode.MsgboxCapExit, MessageBoxButtons.YesNoCancel);
            switch (dialogResult)
            {
                case DialogResult.Yes:
                    if (_sourceCode.UpdatePhanQuyen(tenDangNhap, phanQuyen, ngayCapNhat))
                    {
                        MessageBox.Show(_sourceCode.SuccessUpdate);
                    }
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
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
                    var command = message.WParam.ToInt32() & 0xfff0;
                    if (command == scMove)
                        return;
                    break;
            }

            base.WndProc(ref message);
        }

    }
}
