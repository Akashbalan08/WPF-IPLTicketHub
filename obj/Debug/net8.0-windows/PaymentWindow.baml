   M S B A M L   `   `   `  ����J  FWpfIPLTicketHub, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfIPLTicketHubWpfIPLTicketHub  5   	   #    WpfIPLTicketHub.PaymentWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfIPLTicketHub     5   	     � Title$  Payment��5   	   $	��700��6   $
��1000��6&   
���   � � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � .+�5   
   �� $��/Images/IPLTB_01.PNG��6   $	��200��5      $	��200��6   $
��Left=�5      $	��Top=�5      �� 5   
   $��/Images/IPLTB_02.PNG��6   $	��686��5      $	��200��6   $��Center=�5      $	��Top=�5      $��	200,0,0,0q�6(   �� 5   
   $)��#Enter the payment information below��6   $��20(�5      
����  �$��Center=�5      $	��Top=�5      $��	0,150,0,0q�5      � 5   
   $��Center=�6   $	��Top=�6,   $��	0,200,0,0q�6D   $	��229��6W    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5       $
��Auto �6    �� 5!      $
��Auto �6     � ColumnDefinitions 5#      �� 5$      $
��Auto �6#   �� 5%      $	��200 �6#   .+�5)      �� $��Card Number:��6   $��18(�5*      
�������$��Center=�5,      $��5q�63   �� 5-      -   5         ��Name$ CardNumberTextBox��5-      $��1��5.      $	��200��5/      $��5q�50       �� 	MaxLength$ 16��52      �� 55      $
��CVV:��6   $��1��56      $��18(�57      
�������$��Center=�59      $��5q�63   G� 5:      -   5         G�Name$ 
CVVTextBox��5:      $��1��5;      $��1��5<      $	��200��5=      $��5q�5>       G� 	MaxLength$ 3��5@      �� 5C      $��Expiry Date (MM/YY):��6   $��2��5D      $��18(�5E      
�������$��Center=�5G      $��5q�63   �� 5H      -   5        $ ExpiryDateTextBox��5H      $��2��5I      $��1��5J      $	��200��5K      $��5q�5L      $ 4��5N      �� 5Q      -   5        $��Pay Now��5Q      $��3��5R      $��2��5S      $	��119��5T      $
��Left=�5U      $��130,29,0,-66q�5V      
����  �
�������5Y      5Z      5[      5\      