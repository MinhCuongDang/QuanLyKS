using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLKhachSan;

namespace ThanhTienCTHDUnit
{
    [TestClass]
    public class ThanhTienCTHDUnit
    {
        private ThanhTienCTHD tt;
        [TestInitialize]
        public void setUp()
        {
            tt = new ThanhTienCTHD(25000, 3);
        }
        [TestMethod]
        public void testThanhTienCTHDunit()
        {
            Assert.AreEqual(tt.Ex(), 75000);
        }
    }
}
