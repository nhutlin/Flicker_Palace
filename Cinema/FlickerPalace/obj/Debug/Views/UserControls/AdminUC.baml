   M S B A M L   `   `   `  ����H  DFlickerPalace, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:FlickerPalace.Views.UserControls FlickerPalace.Views.UserControls  5      .    (FlickerPalace.Views.UserControls.AdminUC   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @local.clr-namespace:FlickerPalace.Views.UserControls     5      _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  6K   $
��1900��5   7   .��5	      � 
���   �.+�5
   
   �� y�6   �� *PasswordSideVisibility+.+�5      ��    	buyButton#��[  6;   
���  ��$	��200��6s   $��50��6   $��Back to User Side��6�     K� ZIndex$  1��6�   
 �� Top$ 42��6�    �� Left$
 1133��6�   $��20(�6�   $
��Bold"�6�   
�������$
��Left=�6  $��Center=�6)  ��6   �� *BackToUserCommand+6F  �� 5      $��/Images/movieback.jpg��6   65   �� 5      $��40(�6   
�������$��DemiBold"�69   $��Welcome, Admin!��6P   $
��Left=�6g   $	 339��6�   $��Center=�6�   $	 612��6�   6�   �� 5      $��Email��6   $	 450��6$   $	 520��65   $��20(�6G   $
��Bold"�6U   
�������$
��Left=�6z   $��Center=�6�   6�   �� 5      $	��220��6-   $��30��69   $	 450��6E   $	 659��6V   $��18(�6h   $
��Left=�6v   $��Center=�6�   ��6   �� *Email+6�   �� 5      $��Password��6   $	 550��6'   $	 520��68   $��20(�6J   $
��Bold"�6X   
�������$
��Left=�6}   $��Center=�6�   6�   �� 5      $	��220��60   $��30��6<   $	 550��6H   $	 659��6Y   $��18(�6k   $
��Left=�6y   $��Center=�6�   ��6   �� *
Password+6�   �� 5      $��Log in��66   $	 623��6G   $	 658��6X   $	��100��6j   $��35��6v   $��18(�6�   $
��Bold"�6�   #��[  6�   
���  ��$
��Left=�6�   $��Center=�6�   ��6   �� *LoginCommand+6  5      � 5   
   y�6   �� *MainPartVisibility+.+�5      �� $
��1300��6   $	��400��6!   $	��Top=�6.   .��5      �� $
��Fill=�6   $��/Images/background.jpg��6'   6I   5      �� 5      
�������$	��200��6+   $��50��67   $
��Left=�6C   $	��Top=�6^   $��	ParkAdmin��6v   $
��Bold"�6�   $��35(�6�   $��10,6,0,0q�6�   6�   �� 5      $��60��6   $
��Left=�6   $	��Top=�6:   $��
190,-6,0,0q�6R   $��60��6f   .��5      �� $
��Fill=�6   $��/Icons/admin.png��6'   6C   5      �� 5      $��Right=�6;   $	��Top=�6W   $��
0,10,370,0q�6o   $	��150��6�   $��40��6�   $��Back To User Side��6�   $��16(�6�   $
��Bold"�6�     mainButtons#��[ 6�   
���  ��
���������6   �� *BackToUserCommand+6&  �� 5      $��Right=�6>   $	��Top=�6Z   $��
0,10,200,0q�6r   $	��150��6�   $��40��6�   $��	Add Movie��6�   $��20(�6�   $
��Bold"�6�   #��[ 6�   
�������
���   ���6   �� *AddMovieClickCommand+6  �� 5      $��Right=�6?   $	��Top=�6[   $��	0,10,20,0q�6s   $	��150��6�   $��40��6�   $��
All Places��6�   $��20(�6�   $
��Bold"�6�   #��[ 6�   
��� ���
���   ���6   �� *AllPlacesClickCommand+6$  �� 5       -   5        $��listbox��5    �   $��Center=�6   $	��850��64   $
��1550��6@   $��0q�6N   $��	0,360,0,0q�6�   
���   �$��Disabled=�6�   ��6c   �� *	AllMovies+ �� Mode$ TwoWay=� J� BitmapEffect 5!      F� 5"       F� ShadowDepth$ 10Q�6-    F� Color$
 Gray��6>    F� 	Direction$	 250Q�6K   6]   ��5$      �� 5%      .R�5&      � $��	35,20,0,0q�6$    � Orientation$ 
Horizontal=�67   6R   5'      ��5)      �� 5*      	 �� 
TargetType"	 ��6   .�5+      �� 
 �� Property
 � �� �� Value 5,      �� 5-   "    �� 
TargetType" ��62   .R�5.   &   �� $��Bd��52      #��z��5.   -    �� Padding# z��5/      #��z��50      #��z��51       J� SnapsToDevicePixels . ._�54   *   �� #��z��6;   #��z��55        �� ContentStringFormat �� ContentStringFormat# z 56       #��z��57       #��z��58       # z 59       5;   '    �� Triggers 5=   &   ]� 5>   *    ]� 
Conditions 5?   .   �� 5@   2    �� Property �@��IsSelectionActive �� Value .  6b   �� 5A   2    �@��
IsSelected . 6[   ./�5C   .   ��  �� 
TargetName$ Bd��6Q   
 � ��
 ���� 6a   �� 5D   .   $ Bd��6S   
 � �� 5E   2   ��5F   6   Transparent��6S   5H   /   5I   +   ]� 5J   *    5K   .   �� 5L   2    �@��IsSelectionActive . 6b   �� 5M   2    �@��
IsSelected . 6[   ./�5O   .   �� $ Bd��6Q   
 � ��
 ���� 6a   �� 5P   .   $ Bd��6S   
 � �� 5Q   2   ��5R   6   Transparent��6S   5T   /   5U   +   P� 5V   *    P� Property �@J�IsMouseOver P� Value . . �5W   .   �� $ Bd��6Q   
 � ��
 ���� 6a   �� 5X   .   $ Bd��6S   
 � �� 5Y   2   ��5Z   6   Transparent��6S   5\   /   5]   +   P� 5^   *    � {� .  . �5_   .   �� $ Bd��6W   
 � �� 5`   2   C� 5a   6    C� ResourceKey# Z��6F   5c   /   5d   +   5f   #   5i      5j      *  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5l      +  %Microsoft.Xaml.Behaviors.EventTrigger  5m         	EventName$ SelectionChanged��6%   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5n      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     Command 60   �� *EditMovieCommand+   CommandParameter 5o   ,   ��  �� ElementName$ listbox�� �� Path$ SelectedItem�6q   5q      ��5t      �� 5u      .R�5v      �� 
