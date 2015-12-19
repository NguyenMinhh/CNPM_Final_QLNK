using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace QLNK
{
    public class SourceCode
    {
        public string ERROR_BLANK = "Vui lòng điền đầy đủ thông tin!";
        public string SUCCESS_ADD = "Thêm thành công!";
        public string SUCCESS_UPDATE = "Cập nhật thành công!";
        public string SUCCESS_DELETE = "Xóa thành công!";
        public string MSGBOX_UPDATE = "Lưu thông tin đã chỉnh sửa ?";
        public string MSGBOX_CAP_UPDATE = "Xác nhận chỉnh sửa";
        public string MSGBOX_CAP_EXIT = "Xác nhận thoát";
        public string ERROR_BLANK_FIND = "Vui lòng chọn thông tin cần tra cứu";
        public string ERROR_BLANK_FIND_ITEM = "Vui lòng chọn mục cần tra cứu";
        public string ERROR_MNK_NOT_FOUND_MTT = "Cannot add or update a child row: a foreign key constraint fails (`qlnk`.`tamtru`, CONSTRAINT `tamtru_ibfk_1` FOREIGN KEY (`MNK`) REFERENCES `hokhau` (`nhankhau`))";
        public string ERROR_MNK_NOT_FOUND_TATS = "Cannot add or update a child row: a foreign key constraint fails (`qlnk`.`tienantiensu`, CONSTRAINT `tienantiensu_ibfk_1` FOREIGN KEY (`MNK`) REFERENCES `nhankhau` (`MNK`))";
        public string ERROR_MHK_NOT_FOUND = "Cannot add or update a child row: a foreign key constraint fails (`qlnk`.`nhankhau`, CONSTRAINT `nhankhau_ibfk_1` FOREIGN KEY (`MHK`) REFERENCES `hokhau` (`MHK`))";
        public string ERROR_DELETE = "Cannot delete or update a parent row: a foreign key constraint fails (`qlnk`.`nhankhau`, CONSTRAINT `nhankhau_ibfk_1` FOREIGN KEY (`MHK`) REFERENCES `hokhau` (`MHK`))";

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
                                    string danTocChong, string queQuanChong, string thuongTamTruChong,
                                    string cmndChong, string hoTenVo, string ngaySinhVo,
                                    string danTocVo, string queQuanVo, string thuongTamTruVo,
                                    string cmndVo, string khuVucDangKy, string ngayDangKy)
        {
            string sql = "UPDATE KETHON SET TenChong = '" + hoTenChong + "',NgaySinhChong = '" + ngaySinhChong
                                        + "',DanTocChong = '" + danTocChong + "',QueQuanChong = '" + queQuanChong
                                        + "',ThuongTamTruChong = '" + thuongTamTruChong + "',CMNDChong = '" + cmndChong
                                        + "',TenVo = '" + hoTenVo + "',ngaySinhVo = '" + ngaySinhVo
                                        + "',DanTocVo = '" + danTocVo + "',QueQuanVo = '" + queQuanVo
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
                if (ex.Message.Equals("Duplicate entry '" + maNhanKhau + "' for key 'PRIMARY'"))
                    MessageBox.Show("Mã nhân khẩu \"" + maNhanKhau + "\" đã tồn tại");
                else if (ex.Message.Equals(ERROR_MHK_NOT_FOUND))
                    MessageBox.Show("Mã hộ khẩu \"" + maHoKhau + "\" không tồn tại");
                else
                {
                    MessageBox.Show(ex.Message);
                }
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
                if (ex.Message.Equals("Duplicate entry '" + maHoKhau + "' for key 'PRIMARY'"))
                    MessageBox.Show("Mã hộ khẩu \"" + maHoKhau + "\" đã tồn tại");
                else
                {
                    MessageBox.Show(ex.Message);
                }
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
                if (ex.Message.Equals("Duplicate entry '" + maTamTru + "' for key 'PRIMARY'"))
                    MessageBox.Show("Mã tạm trú \"" + maTamTru + "\" đã tồn tại");
                else if (ex.Message.Equals(ERROR_MNK_NOT_FOUND_MTT))
                    MessageBox.Show("Mã nhân khẩu \"" + maNhanKhau + "\" không tồn tại");
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return false;
        }

        public Boolean addKetHon(string maKetHon, string hoTenChong, string ngaySinhChong, string danTocChong,
                                 string queQuanChong, string cmndChong, string thuongTamTruChong,
                                 string hoTenVo, string ngaySinhVo, string danTocVo, string queQuanVo,
                                 string thuongTamTruVo, string cmndVo, string khuVucDangKy, string ngayDangKy)
        {
            string sql = "INSERT INTO KETHON(MKH,TenChong,NgaySinhChong,DanTocChong,QueQuanChong,"
                                          + "ThuongTamTruChong,CMNDChong,TenVo,NgaySinhVo,DanTocVo,"
                                          + "QueQuanVo,ThuongTamTruVo,CMNDVo,KVDK,NgayDK) VALUES('"
                                          + maKetHon + "','" + hoTenChong + "','" + ngaySinhChong
                                          + "','" + danTocChong + "','" + queQuanChong
                                          + "','" + cmndChong + "','" + thuongTamTruChong
                                          + "','" + hoTenVo + "','" + ngaySinhVo + "','" + danTocVo
                                          + "','" + queQuanVo + "','" + thuongTamTruVo + "','" + cmndVo
                                          + "','"  + khuVucDangKy + "','" + ngayDangKy + "')";
            try
            {
                editCSDL(sql);
                return true;
            }
            catch (Exception ex)
            {
                if (ex.Message.Equals("Duplicate entry '" + maKetHon + "' for key 'PRIMARY'"))
                    MessageBox.Show("Mã kết hôn \"" + maKetHon + "\" đã tồn tại");
                else
                {
                    MessageBox.Show(ex.Message);
                }
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
                if (ex.Message.Equals("Duplicate entry '" + maChungTu + "' for key 'PRIMARY'"))
                    MessageBox.Show("Mã chứng tử \"" + maChungTu + "\" đã tồn tại");
                else
                {
                    MessageBox.Show(ex.Message);
                }
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
                if (ex.Message.Equals("Duplicate entry '" + maTienAnTienSu + "' for key 'PRIMARY'"))
                    MessageBox.Show("Mã tiền án tiền sự \"" + maTienAnTienSu + "\" đã tồn tại");
                else if (ex.Message.Equals(ERROR_MNK_NOT_FOUND_TATS))
                    MessageBox.Show("Mã nhân khẩu \"" + maNhanKhau + "\" không tồn tại");
                else
                {
                    MessageBox.Show(ex.Message);
                }
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
                if (ex.Message.Equals(ERROR_DELETE))
                {
                    MessageBox.Show("Vui lòng xóa các nhân khẩu còn ở trong " + pKeyCode);
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
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
                            case "NHANKHAU": displayNhanKhau(lstView, 0); break;
                            case "HOKHAU": displayHoKhau(lstView, 0); break;
                            case "TAMTRU": displayTamTru(lstView); break;
                            case "KETHON": displayKetHon(lstView); break;
                            case "CHUNGTU": displayChungTu(lstView); break;
                            case "TIENANTIENSU": displayTienAnTienSu(lstView); break;
                            case "CANBO": displayTaiKhoan(lstView); break;
                        }
                        MessageBox.Show(SUCCESS_DELETE);
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
                MessageBox.Show("Vui lòng chọn " + doiTuong + " cần xóa!");
            }
        }

        public void setForeignKey(string value)
        {
            string sql = "SET FOREIGN_KEY_CHECKS = " + value + ";";
            try
            {
                editCSDL(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void clearAllValues(string tableName)
        {
            string sql = "TRUNCATE TABLE " + tableName + ";";
            try
            {
                editCSDL(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //-----------------------------------------------------------------DISPLAY LISTVIEW

        public void displayNhanKhau(ListView lstView, int type)
        {
            lstView.Items.Clear();
            string sql = "SELECT * FROM NHANKHAU";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand MyCommand = new MySqlCommand(sql, myConn);

            try
            {
                myConn.Open();
                MySqlDataReader dr = MyCommand.ExecuteReader();
                if (type == 0)
                {
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
                }
                else
                {
                    while (dr.Read())
                    {
                        ListViewItem item = new ListViewItem(dr["MNK"].ToString());
                        item.SubItems.Add(dr["Ten"].ToString());
                        item.SubItems.Add(dr["QueQuan"].ToString());
                        item.SubItems.Add(dr["CMND"].ToString());
                        lstView.Items.Add(item);
                    }
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void displayHoKhau(ListView lstView, int type)
        {
            lstView.Items.Clear();
            string sql = "SELECT * FROM HOKHAU";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand MyCommand = new MySqlCommand(sql, myConn);

            try
            {
                myConn.Open();
                MySqlDataReader dr = MyCommand.ExecuteReader();
                if (type == 0)
                {
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
                }
                else
                {
                    while (dr.Read())
                    {
                        ListViewItem item = new ListViewItem(dr["MHK"].ToString());
                        item.SubItems.Add(dr["TenChuHo"].ToString());
                        item.SubItems.Add(dr["DiaChiHK"].ToString());
                        lstView.Items.Add(item);
                    }
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
                    item.SubItems.Add(dr["QueQuanChong"].ToString());
                    item.SubItems.Add(dr["ThuongTamTruChong"].ToString());
                    item.SubItems.Add(dr["CMNDChong"].ToString());
                    item.SubItems.Add(dr["TenVo"].ToString());
                    item.SubItems.Add(dr["NgaySinhVo"].ToString());
                    item.SubItems.Add(dr["DanTocVo"].ToString());
                    item.SubItems.Add(dr["QueQuanVo"].ToString());
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

        //-----------------------------------------------------------------SET PRIMARY KEY

        public string setPrimaryKey(string tableName, string primaryKey)
        {
            string primaryKeyOfTable = "";
            int count = 1;
            string sql = "SELECT * FROM " + tableName;
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand MyCommand = new MySqlCommand(sql, myConn);

            try
            {
                myConn.Open();
                MySqlDataReader dr = MyCommand.ExecuteReader();
                while (dr.Read())
                {
                    string str = dr[primaryKey].ToString();
                    string[] arr = str.Split('-');
                    if (arr[1].Equals(count.ToString()))
                    {
                        count++;
                    }
                    else
                    {
                        primaryKeyOfTable = primaryKey + "-" + count.ToString();
                    }
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (primaryKeyOfTable.Equals(""))
            {
                primaryKeyOfTable = primaryKey + "-" + count.ToString();
            }
            return primaryKeyOfTable;
        }

        //----------------------------------------------------------------------------FIND

        public void findAndDisplay(string tableName, string condition, string itemNeedToFind, ListView lstView)
        {
            lstView.Items.Clear();
            string sql = "SELECT * FROM " + tableName + " WHERE " + condition + " = '" + itemNeedToFind + "'";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand MyCommand = new MySqlCommand(sql, myConn);
            int count = 0;
            try
            {
                myConn.Open();
                MySqlDataReader dr = MyCommand.ExecuteReader();
                while (dr.Read())
                {
                    string str = dr[condition].ToString();
                    if (str == itemNeedToFind)
                    {
                        switch (tableName)
                        {
                            case "NHANKHAU":
                                ListViewItem itemNK = new ListViewItem(dr["MNK"].ToString());
                                itemNK.SubItems.Add(dr["Ten"].ToString());
                                itemNK.SubItems.Add(dr["NgaySinh"].ToString());
                                itemNK.SubItems.Add(dr["GioiTinh"].ToString());
                                itemNK.SubItems.Add(dr["QueQuan"].ToString());
                                itemNK.SubItems.Add(dr["TonGiao"].ToString());
                                itemNK.SubItems.Add(dr["DanToc"].ToString());
                                itemNK.SubItems.Add(dr["CMND"].ToString());
                                itemNK.SubItems.Add(dr["MHK"].ToString());
                                itemNK.SubItems.Add(dr["NgheNghiep"].ToString());
                                lstView.Items.Add(itemNK);
                                break;
                            case "HOKHAU":
                                ListViewItem itemHK = new ListViewItem(dr["MHK"].ToString());
                                itemHK.SubItems.Add(dr["TenChuHo"].ToString());
                                itemHK.SubItems.Add(dr["CMNDChuHo"].ToString());
                                itemHK.SubItems.Add(dr["KhuVuc"].ToString());
                                itemHK.SubItems.Add(dr["DiaChiHK"].ToString());
                                itemHK.SubItems.Add(dr["NgayLap"].ToString());
                                lstView.Items.Add(itemHK);
                                break;
                            case "TAMTRU":
                                ListViewItem itemTT = new ListViewItem(dr["MTT"].ToString());
                                itemTT.SubItems.Add(dr["MNK"].ToString());
                                itemTT.SubItems.Add(dr["TenNoiTamTru"].ToString());
                                itemTT.SubItems.Add(dr["DiaChi"].ToString());
                                itemTT.SubItems.Add(dr["SoDienThoai"].ToString());
                                itemTT.SubItems.Add(dr["ThoiHan"].ToString());
                                lstView.Items.Add(itemTT);
                                break;
                            case "CHUNGTU":
                                ListViewItem itemCT = new ListViewItem(dr["MCT"].ToString());
                                itemCT.SubItems.Add(dr["TenNguoiKhai"].ToString());
                                itemCT.SubItems.Add(dr["ThuongTamTru"].ToString());
                                itemCT.SubItems.Add(dr["QHVoiNguoiMat"].ToString());
                                itemCT.SubItems.Add(dr["TenNguoiMat"].ToString());
                                itemCT.SubItems.Add(dr["NgaySinh"].ToString());
                                itemCT.SubItems.Add(dr["DanToc"].ToString());
                                itemCT.SubItems.Add(dr["QuocTich"].ToString());
                                itemCT.SubItems.Add(dr["CMND"].ToString());
                                itemCT.SubItems.Add(dr["NgayMat"].ToString());
                                itemCT.SubItems.Add(dr["GioMat"].ToString());
                                itemCT.SubItems.Add(dr["KVDK"].ToString());
                                itemCT.SubItems.Add(dr["NgayDK"].ToString());
                                lstView.Items.Add(itemCT);
                                break;
                            case "KETHON":
                                ListViewItem itemKH = new ListViewItem(dr["MKH"].ToString());
                                itemKH.SubItems.Add(dr["TenChong"].ToString());
                                itemKH.SubItems.Add(dr["NgaySinhChong"].ToString());
                                itemKH.SubItems.Add(dr["DanTocChong"].ToString());
                                itemKH.SubItems.Add(dr["QueQuanChong"].ToString());
                                itemKH.SubItems.Add(dr["ThuongTamTruChong"].ToString());
                                itemKH.SubItems.Add(dr["CMNDChong"].ToString());
                                itemKH.SubItems.Add(dr["TenVo"].ToString());
                                itemKH.SubItems.Add(dr["NgaySinhVo"].ToString());
                                itemKH.SubItems.Add(dr["DanTocVo"].ToString());
                                itemKH.SubItems.Add(dr["QueQuanVo"].ToString());
                                itemKH.SubItems.Add(dr["ThuongTamTruVo"].ToString());
                                itemKH.SubItems.Add(dr["CMNDVo"].ToString());
                                itemKH.SubItems.Add(dr["KVDK"].ToString());
                                itemKH.SubItems.Add(dr["NgayDK"].ToString());
                                lstView.Items.Add(itemKH);
                                break;
                            case "TIENANTIENSU":
                                ListViewItem itemTATS = new ListViewItem(dr["MaTATS"].ToString());
                                itemTATS.SubItems.Add(dr["MNK"].ToString());
                                itemTATS.SubItems.Add(dr["TenTATS"].ToString());
                                itemTATS.SubItems.Add(dr["NoiXetXu"].ToString());
                                itemTATS.SubItems.Add(dr["NgayThucThi"].ToString());
                                lstView.Items.Add(itemTATS);
                                break;
                        }
                        count++;
                    }
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (count == 0)
            {
                MessageBox.Show("Dữ liệu cần tìm không tồn tại");
            }
        }
    }
}
