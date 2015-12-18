using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace QLNK
{
    class SourceCode
    {
        private static string DATASOURCE = "localhost";
        private static string PORT = "3306";
        private static string USERNAME = "root";
        private static string PASSWORD = "Trongheo1";
        private static string DATABASE = "qlnk";
        public string myConnection = "datasource=" + DATASOURCE + ";port=" + PORT
                                            + ";username=" + USERNAME + ";password=" + PASSWORD
                                            + ";database=" + DATABASE;
        //--------------------------------------------------------------------------EDIT DB

        public void editCSDL(string sql) { 
                MySqlConnection mcon = new MySqlConnection(myConnection);
                MySqlCommand MyCommand = new MySqlCommand(sql, mcon);
                MySqlDataReader MyReader;
                mcon.Open();
                MyReader = MyCommand.ExecuteReader();
                mcon.Close();
        }

        //--------------------------------------------------------------------------SỬA DB

        public Boolean updateHoKhau(string maHoKhau, string tenChuHo, string cmndChuHo,
                                    string khuVuc, string diaChi, string ngayLap)
        {
            string sql = "UPDATE HOKHAU SET TenChuHo = '" + tenChuHo
                                        + "',CMNDChuHo = '" + cmndChuHo + "',KhuVuc = '" + khuVuc
                                        + "',DiaChiHK = '" + diaChi + "',NgayLap = '" + ngayLap
                                        + "' WHERE MHK = '" + maHoKhau + "'";
            try
            {
                editCSDL(sql);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public Boolean updateNhanKhau(string maNhanKhau, string hoTen, string ngaySinh,
                                     string gioiTinh, string queQuan, string tonGiao,
                                     string danToc, string cmnd, string maHoKhau,
                                     string ngheNghiep)
        {
            string sql = "UPDATE NHANKHAU SET Ten = '" + hoTen + "',NgaySinh = '" + ngaySinh + "',"
                                        + "GioiTinh = '" + gioiTinh + "',QueQuan = '" + queQuan + "',"
                                        + "TonGiao = '" + tonGiao + "',DanToc = '" + danToc + "',"
                                        + "CMND = '" + cmnd + "'," + "MHK = '" + maHoKhau + "',"
                                        + "NgheNghiep = '" + ngheNghiep + "' WHERE MNK = '" + maNhanKhau + "'";
            try
            {
                editCSDL(sql);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public Boolean updateTamTru(string maTamTru, string maNhanKhau,
                                    string tenNoiTamTruDayDu, string diaChi,
                                    string soDienThoai, string thoiHan)
        {
            string sql = "UPDATE TAMTRU SET MNK = '" + maNhanKhau
                                        + "',TenNoiTamTru = '" + tenNoiTamTruDayDu
                                        + "',DiaChi = '" + diaChi + "',SoDienThoai = '" + soDienThoai
                                        + "',ThoiHan = '" + thoiHan + "' WHERE MTT = '" + maTamTru + "'";
            try
            {
                editCSDL(sql);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public Boolean updateKetHon(string maKetHon, string hoTenChong, string ngaySinhChong,
                                    string danTocChong, string quocTichChong, string thuongTamTruChong,
                                    string cmndChong, string hoTenVo, string ngaySinhVo,
                                    string danTocVo, string quocTichVo, string thuongTamTruVo,
                                    string cmndVo, string khuVucDangKy, string ngayDangKy)
        {
            string sql = "UPDATE KETHON SET TenChong = '" + hoTenChong + "',NgaySinhChong = '" + ngaySinhChong
                                        + "',DanTocChong = '" + danTocChong + "',QuocTichChong = '" + quocTichChong
                                        + "',ThuongTamTruChong = '" + thuongTamTruChong + "',CMNDChong = '" + cmndChong
                                        + "',TenVo = '" + hoTenVo + "',ngaySinhVo = '" + ngaySinhVo
                                        + "',DanTocVo = '" + danTocVo + "',QuocTichVo = '" + quocTichVo
                                        + "',ThuongTamTruVo = '" + thuongTamTruVo + "',CMNDVo = '" + cmndVo
                                        + "',KVDK = '" + khuVucDangKy + "',NgayDK = '" + ngayDangKy
                                        + "' WHERE MKH = '" + maKetHon + "'";
            try
            {
                editCSDL(sql);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public Boolean updateChungTu(string maChungTu, string tenNguoiKhai, string thuongTamTru,
                                     string qhVoiNguoiMat, string tenNguoiMat, string ngaySinh,
                                     string danToc, string quocTich, string cmnd, string ngayMat,
                                     string gioMat, string khuVucDangKy, string ngayDangKy)
        {
            string sql = "UPDATE CHUNGTU SET TenNguoiKhai = '" + tenNguoiKhai + "',ThuongTamTru = '" + thuongTamTru
                                        + "',QHVoiNguoiMat = '" + qhVoiNguoiMat + "',TenNguoiMat = '" + tenNguoiMat
                                        + "',NgaySinh = '" + ngaySinh + "',DanToc = '" + danToc
                                        + "',QuocTich = '" + quocTich + "',CMND = '" + cmnd
                                        + "',NgayMat = '" + ngayMat + "',GioMat = '" + gioMat
                                        + "',KVDK = '" + khuVucDangKy + "',NgayDK = '" + ngayDangKy
                                        + "' WHERE MCT = '" + maChungTu + "'";
            try
            {
                editCSDL(sql);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public Boolean updateTienAnTienSu(string maTienAnTienSu, string maNhanKhau,
                                          string tenTienAnTienSu, string noiXetXu,
                                          string ngayThucThi)
        {
            string sql = "UPDATE TIENANTIENSU SET MNK = '" + maNhanKhau + "',TenTATS = '" + tenTienAnTienSu
                                             + "',NoiXetXu = '" + noiXetXu + "',NgayThucThi = '" + ngayThucThi
                                             + "' WHERE MaTATS = '" + maTienAnTienSu + "'";
            try
            {
                editCSDL(sql);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        public Boolean updateMatKhau(string taiKhoan, string matKhauMoi, string ngayCapNhat)
        {
            string sql = "UPDATE CANBO SET MatKhau = '" + matKhauMoi + "',NgayCapNhat = '" + ngayCapNhat + "' WHERE TaiKhoan = '" + taiKhoan + "'";
            try
            {
                editCSDL(sql);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public Boolean updatePhanQuyen(string taiKhoan, int phanQuyen, string ngayCapNhat)
        {
            string sql = "UPDATE CANBO SET Quyen = '" + phanQuyen + "',NgayCapNhat = '" + ngayCapNhat + "' WHERE taiKhoan = '" + taiKhoan + "'";
            try
            {
                editCSDL(sql);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        //--------------------------------------------------------------------------THÊM DB

        public Boolean addNhanKhau(string maNhanKhau, string hoTen, string ngaySinh,
                                   string gioiTinh, string queQuan, string tonGiao,
                                   string danToc, string cmnd, string maHoKhau,
                                   string ngheNghiep)
        {
            string sql = "INSERT INTO NHANKHAU(MNK,Ten,NgaySinh,GioiTinh,"
                    + "QueQuan,TonGiao,DanToc,CMND,MHK,NgheNghiep)"
                    + " VALUES('" + maNhanKhau + "','" + hoTen + "','" + ngaySinh
                    + "','" + gioiTinh + "','" + queQuan + "','" + tonGiao
                    + "','" + danToc + "','" + cmnd + "','" + maHoKhau
                    + "','" + ngheNghiep + "')";
            try
            {
                editCSDL(sql);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public Boolean addHoKhau(string maHoKhau, string tenChuHo, string cmndChuHo,
                                 string khuVuc, string diaChi, string ngayLap)
        {
            string sql = "INSERT INTO HOKHAU(MHK,TenChuHo,CMNDChuHo,KhuVuc,DiaChiHK,NgayLap)"
                    + " VALUES('" + maHoKhau + "','" + tenChuHo + "','" +
                                  cmndChuHo + "','" + khuVuc + "','" +
                                  diaChi + "','" + ngayLap + "')";
            try
            {
                editCSDL(sql);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public Boolean addTamTru(string maTamTru, string maNhanKhau,
                                 string tenNoiTamTruDayDu, string diaChi,
                                 string soDienThoai, string thoiHan)
        {
            string sql = "INSERT INTO TAMTRU(MTT,MNK,TenNoiTamTru,"
                         + "DiaChi,SoDienThoai,ThoiHan) VALUES('"
                         + maTamTru + "','" + maNhanKhau + "','" + tenNoiTamTruDayDu
                         + "','" + diaChi + "','" + soDienThoai + "','" + thoiHan + "')";
            try
            {
                editCSDL(sql);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public Boolean addKetHon(string maKetHon, string hoTenChong, string ngaySinhChong, string danTocChong,
                                 string quocTichChong, string cmndChong, string thuongTamTruChong,
                                 string hoTenVo, string ngaySinhVo, string danTocVo, string quocTichVo,
                                 string thuongTamTruVo, string cmndVo, string khuVucDangKy, string ngayDangKy)
        {
            string sql = "INSERT INTO KETHON(MKH,TenChong,NgaySinhChong,DanTocChong,QuocTichChong,"
                                          + "ThuongTamTruChong,CMNDChong,TenVo,NgaySinhVo,DanTocVo,"
                                          + "QuocTichVo,ThuongTamTruVo,CMNDVo,KVDK,NgayDK) VALUES('"
                                          + maKetHon + "','" + hoTenChong + "','" + ngaySinhChong
                                          + "','" + danTocChong + "','" + quocTichChong
                                          + "','" + cmndChong + "','" + thuongTamTruChong
                                          + "','" + hoTenVo + "','" + ngaySinhVo + "','" + danTocVo
                                          + "','" + quocTichVo + "','" + thuongTamTruVo + "','" + cmndVo
                                          + "','"  + khuVucDangKy + "','" + ngayDangKy + "')";
            try
            {
                editCSDL(sql);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public Boolean addChungTu(string maChungTu, string tenNguoiKhai, string thuongTamTru,
                                  string qhVoiNguoiMat, string tenNguoiMat, string ngaySinh,
                                  string danToc, string quocTich, string cmnd, string ngayMat,
                                  string gioMat, string khuVucDangKy, string ngayDangKy)
        {
            string sql = "INSERT INTO CHUNGTU(MCT,TenNguoiKhai,ThuongTamTru,QHVoiNguoiMat,"
                                           + "TenNguoiMat,NgaySinh,DanToc,QuocTich,CMND,"
                                           + "NgayMat,GioMat,KVDK,NgayDK) VALUES('"
                                          + maChungTu + "','" + tenNguoiKhai + "','" + thuongTamTru
                                          + "','" + qhVoiNguoiMat + "','" + tenNguoiMat + "','" + ngaySinh
                                          + "','" + danToc + "','" + quocTich + "','" + cmnd + "','" + ngayMat
                                          + "','" + gioMat + "','" + khuVucDangKy + "','" + ngayDangKy + "')";
            try
            {
                editCSDL(sql);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public Boolean addTienAnTienSu(string maTienAnTienSu, string maNhanKhau,
                                       string tenTienAnTienSu, string noiXetXu,
                                       string ngayThucThi)
        {
            string sql = "INSERT INTO TIENANTIENSU(MaTATS,MNK,TenTATS,NoiXetXu,NgayThucThi) VALUES('"
                                                 + maTienAnTienSu + "','" + maNhanKhau + "','"
                                                 + tenTienAnTienSu + "','" + noiXetXu + "','"
                                                 + ngayThucThi + "')";
            try
            {
                editCSDL(sql);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public Boolean addTaiKhoan(string tenDangNhap, string matKhau, string ngayCapNhat, int phanQuyen, string nguoiSuDung)
        {
            string sql = "INSERT INTO CANBO(TaiKhoan,MatKhau,NgayCapNhat,Quyen, NguoiSuDung) VALUES('" +
                                                                                 tenDangNhap + "','" +
                                                                                 matKhau + "','" +
                                                                                 ngayCapNhat + "','" +
                                                                                 phanQuyen + "','" +
                                                                                 nguoiSuDung +  "')";
            try
            {
                editCSDL(sql);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        //---------------------------------------------------------------------------XÓA DB

        public Boolean xoa(string tableName, string pKey, string pKeyCode)
        {
            string sql = "DELETE FROM " + tableName + " WHERE " + pKey + " = '" + pKeyCode + "'";
            try
            {
                editCSDL(sql);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public void xoaCSDL(ListView lstView, string tableName, string primaryKey)
        {
            if (lstView.SelectedIndices.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Có chắc muốn xóa không", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int index = lstView.FocusedItem.Index;
                    var selectedItems = lstView.SelectedItems;
                    string data = selectedItems[0].SubItems[0].Text;
                    if (xoa(tableName, primaryKey, data))
                    {
                        switch (tableName)
                        {
                            case "NHANKHAU": displayNhanKhau(lstView); break;
                            case "HOKHAU": displayHoKhau(lstView); break;
                            case "TAMTRU": displayTamTru(lstView); break;
                            case "KETHON": displayKetHon(lstView); break;
                            case "CHUNGTU": displayChungTu(lstView); break;
                            case "TIENANTIENSU": displayTienAnTienSu(lstView); break;
                            case "CANBO": displayTaiKhoan(lstView); break;
                        }
                        MessageBox.Show("Xóa thành công");
                    }
                }
            }
            else
            {
                string doiTuong = "";
                switch (tableName)
                {
                    case "NHANKHAU": doiTuong = "nhân khẩu"; break;
                    case "HOKHAU": doiTuong = "hộ khẩu"; break;
                    case "TAMTRU": doiTuong = "tạm trú"; break;
                    case "KETHON": doiTuong = "chứng nhận kết hôn"; break;
                    case "CHUNGTU": doiTuong = "chứng tử"; break;
                    case "TIENANTIENSU": doiTuong = "tiền án tiền sự"; break;
                    case "CANBO": doiTuong = "tài khoản"; break;
                }
                MessageBox.Show("Vui lòng chọn " + doiTuong + " cần xóa");
            }
        }

        //-----------------------------------------------------------------DISPLAY LISTVIEW

        public void displayNhanKhau(ListView lstView)
        {
            lstView.Items.Clear();
            string sql = "SELECT * FROM NHANKHAU";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand MyCommand = new MySqlCommand(sql, myConn);

            try
            {
                myConn.Open();
                MySqlDataReader dr = MyCommand.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["MNK"].ToString());
                    item.SubItems.Add(dr["Ten"].ToString());
                    item.SubItems.Add(dr["NgaySinh"].ToString());
                    item.SubItems.Add(dr["GioiTinh"].ToString());
                    item.SubItems.Add(dr["QueQuan"].ToString());
                    item.SubItems.Add(dr["TonGiao"].ToString());
                    item.SubItems.Add(dr["DanToc"].ToString());
                    item.SubItems.Add(dr["CMND"].ToString());
                    item.SubItems.Add(dr["MHK"].ToString());
                    item.SubItems.Add(dr["NgheNghiep"].ToString());
                    lstView.Items.Add(item);
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void displayHoKhau(ListView lstView)
        {
            lstView.Items.Clear();
            string sql = "SELECT * FROM HOKHAU";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand MyCommand = new MySqlCommand(sql, myConn);

            try
            {
                myConn.Open();
                MySqlDataReader dr = MyCommand.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["MHK"].ToString());
                    item.SubItems.Add(dr["TenChuHo"].ToString());
                    item.SubItems.Add(dr["CMNDChuHo"].ToString());
                    item.SubItems.Add(dr["KhuVuc"].ToString());
                    item.SubItems.Add(dr["DiaChiHK"].ToString());
                    item.SubItems.Add(dr["NgayLap"].ToString());
                    lstView.Items.Add(item);
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void displayTamTru(ListView lstView)
        {
            lstView.Items.Clear();
            string sql = "SELECT * FROM TAMTRU";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand MyCommand = new MySqlCommand(sql, myConn);

            try
            {
                myConn.Open();
                MySqlDataReader dr = MyCommand.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["MTT"].ToString());
                    item.SubItems.Add(dr["MNK"].ToString());
                    item.SubItems.Add(dr["TenNoiTamTru"].ToString());
                    item.SubItems.Add(dr["DiaChi"].ToString());
                    item.SubItems.Add(dr["SoDienThoai"].ToString());
                    item.SubItems.Add(dr["ThoiHan"].ToString());
                    lstView.Items.Add(item);
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void displayChungTu(ListView lstView)
        {
            lstView.Items.Clear();
            string sql = "SELECT * FROM CHUNGTU";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand MyCommand = new MySqlCommand(sql, myConn);

            try
            {
                myConn.Open();
                MySqlDataReader dr = MyCommand.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["MCT"].ToString());
                    item.SubItems.Add(dr["TenNguoiKhai"].ToString());
                    item.SubItems.Add(dr["ThuongTamTru"].ToString());
                    item.SubItems.Add(dr["QHVoiNguoiMat"].ToString());
                    item.SubItems.Add(dr["TenNguoiMat"].ToString());
                    item.SubItems.Add(dr["NgaySinh"].ToString());
                    item.SubItems.Add(dr["DanToc"].ToString());
                    item.SubItems.Add(dr["QuocTich"].ToString());
                    item.SubItems.Add(dr["CMND"].ToString());
                    item.SubItems.Add(dr["NgayMat"].ToString());
                    item.SubItems.Add(dr["GioMat"].ToString());
                    item.SubItems.Add(dr["KVDK"].ToString());
                    item.SubItems.Add(dr["NgayDK"].ToString());
                    lstView.Items.Add(item);
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void displayKetHon(ListView lstView)
        {
            lstView.Items.Clear();
            string sql = "SELECT * FROM KETHON";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand MyCommand = new MySqlCommand(sql, myConn);

            try
            {
                myConn.Open();
                MySqlDataReader dr = MyCommand.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["MKH"].ToString());
                    item.SubItems.Add(dr["TenChong"].ToString());
                    item.SubItems.Add(dr["NgaySinhChong"].ToString());
                    item.SubItems.Add(dr["DanTocChong"].ToString());
                    item.SubItems.Add(dr["QuocTichChong"].ToString());
                    item.SubItems.Add(dr["ThuongTamTruChong"].ToString());
                    item.SubItems.Add(dr["CMNDChong"].ToString());
                    item.SubItems.Add(dr["TenVo"].ToString());
                    item.SubItems.Add(dr["NgaySinhVo"].ToString());
                    item.SubItems.Add(dr["DanTocVo"].ToString());
                    item.SubItems.Add(dr["QuocTichVo"].ToString());
                    item.SubItems.Add(dr["ThuongTamTruVo"].ToString());
                    item.SubItems.Add(dr["CMNDVo"].ToString());
                    item.SubItems.Add(dr["KVDK"].ToString());
                    item.SubItems.Add(dr["NgayDK"].ToString());
                    lstView.Items.Add(item);
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void displayTienAnTienSu(ListView lstView)
        {
            lstView.Items.Clear();
            string sql = "SELECT * FROM TIENANTIENSU";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand MyCommand = new MySqlCommand(sql, myConn);

            try
            {
                myConn.Open();
                MySqlDataReader dr = MyCommand.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["MaTATS"].ToString());
                    item.SubItems.Add(dr["MNK"].ToString());
                    item.SubItems.Add(dr["TenTATS"].ToString());
                    item.SubItems.Add(dr["NoiXetXu"].ToString());
                    item.SubItems.Add(dr["NgayThucThi"].ToString());
                    lstView.Items.Add(item);
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void displayTaiKhoan(ListView lstView)
        {
            lstView.Items.Clear();
            string sql = "SELECT * FROM CANBO";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand MyCommand = new MySqlCommand(sql, myConn);

            try
            {
                myConn.Open();
                MySqlDataReader dr = MyCommand.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["TaiKhoan"].ToString());
                    item.SubItems.Add(dr["MatKhau"].ToString());
                    item.SubItems.Add(dr["NguoiSuDung"].ToString());
                    string phanQuyen = "";
                    switch (dr["Quyen"].ToString())
                    {
                        case "1": phanQuyen = "Quản Lý Tài Khoản"; break;
                        case "2": phanQuyen = "Quản Lý Nhân Khẩu"; break;
                        case "3": phanQuyen = "Quản Lý Hộ Khẩu"; break;
                        case "4": phanQuyen = "Quản Lý Tạm Trú"; break;
                        case "5": phanQuyen = "Quản Lý Chứng Tử"; break;
                        case "6": phanQuyen = "Quản Lý Chứng Nhận Kết Hôn"; break;
                        case "7": phanQuyen = "Quản Lý Tiền Án Tiền Sự"; break;
                    }
                    item.SubItems.Add(phanQuyen);
                    item.SubItems.Add(dr["NgayCapNhat"].ToString());
                    lstView.Items.Add(item);
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //-----------------------------------------------------------------DISPLAY LISTVIEW

        public int dangNhap(string id, string password, ref string phanQuyen, ref string nguoiSuDung)
        {
            string sql = "SELECT * FROM CANBO";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand MyCommand = new MySqlCommand(sql, myConn);

            try
            {
                myConn.Open();
                MySqlDataReader dr = MyCommand.ExecuteReader();
                while (dr.Read())
                {
                    if (id.Equals(dr["TaiKhoan"].ToString()) && password.Equals(dr["MatKhau"].ToString()))
                    {
                        phanQuyen = dr["Quyen"].ToString();
                        nguoiSuDung = dr["NguoiSuDung"].ToString();
                        return 1;
                    }
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return 0;
        }
    }
}
