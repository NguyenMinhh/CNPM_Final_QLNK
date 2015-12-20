using NUnit.Framework;
using QLNK;

namespace UnitTest
{
    [TestFixture]
    public class Test1Them
    {
        readonly SourceCode _sourceCode = new SourceCode();

        [Test]
        public void Test1_ThemHoKhau()
        {
            _sourceCode.SetForeignKey("0");
            _sourceCode.ClearAllValues("TIENANTIENSU");
            _sourceCode.ClearAllValues("TAMTRU");
            _sourceCode.ClearAllValues("NHANKHAU");
            _sourceCode.ClearAllValues("HOKHAU");
            _sourceCode.SetForeignKey("1");

            //Giả định đúng 1: Thêm mã hộ khẩu
            var resultT1 = _sourceCode.AddHoKhau("MHK-1", "Trần Đức Trọng", "025450506", "TPHCM",
                                         "111 đường 37 quận 7 phường Tân Quy", "16/09/1995");

            //Giả định sai 1: trùng mã hộ khẩu
            var resultF1 = _sourceCode.AddHoKhau("MHK-1", "Trần Đức Trọng", "025450506", "TPHCM",
                                         "111 đường 37 quận 7 phường Tân Quy", "16/09/1995");

            Assert.IsTrue(resultT1);
            Assert.IsFalse(resultF1);
        }

        [Test]
        public void Test2_ThemNhanKhau()
        {
            _sourceCode.SetForeignKey("0");
            _sourceCode.ClearAllValues("TIENANTIENSU");
            _sourceCode.ClearAllValues("TAMTRU");
            _sourceCode.ClearAllValues("NHANKHAU");
            _sourceCode.SetForeignKey("1");

            //Giả định đúng 1: Thêm mã nhân khẩu
            var resultT1 = _sourceCode.AddNhanKhau("MNK-1", "Trần Đức Trọng", "16/09/1995", "Nam", "TPHCM",
                                         "Phật giáo", "Kinh", "025450506", "MHK-1", "Sinh viên");

            //Giả định sai 1: trùng mã nhân khẩu
            var resultF1 = _sourceCode.AddNhanKhau("MNK-1", "Trần Đức Trọng", "16/09/1995", "Nam", "TPHCM",
                                         "Phật giáo", "Kinh", "025450506", "MHK-1", "Sinh viên");

            //Giả định sai 2: mã hộ khẩu không tồn tại
            var resultF2 = _sourceCode.AddNhanKhau("MNK-2", "Trần Đức Trọng", "16/09/1995", "Nam", "TPHCM",
                                         "Phật giáo", "Kinh", "025450506", "MHK-10", "Sinh viên");

            Assert.IsTrue(resultT1);
            Assert.IsFalse(resultF1);
            Assert.IsFalse(resultF2);
        }

        [Test]
        public void Test3_ThemTienAnTienSu()
        {
            _sourceCode.SetForeignKey("0");
            _sourceCode.ClearAllValues("TIENANTIENSU");
            _sourceCode.SetForeignKey("1");

            //Giả định đúng 1: Thêm mã tiền án tiền sự
            var resultT1 = _sourceCode.AddTienAnTienSu("TATS-1", "MNK-1", "Giết người cướp tài sản", "TPHCM", "16/09/1995");

            //Giả định sai 1: Trùng mã tiền án tiền sự
            var resultF1 = _sourceCode.AddTienAnTienSu("TATS-1", "MNK-1", "Giết người cướp tài sản", "TPHCM", "16/09/1995");

            //Giả định sai 2: mã nhân khẩu không tồn tại
            var resultF2 = _sourceCode.AddTienAnTienSu("TATS-2", "MNK-10", "Giết người cướp tài sản", "TPHCM", "16/09/1995");

            Assert.IsTrue(resultT1);
            Assert.IsFalse(resultF1);
            Assert.IsFalse(resultF2);
        }

