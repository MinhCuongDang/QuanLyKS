using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLKhachSan;

namespace TestTinhLuongNhanVienUnit
{
    [TestClass]
    public class UnitTest1
    {
        private tinhLuongNhanVien tlnv;
        [TestInitialize]
        public void SetUp()
        {
            tlnv = new tinhLuongNhanVien(2300000, (float)1.5, (float)1.08);
        }
        [TestMethod]
        public void TestTinhLuongNhanVienUnit()
        {
            Assert.AreEqual(tlnv.ex(), 5934000);
        }
    }
}
