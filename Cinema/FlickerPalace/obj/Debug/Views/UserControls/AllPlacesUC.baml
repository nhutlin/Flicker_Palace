   M S B A M L   `   `   `  ����H  DFlickerPalace, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:FlickerPalace.Views.UserControls FlickerPalace.Views.UserControls  5      2    ,FlickerPalace.Views.UserControls.AllPlacesUC   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @local.clr-namespace:FlickerPalace.Views.UserControls     5      _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  6K   .��5	      � 
���   �.+�5
   
   �� .+�5      �� $
��Fill=�6   $
��1400��6#   $��/images/movieback.jpg��60   6Q   5      �� 5   
   $	��100��61   $��30��6=   $��Bottom=�6I   $��Right=�6d   
��� ���$
��Back��6�   $��20(�6�   $��
0,0,206,10q�6�   $
��Bold"�6�      
allButtons#��[  6�   ��6   �� *BackCommand+6�   �� 5   
   $	��175��67   $��30��6C   $��Bottom=�6O   $��Right=�6j   
�������
���  ��$��Back To User Side��6�   $��20(�6�   $
��Bold"�6�   #��[  6�   $��0,0,8,10q�6  ��6   �� *BackToUserCommand+6"  �� 5   
   $��70��6   $	��Top=�6    $��Center=�68   $��
ALL PLACES��6U   
�������$
��Bold"�6z   $��50(�6�   6�   �� 5   
   -   5        $��nameComboBox��5   K   $��15(�6   $
��Bold"�6!   $	��200��63   $��40��6?     �� DisplayMemberPath$  	MovieName��6�   $��92,34,508,376q�6�   ��6_   �� *AllMoviesSchedule+*  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5      +  %Microsoft.Xaml.Behaviors.EventTrigger  5         	EventName$ SelectionChanged��6!   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     Command 6,   �� *MovieSeatsCommand+   CommandParameter 5   ,   ��  �� ElementName$ nameComboBox�� �� Path$ SelectedItem�6v   5      5      �� 5   
   -   5        $��dateComboBox��5   K   $��15(�6   $
��Bold"�6!   $	��300��63   $��40��6?   $��450,33,0,377q�6�   ��6_   �� *
DateMovies+��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� $��0,0,5,0q�6=   ��6$   �� *	Theater+6=   �� 5      $��0,0,5,0q�6?   ��6$   �� *	MovieDate+6?   �� 5      ��6$   �� *MovieDateTime+5       5!       5#        5$      $ SelectionChanged��6!   . 5%         6,   �� *DateSeatsCommand+ 5&   ,   �� $ dateComboBox��$ SelectedItem�6v   5'      5)      5*      5+      