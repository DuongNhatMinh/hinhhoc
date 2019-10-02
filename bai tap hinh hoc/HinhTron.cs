using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_hinh_hoc
{
    class HinhTron: HinhHoc
    {
        private const float pi = 3.14f;
        public float r;

        public float chuvi;
        public float dientich;

        public float BanKinh
        {
            get { return r; }
            set { r = value; }
        }

        public HinhTron() { }
        public HinhTron(float r)
        {
            this.r = r;
        }
        public void CV()
        {
            this.chuvi = r * 2 * pi;
        }

        public void DT()
        {
            this.dientich = 2 * pi * (r * r);
        }
    }
}
