using System;
using System.Windows.Forms;

namespace QLNK
{
    public partial class NhanKhau :Form
    {
        SourceCode sc = new SourceCode();
        private string mnk = "";
        private bool flagSave = false;
        public NhanKhau()
        {
            InitializeComponent();
            sc.displayNhanKhau(listView1, 1);
        }
        public string getMNK()
        {
             return mnk;
        }
        public bool getFlagSave()
        {
            return flagSave;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                flagSave = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân khẩu!");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                int index = listView1.FocusedItem.Index;
                var selectedItems = listView1.SelectedItems;
                mnk = selectedItems[0].SubItems[0].Text;
            }
        }
    }
}