������ $��0q�6;     �� CornerRadius$  20��6O   $	��250��6a   $	��300��6m   ._�5w      � $��myGrid��60   $	��300��6#   
������ $��0,0,8,-4q�6W   .+�5y   "   �� $��image��6�   ! � Cursor$
! Hand��6(   $	��170��66   $	��115��6C   $��-150,15,0,50q�6O   $
��Fill=�6e     imgStyle#��[ 6t   ��6�   �� *	ImagePath+6�   �� 5z   "   $��filmnametxtBox��6  $��135,45,0,150q�6,   $	��Top=�6B   $
��Left=�6Z     txtblck#��[ 6u   $
��Wrap=�6�   $
��Bold"�6�   $��Segoe ui)�6�   
������ 
�������$��15(�65  $	��110��6C  ��6�   �� *	MovieName+6C  �� 5{   "   $��135,105,0,0q�6,   
������ 
�������$��Segoe ui)�6�   ��6r   �� *	MovieDate+6�   �� 5|   "   $��135,125,0,0q�6,   
������ 
�������$��Segoe ui)�6�   ��6r   �� *MovieFormat+6�   �� 5}   "   $��135,145,0,0q�6,   
������ 
������$��Segoe ui)�6�   $��DemiBold"�6�   ��6u   �� *MovieLanguages+6�   �� 5~   "   $��135,165,0,0q�6,   
������ 
������$��DemiBold"�6�   $��Segoe ui)�6�   ��6u   �� *Age+6�   �� 5   "     
buyButton2#��[ 6)   
�������$��90��6`   $��30��6k   $��
Edit Movie��6w   $��15(�6�   $
��Bold"�6�   $
��Left=�6�   $��	5,240,0,0q�6�   ��6�   �� *DataContext.EditMovieCommand+$ listbox����6   �� $ myGrid��5�   #   5�      5�      5�      5�      5�      5�      5�      