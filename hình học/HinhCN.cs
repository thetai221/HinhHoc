using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hình_học
{
    class HinhCN
    {
        protected double chieudai;
        private double chieurong;

        public double chuvi;
        public double dientich;
        public double Dai
        {
            get { return chieudai; }
            set { chieudai = value; }
        }

        public double Rong
        {
            get { return chieurong; }
            set { chieurong = value; }
        }

        public HinhCN(double dai, double rong)
        {
            chieudai = dai;
            chieurong = rong;
        }

        public HinhCN() { }

        public void ChuVi()
        {
            chuvi = (chieudai + chieurong) * 2;
        }

        public void DienTich()
        {
            dientich = chieudai * chieurong;
        }
    }
}
