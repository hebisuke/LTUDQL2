using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;

namespace Mini_App
{
    public partial class RyoCaffeReport : DevExpress.XtraReports.UI.XtraReport
    {
        public RyoCaffeReport(string TenBan, List<ChiTietDonHang> data)
        {
            InitializeComponent();
            DateTime today = DateTime.Today;
            P_NgayHienTai.Value = today;
            P_TenBan.Value = TenBan;
            objectDataSource1.DataSource = data;
        }

    }
}
