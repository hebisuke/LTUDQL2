using MahApps.Metro.Controls;
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

namespace Mini_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        TakeAwayPOSEntities db = new TakeAwayPOSEntities();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Thoat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_DangNhap_Click(object sender, RoutedEventArgs e)
        {
            var a = from tk in db.TaiKhoans where tk.Username == tbx_TenDangNhap.Text && tk.MatKhau == tbx_MatKhau.Password select tk.Username;
            if(a.Count()>0)
            {
                MessageBox.Show("Đăng nhập thành công!");
                var manv = from tk in db.TaiKhoans where tk.Username == tbx_TenDangNhap.Text select tk.ID;
                index frmindex = new index( manv.ToList().FirstOrDefault() );
                frmindex.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Lỗi tài khoản hoặc mật khẩu", "Thông báo lỗi", MessageBoxButton.OK, MessageBoxImage.Warning);
                tbx_TenDangNhap.Focus();
            }
        }
    }
}
