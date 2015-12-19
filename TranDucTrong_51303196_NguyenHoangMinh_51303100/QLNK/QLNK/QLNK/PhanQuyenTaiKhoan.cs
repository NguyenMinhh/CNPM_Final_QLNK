using System.Windows.Forms;
using MaterialSkin.Controls;
using System;

namespace QLNK
{
    public partial class PhanQuyenTaiKhoan : MaterialForm
    {
        SourceCode sc = new SourceCode();
        private string[] itemTaiKhoan;
        private bool flagSave = false;
        public PhanQuyenTaiKhoan(string[] itemTaiKhoan)
        {
            InitializeComponent();
            this.itemTaiKhoan = itemTaiKhoan;
            setNormal(itemTaiKhoan);
        }

        private void setNormal(string[] items)
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

        private void btnLuu_Click(object sender, System.EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text;
            int phanQuyen = 0;
            string ngayCapNhat = DateTime.Now.ToString("dd/MM/yyyy") + " " + DateTime.Now.ToString("HH:mm:ss");
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
            DialogResult dialogResult = MessageBox.Show(sc.MSGBOX_UPDATE, sc.MSGBOX_CAP_UPDATE, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                flagSave = true;
                if (sc.updatePhanQuyen(tenDangNhap, phanQuyen, ngayCapNhat))
                {
                    this.Close();
                    MessageBox.Show(sc.SUCCESS_UPDATE);
                }
            }
        }

        private void PhanQuyenTaiKhoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flagSave == false)
            {
                int phanQuyen = 0;
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
                string tenDangNhap = txtTenDangNhap.Text;
                string quyenHanh = cbQuyenHanh.Text;
                string ngayCapNhat = DateTime.Now.ToString("dd/MM/yyyy") + " " + DateTime.Now.ToString("HH:mm:ss");
                if ((!tenDangNhap.Equals(itemTaiKhoan[0]) || !quyenHanh.Equals(itemTaiKhoan[3])))
                {
                    DialogResult dialogResult = MessageBox.Show(sc.MSGBOX_UPDATE,
                                                                sc.MSGBOX_CAP_EXIT, MessageBoxButtons.YesNoCancel);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (sc.updatePhanQuyen(tenDangNhap, phanQuyen, ngayCapNhat))
                        {
                            MessageBox.Show(sc.SUCCESS_UPDATE);
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

    }
}
