   M S B A M L   `   `   `  ����D  @bm2019gui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:bm2019gui	bm2019gui  5   	       bm2019gui.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:bm2019gui     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� $��Táv:��6   $
��Left=�6   $��32��6:   $��	40,30,0,0q�6F   $	��Top=�6Y   $	��108��6q   �� 5   
   $��Idő (ó:p:mp):��6   $
��Left=�6(   $��32��6C   $��	40,97,0,0q�6O   $	��Top=�6b   $	��108��6z   �� 5   
   $��Átlagsebesség (km/h):��6   $
��Left=�60   $��32��6K   $��
40,164,0,0q�6W   $	��Top=�6k   $	��130��6�   �� 5   
   $��Átlagsebesség (m/s):��6   $
��Left=�6/   $��32��6J   $��
40,231,0,0q�6V   $	��Top=�6j   $	��130��6�   �� 5   
   -   5        $��cbTav��5      $
��Left=�6    $��32��6;   $��
240,30,0,0q�6G   $	��Top=�6[   $	��133��6s   .@�5      �� $��Mini - 16km��6   �� 5      $��Rövid - 38km��6   �� 5      $��Pedelec - 54km��6   �� 5      $��Közép - 57km��6    �� 
IsSelected$
 True��62   �� 5      $��Hosszú - 94km��6   5      �� 5   
   -   5        $��tbIdo��5      $
��Left=�6   $��32��6:   $��
240,97,0,0q�6F    �� TextWrapping$
 Wrap=�6Z   $��1:00:00��6n   $	��Top=�6}   $	��225��6�   �� 5   
   -   5        $��tbAtlagkmph��5      $
��Left=�6'   $��34��6B   $��240,162,0,0q�6N   $
��Wrap=�6c   $�� ��6w   $	��Top=�6   $	��225��6�   �� 5   
   -   5        $��
tbAtlagmps��5      $
��Left=�6&   $��34��6A   $��240,234,0,0q�6M   $
��Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��225��6�   �� 5   
   -   5        $��	btnSzamol��5      $��Számol��6"   $
��Left=�63   $	��184��6N   $��
568,63,0,0q�6[   $	��Top=�6o   $	��178��6�   6�   5      5      