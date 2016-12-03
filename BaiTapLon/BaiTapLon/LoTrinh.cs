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

        private const int maxTime = 2400;
        private double totalTime = 0;
        private int tramHienTai;
        private int tramXaTruongNhat = -1;
        private int tramTruong = 0;
        private int tramKeTiep = -1;


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

        public void TramXaTruongNhat()
        {
            //MessageBox.Show("da chay vao TramXaTruongNhat");
            double max = 0;
            tramXaTruongNhat = -1;
            for (int i = 1; i < 42; i++)
            {
                if (DistanceMatrix[tramTruong, i].ThoiGian > max && ListStation[i].SoHocSinh > 0)
                {
                    max = DistanceMatrix[tramTruong, i].ThoiGian;
                    tramXaTruongNhat = i;
                }
            }

        }
        public void TimTramkeTiep()
        {
            double min = 2401;
            int tam = -1;
            for (int i = 1; i < 42; i++)
            {
                //MessageBox.Show("da chay vao TimTramKeTiep");
                if (DistanceMatrix[tramHienTai, i].ThoiGian < min && ListStation[i].SoHocSinh > 0)
                {
                    if ((totalTime + DistanceMatrix[tramHienTai, i].ThoiGian + DistanceMatrix[i, 0].ThoiGian) <= maxTime)
                    {
                        min = DistanceMatrix[tramHienTai, i].ThoiGian;
                        tam = i;
                    }
                }
            }
            tramKeTiep = tam;
        }
        public bool Stop()
        {
            //MessageBox.Show("da chay vao stop");
            foreach (Station s in ListStation)
            {
                if (s.SoHocSinh > 0) return false;
            }
            return true;
        }
        public void Start(Bus currentBus)
        {
            totalTime = 0;

            tramHienTai = tramXaTruongNhat;
            if (currentBus.KichCo >= ListStation[tramXaTruongNhat].SoHocSinh)
            {
                //MessageBox.Show("da chay vao if cua Start");
                currentBus.KichCo -= ListStation[tramXaTruongNhat].SoHocSinh;
                tuyenDuong.Append(tramXaTruongNhat.ToString() + "(" + ListStation[tramXaTruongNhat].SoHocSinh + "; 0" + ")");
                ListStation[tramXaTruongNhat].SoHocSinh = 0;
            }
            else
            {
                //MessageBox.Show("da chay vao else cua Start");

                isFull = true;
                ListStation[tramXaTruongNhat].SoHocSinh -= currentBus.KichCo;
                tuyenDuong.Append(tramXaTruongNhat.ToString() + "(" + currentBus.KichCo + "; " + totalTime + ")");
                currentBus.KichCo = 0;
            }
        }

    }
}
