using System;
using System.Windows.Forms;

namespace QLNK
{
    public partial class HoKhau : Form
    {
        readonly SourceCode _sourceCode = new SourceCode();
        private string _mhk = "";
        private bool _flagSave;
        public HoKhau()
        {
            InitializeComponent();
            _sourceCode.DisplayHoKhau(listView2, 1);
        }
        public string GetMhk()
        {
            return _mhk;
        }
        public bool GetFlagSave()
        {
            return _flagSave;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedIndices.Count > 0)
            {
                _flagSave = true;
                Close();
            }
            else
            {
                MessageBox.Show(@"Vui lòng chọn hộ khẩu!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedIndices.Count <= 0) return;
            var selectedItems = listView2.SelectedItems;
            _mhk = selectedItems[0].SubItems[0].Text;
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
