   M S B A M L   `   `   `  ����H  DFlickerPalace, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:FlickerPalace.Views.UserControls FlickerPalace.Views.UserControls  5      -    'FlickerPalace.Views.UserControls.EditUC   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @local.clr-namespace:FlickerPalace.Views.UserControls     5      _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  6K   -   5        $��myUserControl��5   z   $	��650��67   $	��900��6D   $	��Top=�6P   $��0,50,0,0q�6h   .��5	      � -   5        $��myGrid��5	   '   
�����w�  � RowDefinitions  5
   
   �� 5      $��* �6   �� 5      $��5* �6   .+�5   
   �� .+�5      �� -   5         ��Name$ 
mainButton��5         mainButtons#��[  6N   $��	50,20,0,0q�6s   $
��Left=�6�   $	��130��6�   $��45��6�   $
��Main��6�   $��20(�6�   $
��Bold"�6�   
����������#2c2c2e��6)   �� *MainClickCommand+5      �� 5      #��[  6:   $��Center=�6_   $
��Left=�6z   $	��130��6�   $��45��6�   $
��Plot��6�   $��20(�6�   $
��Bold"�6�   ���#2c2c2e �� Left$	 210��6�   
 �� Top$ 20��6  
���������6   �� *PlotClickCommand+6  �� 5      #��[  6<   $��Poster��6a   $��Center=�6r   $
��Left=�6�   $	��130��6�   $��45��6�   $	 370��6�   $ 20��6�   $��20(�6�   $
��Bold"�6�   ���#2c2c2e
���������6   �� *PosterClickCommand+6  �� 5      #��[  6;   $��Seats��6`   $��Center=�6q   $
��Left=�6�   $	��130��6�   $��45��6�   $	 530��6�   $ 20��6�   $��20(�6�   $
��Bold"�6�   ���#2c2c2e
���������6   �� *SeatsClickCommand+6  �� 5        
allButtons#��[ 6:   
������ $	 835��6w   $ -7��6�   ��6   �� *CloseEditCommand+.��5      �� $��/Icons/closered.png��6   67   5      5      �� 5   
   -   5         ��Name$ myCanvas��5      $��1��6#   y�60   �� *MainVisibility+.+�5      �� $ 7��6   $ 50��6#   
�������$��Title��6G   $��16(�6W   $��Center=�6e   $	��Top=�6�   6�   �� 5      $��15(�6-   $��DemiBold"�6;   $	��170��6Q   $��25��6]   $ 50��6i   $ 50��6z   $��Center=�6�   $	��Top=�6�   ��6   �� *Title+6�   �� 5      $ 82��6   $ 50��6$   
�������$
��Year��6H   $��16(�6W   $��Center=�6e   $	��Top=�6�   6�   �� 5      $��15(�6-   $��DemiBold"�6;   $	��170��6Q   $��25��6]   $ 50��6i   $	 125��6z   ��6   �� *Year+6�   �� 5      $	 153��6   $ 50��6%   
�������$��Genre��6I   $��16(�6Y   $��Center=�6g   $	��Top=�6�   6�   �� 5      $��15(�6.   $��DemiBold"�6<   $	��170��6R   $��25��6^   $ 50��6j   $	 191��6{   $��Center=�6�   $	��Top=�6�   ��6   �� *Genre+6�   �� 5      $	 222��6   $ 50��6%   
�������$��Director��6I   $��16(�6\   $��Center=�6j   $	��Top=�6�   6�   �� 5       $��15(�61   $��DemiBold"�6?   $	��170��6U   $��25��6a   $ 50��6m   $	 265��6~   $��Center=�6�   $	��Top=�6�   ��6   �� *
Director+6�   �� 5!      $	 294��6   $ 50��6%   
�������$��Actors��6I   $��16(�6Z   $��Center=�6h   $	��Top=�6�   6�   �� 5"      $	��170��6-   $��15(�6:   $��DemiBold"�6H   $��25��6^   $ 50��6j   $	 340��6{   $��Center=�6�   $	��Top=�6�   ��6   �� *Actor+6�   �� 5#      $	 369��6   $ 50��6%   
�������$��	Age Limit��6I   $��16(�6]   $��Center=�6k   $	��Top=�6�   6�   �� 5$      $	��170��60   $��15(�6=   $��DemiBold"�6K   $��25��6a   $ 50��6m   $	 415��6~   $��Center=�6�   $	��Top=�6�   ��6   �� *
AgeLimit+6�   �� 5%      $ 7��6   $	 350��6#   
�������$��Country��6H   $��16(�6Z   6j   �� 5&      $	��170��6/   $��15(�6<   $��DemiBold"�6J   $��25��6`   $	 350��6l   $ 50��6~   ��6   �� *	Country+6�   �� 5'      $ 82��6   $	 350��6$   
�������$��Language��6I   $��16(�6\   6l   �� 5(      $	��170��60   $��15(�6=   $��DemiBold"�6K   $��25��6a   $	 350��6m   $	 125��6   ��6   �� *
Language+6�   �� 5)      $	 153��6   $	 350��6%   
�������$��Duration��6J   $��16(�6]   6m   �� 5*      $	��170��60   $��25��6<   $��15(�6I   $��DemiBold"�6W   $	 350��6m   $	 191��6   ��6   �� *
Duration+6�   �� 5+      $	 222��6   $	 350��6%   
�������$��IMDB Rating��6J   $��16(�6`   6p   �� 5,      $	��170��6.   $��25��6:   $��15(�6G   $��DemiBold"�6U   $	 350��6k   $	 265��6}   ��6   �� *Rating+6�   �� 5-      $	 294��6   $	 350��6%   
�������$��Default Price��6J   $��16(�6b   6r   �� 5.      $	��170��6-   $��25��69   $��15(�6F   $��DemiBold"�6T   $	 350��6j   $	 340��6|   $��Center=�6�   $	��Top=�6�   ��6   �� *Price+6�   �� 5/      $	 369��6   $	 350��6%   
�������$��	Condition��6J   $��16(�6^   $��Center=�6l   $	��Top=�6�   6�   �� 50      $	��170��61   $��15(�6>   $��DemiBold"�6L   $��25��6b   $	 350��6n   $	 415��6�   $��Center=�6�   $	��Top=�6�   ��6   �� *	Condition+6�   �� 51      #��[ 6   
������ $��0q�6R   $	��280��6f   $	��400��6r   $ 45��6   $	 570��6�   .��52      �� $
��Fill=�6   ��6'   �� *	ImagePath+6G   53      �� 54      $	 570��6m   $	��130��6   $��40��6�     	buyButton#��[ 6�   $��Reset Changes��6�   $
��Bold"�6�   $��17(�6�   
�������$	 480��6  ��6   �� *ResetChangesCommand+��6=   ��  �� ElementName$ myGrid��6  �� 55      $	 718��6<   $	��130��6N   $��40��6Z   #��[ 6f   $��Save Changes��6�   $
��Bold"�6�   $��17(�6�   
��� � �$	 480��6�   $
��Left=�6�   $��Center=�6�   ��6   �� *SaveChangesCommand+6  �� 56      $ 50��6n   $	��130��6   $��40��6�   #��[ 6�   $��Delete Movie��6�   $
��Bold"�6�   $��17(�6�   
���  ��$	 483��6  $��Center=�6  $	��Top=�60  ��6   �� *DeleteMovieCommand+��6<   �� $ myCanvas��6J  57      �� 58   
   $��1��6   y�6   �� *PlotVisibility+.+�59      �� $��20(�6   $
��Bold"�6$   $ 70��66   $ 50��6F   $	��800��6W    �� TextWrapping$
 Wrap=�6c   $	��208��6w   
�������$��Center=�6�   $	��Top=�6�   ��6�   �� *
MovieAbout+6�   �� 5:      $��20(�6   $
��Bold"�6$   $	 356��66   $ 48��6G   $	��800��6X   $
 Wrap=�6d   $��50��6x   
�������$
��Left=�6�   $	��Top=�6�   ��6�   �� *	Trailer+6�   �� 5;      $	 570��6j   $	��130��6|   $��40��6�   #��[ 6�   $��Reset Changes��6�   $
��Bold"�6�   $��17(�6�   
�������$	 480��6  ��6   �� *ResetPlotCommand+��6:   �� $ myGrid��6  �� 5<      $	 718��6<   $	��130��6N   $��40��6Z   #��[ 6f   $��Save Changes��6�   $
��Bold"�6�   $��17(�6�   
��� � �$	 480��6�   $
��Left=�6�   $��Center=�6�   ��6   �� *SaveChangesCommand+6  �� 5=      $ 50��6n   $	��130��6   $��40��6�   #��[ 6�   $��Delete Movie��6�   $
��Bold"�6�   $��17(�6�   
���  ��$	 483��6  $��Center=�6  $	��Top=�60  ��6   �� *DeleteMovieCommand+��6<   �� $ myCanvas��6J  5>      �� 5?   
   $��1��6   y�6   �� *PosterVisibility+.+�5@      �� #��[ 6    J� 	AllowDrop . 
������ $��0q�6c   $	��280��6w   $	��400��6�   $ 50��6�   $ 50��6�   .��5A      �� ��6   �� *	ImagePath+67   5B      �� 5C      #��[ 6;   $	 380��6_   $ 50��6q   
�������$	��500��6�   $	��400��6�   ��6   �� *ImageClickCommand+.��5D      �� $��80��6   $��/Icons/cloud.png��6#   6@   5E      �� 5F      #��[ 6;   
������ $��0q�6x   $	 520��6�   $	 300��6�   ��6   �� *ImageClickCommand+.��5G      �� $��40��6   
���   �$
��Bold"�6<   $��25(�6N   $��Upload your image��6\   6w   5H      �� 5I      $	 570��6l   $	��130��6~   $��40��6�   #��[ 6�   $��Reset Changes��6�   $
��Bold"�6�   $��17(�6�   
�������$	 480��6  ��6   �� *ResetPosterCommand+��6<   �� $ myGrid��6  �� 5J      $	 718��6<   $	��130��6N   $��40��6Z   #��[ 6f   $��Save Changes��6�   $
��Bold"�6�   $��17(�6�   
��� � �$	 480��6�   $
��Left=�6�   $��Center=�6�   ��6   �� *SaveChangesCommand+6  �� 5K      $ 50��6n   $	��130��6   $��40��6�   #��[ 6�   $��Delete Movie��6�   $
��Bold"�6�   $��17(�6�   
���  ��$	 483��6  $��Center=�6  $	��Top=�60  ��6   �� *DeleteMovieCommand+��6<   �� $ myCanvas��6J  5L      �� 5M   
   -   5        $
 seat��5M      $��1��6   y�6,   �� *SeatsVisibility+.+�5N      �� -   5        $��	comboBox1��5N   K   
���   �$��30��6�   $	��190��6�   $	��Top=�6�   $��Center=�6�   $ 60��6�   $ 66��6�   $��14(�6�   $
��Bold"�6  ��6   �� *
Theaters+y�6\   �� *IsComboBoxVisible+*  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5O      +  %Microsoft.Xaml.Behaviors.EventTrigger  5P      	   	EventName$	 SelectionChanged��6%   *  $Microsoft.Xaml.Behaviors.TriggerBase
   Actions.
 5Q      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     Command 60   �� *SelectedTheaterCommand+   CommandParameter 5R   ,   �� $ 	comboBox1�� �� Path$ SelectedItem�6s   5S      5U      �� 5V      -   5        $��	comboBox2��5V   H   
���   �$��30��6�   $	��190��6�   $��Center=�6�   $
��Left=�6�   $	 325��6�   $ 66��6�   $��14(�6�   $
��Bold"�6   ��6   �� *Dates+y�6Y   �� *IsComboBoxVisible+ 5W        5X      $	 SelectionChanged��6%   .
 5Y         60   �� *SelectedTheaterCommand+ 5Z   ,   �� $ 	comboBox2��$ SelectedItem�6s   5[      5]      �� 5^      -   5        $��	comboBox3��5^   L   
���   �$��30��6�   $	��190��6�   $��Center=�6�   $
��Left=�6�   $	 593��6�   $ 66��6�   $��14(�6�   $
��Bold"�6  ��6   �� *	DateTimes+y�6]   �� *IsComboBoxVisible+ 5_        5`      $	 SelectionChanged��6%   .
 5a         60   �� *SelectedTheaterCommand+ 5b   ,   �� $ 	comboBox3��$ SelectedItem�6s   5c      5e      �� 5f      -	   5        $��
myComboBox��5f   a   $��15(�6   $
��Bold"�6%   $	 232��67   $	��369��6I   $��30��6U   $
��Left=�6�   $��Center=�6�   ��6s   �� *AllMoviesSchedule+��5g      �� 5h      .R�5i      ��  �� Orientation$ 
Horizontal=�6%   .+�5j      �� $��0,0,5,0q�6A   ��6(   �� *	Theater+6A   �� 5k      $��0,0,5,0q�6C   ��6(   �� *	MovieDate+6C   �� 5l      ��6(   �� *MovieDateTime+5m      5n       5p        5q      $	 SelectionChanged��6%   .
 5r         60   �� *MovieSeatsCommand+ 5s   ,   �� $ 
myComboBox��$ SelectedItem�6t   5t      5v      �� 5w      $	 570��6o   $	��130��6�   $��40��6�   #��[ 6�   $��Reset Changes��6�   $
��Bold"�6�   $��17(�6�   
�������$	 480��6
  ��6   �� *ResetSeatsCommand+��6;   �� $ 
myComboBox��6  �� 5x      $	 718��6i   $	��130��6{   $��40��6�   #��[ 6�   $��Save Changes��6�   $
��Bold"�6�   $��17(�6�   
��� � �$	 480��6   $
��Left=�6  $��Center=�6,  ��6   �� *SaveSeatsCommand+��6;   �� $
 seat��6I  �� 5y      $ 50��6n   $	��130��6   $��40��6�   #��[ 6�   $��Delete Movie��6�   $
��Bold"�6�   $��17(�6�   
���  ��$	 483��6  $��Center=�6  $	��Top=�60  ��6   �� *DeleteMovieCommand+��6<   �� $ myCanvas��6J  5z      5{      5|      