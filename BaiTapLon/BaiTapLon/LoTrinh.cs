using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace BaiTapLon
{
    class LoTrinh
    {
        private List<Bus> ListBus;
        private List<Station> ListStation;
        private Distance[,] DistanceMatrix;

       
        public LoTrinh()
        {
            ListBus = new List<Bus>();
            ListStation = new List<Station>();
            DistanceMatrix = new Distance[42, 42];
        }

        #region Doc du lieu tu cac file
        public void ReadFileBus()
        {
            StreamReader bus = new StreamReader(@"C:\Users\Ngoc Vy\Desktop\PTTKGT\BaiTapLon\BaiTapLon\input\buses.txt");
            string tam;
            string[] split = new string[2];
            while ((tam = bus.ReadLine()) != null)
            {
                split = tam.Split('\t');
                ListBus.Add(new Bus(int.Parse(split[0]), int.Parse(split[1])));
            }
            bus.Close();
        }
        public void ReadFileDistance()
        {
            int i = 0, j = 0;
            StreamReader distance = new StreamReader(@"C:\Users\Ngoc Vy\Desktop\PTTKGT\BaiTapLon\BaiTapLon\input\distance.txt");
            string tam;
            string[] split = new string[2];
            while ((tam = distance.ReadLine()) != null)
            {
                if (j == 42)
                {
                    j = 0;
                    i++;
                }
                split = tam.Split('\t');
                DistanceMatrix[i, j] = new Distance(double.Parse(split[0]), double.Parse(split[1]));
                j++;
            }
            distance.Close();
        }
        public void ReadFileStation()
        {
            StreamReader station = new StreamReader(@"C:\Users\Ngoc Vy\Desktop\PTTKGT\BaiTapLon\BaiTapLon\input\station.txt");
            string tam;
            string[] split = new string[4];
            while ((tam = station.ReadLine()) != null)
            {
                split = tam.Split('\t');
                ListStation.Add(new Station(int.Parse(split[0]), double.Parse(split[1]), double.Parse(split[2]), int.Parse(split[3])));
            }
            station.Close();
        }
        #endregion

       

    }
}
