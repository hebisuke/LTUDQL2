using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DevExpress.Xpf.Core;
using System.Windows.Markup;

namespace Mini_App
{
    /// <summary>
    /// Interaction logic for DXPrintxaml.xaml
    /// </summary>
    public partial class DXPrintxaml : DXWindow, IComponentConnector
    {
        string TenBan = "";
        List<ChiTietDonHang> data;
        public DXPrintxaml(string tb,List<ChiTietDonHang> lst)
        {
            InitializeComponent();
            TenBan = tb;
            data = lst;
        }

        private void preview_Loaded(object sender, RoutedEventArgs e)
        {
            RyoCaffeReport report = new RyoCaffeReport(TenBan,data);
            preview.DocumentSource = report;
            report.CreateDocument();
        }
    }
}
