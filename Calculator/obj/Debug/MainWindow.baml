   M S B A M L   `   `   `  ����E  ACalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Calculator
Calculator  5   	       Calculator.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Calculator     5   	     � 
ResizeMode$  CanMinimize=�5   	    � Title$ Калькулятор��5	   	   $	��512��6   $	��386��6*   $��24(�66   $��Calibri)�6D   .��5
      � $
��Left=�6   $	��512��6&   $��0,-27,-86,-2q�63   $	��Top=�6I   $	��386��6a   ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FF787878��6   � 5      $ 	#FFBE77E0��6    � Offset$ 1Q�61   � 5      $ 	#FFD1DE7C��6   $ 0.477Q�61   5      .+�5   
   �� -   5         ��Name$ b0��5      $��0��6   $
��Left=�6)   $��50��6D   $��
90,430,0,0q�6P   $	��Top=�6d   $��50��6|   $��24(�6�   $��1q�6�   �� 5   
   -   5        $ b1��5      $��1��6   $
��Left=�6)   $��50��6D   $��
20,360,0,0q�6P   $	��Top=�6d   $��50��6|   $��24(�6�   6�   �� 5   
   -   5        $ b2��5      $��2��6   $
��Left=�6)   $��50��6D   $��
90,360,0,0q�6P   $	��Top=�6d   $��50��6|   $��24(�6�   6�   �� 5   
   -   5        $ b3��5      $��3��6   $
��Left=�6)   $��50��6D   $��160,360,0,0q�6P   $	��Top=�6e   $��50��6}   $��24(�6�   6�   �� 5   
   -   5        $ b4��5      $��4��6   $
��Left=�6)   $��50��6D   $��
20,290,0,0q�6P   $	��Top=�6d   $��50��6|   $��24(�6�   6�   �� 5   
   -   5        $ b5��5      $��5��6   $
��Left=�6)   $��50��6D   $��
90,290,0,0q�6P   $	��Top=�6d   $��50��6|   $��24(�6�   6�   �� 5   
   -   5        $ b6��5      $��6��6   $
��Left=�6)   $��50��6D   $��160,290,0,0q�6P   $	��Top=�6e   $��50��6}   $��24(�6�   6�   �� 5   
   -   5        $ b7��5      $��7��6   $
��Left=�6)   $��50��6D   $��
20,220,0,0q�6P   $	��Top=�6d   $��50��6|   $��24(�6�   6�   �� 5   
   -	   5        $ b8��5      $��8��6   $
��Left=�6)   $��50��6D   $��
90,220,0,0q�6P   $	��Top=�6d   $��50��6|   $��24(�6�   6�   �� 5   
   -
   5        $ b9��5      $��9��6   $
��Left=�6)   $��50��6D   $��160,220,0,0q�6P   $	��Top=�6e   $��50��6}   $��24(�6�   6�   �� 5   
   -   5        $ b_sign��5      $	��+/-��6!   $
��Left=�6/   $��50��6J   $��
20,430,0,0q�6V   $	��Top=�6j   $��50��6�   $��24(�6�   ���	#FFEC81CA6�   �� 5   
   -   5        $ b_comma��5      $��,��6"   $
��Left=�6.   $��50��6I   $��160,430,0,0q�6U   $	��Top=�6j   $��50��6�   $��24(�6�   ���	#FFF9F2606�   �� 5   
   -   5        $ b_equal��5      $��=��6"   $
��Left=�6.   $��50��6I   $��230,430,0,0q�6U   $	��Top=�6j   $��50��6�   $��24(�6�   ���	#FF7783FB6�   �� 5   
   -   5        $ b_plus��5      $��+��6!   $
��Left=�6-   $��50��6H   $��230,360,0,0q�6T   $	��Top=�6i   $��50��6�   $��24(�6�   ���	#FF7ADA646�   �� 5    
   -   5        $ b_minus��5       $��-��6"   $
��Left=�6.   $��50��6I   $��230,290,0,0q�6U   $	��Top=�6j   $��50��6�   $��24(�6�   ���	#FF7ADA646�   �� 5!   
   -   5        $ b_multi��5!      $��X��6"   $
��Left=�6.   $��50��6I   $��230,220,0,0q�6U   $	��Top=�6j   $��50��6�   $��24(�6�   ���	#FF7ADA646�   �� 5"   
   -   5        $ b_div��5"      $��/��6    $
��Left=�6,   $��50��6G   $��230,150,0,0q�6S   $	��Top=�6h   $��50��6�   $��24(�6�   ���	#FF7ADA646�   �� 5#   
   -   5        $ b_alldelete��5#      $��C��6&   $
��Left=�62   $��50��6M   $��
20,150,0,0q�6Y   $	��Top=�6m   $��50��6�   $��24(�6�   ���	#FFF5653A6�   �� 5$   
   -   5        $ b_linedelete��5$      $��CE��6'   $
��Left=�64   $��50��6O   $��
90,150,0,0q�6[   $	��Top=�6o   $��50��6�   $��24(�6�   ���	#FFF5653A6�   �� 5%   
   -   5        $ b_delete��5%      $	��Del��6#   $
��Left=�61   $��50��6L   $��160,150,0,0q�6X   $	��Top=�6m   $��50��6�   $��24(�6�   ���	#FFF5653A6�   o� 5&   
   $
��Left=�6   $��24��6*   $��0,28,0,0q�66   $	��Top=�6H   $	��386��6`   $��Calibri Light)�6l   $��14(�6�   .@�5'      m� -   5         m�Name$
 file��5'      $��Файл��6%   $��24��63   .@�5(      m� -   5        $
 exit��5(      $��
Выйти��6)   $��24��68   6D   5)      m� 5*      -   5        $ about��5*      $��О программе��6&   $��24��6;   6G   5+      �� 5,   
   -   5         ��Name$
 tbox��5,      $
