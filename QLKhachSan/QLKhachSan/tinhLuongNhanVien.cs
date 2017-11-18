using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan
{
    public class tinhLuongNhanVien
    {
        private float a;
        private float b;
        private float c;
        public tinhLuongNhanVien(float a, float b, float c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public float ex()
        {
            float re;
            re = a * (b + c);
            return re;
        }
    }
}
