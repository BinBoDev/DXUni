   M S B A M L   `   `   `  ����=  9DX, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:DX.ViewDX.View  5   	       DX.View.XuatNLWD   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   !localclr-namespace:DX.View  5   	   -   5          � Icon$&   /DX;component/View/Image/Uni.ico��5	   	   $��Center=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$, &Xuất nguyên liệu cho sản xuất��5   	   $	��450��6/   $	��800��6<   .��5      � .+�5   
   #  MaterialDesignThemes.Wpf.Card  .��5      �  � RowDefinitions 5      �� 5      $��40 �6$   �� 5      $��* �6$   �� 5      $��* �6$   �� 5      $��40 �6$   .+�5        $��2q�6&   $��0��61   .��5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� ��6!   �� *FillDataCammand+.��5      �� $ 
Horizontal=�6)   $��Center=�6B   .+�5   "   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$  ClipboardTextSearchOutline=�6:   $��2,0,2,0q�6\   �� 5    "   $��Filter��6,   $��2,0,2,0q�6:   5!      5"      (  "System.Windows.Controls.DatePicker  5#      $��	10,2,10,2q�5&      $	��100��5'      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Ngày bắt đầu��5(      .  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton$
 True��5)       (  $MaterialDesignFloatingHintDatePicker#��[  5*         SelectedDate 5$      �� *
StartDay+	 �� UpdateSourceTrigger$	 PropertyChanged=�
 �� Mode$
 TwoWay=�5*        5,      $��	10,2,10,2q�5.      $	��100��5/      $ Ngày kết thúc��50      $
 True��51      #��[  52       5-      �� *EndDay+$	 PropertyChanged=�$
 TwoWay=�52      � 54      $	��120��6   .+�55      �� 
��� � �$	��2,0q�58   !   3  -MaterialDesignThemes.Wpf.ButtonProgressAssist   IsIndeterminate$
 True��59   !      IsIndicatorVisible$
 True��5:   !      Value$ -1Q�5;   !   $��Import Data��5<   !     MaterialDesignRaisedButton#��[ 5>   !   ��56   !   �� *ImportCommand+{�5=   !   �� *DataContext.ControlsEnabled+ �� RelativeSource �� *FindAncestor+ �� AncestorType
 Window5>   !   5@      5A      5B        5D      $��2q�6&   $��1��61   .��5E      �� 
���   �$��1q�61   ._�5F      �� $
��Auto=�6'   $
��Auto=�6L   .��5G      &   System.Windows.Controls.DataGrid  -   5        $��	dtgXuatNL��5G   [      CanUserAddRows$ False��6(      AutoGenerateColumns$ False��6?   ��6l   �� *	XuatNLs+$	 PropertyChanged=�$
 TwoWay=� �� SelectedItem 6�   �� *IsSelectedRow+$	 PropertyChanged=�   Columns 5H   "   0  *System.Windows.Controls.DataGridTextColumn  5I   &   ,	  &System.Windows.Controls.DataGridColumn 	  Header$ Id��69    	  
IsReadOnly$
 True��6\   1
  +System.Windows.Controls.DataGridBoundColumn 
  Binding 6E   �� *Id+6\     5J   &   $ CodeNL��69   $
 True��6d      
Foreground
 �  �� 6I   �� *CodeNL+6v     5K   &   $ TenNL��69   $
 True��6b   
 ��  � 6H   �� *TenNL+6t     5L   &   $ Soluongxuat��69   $
 True��6n    6N   �� *Soluongxuat+6n     5M   &   $ Ngaygioxuatthucte��69   $
 True��6z    6T   �� *Ngaygioxuatthucte+6z     5N   &   $ KehoachThangNam��69   $
 True��6v   
 � � � 6R   �� *KehoachThangNam+6�     5O   &   $ Index��69   $
 True��6b   
 �  �� 6H   �� *Index+6t     5P   &   $ Xuatkhosanxuatngay��69   $
 True��6|    6U   �� *Xuatkhosanxuatngay+6|   4  .System.Windows.Controls.DataGridTemplateColumn  5Q   &   $ Delete��6=      CellTemplate 5R   *   �� 5S   .   .R�5T   2   �� $��btnDel��69   
���  ����6X   �� *DataContext.DelItem+ �� "  .��5U   6   �� $ 
Horizontal=�6A   .+�5V   :     $ DeleteOutline=�6R   �� 5W   :   $
��Xóa��6D   5X   7   5Y   3   5Z   /   5\   '   5^      5_      5b      5c        5e      $��2��6&   $��2q�63   .��5f      �� 
���   �$��1q�61   ._�5g      �� $
��Auto=�6'   $
��Auto=�6L   .��5h        -   5        $��dtgShowFileExcel��5h   [   $ False��6(   $ False��6?   ��6s   �� *	ExcelShow+$
 TwoWay=� 6�   �� *SelectedXuatNL+ 5i   "     5j   &   $ CodeNL��69   $
 True��6d    6I   �� *CodeNL+6d     5k   &   $ TenNL��69   $
 True��6b    6H   �� *TenNL+6b     5l   &   $ Soluongxuat��69   $
 True��6n    6N   �� *Soluongxuat+6n     5m   &   $ Ngaygioxuatthucte��69   $
 True��6z    6T   �� *Ngaygioxuatthucte+6z     5n   &   $ KehoachThangNam��69   $
 True��6v    6R   �� *KehoachThangNam+6v     5o   &   $ Index��69   $
 True��6b    6H   �� *Index+6b     5p   &   $ Xuatkhosanxuatngay��69   $
 True��6|    6U   �� *Xuatkhosanxuatngay+6|     5q   &   $ Select��6=    5r   *   �� 5s   .   .R�5t   2   �� $��	ckSelectd��6;   
��� � ���6_   �� *DataContext.IsCheckCommand+ �� "  .��5u   6   �� $ 
Horizontal=�6A   .+�5v   :     $ CursorDefaultClickOutline=�6R   �� 5w   :   $��Chọn��6D   5x   7   5y   3   5z   /   5|   '   5~      5      5�      5�        5�      $��3��6&   $��2q�63   .��5�      �� $ 
Horizontal=�6!   .+�5�      �� $��2q�6!   
��� � ���6?   �� *ShowExcelCommand+.��5�      �� $ 
Horizontal=�6)   $��Center=�6B   .+�5�   "     $ Search=�6:   �� 5�   "   $��	Tìm File��6,   5�      5�      �� 5�      $��2q�6!   
���� K���6@   �� *UpDateDataGrig+.��5�      �� $ 
Horizontal=�6)   $��Center=�6B   .+�5�   "     $ Import=�6:   �� 5�   "   $��
Thêm Data��6,   5�      5�      5�      5�      5�      5�      5�      5�      