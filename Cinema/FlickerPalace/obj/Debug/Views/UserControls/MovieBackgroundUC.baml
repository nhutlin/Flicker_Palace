   M S B A M L   `   `   `  ����H  DFlickerPalace, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:FlickerPalace.Views.UserControls FlickerPalace.Views.UserControls  5      e aMicrosoft.Web.WebView2.Wpf, Version=1.0.1587.40, Culture=neutral, PublicKeyToken=2a8ab48044d2601ekLclr-namespace:Microsoft.Web.WebView2.Wpf;assembly=Microsoft.Web.WebView2.WpfMicrosoft.Web.WebView2.Wpf 5      8    2FlickerPalace.Views.UserControls.MovieBackgroundUC   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @local.clr-namespace:FlickerPalace.Views.UserControls     5      \wv2Lclr-namespace:Microsoft.Web.WebView2.Wpf;assembly=Microsoft.Web.WebView2.Wpf     5      _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a;	behaviors+http://schemas.microsoft.com/xaml/behaviors  6g   3i+http://schemas.microsoft.com/xaml/behaviors  6�   .��5
      � -   5        $��	movieGrid��5
      
���   �.+�5   
   ��    
logoButton#��[  6     K� ZIndex$  1��6�   $��0q�6�   $	��152��6�   $	��178��6�   $
��Left=�6�   $	��Top=�6�   $��	66,-4,0,0q�6�   ��65   �� *LogoClickCommand+��6Z   ��  �� ElementName$ 	movieGrid��.��5      �� $��Uniform=�6   $��/icons/logo.png��6&   $��89��6?   $	��121��6K   6Y   5      �� 5   
   .+�5      �� $
��Fill=�6   $
��1400��6#   $��/images/movieback.jpg��60   6Q   �� 5        
allButtons#��[ 6   $��30��6_   
 �� Top$ 20��6j    �� Left$
 1249��6z   $
��Left=�6�   $��Center=�6�   ��69   �� *AppleClickCommand+.��5      �� $��/icons/apple.png��6   64   5      �� 5      #��[ 6   $��30��6b   $ 20��6m   $
 1294��6}   $
��Left=�6�   $��Center=�6�   ��6:   �� *AndroidClickCommand+.��5      �� $��/icons/android.png��6   66   5      �� 5      $��100,260,0,0q�6   $��
ExtraBlack"�6-   $��40(�6E   
���������6f   �� *Movie.MovieName+6�   �� 5      $	��800��6   $
��Wrap=�6$   $��100,400,0,0q�68   $��DemiBold"�6M   $��20(�6c   
���������6�   �� *Movie.About+6�   �� 5      $��1047,500,0,0q�6   .+�5      �� 
���  ��$��-10,-170,0,0q�6-   $��25(�6C   $
��Bold"�6Q   Tickets booking6t   �� 5      
�������$��20(�6/   $	��190��6=   $��-100,-130,0,0q�6I   $��DemiBold"�6`   $
��Wrap=�6v   )'+994 12 598 74 14 119 ( charges apply )6�   �� 5      $	��300��6   $	��200��6$   $��/Icons/ticketBanner.png��61   $��-35,-200,0,0q�6R   6j   5      �� 5      $��1020,500,0,0q�6m     
buyButton2#��[ 6�   $	��200��6�   $��80��6�   $��25(�6�   $
��Bold"�6�   ��6   �� *BuyTicketCommand+��6:   �� $ 	movieGrid��.��6�   
Buy Ticket6�   �� 5      $	��200��6   $	��962��6%   $
 1020��62   $	 600��6E   .+�5      �� $
