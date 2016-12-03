using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace BaiTapLon
{
    public partial class Form1 : Form
    {
        private LoTrinh lt;
        public Form1()
        {
            InitializeComponent();
            lt = new LoTrinh();
       
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lt.ReadFileDistance();
            lt.ReadFileStation();
            lt.ReadFileBus();
            lt.LoTrinhXe();
            foreach (string s in lt.Output)
            {
                lstHienThi.Items.Add(s);
            }
        }

    }
}
