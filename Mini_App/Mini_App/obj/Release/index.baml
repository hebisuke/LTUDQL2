   M S B A M L   `   `   `  ���� C  ?Mini_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Mini_AppMini_App      Mini_App.index   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v16.2, Version=16.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aR NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:Mini_App     ] YDevExpress.Mvvm.v16.2, Version=16.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aAdxmvvm2http://schemas.devexpress.com/winfx/2008/xaml/mvvm   ;dx2http://schemas.devexpress.com/winfx/2008/xaml/core  U QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f9Custom,http://metro.mahapps.com/winfx/xaml/controls  -     � Title$  Quản lý bán hàng��$	��720��$
��1280�� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=�2  ,DevExpress.Mvvm.UI.Interactivity.Interaction   	Behaviors /  )DevExpress.Xpf.Core.DXSplashScreenService      ShowSplashScreenOnLoading .    SplashScreenType   Mini_App.SplashScreenView"  .��� .+��� -    ��Name$ groupBox��$��Danh sách bàn��$
��Left=�$	��720��$	��Top=�$	��640��.��� $	��675��$	��Top=�$	��630��$��0,0,0,-7q�.+��� -    ��Name$ btn_ban1��$��Bàn 1��$
��Left=�$	��150��$	��Top=�$	��150���� -   $ btn_ban2��$��Bàn 2��$
��Left=�$	��150��$	��Top=�$	��150��$��	155,0,0,0q��� -   $ btn_ban3��$��Bàn 3��$
��Left=�$	��150��$	��Top=�$	��150��$��	310,0,0,0q��� -   $ btn_ban4��$��Bàn 4��$
��Left=�$	��150��$	��Top=�$	��150��$��	465,0,0,0q��� -   $ btn_ban5��$��Bàn 5��$
��Left=�$	��150��$	��Top=�$	��150��$��	0,155,0,0q��� -   $ btn_ban6��$��Bàn 6��$
��Left=�$	��150��$	��Top=�$	��150��$��155,155,0,0q��� -	   $ btn_ban7��$��Bàn 7��$
��Left=�$	��150��$	��Top=�$	��150��$��310,155,0,0q��� -
   $ btn_ban8��$��Bàn 8��$
��Left=�$	��150��$	��Top=�$	��150��$��465,155,0,0q��� -   $ btn_ban9��$��Bàn 9��$
��Left=�$	��150��$	��Top=�$	��150��$��	0,310,0,0q��� -   $ 	btn_ban10��$��Bàn 10��$
��Left=�$	��150��$	��Top=�$	��150��$��155,310,0,0q��� -   $ 	btn_ban11��$��Bàn 11��$
��Left=�$	��150��$	��Top=�$	��150��$��310,310,0,0q��� -   $ 	btn_ban12��$��Bàn 12��$
��Left=�$	��150��$	��Top=�$	��150��$��465,310,0,0q��� -   $ 	btn_ban13��$��Bàn 13��$
��Left=�$	��150��$	��Top=�$	��150��$��	0,465,0,0q��� -   $ 	btn_ban14��$��Bàn 14��$
��Left=�$	��150��$	��Top=�$	��150��$��155,465,0,0q��� -   $ 	btn_ban15��$��Bàn 15��$
��Left=�$	��150��$	��Top=�$	��150��$��310,465,0,0q��� -   $ btn_Menu��$
��Menu��$
��Left=�$	��150��$	��Top=�$	��150��$��465,465,0,0q��� -   $ 	groupBox1��$��Chi tiết order��$
��Left=�$	��366��$��	645,0,0,0q�$	��Top=�$	��625��.��� $	��322��$	��Top=�$	��615��$��0,0,0,-8q�.+�&   System.Windows.Controls.DataGrid  -     Name$ dgv_NoiDung��$
��Left=�$	��207��$��	10,80,0,0q�$	��Top=�$	��595���� -   	 ��Name$	 lb_TongTien��$��Tổng tiền:��$
��Left=�$��30��$��465,292,0,0q�$	��Top=�$	��140���� -   
 ��Name$
 tbx_BanDuocChon��$
��Left=�$��34��$��	10,10,0,0q�$
��Wrap=�$��Tên bàn được chọn��$	��Top=�$	��101���� -   $ btn_In��$��In Hóa Đơn��$
��Left=�$��48��$��
465,10,0,0q�$	��Top=�$	��140���� -   $ btn_ThanhToan��$��Thanh Toán��$
��Left=�$��48��$��
320,10,0,0q�$	��Top=�$	��140�� J� RenderTransformOrigin$ 0.318,0.604&��� -   $ 	groupBox2��$��Thêm order��$	��271��$��755,371,125,0q�$	��Top=�.��� $	��218��$	��Top=�$	��384��.+��� -   $
 
textBlock1��$
��Left=�$��33��$��	10,10,0,0q�$
��Wrap=�$ ��Tên Bàn Được Chọn:��$	��Top=�$��94���� -    ��Name$ 
cbx_TenBan��$
��Left=�$��27��$��
147,10,0,0q�$	��Top=�$	��218��
���   ��� -   $
 textBlock1_Copy��$
��Left=�$��33��$��	10,68,0,0q�$
��Wrap=�$'��!Tên Đồ Uống Được Chọn��$	��Top=�$��94���� -   $ cbx_TenDoUong��$
��Left=�$��27��$��
147,68,0,0q�$	��Top=�$	��218���� -   $
 textBlock1_Copy1��$
��Left=�$��33��$��
15,107,0,0q�$
��Wrap=�$��Số Lượng��$	��Top=�$��94��*  $MahApps.Metro.Controls.NumericUpDown  -     Name$ tbx_SoLuong��$
��Left=�$��42��$��150,107,0,0q�$	��Top=�$	��215��   Maximum$
 1000Q�   Minimum$ 1Q�   Value$ 1X��� -    $ btn_ThemOrder��$��Thêm order��$
��Left=�$��41��$��
15,167,0,0q�$	��Top=�$	��353��