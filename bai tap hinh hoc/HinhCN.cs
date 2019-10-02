using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_hinh_hoc
{
    class HinhCN: HinhHoc
    {
        protected float ChieuDai;
        private float ChieuRong;

        public float chuvi;
        public float dientich;
        public float Dai
        {
            get { return ChieuDai; }
            set { ChieuDai = value; }
        }

        public float Rong
        {
            get { return ChieuRong; }
            set { ChieuRong = value; }
        }

        public HinhCN(float dai, float rong)
        {
            ChieuDai = dai;
            ChieuRong = rong;
        }

        public HinhCN() { }

        public void CV()
        {
            chuvi = (ChieuDai + ChieuRong) * 2;
        }

        public void DT()
        {
            dientich = ChieuDai * ChieuRong;
        }
    }
}
