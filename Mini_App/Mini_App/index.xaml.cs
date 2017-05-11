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
        int MaNhanVien = 1;
        int MaBanDangChon = 0;
        public index( int manv)
        {
            InitializeComponent();
            MaNhanVien = manv;
            
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
        // load chi tiết từng bàn
        // dựa vào tình trạng =0 Đơn hàng và mã bàn
        private void btn_ban1_Click(object sender, RoutedEventArgs e)
        {
            MaBanDangChon = 1;
            tbx_BanDuocChon.Text = "Bàn đang chọn : Bàn 1";
            var madonhang = from dh in db.DonHangs where dh.TinhTrang == "0" && dh.MaBan == 1 select dh.MaDonHang;
            if(madonhang.Count() >0)
            {
                var lst = from ct in db.ChiTietDonHangs where ct.MaDonHang == madonhang.FirstOrDefault() select new { TenDoUong = ct.TenDoUong, SoLuong = ct.SoLuong, TongTien = ct.TongTien };
                dgv_NoiDung.ItemsSource= lst.ToList();
                decimal? a = 0;
                foreach(var item in lst)
                {
                    a += item.TongTien;
                }
                lb_TongTien.Content = "Tổng tiền: "+ a.ToString();
            }
            else
            {
                MessageBox.Show("Bàn trống!! Vui lòng tạo order mới");
                dgv_NoiDung.ItemsSource = null;
                lb_TongTien.Content = "Tổng tiền : 0";
                return;
            }
            
        }

        private void btn_ban2_Click(object sender, RoutedEventArgs e)
        {
            MaBanDangChon = 2;
            tbx_BanDuocChon.Text = "Bàn đang chọn : Bàn 2";
            var madonhang = from dh in db.DonHangs where dh.TinhTrang == "0" && dh.MaBan == 2 select dh.MaDonHang;
            if (madonhang.Count() > 0)
            {
                var lst = from ct in db.ChiTietDonHangs where ct.MaDonHang == madonhang.FirstOrDefault() select new { TenDoUong = ct.TenDoUong, SoLuong = ct.SoLuong, TongTien = ct.TongTien };
                dgv_NoiDung.ItemsSource = lst.ToList();
                decimal? a = 0;
                foreach (var item in lst)
                {
                    a += item.TongTien;
                }
                lb_TongTien.Content = "Tổng tiền: " + a.ToString();
            }
            else
            {
                MessageBox.Show("Bàn trống!! Vui lòng tạo order mới");
                dgv_NoiDung.ItemsSource = null;
                lb_TongTien.Content = "Tổng tiền : 0";
                return;
            }
        }

        private void btn_ban3_Click(object sender, RoutedEventArgs e)
        {
            MaBanDangChon = 3;
            tbx_BanDuocChon.Text = "Bàn đang chọn : Bàn 3";
            var madonhang = from dh in db.DonHangs where dh.TinhTrang == "0" && dh.MaBan == 3 select dh.MaDonHang;
            if (madonhang.Count() > 0)
            {
                var lst = from ct in db.ChiTietDonHangs where ct.MaDonHang == madonhang.FirstOrDefault() select new { TenDoUong = ct.TenDoUong, SoLuong = ct.SoLuong, TongTien = ct.TongTien };
                dgv_NoiDung.ItemsSource = lst.ToList();
                decimal? a = 0;
                foreach (var item in lst)
                {
                    a += item.TongTien;
                }
                lb_TongTien.Content = "Tổng tiền: " + a.ToString();
            }
            else
            {
                MessageBox.Show("Bàn trống!! Vui lòng tạo order mới");
                dgv_NoiDung.ItemsSource = null;
                lb_TongTien.Content = "Tổng tiền : 0";
                return;
            }
        }

        private void btn_ban4_Click(object sender, RoutedEventArgs e)
        {
            MaBanDangChon = 4;
            tbx_BanDuocChon.Text = "Bàn đang chọn : Bàn 4";
            var madonhang = from dh in db.DonHangs where dh.TinhTrang == "0" && dh.MaBan == 4 select dh.MaDonHang;
            if (madonhang.Count() > 0)
            {
                var lst = from ct in db.ChiTietDonHangs where ct.MaDonHang == madonhang.FirstOrDefault() select new { TenDoUong = ct.TenDoUong, SoLuong = ct.SoLuong, TongTien = ct.TongTien };
                dgv_NoiDung.ItemsSource = lst.ToList();
                decimal? a = 0;
                foreach (var item in lst)
                {
                    a += item.TongTien;
                }
                lb_TongTien.Content = "Tổng tiền: " + a.ToString();
            }
            else
            {
                MessageBox.Show("Bàn trống!! Vui lòng tạo order mới");
                dgv_NoiDung.ItemsSource = null;
                lb_TongTien.Content = "Tổng tiền : 0";
                return;
            }
        }

        private void btn_ban5_Click(object sender, RoutedEventArgs e)
        {
            MaBanDangChon = 5;
            tbx_BanDuocChon.Text = "Bàn đang chọn : Bàn 5";
            var madonhang = from dh in db.DonHangs where dh.TinhTrang == "0" && dh.MaBan == 5 select dh.MaDonHang;
            if (madonhang.Count() > 0)
            {
                var lst = from ct in db.ChiTietDonHangs where ct.MaDonHang == madonhang.FirstOrDefault() select new { TenDoUong = ct.TenDoUong, SoLuong = ct.SoLuong, TongTien = ct.TongTien };
                dgv_NoiDung.ItemsSource = lst.ToList();
                decimal? a = 0;
                foreach (var item in lst)
                {
                    a += item.TongTien;
                }
                lb_TongTien.Content = "Tổng tiền: " + a.ToString();
            }
            else
            {
                MessageBox.Show("Bàn trống!! Vui lòng tạo order mới");
                dgv_NoiDung.ItemsSource = null;
                lb_TongTien.Content = "Tổng tiền : 0";
                return;
            }
        }

        private void btn_ban6_Click(object sender, RoutedEventArgs e)
        {
            MaBanDangChon = 6;
            tbx_BanDuocChon.Text = "Bàn đang chọn : Bàn 6";
            var madonhang = from dh in db.DonHangs where dh.TinhTrang == "0" && dh.MaBan == 6 select dh.MaDonHang;
            if (madonhang.Count() > 0)
            {
                var lst = from ct in db.ChiTietDonHangs where ct.MaDonHang == madonhang.FirstOrDefault() select new { TenDoUong = ct.TenDoUong, SoLuong = ct.SoLuong, TongTien = ct.TongTien };
                dgv_NoiDung.ItemsSource = lst.ToList();
                decimal? a = 0;
                foreach (var item in lst)
                {
                    a += item.TongTien;
                }
                lb_TongTien.Content = "Tổng tiền: " + a.ToString();
            }
            else
            {
                MessageBox.Show("Bàn trống!! Vui lòng tạo order mới");
                dgv_NoiDung.ItemsSource = null;
                lb_TongTien.Content = "Tổng tiền : 0";
                return;
            }
        }

        private void btn_ban7_Click(object sender, RoutedEventArgs e)
        {
            MaBanDangChon = 7;
            tbx_BanDuocChon.Text = "Bàn đang chọn : Bàn 7";
            var madonhang = from dh in db.DonHangs where dh.TinhTrang == "0" && dh.MaBan == 7 select dh.MaDonHang;
            if (madonhang.Count() > 0)
            {
                var lst = from ct in db.ChiTietDonHangs where ct.MaDonHang == madonhang.FirstOrDefault() select new { TenDoUong = ct.TenDoUong, SoLuong = ct.SoLuong, TongTien = ct.TongTien };
                dgv_NoiDung.ItemsSource = lst.ToList();
                decimal? a = 0;
                foreach (var item in lst)
                {
                    a += item.TongTien;
                }
                lb_TongTien.Content = "Tổng tiền: " + a.ToString();
            }
            else
            {
                MessageBox.Show("Bàn trống!! Vui lòng tạo order mới");
                dgv_NoiDung.ItemsSource = null;
                lb_TongTien.Content = "Tổng tiền : 0";
                return;
            }
        }

        private void btn_ban8_Click(object sender, RoutedEventArgs e)
        {
            MaBanDangChon = 8;
            tbx_BanDuocChon.Text = "Bàn đang chọn : Bàn 8";
            var madonhang = from dh in db.DonHangs where dh.TinhTrang == "0" && dh.MaBan == 8 select dh.MaDonHang;
            if (madonhang.Count() > 0)
            {
                var lst = from ct in db.ChiTietDonHangs where ct.MaDonHang == madonhang.FirstOrDefault() select new { TenDoUong = ct.TenDoUong, SoLuong = ct.SoLuong, TongTien = ct.TongTien };
                dgv_NoiDung.ItemsSource = lst.ToList();
                decimal? a = 0;
                foreach (var item in lst)
                {
                    a += item.TongTien;
                }
                lb_TongTien.Content = "Tổng tiền: " + a.ToString();
            }
            else
            {
                MessageBox.Show("Bàn trống!! Vui lòng tạo order mới");
                dgv_NoiDung.ItemsSource = null;
                lb_TongTien.Content = "Tổng tiền : 0";
                return;
            }
        }

        private void btn_ban9_Click(object sender, RoutedEventArgs e)
        {
            MaBanDangChon = 9;
            tbx_BanDuocChon.Text = "Bàn đang chọn : Bàn 9";
            var madonhang = from dh in db.DonHangs where dh.TinhTrang == "0" && dh.MaBan == 9 select dh.MaDonHang;
            if (madonhang.Count() > 0)
            {
                var lst = from ct in db.ChiTietDonHangs where ct.MaDonHang == madonhang.FirstOrDefault() select new { TenDoUong = ct.TenDoUong, SoLuong = ct.SoLuong, TongTien = ct.TongTien };
                dgv_NoiDung.ItemsSource = lst.ToList();
                decimal? a = 0;
                foreach (var item in lst)
                {
                    a += item.TongTien;
                }
                lb_TongTien.Content = "Tổng tiền: " + a.ToString();
            }
            else
            {
                MessageBox.Show("Bàn trống!! Vui lòng tạo order mới");
                dgv_NoiDung.ItemsSource = null;
                lb_TongTien.Content = "Tổng tiền : 0";
                return;
            }
        }

        private void btn_ban10_Click(object sender, RoutedEventArgs e)
        {
            MaBanDangChon = 10;
            tbx_BanDuocChon.Text = "Bàn đang chọn : Bàn 10";
            var madonhang = from dh in db.DonHangs where dh.TinhTrang == "0" && dh.MaBan == 10 select dh.MaDonHang;
            if (madonhang.Count() > 0)
            {
                var lst = from ct in db.ChiTietDonHangs where ct.MaDonHang == madonhang.FirstOrDefault() select new { TenDoUong = ct.TenDoUong, SoLuong = ct.SoLuong, TongTien = ct.TongTien };
                dgv_NoiDung.ItemsSource = lst.ToList();
                decimal? a = 0;
                foreach (var item in lst)
                {
                    a += item.TongTien;
                }
                lb_TongTien.Content = "Tổng tiền: " + a.ToString();
            }
            else
            {
                MessageBox.Show("Bàn trống!! Vui lòng tạo order mới");
                dgv_NoiDung.ItemsSource = null;
                lb_TongTien.Content = "Tổng tiền : 0";
                return;
            }
        }

        private void btn_ban11_Click(object sender, RoutedEventArgs e)
        {
            MaBanDangChon = 11;
            tbx_BanDuocChon.Text = "Bàn đang chọn : Bàn 11";
            var madonhang = from dh in db.DonHangs where dh.TinhTrang == "0" && dh.MaBan == 11 select dh.MaDonHang;
            if (madonhang.Count() > 0)
            {
                var lst = from ct in db.ChiTietDonHangs where ct.MaDonHang == madonhang.FirstOrDefault() select new { TenDoUong = ct.TenDoUong, SoLuong = ct.SoLuong, TongTien = ct.TongTien };
                dgv_NoiDung.ItemsSource = lst.ToList();
                decimal? a = 0;
                foreach (var item in lst)
                {
                    a += item.TongTien;
                }
                lb_TongTien.Content = "Tổng tiền: " + a.ToString();
            }
            else
            {
                MessageBox.Show("Bàn trống!! Vui lòng tạo order mới");
                dgv_NoiDung.ItemsSource = null;
                lb_TongTien.Content = "Tổng tiền : 0";
                return;
            }
        }

        private void btn_ban12_Click(object sender, RoutedEventArgs e)
        {
            MaBanDangChon = 12;
            tbx_BanDuocChon.Text = "Bàn đang chọn : Bàn 12";
            var madonhang = from dh in db.DonHangs where dh.TinhTrang == "0" && dh.MaBan == 12 select dh.MaDonHang;
            if (madonhang.Count() > 0)
            {
                var lst = from ct in db.ChiTietDonHangs where ct.MaDonHang == madonhang.FirstOrDefault() select new { TenDoUong = ct.TenDoUong, SoLuong = ct.SoLuong, TongTien = ct.TongTien };
                dgv_NoiDung.ItemsSource = lst.ToList();
                decimal? a = 0;
                foreach (var item in lst)
                {
                    a += item.TongTien;
                }
                lb_TongTien.Content = "Tổng tiền: " + a.ToString();
            }
            else
            {
                MessageBox.Show("Bàn trống!! Vui lòng tạo order mới");
                dgv_NoiDung.ItemsSource = null;
                lb_TongTien.Content = "Tổng tiền : 0";
                return;
            }
        }

        private void btn_ban13_Click(object sender, RoutedEventArgs e)
        {
            MaBanDangChon = 13;
            tbx_BanDuocChon.Text = "Bàn đang chọn : Bàn 13";
            var madonhang = from dh in db.DonHangs where dh.TinhTrang == "0" && dh.MaBan == 13 select dh.MaDonHang;
            if (madonhang.Count() > 0)
            {
                var lst = from ct in db.ChiTietDonHangs where ct.MaDonHang == madonhang.FirstOrDefault() select new { TenDoUong = ct.TenDoUong, SoLuong = ct.SoLuong, TongTien = ct.TongTien };
                dgv_NoiDung.ItemsSource = lst.ToList();
                decimal? a = 0;
                foreach (var item in lst)
                {
                    a += item.TongTien;
                }
                lb_TongTien.Content = "Tổng tiền: " + a.ToString();
            }
            else
            {
                MessageBox.Show("Bàn trống!! Vui lòng tạo order mới");
                dgv_NoiDung.ItemsSource = null;
                lb_TongTien.Content = "Tổng tiền : 0";
                return;
            }
        }

        private void btn_ban14_Click(object sender, RoutedEventArgs e)
        {
            MaBanDangChon = 14;
            tbx_BanDuocChon.Text = "Bàn đang chọn : Bàn 14";
            var madonhang = from dh in db.DonHangs where dh.TinhTrang == "0" && dh.MaBan == 14 select dh.MaDonHang;
            if (madonhang.Count() > 0)
            {
                var lst = from ct in db.ChiTietDonHangs where ct.MaDonHang == madonhang.FirstOrDefault() select new { TenDoUong = ct.TenDoUong, SoLuong = ct.SoLuong, TongTien = ct.TongTien };
                dgv_NoiDung.ItemsSource = lst.ToList();
                decimal? a = 0;
                foreach (var item in lst)
                {
                    a += item.TongTien;
                }
                lb_TongTien.Content = "Tổng tiền: " + a.ToString();
            }
            else
            {
                MessageBox.Show("Bàn trống!! Vui lòng tạo order mới");
                dgv_NoiDung.ItemsSource = null;
                lb_TongTien.Content = "Tổng tiền : 0";
                return;
            }
        }

        private void btn_ban15_Click(object sender, RoutedEventArgs e)
        {
            MaBanDangChon = 15;
            tbx_BanDuocChon.Text = "Bàn đang chọn : Bàn 15";
            var madonhang = from dh in db.DonHangs where dh.TinhTrang == "0" && dh.MaBan == 15 select dh.MaDonHang;
            if (madonhang.Count() > 0)
            {
                var lst = from ct in db.ChiTietDonHangs where ct.MaDonHang == madonhang.FirstOrDefault() select new { TenDoUong = ct.TenDoUong, SoLuong = ct.SoLuong, TongTien = ct.TongTien };
                dgv_NoiDung.ItemsSource = lst.ToList();
                decimal? a = 0;
                foreach (var item in lst)
                {
                    a += item.TongTien;
                }
                lb_TongTien.Content = "Tổng tiền: " + a.ToString();
            }
            else
            {
                MessageBox.Show("Bàn trống!! Vui lòng tạo order mới");
                dgv_NoiDung.ItemsSource = null;
                lb_TongTien.Content = "Tổng tiền : 0";
                return;
            }
        }

        private void btn_Menu_Click(object sender, RoutedEventArgs e)
        {
            MaBanDangChon = 0;
               //load menu
               var lst = from mn in db.Menus select new { TenDoUong = mn.TenDoUong, GiaTien = mn.GiaTien };
            dgv_NoiDung.ItemsSource = lst.ToList();
            tbx_BanDuocChon.Text = "Menu :";
            lb_TongTien.Content = "";
        }

        private void cbx_TenBan_Loaded(object sender, RoutedEventArgs e)
        {
            var lst = from ttb in db.ThongTinBans select  new { MaBan = ttb.MaBan, TenBan= ttb.TenBan } ;
            cbx_TenBan.ItemsSource = lst.ToList();
            cbx_TenBan.SelectedValuePath = "MaBan";
            cbx_TenBan.DisplayMemberPath = "TenBan";
            
        }

        private void btn_ThemOrder_Click(object sender, RoutedEventArgs e)
        {
            if(cbx_TenBan.SelectedIndex <0)
            {
                MessageBox.Show("Chưa chọn Bàn cần thêm !!");
                return;
            }
            if(cbx_TenDoUong.SelectedIndex <0)
            {
                MessageBox.Show("Chưa chọn Đồ Uống cần thêm !!");
                return;
            }
            // cần 1 hàm tạo đơn hàng mới nếu bàn trống.
            // lấy tên đô uống 
            // tổng tiền : đựa vào sluon * gia tien( gia tiền lấy ma đò uống thông qua menu lấy)
            //so luong
            var maban = cbx_TenBan.SelectedValue.ToString();
            var madonhang = from dh in db.DonHangs where dh.MaBan.ToString() == maban && dh.TinhTrang == "0" select dh.MaDonHang;
            if(madonhang.Count() <=0)
            {
                DateTime today = DateTime.Today;
                var t = new DonHang
                {
                    NgayLap = today,
                    MaBan = (int?)cbx_TenBan.SelectedValue,
                    MaNV = MaNhanVien,
                    TinhTrang = "0",
                };
                db.DonHangs.Add(t);
                db.SaveChanges();
                // Cập nhật tình trạng bàn :
                var ban = (from b in db.ThongTinBans where b.MaBan == (int)cbx_TenBan.SelectedValue select b).FirstOrDefault();
                ban.TinhTrang = "1";
                db.SaveChanges();
                madonhang = from dh in db.DonHangs where dh.MaBan.ToString() == maban && dh.TinhTrang == "0" select dh.MaDonHang;
            }

            // Kiểm tra xem mã chi đơn đơn hàng đã có ma đồ uống đo chưa 
            var SoLuongorder = from ct1 in db.ChiTietDonHangs where ct1.MaDonHang == madonhang.ToList().FirstOrDefault() && ct1.MaDoUong == (int)cbx_TenDoUong.SelectedValue select ct1.SoLuong;
            var TTien = from mn in db.Menus where mn.MaDoUong == (int)cbx_TenDoUong.SelectedValue select mn.GiaTien;
            decimal? TongTienOder = TTien.ToList().FirstOrDefault() * ( (decimal?)tbx_SoLuong.Value + SoLuongorder.ToList().FirstOrDefault());
            if( SoLuongorder.FirstOrDefault() == null)
            {// Thêm mới 
                var ct = new ChiTietDonHang
                {
                    MaDonHang = madonhang.ToList().FirstOrDefault(),
                    MaDoUong = (int)cbx_TenDoUong.SelectedValue,
                    TenDoUong = cbx_TenDoUong.Text,
                    SoLuong = (int?)tbx_SoLuong.Value,
                    TongTien = TongTienOder,
                };
                db.ChiTietDonHangs.Add(ct);
            }
            else
            {// update
                var ctud = (from a in db.ChiTietDonHangs where a.MaDonHang == madonhang.FirstOrDefault() && a.MaDoUong == (int)cbx_TenDoUong.SelectedValue select a).FirstOrDefault();
                ctud.SoLuong = (int?)tbx_SoLuong.Value + SoLuongorder.FirstOrDefault();
                ctud.TongTien = TongTienOder;
            }
            
            
            db.SaveChanges();

           switch((int)cbx_TenBan.SelectedValue)
           {
               case 1: btn_ban1_Loaded(sender, e);
                    btn_ban1_Click(sender, e);
                    break;
                case 2: btn_ban2_Loaded(sender, e);
                    btn_ban2_Click(sender, e);
                    break;
                case 3: btn_ban3_Loaded(sender, e);
                    btn_ban3_Click(sender, e);
                    break;
                case 4: btn_ban4_Loaded(sender,e);
                    btn_ban4_Click(sender, e);
                    break;
                case 5: btn_ban5_Loaded(sender, e);
                    btn_ban5_Click(sender, e);
                    break;
                case 6: btn_ban6_Loaded(sender, e);
                    btn_ban6_Click(sender, e);
                    break;
                case 7: btn_ban7_Loaded(sender, e);
                    btn_ban7_Click(sender, e);
                    break;
                case 8: btn_ban8_Loaded(sender, e);
                    btn_ban8_Click(sender, e);
                    break;
                case 9: btn_ban9_Loaded(sender, e);
                    btn_ban9_Click(sender, e);
                    break;
                case 10: btn_ban10_Loaded(sender, e);
                    btn_ban10_Click(sender, e);
                    break;
                case 11: btn_ban11_Loaded(sender, e);
                    btn_ban11_Click(sender, e);
                    break;
                case 12: btn_ban12_Loaded(sender, e);
                    btn_ban12_Click(sender, e);
                    break;
                case 13: btn_ban13_Loaded(sender, e);
                    btn_ban13_Click(sender, e);
                    break;
                case 14: btn_ban14_Loaded(sender, e);
                    btn_ban14_Click(sender, e);
                    break;
                case 15: btn_ban15_Loaded(sender, e);
                    btn_ban15_Click(sender, e);
                    break;      
           }
            MessageBox.Show("Thêm thành công");
            // thêm insert chi tiết đơn hàng mới
        }

        private void cbx_TenDoUong_Loaded(object sender, RoutedEventArgs e)
        {
            var lst = from mn in db.Menus select new { MaDoUong = mn.MaDoUong,TenDoUong = mn.TenDoUong};
            cbx_TenDoUong.ItemsSource = lst.ToList();
            cbx_TenDoUong.SelectedValuePath = "MaDoUong";
            cbx_TenDoUong.DisplayMemberPath = "TenDoUong";
            
        }

        private void btn_ThanhToan_Click(object sender, RoutedEventArgs e)
        {
            // cập nhật tình trạng cho Đơn hàng , Thông tin bàn
            if( MaBanDangChon ==0)
            {
                btn_Menu_Click(sender, e);
                MessageBox.Show("Chưa chọn bàn cần thành toán");
                return;
            }
            var a = (from ban in db.ThongTinBans where ban.MaBan == MaBanDangChon select ban).FirstOrDefault();
            a.TinhTrang = "0";
            db.SaveChanges();
            var b = (from dh in db.DonHangs where dh.MaBan == MaBanDangChon && dh.TinhTrang == "0" select dh).FirstOrDefault();
            b.TinhTrang = "1";
            db.SaveChanges();
            switch (MaBanDangChon)
            {
                case 1:
                    btn_ban1_Loaded(sender, e);
                    btn_ban1_Click(sender, e);
                    break;
                case 2:
                    btn_ban2_Loaded(sender, e);
                    btn_ban2_Click(sender, e);
                    break;
                case 3:
                    btn_ban3_Loaded(sender, e);
                    btn_ban3_Click(sender, e);
                    break;
                case 4:
                    btn_ban4_Loaded(sender, e);
                    btn_ban4_Click(sender, e);
                    break;
                case 5:
                    btn_ban5_Loaded(sender, e);
                    btn_ban5_Click(sender, e);
                    break;
                case 6:
                    btn_ban6_Loaded(sender, e);
                    btn_ban6_Click(sender, e);
                    break;
                case 7:
                    btn_ban7_Loaded(sender, e);
                    btn_ban7_Click(sender, e);
                    break;
                case 8:
                    btn_ban8_Loaded(sender, e);
                    btn_ban8_Click(sender, e);
                    break;
                case 9:
                    btn_ban9_Loaded(sender, e);
                    btn_ban9_Click(sender, e);
                    break;
                case 10:
                    btn_ban10_Loaded(sender, e);
                    btn_ban10_Click(sender, e);
                    break;
                case 11:
                    btn_ban11_Loaded(sender, e);
                    btn_ban11_Click(sender, e);
                    break;
                case 12:
                    btn_ban12_Loaded(sender, e);
                    btn_ban12_Click(sender, e);
                    break;
                case 13:
                    btn_ban13_Loaded(sender, e);
                    btn_ban13_Click(sender, e);
                    break;
                case 14:
                    btn_ban14_Loaded(sender, e);
                    btn_ban14_Click(sender, e);
                    break;
                case 15:
                    btn_ban15_Loaded(sender, e);
                    btn_ban15_Click(sender, e);
                    break;
            }
            // cập nhật tình trạng cho Thông tin bàn
        }
    }
}
