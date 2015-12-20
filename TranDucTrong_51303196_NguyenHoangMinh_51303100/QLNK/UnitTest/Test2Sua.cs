using NUnit.Framework;
using QLNK;

namespace UnitTest
{
    [TestFixture]
    public class Test2Sua
    {
        readonly SourceCode _sourceCode = new SourceCode();

        [Test]
        public void Test1_SuaHoKhau()
        {
            //Giả định đúng 1: sửa thông tin hộ khẩu
            var resultT1 = _sourceCode.UpdateHoKhau("MHK-1", "Trần Văn ABCDEF", "025450506", "Hà Nội",
                                         "111 đường 37 quận 7 phường Tân Quy", "16/09/1995");

            Assert.IsTrue(resultT1);
        }

        [Test]
        public void Test2_SuaNhanKhau()
        {

            //Giả định đúng 1: Thêm mã nhân khẩu
            var resultT1 = _sourceCode.UpdateNhanKhau("MNK-1", "Trần Đức ABCDEF", "16/09/1995", "Nam", "TPHCM",
                                         "Phật giáo", "Kinh", "025450506", "MHK-1", "Sinh viên");

            Assert.IsTrue(resultT1);
        }

        [Test]
        public void Test3_SuaTienAnTienSu()
        {
            //Giả định đúng 1: Thêm mã tiền án tiền sự
            var resultT1 = _sourceCode.UpdateTienAnTienSu("TATS-1", "MNK-1", "Hiếp dâm", "TPHCM", "16/09/1995");

            Assert.IsTrue(resultT1);
        }

        [Test]
        public void Test4_SuaTamTru()
        {
            //Giả định đúng 1: Thêm mã tạm trú
            var resultT1 = _sourceCode.UpdateTamTru("MTT-1", "MNK-1", "Nhà trọ", "Địa chỉ ma, đường đến địa ngục!", "01283636848", "16/09/1995");
            
            Assert.IsTrue(resultT1);
        }

        [Test]
        public void Test5_SuaChungTu()
        {
            //Giả định đúng 1: Thêm mã chứng tử
            var resultT1 = _sourceCode.UpdateChungTu("MCT-1", "Trần Văn ABCDEF", "123, đường 45, phường 67, quận 8",
                                                  "Cha", "Trần Văn FEDCBA", "12/12/1965", "Kinh", "Việt Nam", "123456789",
                                                  "11/11/2015", "22:30", "TPHCM", "11/11/2015");

            Assert.IsTrue(resultT1);
        }

        [Test]
        public void Test6_SuaChungNhanKetHon()
        {
            //Giả định đúng 1: Thêm mã chứng nhận kết hôn
            var resultT1 = _sourceCode.UpdateKetHon("MKH-1", "Trần Văn ABCDEF", "12/12/1965", "Kinh", "TPHCM",
                                                 "123, đường 45, phường 67, quận 8", "123456789", "Trần Thị ABCDEF",
                                                 "12/12/1965", "Kinh", "TPHCM", "123, đường 45, phường 67, quận 8",
                                                 "987654321", "TPHCM", "11/11/2015");

            Assert.IsTrue(resultT1);
        }

        [Test]
        public void Test7_SuaMatKhauCanBo()
        {
            //Giả định đúng 1: sửa mật khẩu
            var resultT1 = _sourceCode.UpdateMatKhau("ductrongth", "ductrong", "11/11/2011");

            Assert.IsTrue(resultT1);
        }

        [Test]
        public void Test7_PhanQuyenCanBo()
        {
            //Giả định đúng 1: sửa mật khẩu
            var resultT1 = _sourceCode.UpdatePhanQuyen("ductrongth", 5, "11/11/2011");

            Assert.IsTrue(resultT1);
        }
    }
}
