   M S B A M L   `   `   `  ����G  CMovieReccApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:MovieReccAppMovieReccApp  5   	       MovieReccApp.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:MovieReccApp     5   	     � Title$  Movie Reccomendations��5   	   $	��450��6'   $	��800��64   .��5	      � ���	#FFF1B82D.+�5
   
   �� -   5         ��Name$ ReccomendationList��5
      $��288,46,288,104q�6Y   
�������6�   �� 5   
   -   5         ��Name$ 	ReccLabel��5      $��Reccomendations:��6#   $��Center=�6>   $��0,20,0,0q�6[   $	��Top=�6m   $	��224��6�   $��32��6�   $
��Bold"�6�   $��16(�6�   �� 5   
   -   5        $ 
GenreLabel��5      $��Genres:��6$   $
��Left=�66   $��	22,20,0,0q�6Q   $	��Top=�6d   $
��Bold"�6|   $��16(�6�   �� 5   
   -   5         ��Name$ Action��5      $��Action��6#   $
��Left=�64   $��	22,51,0,0q�6O   $	��Top=�6b   �� 5   
   -   5        $ 	Adventure��5      $��	Adventure��6&   $
��Left=�6:   $��	22,71,0,0q�6U   $	��Top=�6h   �� 5   
   -   5        $ 	Animation��5      $��	Animation��6&   $
��Left=�6:   $��	22,91,0,0q�6U   $	��Top=�6h   �� 5   
   -   5        $ Comedy��5      $��Comedy��6#   $
��Left=�64   $��
22,111,0,0q�6O   $	��Top=�6c   �� 5   
   -   5        $ Crime��5      $��Crime��6"   $
��Left=�62   $��
165,51,0,0q�6M   $	��Top=�6a   �� 5   
   -	   5        $ Documentary��5      $��Documentary��6(   $
��Left=�6>   $��
165,71,0,0q�6Y   $	��Top=�6m   �� 5   
   -
   5        $ Drama��5      $��Drama��6"   $
��Left=�62   $��
165,91,0,0q�6M   $	��Top=�6a   �� 5   
   -   5        $ Family��5      $��Family��6#   $
��Left=�64   $��165,111,0,0q�6O   $	��Top=�6d   �� 5   
   -   5         ��Name$ SearchButton��5      $��Search��6'   $
��Left=�68   $��
22,294,0,0q�6S   $	��Top=�6g   $	��101��6   ���	#FFF1B82D6�   �� 5   
   -   5        $ Fantasy��5      $��Fantasy��6$   $
��Left=�66   $��
22,133,0,0q�6Q   $	��Top=�6e   �� 5   
   -   5        $ History��5      $��History��6$   $
��Left=�66   $��
22,153,0,0q�6Q   $	��Top=�6e   �� 5   
   -   5        $ Horror��5      $��Horror��6#   $
��Left=�64   $��
22,173,0,0q�6O   $	��Top=�6c   �� 5   
   -   5        $ Music��5      $��Music��6"   $
��Left=�62   $��
22,193,0,0q�6M   $	��Top=�6a   �� 5   
   -   5        $ Mystery��5      $��Mystery��6$   $
��Left=�66   $��165,133,0,0q�6Q   $	��Top=�6f   �� 5   
   -   5        $ Romance��5      $��Romance��6$   $
��Left=�66   $��165,153,0,0q�6Q   $	��Top=�6f   �� 5   
   -   5        $ ScienceFiction��5      $��ScienceFiction��6+   $
��Left=�6D   $��165,173,0,0q�6_   $	��Top=�6t   �� 5   
   -   5        $ TVMovie��5      $��TVMovie��6$   $
��Left=�66   $��165,193,0,0q�6Q   $	��Top=�6f   �� 5   
   -   5        $ Thriller��5      $��Thriller��6%   $
��Left=�68   $��
22,213,0,0q�6S   $	��Top=�6g   �� 5   
   -   5        $	 War��5      $	��War��6    $
��Left=�6.   $��165,213,0,0q�6I   $	��Top=�6^   �� 5    
   -   5        $ Western��5       $��Western��6$   $
��Left=�66   $��
22,233,0,0q�6Q   $	��Top=�6e   �� 5!   
   -   5        $	 url��5!      $��Label��6   $��Center=�6-   $��	0,377,0,0q�6J   $	��Top=�6]   $	��780��6u   $��8(�6�   �� 5"   
   -   5        $ MovieDescLabel��5"      $��Movie Description��6(   $
��Left=�6D   $��
527,20,0,0q�6_   $	��Top=�6s   $	��224��6�   $��32��6�   $
��Bold"�6�   $��16(�6�   �� 5#   
   -   5         ��Name$ MovieDescription��5#      $
��Left=�6,   $��
534,46,0,0q�6G    �� TextWrapping$
 Wrap=�6[   $��TextBox��6o   $	��Top=�6~   $	��174��6�   $	��284��6�   5$      5%      