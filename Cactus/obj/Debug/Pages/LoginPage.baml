   M S B A M L   `   `   `  ����A  =Cactus, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Cactus.PagesCactus.Pages  5          Cactus.Pages.LoginPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Cactus.Pages     5        N� 
Background
  ����� N� Title$ 	LoginPage��5	      .��5      � ���	#FFA9C7A9 � RowDefinitions 5   
   �� 5      $
��199* �6   �� 5      $
��142* �6   �� 5      $
��109* �6    � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� $��1��6   $��0��6%   �� 5   
   $��2��6   $	��Top=�6%   $
��Left=�6=   $	��124��6X   $	��180��6e    �� Orientation$ Vertical=�6q   $��
10,146,0,0q�6�   $��2��6�   .+�5      �� $��
Логин��6   $��0 0 0 5q�6%   �� 5      -   5         ��Name$ txtLogin��5      $��0 0 0 5q�6(   �� 5      $��Пароль��6   $��0 0 0 5q�6&   G� 5      -   5         G�Name$ txtPassword��5      �� 5      $��0 10 0 0q�6   $��Center=�6+   $ 
Horizontal=�6F   $��Center=�6_   .+�5       �� -   5         ��Name$ BtnAuth��5       $��
Войти��6@   
���   �$��0 0 20 0q�6c   $��60��6u   $��1,1,1,1q�6�   
�������6�   �� 5!      -   5        $ BtnAuth_Close��5!      $��Закрыть��6G   ���	#FFFF1414$��60��6p   
�������6{   5"      5#      �� 5$   
   $��/Images/cactusmain.jpg��6   $��-48,-118,133,-118q�60   $��3��6K   $��2��6\    � 5%   
     � NavigationUIVisibility$ Hidden=�6   5&      5'      