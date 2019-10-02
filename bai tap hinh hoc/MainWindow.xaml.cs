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

namespace bai_tap_hinh_hoc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HinhVuong[] hinhvuongs = null;
        List<HinhTron> hinhtrons = null;
        string[] DataHV = null;
        List<string> DataHT = null;
        public MainWindow()
        {
            InitializeComponent();
        }
       
        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            HinhCN hcn = new HinhCN(4, 3);
            hcn.CV();
            hcn.DT();
            
            MessageBox.Show("Chu vi HinhCN: " + hcn.chuvi.ToString()
                            + "\nDien Tich HinhCN: " + hcn.dientich.ToString());                                          
        }
        int dem = 0;
         
        private void Button_Click(object sender, RoutedEventArgs e)
        {           
            HinhVuong hv = new HinhVuong(3);
            hv.CV();
            hv.DT();
            MessageBox.Show("\nChu vi HinhVuong: " + hv.chuvi.ToString() 
                + "\nDien Tich HinhVuong: " + hv.dientich.ToString());


            LstHinhVuong.Items.Add("STT" + "\t\t" + "Canh" + "\t\t" + "ChuVi" + "\t\t" + "DienTich");
            hinhvuongs = new HinhVuong[5];
            int[] canh = { 5, 3, 6, 7, 4 };
            for (int i = 0; i < hinhvuongs.Length; i++)
                hinhvuongs[i] = new HinhVuong(canh[i]);           
            for (int i = 0; i < hinhvuongs.Length; i++)
            {
                hinhvuongs[i].CV();
                hinhvuongs[i].DT();
                 LstHinhVuong.Items.Add("HinhVuong " + (i + 1).ToString() + "\t" + hinhvuongs[i].Canh.ToString() + "\t\t"
                    + hinhvuongs[i].chuvi.ToString() + "\t\t" + hinhvuongs[i].dientich.ToString());
            }
            
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            HinhTron ht = new HinhTron(3);
            ht.CV();
            ht.DT();
            MessageBox.Show("\nChu vi HinhTron: " + ht.chuvi.ToString()
                            + "\nDien Tich HinhTron: " + ht.dientich.ToString());


            LstHinhTron.Items.Add("STT" + "\t\t" + "Canh" + "\t\t" + "ChuVi" + "\t\t" + "DienTich");
            hinhtrons = new List<HinhTron>();
            int[] bankinh = { 6, 3, 10, 9, 5 };
            for (int i = 0; i < 5; i++) hinhtrons.Add(new HinhTron(bankinh[i]));          
            for (int i = 0; i < bankinh.Length; i++)
            {
                hinhtrons[i].CV();
                hinhtrons[i].DT();
                LstHinhTron.Items.Add("HinhTron " + (i + 1).ToString() + "\t" + hinhtrons[i].BanKinh.ToString() + "\t\t"
                    + hinhtrons[i].chuvi.ToString() + "\t\t" + hinhtrons[i].dientich.ToString());
            }
            
        }


    }
}
