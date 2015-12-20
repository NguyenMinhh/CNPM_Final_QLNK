using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace QLNK
{
    public class SourceCode
    {
        public string ErrorBlank = "Vui lòng điền đầy đủ thông tin!";
        public string SuccessAdd = "Thêm thành công!";
        public string SuccessUpdate = "Cập nhật thành công!";
        public string SuccessDelete = "Xóa thành công!";
        public string MsgboxUpdate = "Lưu thông tin đã chỉnh sửa ?";
        public string MsgboxCapUpdate = "Xác nhận chỉnh sửa";
        public string MsgboxCapExit = "Xác nhận thoát";
        public string ErrorBlankFind = "Vui lòng chọn thông tin cần tra cứu";
        public string ErrorBlankFindItem = "Vui lòng chọn mục cần tra cứu";
        public string ErrorMnkNotFoundMtt = "Cannot add or update a child row: a foreign key constraint fails (`qlnk`.`tamtru`, CONSTRAINT `tamtru_ibfk_1` FOREIGN KEY (`MNK`) REFERENCES `nhankhau` (`MNK`))";
        public string ErrorMnkNotFoundTats = "Cannot add or update a child row: a foreign key constraint fails (`qlnk`.`tienantiensu`, CONSTRAINT `tienantiensu_ibfk_1` FOREIGN KEY (`MNK`) REFERENCES `nhankhau` (`MNK`))";
        public string ErrorMhkNotFound = "Cannot add or update a child row: a foreign key constraint fails (`qlnk`.`nhankhau`, CONSTRAINT `nhankhau_ibfk_1` FOREIGN KEY (`MHK`) REFERENCES `hokhau` (`MHK`))";
        public string ErrorDelete = "Cannot delete or update a parent row: a foreign key constraint fails (`qlnk`.`nhankhau`, CONSTRAINT `nhankhau_ibfk_1` FOREIGN KEY (`MHK`) REFERENCES `hokhau` (`MHK`))";

        private const string Datasource = "localhost";
        private const string Port = "3306";
        private const string Username = "root";
        private const string Password = "Trongheo1";
        private const string Database = "qlnk";

        public string MyConnection = "datasource=" + Datasource + ";port=" + Port
                                            + ";username=" + Username + ";password=" + Password
                                            + ";database=" + Database;
        //--------------------------------------------------------------------------EDIT DB

        public void EditCsdl(string sql) { 
            var mcon = new MySqlConnection(MyConnection);
            var myCommand = new MySqlCommand(sql, mcon);
            mcon.Open();
            myCommand.ExecuteReader();
            mcon.Close();
        }

        //--------------------------------------------------------------------------SỬA DB

        public bool UpdateHoKhau(string maHoKhau, string tenChuHo, string cmndChuHo,
                                    string khuVuc, string diaChi, string ngayLap)
        {
            var sql = "UPDATE HOKHAU SET TenChuHo = '" + tenChuHo
                                        + "',CMNDChuHo = '" + cmndChuHo + "',KhuVuc = '" + khuVuc
                                        + "',DiaChiHK = '" + diaChi + "',NgayLap = '" + ngayLap
                                        + "' WHERE MHK = '" + maHoKhau + "'";
            try
            {
                EditCsdl(sql);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public bool UpdateNhanKhau(string maNhanKhau, string hoTen, string ngaySinh,
                                     string gioiTinh, string queQuan, string tonGiao,
                                     string danToc, string cmnd, string maHoKhau,
                                     string ngheNghiep)
        {
            var sql = "UPDATE NHANKHAU SET Ten = '" + hoTen + "',NgaySinh = '" + ngaySinh + "',"
                                        + "GioiTinh = '" + gioiTinh + "',QueQuan = '" + queQuan + "',"
                                        + "TonGiao = '" + tonGiao + "',DanToc = '" + danToc + "',"
                                        + "CMND = '" + cmnd + "'," + "MHK = '" + maHoKhau + "',"
                                        + "NgheNghiep = '" + ngheNghiep + "' WHERE MNK = '" + maNhanKhau + "'";
            try
            {
                EditCsdl(sql);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public bool UpdateTamTru(string maTamTru, string maNhanKhau,
                                    string tenNoiTamTruDayDu, string diaChi,
                                    string soDienThoai, string thoiHan)
        {
            var sql = "UPDATE TAMTRU SET MNK = '" + maNhanKhau
                                        + "',TenNoiTamTru = '" + tenNoiTamTruDayDu
                                        + "',DiaChi = '" + diaChi + "',SoDienThoai = '" + soDienThoai
                                        + "',ThoiHan = '" + thoiHan + "' WHERE MTT = '" + maTamTru + "'";
            try
            {
                EditCsdl(sql);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public bool UpdateKetHon(string maKetHon, string hoTenChong, string ngaySinhChong,
                                    string danTocChong, string queQuanChong, string thuongTamTruChong,
                                    string cmndChong, string hoTenVo, string ngaySinhVo,
                                    string danTocVo, string queQuanVo, string thuongTamTruVo,
                                    string cmndVo, string khuVucDangKy, string ngayDangKy)
        {
            var sql = "UPDATE KETHON SET TenChong = '" + hoTenChong + "',NgaySinhChong = '" + ngaySinhChong
                                        + "',DanTocChong = '" + danTocChong + "',QueQuanChong = '" + queQuanChong
                                        + "',ThuongTamTruChong = '" + thuongTamTruChong + "',CMNDChong = '" + cmndChong
                                        + "',TenVo = '" + hoTenVo + "',ngaySinhVo = '" + ngaySinhVo
                                        + "',DanTocVo = '" + danTocVo + "',QueQuanVo = '" + queQuanVo
                                        + "',ThuongTamTruVo = '" + thuongTamTruVo + "',CMNDVo = '" + cmndVo
                                        + "',KVDK = '" + khuVucDangKy + "',NgayDK = '" + ngayDangKy
                                        + "' WHERE MKH = '" + maKetHon + "'";
            try
            {
                EditCsdl(sql);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public bool UpdateChungTu(string maChungTu, string tenNguoiKhai, string thuongTamTru,
                                     string qhVoiNguoiMat, string tenNguoiMat, string ngaySinh,
                                     string danToc, string quocTich, string cmnd, string ngayMat,
                                     string gioMat, string khuVucDangKy, string ngayDangKy)
        {
            var sql = "UPDATE CHUNGTU SET TenNguoiKhai = '" + tenNguoiKhai + "',ThuongTamTru = '" + thuongTamTru
                                        + "',QHVoiNguoiMat = '" + qhVoiNguoiMat + "',TenNguoiMat = '" + tenNguoiMat
                                        + "',NgaySinh = '" + ngaySinh + "',DanToc = '" + danToc
                                        + "',QuocTich = '" + quocTich + "',CMND = '" + cmnd
                                        + "',NgayMat = '" + ngayMat + "',GioMat = '" + gioMat
                                        + "',KVDK = '" + khuVucDangKy + "',NgayDK = '" + ngayDangKy
                                        + "' WHERE MCT = '" + maChungTu + "'";
            try
            {
                EditCsdl(sql);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public bool UpdateTienAnTienSu(string maTienAnTienSu, string maNhanKhau,
                                          string tenTienAnTienSu, string noiXetXu,
                                          string ngayThucThi)
        {
            var sql = "UPDATE TIENANTIENSU SET MNK = '" + maNhanKhau + "',TenTATS = '" + tenTienAnTienSu
                                             + "',NoiXetXu = '" + noiXetXu + "',NgayThucThi = '" + ngayThucThi
                                             + "' WHERE MaTATS = '" + maTienAnTienSu + "'";
            try
            {
                EditCsdl(sql);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        public bool UpdateMatKhau(string taiKhoan, string matKhauMoi, string ngayCapNhat)
        {
            var sql = "UPDATE CANBO SET MatKhau = '" + matKhauMoi + "',NgayCapNhat = '" + ngayCapNhat + "' WHERE TaiKhoan = '" + taiKhoan + "'";
            try
            {
                EditCsdl(sql);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public bool UpdatePhanQuyen(string taiKhoan, int phanQuyen, string ngayCapNhat)
        {
            var sql = "UPDATE CANBO SET Quyen = '" + phanQuyen + "',NgayCapNhat = '" + ngayCapNhat + "' WHERE taiKhoan = '" + taiKhoan + "'";
            try
            {
                EditCsdl(sql);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        //--------------------------------------------------------------------------THÊM DB

        public bool AddNhanKhau(string maNhanKhau, string hoTen, string ngaySinh,
                                   string gioiTinh, string queQuan, string tonGiao,
                                   string danToc, string cmnd, string maHoKhau,
                                   string ngheNghiep)
        {
            var sql = "INSERT INTO NHANKHAU(MNK,Ten,NgaySinh,GioiTinh,"
                    + "QueQuan,TonGiao,DanToc,CMND,MHK,NgheNghiep)"
                    + " VALUES('" + maNhanKhau + "','" + hoTen + "','" + ngaySinh
                    + "','" + gioiTinh + "','" + queQuan + "','" + tonGiao
                    + "','" + danToc + "','" + cmnd + "','" + maHoKhau
                    + "','" + ngheNghiep + "')";
            try
            {
                EditCsdl(sql);
                return true;
            }
            catch (Exception ex)
            {
                if (ex.Message.Equals("Duplicate entry '" + maNhanKhau + "' for key 'PRIMARY'"))
                    MessageBox.Show(@"Mã nhân khẩu """ + maNhanKhau + @""" đã tồn tại");
                else if (ex.Message.Equals(ErrorMhkNotFound))
                    MessageBox.Show(@"Mã hộ khẩu """ + maHoKhau + @""" không tồn tại");
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return false;
        }

        public bool AddHoKhau(string maHoKhau, string tenChuHo, string cmndChuHo,
                                 string khuVuc, string diaChi, string ngayLap)
        {
            var sql = "INSERT INTO HOKHAU(MHK,TenChuHo,CMNDChuHo,KhuVuc,DiaChiHK,NgayLap)"
                    + " VALUES('" + maHoKhau + "','" + tenChuHo + "','" +
                                  cmndChuHo + "','" + khuVuc + "','" +
                                  diaChi + "','" + ngayLap + "')";
            try
            {
                EditCsdl(sql);
                return true;
            }
            catch (Exception ex)
            {
                if (ex.Message.Equals("Duplicate entry '" + maHoKhau + "' for key 'PRIMARY'"))
                    MessageBox.Show(@"Mã hộ khẩu """ + maHoKhau + @""" đã tồn tại");
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return false;
        }

        public bool AddTamTru(string maTamTru, string maNhanKhau,
                                 string tenNoiTamTruDayDu, string diaChi,
                                 string soDienThoai, string thoiHan)
        {
            var sql = "INSERT INTO TAMTRU(MTT,MNK,TenNoiTamTru,"
                         + "DiaChi,SoDienThoai,ThoiHan) VALUES('"
                         + maTamTru + "','" + maNhanKhau + "','" + tenNoiTamTruDayDu
                         + "','" + diaChi + "','" + soDienThoai + "','" + thoiHan + "')";
            try
            {
                EditCsdl(sql);
                return true;
            }
            catch (Exception ex)
            {
                if (ex.Message.Equals("Duplicate entry '" + maTamTru + "' for key 'PRIMARY'"))
                    MessageBox.Show(@"Mã tạm trú """ + maTamTru + @""" đã tồn tại");
                else if (ex.Message.Equals(ErrorMnkNotFoundMtt))
                    MessageBox.Show(@"Mã nhân khẩu """ + maNhanKhau + @""" không tồn tại");
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return false;
        }

        public bool AddKetHon(string maKetHon, string hoTenChong, string ngaySinhChong, string danTocChong,
                                 string queQuanChong, string thuongTamTruChong, string cmndChong,
                                 string hoTenVo, string ngaySinhVo, string danTocVo, string queQuanVo,
                                 string thuongTamTruVo, string cmndVo, string khuVucDangKy, string ngayDangKy)
        {
            var sql = "INSERT INTO KETHON(MKH,TenChong,NgaySinhChong,DanTocChong,QueQuanChong,"
                                          + "ThuongTamTruChong,CMNDChong,TenVo,NgaySinhVo,DanTocVo,"
                                          + "QueQuanVo,ThuongTamTruVo,CMNDVo,KVDK,NgayDK) VALUES('"
                                          + maKetHon + "','" + hoTenChong + "','" + ngaySinhChong
                                          + "','" + danTocChong + "','" + queQuanChong
                                          + "','" + thuongTamTruChong + "','" + cmndChong
                                          + "','" + hoTenVo + "','" + ngaySinhVo + "','" + danTocVo
                                          + "','" + queQuanVo + "','" + thuongTamTruVo + "','" + cmndVo
                                          + "','"  + khuVucDangKy + "','" + ngayDangKy + "')";
            try
            {
                EditCsdl(sql);
                return true;
            }
            catch (Exception ex)
            {
                if (ex.Message.Equals("Duplicate entry '" + maKetHon + "' for key 'PRIMARY'"))
                    MessageBox.Show(@"Mã kết hôn """ + maKetHon + @""" đã tồn tại");
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return false;
        }

        public bool AddChungTu(string maChungTu, string tenNguoiKhai, string thuongTamTru,
                                  string qhVoiNguoiMat, string tenNguoiMat, string ngaySinh,
                                  string danToc, string quocTich, string cmnd, string ngayMat,
                                  string gioMat, string khuVucDangKy, string ngayDangKy)
        {
            var sql = "INSERT INTO CHUNGTU(MCT,TenNguoiKhai,ThuongTamTru,QHVoiNguoiMat,"
                                           + "TenNguoiMat,NgaySinh,DanToc,QuocTich,CMND,"
                                           + "NgayMat,GioMat,KVDK,NgayDK) VALUES('"
                                          + maChungTu + "','" + tenNguoiKhai + "','" + thuongTamTru
                                          + "','" + qhVoiNguoiMat + "','" + tenNguoiMat + "','" + ngaySinh
                                          + "','" + danToc + "','" + quocTich + "','" + cmnd + "','" + ngayMat
                                          + "','" + gioMat + "','" + khuVucDangKy + "','" + ngayDangKy + "')";
            try
            {
                EditCsdl(sql);
                return true;
            }
            catch (Exception ex)
            {
                if (ex.Message.Equals("Duplicate entry '" + maChungTu + "' for key 'PRIMARY'"))
                    MessageBox.Show(@"Mã chứng tử """ + maChungTu + @""" đã tồn tại");
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return false;
        }

        public bool AddTienAnTienSu(string maTienAnTienSu, string maNhanKhau,
                                       string tenTienAnTienSu, string noiXetXu,
                                       string ngayThucThi)
        {
            var sql = "INSERT INTO TIENANTIENSU(MaTATS,MNK,TenTATS,NoiXetXu,NgayThucThi) VALUES('"
                                                 + maTienAnTienSu + "','" + maNhanKhau + "','"
                                                 + tenTienAnTienSu + "','" + noiXetXu + "','"
                                                 + ngayThucThi + "')";
            try
            {
                EditCsdl(sql);
                return true;
            }
            catch (Exception ex)
            {
                if (ex.Message.Equals("Duplicate entry '" + maTienAnTienSu + "' for key 'PRIMARY'"))
                    MessageBox.Show(@"Mã tiền án tiền sự """ + maTienAnTienSu + @""" đã tồn tại");
                else if (ex.Message.Equals(ErrorMnkNotFoundTats))
                    MessageBox.Show(@"Mã nhân khẩu """ + maNhanKhau + @""" không tồn tại");
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return false;
        }

        public bool AddTaiKhoan(string tenDangNhap, string matKhau, string ngayCapNhat, int phanQuyen, string nguoiSuDung)
        {
            var sql = "INSERT INTO CANBO(TaiKhoan,MatKhau,NgayCapNhat,Quyen, NguoiSuDung) VALUES('" +
                                                                                 tenDangNhap + "','" +
                                                                                 matKhau + "','" +
                                                                                 ngayCapNhat + "','" +
                                                                                 phanQuyen + "','" +
                                                                                 nguoiSuDung +  "')";
            try
            {
                EditCsdl(sql);
                return true;
            }
            catch (Exception ex)
            {
                if (ex.Message.Equals("Duplicate entry '" + tenDangNhap + "' for key 'PRIMARY'"))
                    MessageBox.Show(@"Tên đăng nhập """ + tenDangNhap + @""" đã tồn tại");
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return false;
        }

        //---------------------------------------------------------------------------XÓA DB

        public bool Xoa(string tableName, string pKey, string pKeyCode)
        {
            var sql = "DELETE FROM " + tableName + " WHERE " + pKey + " = '" + pKeyCode + "'";
            try
            {
                EditCsdl(sql);
                return true;
            }
            catch (Exception ex)
            {
                if (ex.Message.Equals(ErrorDelete))
                {
                    MessageBox.Show(@"Vui lòng xóa các nhân khẩu trong " + pKeyCode);
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return false;
        }

        public void XoaCsdl(ListView lstView, string tableName, string primaryKey)
        {
            if (lstView.SelectedIndices.Count > 0)
            {
                var dialogResult = MessageBox.Show(@"Xóa xóa không", @"Xác nhận xóa", MessageBoxButtons.YesNo);
                if (dialogResult != DialogResult.Yes) return;
                var selectedItems = lstView.SelectedItems;
                var data = selectedItems[0].SubItems[0].Text;
                if (!Xoa(tableName, primaryKey, data)) return;
                switch (tableName)
                {
                    case "NHANKHAU": DisplayNhanKhau(lstView, 0); break;
                    case "HOKHAU": DisplayHoKhau(lstView, 0); break;
                    case "TAMTRU": DisplayTamTru(lstView); break;
                    case "KETHON": DisplayKetHon(lstView); break;
                    case "CHUNGTU": DisplayChungTu(lstView); break;
                    case "TIENANTIENSU": DisplayTienAnTienSu(lstView); break;
                    case "CANBO": DisplayTaiKhoan(lstView); break;
                }
                MessageBox.Show(SuccessDelete);
            }
            else
            {
                var doiTuong = "";
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
                MessageBox.Show(@"Vui lòng chọn " + doiTuong + @" cần xóa!");
            }
        }

        public void SetForeignKey(string value)
        {
            var sql = "SET FOREIGN_KEY_CHECKS = " + value + ";";
            try
            {
                EditCsdl(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ClearAllValues(string tableName)
        {
            var sql = "TRUNCATE TABLE " + tableName + ";";
            try
            {
                EditCsdl(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //-----------------------------------------------------------------DISPLAY LISTVIEW

        public void DisplayNhanKhau(ListView lstView, int type)
        {
            lstView.Items.Clear();
            var sql = "SELECT * FROM NHANKHAU";
            var myConn = new MySqlConnection(MyConnection);
            var myCommand = new MySqlCommand(sql, myConn);

            try
            {
                myConn.Open();
                var dr = myCommand.ExecuteReader();
                if (type == 0)
                {
                    while (dr.Read())
                    {
                        var item = new ListViewItem(dr["MNK"].ToString());
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

        public void DisplayHoKhau(ListView lstView, int type)
        {
            lstView.Items.Clear();
            var sql = "SELECT * FROM HOKHAU";
            var myConn = new MySqlConnection(MyConnection);
            var myCommand = new MySqlCommand(sql, myConn);

            try
            {
                myConn.Open();
                var dr = myCommand.ExecuteReader();
                if (type == 0)
                {
                    while (dr.Read())
                    {
                        var item = new ListViewItem(dr["MHK"].ToString());
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
                        var item = new ListViewItem(dr["MHK"].ToString());
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

        public void DisplayTamTru(ListView lstView)
        {
            lstView.Items.Clear();
            var sql = "SELECT * FROM TAMTRU";
            var myConn = new MySqlConnection(MyConnection);
            var myCommand = new MySqlCommand(sql, myConn);

            try
            {
                myConn.Open();
                var dr = myCommand.ExecuteReader();
                while (dr.Read())
                {
                    var item = new ListViewItem(dr["MTT"].ToString());
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

        public void DisplayChungTu(ListView lstView)
        {
            lstView.Items.Clear();
            var sql = "SELECT * FROM CHUNGTU";
            var myConn = new MySqlConnection(MyConnection);
            var myCommand = new MySqlCommand(sql, myConn);

            try
            {
                myConn.Open();
                var dr = myCommand.ExecuteReader();
                while (dr.Read())
                {
                    var item = new ListViewItem(dr["MCT"].ToString());
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

        public void DisplayKetHon(ListView lstView)
        {
            lstView.Items.Clear();
            var sql = "SELECT * FROM KETHON";
            var myConn = new MySqlConnection(MyConnection);
            var myCommand = new MySqlCommand(sql, myConn);

            try
            {
                myConn.Open();
                var dr = myCommand.ExecuteReader();
                while (dr.Read())
                {
                    var item = new ListViewItem(dr["MKH"].ToString());
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

        public void DisplayTienAnTienSu(ListView lstView)
        {
            lstView.Items.Clear();
            const string sql = "SELECT * FROM TIENANTIENSU";
            var myConn = new MySqlConnection(MyConnection);
            var myCommand = new MySqlCommand(sql, myConn);

            try
            {
                myConn.Open();
                var dr = myCommand.ExecuteReader();
                while (dr.Read())
                {
                    var item = new ListViewItem(dr["MaTATS"].ToString());
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

        public void DisplayTaiKhoan(ListView lstView)
        {
            lstView.Items.Clear();
            var sql = "SELECT * FROM CANBO";
            var myConn = new MySqlConnection(MyConnection);
            var myCommand = new MySqlCommand(sql, myConn);

            try
            {
                myConn.Open();
                var dr = myCommand.ExecuteReader();
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

        public int DangNhap(string id, string password, ref string phanQuyen, ref string nguoiSuDung)
        {
            var sql = "SELECT * FROM CANBO";
            var myConn = new MySqlConnection(MyConnection);
            var myCommand = new MySqlCommand(sql, myConn);

            try
            {
                myConn.Open();
                var dr = myCommand.ExecuteReader();
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

        public string SetPrimaryKey(string tableName, string primaryKey)
        {
            var primaryKeyOfTable = "";
            var count = 1;
            var sql = "SELECT * FROM " + tableName;
            var myConn = new MySqlConnection(MyConnection);
            var myCommand = new MySqlCommand(sql, myConn);

            try
            {
                myConn.Open();
                var dr = myCommand.ExecuteReader();
                while (dr.Read())
                {
                    var str = dr[primaryKey].ToString();
                    var arr = str.Split('-');
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

        public void FindAndDisplay(string tableName, string condition, string itemNeedToFind, ListView lstView)
        {
            lstView.Items.Clear();
            var sql = "SELECT * FROM " + tableName + " WHERE " + condition + " = '" + itemNeedToFind + "'";
            var myConn = new MySqlConnection(MyConnection);
            var myCommand = new MySqlCommand(sql, myConn);
            var count = 0;
            try
            {
                myConn.Open();
                var dr = myCommand.ExecuteReader();
                while (dr.Read())
                {
                    var str = dr[condition].ToString();
                    if (str != itemNeedToFind) continue;
                    switch (tableName)
                    {
                        case "NHANKHAU":
                            var itemNk = new ListViewItem(dr["MNK"].ToString());
                            itemNk.SubItems.Add(dr["Ten"].ToString());
                            itemNk.SubItems.Add(dr["NgaySinh"].ToString());
                            itemNk.SubItems.Add(dr["GioiTinh"].ToString());
                            itemNk.SubItems.Add(dr["QueQuan"].ToString());
                            itemNk.SubItems.Add(dr["TonGiao"].ToString());
                            itemNk.SubItems.Add(dr["DanToc"].ToString());
                            itemNk.SubItems.Add(dr["CMND"].ToString());
                            itemNk.SubItems.Add(dr["MHK"].ToString());
                            itemNk.SubItems.Add(dr["NgheNghiep"].ToString());
                            lstView.Items.Add(itemNk);
                            break;
                        case "HOKHAU":
                            var itemHk = new ListViewItem(dr["MHK"].ToString());
                            itemHk.SubItems.Add(dr["TenChuHo"].ToString());
                            itemHk.SubItems.Add(dr["CMNDChuHo"].ToString());
                            itemHk.SubItems.Add(dr["KhuVuc"].ToString());
                            itemHk.SubItems.Add(dr["DiaChiHK"].ToString());
                            itemHk.SubItems.Add(dr["NgayLap"].ToString());
                            lstView.Items.Add(itemHk);
                            break;
                        case "TAMTRU":
                            var itemTt = new ListViewItem(dr["MTT"].ToString());
                            itemTt.SubItems.Add(dr["MNK"].ToString());
                            itemTt.SubItems.Add(dr["TenNoiTamTru"].ToString());
                            itemTt.SubItems.Add(dr["DiaChi"].ToString());
                            itemTt.SubItems.Add(dr["SoDienThoai"].ToString());
                            itemTt.SubItems.Add(dr["ThoiHan"].ToString());
                            lstView.Items.Add(itemTt);
                            break;
                        case "CHUNGTU":
                            var itemCt = new ListViewItem(dr["MCT"].ToString());
                            itemCt.SubItems.Add(dr["TenNguoiKhai"].ToString());
                            itemCt.SubItems.Add(dr["ThuongTamTru"].ToString());
                            itemCt.SubItems.Add(dr["QHVoiNguoiMat"].ToString());
                            itemCt.SubItems.Add(dr["TenNguoiMat"].ToString());
                            itemCt.SubItems.Add(dr["NgaySinh"].ToString());
                            itemCt.SubItems.Add(dr["DanToc"].ToString());
                            itemCt.SubItems.Add(dr["QuocTich"].ToString());
                            itemCt.SubItems.Add(dr["CMND"].ToString());
                            itemCt.SubItems.Add(dr["NgayMat"].ToString());
                            itemCt.SubItems.Add(dr["GioMat"].ToString());
                            itemCt.SubItems.Add(dr["KVDK"].ToString());
                            itemCt.SubItems.Add(dr["NgayDK"].ToString());
                            lstView.Items.Add(itemCt);
                            break;
                        case "KETHON":
                            var itemKh = new ListViewItem(dr["MKH"].ToString());
                            itemKh.SubItems.Add(dr["TenChong"].ToString());
                            itemKh.SubItems.Add(dr["NgaySinhChong"].ToString());
                            itemKh.SubItems.Add(dr["DanTocChong"].ToString());
                            itemKh.SubItems.Add(dr["QueQuanChong"].ToString());
                            itemKh.SubItems.Add(dr["ThuongTamTruChong"].ToString());
                            itemKh.SubItems.Add(dr["CMNDChong"].ToString());
                            itemKh.SubItems.Add(dr["TenVo"].ToString());
                            itemKh.SubItems.Add(dr["NgaySinhVo"].ToString());
                            itemKh.SubItems.Add(dr["DanTocVo"].ToString());
                            itemKh.SubItems.Add(dr["QueQuanVo"].ToString());
                            itemKh.SubItems.Add(dr["ThuongTamTruVo"].ToString());
                            itemKh.SubItems.Add(dr["CMNDVo"].ToString());
                            itemKh.SubItems.Add(dr["KVDK"].ToString());
                            itemKh.SubItems.Add(dr["NgayDK"].ToString());
                            lstView.Items.Add(itemKh);
                            break;
                        case "TIENANTIENSU":
                            var itemTats = new ListViewItem(dr["MaTATS"].ToString());
                            itemTats.SubItems.Add(dr["MNK"].ToString());
                            itemTats.SubItems.Add(dr["TenTATS"].ToString());
                            itemTats.SubItems.Add(dr["NoiXetXu"].ToString());
                            itemTats.SubItems.Add(dr["NgayThucThi"].ToString());
                            lstView.Items.Add(itemTats);
                            break;
                    }
                    count++;
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (count == 0)
            {
                MessageBox.Show(@"Dữ liệu cần tìm không tồn tại");
            }
        }
    }
}
