using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon
{
    class Bus
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private int kichCo;

        public int KichCo
        {
            get { return kichCo; }
            set { kichCo = value; }
        }
        public Bus()
        {

        }
        public Bus(int id, int kichCo)
        {
            this.id = id;
            this.kichCo = kichCo;
        }
    }
}
