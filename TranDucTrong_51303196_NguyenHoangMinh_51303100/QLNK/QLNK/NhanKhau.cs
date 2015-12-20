using System;
using System.Windows.Forms;

namespace QLNK
{
    public partial class NhanKhau :Form
    {
        readonly SourceCode _sourceCode = new SourceCode();
        private string _mnk = "";
        private bool _flagSave;
        public NhanKhau()
        {
            InitializeComponent();
            _sourceCode.DisplayNhanKhau(listView1, 1);
        }
        public string GetMnk()
        {
             return _mnk;
        }
        public bool GetFlagSave()
        {
            return _flagSave;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                _flagSave = true;
                Close();
            }
            else
            {
                MessageBox.Show(@"Vui lòng chọn nhân khẩu!");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count <= 0) return;
            var selectedItems = listView1.SelectedItems;
            _mnk = selectedItems[0].SubItems[0].Text;
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
