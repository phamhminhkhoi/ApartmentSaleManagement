   M S B A M L   `   `   `  ����  PresentationLayerWPF%    PresentationLayerWPF.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  Login��5   	   $	��450��6   $	��800��6$    � WindowStartupLocation$ CenterScreen=�60    � AllowsTransparency$ False��6U    � WindowStyle$
 None=�6p   ��5      �� 5	   
    �� ImageSource$Q Khttps://wallpaper.forfun.com/fetch/18/1868ad33a9737d197733a7102b886dc5.jpeg��6    �� Opacity$	 0.8Q�6o    �� RelativeTransform 5
      V� 5      .~�5      ��  �� ScaleX$	 1.5Q�6%    �� ScaleY$	 1.5Q�62   T� 5      	 T� X$
	 -0.2Q�6)   
 T� Y$

 -0.2Q�62   5      5      .��5      � .+�5   
   �� ���#FFFFFF �� CornerRadius$ 20��6&    �� Padding$ 30q�68   $��Center=�6E   $��Center=�6b   $	��350��6}    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 30Q�6#      ShadowDepth$ 0Q�63      Color$ #000000��6C      Opacity$	 0.3Q�6S   ._�5      �� .+�5      �� -   5        $	��✕��5      $��25��6%   $��25��60   $��0q�6<   
������ ���#757575$��Right=�5      $��14(�65   6C   �� 5      $��Welcome Back��6   $��28(�60   $
��Bold"�6>   
���   �$��Center=�6c   $��0,0,0,20q�6�    5         5!      $ 4Q�6+   $ 2Q�6:   $ #000000��6J   $	 0.6Q�6Z   5#      �� 5&      $��Email��6   ���#333333$��0,0,0,5q�6>   �� 5'      ���#f0f0f0���#cccccc$��1q�6D   $ 8��6X   ._�5(      �� -   5         ��Name$ EmailTextBox��5(      $��35��64   $��10q�6@   
������  � ToolTip$ Enter your email��5)      
���   �69   5*      �� 5+      $��Password��6   ���#3333336,   �� 5.      ���#f0f0f0���#cccccc$��1q�6D   $ 8��6X   ._�5/      G� -   5         G�Name$ PasswordBox��5/   "   $��35��67   $��10q�6C   
������ $ Enter your password��50   "   
���   �6@   51      �� 54      -   5         ��Name$ LoginButton��54      $��Login��6.   
�������$
��Bold"�6k   $��40��6}   $��	0,20,0,10q�55      
���   �$��0q�6@   $��Center=�56      $	��150��66   ���#000000 57        58      $ 10Q�6+   $ 5Q�6;   $ #000000��6K   $	 0.5Q�6[   5:      �� 5=      -   5        $ RegisterButton��5=      $��Register��61   
���   �$
��Bold"�6t   $��35��6�   $��0,5,0,5q�5>      ���#cccccc$��1q�6@   $��Center=�5?      $	��150��66   ���#f0f0f05@      �� 5C      -   5        $ 
QuitButton��5C      $
��Quit��6-   
���   �$
��Bold"�6h   $��35��6z   $��0,5,0,0q�5D      ���#cccccc$��1q�6@   $��Center=�5E      $	��150��66   ���#f0f0f05F      �� 5I      -   5         ��Name$ ErrorMessage��5I      
���  ��$y�	Collapsed=�6C   $ ��Invalid email or password.��6Z   $��Center=�5J      $��0,10,0,0q�69    J� Opacity$ 0Q�6K   5K      5L      5M      5N      