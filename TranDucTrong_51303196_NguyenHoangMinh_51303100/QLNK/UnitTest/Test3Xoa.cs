using NUnit.Framework;
using QLNK;

namespace UnitTest
{
    [TestFixture]
    public class Test3Xoa
    {
        readonly SourceCode _sourceCode = new SourceCode();

        [Test]
        public void Test1_XoaTienAnTienSu()
        {
            //Giả định đúng 1: xóa thông tin tiền án tiền sự
            var resultT1 = _sourceCode.Xoa("TIENANTIENSU", "MaTATS", "TATS-1");

            Assert.IsTrue(resultT1);
        }

        [Test]
        public void Test2_XoaTamTru()
        {
            //Giả định đúng 1: xóa thông tin tạm trú
            var resultT1 = _sourceCode.Xoa("TAMTRU", "MTT", "MTT-1");

            Assert.IsTrue(resultT1);
        }

        [Test]
        public void Test3_XoaNhanKhau()
        {
            //Giả định đúng 1: xóa thông tin nhân khẩu
            var resultT1 = _sourceCode.Xoa("NHANKHAU", "MNK", "MNK-1");

            Assert.IsTrue(resultT1);
        }

        [Test]
        public void Test4_XoaHoKhau()
        {
            //Giả định đúng 1: xóa thông tin hộ khẩu
            var resultT1 = _sourceCode.Xoa("HOKHAU", "MHK", "MHK-1");

            Assert.IsTrue(resultT1);
        }

        [Test]
        public void Test5_XoaChungTu()
        {
            //Giả định đúng 1: xóa thông tin chứng tử
            var resultT1 = _sourceCode.Xoa("CHUNGTU", "MCT", "MCT-1");

            Assert.IsTrue(resultT1);
        }

        [Test]
        public void Test6_XoaChungNhanKetHon()
        {
            //Giả định đúng 1: xóa thông tin chứng nhận kết hôn
            var resultT1 = _sourceCode.Xoa("KETHON", "MKH", "MKH-1");

            Assert.IsTrue(resultT1);
        }

        [Test]
        public void Test6_XoaCanBo()
        {
            //Giả định đúng 1: xóa cán bộ quản lý
            var resultT1 = _sourceCode.Xoa("CANBO", "TaiKhoan", "ductrongth");

            Assert.IsTrue(resultT1);
        }
    }
}
