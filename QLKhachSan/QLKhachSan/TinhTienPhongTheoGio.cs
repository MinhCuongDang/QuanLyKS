using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan
{
    public class TinhTienPhongTheoGio
    {
        private int a;
        private double b;
        public TinhTienPhongTheoGio(int a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public double ex()
        {
            double re;
            re = this.a * this.b;
            return re;
        }
    }
}
