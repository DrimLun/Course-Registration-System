   M S B A M L   `   `   `  ����K  GCase_study_test2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Case_study_test2Case_study_test2  5   	   !    Case_study_test2.AddCourses   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Case_study_test2     5   	     � Title$  Student_Add_Section��5   	   $	��700��6%   $
��1400��62   .��5	      � $	��700��6   $
��1400��6   .+�5
   
   �� $��Add Courses��6    �� Left$	 460��6&   
 �� Top$	 192��68   $��40(�6I   $
��Bold"�6W   $
��Left=�6i   $	��Top=�6�   $��	75,43,0,0q�6�   $��54��6�   $	��298��6�   �� 5   
   -   5         ��Name$ txt_course_code��5      $	 532��6+   $	 146��6=    �� TextWrapping$
 Wrap=�6N   $	��664��6b   $��20(�6n   $
��Bold"�6|   $
��Left=�6�   $	��Top=�6�   $��
75,130,0,0q�6�   $��66��6�   �� 5   
   -   5         ��Name$ Search_course_code��5      $��Search��6-   $	 434��6>   $ 35��6P   $��20(�6`   $
��Bold"�6n   $��768,130,507,504q�6�   �� 5   
   -   5        $ 	addCourse��5      $��Add Courses��6$   $��20(�6:   $
��Bold"�6H   $��552,554,700,78q�6r   �� 5   
   -   5        $ closeWindow��5      $��Cancel��6&   $��20(�67   $
��Bold"�6E   $��115,554,1138,78q�6q   �� 5   
   $1��+Double click a course then click add course��6   $��18(�6F   $��442,55,437,568q�6T   �� 5   
   $��Course Code��6   $��15(�6&   $
��Bold"�64   $��873,244,401,390q�6F   �� 5   
   $��Course Name��6   $��15(�6&   $
��Bold"�64   $��873,339,401,329q�6F   �� 5   
   $��Semester��6   $��15(�6#   $
��Bold"�61   $��873,433,437,239q�6C   �� 5   
   -   5        $��txt_show_course_code��5      $��Selected Course Code��6/   $��15(�6K   $��873,272,77,371q�6Y   �� 5   
   -   5        $��txt_show_course_name��5      $��Selected Course Name��6/   $��15(�6K   $��873,371,77,275q�6Y   �� 5   
   -   5        $��txt_show_prereq��5      $��Selected Semester��6*   $��15(�6C   $��873,461,77,183q�6Q   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ grid_Courses��5         	RowHeight$ 40Q�6Z   $��20(�6i   $	��298��6w   $	��666��6�   $ 32��6�   $ 35��6�      
IsReadOnly . $
��Left=�6�   $	��Top=�6�   $��
75,222,0,0q�6�   5"      5#      5$      