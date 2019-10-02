using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace hình_học
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            HinhCN hcn = new HinhCN(4, 3);
            hcn.ChuVi();
            hcn.DienTich();
            MessageBox.Show("Chu vi hinh chu nhat: " + hcn.chuvi.ToString()
                            + "\nDien Tich hinh chu nhat: " + hcn.dientich.ToString());

            HinhVuong hv = new HinhVuong(3);
            hv.ChuVi();
            hv.DienTich();
            MessageBox.Show("Chu vi hinh vuong: " + hv.chuVi.ToString()
                            + "\nDien Tich: " + hv.dientich.ToString());
            HinhTron ht = new HinhTron(3);
            ht.ChuVi();
            ht.DienTich();
            MessageBox.Show("Chu vi: " + ht.chuvi.ToString()
                            + "\nDien Tich: " + ht.dientich.ToString());
            lb.Items.Add("STT" + "\t\t Cạnh" + "\t\t Chu vi" + "\t\t Diện tích");
            HinhVuong[] hinhvuongs = new HinhVuong[5];
            int[] canh = { 15, 3, 6, 9, 10 };
            for (int i = 0; i < hinhvuongs.Length; i++)
                hinhvuongs[i] = new HinhVuong(canh[i]);
            for (int i = 0; i < hinhvuongs.Length; i++)
            {
                hinhvuongs[i].ChuVi();
                hinhvuongs[i].DienTich();
                lb.Items.Add((i + 1).ToString() + "\t\t" + hinhvuongs[i].Canh.ToString() + "\t\t" + hinhvuongs[i].chuVi.ToString() + "\t\t" +
                    hinhvuongs[i].dientich.ToString());
            }

            lb1.Items.Add("STT" + "\t\t Bán kính" + "\t Chu vi" + "\t\tDiện tích");
            HinhTron[] hinhTrons = new HinhTron[5]; 
            int[] BK = { 6, 9, 14, 25, 5 };
            for (int i = 0; i < hinhTrons.Length; i++)
                hinhTrons[i] = new HinhTron(BK[i]);
            for (int i = 0; i < hinhTrons.Length; i++)
            {
                hinhTrons[i].ChuVi();
                hinhTrons[i].DienTich();
                lb1.Items.Add((i + 1).ToString() + "\t\t" + hinhTrons[i].Bankinh.ToString() + "\t\t" + hinhTrons[i].chuvi.ToString() + "\t\t" +
                    hinhTrons[i].dientich.ToString());
            }
        }
    }
}
