using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hình_học
{
    class HinhVuong: HinhCN
    {
        public double chuVi;
        public double dientich;

        public double Canh
        {
            get { return chieudai; }
            set { chieudai = value; }
        }

        public HinhVuong() { }

        public HinhVuong(double canh)
        {
            chieudai = canh;
        }

        public void ChuVi()
        {
            chuVi = Canh * 4;
        }
        public void DienTich()
        {
            dientich = Canh * Canh;
        }
    }
}
