using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Mini_App
{
    /// <summary>
    /// Interaction logic for index.xaml
    /// </summary>
    public partial class index : Window
    {
        TakeAwayPOSEntities db = new TakeAwayPOSEntities();
        public index()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Thread.Sleep(5000);
        }

        private void btn_ban1_Loaded(object sender, RoutedEventArgs e)
        {
            var a = from ttb in db.ThongTinBans where ttb.MaBan == 1 && ttb.TinhTrang == "0" select ttb.MaBan;
            if(a.Count() > 0)
            {
                BrushConverter bc = new BrushConverter();
                btn_ban1.Background = (Brush)bc.ConvertFrom("#FF673AB7");
            }
            else
            {
                btn_ban1.Background = Brushes.Red;
            }
        }

        private void btn_ban2_Loaded(object sender, RoutedEventArgs e)
        {
            var a = from ttb in db.ThongTinBans where ttb.MaBan == 2 && ttb.TinhTrang == "0" select ttb.MaBan;
            if (a.Count() > 0)
            {
                BrushConverter bc = new BrushConverter();
                btn_ban2.Background = (Brush)bc.ConvertFrom("#FF673AB7");
            }
            else
            {
                btn_ban2.Background = Brushes.Red;
            }
        }

        private void btn_ban3_Loaded(object sender, RoutedEventArgs e)
        {
            var a = from ttb in db.ThongTinBans where ttb.MaBan == 3 && ttb.TinhTrang == "0" select ttb.MaBan;
            if (a.Count() > 0)
            {
                BrushConverter bc = new BrushConverter();
                btn_ban3.Background = (Brush)bc.ConvertFrom("#FF673AB7");
            }
            else
            {
                btn_ban3.Background = Brushes.Red;
            }
        }

        private void btn_ban4_Loaded(object sender, RoutedEventArgs e)
        {
            var a = from ttb in db.ThongTinBans where ttb.MaBan == 4 && ttb.TinhTrang == "0" select ttb.MaBan;
            if (a.Count() > 0)
            {
                BrushConverter bc = new BrushConverter();
                btn_ban4.Background = (Brush)bc.ConvertFrom("#FF673AB7");
            }
            else
            {
                btn_ban4.Background = Brushes.Red;
            }
        }

        private void btn_ban5_Loaded(object sender, RoutedEventArgs e)
        {
            var a = from ttb in db.ThongTinBans where ttb.MaBan == 5 && ttb.TinhTrang == "0" select ttb.MaBan;
            if (a.Count() > 0)
            {
                BrushConverter bc = new BrushConverter();
                btn_ban5.Background = (Brush)bc.ConvertFrom("#FF673AB7");
            }
            else
            {
                btn_ban5.Background = Brushes.Red;
            }
        }

        private void btn_ban6_Loaded(object sender, RoutedEventArgs e)
        {
            var a = from ttb in db.ThongTinBans where ttb.MaBan == 6 && ttb.TinhTrang == "0" select ttb.MaBan;
            if (a.Count() > 0)
            {
                BrushConverter bc = new BrushConverter();
                btn_ban6.Background = (Brush)bc.ConvertFrom("#FF673AB7");
            }
            else
            {
                btn_ban6.Background = Brushes.Red;
            }
        }

        private void btn_ban7_Loaded(object sender, RoutedEventArgs e)
        {
            var a = from ttb in db.ThongTinBans where ttb.MaBan == 7 && ttb.TinhTrang == "0" select ttb.MaBan;
            if (a.Count() > 0)
            {
                BrushConverter bc = new BrushConverter();
                btn_ban7.Background = (Brush)bc.ConvertFrom("#FF673AB7");
            }
            else
            {
                btn_ban7.Background = Brushes.Red;
            }
        }

        private void btn_ban8_Loaded(object sender, RoutedEventArgs e)
        {
            var a = from ttb in db.ThongTinBans where ttb.MaBan == 8 && ttb.TinhTrang == "0" select ttb.MaBan;
            if (a.Count() > 0)
            {
                BrushConverter bc = new BrushConverter();
                btn_ban8.Background = (Brush)bc.ConvertFrom("#FF673AB7");
            }
            else
            {
                btn_ban8.Background = Brushes.Red;
            }
        }

        private void btn_ban9_Loaded(object sender, RoutedEventArgs e)
        {
            var a = from ttb in db.ThongTinBans where ttb.MaBan == 9 && ttb.TinhTrang == "0" select ttb.MaBan;
            if (a.Count() > 0)
            {
                BrushConverter bc = new BrushConverter();
                btn_ban9.Background = (Brush)bc.ConvertFrom("#FF673AB7");
            }
            else
            {
                btn_ban9.Background = Brushes.Red;
            }
        }

        private void btn_ban10_Loaded(object sender, RoutedEventArgs e)
        {
            var a = from ttb in db.ThongTinBans where ttb.MaBan == 10 && ttb.TinhTrang == "0" select ttb.MaBan;
            if (a.Count() > 0)
            {
                BrushConverter bc = new BrushConverter();
                btn_ban10.Background = (Brush)bc.ConvertFrom("#FF673AB7");
            }
            else
            {
                btn_ban10.Background = Brushes.Red;
            }
        }

        private void btn_ban11_Loaded(object sender, RoutedEventArgs e)
        {
            var a = from ttb in db.ThongTinBans where ttb.MaBan == 11 && ttb.TinhTrang == "0" select ttb.MaBan;
            if (a.Count() > 0)
            {
                BrushConverter bc = new BrushConverter();
                btn_ban11.Background = (Brush)bc.ConvertFrom("#FF673AB7");
            }
            else
            {
                btn_ban11.Background = Brushes.Red;
            }
        }

        private void btn_ban12_Loaded(object sender, RoutedEventArgs e)
        {
            var a = from ttb in db.ThongTinBans where ttb.MaBan == 12 && ttb.TinhTrang == "0" select ttb.MaBan;
            if (a.Count() > 0)
            {
                BrushConverter bc = new BrushConverter();
                btn_ban12.Background = (Brush)bc.ConvertFrom("#FF673AB7");
            }
            else
            {
                btn_ban12.Background = Brushes.Red;
            }
        }

        private void btn_ban13_Loaded(object sender, RoutedEventArgs e)
        {
            var a = from ttb in db.ThongTinBans where ttb.MaBan == 13 && ttb.TinhTrang == "0" select ttb.MaBan;
            if (a.Count() > 0)
            {
                BrushConverter bc = new BrushConverter();
                btn_ban13.Background = (Brush)bc.ConvertFrom("#FF673AB7");
            }
            else
            {
                btn_ban13.Background = Brushes.Red;
            }
        }

        private void btn_ban14_Loaded(object sender, RoutedEventArgs e)
        {
            var a = from ttb in db.ThongTinBans where ttb.MaBan == 14 && ttb.TinhTrang == "0" select ttb.MaBan;
            if (a.Count() > 0)
            {
                BrushConverter bc = new BrushConverter();
                btn_ban14.Background = (Brush)bc.ConvertFrom("#FF673AB7");
            }
            else
            {
                btn_ban14.Background = Brushes.Red;
            }
        }

        private void btn_ban15_Loaded(object sender, RoutedEventArgs e)
        {
            var a = from ttb in db.ThongTinBans where ttb.MaBan == 15 && ttb.TinhTrang == "0" select ttb.MaBan;
            if (a.Count() > 0)
            {
                BrushConverter bc = new BrushConverter();
                btn_ban15.Background = (Brush)bc.ConvertFrom("#FF673AB7");
            }
            else
            {
                btn_ban15.Background = Brushes.Red;
            }
        }
    }
}