        [Test]
        public void Test4_ThemTamTru()
        {
            _sourceCode.SetForeignKey("0");
            _sourceCode.ClearAllValues("TAMTRU");
            _sourceCode.SetForeignKey("1");

            //Giả định đúng 1: Thêm mã tạm trú
            var resultT1 = _sourceCode.AddTamTru("MTT-1", "MNK-1", "Nhà trọ", "111 đường 37 quận 7 phường Tân Quy", "01283636848", "16/09/1995");

            //Giả định sai 1: Trùng mã tạm trú
            var resultF1 = _sourceCode.AddTamTru("MTT-1", "MNK-1", "Nhà trọ", "111 đường 37 quận 7 phường Tân Quy", "01283636848", "16/09/1995");

            //Giả định sai 2: mã nhân khẩu không tồn tại
            var resultF2 = _sourceCode.AddTamTru("MTT-2", "MNK-10", "Nhà trọ", "111 đường 37 quận 7 phường Tân Quy", "01283636848", "16/09/1995");

            Assert.IsTrue(resultT1);
            Assert.IsFalse(resultF1);
            Assert.IsFalse(resultF2);
        }

        [Test]
        public void Test5_ThemChungTu()
        {
            _sourceCode.ClearAllValues("CHUNGTU");

            //Giả định đúng 1: Thêm mã chứng tử
            var resultT1 = _sourceCode.AddChungTu("MCT-1", "Trần Văn A", "123, đường 45, phường 67, quận 8",
                                                  "Cha", "Trần Văn B", "12/12/1965", "Kinh", "Việt Nam", "123456789",
                                                  "11/11/2015", "22:30", "TPHCM", "11/11/2015");

            //Giả định sai 1: Trùng mã chứng tử
            var resultF1 = _sourceCode.AddChungTu("MCT-1", "Trần Văn A", "123, đường 45, phường 67, quận 8",
                                                  "Cha", "Trần Văn B", "12/12/1965", "Kinh", "Việt Nam", "123456789",
                                                  "11/11/2015", "22:30", "TPHCM", "11/11/2015");

            Assert.IsTrue(resultT1);
            Assert.IsFalse(resultF1);
        }

        [Test]
        public void Test6_ThemChungNhanKetHon()
        {
            _sourceCode.ClearAllValues("KETHON");

            //Giả định đúng 1: Thêm mã chứng nhận kết hôn
            var resultT1 = _sourceCode.AddKetHon("MKH-1", "Trần Văn A", "12/12/1965", "Kinh", "TPHCM",
                                                 "123, đường 45, phường 67, quận 8", "123456789", "Trần Thị B",
                                                 "12/12/1965", "Kinh", "TPHCM", "123, đường 45, phường 67, quận 8",
                                                 "987654321", "TPHCM", "11/11/2015");

            //Giả định sai 1: Trùng mã chứng nhận kết hôn
            var resultF1 = _sourceCode.AddKetHon("MKH-1", "Trần Văn A", "12/12/1965", "Kinh", "TPHCM",
                                                 "123, đường 45, phường 67, quận 8", "123456789", "Trần Thị B",
                                                 "12/12/1965", "Kinh", "TPHCM", "123, đường 45, phường 67, quận 8",
                                                 "987654321", "TPHCM", "11/11/2015");

            Assert.IsTrue(resultT1);
            Assert.IsFalse(resultF1);
        }

        [Test]
        public void Test7_ThemCanBo()
        {
            //Giả định đúng 1: Thêm tài khoản
            var resultT1 = _sourceCode.AddTaiKhoan("ductrongth", "mrtrong", "12/12/1995", 1, "Trần Đức Trọng");

            //Giả định sai 1: Trùng tên tài khoản
            var resultF1 = _sourceCode.AddTaiKhoan("ductrongth", "mrtrong", "12/12/1995", 1, "Trần Đức Trọng");

            Assert.IsTrue(resultT1);
            Assert.IsFalse(resultF1);
        }
    }
}
