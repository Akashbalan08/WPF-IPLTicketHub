   M S B A M L   `   `   `  ����J  FWpfIPLTicketHub, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfIPLTicketHubWpfIPLTicketHub  5   	   *    $WpfIPLTicketHub.ForgotPasswordWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfIPLTicketHub     5   	     � Title$  Forgot Password��5   	   $	��700��6!   $
��1000��6.   
���   � � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � .+�5   
   �� $��/Images/IPLTB_01.PNG��6   $	��200��5      $	��200��6   $
��Left=�5      $	��Top=�5      �� 5   
   $��/Images/IPLTB_02.PNG��6   $	��686��5      $	��200��6   $��Center=�5      $	��Top=�5      $��	200,0,0,0q�6(   �� 5   
   $"��Forgot Password? Reset Below��6   
�������$��20(�5      $��
10,132,0,0q�5      $��Center=�5      $	��Top=�5      � 5   
   $��
10,183,0,0q�6   $��Center=�6#   $	��Top=�6@   $	��388��6X   $	��317��6d    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $��* �6#    � RowDefinitions 5!      �� 5"      $
��Auto �6    �� 5#      $
��Auto �6    �� 5$      $
��Auto �6    �� 5%      $
��Auto �6    �� 5&      $
��Auto �6    �� 5'      $
��Auto �6    �� 5(      $
��Auto �6    �� 5)      $
��Auto �6    �� 5*      $
��Auto �6    .+�5-      �� $��Email��6   
�������$��14(�68   $��3��6F   $��0��6S   $	��0,5q�6c   �� 5.      -   5         ��Name$ EmailTextBox��5.      $	��200��6,   $��3��68   $��1��6E   $��5q�6U   �� 50      $��New Password��6   
�������$��14(�6?   $��4��6M   $��0��6Z   $	��0,5q�6j   G� 51      -   5         G�Name$ PasswordTextBox��51      $	��200��63   $��4��6?   $��1��6L   $��5q�6\   �� 53      $��Confirm Password��6   
�������$��14(�6C   $��5��6Q   $��0��6^   $	��0,5q�6n   G� 54      -   5        $ ConfirmPasswordTextBox��54      $	��200��6:   $��5��6F   $��1��6S   $��5q�6c   �� 56      
�������$��14(�6+   $��6��69   $��0��6F   $	��0,5q�6V   �� 6d   $�Security Question ��6h   �� 6�   �� 6�   $�Fav color+Year of Birth ��6�   �� 6�   �� 6�   $�(all small letters)��6�   6�   �� 57      -   5        $ SecurityQuestionTextBox��57      $	��200��67   $��6��6C   $��1��6P   $��
22,5,22,47q�6`   �� 59      -   5        $��Reset Password��59      $��94��6.   $��	0,45,0,10q�69   $��7��6L   $
��Left=�6Y   $��1��6t   
����  �
�������6�   �� 5;      -   5        $��	Home Page��5;      $��94��6)   $��	0,10,0,10q�64   $��8��6G   $
��Left=�6T   $��1��6o   
����  �
�������6�   5<      5=      5>      