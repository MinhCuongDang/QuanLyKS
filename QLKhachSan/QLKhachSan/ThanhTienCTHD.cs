using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan
{
    public class ThanhTienCTHD
    {
        private int a;
        private int b;
        public ThanhTienCTHD(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int Ex()
        {
            int result = 0;
            result = this.a * this.b;
            return result;
        }
    }
}
