   M S B A M L   `   `   `  ����L  HPresentationLayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulli9clr-namespace:PresentationLayer.ViewModels.LoginViewModel+PresentationLayer.ViewModels.LoginViewModel  5   	   '    !PresentationLayer.Views.LoginView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Klocal9clr-namespace:PresentationLayer.ViewModels.LoginViewModel     5   	     � Title$  	LoginView��5   	   $	��450��6   $	��950��6(   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��1��6!   $��2��61   $��0 0 0 20q�6E   $��Center=�5      $��64(�61   $��	Helvetica)�6?   AirBnB5      �� 5    
   $��1��6   $��1��6!   $��0 0 0 10q�61   	UserID:5"      �� 5#   
   -   5         ��Name$ userId��5#      $��1��6"   $��2��6/   $	��100��6?   $��0 0 0 10q�6N   ��6`   �� *
username+ �� Mode$ TwoWay=��� 5&   
   $��2��6   $��1��6!   $��0 0 0 10q�61   	Password:5(      �� 5)   
   -   5        $ password��5)      $��2��6$   $��2��61   $	��100��6A   $��0 0 0 10q�6P   ��6b   �� *
password+$ TwoWay=��� 5,   
   -   5         ��Name$ loginButton��5-      $��3��5,      $��1��6   $��2��6.   $
��20 5q�6B   $��Center=�6Q   $��0 0 0 10q�5-   &   ��68   �� *LoginCommand+.��6Y   Log In5/      �� 52   
   $��4��6   $��1��6!   $��
0 105 0 10q�61   	UserID:54      �� 55   
   -   5        $ 	newUserID��55      $��4��6%   $��2��62   $	��100��6B   $��
0 105 0 10q�6Q   ��6e   �� *createusername+$ TwoWay=��� 58   
   $��4��6   $��3��6!   $��20 105 0 10q�61   	Password:5:      �� 5;   
   -   5        $ newPassword��5;      $��4��6'   $��4��64   $	��100��6D   $��140 105 320 10q�6S   ��6k   �� *createpassword+$ TwoWay=��� 5>   
   -   5        $ 
newUserBtn��5?      $��4��5>      $��5��6   $	��100��6.   $��310 95 100 10q�6=   $
��10 5q�6T   $��Center=�6c   $��11(�5?   %   ��63   �� *AddUserCommand+.��6V   Create Account5A      �� 5D   
   $^��Xhttps://cdn.discordapp.com/attachments/758225958309462056/966268847462178826/unknown.png��6   $��1��6r   $��3��6   $��4��6�   $	��200��6�   $	��200��6�   5F      5I      5K      