��Left=�6    $��50��6;   $��	20,84,0,0q�6G   	 �� TextWrapping$
	 Wrap=�6Z   $��0��6n   $	��Top=�6w   $	��330��6�   
 �� 	UndoLimit$
 96��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   $��36(�6�   $ �� HorizontalScrollBarVisibility$
 Auto=�6�   $��0,0,0,0q�6�   $��4q�6   �� 	MaxLength$ 12��6#   �� MaxLines$ 1��62   �� TextAlignment$ Right=�6?  ���	#FFD4D4D46U  �� 5-   
   -   5        $
 pbox��5-      $
��Left=�6    $��25��6;   $��	20,59,0,0q�6G   $
	 Wrap=�6Z   $�� ��6n   $	��Top=�6v   $	��330��6�   $��20(�6�   $ Right=�6�   ��6�   Z� ��6�   Z� 6�   �� 5.   
   -   5        $
 b_ms��5.      $
��Left=�6   $��300,150,0,0q�6:   $	��Top=�6O   $��50��6g   $��50��6r   $��MS��6~   ���	#FFFFA0006�   �� 5/   
   -   5        $
 b_mr��5/      $��MR��6   $
��Left=�6,   $��300,220,0,0q�6G   $	��Top=�6\   $��50��6t   $��50��6   ���	#FFFFA0006�   �� 50   
   -   5        $
 b_mc��50      $��MC��6   $
��Left=�6,   $��300,290,0,0q�6G   $	��Top=�6\   $��50��6t   $��50��6   ���	#FFFFA0006�   �� 51   
   -   5        $ b_m_plus��51      $��M+��6#   $
��Left=�60   $��300,360,0,0q�6K   $	��Top=�6`   $��50��6x   $��50��6�   ���	#FFFFA0006�   �� 52   
   -   5        $ 	b_m_minus��52      $��M-��6$   $
��Left=�61   $��300,430,0,0q�6L   $	��Top=�6a   $��50��6y   $��50��6�   ���	#FFFFA2006�   54      56      