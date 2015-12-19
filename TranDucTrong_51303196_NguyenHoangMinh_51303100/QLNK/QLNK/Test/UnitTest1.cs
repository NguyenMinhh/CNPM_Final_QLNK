using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLNK;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        //Tất cả trường hợp giả định sai đều đã được chương trình giải quyết.
        SourceCode sc = new SourceCode();
        [TestMethod]
        public void testThemNhanKhau()
        {
            sc.setForeignKey("0");
            sc.clearAllValues("TIENANTIENSU");
            sc.clearAllValues("TAMTRU");
            sc.clearAllValues("NHANKHAU");
            sc.setForeignKey("1");

            //Giả định đúng 1: Thêm mã nhân khẩu
            bool resultT1 = sc.addNhanKhau("MNK-1", "Trần Đức Trọng", "16/09/1995", "Nam","TPHCM",
                                         "Phật giáo","Kinh", "025450506","MHK-1","Sinh viên");

            //Giả định sai 1: trùng mã nhân khẩu
            bool resultF1 = sc.addNhanKhau("MNK-1", "Trần Đức Trọng", "16/09/1995", "Nam", "TPHCM",
                                         "Phật giáo", "Kinh", "025450506", "MHK-1", "Sinh viên");

            //Giả định sai 2: mã hộ khẩu không tồn tại
            bool resultF2 = sc.addNhanKhau("MNK-2", "Trần Đức Trọng", "16/09/1995", "Nam", "TPHCM",
                                         "Phật giáo", "Kinh", "025450506", "MHK-10", "Sinh viên");

            Assert.IsTrue(resultT1);
            Assert.IsFalse(resultF1);
            Assert.IsFalse(resultF2);
        }

        [TestMethod]
        public void testThemHoKhau()
        {
            sc.setForeignKey("0");
            sc.clearAllValues("TIENANTIENSU");
            sc.clearAllValues("TAMTRU");
            sc.clearAllValues("NHANKHAU");
            sc.clearAllValues("HOKHAU");
            sc.setForeignKey("1");

            //Giả định đúng 1: Thêm mã hộ khẩu
            bool resultT1 = sc.addHoKhau("MHK-1", "Trần Đức Trọng", "025450506", "TPHCM",
                                         "111 đường 37 quận 7 phường Tân Quy","16/09/1995");

            //Giả định sai 1: trùng mã hộ khẩu
            bool resultF1 = sc.addHoKhau("MHK-1", "Trần Đức Trọng", "025450506", "TPHCM",
                                         "111 đường 37 quận 7 phường Tân Quy", "16/09/1995");

            Assert.IsTrue(resultT1);
            Assert.IsFalse(resultF1);
        }

        [TestMethod]
        public void testThemTienAnTienSu()
        {
            sc.setForeignKey("0");
            sc.clearAllValues("TIENANTIENSU");
            sc.setForeignKey("1");

            //Giả định đúng 1: Thêm mã tiền án tiền sự
            bool resultT1 = sc.addTienAnTienSu("TATS-1", "MNK-1", "Giết người cướp tài sản", "TPHCM", "16/09/1995");

            //Giả định sai 1: Trùng mã tiền án tiền sự
            bool resultF1 = sc.addTienAnTienSu("TATS-1", "MNK-1", "Giết người cướp tài sản", "TPHCM", "16/09/1995");

            //Giả định sai 2: mã nhân khẩu không tồn tại
            bool resultF2 = sc.addTienAnTienSu("TATS-2", "MNK-10", "Giết người cướp tài sản", "TPHCM", "16/09/1995");

            Assert.IsTrue(resultT1);
            Assert.IsFalse(resultF1);
            Assert.IsFalse(resultF2);
        }

        [TestMethod]
        public void testThemTamTru()
        {
            sc.setForeignKey("0");
            sc.clearAllValues("TAMTRU");
            sc.setForeignKey("1");

            //Giả định đúng 1: Thêm mã tạm trú
            bool resultT1 = sc.addTamTru("MTT-1", "MNK-1", "Nhà trọ", "111 đường 37 quận 7 phường Tân Quy", "01283636848", "16/09/1995");

            //Giả định sai 1: Trùng mã tạm trú
            bool resultF1 = sc.addTamTru("MTT-1", "MNK-1", "Nhà trọ", "111 đường 37 quận 7 phường Tân Quy", "01283636848", "16/09/1995");

            //Giả định sai 2: mã nhân khẩu không tồn tại
            bool resultF2 = sc.addTamTru("MTT-2", "MNK-10", "Nhà trọ", "111 đường 37 quận 7 phường Tân Quy", "01283636848", "16/09/1995");

            Assert.IsTrue(resultT1);
            Assert.IsFalse(resultF1);
            Assert.IsFalse(resultF2);
        }

        [TestMethod]
        public void testThemChungTu()
        {

        }

        [TestMethod]
        public void testThemChungNhanKetHon()
        {

        }
    }
}
