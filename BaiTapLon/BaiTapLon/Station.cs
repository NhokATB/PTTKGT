using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon
{
    class Station
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private double kinhDo;

        public double KinhDo
        {
            get { return kinhDo; }
            set { kinhDo = value; }
        }
        private double viDo;

        public double ViDo
        {
            get { return viDo; }
            set { viDo = value; }
        }
        private int soHocSinh;

        public int SoHocSinh
        {
            get { return soHocSinh; }
            set { soHocSinh = value; }
        }
        public Station()
        {

        }
        public Station(int id, double kinhDo, double viDo, int soHocSinh)
        {
            this.id = id;
            this.kinhDo = kinhDo;
            this.viDo = viDo;
            this.soHocSinh = soHocSinh;
        }
    }
}