��Fill=�6   ��6(   �� *Movie.ImagePath+6M   �� 5       ���#818181.��6-   Rating65   �� 5!      $��5,0,0,0q�6   
���������6@   �� *Movie.Rating+6`   �� 5"      ���#818181.��6-   	Country66   �� 5#      $��5,0,0,0q�6   
���������6@   �� *Movie.MovieCountry+6f   �� 5$      ���#818181.��6-   Year63   �� 5%      $��5,0,0,0q�6   
���������6@   �� *Movie.MovieYear+6c   �� 5&      ���#818181.��6-   
Director67   �� 5'      $��5,0,0,0q�6   
���������6@   �� *Movie.MovieDirector+6g   �� 5(      ���#818181.��6-   Genre64   �� 5)      $��5,0,0,0q�6   
�������$
��Wrap=�6@   $	��100��6T   $
��Left=�6`   ��6{   �� *Movie.MovieGenre+6�   �� 5*      ���#818181.��6-   Actors65   �� 5+      $
��Left=�6   $
��Wrap=�67   $	��100��6K   $��5,0,0,0q�6W   
���������6{   �� *Movie.MovieActors+6�   �� 5,      ���#818181.��6-   
Duration67   �� 5-      $��5,0,0,0q�6   
���������6@   �� *Movie.MovieDuration+6g   �� 5.      ���#818181.��6-   	Age Limit68   �� 5/      $��5,0,0,0q�6   
���������6@   �� *	Movie.Age+6]   �� 50      ���#818181.��6-   Price64   �� 51      $��5,0,0,0q�6   
���������6@   �� *Movie.MoviePrice+6d   52      53      �� 54   
   $��60,600,0,573q�6   .+�55      )  #Microsoft.Web.WebView2.Wpf.WebView2  -   5        $��webview��55      $	��850��6*   $
��Left=�66   $	��523��6Q      Source 6^   �� *Movie.MovieLink+6�   56      �� 57   
   $
��Left=�6   
�������$��337,1170,0,484q�6>   $��
ExtraBlack"�6V   $��40(�6n    J� RenderTransformOrigin$ 0.541,0.506&�6|   .��6�   
See also6�   �� 58   
   -   5        $��listbox��58   �   
������ $
��Left=�6N   $	��850��6i   $	��300��6u   $��-4,1309,0,108q�6�   $��0q�6�   $��Disabled=�6�   ��6,   �� *	AllMovies+��59      �� 5:      .R�5;      �  � Orientation$ 
Horizontal=�6    6;   5<      ��5>      �� 5?       �� 
TargetType" ��6   .�5@      ��  �� Property � ��	 �� Value	 5A      �� 5B      
 �� 
TargetType"
 ��6.   .R�5C   "   �� $��Bd��5G      #��z��5C   )    �� Padding# z��5D      #��z��5E      #��z��5F       J� SnapsToDevicePixels . ._�5I   &   �� #��z��67   #��z��5J        �� ContentStringFormat �� ContentStringFormat# z 5K       #��z��5L       #��z��5M       # z 5N       5O   #    �� Triggers 5P   "   ]� 5Q   &    ]� 
Conditions 5R   *   �� 5S   .    �� Property �@��IsSelectionActive �� Value .  6^   �� 5T   .    �@��
IsSelected . 6W   ./�5V   *   ��  �� 
TargetName$ Bd��6M    � ��
	 ���� 6]   �� 5W   *   $ Bd��6O    � ��	 5X   .   ��5Y   2   Transparent��6O   5[   +   5\   '   ]� 5]   &    5^   *   �� 5_   .    �@��IsSelectionActive . 6^   �� 5`   .    �@��
IsSelected . 6W   ./�5b   *   �� $ Bd��6M    � ��
	 ���� 6]   �� 5c   *   $ Bd��6O    � ��	 5d   .   ��5e   2   Transparent��6O   5g   +   5h   '   P� 5i   &    P� Property �@J�IsMouseOver P� Value . . �5j   *   �� $ Bd��6M    � ��
	 ���� 6]   �� 5k   *   $ Bd��6O    � ��	 5l   .   ��5m   2   Transparent��6O   5o   +   5p   '   P� 5q   &    � {� .  . �5r   *   �� $ Bd��6S    � ��	 5s   .   C� 5t   2    C� ResourceKey# Z��6B   5v   +   5w   '   5y      5{      5|      *  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5~      +  %Microsoft.Xaml.Behaviors.EventTrigger  5         	EventName$ SelectionChanged��6!   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5�      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     Command 6,   �� *MovieNameClickCommand+   CommandParameter 5�   ,   �� $ 	movieGrid��6a   5�      ��5�      �� 5�      .R�5�      �� 
������ $��0q�67    �� CornerRadius$ 20��6K   $	��150��6]   $	��250��6i   ._�5�      � $��myGrid��62   $��0,35,0,0q�6   
������ .+�5�      �� $��image��6}    � Cursor$
 Hand��6$   $	��170��62   $	��115��6?   $
��Fill=�6L     imgStyle#��[ 6[   ��6�   �� *	ImagePath+6�   �� 5�      $��filmnametxtBox��6  $��
30,-35,0,0q�6(   $	��Top=�6<   $
��Left=�6T     txtblck#��[ 6o   $
��Wrap=�6�   $
��Bold"�6�   $��Segoe ui)�6�   
������ 
�������$��15(�6/  $	��110��6=  ��6�   �� *	MovieName+6=  5�      5�      5�      5�      �� 5�   
   $��
0,1600,0,0q�6   $	��100��6%   ���#2b3236.+�5�      �� $��	80,20,0,0q�6   
�������.��6=   © Park Cinema, 20236R   �� 5�      $��30��6   $��30��6    $��	82,50,0,0q�6+   $��/icons/visa.png��6>   6Y   �� 5�      $��30��6   $��30��6    $��
117,50,0,0q�6+   $��/icons/master.png��6?   6\   �� 5�      $	��250��6   $	��100��6    $��
1200,0,0,0q�6-   ���#6e6d6d.��5�      �� #��[ 6q   $	��150��6�   $��80��6�   ��6   �� *LogoClickCommand+��6>   �� $ 	movieGrid��.��5�      �� $��Uniform=�6   $��/icons/logogray.png��6/   6N   5�      5�      5�      5�      5�      