   M S B A M L   `   `   `  ����=  9DX, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:DX.ViewDX.View  5   	       DX.View.AccountManager   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   !localclr-namespace:DX.View  5   	     � 
ResizeMode$  NoResize=�5	   	    � Icon$&  /DX;component/View/Image/Uni.ico��5
   	   $��Center=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ Quản lý tài khoản��5   	   $	��500��6#   $	��500��60    � 	Resources 5          DX.View.BoolToIntConverter   BoolToIntConverter��%   &	          5   
   6#   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   #  MaterialDesignThemes.Wpf.Card  $��5q�6   $��0q�6)   .��5      ��  �� Orientation$ 
Horizontal=�6   $��Center=�62   5      5        5   
   $��1��6   $��5q�6+   .��5      �  � ColumnDefinitions 5      �� 5      $
��auto �6'   �� 5      $��* �6'   .+�5       �  5!      �� 5"      �� 5#      .+�5%      �� $ 
Horizontal=�6!   $��Center=�6:   .+�5&      �� -   5        $��txtUsername��5(      $��5q�5)      $��Center=�5*      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tên đăng nhập��5+       % !MaterialDesignFloatingHintTextBox#��[ 5,      ��5'      �� *
Username+	 �� UpdateSourceTrigger$	 PropertyChanged=�
 �� Mode$
 TwoWay=�5,      �� 5-      -   5        $��
txtPasword��5/      $��5q�50      $��Center=�51      $ Password��52      #��[ 53      ��5.      �� *
Password+$	 PropertyChanged=�$
 TwoWay=�53      	� 54      -   5        $��rbAdmin��55   A   $��Admin��6   $��	20,5,10,5q�6.   
 � Tag$ 1��6P    d� 	IsChecked 56      �� *Type+ �� 	Converter# [   �� ConverterParameter$ 1��	� 58      -   5        $��rbSub��58   ?   $	��Sub��6&   $��5q�64   $ 2��6L    59      �� *Type+# [  $ 2��	� 5;      -   5        $��rbNomal��5<   5   $��Nomal��6%   $ 3��6D    5=      �� *Type+# [  $ 3���� 5?      -   5        $��btnAdd��5?   C   $��Thêm��6!   $��	20,5,10,5q�60   
��� � ���6d   �� *
AddCommand+5@      &   System.Windows.Controls.DataGrid  5B      $��1��6      CanUserAddRows$ False��6,      AutoGenerateColumns$ False��6D   ��6`   �� *
Accounts+$	 PropertyChanged=� �� SelectedItem 6�   �� *SelectedAccount+   Columns 5C      0  *System.Windows.Controls.DataGridTextColumn  5D      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��61      
IsReadOnly$
 True��6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *Id+6T     5E      $ Username��61   $
 True��6`    6C   �� *
Username+6`     5F      $ Password��61   $
 True��6`    6C   �� *
Password+   ElementStyle 5G   "   �� 5H   &    �� 
TargetType" ��6,   .�5I   *   ��  �� Property � �� �� Value$
 ****��6A   5J   '   5L        5M      $
 Type��61   $
 True��6X    6?   �� *Type+6X   4  .System.Windows.Controls.DataGridTemplateColumn  5N      $ Delete��65      CellTemplate 5O   "   �� 5P   &   .R�5Q   *   �� $��btnDel��61   
���  ����6P   �� *DataContext.DelCommand+ �� RelativeSource ��  �� AncestorType"  .��5R   .   �� $ 
Horizontal=�69   .+�5S   2   '	  !MaterialDesignThemes.Wpf.PackIcon	   	  Kind$ DeleteOutline=�6J   �� 5T   2   $
��Xóa��6<   5U   /   5V   +   5W   '   5Y      5[      5\      � 5]      $��1��6   5_      5`      5a      5b      5c      