   M S B A M L   `   `   `  ����F  BLibraryTry3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:LibraryTry3LibraryTry3  5   	   5clr-namespace:LibraryTry3.ToolsLibraryTry3.Tools  5   	       LibraryTry3.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:LibraryTry3     5   	   1toolsclr-namespace:LibraryTry3.Tools     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466.wpf$http://schemas.fontawesome.io/icons/  5   	   -   5          � Title$  
MainWindow��5
   	    � AllowsTransparency .  � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�6    � 
ResizeMode$ CanResizeWithGrip=�5   	      StyleBorder#��[  6(   $	��600��5   	   $	��600��6    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5   
      ShadowDepth$ 5Q�6      
BlurRadius$ 10Q�6+      Opacity$	 0.6Q�6;   .��5      � 	 � ColumnDefinitions	 5   
   �� 5      $��* �6   �� 5      $��2* �6   �� 5      $��* �6   
 � RowDefinitions
 5   
   �� 5      $��* �6   �� 5      $��3* �6   �� 5       $��5* �6   �� 5!      $��* �6   .+�5$   
   � $��0��6   $��0��5%      $��3��5&        	StyleBack#��[ 5'      .+�5)      ]� $��Center=�6   $��10,0,0,0q�63   .+�5*      "  FontAwesome.WPF.ImageAwesome     Icon$
 Book=�6#   $��30��6/      
Foreground
 �����$
��Left=�6M   6j   �� 5+      -   5        $��lbLib��5+      
�������$��10,0,0,0q�68   .��6J   GLCS-Lib Library Management6h   �� 5,      $��Right=�6    �� Orientation$ 
Horizontal=�69   .+�5-      �� -   5        $��btnMinus��5-      $��0,0,10,0q�6-     TransparentBtn#��[ 5.      .��51        $ Minus=�6+   $��3��68   $��15��6C   
 �����$
��Fill=�6a   6r   52      �� 53      -   5        $��	btnNormal��53      $��0,0,10,0q�6.   #��[ 6@   .��54        $
 File=�6+   $��15��67   
 �����6W   55      �� 56      -   5        $��	0,0, 10,0q�56      #��[ 60   .��57        $ Remove=�6+   $��15��69   
 �����6Y   58      59      5;      5=      � 5>   
   $��1��6   $��1��6   .+�5?      �� $ Vertical=�6   $��Center=�60   .+�5@        $
 Book=�6#   $��30��6/    �#0047a06:   �� 5A      $��Please Login��6   ���#0047a0$��20(�6D   $��SemiBold"�6R   $��Center=�6h   5B      5C      � 5D   
   $��2��6   $��1��6   
 5E      �� 5F      $
��Auto �6    �� 5G      $
��Auto �6    �� 5H      $
��Auto �6    �� 5I      $
��Auto �6    .+�5K      � $��0��6   .+�5L      �� $
��30,0q�6   $ Vertical=�6+   .+�5M      �� $��	User Type��6   ���#0047a06G   �� 5O      -   5        $��comboUserType��5O      $��0,0,0,0q�64   $��36��6E   $��Center=�6Q   .@�5P      �� $��Reader��6'   �� 5Q      $��Administrator��6'   5R      5T      5U      � 5V      $��1��6   .+�5W      �� $
��30,0q�6   $ Vertical=�6,   .+�5X      �� $��ID��6   ���#0047a06@   �� 5Y      -   5        $��txtID��5Y      $��36��6+   $��Center=�67   6[   5Z      5[      � 5\      $��2��6   .+�5]      �� $
��30,0q�6   $ Vertical=�6,   .+�5^      �� $��Password��6   ���#0047a06F   G� 5`      -   5        $��txtPsd��5`   "   $��36��60   $��Center=�6<   6`   5a      5b      � 5c      $��3��6   .+�5d      �� $��
30,30,30,0q�6   $��Bottom=�61   .+�5e      �� $��Forget password?��6   $��10(�68   $
��50,5q�6F     BtnTriggerStyle#��[ 5f      6H   �� 5g      -	   5        $��btnLogin��5g   ]   $��Login��6   $��36��6.     	CustomBtn#��[ 6:   6�   5h      5j      5l      � 5m   
   $��3��6   $��0��6   $��2��6,   $��Bottom=�6@   .+�5n      �� $/��)Wei Chen & Yaguang Liu Copyright reserved��6   $��10(�6L   ���#0047a06q   5o      5q      5r      