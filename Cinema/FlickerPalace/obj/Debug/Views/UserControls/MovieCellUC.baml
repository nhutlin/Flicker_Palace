   M S B A M L   `   `   `  ����H  DFlickerPalace, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:FlickerPalace.Views.UserControls FlickerPalace.Views.UserControls  5      2    ,FlickerPalace.Views.UserControls.MovieCellUC   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @local.clr-namespace:FlickerPalace.Views.UserControls     5      .��5	      � -   5          �Name$  myGrid��5	      .+�5
   
   �� 
������  �� RadiusX$ 20��6'    �� RadiusY$ 20��64   6C   �� 5   
   .+�5      �� -   5         ��Name$ image��5       �� Left$ 20��6F   
 �� Top$ 20��6W   $	��250��5      $	��350��6    ��5   #   �� *Movie.ImagePath+5      �� 5      -   5         ��Name$
 name��5      $	��200��6&   $
��Wrap=�62   $��23(�6F   $��	ExtraBold"�6T   
���   � �� Bottom$ 25��5   +   $	 285��5      $
��Left=�6v   $ 25��6�   $	��Top=�6�   ��6%   �� *Movie.MovieName+ �� Mode$ TwoWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=�6�   �� 5      $
��Wrap=�6   $��15(�6,   $��
ExtraBlack"�6:   $��20��6R   
���   �$��Comic Sans MS)�5   /   $ 39��6J   $	 373��6[   $
��Left=�6l   $	��Top=�6�   Imdb :5   &   �� 5      $
��Wrap=�6   $��15(�6,   $��
ExtraBlack"�6:   
���   �$��Comic Sans MS)�5   /   $ 39��6J   $	 408��6[   $
��Left=�6l   $��Center=�6�   	About :5   '   �� 5      -   5        $ rating��5      $��50��6(   $
��Wrap=�64   $��18(�6H   $��
ExtraBlack"�6V   
���   �$��Comic Sans MS)�5   /   
 �� Right$
 20��6J   $	 369��6\   $	 120��5   i   $
��Left=�6{   $	��Top=�6�   ��6   �� *Movie.Rating+$ TwoWay=�$	 PropertyChanged=�6�   �� 5      -   5        $ about��5      $	��200��6'   $
��Wrap=�63   $��15(�6G   $��DemiBold"�6U   
���   �$��Comic Sans MS)�5   /   $
 20��6J   $	 408��6\   $	 120��5    h   $
��Left=�6z   $��Center=�6�   ��6   �� *Movie.About+$ TwoWay=�$	 PropertyChanged=�6�   �� 5!      
��� � �$	��100��6�   $��40��6�   $��20(�6�   $
��Bold"�6�      	buyButton#��[  6�   $	��Add��6�   $��Center=�6�   $	 300��6  $	��Top=�6  $	 100��61  ��6   �� *AddMovieClickCommand+��6>   ��  �� ElementName$ myGrid��6D  5#      5&      5'      