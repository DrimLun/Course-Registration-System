   M S B A M L   `   `   `  ����K  GCase_study_test2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Case_study_test2Case_study_test2  5   	   !    Case_study_test2.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Case_study_test2     5   	     � Title$  Student Dashboard��5   	   $	��700��6#   $
��1400��60   .��5	      �� .��5
   
   � $	��700��6   $
��1400��6   .+�5      �� $��Student Dashboard��6    �� Left$	 460��60   
 �� Top$	 192��6B   $��30(�6S   $
��Bold"�6a   $
��Left=�6s   $	��Top=�6�   $��	75,24,0,0q�6�   $��54��6�   $	��298��6�   &   System.Windows.Controls.DataGrid  5      -   5          Name$ grid_Student��5         	RowHeight$ 40Q�6-   $��25(�6<   $��99��6J   $	��804��6V   $ 32��6b   $ 35��6s      
IsReadOnly . $
��Left=�6�   $	��Top=�6�   $��	75,87,0,0q�6�     5      -   5        $ grid_CurrentCourses��5      $ 40Q�6c   $��20(�6r   $	��136��6�   $	��804��6�   $ 32��6�   $ 35��6�    . $
��Left=�6�   $	��Top=�6�   $��
75,266,0,0q�6�     5      -   5        $ grid_AcademicHistory��5      $ 40Q�65   $��20(�6D   $	��133��6R   $	��804��6_    . $
��Left=�6}   $	��Top=�6�   $��
75,541,0,0q�6�   �� 5      $3��-Double click to select a course to be dropped��6   $��18(�6L   $��510,407,516,243q�6Z   �� 5      -   5         ��Name$ btn_EditProfile��5      $��Edit Profile��6.   $��20(�6E   $��Regular"�6S   $��928,107,321,527q�6�   �� 5      -   5        $ btn_AddCourses��5      $��Add Courses��6-   $��20(�6C   $��Regular"�6Q   $��75,429,1174,223q�6�   �� 5      -   5        $ btn_DropCourses��5      $��Drop Selected Course��6.   $��20(�6M   $��Regular"�6[   $��928,293,244,342q�6�   �� 5      -   5        $ btn_Refresh��5      $��Refresh��6*   $��20(�6<   $��Regular"�6J   $��1203,24,46,602q�6y   �� 5      $��Current Courses��6   $��30(�6.   $
��Bold"�6<   $
��Left=�6N   $	��Top=�6i   $��
75,212,0,0q�6�   $��54��6�   $	��298��6�   �� 5      $��Academic History��6   $��30(�6/   $
��Bold"�6=   $
��Left=�6O   $	��Top=�6j   $��
75,482,0,0q�6�   $��54��6�   $	��298��6�   5      5      5      