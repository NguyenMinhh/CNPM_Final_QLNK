using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNK
{
    public partial class HoKhau : Form
    {
        SourceCode sc = new SourceCode();
        private string mhk = "";
        private bool flagSave = false;
        public HoKhau()
        {
            InitializeComponent();
            sc.displayHoKhau(listView2, 1);
        }
        public string getMHK()
        {
            return mhk;
        }
        public bool getFlagSave()
        {
            return flagSave;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedIndices.Count > 0)
            {
                flagSave = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hộ khẩu!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedIndices.Count > 0)
            {
                int index = listView2.FocusedItem.Index;
                var selectedItems = listView2.SelectedItems;
                mhk = selectedItems[0].SubItems[0].Text;
            }
        }
    }
}
