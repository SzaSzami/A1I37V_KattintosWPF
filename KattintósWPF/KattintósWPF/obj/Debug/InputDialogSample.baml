   M S B A M L   `   `   `  ����  KattintósWPF%    KattintósWPF.InputDialogSample   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$  Input��5   	    � SizeToContent$ WidthAndHeight=�6    � WindowStartupLocation$ CenterScreen=�66   .��5      � $��15q�6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5	      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $*��$pack://application:,,,/Files/kep.png��6   $��40��6>   $��40��6J   $��2��6U   $��	25,9,32,3q�6f   �� 5   
   -   5        $��lblQuestion��5      $��1��6#   .��63   Kérlek add meg a neved!6L   �� 5   
   -   5        $��	txtAnswer��5      $��1��6#   $��1��63   $	��250��6@   .��6O   Játékosnév:6\   � 5   
   $��2��6   $��2��6!   $��Right=�65   $��0,15,0,0q�6Q   .+�5      �� -   5        $��btnDialogOk��5   &    �� 	IsDefault . $��60��6S   $��0,0,10,0q�6a   .��6s   _Ok6x   �� 5       �� IsCancel . $��60��6%   .��64   	_Cancel6=   5      5      5      