   M S B A M L   `   `   `  ����  PresentationLayerWPF&     PresentationLayerWPF.AdminWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Admin Panel��5   	   $	��600��6   $
��1000��6*    � WindowStartupLocation$ CenterScreen=�5   	    � AllowsTransparency$ False��6.    � WindowStyle$
 None=�6I   ��5      �� 5   
    �� ImageSource$d ^https://as1.ftcdn.net/v2/jpg/05/69/62/50/1000_F_569625055_MHLKSN5l8QKDL8WDMxQ0EnuTHKqQLbUk.jpg��6    �� Opacity$ 1Q�6�    �� RelativeTransform 5      V� 5	      .~�5
      ��  �� ScaleX$	 1.5Q�6%    �� ScaleY$	 1.5Q�62   T� 5      	 T� X$
	 -0.2Q�6)   
 T� Y$

 -0.2Q�62   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      $��* �6   .+�5   
   �� ���#FFFFFF �� CornerRadius$ 20��6&    �� Padding$ 10q�68   $��
10,10,0,10q�6E   $
��Left=�6Y   $	��185��6t    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 30Q�6#      ShadowDepth$ 0Q�63      Color$ #000000��6C      Opacity$	 0.3Q�6S   ._�5      �� $��Stretch=�6   .+�5      �� $��Admin Panel��6   $��24(�6/   $
��Bold"�6=   
���   �$��10q�5      $��Center=�6     5        5       $ 4Q�6+   $ 2Q�6:   $ #000000��6J   $	 0.6Q�6Z   5"      �� 5%      -   5        $��Property��5%      $��10q�5&      $��16(�6   $
��Bold"�6,   
�������$	��140��5'   $   $��40��60   $��Center=�5(      $��10q�6.   ��5)      �� 5*       �� 
StartPoint$	 0,0&�6.    �� EndPoint$	 1,1&�6?   .��5+      �  � Color$ #000000��6+    � Offset$	 0.0Q�6;   � 5,      $ #000000��6+   $	 1.0Q�6;   5-       5/        50      $ 10Q�6+   $ 0Q�6;   $ #000000��6K   $	 0.5Q�6[   ��52      �� 53       �� 
TargetType" ��6*   .R�54      �� #��z��6%   $ 20��6O   ._�55   "   �� $��Center=�63   $��Center=�6P   56       �� Triggers 57      P� 58   "    P� Property �@J�IsMouseOver P� Value$
 True��6A   . �59   &   ��  �� Property �@J�Effect �� Value 5:   *     5;   .   $ #000000��6?   $ 15Q�6O   $ 0Q�6_   $	 0.7Q�6o   5=   '   5>   #   5@      5B      �� 5E      -   5        $��Member��5E      $��10q�5F      $��16(�6   $
��Bold"�6,   
�������$	��140��5G   $   $��40��60   $��Center=�5H      $��10q�6.   ��5I      �� 5J      $	 0,0&�6.   $	 1,1&�6?   .��5K      � $ #000000��6+   $	 0.0Q�6;   � 5L      $ #000000��6+   $	 1.0Q�6;   5M       5O        5P      $ 10Q�6+   $ 0Q�6;   $ #000000��6K   $	 0.5Q�6[   ��5R      �� 5S      " ��6*   .R�5T      �� #��z��6%   $ 20��6O   ._�5U   "   �� $��Center=�63   $��Center=�6P   5V       5W      P� 5X   "    �@J�IsMouseOver$
 True��6A   . �5Y   &   ��  �@J�Effect 5Z   *     5[   .   $ #1565C0��6?   $ 15Q�6O   $ 0Q�6_   $	 0.7Q�6o   5]   '   5^   #   5`      5b      �� 5g      -   5        $��Logout��5g      $��10q�5h      $��16(�6   $
��Bold"�6,   
�������$	��140��5i   $   $��40��60   $��Center=�5j      $��10q�6.   ��5k      �� 5l      $	 0,0&�6.   $	 1,1&�6?   .��5m      � $ #FF6A6A��6+   $	 0.0Q�6;   � 5n      $ #FF3A3A��6+   $	 1.0Q�6;   5o       5q        5r      $ 10Q�6+   $ 0Q�6;   $ #FF6666��6K   $	 0.5Q�6[   ��5t      �� 5u      " ��6*   .R�5v      �� #��z��6%   $ 20��6O   ._�5w   "   �� $��Center=�63   $��Center=�6P   5x       5y      P� 5z   "    �@J�IsMouseOver$
 True��6A   . �5{   &   ��  �@J�Effect 5|   *     5}   .   $ #FF4D4D��6?   $ 15Q�6O   $ 0Q�6_   $	 0.7Q�6o   5   '   5�   #   5�      5�      5�      5�       � 5�   
   -   5          �Name$ 	MainFrame��5�      $��1��6#     � NavigationUIVisibility$ Hidden=�63   
������ 6S   5�      5�      