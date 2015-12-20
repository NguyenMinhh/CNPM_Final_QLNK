namespace QLNK
{
    partial class HoKhau
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnLuu = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // listView2
            // 
            this.listView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader15});
            this.listView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.listView2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.listView2.FullRowSelect = true;
            this.listView2.Location = new System.Drawing.Point(0, 0);
            this.listView2.Margin = new System.Windows.Forms.Padding(0);
            this.listView2.Name = "listView2";
            this.listView2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listView2.Size = new System.Drawing.Size(361, 349);
            this.listView2.TabIndex = 14;
            this.listView2.TileSize = new System.Drawing.Size(1, 1);
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Mã Hộ Khẩu";
            this.columnHeader11.Width = 105;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Tên Chủ Hộ";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader12.Width = 202;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Địa Chỉ";
            this.columnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader15.Width = 640;
            // 
            // btnExit
            // 
            this.btnExit.Depth = 0;
            this.btnExit.Location = new System.Drawing.Point(138, 366);
            this.btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExit.Name = "btnExit";
            this.btnExit.Primary = true;
            this.btnExit.Size = new System.Drawing.Size(97, 50);
            this.btnExit.TabIndex = 295;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Depth = 0;
            this.btnLuu.Location = new System.Drawing.Point(252, 366);
            this.btnLuu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Primary = true;
            this.btnLuu.Size = new System.Drawing.Size(97, 50);
            this.btnLuu.TabIndex = 294;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // HoKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 429);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.listView2);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::QLNK.Properties.Settings.Default, "hokhau", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = global::QLNK.Properties.Settings.Default.hokhau;
            this.MaximizeBox = false;
            this.Name = "HoKhau";
            this.Text = "HỘ KHẨU";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private MaterialSkin.Controls.MaterialRaisedButton btnExit;
        private MaterialSkin.Controls.MaterialRaisedButton btnLuu;
    }
}