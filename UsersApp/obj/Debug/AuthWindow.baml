   M S B A M L   `   `   `  ����C  ?UsersApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:UsersAppUsersApp  5   	       UsersApp.AuthWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:UsersApp     5   	   _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
     � Title$<  6Приложение для пользователей��5	   	   $	��450��6.   $	��800��6;    � Triggers 5      :� 5   
    :� RoutedEvent$ Loaded��6   [�5      �� 5      .��5      ��  �� TargetProperty$ Width�6!    �� 
TargetName$ 
authButton��68   .��5      W�  W� From$ 50X�6*   	 W� To$	 450X�64    g� AutoReverse .  g� RepeatBehavior$ 2x��5   *   	 g� Duration$	 0:0:4D�6>   5      5      5      .��5      � ���#C4B9E1.+�5   
   �� $	��400��6   $��15q�6    
�������$��Center=�6?   
 �� Padding$
 30q�6Z   $	��550��6g    �� CornerRadius$ 20��6v    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 30Q�6#      Color$ 	LightGray��63      ShadowDepth$ 0Q�6E   ._�5      �� .+�5      �� $��Авторизация��6   $��30(�6/   $
��Bold"�6=   $��0 0 0 20q�6O   � 5       $��0 0 0 20q�6   .+�5!      �� -   5        $
��Left=�5!      $��Регистрация��68   6N   �� 5"      $��Right=�6   $��
Войти��69      MaterialDesignFlatButton#��[  6I   5#      �� 5%      -   5         ��Name$ textBoxLogin��5%      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Введите логин��60    % !MaterialDesignFloatingHintTextBox#��[ 6_   G� 5&      -   5         G�Name$ passBox��5&      $! Введите пароль��6/    ) %MaterialDesignFloatingHintPasswordBox#��[ 6_   �� 5'      -   5         ��Name$ 
authButton��5'      $��
Войти��6-   $��
-1,20,1,20q�6=   6Q   5(      5)      5*      5+      