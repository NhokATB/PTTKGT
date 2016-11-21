using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon
{
    class Distance
    {
        private double khoangCach;

        public double KhoangCach
        {
            get { return khoangCach; }
            set { khoangCach = value; }
        }
        private double thoiGian;

        public double ThoiGian
        {
            get { return thoiGian; }
            set { thoiGian = value; }
        }
        public Distance()
        {

        }
        public Distance(double khoangCach, double thoiGian) 
        {
            this.khoangCach = khoangCach;
            this.thoiGian = thoiGian;
        }
            
    }
}
