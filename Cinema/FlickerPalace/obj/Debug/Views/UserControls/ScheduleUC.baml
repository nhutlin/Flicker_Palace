   M S B A M L   `   `   `  ����H  DFlickerPalace, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:FlickerPalace.Views.UserControls FlickerPalace.Views.UserControls  5      1    +FlickerPalace.Views.UserControls.ScheduleUC   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @local.clr-namespace:FlickerPalace.Views.UserControls     5      _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  6K   .��5	      � 
���   �.+�5
   
   ��    
logoButton#��[  6     K� ZIndex$  1��6Z   $��0q�6k   $	��152��6   $	��142��6�   $
��Left=�6�   $	��Top=�6�   $��	66,-4,0,0q�6�   ��65   �� *LogoClickCommand+.��5      �� $��Uniform=�6   $��/icons/logo.png��6&   $��89��6?   $	��121��6K   6Y   5      ]� 5   
   $  1��6   $��
0,-10,0,10q�6%   .+�5      �� $  1��6   
�������$��500,-480,0,0q�6<   $	��370��6R   $
��Left=�6^   $��60��6y   $��segoe ui)�6�   $��50(�6�   $��
ExtraBlack"�6�   $��S C H E D U L E��6�   6�   5      �� 5   
   .+�5      �� $
��Fill=�6   $
��1400��6#   $��/images/movieback.jpg��60   6Q   5      �� 5   
   -   5        $��
myComboBox��5      $
��Bold"�6%   $��165,250,0,0q�67   $��30��6L   $	��190��6X   $	��Top=�6d   $
��Left=�6|   ��6�   �� *Dates+*  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5      +  %Microsoft.Xaml.Behaviors.EventTrigger  5         	EventName$ SelectionChanged��6!   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     Command 6,   �� *SelectedCommand+   CommandParameter 5   ,   ��  �� ElementName$ 
myComboBox�� �� Path$ SelectedItem�6t   5      5      �� 5   
   -   5        $��	comboBox2��5   G   
���   �$��30��6�   $	��190��6�   $	��Top=�6�   $
��Left=�6�   $��400,250,0,0q�6�   ��6   �� *
Theaters+y�6X   �� *IsComboBoxVisible+ 5        5      $ SelectionChanged��6!   . 5         6,   �� *SelectedTheaterCommand+ 5    ,   �� $ 	comboBox2��$ SelectedItem�6s   5!      5#      &   System.Windows.Controls.DataGrid  5$   
   -   5          Name$ datagrid��5$      	   CanUserAddRows	 .  
������  DataGridRowStyle
   RowStyle#
 [ 6W   $
��Bold"�6�   $��20(�6�   $��Center=�6�      	RowHeight$ 50Q�6�   
��� ���$	��600��6�   $
��1118��6�   $��	0,300,0,0q�6     AutoGenerateColumns .  ��6  �� *Movies+ � 	Resources 5%      *  $System.Windows.Controls.DataGridCell �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value��%�  '        �� 5&      "  6   .�5'      ��  � ��
 ���� 63   �� 5(       � ��$ 0q�68   �� 5)       � ��
 �   �63    5*      P� 5+       �@ 
IsSelected . . �5,      ��  � ��
 ���� 6;   �� 5-       � ��
 �   �6;   �� 5.       � ��$ 0q�6@   5/      P� 50       �@J�IsMouseOver . . �51      ��  � ��
 ���� 6;   �� 52       � ��
 �   �6;   �� 53       � ��$ 0q�6@   54      56      57         Columns 58      4  .System.Windows.Controls.DataGridTemplateColumn  59      ,  &System.Windows.Controls.DataGridColumn   Header$ Movie��6*      Width5	  /System.Windows.Controls.DataGridLengthConverter$	 180	 69      CellTemplate 5:      �� 5;      .R�5<      �� $
��Wrap=�6(   $��18(�6<   ��6J   �� *	MovieName+6g   5=      5?      0
  *System.Windows.Controls.DataGridTextColumn
  5@      $ Sessions��6%   $	 140	 67   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6C   �� *MovieDateTime+
  5A      $ Theater��6%   $	 235	 66    6B   �� *	Theater+
  5B      $
 Date��6%   $	 140	 63    6?   �� *	MovieDate+
  5C      $ Duration��6%   $	 130	 67    6C   �� *
Duration+  5D      $ Price��6)   $	 140	 68    5E      �� 5F      .R�5G      �� .+�5H   "   �� $��10,0,0,0q�6C   ��6,   �� *Price+6W   �� 5I   "   $�� VNĐ ��6,   $��70,0,0,0q�69   6M   5J      5K      5M        5N      $ Seats��6)   $	 150	 68    5O      �� 5P      .R�5Q      �� .+�5R   "   �� $��46��6)   $��42��64   $  1��6@     
allButtons#��[ 6Q   $
��Left=�6u   
������ ��6�   �� *DataContext.SeatClickCommand+ �� RelativeSource ��  �� AncestorType$ DataGridL���6  �� .��5S   &   �� $
��Left=�6,   $��50��6G   $��40��6R   $��/Icons/seat.png��6^   6y   5T   #   �� 5U   "   $��	50,10,0,0q�6�   $��51��6�   $��25��6�   #��[ 6   ��6)   �� *DataContext.SeatClickCommand+ �� $ DataGridL���6�   �� $ datagrid��$ SelectedItem�.��5V   &   ��   txtblck#��[ 60   $  1��6Q   $��15(�6c   $
��Bold"�6q   $��Places��6�   6�   5W   #   5X      5Y      5[      5]      5^      5_      