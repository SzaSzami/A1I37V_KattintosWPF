   M S B A M L   `   `   `  ����H  DKattintósWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:KattintósWPFKattintósWPF  5   	       KattintósWPF.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:KattintósWPF     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Kattintós Játék��5	   	   $	��600��6!   $	��450��6.    � 
ResizeMode$ CanMinimize=�6:   .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      ��5   
   �� 5       j� Stretch$
 Fill=�6    �� ImageSource$7 1pack://application:,,,/Files/background-Image.jpg��6(    j� 
AlignmentY$	 Top=�5       j� 
AlignmentX$ Center=�6"   .+�5   
   �� $��Kattintós játék WPF��6   $��24(�6.   $��2��6<   $��114,41,105,457q�6P   �� 5   
   -   5        $��Start��5   $   $��Új játék��6   $
��Left=�61   $��
37,188,0,0q�6L   $	��Top=�6`   $	��359��6x   $��50��6�   $��24(�6�   $��2��6�   6�   �� 5   
   -   5        $��Kilepes��5   #   $��	Kilépés��6   $
��Left=�62   $��
37,362,0,0q�6M   $	��Top=�6a   $	��359��6y   $��50��6�   $��24(�6�   $��2��6�   6�   �� 5   
   -   5         ��Name$ 
Jatekosnev��5   /   $��Játékosnév megadása��6   $
��Left=�6C   $��
37,273,0,0q�6^   $	��Top=�6r   $	��359��6�   $��50��6�   $��24(�6�   $��2��6�   6�   �� 5   
   $$��Jelenleg bejelentkezve, mint: ��6   $
��Left=�69   $��
37,532,0,0q�6T   $	��Top=�6h   $	��185��6�   �� 5   
   -   5        $��lblBejelentkezveMint��5      $�� ��6   $��1��67   $
��Left=�6G   $��
10,532,0,0q�6b   $	��Top=�6v   $	��134��6�   5      5      