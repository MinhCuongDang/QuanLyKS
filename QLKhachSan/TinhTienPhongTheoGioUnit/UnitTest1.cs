using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLKhachSan;

namespace TinhTienPhongTheoGioUnit
{
    [TestClass]
    public class UnitTest1
    {
        private TinhTienPhongTheoGio tptg;
        [TestInitialize]
        public void SetUp()
        {
            tptg = new TinhTienPhongTheoGio(500000, 0.7);
        }
        [TestMethod]
        public void TestTienPhongTheoGioUnit()
        {
            Assert.AreEqual(tptg.ex(), 350000);
        }
    }
}
